using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOffice.ATG;

namespace StoreOffice
{
    public class DomainHelper
    {
        private static ArticleInfoArticleDetailsClassification classification;
        private static ArticleInfoArticleDetailsCostPrice costPrice;
        private static ArticleInfoArticleDetailsPrice price;
        private static ArticleInfoArticleDetailsLabelInfo labelInfo;
        //private static bool isFruit = false;

        static DomainHelper()
        {
            classification = new ArticleInfoArticleDetailsClassification();
            ArticleInfoArticleDetailsClassificationDepartment department = new ArticleInfoArticleDetailsClassificationDepartment();
            //department.Name = "Kött och bilar";
            department.Number = 42;
            department.IsNumberSpecified = true;
            classification.Department = department;

            costPrice = new ArticleInfoArticleDetailsCostPrice();
            costPrice.CurrentOrdinaryCostPrice = "123";
            costPrice.IsCurrentOrdinaryCostPriceSpecified = true;
            //costPrice.PromotionCostPrice = "123";

            price = new ArticleInfoArticleDetailsPrice();
            price.CurrentOrdinaryPrice = "123";


        }

        public static ArticleInfoArticleDetailsClassification Classification
        {
            get { return classification; }
        }

        public static ArticleInfoArticleDetailsCostPrice CostPrice
        {
            get { return costPrice; }
        }

        public static ArticleInfoArticleDetailsPrice Price
        {
            get { return price; }
        }

        public static ArticleInfoArticleDetailsLabelInfo GetLabelInfo(StoreItem item)
        {
            labelInfo = new ArticleInfoArticleDetailsLabelInfo();
            labelInfo.IsCountryOfOriginSpecified = true;

            if (item.CountryCode == string.Empty || item.CountryCode.Equals("NULL"))
            {
                labelInfo.IsCountryOfOriginSpecified = false;
            }
            else
            {
                labelInfo.CountryOfOrigin = item.CountryCode;
            }

            return labelInfo;
        }

        public static bool CheckGTIN(string gtin)
        {
            gtin = gtin.Substring(0, 4);

            if (gtin.Contains("2092") || gtin.Contains("2098"))
            {
                //isFruit = true;
                return true;
            }

            //isFruit = false;
            return false;
        }
    }
}

