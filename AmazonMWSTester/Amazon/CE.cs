﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class CE : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CEProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("ConsumerElectronics", typeof(ConsumerElectronics))]
[System.Xml.Serialization.XmlElementAttribute("PC", typeof(PC))]
[System.Xml.Serialization.XmlElementAttribute("PDA", typeof(PDA))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CEProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CEDataTransferRate { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DataTransferUnitOfMeasure unitOfMeasure { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitOfMeasureSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "nonNegativeInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CEDataTransferRate)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CEPortedBoxVolume { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public VolumeUnitOfMeasure unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CEPortedBoxVolume)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CESealedBoxVolume { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public VolumeUnitOfMeasure unitOfMeasure { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CESealedBoxVolume)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum CEProductSubtype { Antenna, AVFurniture, BarCodeReader, Battery, BlankMedia, CableOrAdapter, CarAudioOrTheater, CarElectronics, CECarryingCaseOrBag, CombinedAvDevice, Computer, ComputerDriveOrStorage, ComputerProcessor, ComputerVideoGameController, DigitalVideoRecorder, DVDPlayerOrRecorder, FlashMemory, GPSOrNavigationAccessory, GPSOrNavigationSystem, HandheldOrPDA, HomeTheaterSystemOrHTIB, Keyboards, MemoryReader, Microphone, Monitor, MP3Player, MultifunctionOfficeMachine, NetworkAdapter, NetworkMediaPlayer, NetworkStorage, NetworkTransceiver, NetworkingDevice, NetworkingHub, Phone, PointingDevice, PortableAudio, PortableElectronics, Printer, PrinterConsumable, ReceiverOrAmplifier, RemoteControl, SatelliteOrDSS, Scanner, SoundCard, Speakers, SystemCabinet, SystemPowerDevice, Television, TwoWayRadio, VCR, VideoCard, VideoProjector, Webcam, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum CEFloppyDiskDrive {[System.Xml.Serialization.XmlEnumAttribute("1_44_mb_3_5_inch")] Item1_44_mb_3_5_inch, [System.Xml.Serialization.XmlEnumAttribute("720_kb_3_5_inch")] Item720_kb_3_5_inch, floppy_cd_drive_combo, floppy_cd_rw_dvd_rom_combo, floppy_dvd_drive_combo, ls_120_superdisk, none, unknown, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum CELithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ConsumerElectronicsVariationData { private static System.Xml.Serialization.XmlSerializer serializer; public ConsumerElectronicsVariationDataParentage Parentage { get; set; } public ConsumerElectronicsVariationDataVariationTheme VariationTheme { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool VariationThemeSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ConsumerElectronicsVariationData)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum DataTransferUnitOfMeasure { KHz, MHz, GHz, Mbps, Gbps, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ConsumerElectronicsVariationDataParentage { parent, child, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum ConsumerElectronicsVariationDataVariationTheme { Color, Size, }


}
