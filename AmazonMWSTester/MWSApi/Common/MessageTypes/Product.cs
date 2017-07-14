using AmazonMWSTester.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AmazonMWSTester.MWSApi.Common.MessageTypes
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Product
	{ 
		private string sKUField;

		private StandardProductID standardProductIDField;

		private ProductGtinExemptionReason gtinExemptionReasonField;

		private bool gtinExemptionReasonFieldSpecified;

		private RelatedProductID relatedProductIDField;

		private string productTaxCodeField;

		private System.DateTime launchDateField;

		private bool launchDateFieldSpecified;

		private System.DateTime discontinueDateField;

		private bool discontinueDateFieldSpecified;

		private System.DateTime releaseDateField;

		private bool releaseDateFieldSpecified;

		private string externalProductUrlField;

		private ProductOffAmazonChannel offAmazonChannelField;

		private bool offAmazonChannelFieldSpecified;

		private ProductOnAmazonChannel onAmazonChannelField;

		private bool onAmazonChannelFieldSpecified;

		private ConditionInfo conditionField;

		private RebateType[] rebateField;

		private string itemPackageQuantityField;

		private string numberOfItemsField;

		private VolumeDimension liquidVolumeField;

		private ProductDescriptionData descriptionDataField;

		private ProductPromoTag promoTagField;

		private ProductDiscoveryData discoveryDataField;

		private ProductProductData productDataField;

		private bool shippedByFreightField;

		private bool shippedByFreightFieldSpecified;

		private string[] enhancedImageURLField;

		private AmazonVendorOnly amazonVendorOnlyField;
	
		private AmazonOnly amazonOnlyField;

		private ProductRegisteredParameter registeredParameterField;

		private bool registeredParameterFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string SKU
		{
			get
			{
				return this.sKUField;
			}
			set
			{
				this.sKUField = value;
			}
		}

		/// <remarks/>
		public StandardProductID StandardProductID
		{
			get
			{
				return this.standardProductIDField;
			}
			set
			{
				this.standardProductIDField = value;
			}
		}

		/// <remarks/>
		public ProductGtinExemptionReason GtinExemptionReason
		{
			get
			{
				return this.gtinExemptionReasonField;
			}
			set
			{
				this.gtinExemptionReasonField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool GtinExemptionReasonSpecified
		{
			get
			{
				return this.gtinExemptionReasonFieldSpecified;
			}
			set
			{
				this.gtinExemptionReasonFieldSpecified = value;
			}
		}

		/// <remarks/>
		public RelatedProductID RelatedProductID
		{
			get
			{
				return this.relatedProductIDField;
			}
			set
			{
				this.relatedProductIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string ProductTaxCode
		{
			get
			{
				return this.productTaxCodeField;
			}
			set
			{
				this.productTaxCodeField = value;
			}
		}

		/// <remarks/>
		public System.DateTime LaunchDate
		{
			get
			{
				return this.launchDateField;
			}
			set
			{
				this.launchDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool LaunchDateSpecified
		{
			get
			{
				return this.launchDateFieldSpecified;
			}
			set
			{
				this.launchDateFieldSpecified = value;
			}
		}

		/// <remarks/>
		public System.DateTime DiscontinueDate
		{
			get
			{
				return this.discontinueDateField;
			}
			set
			{
				this.discontinueDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DiscontinueDateSpecified
		{
			get
			{
				return this.discontinueDateFieldSpecified;
			}
			set
			{
				this.discontinueDateFieldSpecified = value;
			}
		}

		/// <remarks/>
		public System.DateTime ReleaseDate
		{
			get
			{
				return this.releaseDateField;
			}
			set
			{
				this.releaseDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ReleaseDateSpecified
		{
			get
			{
				return this.releaseDateFieldSpecified;
			}
			set
			{
				this.releaseDateFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
		public string ExternalProductUrl
		{
			get
			{
				return this.externalProductUrlField;
			}
			set
			{
				this.externalProductUrlField = value;
			}
		}

		/// <remarks/>
		public ProductOffAmazonChannel OffAmazonChannel
		{
			get
			{
				return this.offAmazonChannelField;
			}
			set
			{
				this.offAmazonChannelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool OffAmazonChannelSpecified
		{
			get
			{
				return this.offAmazonChannelFieldSpecified;
			}
			set
			{
				this.offAmazonChannelFieldSpecified = value;
			}
		}

		/// <remarks/>
		public ProductOnAmazonChannel OnAmazonChannel
		{
			get
			{
				return this.onAmazonChannelField;
			}
			set
			{
				this.onAmazonChannelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool OnAmazonChannelSpecified
		{
			get
			{
				return this.onAmazonChannelFieldSpecified;
			}
			set
			{
				this.onAmazonChannelFieldSpecified = value;
			}
		}

		/// <remarks/>
		public ConditionInfo Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Rebate")]
		public RebateType[] Rebate
		{
			get
			{
				return this.rebateField;
			}
			set
			{
				this.rebateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string ItemPackageQuantity
		{
			get
			{
				return this.itemPackageQuantityField;
			}
			set
			{
				this.itemPackageQuantityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string NumberOfItems
		{
			get
			{
				return this.numberOfItemsField;
			}
			set
			{
				this.numberOfItemsField = value;
			}
		}

		/// <remarks/>
		public VolumeDimension LiquidVolume
		{
			get
			{
				return this.liquidVolumeField;
			}
			set
			{
				this.liquidVolumeField = value;
			}
		}

		/// <remarks/>
		public ProductDescriptionData DescriptionData
		{
			get
			{
				return this.descriptionDataField;
			}
			set
			{
				this.descriptionDataField = value;
			}
		}

		/// <remarks/>
		public ProductPromoTag PromoTag
		{
			get
			{
				return this.promoTagField;
			}
			set
			{
				this.promoTagField = value;
			}
		}

		/// <remarks/>
		public ProductDiscoveryData DiscoveryData
		{
			get
			{
				return this.discoveryDataField;
			}
			set
			{
				this.discoveryDataField = value;
			}
		}

		/// <remarks/>
		public ProductProductData ProductData
		{
			get
			{
				return this.productDataField;
			}
			set
			{
				this.productDataField = value;
			}
		}

		/// <remarks/>
		public bool ShippedByFreight
		{
			get
			{
				return this.shippedByFreightField;
			}
			set
			{
				this.shippedByFreightField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ShippedByFreightSpecified
		{
			get
			{
				return this.shippedByFreightFieldSpecified;
			}
			set
			{
				this.shippedByFreightFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EnhancedImageURL", DataType = "anyURI")]
		public string[] EnhancedImageURL
		{
			get
			{
				return this.enhancedImageURLField;
			}
			set
			{
				this.enhancedImageURLField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Amazon-Vendor-Only")]
		public AmazonVendorOnly AmazonVendorOnly
		{
			get
			{
				return this.amazonVendorOnlyField;
			}
			set
			{
				this.amazonVendorOnlyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Amazon-Only")]
		public AmazonOnly AmazonOnly
		{
			get
			{
				return this.amazonOnlyField;
			}
			set
			{
				this.amazonOnlyField = value;
			}
		}

		/// <remarks/>
		public ProductRegisteredParameter RegisteredParameter
		{
			get
			{
				return this.registeredParameterField;
			}
			set
			{
				this.registeredParameterField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RegisteredParameterSpecified
		{
			get
			{
				return this.registeredParameterFieldSpecified;
			}
			set
			{
				this.registeredParameterFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductGtinExemptionReason
	{

		/// <remarks/>
		bundle,

		/// <remarks/>
		part,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductOffAmazonChannel
	{

		/// <remarks/>
		advertise,

		/// <remarks/>
		exclude,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductOnAmazonChannel
	{

		/// <remarks/>
		sell,

		/// <remarks/>
		advertise,

		/// <remarks/>
		exclude,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ProductDescriptionData
	{

		private string titleField;

		private string brandField;

		private string designerField;

		private string descriptionField;

		private string[] bulletPointField;

		private Dimensions itemDimensionsField;

		private Dimensions packageDimensionsField;

		private PositiveWeightDimension packageWeightField;

		private PositiveWeightDimension shippingWeightField;

		private string merchantCatalogNumberField;

		private CurrencyAmount mSRPField;

		private CurrencyAmount mSRPWithTaxField;

		private string maxOrderQuantityField;

		private bool serialNumberRequiredField;

		private bool serialNumberRequiredFieldSpecified;

		private bool prop65Field;

		private bool prop65FieldSpecified;

		private ProductDescriptionDataCPSIAWarning[] cPSIAWarningField;

		private string cPSIAWarningDescriptionField;

		private string legalDisclaimerField;

		private string manufacturerField;

		private string mfrPartNumberField;

		private string[] searchTermsField;

		private string[] platinumKeywordsField;

		private bool memorabiliaField;

		private bool memorabiliaFieldSpecified;

		private bool autographedField;

		private bool autographedFieldSpecified;

		private string[] usedForField;

		private string itemTypeField;

		private string[] otherItemAttributesField;

		private string[] targetAudienceField;

		private string[] subjectContentField;

		private bool isGiftWrapAvailableField;

		private bool isGiftWrapAvailableFieldSpecified;

		private bool isGiftMessageAvailableField;

		private bool isGiftMessageAvailableFieldSpecified;

		private string[] promotionKeywordsField;

		private bool isDiscontinuedByManufacturerField;

		private bool isDiscontinuedByManufacturerFieldSpecified;

		private string deliveryScheduleGroupIDField;

		private DeliveryChannel[] deliveryChannelField;

		private ProductDescriptionDataPurchasingChannel[] purchasingChannelField;

		private string maxAggregateShipQuantityField;

		private bool isCustomizableField;

		private bool isCustomizableFieldSpecified;

		private string customizableTemplateNameField;

		private string[] recommendedBrowseNodeField;

		private string merchantShippingGroupNameField;

		private string fEDAS_IDField;

		private ProductDescriptionDataTSDAgeWarning tSDAgeWarningField;

		private bool tSDAgeWarningFieldSpecified;

		private ProductDescriptionDataTSDWarning[] tSDWarningField;

		private ProductDescriptionDataTSDLanguage[] tSDLanguageField;

		private ProductDescriptionDataOptionalPaymentTypeExclusion[] optionalPaymentTypeExclusionField;

		private DistributionDesignationValues distributionDesignationField;

		private bool distributionDesignationFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Brand
		{
			get
			{
				return this.brandField;
			}
			set
			{
				this.brandField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Designer
		{
			get
			{
				return this.designerField;
			}
			set
			{
				this.designerField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("BulletPoint", DataType = "normalizedString")]
		public string[] BulletPoint
		{
			get
			{
				return this.bulletPointField;
			}
			set
			{
				this.bulletPointField = value;
			}
		}

		/// <remarks/>
		public Dimensions ItemDimensions
		{
			get
			{
				return this.itemDimensionsField;
			}
			set
			{
				this.itemDimensionsField = value;
			}
		}

		/// <remarks/>
		public Dimensions PackageDimensions
		{
			get
			{
				return this.packageDimensionsField;
			}
			set
			{
				this.packageDimensionsField = value;
			}
		}

		/// <remarks/>
		public PositiveWeightDimension PackageWeight
		{
			get
			{
				return this.packageWeightField;
			}
			set
			{
				this.packageWeightField = value;
			}
		}

		/// <remarks/>
		public PositiveWeightDimension ShippingWeight
		{
			get
			{
				return this.shippingWeightField;
			}
			set
			{
				this.shippingWeightField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MerchantCatalogNumber
		{
			get
			{
				return this.merchantCatalogNumberField;
			}
			set
			{
				this.merchantCatalogNumberField = value;
			}
		}

		/// <remarks/>
		public CurrencyAmount MSRP
		{
			get
			{
				return this.mSRPField;
			}
			set
			{
				this.mSRPField = value;
			}
		}

		/// <remarks/>
		public CurrencyAmount MSRPWithTax
		{
			get
			{
				return this.mSRPWithTaxField;
			}
			set
			{
				this.mSRPWithTaxField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string MaxOrderQuantity
		{
			get
			{
				return this.maxOrderQuantityField;
			}
			set
			{
				this.maxOrderQuantityField = value;
			}
		}

		/// <remarks/>
		public bool SerialNumberRequired
		{
			get
			{
				return this.serialNumberRequiredField;
			}
			set
			{
				this.serialNumberRequiredField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SerialNumberRequiredSpecified
		{
			get
			{
				return this.serialNumberRequiredFieldSpecified;
			}
			set
			{
				this.serialNumberRequiredFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool Prop65
		{
			get
			{
				return this.prop65Field;
			}
			set
			{
				this.prop65Field = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool Prop65Specified
		{
			get
			{
				return this.prop65FieldSpecified;
			}
			set
			{
				this.prop65FieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("CPSIAWarning")]
		public ProductDescriptionDataCPSIAWarning[] CPSIAWarning
		{
			get
			{
				return this.cPSIAWarningField;
			}
			set
			{
				this.cPSIAWarningField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string CPSIAWarningDescription
		{
			get
			{
				return this.cPSIAWarningDescriptionField;
			}
			set
			{
				this.cPSIAWarningDescriptionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string LegalDisclaimer
		{
			get
			{
				return this.legalDisclaimerField;
			}
			set
			{
				this.legalDisclaimerField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string Manufacturer
		{
			get
			{
				return this.manufacturerField;
			}
			set
			{
				this.manufacturerField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MfrPartNumber
		{
			get
			{
				return this.mfrPartNumberField;
			}
			set
			{
				this.mfrPartNumberField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SearchTerms", DataType = "normalizedString")]
		public string[] SearchTerms
		{
			get
			{
				return this.searchTermsField;
			}
			set
			{
				this.searchTermsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlatinumKeywords", DataType = "normalizedString")]
		public string[] PlatinumKeywords
		{
			get
			{
				return this.platinumKeywordsField;
			}
			set
			{
				this.platinumKeywordsField = value;
			}
		}

		/// <remarks/>
		public bool Memorabilia
		{
			get
			{
				return this.memorabiliaField;
			}
			set
			{
				this.memorabiliaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MemorabiliaSpecified
		{
			get
			{
				return this.memorabiliaFieldSpecified;
			}
			set
			{
				this.memorabiliaFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool Autographed
		{
			get
			{
				return this.autographedField;
			}
			set
			{
				this.autographedField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool AutographedSpecified
		{
			get
			{
				return this.autographedFieldSpecified;
			}
			set
			{
				this.autographedFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("UsedFor", DataType = "normalizedString")]
		public string[] UsedFor
		{
			get
			{
				return this.usedForField;
			}
			set
			{
				this.usedForField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string ItemType
		{
			get
			{
				return this.itemTypeField;
			}
			set
			{
				this.itemTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OtherItemAttributes", DataType = "normalizedString")]
		public string[] OtherItemAttributes
		{
			get
			{
				return this.otherItemAttributesField;
			}
			set
			{
				this.otherItemAttributesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TargetAudience", DataType = "normalizedString")]
		public string[] TargetAudience
		{
			get
			{
				return this.targetAudienceField;
			}
			set
			{
				this.targetAudienceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("SubjectContent", DataType = "normalizedString")]
		public string[] SubjectContent
		{
			get
			{
				return this.subjectContentField;
			}
			set
			{
				this.subjectContentField = value;
			}
		}

		/// <remarks/>
		public bool IsGiftWrapAvailable
		{
			get
			{
				return this.isGiftWrapAvailableField;
			}
			set
			{
				this.isGiftWrapAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsGiftWrapAvailableSpecified
		{
			get
			{
				return this.isGiftWrapAvailableFieldSpecified;
			}
			set
			{
				this.isGiftWrapAvailableFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool IsGiftMessageAvailable
		{
			get
			{
				return this.isGiftMessageAvailableField;
			}
			set
			{
				this.isGiftMessageAvailableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsGiftMessageAvailableSpecified
		{
			get
			{
				return this.isGiftMessageAvailableFieldSpecified;
			}
			set
			{
				this.isGiftMessageAvailableFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PromotionKeywords", DataType = "normalizedString")]
		public string[] PromotionKeywords
		{
			get
			{
				return this.promotionKeywordsField;
			}
			set
			{
				this.promotionKeywordsField = value;
			}
		}

		/// <remarks/>
		public bool IsDiscontinuedByManufacturer
		{
			get
			{
				return this.isDiscontinuedByManufacturerField;
			}
			set
			{
				this.isDiscontinuedByManufacturerField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsDiscontinuedByManufacturerSpecified
		{
			get
			{
				return this.isDiscontinuedByManufacturerFieldSpecified;
			}
			set
			{
				this.isDiscontinuedByManufacturerFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string DeliveryScheduleGroupID
		{
			get
			{
				return this.deliveryScheduleGroupIDField;
			}
			set
			{
				this.deliveryScheduleGroupIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("DeliveryChannel")]
		public DeliveryChannel[] DeliveryChannel
		{
			get
			{
				return this.deliveryChannelField;
			}
			set
			{
				this.deliveryChannelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PurchasingChannel")]
		public ProductDescriptionDataPurchasingChannel[] PurchasingChannel
		{
			get
			{
				return this.purchasingChannelField;
			}
			set
			{
				this.purchasingChannelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string MaxAggregateShipQuantity
		{
			get
			{
				return this.maxAggregateShipQuantityField;
			}
			set
			{
				this.maxAggregateShipQuantityField = value;
			}
		}

		/// <remarks/>
		public bool IsCustomizable
		{
			get
			{
				return this.isCustomizableField;
			}
			set
			{
				this.isCustomizableField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsCustomizableSpecified
		{
			get
			{
				return this.isCustomizableFieldSpecified;
			}
			set
			{
				this.isCustomizableFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string CustomizableTemplateName
		{
			get
			{
				return this.customizableTemplateNameField;
			}
			set
			{
				this.customizableTemplateNameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("RecommendedBrowseNode", DataType = "positiveInteger")]
		public string[] RecommendedBrowseNode
		{
			get
			{
				return this.recommendedBrowseNodeField;
			}
			set
			{
				this.recommendedBrowseNodeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string MerchantShippingGroupName
		{
			get
			{
				return this.merchantShippingGroupNameField;
			}
			set
			{
				this.merchantShippingGroupNameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string FEDAS_ID
		{
			get
			{
				return this.fEDAS_IDField;
			}
			set
			{
				this.fEDAS_IDField = value;
			}
		}

		/// <remarks/>
		public ProductDescriptionDataTSDAgeWarning TSDAgeWarning
		{
			get
			{
				return this.tSDAgeWarningField;
			}
			set
			{
				this.tSDAgeWarningField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TSDAgeWarningSpecified
		{
			get
			{
				return this.tSDAgeWarningFieldSpecified;
			}
			set
			{
				this.tSDAgeWarningFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TSDWarning")]
		public ProductDescriptionDataTSDWarning[] TSDWarning
		{
			get
			{
				return this.tSDWarningField;
			}
			set
			{
				this.tSDWarningField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TSDLanguage")]
		public ProductDescriptionDataTSDLanguage[] TSDLanguage
		{
			get
			{
				return this.tSDLanguageField;
			}
			set
			{
				this.tSDLanguageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("OptionalPaymentTypeExclusion")]
		public ProductDescriptionDataOptionalPaymentTypeExclusion[] OptionalPaymentTypeExclusion
		{
			get
			{
				return this.optionalPaymentTypeExclusionField;
			}
			set
			{
				this.optionalPaymentTypeExclusionField = value;
			}
		}

		/// <remarks/>
		public DistributionDesignationValues DistributionDesignation
		{
			get
			{
				return this.distributionDesignationField;
			}
			set
			{
				this.distributionDesignationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DistributionDesignationSpecified
		{
			get
			{
				return this.distributionDesignationFieldSpecified;
			}
			set
			{
				this.distributionDesignationFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductDescriptionDataCPSIAWarning
	{

		/// <remarks/>
		choking_hazard_balloon,

		/// <remarks/>
		choking_hazard_contains_a_marble,

		/// <remarks/>
		choking_hazard_contains_small_ball,

		/// <remarks/>
		choking_hazard_is_a_marble,

		/// <remarks/>
		choking_hazard_is_a_small_ball,

		/// <remarks/>
		choking_hazard_small_parts,

		/// <remarks/>
		no_warning_applicable,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductDescriptionDataPurchasingChannel
	{

		/// <remarks/>
		in_store,

		/// <remarks/>
		online,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductDescriptionDataTSDAgeWarning
	{

		/// <remarks/>
		not_suitable_under_36_months,

		/// <remarks/>
		not_suitable_under_3_years_supervision,

		/// <remarks/>
		not_suitable_under_4_years_supervision,

		/// <remarks/>
		not_suitable_under_5_years_supervision,

		/// <remarks/>
		not_suitable_under_6_years_supervision,

		/// <remarks/>
		not_suitable_under_7_years_supervision,

		/// <remarks/>
		not_suitable_under_8_years_supervision,

		/// <remarks/>
		not_suitable_under_9_years_supervision,

		/// <remarks/>
		not_suitable_under_10_years_supervision,

		/// <remarks/>
		not_suitable_under_11_years_supervision,

		/// <remarks/>
		not_suitable_under_12_years_supervision,

		/// <remarks/>
		not_suitable_under_13_years_supervision,

		/// <remarks/>
		not_suitable_under_14_years_supervision,

		/// <remarks/>
		no_warning_applicable,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductDescriptionDataTSDWarning
	{

		/// <remarks/>
		only_domestic_use,

		/// <remarks/>
		adult_supervision_required,

		/// <remarks/>
		protective_equipment_required,

		/// <remarks/>
		water_adult_supervision_required,

		/// <remarks/>
		toy_inside,

		/// <remarks/>
		no_protective_equipment,

		/// <remarks/>
		risk_of_entanglement,

		/// <remarks/>
		fragrances_allergy_risk,

		/// <remarks/>
		no_warning_applicable,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductDescriptionDataTSDLanguage
	{

		/// <remarks/>
		English,

		/// <remarks/>
		French,

		/// <remarks/>
		German,

		/// <remarks/>
		Italian,

		/// <remarks/>
		Spanish,

		/// <remarks/>
		Dutch,

		/// <remarks/>
		Polish,

		/// <remarks/>
		Bulgarian,

		/// <remarks/>
		Czech,

		/// <remarks/>
		Danish,

		/// <remarks/>
		Estonian,

		/// <remarks/>
		Finnish,

		/// <remarks/>
		Greek,

		/// <remarks/>
		Hungarian,

		/// <remarks/>
		Latvian,

		/// <remarks/>
		Lithuanian,

		/// <remarks/>
		Portuguese,

		/// <remarks/>
		Romanian,

		/// <remarks/>
		Slovak,

		/// <remarks/>
		Slovene,

		/// <remarks/>
		Swedish,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductDescriptionDataOptionalPaymentTypeExclusion
	{

		/// <remarks/>
		cash_on_delivery,

		/// <remarks/>
		cvs,

		/// <remarks/>
		exclude_none,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("exclude cod")]
		excludecod,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("exclude cvs")]
		excludecvs,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("exclude cod and cvs")]
		excludecodandcvs,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ProductPromoTag
	{

		private ProductPromoTagPromoTagType promoTagTypeField;

		private System.DateTime effectiveFromDateField;

		private System.DateTime effectiveThroughDateField;

		private bool effectiveThroughDateFieldSpecified;

		/// <remarks/>
		public ProductPromoTagPromoTagType PromoTagType
		{
			get
			{
				return this.promoTagTypeField;
			}
			set
			{
				this.promoTagTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime EffectiveFromDate
		{
			get
			{
				return this.effectiveFromDateField;
			}
			set
			{
				this.effectiveFromDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime EffectiveThroughDate
		{
			get
			{
				return this.effectiveThroughDateField;
			}
			set
			{
				this.effectiveThroughDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool EffectiveThroughDateSpecified
		{
			get
			{
				return this.effectiveThroughDateFieldSpecified;
			}
			set
			{
				this.effectiveThroughDateFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductPromoTagPromoTagType
	{

		/// <remarks/>
		Sale,

		/// <remarks/>
		New,

		/// <remarks/>
		NewArrival,

		/// <remarks/>
		WebOnly,

		/// <remarks/>
		Clearance,

		/// <remarks/>
		LimitedOffer,

		/// <remarks/>
		SpecialOffer,

		/// <remarks/>
		SpecialPurchase,

		/// <remarks/>
		OnlyInStores,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ProductDiscoveryData
	{

		private string priorityField;

		private bool browseExclusionField;

		private bool browseExclusionFieldSpecified;

		private bool recommendationExclusionField;

		private bool recommendationExclusionFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
			}
		}

		/// <remarks/>
		public bool BrowseExclusion
		{
			get
			{
				return this.browseExclusionField;
			}
			set
			{
				this.browseExclusionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool BrowseExclusionSpecified
		{
			get
			{
				return this.browseExclusionFieldSpecified;
			}
			set
			{
				this.browseExclusionFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool RecommendationExclusion
		{
			get
			{
				return this.recommendationExclusionField;
			}
			set
			{
				this.recommendationExclusionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RecommendationExclusionSpecified
		{
			get
			{
				return this.recommendationExclusionFieldSpecified;
			}
			set
			{
				this.recommendationExclusionFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ProductProductData
	{

		private object itemField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdditionalProductInformation", typeof(AdditionalProductInformation))]
		[System.Xml.Serialization.XmlElementAttribute("Arts", typeof(Arts))]
		[System.Xml.Serialization.XmlElementAttribute("AutoAccessory", typeof(AutoAccessory))]
		[System.Xml.Serialization.XmlElementAttribute("Baby", typeof(Baby))]
		[System.Xml.Serialization.XmlElementAttribute("Beauty", typeof(Beauty))]
		[System.Xml.Serialization.XmlElementAttribute("Books", typeof(Books))]
		[System.Xml.Serialization.XmlElementAttribute("CE", typeof(CE))]
		[System.Xml.Serialization.XmlElementAttribute("CameraPhoto", typeof(CameraPhoto))]
		[System.Xml.Serialization.XmlElementAttribute("Clothing", typeof(Clothing))]
		[System.Xml.Serialization.XmlElementAttribute("ClothingAccessories", typeof(ClothingAccessories))]
		[System.Xml.Serialization.XmlElementAttribute("Coins", typeof(Coins))]
		[System.Xml.Serialization.XmlElementAttribute("Collectibles", typeof(Collectibles))]
		[System.Xml.Serialization.XmlElementAttribute("Computers", typeof(Computers))]
		[System.Xml.Serialization.XmlElementAttribute("EUCompliance", typeof(EUCompliance))]
		[System.Xml.Serialization.XmlElementAttribute("EntertainmentCollectibles", typeof(EntertainmentCollectibles))]
		[System.Xml.Serialization.XmlElementAttribute("FBA", typeof(FBA))]
		[System.Xml.Serialization.XmlElementAttribute("FoodAndBeverages", typeof(FoodAndBeverages))]
		[System.Xml.Serialization.XmlElementAttribute("FoodServiceAndJanSan", typeof(FoodServiceAndJanSan))]
		[System.Xml.Serialization.XmlElementAttribute("Furniture", typeof(Furniture))]
		[System.Xml.Serialization.XmlElementAttribute("GiftCard", typeof(GiftCard))]
		[System.Xml.Serialization.XmlElementAttribute("Gourmet", typeof(Gourmet))]
		[System.Xml.Serialization.XmlElementAttribute("Health", typeof(Health))]
		[System.Xml.Serialization.XmlElementAttribute("Home", typeof(Home))]
		[System.Xml.Serialization.XmlElementAttribute("HomeImprovement", typeof(HomeImprovement))]
		[System.Xml.Serialization.XmlElementAttribute("Industrial", typeof(Industrial))]
		[System.Xml.Serialization.XmlElementAttribute("Jewelry", typeof(Jewelry))]
		[System.Xml.Serialization.XmlElementAttribute("LabSupplies", typeof(LabSupplies))]
		[System.Xml.Serialization.XmlElementAttribute("LargeAppliances", typeof(LargeAppliances))]
		[System.Xml.Serialization.XmlElementAttribute("Lighting", typeof(Lighting))]
		[System.Xml.Serialization.XmlElementAttribute("Luggage", typeof(Luggage))]
		[System.Xml.Serialization.XmlElementAttribute("LuxuryBeauty", typeof(LuxuryBeauty))]
		[System.Xml.Serialization.XmlElementAttribute("MaterialHandling", typeof(MaterialHandling))]
		[System.Xml.Serialization.XmlElementAttribute("MechanicalFasteners", typeof(MechanicalFasteners))]
		[System.Xml.Serialization.XmlElementAttribute("Miscellaneous", typeof(Miscellaneous))]
		[System.Xml.Serialization.XmlElementAttribute("Motorcycles", typeof(Motorcycles))]
		[System.Xml.Serialization.XmlElementAttribute("Music", typeof(Music))]
		[System.Xml.Serialization.XmlElementAttribute("MusicalInstruments", typeof(MusicalInstruments))]
		[System.Xml.Serialization.XmlElementAttribute("Office", typeof(Office))]
		[System.Xml.Serialization.XmlElementAttribute("Outdoors", typeof(Outdoors))]
		[System.Xml.Serialization.XmlElementAttribute("PetSupplies", typeof(PetSupplies))]
		[System.Xml.Serialization.XmlElementAttribute("PowerTransmission", typeof(PowerTransmission))]
		[System.Xml.Serialization.XmlElementAttribute("ProfessionalHealthCare", typeof(ProfessionalHealthCare))]
		[System.Xml.Serialization.XmlElementAttribute("RawMaterials", typeof(RawMaterials))]
		[System.Xml.Serialization.XmlElementAttribute("Shoes", typeof(Shoes))]
		[System.Xml.Serialization.XmlElementAttribute("SoftwareVideoGames", typeof(SoftwareVideoGames))]
		[System.Xml.Serialization.XmlElementAttribute("Sports", typeof(Sports))]
		[System.Xml.Serialization.XmlElementAttribute("SportsMemorabilia", typeof(SportsMemorabilia))]
		[System.Xml.Serialization.XmlElementAttribute("ThreeDPrinting", typeof(ThreeDPrinting))]
		[System.Xml.Serialization.XmlElementAttribute("TiresAndWheels", typeof(TiresAndWheels))]
		[System.Xml.Serialization.XmlElementAttribute("Tools", typeof(Tools))]
		[System.Xml.Serialization.XmlElementAttribute("Toys", typeof(Toys))]
		[System.Xml.Serialization.XmlElementAttribute("ToysBaby", typeof(ToysBaby))]
		[System.Xml.Serialization.XmlElementAttribute("Video", typeof(Video))]
		[System.Xml.Serialization.XmlElementAttribute("WineAndAlcohol", typeof(WineAndAlcohol))]
		[System.Xml.Serialization.XmlElementAttribute("Wireless", typeof(Wireless))]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductRegisteredParameter
	{

		/// <remarks/>
		PrivateLabel,

		/// <remarks/>
		Specialized,

		/// <remarks/>
		NonConsumer,

		/// <remarks/>
		PreConfigured,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class ProductImage
	{

		private string sKUField;

		private ProductImageImageType imageTypeField;

		private string imageLocationField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string SKU
		{
			get
			{
				return this.sKUField;
			}
			set
			{
				this.sKUField = value;
			}
		}

		/// <remarks/>
		public ProductImageImageType ImageType
		{
			get
			{
				return this.imageTypeField;
			}
			set
			{
				this.imageTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
		public string ImageLocation
		{
			get
			{
				return this.imageLocationField;
			}
			set
			{
				this.imageLocationField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ProductImageImageType
	{

		/// <remarks/>
		Main,

		/// <remarks/>
		Swatch,

		/// <remarks/>
		BKLB,

		/// <remarks/>
		PT1,

		/// <remarks/>
		PT2,

		/// <remarks/>
		PT3,

		/// <remarks/>
		PT4,

		/// <remarks/>
		PT5,

		/// <remarks/>
		PT6,

		/// <remarks/>
		PT7,

		/// <remarks/>
		PT8,

		/// <remarks/>
		Search,

		/// <remarks/>
		PM01,

		/// <remarks/>
		MainOfferImage,

		/// <remarks/>
		OfferImage1,

		/// <remarks/>
		OfferImage2,

		/// <remarks/>
		OfferImage3,

		/// <remarks/>
		OfferImage4,

		/// <remarks/>
		OfferImage5,

		/// <remarks/>
		PFEE,

		/// <remarks/>
		PFUK,

		/// <remarks/>
		PFDE,

		/// <remarks/>
		PFFR,

		/// <remarks/>
		PFIT,

		/// <remarks/>
		PFES,

		/// <remarks/>
		EEGL,

		/// <remarks/>
		PT98,

		/// <remarks/>
		PT99,

		/// <remarks/>
		ELFL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Relationship
	{

		private string parentSKUField;

		private RelationshipRelation[] relationField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string ParentSKU
		{
			get
			{
				return this.parentSKUField;
			}
			set
			{
				this.parentSKUField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Relation")]
		public RelationshipRelation[] Relation
		{
			get
			{
				return this.relationField;
			}
			set
			{
				this.relationField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class RelationshipRelation
	{

		private string sKUField;

		private string sortHeuristicField;

		private string quantityField;

		private string componentNumberField;

		private RelationshipRelationChildDetailPageDisplay childDetailPageDisplayField;

		private bool childDetailPageDisplayFieldSpecified;

		private RelationshipRelationType typeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string SKU
		{
			get
			{
				return this.sKUField;
			}
			set
			{
				this.sKUField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string SortHeuristic
		{
			get
			{
				return this.sortHeuristicField;
			}
			set
			{
				this.sortHeuristicField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string ComponentNumber
		{
			get
			{
				return this.componentNumberField;
			}
			set
			{
				this.componentNumberField = value;
			}
		}

		/// <remarks/>
		public RelationshipRelationChildDetailPageDisplay ChildDetailPageDisplay
		{
			get
			{
				return this.childDetailPageDisplayField;
			}
			set
			{
				this.childDetailPageDisplayField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ChildDetailPageDisplaySpecified
		{
			get
			{
				return this.childDetailPageDisplayFieldSpecified;
			}
			set
			{
				this.childDetailPageDisplayFieldSpecified = value;
			}
		}

		/// <remarks/>
		public RelationshipRelationType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum RelationshipRelationChildDetailPageDisplay
	{

		/// <remarks/>
		independently_displayable,

		/// <remarks/>
		display_only_on_parent,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum RelationshipRelationType
	{

		/// <remarks/>
		Variation,

		/// <remarks/>
		DisplaySet,

		/// <remarks/>
		Collection,

		/// <remarks/>
		Accessory,

		/// <remarks/>
		Customized,

		/// <remarks/>
		Part,

		/// <remarks/>
		Complements,

		/// <remarks/>
		Piece,

		/// <remarks/>
		Necessary,

		/// <remarks/>
		ReplacementPart,

		/// <remarks/>
		Similar,

		/// <remarks/>
		Episode,

		/// <remarks/>
		Season,

		/// <remarks/>
		MerchantTitleAuthority,

		/// <remarks/>
		Component,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class RelatedProductID
	{

		private RelatedProductIDType typeField;

		private string valueField;

		/// <remarks/>
		public RelatedProductIDType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		/// <remarks/>
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum RelatedProductIDType
	{
		UPC,
		EAN,
		GTIN
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class ConditionInfo
	{

		private ConditionType conditionTypeField;

		private string conditionNoteField;

		/// <remarks/>
		public ConditionType ConditionType
		{
			get
			{
				return this.conditionTypeField;
			}
			set
			{
				this.conditionTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string ConditionNote
		{
			get
			{
				return this.conditionNoteField;
			}
			set
			{
				this.conditionNoteField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public enum ConditionType
	{
		New,
		UsedLikeNew,
		UsedVeryGood,
		UsedGood,
		UsedAcceptable,
		CollectibleLikeNew,
		CollectibleVeryGood,
		CollectibleGood,
		CollectibleAcceptable,
		Refurbished,
		Club,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class RebateType
	{

		private System.DateTime rebateStartDateField;

		private System.DateTime rebateEndDateField;

		private string rebateMessageField;

		private string rebateNameField;

		/// <remarks/>
		public System.DateTime RebateStartDate
		{
			get
			{
				return this.rebateStartDateField;
			}
			set
			{
				this.rebateStartDateField = value;
			}
		}

		/// <remarks/>
		public System.DateTime RebateEndDate
		{
			get
			{
				return this.rebateEndDateField;
			}
			set
			{
				this.rebateEndDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string RebateMessage
		{
			get
			{
				return this.rebateMessageField;
			}
			set
			{
				this.rebateMessageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string RebateName
		{
			get
			{
				return this.rebateNameField;
			}
			set
			{
				this.rebateNameField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class VolumeDimension
	{

		private VolumeUnitOfMeasure unitOfMeasureField;

		private decimal valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public VolumeUnitOfMeasure unitOfMeasure
		{
			get
			{
				return this.unitOfMeasureField;
			}
			set
			{
				this.unitOfMeasureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	public enum VolumeUnitOfMeasure
	{
		[System.Xml.Serialization.XmlEnumAttribute("cubic-cm")]
		cubiccm,
		[System.Xml.Serialization.XmlEnumAttribute("cubic-ft")]
		cubicft,
		[System.Xml.Serialization.XmlEnumAttribute("cubic-in")]
		cubicin,
		[System.Xml.Serialization.XmlEnumAttribute("cubic-m")]
		cubicm,
		[System.Xml.Serialization.XmlEnumAttribute("cubic-yd")]
		cubicyd,
		cup,
		[System.Xml.Serialization.XmlEnumAttribute("fluid-oz")]
		fluidoz,
		gallon,
		liter,
		milliliter,
		ounce,
		pint,
		quart,
		liters,
		deciliters,
		centiliters,
		milliliters,
		microliters,
		nanoliters,
		picoliters,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute("Amazon-Vendor-Only", Namespace = "", IsNullable = false)]
	public partial class AmazonVendorOnly
	{

		private CurrencyAmount costField;

		/// <remarks/>
		public CurrencyAmount Cost
		{
			get
			{
				return this.costField;
			}
			set
			{
				this.costField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute("Amazon-Only", Namespace = "", IsNullable = false)]
	public partial class AmazonOnly
	{

		private string tierField;

		private string purchasingCategoryField;

		private string purchasingSubCategoryField;

		private string packagingTypeField;

		private AmazonOnlyUnderlyingAvailability underlyingAvailabilityField;

		private AmazonOnlyReplenishmentCategory replenishmentCategoryField;

		private AmazonOnlyDropShipStatus dropShipStatusField;

		private AmazonOnlyOutOfStockWebsiteMessage outOfStockWebsiteMessageField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string Tier
		{
			get
			{
				return this.tierField;
			}
			set
			{
				this.tierField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string PurchasingCategory
		{
			get
			{
				return this.purchasingCategoryField;
			}
			set
			{
				this.purchasingCategoryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string PurchasingSubCategory
		{
			get
			{
				return this.purchasingSubCategoryField;
			}
			set
			{
				this.purchasingSubCategoryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")]
		public string PackagingType
		{
			get
			{
				return this.packagingTypeField;
			}
			set
			{
				this.packagingTypeField = value;
			}
		}

		/// <remarks/>
		public AmazonOnlyUnderlyingAvailability UnderlyingAvailability
		{
			get
			{
				return this.underlyingAvailabilityField;
			}
			set
			{
				this.underlyingAvailabilityField = value;
			}
		}

		/// <remarks/>
		public AmazonOnlyReplenishmentCategory ReplenishmentCategory
		{
			get
			{
				return this.replenishmentCategoryField;
			}
			set
			{
				this.replenishmentCategoryField = value;
			}
		}

		/// <remarks/>
		public AmazonOnlyDropShipStatus DropShipStatus
		{
			get
			{
				return this.dropShipStatusField;
			}
			set
			{
				this.dropShipStatusField = value;
			}
		}

		/// <remarks/>
		public AmazonOnlyOutOfStockWebsiteMessage OutOfStockWebsiteMessage
		{
			get
			{
				return this.outOfStockWebsiteMessageField;
			}
			set
			{
				this.outOfStockWebsiteMessageField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum AmazonOnlyUnderlyingAvailability
	{

		/// <remarks/>
		backordered,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("manufacturer-out-of-stock")]
		manufactureroutofstock,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("pre-ordered")]
		preordered,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("2-3-days")]
		Item23days,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("1-2-weeks")]
		Item12weeks,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("4-6-weeks")]
		Item46weeks,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum AmazonOnlyReplenishmentCategory
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("basic-replenishment")]
		basicreplenishment,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("limited-replenishment")]
		limitedreplenishment,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("manufacturer-out-of-stock")]
		manufactureroutofstock,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("new-product")]
		newproduct,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("non-replenishable")]
		nonreplenishable,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("non-stockupable")]
		nonstockupable,

		/// <remarks/>
		obsolete,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("planned-replenishment")]
		plannedreplenishment,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum AmazonOnlyDropShipStatus
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-disabled")]
		dropshipdisabled,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-disabled-by-buyer")]
		dropshipdisabledbybuyer,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-enabled")]
		dropshipenabled,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-enabled-no-auto-pricing")]
		dropshipenablednoautopricing,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("drop-ship-only")]
		dropshiponly,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum AmazonOnlyOutOfStockWebsiteMessage
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("email-me-when-available")]
		emailmewhenavailable,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("out-of-stock")]
		outofstock,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("pre-order-ute")]
		preorderute,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("underlying-availability")]
		underlyingavailability,
	}


}
