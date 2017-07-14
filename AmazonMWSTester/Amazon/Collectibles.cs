using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Collectibles : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] [System.ComponentModel.DesignerCategoryAttribute("code")] [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class CollectiblesProductType { private static System.Xml.Serialization.XmlSerializer serializer;[System.Xml.Serialization.XmlElementAttribute("AdvertisementCollectibles", typeof(AdvertisementCollectibles))] [System.Xml.Serialization.XmlElementAttribute("HistoricalCollectibles", typeof(HistoricalCollectibles))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(CollectiblesProductType)); } return serializer; } } }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")] [System.SerializableAttribute()] public enum Originality { Original, [System.Xml.Serialization.XmlEnumAttribute("Original Limited Edition")] OriginalLimitedEdition, Reproduced, [System.Xml.Serialization.XmlEnumAttribute("Reproduced Limited Edition")] ReproducedLimitedEdition, Replica, [System.Xml.Serialization.XmlEnumAttribute("Replica Limited Edition")] ReplicaLimitedEdition, [System.Xml.Serialization.XmlEnumAttribute("Limited Edition")] LimitedEdition, Manufactured, Licensed, Vintage, }

}
