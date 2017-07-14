using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Books : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class BooksProductType { private BooksMisc itemField; private static System.Xml.Serialization.XmlSerializer serializer; public BooksProductType() { this.itemField = new BooksMisc(); }[System.Xml.Serialization.XmlElementAttribute("BooksMisc")] public BooksMisc Item { get { return this.itemField; } set { this.itemField = value; } } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BooksProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum BooksVideoFormatType { engagement_calendar, student_calendar, sticker_book, audiobook, box_set, almanac_calendar, desk_calendar, wall_calendar, poster_calendar, advent_calendar, box_calendar, perpetual_calendar, day_to_day_calendar, project_calendar, collectors_edition, deluxe_edition, special_edition, special_extended_version, special_limited_edition, international_edition, standard_edition, large_print, coloring_book, picture_book, teachers_edition, pop_up, antique_books, wall_map, folded_map, bookmark_calendar, mini_calendar, other_calendar, roughcut, unabridged, abridged, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum BindingTypes { Accessory, Album, Audiocd, Audiodownload, Bathbook, Boardbook, Bondedleather, Calendar, Cardbook, Cards, Cassette, Cdrom, Comic, Diary, Dvdrom, Flexibound, Foambook, Game, Hardcover, Hardcovercomic, Hardcoverspiral, Imitationleather, Journal, Kindleedition, Leatherbound, Library, Libraryaudiocd, Libraryaudiomp3, Looseleaf, Map, Massmarket, Microfiche, Microfilm, Miscsupplies, Mook, Mp3cd, Pamphlet, Paperback, Paperbackbunko, Paperbackshinsho, Perfect, Plasticcomb, Popup, Preloadeddigitalaudioplayer, Ragbook, Ringbound, Roughcut, School, Sheetmusic, Singleissuemagazine, Slide, Spiralbound, Stationery, Tankobonhardcover, Tankobonsoftcover, Textbook, Toy, Transparency, Turtleback, Unbound, Vinylbound, Wallchart, Workbook, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum DustJacketTypes { NoDustJacket, LikeNew, VeryGood, Good, Acceptable, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum SignedByValues { Author, Illustrator, Editor, Photographer, Other, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum SourceCountryCodeValues { JP, US, GB, DE, Unknown, }

}
