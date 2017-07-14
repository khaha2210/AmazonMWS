using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class amzn_base
	{
	}

	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class BatteryBatterySubgroup
	{

		private static System.Xml.Serialization.XmlSerializer serializer;

		public BatteryBatterySubgroupBatteryType BatteryType { get; set; }

		[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
		public string NumberOfBatteries { get; set; }
	}

	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum PhoneNumberTypeType
	{
		Voice,
		Fax,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum StandardProductIDType
	{
		ISBN,
		UPC,
		EAN,
		ASIN,
		GTIN,
		GCID,
		PZN,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum JewelryBatteryBatterySubgroupBatteryType
	{
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_2/3A")]
		battery_type_23A,
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_4/3A")]
		battery_type_43A,
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_4/5A")]
		battery_type_45A,
		battery_type_9v,
		battery_type_12v,
		battery_type_a,
		battery_type_a76,
		battery_type_aa,
		battery_type_aaa,
		battery_type_aaaa,
		battery_type_c,
		battery_type_cr123a,
		battery_type_cr2,
		battery_type_cr5,
		battery_type_d,
		battery_type_lithium_ion,
		battery_type_lithium_metal,
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_L-SC")]
		battery_type_LSC,
		battery_type_p76,
		battery_type_product_specific,
		battery_type_SC,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum BatteryBatterySubgroupBatteryType
	{
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_2/3A")]
		battery_type_23A,
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_4/3A")]
		battery_type_43A,
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_4/5A")]
		battery_type_45A,
		battery_type_9v,
		battery_type_12v,
		battery_type_a,
		battery_type_a76,
		battery_type_aa,
		battery_type_aaa,
		battery_type_aaaa,
		battery_type_c,
		battery_type_cr123a,
		battery_type_cr2,
		battery_type_cr5,
		battery_type_d,
		battery_type_lithium_ion,
		battery_type_lithium_metal,
		[System.Xml.Serialization.XmlEnumAttribute("battery_type_L-SC")]
		battery_type_LSC,
		battery_type_p76,
		battery_type_product_specific,
		battery_type_SC,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum RelatedProductIDType
	{
		UPC,
		EAN,
		GTIN,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum ComputerPlatformType
	{
		windows,
		mac,
		linux,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum AgeRecommendedUnitOfMeasure
	{
		months,
		years,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum WeightUnitOfMeasure
	{
		GR,
		KG,
		OZ,
		LB,
		MG,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum LengthUnitOfMeasure
	{
		MM,
		CM,
		M,
		IN,
		FT,
		inches,
		feet,
		meters,
		decimeters,
		centimeters,
		millimeters,
		micrometers,
		nanometers,
		picometers,
	}

	public enum EmailAddressTypePreferredFormat
	{
		TextOnly,
		HTML
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class AmazonFeesFee
	{

		private CurrencyAmount amountField;


		public string Type { get; set; }


		public AmazonFeesFee()
		{
			this.amountField = new CurrencyAmount();
		}

		public CurrencyAmount Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum BaseCurrencyCode
	{
		USD,
		GBP,
		EUR,
		JPY,
		CAD,
		CNY,
		INR,
		MXN,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class BuyerPriceComponent
	{

		private CurrencyAmount amountField;


		public BuyerPriceComponentType Type { get; set; }


		public BuyerPriceComponent()
		{
			this.amountField = new CurrencyAmount();
		}

		public CurrencyAmount Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class AdjustmentDirectPaymentTypeComponent
	{

		private AdjustmentCurrencyAmount amountField;


		public string Type { get; set; }


		public AdjustmentDirectPaymentTypeComponent()
		{
			this.amountField = new AdjustmentCurrencyAmount();
		}

		public AdjustmentCurrencyAmount Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum BuyerPriceComponentType
	{
		Principal,
		Shipping,
		CODFee,
		Tax,
		ShippingTax,
		RestockingFee,
		RestockingFeeTax,
		GiftWrap,
		GiftWrapTax,
		Surcharge,
		ReturnShipping,
		Goodwill,
		ExportCharge,
		COD,
		CODTax,
		Other,
		FreeReplacementReturnShipping,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class DirectPaymentTypeComponent
	{

		private CurrencyAmount amountField;


		public string Type { get; set; }


		public DirectPaymentTypeComponent()
		{
			this.amountField = new CurrencyAmount();
		}

		public CurrencyAmount Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
	public enum ItemChoiceType
	{
		PreviousPrice,
		Price,
		AmazonOrderID,
		MerchantOrderID
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class PromotionDataTypeComponent
	{

		private CurrencyAmount amountField;


		public PromotionApplicationType Type { get; set; }


		public PromotionDataTypeComponent()
		{
			this.amountField = new CurrencyAmount();
		}

		public CurrencyAmount Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
			}
		}
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum PromotionApplicationType
	{
		Principal,
		Shipping,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum EnergyUnitOfMeasure
	{
		BTU,
		watts,
		joules,
		kilojoules,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum AreaUnitOfMeasure
	{
		[System.Xml.Serialization.XmlEnumAttribute("square-in")]
		squarein,
		[System.Xml.Serialization.XmlEnumAttribute("square-ft")]
		squareft,
		[System.Xml.Serialization.XmlEnumAttribute("square-cm")]
		squarecm,
		[System.Xml.Serialization.XmlEnumAttribute("square-m")]
		squarem,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum AirFlowDisplacementUnitOfMeasure
	{
		cubic_feet_per_minute,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum BurnTimeUnitOfMeasure
	{
		minutes,
		hours,
		cycles,
	}

	[System.SerializableAttribute()]
	public enum GlobalCurrencyCode
	{
		AED,
		ALL,
		ARS,
		ATS,
		AUD,
		BAM,
		BEF,
		BGN,
		BHD,
		BOB,
		BRL,
		BYR,
		CAD,
		CHF,
		CLP,
		CNY,
		COP,
		CRC,
		CSD,
		CZK,
		DEM,
		DKK,
		DOP,
		DZD,
		EEK,
		EGP,
		ESP,
		EUR,
		FIM,
		FRF,
		GBP,
		GRD,
		GTQ,
		HKD,
		HNL,
		HRK,
		HUF,
		IDR,
		ILS,
		INR,
		IQD,
		ISK,
		ITL,
		JOD,
		JPY,
		KRW,
		KWD,
		LBP,
		LTL,
		LUF,
		LVL,
		LYD,
		MAD,
		MKD,
		MXN,
		MYR,
		NIO,
		NOK,
		NZD,
		OMR,
		PAB,
		PEN,
		PHP,
		PLN,
		PTE,
		PYG,
		QAR,
		RON,
		RSD,
		RUB,
		SAR,
		SDG,
		SEK,
		SGD,
		SKK,
		SVC,
		SYP,
		THB,
		TND,
		TRY,
		TWD,
		UAH,
		USD,
		UYU,
		VEF,
		VND,
		YER,
		ZAR,
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum LuminanceUnitOfMeasure
	{

		/// <remarks/>
		lumens,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
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

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum VolumeRateUnitOfMeasure
	{
		[System.Xml.Serialization.XmlEnumAttribute("milliliters per second")]
		milliliterspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("centiliters per second")]
		centiliterspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("liters per second")]
		literspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("milliliters per minute")]
		millilitersperminute,
		[System.Xml.Serialization.XmlEnumAttribute("liters per minute")]
		litersperminute,
		[System.Xml.Serialization.XmlEnumAttribute("microliters per second")]
		microliterspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("nanoliters per second")]
		nanoliterspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("picoliters per second")]
		picoliterspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("microliters per minute")]
		microlitersperminute,
		[System.Xml.Serialization.XmlEnumAttribute("nanoliters per minute")]
		nanolitersperminute,
		[System.Xml.Serialization.XmlEnumAttribute("picoliters per minute")]
		picolitersperminute,
		gallons_per_day,
		liters_per_day,
		liters,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum JewelryLengthUnitOfMeasure
	{
		MM,
		CM,
		IN,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum JewelryWeightUnitOfMeasure
	{
		GR,
		KG,
		OZ,
		LB,
		CARATS,
		DWT,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum DegreeUnitOfMeasure
	{
		degrees,
		microradian,
		arc_minute,
		arc_sec,
		milliradian,
		radians,
		turns,
		revolutions,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum MemorySizeUnitOfMeasure
	{
		TB,
		GB,
		MB,
		KB,
		KO,
		MO,
		GO,
		TO,
		bytes,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum FrequencyUnitOfMeasure
	{
		Hz,
		KHz,
		MHz,
		GHz,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum AmperageUnitOfMeasure
	{
		amps,
		kiloamps,
		microamps,
		milliamps,
		nanoamps,
		picoamps,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ResistanceUnitOfMeasure
	{
		ohms,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum TimeUnitOfMeasure
	{
		sec,
		min,
		hr,
		days,
		hours,
		minutes,
		seconds,
		milliseconds,
		microseconds,
		nanoseconds,
		picoseconds,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum BatteryAverageLifeUnitOfMeasure
	{
		minutes,
		hours,
		days,
		weeks,
		months,
		years,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum DateUnitOfMeasure
	{
		days,
		weeks,
		months,
		years,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum SunProtectionUnitOfMeasure
	{
		sun_protection_factor,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum AssemblyTimeUnitOfMeasure
	{
		minutes,
		hours,
		days,
		weeks,
		months,
		years,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum BatteryPowerUnitOfMeasure
	{
		milliamp_hours,
		amp_hours,
		volt_amperes,
		watt_hours,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum LuminousIntensityUnitOfMeasure
	{
		candela,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
	public enum VoltageUnitOfMeasure
	{
		volts,
		millivolts,
		microvolts,
		nanovolts,
		kilovolts,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum WattageUnitOfMeasure
	{
		watts,
		kilowatts,
	}

	[System.SerializableAttribute()]
	public enum MillimeterUnitOfMeasure
	{
		millimeters,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum NoiseLevelUnitOfMeasure
	{
		dBA,
		decibels,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum TemperatureUnitOfMeasure
	{
		C,
		F,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum TemperatureRatingUnitOfMeasure
	{
		[System.Xml.Serialization.XmlEnumAttribute("degrees-celsius")]
		degreescelsius,
		[System.Xml.Serialization.XmlEnumAttribute("degrees-fahrenheit")]
		degreesfahrenheit,
		kelvin,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ClothingSizeUnitOfMeasure
	{
		IN,
		CM,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum CurrentUnitOfMeasure
	{
		mA,
		A,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ForceUnitOfMeasure
	{
		newtons,
		Newton,
		pounds,
		kilograms,
		PSI,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum HardnessUnitOfMeasure
	{
		brinnell,
		vickers,
		rockwell_a,
		rockwell_b,
		rockwell_c,
		rockwell_d,
		shore_a,
		shore_b,
		shore_c,
		shore_d,
		shore_do,
		shore_e,
		shore_m,
		shore_o,
		shore_oo,
		shore_ooo,
		shore_ooo_s,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum SweetnessAtHarvestUnitOfMeasure
	{
		brix,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum VineyardYieldUnitOfMeasure
	{
		tons,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum AlcoholContentUnitOfMeasure
	{
		percent_by_volume,
		percent_by_weight,
		unit_of_alcohol,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum TorqueUnitOfMeasure
	{
		[System.Xml.Serialization.XmlEnumAttribute("foot-lbs")]
		footlbs,
		[System.Xml.Serialization.XmlEnumAttribute("inch-lbs")]
		inchlbs,
		centimeter_kilograms,
		foot_pounds,
		inch_ounces,
		inch_pounds,
		kilonewtons,
		kilograms_per_millimeter,
		newton_meters,
		newton_millimeters,
		newtons,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ZoomUnitOfMeasure
	{
		x,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum PixelUnitOfMeasure
	{
		pixels,
		MP,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum PressureUnitOfMeasure
	{
		bars,
		psi,
		pascal,
	}

	[System.SerializableAttribute()]
	public enum OpticalPowerUnitOfMeasure
	{
		diopters
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum PowerUnitOfMeasure
	{
		watts,
		kilowatts,
		horsepower,
		[System.Xml.Serialization.XmlEnumAttribute("watts-per-sec")]
		wattspersec,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ResolutionUnitOfMeasure
	{
		megapixels,
		pixels,
		lines_per_inch,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ApertureUnitOfMeasure
	{
		f,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ContinuousShootingUnitOfMeasure
	{
		frames,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum EnergyConsumptionUnitOfMeasure
	{
		kilowatt_hours,
		btu,
		kilowatts,
		watt_hours,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum SportsMaximumPitchSpeedUnitOfMeasure
	{
		kilometer,
		mph,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum SpeedUnitOfMeasure
	{
		feet_per_minute,
		miles_per_hour,
		kilometers_per_hour,
		RPM,
		RPS,
		[System.Xml.Serialization.XmlEnumAttribute("meters per second")]
		meterspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("centimeters per second")]
		centimeterspersecond,
		[System.Xml.Serialization.XmlEnumAttribute("millimeters per second")]
		millimeterspersecond,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum MagnificationUnitOfMeasure
	{
		multiplier_x,
		diopters,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum NeckSizeUnitOfMeasure
	{
		CM,
		IN,
		MM,
		M,
		FT,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum CycleLengthUnitOfMeasure
	{
		CM,
		IN,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum BootSizeUnitOfMeasure
	{
		adult_us,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum DensityUnitOfMeasure
	{
		grams_per_square_meter,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum CapacityUnitMeasure
	{
		cubic_centimeters,
		cubic_feet,
		cubic_inches,
		cubic_meters,
		cubic_yards,
		cups,
		fluid_ounces,
		gallons,
		imperial_gallons,
		liters,
		milliliters,
		ounces,
		pints,
		quarts,
		deciliters,
		centiliters,
		microliters,
		nanoliters,
		
		picoliters,
		grams,
		kilograms,
		[System.Xml.Serialization.XmlEnumAttribute("ounces")]
		ounces1,
		pounds,
		milligrams,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum ServingUnit
	{
		[System.Xml.Serialization.XmlEnumAttribute("percent-fda")]
		percentfda,
		mg,
		gr,
		ml,
		grams,
		milligrams,
		milliliters,
	}


}
