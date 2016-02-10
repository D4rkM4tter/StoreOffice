using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StoreOffice.Nathandel;
using StoreOffice.ATG;
using StoreOffice.csv;
using System.Reflection;


namespace StoreOffice
{
    public class Program
    {
        public static List<StoreItem> items = new List<StoreItem>();
        public static string inputFileName = "";
        public static string outputFileName = "output.xml";
        static void Main(string[] args)
        {
            try
            {
                if(args == null || args.Length == 0)
                {
                    Console.WriteLine("ICA Online Store Office Xml generator utility version 0.1.");
                    Console.WriteLine("Warning : No arguments specified.");
                    Console.WriteLine();
                    Console.WriteLine("/in - Input file (csv) that contains orginal data must be specified.");
                    Console.WriteLine();
                    Console.WriteLine("/out - Output file could be specified. If not provided default output.xml will be used.");
                    Console.WriteLine();
                    Console.WriteLine("Exampel 1: /in data.csv");
                    Console.WriteLine();
                    Console.WriteLine("Exampel 2: /in data.csv /out Rilles_store.xml");
                }
                else
                {
                    if(args.Length == 2)
                    {
                        inputFileName = args[1];
                    }
                    else
                    {
                        inputFileName = args[1];
                        outputFileName = args[3];
                    }

                    //@"C:\dev\OneDrive\Development\DemoStore\Storeloader\data\csv\demo_store.csv"
                    ReadCsvFile(inputFileName);
                    WriteFile(outputFileName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// Read the csv file containing the GTINs and Country.
        /// </summary>
        /// <returns></returns>
        public static List<StoreItem> ReadCsvFile(string path)
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
                }
            }

            return items;
        }

        public static void WriteFile(string filename)
        {
            ArticleInfo articleInfo = GetArticles();
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
