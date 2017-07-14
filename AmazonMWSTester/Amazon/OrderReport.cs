using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class OrderReport : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportCustomerOrderInfo { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Type { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportCustomerOrderInfo)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportBillingData { private OrderReportBillingDataCreditCard creditCardField; private AddressType addressField; private static System.Xml.Serialization.XmlSerializer serializer; public decimal CODCollectibleAmount { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool CODCollectibleAmountSpecified { get; set; } public decimal AlreadyPaid { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool AlreadyPaidSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerEmailAddress { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string BuyerPhoneNumber { get; set; } public bool IsConfidentialShippingAddress { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsConfidentialShippingAddressSpecified { get; set; } public OrderReportBillingData() { this.addressField = new AddressType(); this.creditCardField = new OrderReportBillingDataCreditCard(); } public OrderReportBillingDataCreditCard CreditCard { get { return this.creditCardField; } set { this.creditCardField = value; } } public AddressType Address { get { return this.addressField; } set { this.addressField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportBillingData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportFulfillmentData { private AddressType addressField; private static System.Xml.Serialization.XmlSerializer serializer; public FulfillmentMethod FulfillmentMethod { get; set; } public FulfillmentServiceLevel FulfillmentServiceLevel { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool FulfillmentServiceLevelSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string FulfillmentCenterID { get; set; } public bool IsConfidentialShippingAddress { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool IsConfidentialShippingAddressSpecified { get; set; } public OrderReportFulfillmentData() { this.addressField = new AddressType(); } public AddressType Address { get { return this.addressField; } set { this.addressField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportFulfillmentData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportItem { private List<CustomizationInfoType> customizationInfoField; private List<BuyerPriceComponent> itemPriceField; private List<AmazonFeesFee> itemFeesField; private TaxData itemTaxDataField; private TaxData shippingTaxDataField; private TaxData giftWrapTaxDataField; private List<TaxablePromotionType> promotionField; private InvoiceDataType invoiceDataField; private List<OrderReportItemItemRelationship> itemRelationshipField; private OrderReportItemPhoneNumberTransfer phoneNumberTransferField; private ExpectedShipDateRangeType expectedShipDateRangeField; private ExpectedDeliveryDateRangeType expectedDeliveryDateRangeField; private static System.Xml.Serialization.XmlSerializer serializer; public string AmazonOrderItemCode { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SKU { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Title { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ItemExtensionsData { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ScheduledDeliveryStartDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ScheduledDeliveryEndDate { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string Quantity { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ProductTaxCode { get; set; } public System.DateTime DeliveryStartDate { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool DeliveryStartDateSpecified { get; set; } public System.DateTime DeliveryEndDate { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool DeliveryEndDateSpecified { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string DeliveryTimeZone { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string DeliveryInstructions { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string GiftWrapLevel { get; set; } public string GiftMessageText { get; set; } public object PriceDesignation { get; set; } public bool MerchantsAtOrder { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool MerchantsAtOrderSpecified { get; set; } public OrderReportItem() { this.expectedDeliveryDateRangeField = new ExpectedDeliveryDateRangeType(); this.expectedShipDateRangeField = new ExpectedShipDateRangeType(); this.phoneNumberTransferField = new OrderReportItemPhoneNumberTransfer(); this.itemRelationshipField = new List<OrderReportItemItemRelationship>(); this.invoiceDataField = new InvoiceDataType(); this.promotionField = new List<TaxablePromotionType>(); this.giftWrapTaxDataField = new TaxData(); this.shippingTaxDataField = new TaxData(); this.itemTaxDataField = new TaxData(); this.itemFeesField = new List<AmazonFeesFee>(); this.itemPriceField = new List<BuyerPriceComponent>(); this.customizationInfoField = new List<CustomizationInfoType>(); }[System.Xml.Serialization.XmlElementAttribute("CustomizationInfo")] public List<CustomizationInfoType> CustomizationInfo { get { return this.customizationInfoField; } set { this.customizationInfoField = value; } }[System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable = false)] public List<BuyerPriceComponent> ItemPrice { get { return this.itemPriceField; } set { this.itemPriceField = value; } }[System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)] public List<AmazonFeesFee> ItemFees { get { return this.itemFeesField; } set { this.itemFeesField = value; } } public TaxData ItemTaxData { get { return this.itemTaxDataField; } set { this.itemTaxDataField = value; } } public TaxData ShippingTaxData { get { return this.shippingTaxDataField; } set { this.shippingTaxDataField = value; } } public TaxData GiftWrapTaxData { get { return this.giftWrapTaxDataField; } set { this.giftWrapTaxDataField = value; } }[System.Xml.Serialization.XmlElementAttribute("Promotion")] public List<TaxablePromotionType> Promotion { get { return this.promotionField; } set { this.promotionField = value; } } public InvoiceDataType InvoiceData { get { return this.invoiceDataField; } set { this.invoiceDataField = value; } }[System.Xml.Serialization.XmlElementAttribute("ItemRelationship")] public List<OrderReportItemItemRelationship> ItemRelationship { get { return this.itemRelationshipField; } set { this.itemRelationshipField = value; } } public OrderReportItemPhoneNumberTransfer PhoneNumberTransfer { get { return this.phoneNumberTransferField; } set { this.phoneNumberTransferField = value; } } public ExpectedShipDateRangeType ExpectedShipDateRange { get { return this.expectedShipDateRangeField; } set { this.expectedShipDateRangeField = value; } } public ExpectedDeliveryDateRangeType ExpectedDeliveryDateRange { get { return this.expectedDeliveryDateRangeField; } set { this.expectedDeliveryDateRangeField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportItem)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportRiskAssessmentData { private AmazonW3CEncryptedType driversLicenseNumberField; private AmazonW3CEncryptedType driversLicenseExpirationDateField; private AmazonW3CEncryptedType driversLicenseStateField; private AmazonW3CEncryptedType sSNField; private AmazonW3CEncryptedType dateOfBirthField; private AmazonW3CEncryptedType employerNameField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string NamePrefix { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string FirstName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string MiddleInitial { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string LastName { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string NameSuffix { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string AddressFieldOne { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string AddressFieldTwo { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string City { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string State { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Country { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PostalCode { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ContactPhoneNumber { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string EmailAddress { get; set; } public OrderReportRiskAssessmentData() { this.employerNameField = new AmazonW3CEncryptedType(); this.dateOfBirthField = new AmazonW3CEncryptedType(); this.sSNField = new AmazonW3CEncryptedType(); this.driversLicenseStateField = new AmazonW3CEncryptedType(); this.driversLicenseExpirationDateField = new AmazonW3CEncryptedType(); this.driversLicenseNumberField = new AmazonW3CEncryptedType(); } public AmazonW3CEncryptedType DriversLicenseNumber { get { return this.driversLicenseNumberField; } set { this.driversLicenseNumberField = value; } } public AmazonW3CEncryptedType DriversLicenseExpirationDate { get { return this.driversLicenseExpirationDateField; } set { this.driversLicenseExpirationDateField = value; } } public AmazonW3CEncryptedType DriversLicenseState { get { return this.driversLicenseStateField; } set { this.driversLicenseStateField = value; } } public AmazonW3CEncryptedType SSN { get { return this.sSNField; } set { this.sSNField = value; } } public AmazonW3CEncryptedType DateOfBirth { get { return this.dateOfBirthField; } set { this.dateOfBirthField = value; } } public AmazonW3CEncryptedType EmployerName { get { return this.employerNameField; } set { this.employerNameField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportRiskAssessmentData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum TaxAddressTypeAddressRole { ShipFrom, BillTo, SellerPrimary, BuyerPrimary, Middleman, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TaxDataTaxRates { private static System.Xml.Serialization.XmlSerializer serializer; public decimal District { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool DistrictSpecified { get; set; } public decimal City { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool CitySpecified { get; set; } public decimal County { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool CountySpecified { get; set; } public decimal State { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool StateSpecified { get; set; } public decimal Country { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool CountrySpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TaxDataTaxRates)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TaxablePromotionTypeComponent { private CurrencyAmount amountField; private TaxData taxDataField; private static System.Xml.Serialization.XmlSerializer serializer; public PromotionApplicationType Type { get; set; } public TaxablePromotionTypeComponent() { this.taxDataField = new TaxData(); this.amountField = new CurrencyAmount(); } public CurrencyAmount Amount { get { return this.amountField; } set { this.amountField = value; } } public TaxData TaxData { get { return this.taxDataField; } set { this.taxDataField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TaxablePromotionTypeComponent)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum InvoiceDataTypeInvoiceRequirement { None, Consolidated, Individual, NotNeeded, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum InvoiceDataTypeInvoiceInformation { BuyerSelectedCategory, ProductTitle, NotApplicable, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportBillingDataCreditCard { private static System.Xml.Serialization.XmlSerializer serializer; public OrderReportBillingDataCreditCardIssuer Issuer { get; set; } public string Tail { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")] public string ExpirationDate { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportBillingDataCreditCard)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportItemItemRelationship { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string RelationshipID { get; set; } public OrderReportItemItemRelationshipType Type { get; set; } public OrderReportItemItemRelationshipRole Role { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportItemItemRelationship)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class OrderReportItemPhoneNumberTransfer { private AmazonW3CEncryptedType encryptedAccountNumberField; private AddressType accountBillingAddressField; private AmazonW3CEncryptedType encryptedSSNField; private AmazonW3CEncryptedType encryptedPINField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string CurrentPhoneNumber { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ServiceProvider { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string AccountHolderName { get; set; } public OrderReportItemPhoneNumberTransfer() { this.encryptedPINField = new AmazonW3CEncryptedType(); this.encryptedSSNField = new AmazonW3CEncryptedType(); this.accountBillingAddressField = new AddressType(); this.encryptedAccountNumberField = new AmazonW3CEncryptedType(); } public AmazonW3CEncryptedType EncryptedAccountNumber { get { return this.encryptedAccountNumberField; } set { this.encryptedAccountNumberField = value; } } public AddressType AccountBillingAddress { get { return this.accountBillingAddressField; } set { this.accountBillingAddressField = value; } } public AmazonW3CEncryptedType EncryptedSSN { get { return this.encryptedSSNField; } set { this.encryptedSSNField = value; } } public AmazonW3CEncryptedType EncryptedPIN { get { return this.encryptedPINField; } set { this.encryptedPINField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(OrderReportItemPhoneNumberTransfer)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum OrderReportBillingDataCreditCardIssuer
	{

		/// <remarks/>
		Visa,

		/// <remarks/>
		MasterCard,

		/// <remarks/>
		AmericanExpress,

		/// <remarks/>
		Discover,

		/// <remarks/>
		DinersClub,

		/// <remarks/>
		JCB,

		/// <remarks/>
		PrivateLabel,

		/// <remarks/>
		BankDebit,

		/// <remarks/>
		CarteBlanche,

		/// <remarks/>
		CarteBancaire,

		/// <remarks/>
		PaymentByInvoice,

		/// <remarks/>
		Laser,

		/// <remarks/>
		Switch,

		/// <remarks/>
		SVS,

		/// <remarks/>
		BordersECG,

		/// <remarks/>
		Other,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum OrderReportItemItemRelationshipType
	{

		/// <remarks/>
		bundle,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("send-same-shipment")]
		sendsameshipment,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum OrderReportItemItemRelationshipRole
	{

		/// <remarks/>
		child,

		/// <remarks/>
		parent,

		/// <remarks/>
		peer,
	}
}
