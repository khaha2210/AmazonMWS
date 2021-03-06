﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Video : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class VideoProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("VideoDVD", typeof(VideoDVD))]
[System.Xml.Serialization.XmlElementAttribute("VideoVHS", typeof(VideoVHS))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(VideoProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum VideoFormatType {[System.Xml.Serialization.XmlEnumAttribute("ac-3")] ac3, dolby, thx, pal, ntsc, bw, color, subtitled, dubbed, [System.Xml.Serialization.XmlEnumAttribute("closed-captioned")] closedcaptioned, import, remastered, widescreen, [System.Xml.Serialization.XmlEnumAttribute("hi-fidelity")] hifidelity, collectors_edition, silent, directors_cut, full_screen, anamorphic, surround, dts_stereo, dvd_video, vhs, vhs_c, hybrid_sacd, digital_sound, deluxe_edition, special_extended_version, special_limited_edition, mono, dual_disc, value_price, multisystem, hd_dvd, blu_ray, umd, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum BluRayRegionType { region_a, region_b, region_c, region_free, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum VideoAspectRatioType {[System.Xml.Serialization.XmlEnumAttribute("1.33:1")] Item1331, [System.Xml.Serialization.XmlEnumAttribute("1.37:1")] Item1371, [System.Xml.Serialization.XmlEnumAttribute("1.44:1")] Item1441, [System.Xml.Serialization.XmlEnumAttribute("1.55:1")] Item1551, [System.Xml.Serialization.XmlEnumAttribute("1.66:1")] Item1661, [System.Xml.Serialization.XmlEnumAttribute("1.75:1")] Item1751, [System.Xml.Serialization.XmlEnumAttribute("1.77:1")] Item1771, [System.Xml.Serialization.XmlEnumAttribute("1.78:1")] Item1781, [System.Xml.Serialization.XmlEnumAttribute("1.85:1")] Item1851, [System.Xml.Serialization.XmlEnumAttribute("2.20:1")] Item2201, [System.Xml.Serialization.XmlEnumAttribute("2.35:1")] Item2351, [System.Xml.Serialization.XmlEnumAttribute("2.40:1")] Item2401, [System.Xml.Serialization.XmlEnumAttribute("2.55:1")] Item2551, [System.Xml.Serialization.XmlEnumAttribute("2:1")] Item21, unknown_aspect_ratio, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum BBFC_Rating_Type { ages_12_and_over, ages_15_and_over, ages_18_and_over, exempt, parental_guidance, to_be_announced, universal, universal_childrens, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum CNC_Rating_Type { universal, parental_guidance, ages_12_and_over, ages_14_and_over, ages_16_and_over, ages_18_and_over, ages_18_and_over_x_rated, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum CBFC_Rating_Type { adults_only, parental_guidance, special_audience, Universal, not_rated, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum FSK_Rating_Type { ages_6_and_over, ages_12_and_over, ages_16_and_over, ages_18_and_over, checked_by_legal_department, cannot_publicize, not_checked, unknown, without_age_limitation, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum MPAARatingType { g, [System.Xml.Serialization.XmlEnumAttribute("nc-17")] nc17, pg, [System.Xml.Serialization.XmlEnumAttribute("pg-13")] pg13, nr, unrated, r, x, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum ItalianAgeRatingType { vm18, vm14, t, x, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum ICAARatingType { ages_12_and_over, ages_16_and_over, ages_18_and_over, ages_7_and_over, ages_7_and_over_recommended_for_children, all_ages, all_ages_recommended_for_children, rated_x, to_be_announced, unknown, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum VideoDVDMediaType { dvd, hd_dvd, blu_ray, videodisc, dvd_i, dvd_r, umd, video_cd, mini_disc, laser_disc, cassette, [System.Xml.Serialization.XmlEnumAttribute("blu_ray")] blu_ray1, audioCD, usb_flash_drive, mp3_cd, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum VideoBindingType { dvd, blu_ray, hd_dvd, umd, VHStape, videotape, cassette, mp3_cd, cd_rom, audioCD, dvd_r, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum ChromatismType { black_and_white, color, [System.Xml.Serialization.XmlEnumAttribute("color/black_and_white")] colorblack_and_white, colorized, tinted, unknown_chromatism, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum VideoDVDLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum ThreeDTechnologyValues { active, anaglyphic, auto_stereoscopic, passive, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum VideoVHSMediaType { VHStape, videotape, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum VideotapeRecordingSpeedType { unknown, sp, ep, slp, lp, Unknown, SP, EP, SLP, LP, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum VideoVHSLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }

}
