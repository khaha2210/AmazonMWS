using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Relationship : AmazonMessageChoice
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RelationshipRelation { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString")] public string SKU { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string SortHeuristic { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string Quantity { get; set; }[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string ComponentNumber { get; set; } public RelationshipRelationChildDetailPageDisplay ChildDetailPageDisplay { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool ChildDetailPageDisplaySpecified { get; set; } public RelationshipRelationType Type { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RelationshipRelation)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RelationshipRelationChildDetailPageDisplay { independently_displayable, display_only_on_parent, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RelationshipRelationType { Variation, DisplaySet, Collection, Accessory, Customized, Part, Complements, Piece, Necessary, ReplacementPart, Similar, Episode, Season, MerchantTitleAuthority, Component, }

}
