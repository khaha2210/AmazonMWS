using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Industrial : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class IndustrialProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("Abrasives", typeof(Abrasives))]
[System.Xml.Serialization.XmlElementAttribute("AdhesivesAndSealants", typeof(AdhesivesAndSealants))]
[System.Xml.Serialization.XmlElementAttribute("CuttingTools", typeof(CuttingTools))]
[System.Xml.Serialization.XmlElementAttribute("ElectronicComponents", typeof(ElectronicComponents))]
[System.Xml.Serialization.XmlElementAttribute("Gears", typeof(Gears))]
[System.Xml.Serialization.XmlElementAttribute("Grommets", typeof(Grommets))]
[System.Xml.Serialization.XmlElementAttribute("IndustrialHose", typeof(IndustrialHose))]
[System.Xml.Serialization.XmlElementAttribute("IndustrialWheels", typeof(IndustrialWheels))]
[System.Xml.Serialization.XmlElementAttribute("MechanicalComponents", typeof(MechanicalComponents))]
[System.Xml.Serialization.XmlElementAttribute("ORings", typeof(ORings))]
[System.Xml.Serialization.XmlElementAttribute("PrecisionMeasuring", typeof(PrecisionMeasuring))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(IndustrialProductType)); } return serializer; } } 
}

}
