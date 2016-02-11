using System;
using System.Collections.Generic;
//using StoreOffice.Nathandel;
using StoreOffice.ATG;
using StoreOffice.csv;
using StoreOffice.Util;
using CommandLine;
//using CommandLine.Text;

namespace StoreOffice
{
    public class Program
    {
        public static List<StoreItem> items = new List<StoreItem>();
        static void Main(string[] args)
        {
            ArgumentOptions options = new ArgumentOptions();
            Parser parser = new Parser((new ParserSettings {IgnoreUnknownArguments = false, CaseSensitive = false, HelpWriter = Console.Error }));
            var result = parser.ParseArguments(args, options);

            if (options.Help || args.Length == 0)
            {
                Console.Error.Write(options.GetUsage());
            }

            try
            {
                //@"C:\dev\OneDrive\Development\DemoStore\Storeloader\data\csv\demo_store.csv"

                if (options.Verbose) { Console.WriteLine("Reading CSV file..."); }
                ReadCsvFile(options.InputFile, options.Verbose);

                if(options.Verbose) { Console.WriteLine("Writing Store Office Xml..."); }
                WriteFile(options.OutputFile, options.Verbose);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            if(options.Verbose) { Console.WriteLine("Operation completed succesfully!"); }
        }

        /// <summary>
        /// Read the csv file containing the GTINs and Country.
        /// </summary>
        /// <returns></returns>
        public static List<StoreItem> ReadCsvFile(string path, bool verbose)
        {
            using (CsvFileReader reader = new CsvFileReader(path))
            {
                CsvRow row = new CsvRow();

                while (reader.ReadRow(row))
                {
                    StoreItem item = new StoreItem();
                    item.GTIN = row[0];

                    if (row.Count > 1)
                        item.CountryCode = row[1];

                    items.Add(item);
                    if (verbose) { Console.WriteLine("CSV row: {0}, {1}", item.GTIN, item.CountryCode); }
                }
            }

            return items;
        }

        public static void WriteFile(string filename, bool verbose)
        {
            ArticleInfo articleInfo = GetArticles();
            if (verbose) { Console.WriteLine("{0} number of articles ready to serialize to disk.", articleInfo.ArticleDetails.Length); }
            SerializationHelper.XMLSerializeToFile(articleInfo, filename);
        }


        private static ArticleInfo GetArticles()
        {
            ArticleInfo articleInfo = new ArticleInfo();
            articleInfo.ArticleDetails = GetArticleDetails(true);
            return articleInfo;
        }

        private static ArticleInfoArticleDetails[] GetArticleDetails(bool csv)
        {
            List<ArticleInfoArticleDetails> articleDetailsList = new List<ArticleInfoArticleDetails>();
            ArticleInfoArticleDetails articleDetail;

            foreach (StoreItem item in items)
            {
                articleDetail = new ArticleInfoArticleDetails();
                articleDetail.GTIN = item.GTIN;
                articleDetail.RemovedArticleFlag = 0; //
                articleDetail.IsRemovedArticleFlagSpecified = true;
                articleDetail.OnLineShoppingFlag = 1; //
                articleDetail.IsOnLineShoppingFlagSpecified = true;
                articleDetail.Classification = DomainHelper.Classification;
                articleDetail.CostPrice = DomainHelper.CostPrice;
                articleDetail.Price = DomainHelper.Price;
                articleDetail.LabelInfo = DomainHelper.GetLabelInfo(item);

                articleDetailsList.Add(articleDetail);
            }

            return articleDetailsList.ToArray();
        }



        //static void ReadXmlFile()
        //{
        //    string path = @"C:\Users\Oscar\OneDrive\Development\StoreOfficeTest\StoreOfficeTest\xml\OLS2235100520150408144046.xml";
        //    object obj = SerializationHelper.XMLDeserializeFromFile(typeof(ArticleInfo), path);
        //}
    }
}
