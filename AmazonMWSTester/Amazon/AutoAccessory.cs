using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class AutoAccessory : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutoAccessoryProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("AutoAccessoryMisc", typeof(AutoAccessoryMisc))]
[System.Xml.Serialization.XmlElementAttribute("AutoPart", typeof(AutoPart))]
[System.Xml.Serialization.XmlElementAttribute("Autobattery", typeof(Autobattery))]
[System.Xml.Serialization.XmlElementAttribute("Autochemical", typeof(Autochemical))]
[System.Xml.Serialization.XmlElementAttribute("Autooil", typeof(Autooil))]
[System.Xml.Serialization.XmlElementAttribute("CleaningOrRepairKit", typeof(CleaningOrRepairKit))]
[System.Xml.Serialization.XmlElementAttribute("Helmet", typeof(Helmet))]
[System.Xml.Serialization.XmlElementAttribute("Motorcycleaccessory", typeof(Motorcycleaccessory))]
[System.Xml.Serialization.XmlElementAttribute("Motorcyclepart", typeof(Motorcyclepart))]
[System.Xml.Serialization.XmlElementAttribute("PowersportsPart", typeof(PowersportsPart))]
[System.Xml.Serialization.XmlElementAttribute("PowersportsVehicle", typeof(PowersportsVehicle))]
[System.Xml.Serialization.XmlElementAttribute("ProtectiveGear", typeof(ProtectiveGear))]
[System.Xml.Serialization.XmlElementAttribute("RidingApparel", typeof(RidingApparel))]
[System.Xml.Serialization.XmlElementAttribute("Ridingboots", typeof(Ridingboots))]
[System.Xml.Serialization.XmlElementAttribute("Ridinggloves", typeof(Ridinggloves))]
[System.Xml.Serialization.XmlElementAttribute("Rims", typeof(Rims))]
[System.Xml.Serialization.XmlElementAttribute("Tire", typeof(Tire))]
[System.Xml.Serialization.XmlElementAttribute("TireAndWheel", typeof(TireAndWheel))]
[System.Xml.Serialization.XmlElementAttribute("Vehicle", typeof(Vehicle))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutoAccessoryProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum EuAcousticNoiseValue {[System.Xml.Serialization.XmlEnumAttribute("1")] Item1, [System.Xml.Serialization.XmlEnumAttribute("2")] Item2, [System.Xml.Serialization.XmlEnumAttribute("3")] Item3, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum EuEfficiencyClassType { a, b, c, d, e, f, g, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum EuTireClassType { c1, c2, c3, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoAccessoryLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoAccessoryTargetGender { male, female, unisex, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutoAccessoryMiscVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public AutoAccessoryMiscVariationDataParentage Parentage { get; set; } public AutoAccessoryMiscVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutoAccessoryMiscVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutoAccessoryMiscColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutoAccessoryMiscColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutoAccessoryMiscPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutoAccessoryMiscPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum SizeMapType {[System.Xml.Serialization.XmlEnumAttribute("XXXXX-Small")] XXXXXSmall, [System.Xml.Serialization.XmlEnumAttribute("XXXX-Small")] XXXXSmall, [System.Xml.Serialization.XmlEnumAttribute("XXX-Small")] XXXSmall, [System.Xml.Serialization.XmlEnumAttribute("XX-Small")] XXSmall, [System.Xml.Serialization.XmlEnumAttribute("X-Small")] XSmall, Small, Medium, Large, [System.Xml.Serialization.XmlEnumAttribute("X-Large")] XLarge, [System.Xml.Serialization.XmlEnumAttribute("XX-Large")] XXLarge, [System.Xml.Serialization.XmlEnumAttribute("XXX-Large")] XXXLarge, [System.Xml.Serialization.XmlEnumAttribute("XXXX-Large")] XXXXLarge, [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Large")] XXXXXLarge, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum ShoeWidthType { AAAA, AAA, AA, A, B, C, D, E, [System.Xml.Serialization.XmlEnumAttribute("E")] E1, EE, EEE, EEEE, EEEEE, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum PositionType { left, left_front, left_rear, left_inner, left_outer, left_center, left_upper, left_lower, left_inside, left_outside, right, right_front, right_rear, right_inner, right_outer, right_center, right_upper, right_lower, right_inside, right_outside, front, front_inner, front_outer, front_center, front_upper, front_lower, front_inside, front_outside, rear, rear_inner, rear_outer, rear_center, rear_upper, rear_lower, rear_inside, rear_outside, inner, outer, upper, lower, top, bottom, inside, inside_center, outside, intermediate, driveline, front_left_inner, front_left_outer, front_right_inner, front_right_outer, rear_left_inner, rear_left_outer, rear_right_inner, rear_right_outer, front_left_upper, front_left_lower, front_right_upper, front_right_lower, rear_left_upper, rear_left_lower, rear_right_lower, rear_right_upper, left_intermediate, right_intermediate, bottom_left, bottom_right, top_left, top_right, front_left, front_right, rear_left, rear_right, center, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum WaterResistantType { not_water_resistant, water_resistant, waterproof, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum BatteryCellTypeValues { NiCAD, NiMh, alkaline, aluminum_oxygen, lead_acid, lead_calcium, lithium, lithium_ion, lithium_manganese_dioxide, lithium_metal, lithium_polymer, manganese, polymer, silver_oxide, zinc, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoAccessoryMiscLegalComplianceCertificationStatus { compliant, noncompliant, exempt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutoPartVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public AutoPartVariationDataParentage Parentage { get; set; } public AutoPartVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutoPartVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutoPartColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutoPartColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutoPartPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutoPartPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlRootAttribute("HardwareInterface", Namespace = "", IsNullable = false)] public enum HardwareInterfaceValues {[System.Xml.Serialization.XmlEnumAttribute("1_4_inch_audio")] Item1_4_inch_audio, [System.Xml.Serialization.XmlEnumAttribute("2_5_mm_audio")] Item2_5_mm_audio, [System.Xml.Serialization.XmlEnumAttribute("3.0_v_ttl")] Item30_v_ttl, [System.Xml.Serialization.XmlEnumAttribute("3_5_floppy")] Item3_5_floppy, [System.Xml.Serialization.XmlEnumAttribute("3_5_mm_audio")] Item3_5_mm_audio, ata, ata_flash_card, audio_video_port, bluetooth, built_in_flash_memory, [System.Xml.Serialization.XmlEnumAttribute("cd-r")] cdr, cd_rw, cdr_drive, compact_disc, compact_flash_card, compact_flash_type_i_or_ii, compactflash_type_i, compactflash_type_ii, component_video, composite_video, d_sub, dmi, dssi, dvd_r, dvd_rw, dvi_x_1, dvi_x_2, dvi_x_4, eide, eisa, ethernet, express_card, fibre_channel, firewire_1600, firewire_3200, firewire_400, firewire_800, firewire_esata, game_port, gbic, hdmi, headphone, hp_hsc, hp_pb, hs_mmc, ibm_microdrive, ide, ieee_1284, infrared, internal_w_removable_media, iomega_clik_disk, isa, isp, lanc, mca, media_card, memory_stick, memory_stick_duo, memory_stick_micro, memory_stick_pro, memory_stick_pro_duo, memory_stick_pro_hg_duo, memory_stick_select, memory_stick_xc, memory_stick_xc_hg_micro, memory_stick_xc_micro, micard, micro_sdhc, micro_sdxc, microsd, mini_dvd, mini_hdmi, mini_pci, mini_sdhc, mini_sdxc, minisd, mmc_micro, multimedia_card, multimedia_card_mobile, multimedia_card_plus, multipronged_audio, nubus, parallel_interface, pc_card, pci, pci_64, pci_64_hot_plug, pci_64_hot_plug_33_mhz, pci_64_hot_plug_66_mhz, pci_express_x4, pci_express_x8, pci_hot_plug, pci_raid, pci_x, pci_x_1, pci_x_100_mhz, pci_x_16, pci_x_16_gb, pci_x_4, pci_x_66_mhz, pci_x_8, pci_x_hot_plug, pci_x_hot_plug_133_mhz, pcmcia, pcmcia_ii, pcmcia_iii, pictbridge, [System.Xml.Serialization.XmlEnumAttribute("ps/2")] ps2, radio_frequency, rs_mmc, s_video, sas, sata_1_5_gb, sata_3_0_gb, sata_6_0_gb, sbus, scsi, sdhc, sdio, sdxc, secure_digital, secure_mmc, serial_interface, sim_card, smartmedia_card, solid_state_drive, spd, springboard_module, ssfdc, superdisk, transflash, unknown, usb, [System.Xml.Serialization.XmlEnumAttribute("usb1.0")] usb10, [System.Xml.Serialization.XmlEnumAttribute("usb1.1")] usb11, [System.Xml.Serialization.XmlEnumAttribute("usb2.0")] usb20, [System.Xml.Serialization.XmlEnumAttribute("usb3.0")] usb30, usb_docking_station, usb_streaming, vga, xd_picture_card, xd_picture_card_h, xd_picture_card_m, xd_picture_card_m_plus, ieee_1394, pci_x_133_mhz, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoPartOrientation { passengers_side, drivers_side, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoPartProfile { high, low, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoPartPulleyType { serpentine, v_belt, dual_v_belt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoPartLegalComplianceCertificationStatus { compliant, noncompliant, exempt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutobatteryVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public AutobatteryVariationDataParentage Parentage { get; set; } public AutobatteryVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutobatteryVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutobatteryColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutobatteryColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutobatteryPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutobatteryPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutochemicalPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutochemicalPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutooilPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutooilPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutooilVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public AutooilVariationDataParentage Parentage { get; set; } public AutooilVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutooilVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class AutooilColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(AutooilColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CleaningOrRepairKitVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public CleaningOrRepairKitVariationDataParentage Parentage { get; set; } public CleaningOrRepairKitVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CleaningOrRepairKitVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CleaningOrRepairKitColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CleaningOrRepairKitColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HelmetVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public HelmetVariationDataParentage Parentage { get; set; } public HelmetVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HelmetVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HelmetColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HelmetColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class HelmetPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(HelmetPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HelmetLegalComplianceCertificationStatus { compliant, noncompliant, exempt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcycleaccessoryVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public MotorcycleaccessoryVariationDataParentage Parentage { get; set; } public MotorcycleaccessoryVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcycleaccessoryVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcycleaccessoryColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcycleaccessoryColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcycleaccessoryPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcycleaccessoryPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MotorcycleaccessorySizeMap {[System.Xml.Serialization.XmlEnumAttribute("XXXXX-Small")] XXXXXSmall, [System.Xml.Serialization.XmlEnumAttribute("XXXX-Small")] XXXXSmall, [System.Xml.Serialization.XmlEnumAttribute("XXX-Small")] XXXSmall, [System.Xml.Serialization.XmlEnumAttribute("XX-Small")] XXSmall, [System.Xml.Serialization.XmlEnumAttribute("X-Small")] XSmall, Small, Medium, Large, [System.Xml.Serialization.XmlEnumAttribute("X-Large")] XLarge, [System.Xml.Serialization.XmlEnumAttribute("XX-Large")] XXLarge, [System.Xml.Serialization.XmlEnumAttribute("XXX-Large")] XXXLarge, [System.Xml.Serialization.XmlEnumAttribute("XXXX-Large")] XXXXLarge, [System.Xml.Serialization.XmlEnumAttribute("XXXXX-Large")] XXXXXLarge, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcyclepartVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public MotorcyclepartVariationDataParentage Parentage { get; set; } public MotorcyclepartVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcyclepartVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcyclepartColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcyclepartColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MotorcyclepartPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MotorcyclepartPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PowersportsPartVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public PowersportsPartVariationDataParentage Parentage { get; set; } public PowersportsPartVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PowersportsPartVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PowersportsPartColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PowersportsPartColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PowersportsPartPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PowersportsPartPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsPartOrientation { passengers_side, drivers_side, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsPartProfile { high, low, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsPartPulleyType { serpentine, v_belt, dual_v_belt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsPartLegalComplianceCertificationStatus { compliant, noncompliant, exempt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PowersportsVehicleVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public PowersportsVehicleVariationDataParentage Parentage { get; set; } public PowersportsVehicleVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PowersportsVehicleVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class PowersportsVehicleColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(PowersportsVehicleColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ProtectiveGearVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public ProtectiveGearVariationDataParentage Parentage { get; set; } public ProtectiveGearVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ProtectiveGearVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ProtectiveGearColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ProtectiveGearColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ProtectiveGearPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ProtectiveGearPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ProtectiveGearCupSize { A, B, C, D, DD, DDD, E, F, FF, G, H, I, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ProtectiveGearLegalComplianceCertificationStatus { compliant, noncompliant, exempt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingApparelVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public RidingApparelVariationDataParentage Parentage { get; set; } public RidingApparelVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingApparelVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingApparelColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingApparelColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingApparelClothingType { Gloves, Jacket, Pants, Shirt, Shoes, Suit, Underwear, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingApparelCupSize { A, B, C, D, DD, DDD, E, F, FF, G, H, I, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingApparelLegalComplianceCertificationStatus { compliant, noncompliant, exempt, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingbootsVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public RidingbootsVariationDataParentage Parentage { get; set; } public RidingbootsVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingbootsVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingbootsColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingbootsColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingbootsPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingbootsPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingglovesVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public RidingglovesVariationDataParentage Parentage { get; set; } public RidingglovesVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingglovesVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingglovesColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingglovesColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RidingglovesPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RidingglovesPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RimsVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public RimsVariationDataParentage Parentage { get; set; } public RimsVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RimsVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RimsColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RimsColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RimsPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RimsPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TireVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public TireVariationDataParentage Parentage { get; set; } public TireVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TireVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TireColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TireColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TirePartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TirePartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TireAndWheelVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public TireAndWheelVariationDataParentage Parentage { get; set; } public TireAndWheelVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TireAndWheelVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TireAndWheelColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TireAndWheelColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class TireAndWheelPartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(TireAndWheelPartInterchangeData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class VehicleVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public VehicleVariationDataParentage Parentage { get; set; } public VehicleVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(VehicleVariationData)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class VehicleColorSpecification { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string Color { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string ColorMap { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(VehicleColorSpecification)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class VehiclePartInterchangeData { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string OEManufacturer { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string PartInterchangeInfo { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(VehiclePartInterchangeData)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoAccessoryMiscVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoAccessoryMiscVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoPartVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutoPartVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutobatteryVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutobatteryVariationDataVariationTheme { Color, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutooilVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum AutooilVariationDataVariationTheme { Color, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum CleaningOrRepairKitVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum CleaningOrRepairKitVariationDataVariationTheme { Color, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HelmetVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum HelmetVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MotorcycleaccessoryVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MotorcycleaccessoryVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MotorcyclepartVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MotorcyclepartVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsPartVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsPartVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsVehicleVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum PowersportsVehicleVariationDataVariationTheme { Color, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ProtectiveGearVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ProtectiveGearVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingApparelVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingApparelVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingbootsVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingbootsVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingglovesVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RidingglovesVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RimsVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RimsVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum TireVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum TireVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum TireAndWheelVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum TireAndWheelVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum VehicleVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum VehicleVariationDataVariationTheme { Size, Color, [System.Xml.Serialization.XmlEnumAttribute("Size-Color")] SizeColor, }


}
