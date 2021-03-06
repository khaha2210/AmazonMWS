﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class Music : ProductProductData
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class MusicProductType { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute("MusicClassical", typeof(MusicClassical))]
[System.Xml.Serialization.XmlElementAttribute("MusicPopular", typeof(MusicPopular))] public object Item { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(MusicProductType)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum MusicFormatType { authorized_bootleg, bsides, best_of, box_set, original_recording, reissued, remastered, soundtrack, special_edition, special_limited_edition, cast_recording, compilation, deluxe_edition, digital_sound, double_lp, explicit_lyrics, [System.Xml.Serialization.XmlEnumAttribute("hi-fidelity")] hifidelity, import, limited_collectors_edition, limited_edition, remixes, live, extra_tracks, cutout, cd_and_dvd, dual_disc, hybrid_sacd, [System.Xml.Serialization.XmlEnumAttribute("cd-single")] cdsingle, maxi_single, sacd, minidisc, uk_import, us_import, jp_import, enhanced, clean, copy_protected_cd, [System.Xml.Serialization.XmlEnumAttribute("double_lp")] double_lp1, [System.Xml.Serialization.XmlEnumAttribute("soundtrack")] soundtrack1, [System.Xml.Serialization.XmlEnumAttribute("cd-single")] cdsingle1, [System.Xml.Serialization.XmlEnumAttribute("remastered")] remastered1, [System.Xml.Serialization.XmlEnumAttribute("box_set")] box_set1, double_cd, karaoke, [System.Xml.Serialization.XmlEnumAttribute("limited_edition")] limited_edition1, [System.Xml.Serialization.XmlEnumAttribute("maxi_single")] maxi_single1, mp3_audio, ringle, [System.Xml.Serialization.XmlEnumAttribute("cd_and_dvd")] cd_and_dvd1, shm_cd, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum MusicMediaType { lp_record, audioCD, cassette, dvd_audio, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum MusicAspectRatioType {[System.Xml.Serialization.XmlEnumAttribute("1.33:1")] Item1331, [System.Xml.Serialization.XmlEnumAttribute("1.85:1")] Item1851, [System.Xml.Serialization.XmlEnumAttribute("2.35:1")] Item2351, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MusicClassicalLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum AudioEncodingType {[System.Xml.Serialization.XmlEnumAttribute("5_1_disney_enhanced_home_theater_mix")] Item5_1_disney_enhanced_home_theater_mix, [System.Xml.Serialization.XmlEnumAttribute("7_1_disney_enhanced_home_theater_mix")] Item7_1_disney_enhanced_home_theater_mix, analog, digital_atrac, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_1.0")] dolby_digital_10, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0")] dolby_digital_20, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0_mono")] dolby_digital_20_mono, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0_stereo")] dolby_digital_20_stereo, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0_surround")] dolby_digital_20_surround, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.1")] dolby_digital_21, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_3.0")] dolby_digital_30, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_4.0")] dolby_digital_40, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_4.1")] dolby_digital_41, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.0")] dolby_digital_50, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.1")] dolby_digital_51, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.1_es")] dolby_digital_51_es, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.1_ex")] dolby_digital_51_ex, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_6.1_es")] dolby_digital_61_es, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_6.1_ex")] dolby_digital_61_ex, dolby_digital_ex, dolby_digital_live, dolby_digital_plus, dolby_digital_plus_2_0, dolby_digital_plus_5_1, dolby_stereo_analog, dolby_surround, dolby_truehd, dolby_truehd_5_1, [System.Xml.Serialization.XmlEnumAttribute("dts_5.0")] dts_50, [System.Xml.Serialization.XmlEnumAttribute("dts_5.1")] dts_51, [System.Xml.Serialization.XmlEnumAttribute("dts_6.1")] dts_61, dts_6_1_es, [System.Xml.Serialization.XmlEnumAttribute("dts_6.1_es")] dts_61_es, dts_es, dts_hd_high_res_audio, dts_interactive, hi_res_96_24_digital_surround, mlp_lossless, mono, [System.Xml.Serialization.XmlEnumAttribute("mpeg_1_2.0")] mpeg_1_20, [System.Xml.Serialization.XmlEnumAttribute("mpeg_2_5.1")] mpeg_2_51, pcm, pcm_24bit_96khz, pcm_mono, pcm_stereo, pcm_surround, quadraphonic, stereo, surround, thx_surround_ex, unknown_audio_encoding, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum MusicPopularLithiumBatteryPackaging { batteries_contained_in_equipment, batteries_only, batteries_packed_with_equipment, }

}
