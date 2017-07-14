using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Product : AmazonMessageChoice
	{

	}


	public partial class ProductProductData
	{

	}

	public partial class ProductDescriptionData
	{

		private List<string> bulletPointField;

		private Dimensions itemDimensionsField;

		private Dimensions packageDimensionsField;

		private PositiveWeightDimension packageWeightField;

		private PositiveWeightDimension shippingWeightField;

		private CurrencyAmount mSRPField;

		private CurrencyAmount mSRPWithTaxField;

		private List<ProductDescriptionDataCPSIAWarning> cPSIAWarningField;

		private List<string> searchTermsField;

		private List<string> platinumKeywordsField;

		private List<string> usedForField;

		private List<string> otherItemAttributesField;

		private List<string> targetAudienceField;

		private List<string> subjectContentField;

		private List<string> promotionKeywordsField;

		private List<DeliveryChannel> deliveryChannelField;

		private List<ProductDescriptionDataPurchasingChannel> purchasingChannelField;

		private List<string> recommendedBrowseNodeField;

		private List<ProductDescriptionDataTSDWarning> tSDWarningField;

		private List<ProductDescriptionDataTSDLanguage> tSDLanguageField;

		private List<ProductDescriptionDataOptionalPaymentTypeExclusion> optionalPaymentTypeExclusionField;

		public string Title { get; set; }

		public string Brand { get; set; }

		public string Designer { get; set; }

		public string Description { get; set; }

		public string MerchantCatalogNumber { get; set; }

		public string MaxOrderQuantity { get; set; }

		public bool SerialNumberRequired { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SerialNumberRequiredSpecified { get; set; }

		public bool Prop65 { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool Prop65Specified { get; set; }

		public string CPSIAWarningDescription { get; set; }

		public string LegalDisclaimer { get; set; }

		public string Manufacturer { get; set; }

		public string MfrPartNumber { get; set; }

		public bool Memorabilia { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MemorabiliaSpecified { get; set; }

		public bool Autographed { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool AutographedSpecified { get; set; }

		public string ItemType { get; set; }

		public bool IsGiftWrapAvailable { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsGiftWrapAvailableSpecified { get; set; }

		public bool IsGiftMessageAvailable { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsGiftMessageAvailableSpecified { get; set; }

		public bool IsDiscontinuedByManufacturer { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsDiscontinuedByManufacturerSpecified { get; set; }

		public string DeliveryScheduleGroupID { get; set; }

		public string MaxAggregateShipQuantity { get; set; }

		public bool IsCustomizable { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool IsCustomizableSpecified { get; set; }

		public string CustomizableTemplateName { get; set; }

		public string MerchantShippingGroupName { get; set; }

		public string FEDAS_ID { get; set; }

		public ProductDescriptionDataTSDAgeWarning TSDAgeWarning { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TSDAgeWarningSpecified { get; set; }

		public DistributionDesignationValues DistributionDesignation { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DistributionDesignationSpecified { get; set; }


		public ProductDescriptionData()
		{
			this.optionalPaymentTypeExclusionField = new List<ProductDescriptionDataOptionalPaymentTypeExclusion>();
			this.tSDLanguageField = new List<ProductDescriptionDataTSDLanguage>();
			this.tSDWarningField = new List<ProductDescriptionDataTSDWarning>();
			this.recommendedBrowseNodeField = new List<string>();
			this.purchasingChannelField = new List<ProductDescriptionDataPurchasingChannel>();
			this.deliveryChannelField = new List<DeliveryChannel>();
			this.promotionKeywordsField = new List<string>();
			this.subjectContentField = new List<string>();
			this.targetAudienceField = new List<string>();
			this.otherItemAttributesField = new List<string>();
			this.usedForField = new List<string>();
			this.platinumKeywordsField = new List<string>();
			this.searchTermsField = new List<string>();
			this.cPSIAWarningField = new List<ProductDescriptionDataCPSIAWarning>();
			this.mSRPWithTaxField = new CurrencyAmount();
			this.mSRPField = new CurrencyAmount();
			this.shippingWeightField = new PositiveWeightDimension();
			this.packageWeightField = new PositiveWeightDimension();
			this.packageDimensionsField = new Dimensions();
			this.itemDimensionsField = new Dimensions();
			this.bulletPointField = new List<string>();
		}

		public List<string> BulletPoint
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

		public List<ProductDescriptionDataCPSIAWarning> CPSIAWarning
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

		public List<string> SearchTerms
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

		public List<string> PlatinumKeywords
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

		public List<string> UsedFor
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

		public List<string> OtherItemAttributes
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

		public List<string> TargetAudience
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

		public List<string> SubjectContent
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

		public List<string> PromotionKeywords
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

		public List<DeliveryChannel> DeliveryChannel
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

		public List<ProductDescriptionDataPurchasingChannel> PurchasingChannel
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

		public List<string> RecommendedBrowseNode
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

		public List<ProductDescriptionDataTSDWarning> TSDWarning
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

		public List<ProductDescriptionDataTSDLanguage> TSDLanguage
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

		public List<ProductDescriptionDataOptionalPaymentTypeExclusion> OptionalPaymentTypeExclusion
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
	}

	public enum ProductDescriptionDataCPSIAWarning
	{
		choking_hazard_balloon,
		choking_hazard_contains_a_marble,
		choking_hazard_contains_small_ball,
		choking_hazard_is_a_marble,
		choking_hazard_is_a_small_ball,
		choking_hazard_small_parts,
		no_warning_applicable,
	}

	public enum ProductDescriptionDataPurchasingChannel
	{
		in_store,
		online,
	}

	public enum ProductDescriptionDataTSDAgeWarning
	{
		not_suitable_under_36_months,
		not_suitable_under_3_years_supervision,
		not_suitable_under_4_years_supervision,
		not_suitable_under_5_years_supervision,
		not_suitable_under_6_years_supervision,
		not_suitable_under_7_years_supervision,
		not_suitable_under_8_years_supervision,
		not_suitable_under_9_years_supervision,
		not_suitable_under_10_years_supervision,
		not_suitable_under_11_years_supervision,
		not_suitable_under_12_years_supervision,
		not_suitable_under_13_years_supervision,
		not_suitable_under_14_years_supervision,
		no_warning_applicable,
	}

	public enum ProductDescriptionDataTSDWarning
	{
		only_domestic_use,
		adult_supervision_required,
		protective_equipment_required,
		water_adult_supervision_required,
		toy_inside,
		no_protective_equipment,
		risk_of_entanglement,
		fragrances_allergy_risk,
		no_warning_applicable,
	}

	public enum ProductDescriptionDataTSDLanguage
	{
		English,
		French,
		German,
		Italian,
		Spanish,
		Dutch,
		Polish,
		Bulgarian,
		Czech,
		Danish,
		Estonian,
		Finnish,
		Greek,
		Hungarian,
		Latvian,
		Lithuanian,
		Portuguese,
		Romanian,
		Slovak,
		Slovene,
		Swedish,
	}

	public enum ProductDescriptionDataOptionalPaymentTypeExclusion
	{
		cash_on_delivery,
		cvs,
		exclude_none,
		[System.Xml.Serialization.XmlEnumAttribute("exclude cod")]
		excludecod,
		[System.Xml.Serialization.XmlEnumAttribute("exclude cvs")]
		excludecvs,
		[System.Xml.Serialization.XmlEnumAttribute("exclude cod and cvs")]
		excludecodandcvs,
	}

	public enum DistributionDesignationValues
	{
		jp_parallel_import,
	}

	public partial class ProductPromoTag
	{

		public ProductPromoTagPromoTagType PromoTagType { get; set; }

		public System.DateTime EffectiveFromDate { get; set; }

		public System.DateTime EffectiveThroughDate { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool EffectiveThroughDateSpecified { get; set; }

	}

	public enum ProductPromoTagPromoTagType
	{
		Sale,
		New,
		NewArrival,
		WebOnly,
		Clearance,
		LimitedOffer,
		SpecialOffer,
		SpecialPurchase,
		OnlyInStores,
	}



	public partial class ProductDiscoveryData
	{

		public string Priority { get; set; }

		public bool BrowseExclusion { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool BrowseExclusionSpecified { get; set; }

		public bool RecommendationExclusion { get; set; }

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool RecommendationExclusionSpecified { get; set; }

	}

	public enum ProductGtinExemptionReason
	{
		bundle,
		part,
	}

	public enum ProductOffAmazonChannel
	{
		advertise,
		exclude,
	}

	public enum ProductOnAmazonChannel
	{
		sell,
		advertise,
		exclude,
	}

	public enum ProductRegisteredParameter
	{
		PrivateLabel,
		Specialized,
		NonConsumer,
		PreConfigured,
	}
}
