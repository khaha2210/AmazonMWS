using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMWSTester.Amazon
{
	public partial class ProductAttributes
	{
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum activitiesValue { activity_box_required, activity_requires_asin_sticker, activity_padding_required, activity_bagging_required, activity_requires_box_building, activity_requires_overwrap, activity_requires_cardboard_footprint, exception_no_upc, unprep_remove_box, unprep_remove_bagging, unprep_requires_asin_sticker, unprep_apparel_handling, create_purchaseable_item_set_of_2, create_purchaseable_item_set_of_3, create_purchaseable_item_set_of_4, create_purchaseable_item_special_set, activity_requires_ticketing, activity_break_item_down, sold_as_set, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum additional_drivesValue { dvd, dvd_rw, dvd_plus_rw, cd_rw, cd_rom, zip, jazz, floppy, thumb_drive, dvd_cd_rw, dvd_r, dvd_plus_r, dvd_plus_minus_rw, dvd_ram, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class amperageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public amperageValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(amperageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum antenna_typeValue { retractable, @fixed, @internal, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum audio_encodingValue {[System.Xml.Serialization.XmlEnumAttribute("dts_6.1_es")] dts_61_es, dts_es, surround, dolby_surround, unknown_audio_encoding, [System.Xml.Serialization.XmlEnumAttribute("dts_5.1")] dts_51, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_1.0")] dolby_digital_10, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0")] dolby_digital_20, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0_mono")] dolby_digital_20_mono, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0_stereo")] dolby_digital_20_stereo, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.0_surround")] dolby_digital_20_surround, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_3.0")] dolby_digital_30, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_4.0")] dolby_digital_40, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_4.1")] dolby_digital_41, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.0")] dolby_digital_50, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.1")] dolby_digital_51, [System.Xml.Serialization.XmlEnumAttribute("mpeg_1_2.0")] mpeg_1_20, [System.Xml.Serialization.XmlEnumAttribute("mpeg_2_5.1")] mpeg_2_51, pcm, pcm_mono, pcm_stereo, pcm_surround, pcm_24bit_96khz, thx_surround_ex, mono, analog, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_2.1")] dolby_digital_21, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_6.1_ex")] dolby_digital_61_ex, stereo, digital_atrac, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.1_es")] dolby_digital_51_es, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_6.1_es")] dolby_digital_61_es, [System.Xml.Serialization.XmlEnumAttribute("dts_6.1")] dts_61, [System.Xml.Serialization.XmlEnumAttribute("dolby_digital_5.1_ex")] dolby_digital_51_ex, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class audio_sensitivityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public audio_sensitivityValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(audio_sensitivityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class battery_average_lifeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public battery_average_lifeValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(battery_average_lifeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class battery_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public battery_capacityValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(battery_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum battery_cell_compositionValue { NiCAD, NiMh, alkaline, aluminum_oxygen, lead_acid, lead_calcium, lithium, lithium_ion, lithium_manganese_dioxide, lithium_metal, lithium_polymer, manganese, polymer, silver_oxide, zinc, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class battery_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public battery_powerValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(battery_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum colorValue { unknown, red, green, blue, orange, yellow, black, white, brown, purple, burgundy, antiquewhite, aqua, aquamarine, beige, berry, blueviolet, cadetblue, chocolate, clear, dandelion, darkblue, darkgray, darkgreen, darkred, darkslategray, fuchsia, gold, gray, greenyellow, indigo, ivory, khaki, kiwi, lavender, lightblue, lightgreen, lightgrey, lightpink, limegreen, magenta, maroon, midnightblue, navy, olive, olivedrab, pink, powderblue, royalblue, salmon, sandybrown, silver, tan, turquoise, violet, wheat, whitesmoke, ice, graphitegray, chrome, stainlesssteel, teal, yellowgreen, transparent, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class computer_cpu_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public computer_cpu_speedValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitValueSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(computer_cpu_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum CountryList { UNKNOWN, AD, AE, AG, AI, AL, AM, AO, AQ, AR, AS, AT, AU, AW, BA, BB, BD, BE, BF, BG, BH, BI, BJ, BM, BN, BO, BR, BS, BT, BW, BY, BZ, CA, CF, CG, CH, CI, CK, CL, CM, CN, CO, CR, CU, CV, CY, CZ, DE, DJ, DK, DM, DO, DZ, EC, EE, EG, ER, ES, ET, FI, FJ, FK, FO, FR, GA, GB, GD, GE, GF, GG, GH, GI, GL, GM, GN, GP, GQ, GR, GT, GU, GW, GY, HK, HN, HR, HT, HU, IC, ID, IE, IL, IN, IQ, IR, IS, IT, JE, JM, JO, JP, KE, KG, KH, KI, KM, KN, KP, KR, KW, KY, KZ, LA, LB, LC, LI, LK, LR, LS, LT, LU, LV, LY, MA, MC, MG, MH, MK, ML, MM, MN, MO, MP, MQ, MR, MS, MT, MU, MV, MW, MX, MY, MZ, NA, NC, NE, NG, NI, NL, NO, NP, NR, NU, NZ, OM, PA, PE, PF, PG, PH, PK, PL, PR, PT, PY, QA, RE, RO, RU, RW, SA, SB, SC, SE, SG, SI, SK, SL, SN, SO, SR, ST, SV, SX, SY, SZ, TC, TD, TG, TH, TJ, TM, TN, TO, TR, TT, TV, TW, TZ, UA, UG, US, UY, UZ, VC, VE, VG, VI, VN, VU, WD, WS, WZ, XB, XC, XE, XM, XN, XY, YE, YU, ZA, ZM, ZR, ZW, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum cpsia_cautionary_statementValue { choking_hazard_balloon, choking_hazard_contains_a_marble, choking_hazard_contains_small_ball, choking_hazard_is_a_marble, choking_hazard_is_a_small_ball, choking_hazard_small_parts, no_warning_applicable, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum customer_return_methodValue { unknown, no_return, mail, store, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum customer_return_policyValue { unknown, non_returnable, restocking_fee, seasonal, collectible, standard, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum esrb_age_ratingValue { early_childhood, kids_to_adults, teen, mature, adults_only, rating_pending, rating_pending_mature, everyone, everyone_10_plus, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum esrb_descriptorsValue { alcohol_and_tobacco_reference, alcohol_reference, animated_blood, animated_blood_and_gore, animated_violence, blood, blood_and_gore, cartoon_violence, comic_mischief, crude_humor, drug_and_alcohol_reference, drug_reference, edutainment, fantasy_violence, gambling, gaming, graphic_violence, informational, intense_violence, language, lyrics, mature_humor, mature_sexual_themes, mild_animated_blood, mild_animated_violence, mild_blood, mild_cartoon_violence, mild_fantasy_violence, mild_language, mild_lyrics, mild_realistic_violence, mild_sexual_themes, mild_suggestive_themes, mild_violence, nudity, partial_nudity, real_gambling, realistic_blood, realistic_blood_and_gore, realistic_violence, sexual_content, sexual_themes, sexual_violence, simulated_gambling, some_adult_assistance_may_be_needed, strong_language, strong_lyrics, strong_sexual_content, suggestive_themes, suitable_for_all_users, suitable_for_mature_users, tobacco_reference, use_of_alcohol, use_of_alcohol_and_tobacco, use_of_drugs, use_of_drugs_and_alcohol, use_of_tobacco, violence, violent_references, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class expiration_intervalValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public expiration_intervalValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(expiration_intervalValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum film_color_typeValue {[System.Xml.Serialization.XmlEnumAttribute("black-and-white")] blackandwhite, color, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum film_format_typeValue {[System.Xml.Serialization.XmlEnumAttribute("35mm")] Item35mm, [System.Xml.Serialization.XmlEnumAttribute("70mm")] Item70mm, [System.Xml.Serialization.XmlEnumAttribute("110")] Item110, [System.Xml.Serialization.XmlEnumAttribute("120")] Item120, [System.Xml.Serialization.XmlEnumAttribute("220")] Item220, [System.Xml.Serialization.XmlEnumAttribute("2x3")] Item2x3, [System.Xml.Serialization.XmlEnumAttribute("4x5")] Item4x5, [System.Xml.Serialization.XmlEnumAttribute("5x7")] Item5x7, [System.Xml.Serialization.XmlEnumAttribute("8x10")] Item8x10, [System.Xml.Serialization.XmlEnumAttribute("11x14")] Item11x14, aps, micro, instant, other, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum film_lighting_typeValue { daylight, infrared, tungsten, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum flash_dedicationValue { dedicated, [System.Xml.Serialization.XmlEnumAttribute("non-dedicated")] nondedicated, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum focus_typeValue {[System.Xml.Serialization.XmlEnumAttribute("auto-focus")] autofocus, [System.Xml.Serialization.XmlEnumAttribute("manual-focus")] manualfocus, [System.Xml.Serialization.XmlEnumAttribute("manual-and-auto-focus")] manualandautofocus, [System.Xml.Serialization.XmlEnumAttribute("focus-free")] focusfree, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum formatValue { clv, [System.Xml.Serialization.XmlEnumAttribute("ac-3")] ac3, dolby, thx, sega, nintendo, pal, ntsc, bw, color, subtitled, supratitled, dubbed, [System.Xml.Serialization.XmlEnumAttribute("closed-captioned")] closedcaptioned, threeD, abridged, laser_printed, photocopy, diskette35, diskette525, drama_enhanced, tarot, flash, classical, soundtrack, [System.Xml.Serialization.XmlEnumAttribute("full-length")] fulllength, [System.Xml.Serialization.XmlEnumAttribute("cd-single")] cdsingle, import, [System.Xml.Serialization.XmlEnumAttribute("cd-4")] cd4, original_recording, remastered, reissued, remixes, bsides, extra_tracks, box_set, facsimile, gold_cd, explicit_lyrics, audiobook, widescreen, miniseries, dvt, [System.Xml.Serialization.XmlEnumAttribute("hi-fidelity")] hifidelity, collectors_edition, silent, directors_cut, full_screen, anamorphic, dvd_region, surround, dts_stereo, cx_encoding, animated, large_print, braille, enhanced, cast_recording, sacd, live, studio, secam, bargain_price, adobe_ebook_reader, everybook, microsoft_reader_desktop, limited_edition, electronic_software_download, extended_play, maxi_single, html, pdf, magazine_subscription, adult, wall_calendar, desk_calendar, box_calendar, engagement_calendar, mp3_audio, [System.Xml.Serialization.XmlEnumAttribute("8_mm")] Item8_mm, adpcm, atrac3, digital_8, dvd_ram, dvd_rom, dvd_video, hi_8, minidisc, minidv, mpeg_2_5, real_audio, realaudio_g2, vhs, vhs_c, uk_import, us_import, best_of, double_lp, highlights, complete, hybrid_sacd, newspaper_subscription, palm_ebook_reader, unknown_format, playstation, letterboxed, unabridged, processor386, compilation, [System.Xml.Serialization.XmlEnumAttribute("cd-6")] cd6, authorized_bootleg, double_cd, karaoke, restored, special_edition, digital_sound, criterion, cutout, clean, copy_protected_cd, newsletter_subscription, deluxe_edition, limited_collectors_edition, special_extended_version, special_limited_edition, ultimate_edition, aus_import, ca_import, jp_import, mono, wav, wma, vqf, aiff, mpeg, avi, memory_stick, compact_flash, cd, smart_media, xd_card, illustrated, student_edition, teachers_edition, rental, ali, alx, cab, cod, csv, dff, doc, exe, gif, ipk, jad, jar, jpg, mdb, mde, pdb, pqa, prc, prn, rar, sis, sit, tiff, txt, wks, xls, xml, zip, amazon_ebook_reader, bookplus_reader, registration_code, cd_rom, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum for_use_with_product_typeValue {[System.Xml.Serialization.XmlEnumAttribute("film-cameras")] filmcameras, [System.Xml.Serialization.XmlEnumAttribute("digital-cameras")] digitalcameras, camcorders, telescopes, microscopes, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum fulfill_readiness_condValue { unknown, drop_ship_ready, po_ready, receive_ready, not_ready, exception_receive_ready, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class golf_club_loftValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public golf_club_loftValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitValueSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(golf_club_loftValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum graphics_card_interfaceValue { unknown, integrated, agp, pci, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum guitar_attributeValue { dreadnought, fretless, [System.Xml.Serialization.XmlEnumAttribute("grand-auditorium")] grandauditorium, [System.Xml.Serialization.XmlEnumAttribute("grand-concert")] grandconcert, jumbo, mini, nex, [System.Xml.Serialization.XmlEnumAttribute("shallow-body")] shallowbody, [System.Xml.Serialization.XmlEnumAttribute("short-scale")] shortscale, travel, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum guitar_bridge_systemValue { @fixed, tremolo, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum guitar_pick_thicknessValue {[System.Xml.Serialization.XmlEnumAttribute("extra-thick")] extrathick, thick, medium, thin, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum guitar_pickup_configurationValue { humbucker, [System.Xml.Serialization.XmlEnumAttribute("magnetic-combination")] magneticcombination, [System.Xml.Serialization.XmlEnumAttribute("magnetic-double-coil")] magneticdoublecoil, [System.Xml.Serialization.XmlEnumAttribute("magnetic-single-coil")] magneticsinglecoil, piezoelectric, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class handle_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(handle_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum hard_disk_interfaceValue { unknown, eide, ide, scsi, ultra_160_scsi, ultra_wide_scsi, ultra2_scsi, ultra3_scsi, ultra_ata, ata100, serial_ata, firewire, [System.Xml.Serialization.XmlEnumAttribute("usb_1.1")] usb_11, [System.Xml.Serialization.XmlEnumAttribute("usb_2.0")] usb_20, ata133, raid, ata, ata_2, ata_3, ata_4, atapi, fdd, ethernet_10base_t, ethernet_100base_tx, ethernet_100base_t, ieee_1284, pc_card, serial_ata150, dma, ultra_320_scsi, fibre_channel, eio, esdi, fast_wide_scsi, fast_scsi, fata, fc_al, fc_al_2, ieee_1394b, lvds, ssa, st412, ultra_scsi, ultra2_wide_scsi, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum hardware_interfaceValue { unknown, [System.Xml.Serialization.XmlEnumAttribute("3_5_floppy")] Item3_5_floppy, ata_flash_card, built_in_flash_memory, cdr_drive, compact_disc, compact_flash_type_i_or_ii, compactflash_type_i, ethernet, headphone, ibm_microdrive, infrared, internal_w_removable_media, lanc, media_card, memory_stick, multimedia_card, pc_card, s_video, secure_digital, smartmedia_card, springboard_module, ssfdc, superdisk, usb, [System.Xml.Serialization.XmlEnumAttribute("cd-r")] cdr, audio_video_port, compact_flash_card, compactflash_type_ii, ieee_1394, iomega_clik_disk, parallel_interface, serial_interface, usb_docking_station, [System.Xml.Serialization.XmlEnumAttribute("usb2.0")] usb20, usb_streaming, [System.Xml.Serialization.XmlEnumAttribute("usb1.1")] usb11, pcmcia, pcmcia_ii, pcmcia_iii, xd_picture_card, minisd, rs_mmc, transflash, fibre_channel, [System.Xml.Serialization.XmlEnumAttribute("3.0_v_ttl")] Item30_v_ttl, bluetooth, dssi, eisa, gbic, hp_hsc, hp_pb, ide, isa, isp, mca, mini_pci, nubus, pci, pci_64, pci_64_hot_plug, pci_64_hot_plug_33_mhz, pci_64_hot_plug_66_mhz, pci_express_x4, pci_express_x8, pci_hot_plug, pci_raid, pci_x, pci_x_100_mhz, pci_x_133_mhz, pci_x_66_mhz, pci_x_hot_plug, pci_x_hot_plug_133_mhz, sbus, scsi, sdio, spd, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum hazmat_typeValue { unknown, gasoline, fuel_cell, butane, sealed_lead_acid_battery, orm_d_class_1, orm_d_class_2, orm_d_class_3, orm_d_class_4, orm_d_class_5, orm_d_class_6, orm_d_class_7, orm_d_class_8, orm_d_class_9, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum head_size_nameValue {[System.Xml.Serialization.XmlEnumAttribute("mid-plus")] midplus, [System.Xml.Serialization.XmlEnumAttribute("mid-sized")] midsized, [System.Xml.Serialization.XmlEnumAttribute("over-sized")] oversized, [System.Xml.Serialization.XmlEnumAttribute("super-oversized")] superoversized, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class image_capture_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public image_capture_speedValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(image_capture_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum inner_package_typeValue { unknown, jewelry_pouch_small, jewelry_pouch_medium, jewelry_pouch_large, jewelry_standard_double_ring, jewelry_standard_post_earring, jewelry_standard_hanging_earring, jewelry_standard_pendant, jewelry_standard_bracelet, jewelry_standard_necklace_large, jewelry_deluxe_double_ring, jewelry_deluxe_post_earring, jewelry_deluxe_hanging_earring, jewelry_deluxe_pendant, jewelry_deluxe_bracelet, jewelry_deluxe_necklace_large, jewelry_cloth_box, jewelry_cloth_pouch, jewelry_wood_box, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum item_classificationValue { base_product, assortment_parent, bundle_parent, variation_parent, variation_ad_parent, display_set_parent, collection_parent, title_authority_parent, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum LanguageNameList { abkhazian, adygei, afar, afrikaans, albanian, alsatian, amharic, ancient_greek, arabic, aramaic, armenian, assamese, assyrian, austronesian, awadhi, aymara, azerbaijani, balinese, bambara, bantu, bashkir, basque, batak, bengali, berber, bhojpuri, bhutani, bihari, bislama, bosnian, braj, breton, bribri, bulgarian, burmese, buryat, byelorussian, cambodian, cantonese_chinese, castillian, catalan, cayuga, chagatai, chechen, cheyenne, chinese, chiricahua, classical_newari, cornish, corsican, creek, creole, crimean_tatar, croatian, czech, danish, dargwa, dari, dinka, dogri, dutch, dzongkha, english, esperanto, estonian, faroese, farsi, fiji, filipino, finnish, finno_ugrian, flemish, french, french_canadian, frisian, galician, gallegan, georgian, german, gibberish, greek, greenlandic, guarani, gujarati, gullah, hausa, hawaiian, hebrew, hindi, hmong, hokkien, hungarian, icelandic, indic, indo_european, indonesian, ingush, interlingua, interlingue, inuktitun, inuktitut, inupiak, inupiaq, irish, italian, japanese, javanese, jula, kalaallisut, kalmyk, kannada, karachay_balkar, kashmiri, kashubian, kazakh, khmer, kikuyu, kinyarwanda, kirghiz, kirundi, klingon, korean, kuanyama, kurdish, ladino, lao, lapp, latin, latvian, lingala, lithuanian, lojban, lower_sorbian, luo, macedonian, maithili, malagasy, malay, malayalam, maltese, mandarin_chinese, maori, marathi, marshallese, marwari, mayan, mende, middle_english, middle_french, middle_high_german, mirandese, mohawk, moksha, moldavian, mongo, mongolian, multilingual, nahautl, nauru, navaho, ndonga, nepali, nogai, north_ndebele, norwegian, occitan, old_english, old_french, oriya, oromo, pashto, persian, pig_latin, polish, portuguese, punjabi, quechua, rajasthani, romance, romanian, romansch, romany, russian, samaritan, samoan, sangho, sanskrit, serbian, [System.Xml.Serialization.XmlEnumAttribute("serbo-croatian")] serbocroatian, sesotho, setswana, shona, sichuan_yi, sicilian, sign_language, sindhi, sinhalese, sino_tibetan, siswati, slavic, slovak, slovakian, slovene, somali, sorbian_languages, southern_sotho, spanish, sumerian, sundanese, swahili, swedish, swiss_german, syriac, tagalog, tahitian, taiwanese_chinese, tajik, tamil, tatar, telugu, thai, tibetan, tigrinya, tonga, tsonga, turkish, turkmen, tuvinian, twi, tzeltal, udmurt, uighur, ukrainian, ukranian, unknown, urdu, uzbek, vietnamese, volapuk, welsh, wolof, xhosa, yakut, yiddish, yoruba, zhuang, zulu, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum light_meter_display_typeValue { analog, digital, led, [System.Xml.Serialization.XmlEnumAttribute("match-needle")] matchneedle, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum light_power_typeValue { ac, dc, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum light_source_typeValue { flourescent, hmi, tungsten, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum loupe_magnificationValue {[System.Xml.Serialization.XmlEnumAttribute("up-to-4x")] upto4x, [System.Xml.Serialization.XmlEnumAttribute("5x-9x")] Item5x9x, [System.Xml.Serialization.XmlEnumAttribute("10x-15x")] Item10x15x, [System.Xml.Serialization.XmlEnumAttribute("above-15x")] above15x, zoom, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum mallet_hardnessValue {[System.Xml.Serialization.XmlEnumAttribute("extra-hard")] extrahard, hard, medium, soft, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class max_copy_speed_black_whiteValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public max_copy_speed_black_whiteValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(max_copy_speed_black_whiteValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class max_copy_speed_colorValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public max_copy_speed_colorValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(max_copy_speed_colorValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class memory_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public memory_speedValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitValueSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(memory_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum missing_keyset_reasonValue { private_label, specialized, non_consumer, pre_configured, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum moisture_needsValue {[System.Xml.Serialization.XmlEnumAttribute("little-to-no-watering")] littletonowatering, [System.Xml.Serialization.XmlEnumAttribute("moderate-watering")] moderatewatering, [System.Xml.Serialization.XmlEnumAttribute("regular-watering")] regularwatering, [System.Xml.Serialization.XmlEnumAttribute("constant-watering")] constantwatering, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum mpaa_ratingValue { g, [System.Xml.Serialization.XmlEnumAttribute("nc-17")] nc17, pg, [System.Xml.Serialization.XmlEnumAttribute("pg-13")] pg13, nr, unrated, r, x, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class optical_zoomValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public optical_zoomValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool unitValueSpecified { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(optical_zoomValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum package_typeValue { clamshell, snap_case, keep_case, dura_case, slip_sleeve, japanese_case, super_jewel_case, box_set, digipak, blister_pack, jewel_case, polygram_case, custom, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum photo_filter_bayonet_sizeValue {[System.Xml.Serialization.XmlEnumAttribute("b-3")] b3, [System.Xml.Serialization.XmlEnumAttribute("b-39")] b39, [System.Xml.Serialization.XmlEnumAttribute("b-50")] b50, [System.Xml.Serialization.XmlEnumAttribute("b-6")] b6, [System.Xml.Serialization.XmlEnumAttribute("b-60")] b60, [System.Xml.Serialization.XmlEnumAttribute("b-70")] b70, [System.Xml.Serialization.XmlEnumAttribute("b-93")] b93, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum photo_filter_color_nameValue { blue, brown, cyan, green, magenta, orange, red, [System.Xml.Serialization.XmlEnumAttribute("red-orange")] redorange, yellow, [System.Xml.Serialization.XmlEnumAttribute("yellow-orange")] yelloworange, [System.Xml.Serialization.XmlEnumAttribute("yellow-green")] yellowgreen, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum photo_filter_drop_in_sizeValue {[System.Xml.Serialization.XmlEnumAttribute("6-inch-wratten")] Item6inchwratten, [System.Xml.Serialization.XmlEnumAttribute("cokin-a")] cokina, [System.Xml.Serialization.XmlEnumAttribute("cokin-p")] cokinp, [System.Xml.Serialization.XmlEnumAttribute("lee-type")] leetype, [System.Xml.Serialization.XmlEnumAttribute("pro-optic-a")] prooptica, [System.Xml.Serialization.XmlEnumAttribute("pro-optic-p")] proopticp, other, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum photo_filter_mount_typeValue { round, square, bayonet, other, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum photo_paper_baseValue {[System.Xml.Serialization.XmlEnumAttribute("polyester-based")] polyesterbased, [System.Xml.Serialization.XmlEnumAttribute("fiber-based")] fiberbased, [System.Xml.Serialization.XmlEnumAttribute("resin-coated")] resincoated, other, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum photo_paper_gradeValue {[System.Xml.Serialization.XmlEnumAttribute("grade-0")] grade0, [System.Xml.Serialization.XmlEnumAttribute("grade-1")] grade1, [System.Xml.Serialization.XmlEnumAttribute("grade-2")] grade2, [System.Xml.Serialization.XmlEnumAttribute("grade-3")] grade3, [System.Xml.Serialization.XmlEnumAttribute("grade-4")] grade4, multigrade, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum photo_paper_surfaceValue { glossy, [System.Xml.Serialization.XmlEnumAttribute("semi-glossy")] semiglossy, matt, [System.Xml.Serialization.XmlEnumAttribute("semi-matt")] semimatt, pearl, luster, satin, other, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pitch_circle_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pitch_circle_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum platformValue {[System.Xml.Serialization.XmlEnumAttribute("3do")] Item3do, atari_2600, atari_jaguar, atari_st, be_os, colecovision, cybiko, dos, dreamcast, electronic_games, epoc, game_boy_advance, gameboy, gameboy_color, gamecube, linux, mac_os_9_0_and_below, mac_os_x, mac_os_x_cheetah, mac_os_x_intel, mac_os_x_jaguar, mac_os_x_leopard, mac_os_x_panther, mac_os_x_puma, mac_os_x_tiger, macintosh, microsoft_xbox_360, microsoft_xp_media_center, n_gage, neo_geo, neo_geo_pocket, netware, nintendo_NES, nintendo_super_NES, nintendo64, no_operating_system, not_machine_specific, [System.Xml.Serialization.XmlEnumAttribute("os/2")] os2, palm, pda, playstation, playstation_2, pocket_pc, pocket_pc_2002, pocket_pc_2003, powermac, sega_game_gear, sega_genesis, sega_master_system, sega_mega_cd, sega_saturn, sony_playstation3, sony_psp, sun_solaris, super_nintendo, trs_80, unix, virtual_boy, windows, windows_2000_server, windows_2003_server, windows_mobile, windows_mobile_2003, windows_mobile_5, windows_vista, windows_vista_business, windows_vista_enterprise, windows_vista_home_basic, windows_vista_home_premium, windows_vista_ultimate, windows_xp, windows_xp_home, windows_xp_professional, windows_xp_tablet_pc, windows2000, windows3_1, windows3_x, windows95, windows98, windowsCE, windowsME, windowsNT, windowsNT3_5, windowsNT4, windowsNT5, wonderswan, wonderswan_color, xbox, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum original_feed_formatValue {[System.Xml.Serialization.XmlEnumAttribute("MERCHANT_ADVERTISER Shopzilla")] MERCHANT_ADVERTISERShopzilla, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum promotional_tagValue { unknown, award_winner, sale, reduced, clearance, new_arrival, limited_offer, exclusive, hot_buy, as_seen_on_tv, deal_of_the_week, match_the_price, ofoto, share_our_strength, outlet, @new, rebate, value_pack, advertised_special, best_of_e3, toys_r_us_exclusive, special_offer, while_supplies_last, microsoft_windows_xp_installed, new_low_price, upgrade_rebate, bonus, made_in_usa, gone_gold, instant_rebate, markdown, must_have, catalog_web_only, fields_favorite, special_of_the_week, expect_more_pay_less, from_our_catalog, wise_and_witty, big_kitchen_sale, storewide_sale, platinum_dendo, gold_dendo, silver_dendo, babies_r_us_exclusive, woodworking_sale, one_92, only_available_online, editors_choice, amazon_exclusive, special_buy, scarce, reconditioned, friday_sale, outlet_special, microsoft_windows_xp_ready, really_cool_stuff, big_tool_sale, web_only, exclusively_ours, recently_reduced, lowest_price_of_season, big_yard_sale, msn_exclusive, everyday_best_value, unbeatable_value, game_of_year, best_of_2003, best_of_2004, best_of_2005, top_rated, personalize_it, buzz_shop, newest_version, old_version, apple_hot_deal, hot_deal, microsoft_week, r_us_exclusive, special_purchase, only_in_stores, made_in_france, made_in_italy, made_in_great_britain, made_in_thailand, made_in_the_philippines, made_in_mexico, made_in_china, made_in_indonesia, made_in_south_africa, made_in_kenya, made_in_india, made_in_germany, made_in_spain, made_in_portugal, made_in_poland, made_in_turkey, temporary_price_cut, extended_sizes_available, bonus_buy, [System.Xml.Serialization.XmlEnumAttribute("99_cent_shipping")] Item99_cent_shipping, buy_both_and_save, buy_more_and_save, closeout, free_e_giftcard, price_cut, top_registry_item, more_colors_available, get_it_by_the_25th, ga, media36, seasonal, introductory_offer, corporate, our_lowest_price_of_the_season, more_colors_and_extended_sizes_available, free_USD_e_giftcard_with_purchase, free_5_USD_e_giftcard_with_purchase, free_10_USD_e_giftcard_with_purchase, free_15_USD_e_giftcard_with_purchase, free_20_USD_e_giftcard_with_purchase, free_25_USD_e_giftcard_with_purchase, free_30_USD_e_giftcard_with_purchase, free_35_USD_e_giftcard_with_purchase, free_40_USD_e_giftcard_with_purchase, free_50_USD_e_giftcard_with_purchase, free_60_USD_e_giftcard_with_purchase, free_70_USD_e_giftcard_with_purchase, free_100_USD_e_giftcard_with_purchase, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum purchasing_channelValue { in_store, online, external_site, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum registry_channelValue { gift_registry, wish_list, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum removable_memoryValue { unknown, [System.Xml.Serialization.XmlEnumAttribute("3_5_floppy")] Item3_5_floppy, ata_flash_card, audio_video_port, built_in_flash_memory, [System.Xml.Serialization.XmlEnumAttribute("cd-r")] cdr, cdr_drive, compact_disc, compact_flash_card, compact_flash_type_i_or_ii, compactflash_type_i, compactflash_type_ii, ethernet, headphone, ibm_microdrive, ieee_1394, infrared, internal_w_removable_media, iomega_clik_disk, lanc, media_card, memory_stick, multimedia_card, parallel_interface, pc_card, s_video, secure_digital, serial_interface, smartmedia_card, springboard_module, ssfdc, superdisk, usb, [System.Xml.Serialization.XmlEnumAttribute("usb1.1")] usb11, usb_docking_station, usb_streaming, microsd, minisd, multimediacardmobile, multimediacardplus, rs_mmc, sim_card, transflash, xd_picture_card, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum sales_restrictionValue { continental_only, all_states_no_apo_prot, all_states_apo_prot, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum system_ram_typeValue { unknown, dram, rdram, sdram, sgram, sldram, sodimm, sram, wram, ddr_dram, ddr_sdram, edo_dram, vram, dimm, rimm, simm, sorimm, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum telling_page_indicatorValue { unknown, bedding, proposition_65, sizes, window_measurements, warranty_information, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_rating_degreesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public temperature_rating_degreesValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_rating_degreesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum toy_awardValue { australia_toy_fair_toy_of_the_year, australia_toy_fair_boys_toy_of_the_year, child_magazine, dr_toys_100_best_child_products, energizer_battery_operated_toy_of_the_yr, family_fun_toy_of_the_year_seal, games_magazine, german_toy_association_toy_of_the_year, hamleys_toy_of_the_year, lion_mark, national_parenting_approval_award, norwegian_toy_association_toy_of_the_yr, oppenheim_toys, parents_choice_portfolio, parents_magazine, rdj_france_best_electronic_toy_of_the_yr, rdj_france_best_toy_of_the_year, toy_wishes, uk_npd_report_number_one_selling_toy, unknown, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum tv_parental_guideline_ratingValue { tv_y, tv_y7, tv_y7_fv, tv_14, tv_g, tv_pg, tv_ma, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class video_capture_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public video_capture_speedValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(video_capture_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum video_tape_recording_speedValue { unknown, sp, ep, slp, lp, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum vinyl_record_detailsValue { unknown, lp, [System.Xml.Serialization.XmlEnumAttribute("12_single")] Item12_single, [System.Xml.Serialization.XmlEnumAttribute("45")] Item45, ep, [System.Xml.Serialization.XmlEnumAttribute("78")] Item78, other, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wattageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wattageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum wireless_comm_standardValue {[System.Xml.Serialization.XmlEnumAttribute("802_11_B")] Item802_11_B, [System.Xml.Serialization.XmlEnumAttribute("802_11_A")] Item802_11_A, [System.Xml.Serialization.XmlEnumAttribute("802_11_AB")] Item802_11_AB, [System.Xml.Serialization.XmlEnumAttribute("802_11_G")] Item802_11_G, [System.Xml.Serialization.XmlEnumAttribute("54g")] Item54g, bluetooth, [System.Xml.Serialization.XmlEnumAttribute("802_11_AG")] Item802_11_AG, [System.Xml.Serialization.XmlEnumAttribute("802_11_G_108Mbps")] Item802_11_G_108Mbps, radio_frequency, [System.Xml.Serialization.XmlEnumAttribute("2.4_ghz_radio_frequency")] Item24_ghz_radio_frequency, [System.Xml.Serialization.XmlEnumAttribute("900_mhz_radio_frequency")] Item900_mhz_radio_frequency, dect, infrared, irda, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RebateRebate_description { private static System.Xml.Serialization.XmlSerializer serializer; public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RebateRebate_description)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RebateRebate_name { private static System.Xml.Serialization.XmlSerializer serializer; public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RebateRebate_name)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class RebateRebate_type { private static System.Xml.Serialization.XmlSerializer serializer; public RebateRebate_typeValue value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(RebateRebate_type)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum StandardItemPackageType { cd, vhs, dvd, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoneStone_depth_percentage { private static System.Xml.Serialization.XmlSerializer serializer; public decimal value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoneStone_depth_percentage)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class StoneStone_table_percentage { private static System.Xml.Serialization.XmlSerializer serializer; public decimal value { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool valueSpecified { get; set; }[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(StoneStone_table_percentage)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class BatteriesBattery_type { private static System.Xml.Serialization.XmlSerializer serializer; public BatteriesBattery_typeValue value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BatteriesBattery_type)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class BatteriesNum_batteries { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")] public string value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(BatteriesNum_batteries)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bearing_numberValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bearing_numberValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bolt_hole_size_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bolt_hole_size_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bore_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bore_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bore_diameter_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bore_diameter_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_shaft_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_shaft_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class fits_shaft_diameter_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(fits_shaft_diameter_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class dynamic_load_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(dynamic_load_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class exterior_finishValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(exterior_finishValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_center_to_center_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_center_to_center_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_height_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_height_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_hole_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_hole_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_outside_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_outside_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_thickness_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_thickness_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inside_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inside_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inside_diameter_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inside_diameter_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_diameter_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_diameter_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_height_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_height_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_thickness_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_thickness_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_rotational_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_rotational_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class measurement_systemValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(measurement_systemValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class outer_ring_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(outer_ring_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shield_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shield_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class specification_metValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(specification_metValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class static_load_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(static_load_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class belt_angle_degreesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(belt_angle_degreesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class belt_cross_sectionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(belt_cross_sectionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_pitch_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_pitch_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lower_temperature_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lower_temperature_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_bandsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_bandsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class reinforcement_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(reinforcement_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class trade_size_nameValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(trade_size_nameValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class upper_temperature_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(upper_temperature_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_outside_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_outside_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_pipe_size_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_pipe_size_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_tube_outside_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_tube_outside_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_pitch_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_pitch_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class breaking_strengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(breaking_strengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class standard_constructionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(standard_constructionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sphericity_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sphericity_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wall_thickness_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wall_thickness_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wall_thickness_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wall_thickness_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class air_entry_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(air_entry_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_hardnessValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_hardnessValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_length_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_length_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_thickness_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_thickness_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_width_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_width_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lower_bubbling_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lower_bubbling_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pore_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pore_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tolerance_heldValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tolerance_heldValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class upper_bubbling_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(upper_bubbling_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class void_volume_percentageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(void_volume_percentageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_hole_size_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_hole_size_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_rod_size_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_rod_size_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_turnsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_turnsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_spring_compression_loadValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_spring_compression_loadValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_spring_compression_loadValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_spring_compression_loadValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class spring_rateValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(spring_rateValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wire_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wire_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inside_height_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inside_height_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inside_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inside_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inside_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inside_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class manufacturerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(manufacturerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class material_mapValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(material_mapValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class part_numberValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(part_numberValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class axial_misalignment_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(axial_misalignment_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class body_outside_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(body_outside_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bore_depth_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bore_depth_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_angular_misalignmentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_angular_misalignmentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_parallel_misalignment_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_parallel_misalignment_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_torqueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_torqueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shielding_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shielding_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class face_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(face_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hub_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hub_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hub_projection_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hub_projection_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_teethValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_teethValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pitch_line_to_base_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pitch_line_to_base_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_panel_thickness_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_panel_thickness_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class load_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(load_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wheel_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wheel_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wheel_tread_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wheel_tread_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hub_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hub_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class guide_support_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(guide_support_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class slide_travel_distance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(slide_travel_distance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class disc_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(disc_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class gauge_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(gauge_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hole_countValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hole_countValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class mesh_countValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(mesh_countValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class mesh_numberValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(mesh_numberValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class mesh_opening_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(mesh_opening_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class open_area_percentageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(open_area_percentageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sheet_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sheet_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sheet_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sheet_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class metal_construction_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(metal_construction_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tubing_wall_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tubing_wall_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_temperValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_temperValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_startsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_startsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_styleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_styleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class fastener_thread_countValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(fastener_thread_countValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class working_load_limitValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(working_load_limitValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cross_section_shapeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cross_section_shapeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class nominal_inside_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(nominal_inside_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class nominal_outside_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(nominal_outside_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class nominal_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(nominal_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class mesh_opening_size_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(mesh_opening_size_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class durometer_hardnessValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(durometer_hardnessValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class belt_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(belt_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class belt_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(belt_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_groovesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_groovesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shaft_mounting_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shaft_mounting_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class web_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(web_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class key_way_depth_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(key_way_depth_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class key_way_width_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(key_way_width_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class opposing_screw_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(opposing_screw_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_linksValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_linksValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_tension_loadValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_tension_loadValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class strand_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(strand_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tension_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tension_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_hex_wrench_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_hex_wrench_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class drill_point_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(drill_point_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class drive_systemValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(drive_systemValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class grade_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(grade_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class head_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(head_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class head_diameter_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(head_diameter_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class head_height_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(head_height_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class head_height_tolerance_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(head_height_tolerance_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class screw_head_styleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(screw_head_styleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class screw_point_styleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(screw_point_styleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class self_locking_mechanism_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(self_locking_mechanism_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shoulder_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shoulder_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shoulder_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shoulder_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_coverageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_coverageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_torx_wrenchValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_torx_wrenchValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_axial_loadValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_axial_loadValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class set_screw_thread_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(set_screw_thread_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compressed_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compressed_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class free_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(free_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hub_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hub_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class idler_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(idler_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_pitch_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_pitch_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class clutch_engagement_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(clutch_engagement_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_torqueValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_torqueValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_shaft_penetrationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_shaft_penetrationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class rotation_directionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(rotation_directionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class spring_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(spring_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class active_coilsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(active_coilsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class deflection_angleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(deflection_angleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class leg_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(leg_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class rod_outside_diameter_maximum_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(rod_outside_diameter_maximum_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class spring_wind_directionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(spring_wind_directionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class center_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(center_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class end_unit_length_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(end_unit_length_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class flange_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(flange_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_angle_degreesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_angle_degreesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pin_hole_diameter_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pin_hole_diameter_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shaft_spacing_stringValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shaft_spacing_stringValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class washer_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(washer_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class washer_hole_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(washer_hole_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_with_tube_gaugeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_with_tube_gaugeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tensile_strengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tensile_strengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class arbor_hole_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(arbor_hole_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class backing_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(backing_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class backing_weightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(backing_weightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cfm_at_90_psiValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cfm_at_90_psiValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class chamfer_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(chamfer_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class chip_breaker_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(chip_breaker_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class coarseness_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(coarseness_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_beam_flange_widthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_beam_flange_widthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_min_beam_curve_radiusValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_min_beam_curve_radiusValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compatible_min_beam_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compatible_min_beam_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class construction_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(construction_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class container_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(container_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class control_cord_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(control_cord_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cover_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cover_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cut_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cut_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cutting_angleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cutting_angleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cutting_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cutting_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cutting_directionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cutting_directionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cutting_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cutting_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class drum_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(drum_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class end_cut_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(end_cut_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class fastening_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(fastening_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class fixture_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(fixture_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class gradient_spacingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(gradient_spacingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class grit_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(grit_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hanger_hole_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hanger_hole_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hydraulic_ram_hole_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hydraulic_ram_hole_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hydraulic_ram_outside_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hydraulic_ram_outside_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hydraulic_ram_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hydraulic_ram_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class industry_standard_identifierValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(industry_standard_identifierValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lead_angleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lead_angleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lever_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lever_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lifting_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lifting_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lifting_mechanismValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lifting_mechanismValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class manufacturer_gradeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(manufacturer_gradeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_bend_radiusValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_bend_radiusValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_fitting_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_fitting_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_gap_fillValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_gap_fillValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_lifting_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_lifting_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_lifting_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_lifting_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_measurementValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_measurementValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_clearanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_clearanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class motor_phaseValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(motor_phaseValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class mounting_hole_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(mounting_hole_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_flutesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_flutesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_insertsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_insertsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_partsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_partsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_speedsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_speedsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class numeric_viscosityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public numeric_viscosityValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(numeric_viscosityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class piston_stroke_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(piston_stroke_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class rake_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(rake_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shank_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shank_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shank_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shank_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shank_widthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shank_widthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shank_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shank_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shank_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shank_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class specific_gravityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(specific_gravityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tool_flute_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tool_flute_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tool_flute_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tool_flute_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wheel_recess_dimensionsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wheel_recess_dimensionsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class actuator_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(actuator_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class actuator_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(actuator_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class alternating_discharge_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(alternating_discharge_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class amplifier_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(amplifier_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class angle_of_half_intensityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(angle_of_half_intensityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class angular_accelerationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Acceleration unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(angular_accelerationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class aperture_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(aperture_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class aperture_orientationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(aperture_orientationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class arc_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(arc_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class attenuationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(attenuationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class attenuation_toleranceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(attenuation_toleranceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class average_current_consumptionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(average_current_consumptionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class axis_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(axis_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bandwidthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bandwidthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class base_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(base_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class base_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(base_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class beam_divergenceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(beam_divergenceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class beam_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(beam_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bearing_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bearing_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class beta_constantValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(beta_constantValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class board_thicknessValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(board_thicknessValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class body_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(body_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class body_styleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(body_styleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class breakdown_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(breakdown_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cable_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cable_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class capacitance_toleranceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(capacitance_toleranceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cdrh_classificationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cdrh_classificationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class character_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(character_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class clamping_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(clamping_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class clarityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(clarityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class clock_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(clock_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class coating_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(coating_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class coil_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(coil_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class coil_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(coil_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class coil_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(coil_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class collector_base_breakdown_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(collector_base_breakdown_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class collector_base_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(collector_base_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class collector_continuous_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(collector_continuous_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class collector_dissipationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(collector_dissipationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class collector_emitter_breakdown_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(collector_emitter_breakdown_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class collector_emitter_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(collector_emitter_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class common_emitter_current_gainValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(common_emitter_current_gainValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class communication_standardValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(communication_standardValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class communication_interfaceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(communication_interfaceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class connector_genderValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(connector_genderValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class connector_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(connector_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_current_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_current_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_initial_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_initial_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_input_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_input_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_pitchValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_pitchValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_plating_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_plating_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class contact_voltage_dropValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(contact_voltage_dropValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class continuous_forward_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(continuous_forward_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class continuous_output_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(continuous_output_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class controller_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(controller_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class current_gain_bandwidthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(current_gain_bandwidthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class current_per_phaseValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(current_per_phaseValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class current_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(current_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class dark_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(dark_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class date_formatValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(date_formatValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class detection_angleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(detection_angleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class detection_angle_toleranceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(detection_angle_toleranceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class detector_power_dissipationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(detector_power_dissipationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class dielectric_strengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(dielectric_strengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class differential_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(differential_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class digit_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(digit_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class digit_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(digit_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class display_methodValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(display_methodValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class display_modeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(display_modeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class dot_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(dot_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class dots_per_screen_areaValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(dots_per_screen_areaValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class drive_levelValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(drive_levelValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class dropout_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(dropout_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class duty_cycle_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(duty_cycle_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class effective_input_areaValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(effective_input_areaValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class electrical_life_expectancyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Life unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(electrical_life_expectancyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class electrical_travel_limitValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(electrical_travel_limitValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class electrode_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(electrode_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class emitter_base_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(emitter_base_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class emitter_collector_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(emitter_collector_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class equivalent_series_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(equivalent_series_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class feedbackValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(feedbackValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ferrule_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ferrule_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class forward_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(forward_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class forward_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(forward_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class frequency_accuracyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(frequency_accuracyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class frequency_responseValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(frequency_responseValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class frequency_toleranceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PartsPerType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(frequency_toleranceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class gearbox_efficiencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(gearbox_efficiencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class gearbox_ratioValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(gearbox_ratioValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class gearingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(gearingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class glow_arc_transition_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(glow_arc_transition_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class hold_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(hold_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class holding_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(holding_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class holdover_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(holdover_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class housing_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(housing_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class housing_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(housing_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class impedanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(impedanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class impedance_toleranceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(impedance_toleranceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class impulse_discharge_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(impulse_discharge_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class impulse_sparkoverValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(impulse_sparkoverValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inductanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Inductance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inductanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inductance_toleranceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inductance_toleranceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class input_capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(input_capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class input_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(input_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class input_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(input_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class input_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(input_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class input_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(input_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class input_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(input_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class insert_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(insert_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class insertion_lossValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(insertion_lossValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class insulation_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(insulation_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class intensityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public LuminousIntensity unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(intensityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class interface_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(interface_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class isolation_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(isolation_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class jacket_colorValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(jacket_colorValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class jacket_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(jacket_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class junction_maximum_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(junction_maximum_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lead_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lead_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lead_pitchValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lead_pitchValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class lead_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(lead_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class leakage_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(leakage_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class led_power_dissipationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(led_power_dissipationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class light_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(light_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class linearityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(linearityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class line_maximum_frequencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(line_maximum_frequencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class load_capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(load_capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class load_forceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(load_forceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class location_accuracyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(location_accuracyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class logic_circuit_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(logic_circuit_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class logic_familyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(logic_familyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class logic_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(logic_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class logic_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(logic_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class loop_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(loop_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class luminous_intensityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public LuminousIntensity unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(luminous_intensityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_circuit_breaker_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_circuit_breaker_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_clamping_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_clamping_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_coil_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_coil_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_collector_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_collector_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_control_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_control_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_force_requiredValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_force_requiredValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_frequencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_frequencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_horsepowerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_horsepowerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_input_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_input_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_inrush_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_inrush_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_load_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_load_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_measuring_levelValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_measuring_levelValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_off_state_leakage_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_off_state_leakage_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_operating_distanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_operating_distanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_operating_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_operating_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_operating_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_operating_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_output_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_output_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_rate_of_flowValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_rate_of_flowValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_resistive_loadValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_resistive_loadValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_rms_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_rms_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_shockValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Acceleration unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_shockValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_storage_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_storage_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_suctionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_suctionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_supply_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_supply_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_surge_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_surge_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_switching_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_switching_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_switching_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_switching_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_trimmer_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_trimmer_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_vibrationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Acceleration unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_vibrationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_working_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_working_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class measurement_accuracyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(measurement_accuracyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class measurement_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(measurement_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class measurement_window_widthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(measurement_window_widthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class mechanical_life_expectancyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Life unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(mechanical_life_expectancyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class meter_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(meter_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_accuracyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_accuracyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_coil_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_coil_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_control_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_control_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_detectable_object_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_detectable_object_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_frequencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_frequencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_input_impedanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_input_impedanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_input_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_input_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_junction_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_junction_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_line_frequencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_line_frequencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_load_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_load_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_measuring_levelValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_measuring_levelValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_operating_distanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_operating_distanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_operating_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_operating_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_output_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_output_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_rate_of_flowValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_rate_of_flowValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_release_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_release_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_storage_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_storage_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_suctionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_suctionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_supply_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_supply_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_switching_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_switching_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_trimmer_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_trimmer_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_working_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_working_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class mounting_hole_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(mounting_hole_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class noise_figureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(noise_figureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class nominal_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(nominal_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class nominal_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(nominal_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class nominal_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(nominal_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class microchip_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(microchip_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_bitsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_bitsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_circuitsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_circuitsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_comparatorsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_comparatorsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_conductorsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_conductorsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_contactsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_contactsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_detentsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_detentsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_digitsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_digitsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_driversValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_driversValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_leadsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_leadsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_macrocellsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_macrocellsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_outputsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_outputsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_pinsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_pinsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_polesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_polesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_receiversValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_receiversValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_rowsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_rowsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_sectionsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_sectionsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_shaftsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_shaftsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_wiresValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_wiresValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class off_state_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(off_state_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_forceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public ForceType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_forceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_frequencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_frequencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_humidityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_humidityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_lifeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Life unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_lifeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_wavelengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_wavelengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operation_modeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operation_modeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class optical_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(optical_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class orientationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(orientationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class outline_dimensionsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(outline_dimensionsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class output_capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(output_capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class output_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(output_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class output_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(output_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class output_sink_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(output_sink_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class output_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(output_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class output_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(output_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pad_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pad_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pattern_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pattern_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pcb_hole_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pcb_hole_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_collector_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_collector_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_forward_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_forward_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_forward_surge_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_forward_surge_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_output_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_output_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_repetitive_forward_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_repetitive_forward_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_repetitive_reverse_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_repetitive_reverse_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_to_peak_rippleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_to_peak_rippleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class peak_wavelengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(peak_wavelengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class phase_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(phase_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pickup_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pickup_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pin_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pin_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pixel_pitchValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pixel_pitchValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pixel_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pixel_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class polarityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(polarityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class polarization_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(polarization_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class port_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(port_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class power_consumptionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(power_consumptionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class power_dissipationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(power_dissipationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class power_gainValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(power_gainValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pressure_reading_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pressure_reading_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pre_travel_distanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pre_travel_distanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class primary_winding_impedanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(primary_winding_impedanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class primary_winding_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(primary_winding_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pulse_per_revolutionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pulse_per_revolutionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pulse_withstandValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Pulse unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pulse_withstandValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class quality_factorValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(quality_factorValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class repetition_rateValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(repetition_rateValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class required_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(required_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class resistance_toleranceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(resistance_toleranceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class resolutionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(resolutionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class return_lossValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(return_lossValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class reverse_breakdown_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(reverse_breakdown_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class reverse_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(reverse_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class reverse_input_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(reverse_input_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class reverse_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(reverse_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class reverse_voltage_leakageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(reverse_voltage_leakageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class rod_travel_distanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(rod_travel_distanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class row_spacingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(row_spacingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class screen_hardnessValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(screen_hardnessValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class secondary_winding_impedanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(secondary_winding_impedanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class secondary_winding_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(secondary_winding_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class self_resonant_frequencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Frequency unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(self_resonant_frequencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sensing_distanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sensing_distanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sensing_methodValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sensing_methodValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sensing_modeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sensing_modeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sensitivityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sensitivityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class setting_methodValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(setting_methodValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shaft_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shaft_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shaft_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shaft_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shock_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Acceleration unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shock_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shunt_capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shunt_capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sleeve_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sleeve_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sound_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sound_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class sparkover_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(sparkover_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class spectral_widthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(spectral_widthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class step_angleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(step_angleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class storage_humidityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(storage_humidityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class strandsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(strandsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class strip_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(strip_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class stud_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(stud_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class supply_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(supply_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class supply_powerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(supply_powerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class supply_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(supply_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class switch_capacitanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Capacitance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(switch_capacitanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class switch_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(switch_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class system_configurationValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(system_configurationValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_coefficientValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_coefficientValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_increase_per_wattValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_increase_per_wattValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class terminal_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(terminal_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thermal_performance_descriptionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thermal_performance_descriptionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thermal_settingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thermal_settingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thermocouple_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thermocouple_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thermoelectric_potentialValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thermoelectric_potentialValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class thread_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(thread_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class time_formatValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(time_formatValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class total_travelValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(total_travelValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class transducer_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(transducer_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class transmit_distanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(transmit_distanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class trigger_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(trigger_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class trip_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(trip_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class turns_ratioValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(turns_ratioValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ultraviolet_intensityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public UVIntensity unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ultraviolet_intensityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class user_interface_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(user_interface_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class vibration_ratingValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Acceleration unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(vibration_ratingValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class viewable_areaValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(viewable_areaValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class viewing_angleValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public AngularMeasurementType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(viewing_angleValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class voltage_standing_wave_ratioValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public SoundLevel unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(voltage_standing_wave_ratioValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wavelengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wavelengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wiper_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wiper_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class zener_resistanceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Resistance unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(zener_resistanceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class zener_voltageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(zener_voltageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class switching_activation_levelValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Acceleration unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(switching_activation_levelValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class actuator_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(actuator_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class anti_input_area_descriptionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(anti_input_area_descriptionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class current_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(current_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class dielectric_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(dielectric_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class gas_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(gas_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_gatesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_gatesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_cellsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_cellsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class air_consumptionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(air_consumptionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class air_flow_displacementValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(air_flow_displacementValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class air_input_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(air_input_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class block_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public MassType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(block_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class bulb_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(bulb_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cap_colorValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cap_colorValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cap_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cap_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cap_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cap_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class chamber_depthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(chamber_depthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class chamber_heightValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(chamber_heightValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class chamber_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(chamber_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class chamber_widthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(chamber_widthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class closure_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(closure_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class co2_rangeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(co2_rangeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class cold_finger_coil_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(cold_finger_coil_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class compressor_horsepowerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(compressor_horsepowerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class condenser_horsepowerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(condenser_horsepowerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class coolant_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(coolant_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class coolant_consumption_rateValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(coolant_consumption_rateValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class current_intervalsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(current_intervalsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class drops_per_milliliterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(drops_per_milliliterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class extension_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(extension_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class fuel_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(fuel_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class gap_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(gap_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class ground_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(ground_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class handle_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(handle_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class head_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(head_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class heated_element_dimensionsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(heated_element_dimensionsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class heater_surface_material_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(heater_surface_material_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class heater_wattageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(heater_wattageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class heating_element_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(heating_element_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class immersion_depthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(immersion_depthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inlet_connection_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inlet_connection_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inlet_outside_dimensionsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inlet_outside_dimensionsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class inside_depthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(inside_depthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class item_areaValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Area unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(item_areaValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class jacket_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(jacket_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class marking_colorValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(marking_colorValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_energy_outputValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_energy_outputValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_flow_rateValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_flow_rateValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_inlet_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_inlet_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_inlet_water_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_inlet_water_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_relative_centrifugal_forceValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Acceleration unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_relative_centrifugal_forceValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_stirring_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_stirring_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class maximum_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(maximum_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class media_colorValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(media_colorValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_currentValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Current unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_currentValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_energy_outputValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_energy_outputValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_flow_rateValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_flow_rateValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_inlet_water_temperatureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_inlet_water_temperatureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class minimum_stirring_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(minimum_stirring_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class motor_horsepowerValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Power unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(motor_horsepowerValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class motor_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(motor_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class narrow_end_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(narrow_end_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class neck_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(neck_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class needle_gaugeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(needle_gaugeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class needle_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(needle_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_heatersValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_heatersValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_traysValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_traysValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_tubesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_tubesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_wellsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_wellsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_windowsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_windowsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class number_of_zonesValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute(DataType = "positiveInteger")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(number_of_zonesValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class operating_pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(operating_pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class orbit_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(orbit_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class output_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(output_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class outside_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(outside_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class paper_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(paper_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class particle_retention_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(particle_retention_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class plate_areaValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(plate_areaValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class plate_outside_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(plate_outside_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class plug_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(plug_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pressureValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public PressureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pressureValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class pressure_flow_rateValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(pressure_flow_rateValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class purification_methodValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(purification_methodValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class readout_accuracyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(readout_accuracyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class recovery_percentageValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(recovery_percentageValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class septa_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(septa_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shaft_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shaft_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class shaking_speedValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public RotationalSpeedType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(shaking_speedValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class stem_lengthValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(stem_lengthValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class stem_outside_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(stem_outside_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class stopper_numberValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(stopper_numberValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class suction_flow_rateValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(suction_flow_rateValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_accuracyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_accuracyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_control_precisionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_control_precisionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_control_typeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_control_typeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_rangeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_rangeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_recoveryValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_recoveryValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_stabilityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_stabilityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class temperature_uniformityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public TemperatureType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(temperature_uniformityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tubing_outside_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tubing_outside_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class tubing_sizeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(tubing_sizeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class voltage_intervalsValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public Voltage unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(voltage_intervalsValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class volume_precisionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(volume_precisionValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class volumetric_tolerance_classValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(volumetric_tolerance_classValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class water_removal_capacityValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public FlowRate unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(water_removal_capacityValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class well_shapeValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(well_shapeValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class wide_end_diameterValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public DimensionType unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(wide_end_diameterValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class frequencyValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public frequencyValueUnitValue unitValue { get; set; }[System.Xml.Serialization.XmlTextAttribute()] public decimal Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(frequencyValue)); } return serializer; } } 
}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum payment_scheduleValue { nopayment, postpaid, prepaid, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum wireless_plan_areaValue { local, national, regional, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum WirelessProviderType { alltell, att, cingular, earthlink, nextel, sprintpcs, sti_mobile, tracfone, uscellular, verizon, virgin_mobile, voicestream, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum wireless_risk_assessmentValue {[System.Xml.Serialization.XmlEnumAttribute("0")] Item0, [System.Xml.Serialization.XmlEnumAttribute("1")] Item1, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public partial class target_com_extended_product_descriptionValue { private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public string data_provider { get; set; }[System.Xml.Serialization.XmlTextAttribute(DataType = "normalizedString")] public string Value { get; set; } private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(target_com_extended_product_descriptionValue)); } return serializer; } } 
}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum amperageValueUnitValue { milliamps, amps, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum audio_sensitivityValueUnitValue { dB, [System.Xml.Serialization.XmlEnumAttribute("dBV/Pascal")] dBVPascal, [System.Xml.Serialization.XmlEnumAttribute("dBV/uBar")] dBVuBar, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum battery_average_lifeValueUnitValue { sec, min, hr, day, week, month, year, page, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum battery_capacityValueUnitValue { Wh, mAh, Ah, VA, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum battery_powerValueUnitValue { mAh, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum computer_cpu_speedValueUnitValue { MHz, GHz, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum expiration_intervalValueUnitValue { days, weeks, months, quarters, years, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum golf_club_loftValueUnitValue { degrees, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum DimensionType { MM, CM, M, IN, FT, cm, dm, ft, @in, km, m, mi, mm, yd, micrometer, threads_per_inch, turns_per_inch, links_per_inch, threads_per_centimeter, turns_per_centimeter, mesh_count_per_square_inch, links_per_foot, angstrom, nanometer, picometer, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum image_capture_speedValueUnitValue { fps, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum max_copy_speed_black_whiteValueUnitValue { ppm, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum max_copy_speed_colorValueUnitValue { ppm, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum memory_speedValueUnitValue { MHz, GHz, KHz, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum optical_zoomValueUnitValue { x, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum temperature_rating_degreesValueUnitValue {[System.Xml.Serialization.XmlEnumAttribute("degrees-celsius")] degreescelsius, [System.Xml.Serialization.XmlEnumAttribute("degrees-fahrenheit")] degreesfahrenheit, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum video_capture_speedValueUnitValue { fps, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class voltage
	{
		private voltageValue valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }
		[System.Xml.Serialization.XmlIgnoreAttribute()] public bool deleteSpecified { get; set; }


		private static System.Xml.Serialization.XmlSerializer Serializer { get { if ((serializer == null)) { serializer = new System.Xml.Serialization.XmlSerializer(typeof(voltage)); } return serializer; } }
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Power { milliwatts, microwatts, nanowatts, picowatts, watts, horsepower, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum RebateRebate_typeValue { CASH_REBATE, GIFTCARD_REBATE, PRODUCT_REBATE, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum BatteriesBattery_typeValue {[System.Xml.Serialization.XmlEnumAttribute("9v")] Item9v, a, aa, aaa, c, cr123a, cr2, d, lithium_ion, p76, product_specific, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum MassType { grams, kilograms, milligrams, ounces, pounds, tons, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum RotationalSpeedType { rpm, revolutions_per_second, revolutions_per_hour, revolutions_per_week, degrees_per_second, radians_per_second, revolutions_per_month, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum AngularMeasurementType { arc_sec, degrees, radians, milliradian, arc_minute, microradian, turns, revolutions, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum TemperatureType { degrees_celsius, degrees_fahrenheit, kelvin, btus, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum PressureType { pounds_per_square_inch, bars, millibars, kilopascal, hectopascal, pascal, atmosphere, millimeters_mercury, pound_per_square_foot, inches_mercury, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum ForceType { inch_ounces, inch_pounds, kilonewtons, newton_millimeters, newton_meters, newtons, foot_pounds, centimeter_kilograms, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum SpeedType { feet_per_minute, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum numeric_viscosityValueUnitValue { poise, centipoise, stokes, centistokes, pascal_seconds, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Current { amps, kiloamps, microamps, milliamps, nanoamps, picoamps, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Acceleration { gravity, inches_per_second_squared, feet_per_second_squared, meters_per_second_squared, radians_per_second_squared, degrees_per_second_squared, revolutions_per_second_squared, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum SoundLevel { decibels, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Frequency { microhertz, millihertz, hertz, kilohertz, megahertz, gigahertz, terahertz, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class capacitance
	{
		private capacitanceValue valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Resistance { picoohms, nanoohms, microohms, milliohms, ohm, kiloohms, megaohms, gigaohms, teraohms, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Life { operations, cycles, rotations, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum PartsPerType { parts_per_hundred, parts_per_thousand, parts_per_million, parts_per_billion, parts_per_trillion, parts_per_quadrillion, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class inductance
	{
		private inductanceValue valueField; private static System.Xml.Serialization.XmlSerializer serializer;
[System.Xml.Serialization.XmlAttributeAttribute()] public BooleanType delete { get; set; }
		
	}
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum LuminousIntensity { candela, microcandela, millicandela, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum FlowRate { cubic_feet_per_second, cubic_feet_per_minute, cubic_feet_per_hour, cubic_inches_per_minute, cubic_meters_per_hour, liters_per_minute, liters_per_hour, cubic_centimeters_per_minute, cubic_centimeters_per_second, milliliters_per_minute, liters_per_second, cubic_meters_per_second, cubic_meters_per_minute, liters_per_day, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Pulse { pulses, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum UVIntensity { milliwatts_per_centimeters_squared, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()] public enum Area { centimeters_squared, inches_squared, }
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)] public enum frequencyValueUnitValue { KHz, MHz, GHz, }

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum Voltage
	{

		/// <remarks/>
		volts,

		/// <remarks/>
		kilovolts,

		/// <remarks/>
		millivolts,

		/// <remarks/>
		microvolts,

		/// <remarks/>
		nanovolts,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum Capacitance
	{

		/// <remarks/>
		farad,

		/// <remarks/>
		decafarad,

		/// <remarks/>
		hectofarad,

		/// <remarks/>
		kilofarad,

		/// <remarks/>
		megafarad,

		/// <remarks/>
		gigafarad,

		/// <remarks/>
		terafarad,

		/// <remarks/>
		petafarad,

		/// <remarks/>
		exafarad,

		/// <remarks/>
		zettafarad,

		/// <remarks/>
		yottafarad,

		/// <remarks/>
		decifarad,

		/// <remarks/>
		centifarad,

		/// <remarks/>
		millifarad,

		/// <remarks/>
		microfarad,

		/// <remarks/>
		nanofarad,

		/// <remarks/>
		picofarad,

		/// <remarks/>
		femtofarad,

		/// <remarks/>
		attofarad,

		/// <remarks/>
		zeptofarad,

		/// <remarks/>
		yoctofarad,
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
	[System.SerializableAttribute()]
	public enum Inductance
	{

		/// <remarks/>
		kilohenry,

		/// <remarks/>
		henry,

		/// <remarks/>
		millihenry,

		/// <remarks/>
		microhenry,

		/// <remarks/>
		nanohenry,
	}

}
