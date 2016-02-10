
using System.Xml.Serialization;

namespace StoreOffice.ATG
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ArticleInfo
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArticleDetails")]
        public ArticleInfoArticleDetails[] ArticleDetails
        {
            get { return this.articleDetails; }
            set { this.articleDetails = value; }
        }
        private ArticleInfoArticleDetails[] articleDetails;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArticleInfoType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        private ArticleInfoType type;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArticleInfoArticleDetails
    {
        public string GTIN
        {
            get { return this.gtin; }
            set { this.gtin = value; }
        }
        private string gtin;

        /// <remarks/>
        public int RemovedArticleFlag
        {
            get { return this.removedArticleFlag; }
            set { this.removedArticleFlag = value; }
        }
        private int removedArticleFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRemovedArticleFlagSpecified
        {
            get { return this.isRemovedArticleFlagSpecified; }
            set { this.isRemovedArticleFlagSpecified = value; }
        }
        private bool isRemovedArticleFlagSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GTIN", IsNullable = false)]
        public string[] ConnectGTIN
        {
            get { return this.connectGTIN; }
            set { this.connectGTIN = value; }
        }
        private string[] connectGTIN;

        /// <remarks/>
        public int OnLineShoppingFlag
        {
            get { return this.onLineShoppingFlag; }
            set { this.onLineShoppingFlag = value; }
        }
        private int onLineShoppingFlag;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsOnLineShoppingFlagSpecified
        {
            get { return this.isOnLineShoppingFlagSpecified; }
            set { this.isOnLineShoppingFlagSpecified = value; }
        }
        private bool isOnLineShoppingFlagSpecified;

        /// <remarks/>
        public ArticleInfoArticleDetailsClassification Classification
        {
            get { return this.classification; }
            set { this.classification = value; }
        }
        private ArticleInfoArticleDetailsClassification classification;

        /// <remarks/>
        public ArticleInfoArticleDetailsCostPrice CostPrice
        {
            get { return this.costPrice; }
            set { this.costPrice = value; }
        }
        private ArticleInfoArticleDetailsCostPrice costPrice;

        /// <remarks/>
        public ArticleInfoArticleDetailsPrice Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        private ArticleInfoArticleDetailsPrice price;

        /// <remarks/>
        public ArticleInfoArticleDetailsLabelInfo LabelInfo
        {
            get { return this.labelInfo; }
            set { this.labelInfo = value; }
        }
        private ArticleInfoArticleDetailsLabelInfo labelInfo;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArticleInfoArticleDetailsClassification
    {
        public ArticleInfoArticleDetailsClassificationDepartment Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        private ArticleInfoArticleDetailsClassificationDepartment department;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArticleInfoArticleDetailsClassificationDepartment
    {
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        private int number;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsNumberSpecified
        {
            get { return this.isNumberSpecified; }
            set { this.isNumberSpecified = value; }
        }
        private bool isNumberSpecified;

        /// <remarks/>
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
        private string nameField;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArticleInfoArticleDetailsCostPrice
    { 
        public string CurrentOrdinaryCostPrice
        {
            get { return this.currentOrdinaryCostPrice; }
            set { this.currentOrdinaryCostPrice = value; }
        }
        private string currentOrdinaryCostPrice;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCurrentOrdinaryCostPriceSpecified
        {
            get { return this.isCurrentOrdinaryCostPriceSpecified; }
            set { this.isCurrentOrdinaryCostPriceSpecified = value; }
        }
        private bool isCurrentOrdinaryCostPriceSpecified;

        /// <remarks/>
        public string PromotionCostPrice
        {
            get { return this.promotionCostPrice; }
            set { this.promotionCostPrice = value; }
        }
        private string promotionCostPrice;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPromotionCostPriceSpecified
        {
            get { return this.isPromotionCostPriceSpecified; }
            set { this.isPromotionCostPriceSpecified = value; }
        }
        private bool isPromotionCostPriceSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArticleInfoArticleDetailsPrice
    {
        public string CurrentOrdinaryPrice
        {
            get { return this.currentOrdinaryPrice; }
            set { this.currentOrdinaryPrice = value; }
        }
        private string currentOrdinaryPrice;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ArticleInfoArticleDetailsLabelInfo
    {
        /// <remarks/>
        public string CountryOfOrigin
        {
            get { return this.countryOfOrigin; }
            set { this.countryOfOrigin = value; }
        }
        private string countryOfOrigin;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCountryOfOriginSpecified
        {
            get { return this.isCountryOfOriginSpecified; }
            set { this.isCountryOfOriginSpecified = value; }
        }
        private bool isCountryOfOriginSpecified;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ArticleInfoType
    {

        /// <remarks/>
        Total,

        /// <remarks/>
        Dagslut,

        /// <remarks/>
        Manuell,
    }
}