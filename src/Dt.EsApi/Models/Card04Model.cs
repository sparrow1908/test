using ServerLogic.Types;
using System;
using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{
    public record CardsContainerModel
    {
        ///<summary> РљР°СЂС‚РѕС‡РєР° 112 </summary>
        public Card112Model Card112 { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° 01 </summary>
        public Card01Model? Card01 { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° 02 </summary>
        public Card02Model? Card02 { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° 03 </summary>
        public Card03Model? Card03 { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° 04 </summary>
        public Card04Model? Card04 { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° AT </summary>
        public CardATModel? CardAT { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° Р•Р”Р”РЎ/Р–РљРҐ </summary>
        public CardCommServModel? CardCommServ { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєРё РєР°СЃС‚РѕРјРЅС‹С… СЃР»СѓР¶Р± </summary> 
        public List<CardCustomServiceModel>? CustomServicesCards { get; set; }
    }
    public record Card112Model
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralDataModel? GeneralData { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ </summary>
        public DateTime Create { get; set; }
        ///<summary> ID РІС‹Р·РѕРІР° </summary>
        public long? CallId { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅС‹Р№ Id РІС‹Р·РѕРІР° </summary>
        public string? ExtCallId { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅС‹Р№ Id РІС‹Р·РѕРІР° </summary>
        public string? ExtCallId2 { get; set; }
        ///<summary> РќР°Р±СЂР°РЅРЅС‹Р№ РЅРѕРјРµСЂ </summary>
        public string? CdPN { get; set; }
        ///<summary> РќРѕРјРµСЂ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? CgPN { get; set; }
        ///<summary> РљР°РєР°СЏ-С‚Рѕ РёРЅС‚РµРіСЂР°С†РёСЏ СЃ 04 </summary>
        public int? Category { get; set; }
        ///<summary> РўРёРї РІС‹Р·РѕРІР° </summary>
        public int? CallTypeId { get; set; }
        ///<summary> РўРёРї РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? IncidentTypeId { get; set; }
        ///<summary> РЈСЂРѕРІРµРЅСЊ СѓРіСЂРѕР·С‹ Р§РЎ </summary>
        public ImportanceLevelModel? ImportanceLevelId { get; set; }
        ///<summary> Р’Р»Р°РґРµР»РµС† С‚РµР»РµС„РѕРЅРЅРѕРіРѕ РЅРѕРјРµСЂР° </summary>
        public string? PhoneOwner { get; set; }
        ///<summary> РђРґСЂРµСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? PhoneAddress { get; set; }
        ///<summary> РЎРѕР·РґР°С‚РµР»СЊ </summary>
        public string? Creator { get; set; }
        ///<summary> Р Р°Р№РѕРЅ </summary>
        public int? CityID { get; set; }
        ///<summary> РћРєСЂСѓРі </summary>
        public int? DistrictID { get; set; }
        ///<summary> РЈР»РёС†Р° </summary>
        public int? StreetID { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ СѓР»РёС†Р° </summary>
        public int? AdditionalStreetId { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 112 </summary>
        public int? CardSyntheticStateId { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 01 </summary>
        public int? Card01SyntheticStateId { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 02 </summary>
        public int? Card02SyntheticStateId { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 03 </summary>
        public int? Card03SyntheticStateId { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 04 </summary>
        public int? Card04SyntheticStateId { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё Р•Р”Р”РЎ </summary>
        public int? CardCommServSyntheticStateId { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё РђРў </summary>
        public int? CardATSyntheticStateId { get; set; }
        ///<summary> РќРѕРјРµСЂ РґРѕРјР° </summary>
        public string? Building { get; set; }
        ///<summary> РљРѕСЂРїСѓСЃ </summary>
        public string? Corps { get; set; }
        ///<summary> РљРІР°СЂС‚РёСЂР° </summary>
        public string? Room { get; set; }
        ///<summary> РђРґСЂРµСЃРЅС‹Р№ СѓС‡Р°СЃС‚РѕРє </summary>
        public string? AddressStrip { get; set; }
        ///<summary> Р­С‚Р°Р¶РЅРѕСЃС‚СЊ </summary>
        public string? Storeys { get; set; }
        ///<summary> РљРѕРЅС‚Р°РєС‚РЅС‹Р№ С‚РµР»РµС„РѕРЅ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? CallerContactPhone { get; set; }
        ///<summary> Р­С‚Р°Р¶ </summary>
        public int? Floor { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ РїРѕ РѕР±СЉРµРєС‚Сѓ </summary>
        public string? AdditionalLocationInfo { get; set; }
        ///<summary> РџРѕРґСЉРµР·Рґ </summary>
        public string? Entrance { get; set; }
        ///<summary> РљРѕРґ РґРѕРјРѕС„РѕРЅР° РЅР° РїРѕРґСЉРµР·РґРµ </summary>
        public string? EntranceCode { get; set; }
        ///<summary> РћРїРёСЃР°РЅРёРµ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public string? IncidentDescription { get; set; }
        ///<summary> РРјСЏ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? DeclarantName { get; set; }
        ///<summary> Р¤Р°РјРёР»РёСЏ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? DeclarantLastName { get; set; }
        ///<summary> РћС‚С‡РµСЃС‚РІРѕ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? DeclarantMiddleName { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? DeclarantStatusId { get; set; }
        ///<summary> РђРґСЂРµСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? DeclarantAddress { get; set; }
        ///<summary> Р“РѕСЂРѕРґ/РѕР±Р». Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? DeclarantCityId { get; set; }
        ///<summary> РћРєСЂСѓРі Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? DeclarantDistrictId { get; set; }
        ///<summary> id СЂР°Р№РѕРЅР° Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public int? DeclarantLocalDistrictId { get; set; }
        ///<summary> РЈР»РёС†Р° Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? DeclarantStreetId { get; set; }
        ///<summary> РќРѕРјРµСЂ РґРѕРјР° Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? DeclarantBuildingNumber { get; set; }
        ///<summary> РљРѕСЂРїСѓСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? DeclarantCorps { get; set; }
        ///<summary> РљРІР°СЂС‚РёСЂР° Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? DeclarantFlat { get; set; }
        ///<summary> РўРёРї Р§РЎ </summary>
        public int? CCMC_TypeId { get; set; }
        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 01 </summary>
        public bool HasCard01 { get; set; }
        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 02 </summary>
        public bool HasCard02 { get; set; }
        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 03 </summary>
        public bool HasCard03 { get; set; }
        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 04 </summary>
        public bool HasCard04 { get; set; }
        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° AT </summary>
        public bool HasCardAT { get; set; }
        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° Р•Р”Р”РЎ </summary>
        public bool HasCardCommServ { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РґСѓР±Р»РёСЂРѕРІР°РЅРёСЏ, РѕРїСЂРµРґРµР»РµРЅРЅС‹Р№ РїРѕР»СЊР·РѕРІР°С‚РµР»РµРј </summary>
        public int? DuplicateUserStatus { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РґСѓР±Р»РёСЂРѕРІР°РЅРёСЏ, РѕРїСЂРµРґРµР»РµРЅРЅС‹Р№ СЃРёСЃС‚РµРјРѕР№ </summary>
        public int? DuplicateSystemStatus { get; set; }
        ///<summary> id РІРѕР·РјРѕР¶РЅРѕРіРѕ РѕСЂРёРіРёРЅР°Р»Р° </summary>
        public int? OriginalCardId { get; set; }
        ///<summary> GUID РІРѕР·РјРѕР¶РЅРѕРіРѕ РѕСЂРёРіРёРЅР°Р»Р° </summary>
        public string? OriginalGlobalId { get; set; }
        ///<summary> РњСѓР»СЊС‚РёР·РѕРЅР°Р»СЊРЅРѕСЃС‚СЊ </summary>
        public bool? IsMultizone { get; set; }
        ///<summary> Р”Р°С‚Р° СЂРѕР¶РґРµРЅРёСЏ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public DateTime? DeclarantDateOfBirth { get; set; }
        ///<summary> Р’РѕР·СЂР°СЃС‚ Р·РІРѕРЅСЏС‰РµРіРѕ (Р»РµС‚) </summary>
        public int? AgeYear { get; set; }
        ///<summary> РћР±СЉРµРєС‚ </summary>
        public int? ObjectId { get; set; }
        ///<summary> РќРѕРјРµСЂ СЂРµРІРёР·РёРё РєР°СЂС‚РѕС‡РєРё </summary>
        public int? Revision { get; set; }
        ///<summary> РќРѕРјРµСЂ СЏС‡РµР№РєРё Tele2 </summary>
        public long? CellId { get; set; }
        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р°: (С€РёСЂРѕС‚Р°) </summary>
        public double? GeoLatitude { get; set; }
        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р° (РґРѕР»РіРѕС‚Р°) </summary>
        public double? GeoLongitude { get; set; }
        ///<summary> РћРїРёСЃР°РЅРёРµ РіРµРѕ РїРѕР·РёС†РёРё </summary>
        public string? GeoRegionDesc { get; set; }
        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р° Р·Р°СЏРІРёС‚РµР»СЏ: (С€РёСЂРѕС‚Р°) </summary>
        public double? DeclarantGeoLatitude { get; set; }
        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р° Р·Р°СЏРІРёС‚РµР»СЏ (РґРѕР»РіРѕС‚Р°) </summary>
        public double? DeclarantGeoLongitude { get; set; }
        ///<summary> РўРёРї РіРµРѕ РїРѕР·РёС†РёРё Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public string? DeclarantGeoRegionDesc { get; set; }
        ///<summary> РЈР»РёС†Р° РЅРµРїСЂРѕС€РµРґС€Р°СЏ РІР°Р»РёРґР°С†РёСЋ </summary>
        public string? InvalidStreet { get; set; }
        ///<summary> XML РґР»СЏ РёРЅС‚РµРіСЂР°С†РёРё СЃ EraGlonass </summary>
        public string? EraIntegrationXml { get; set; }
        ///<summary> РўРµРєСЃС‚РѕРІС‹Р№ Р°РґСЂРµСЃ </summary>
        public string? TextAddress { get; set; }
        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂС‹ РєР°РјРµСЂ РІРёРґРµРѕРїРѕСЂС‚Р°Р»Р° Р±Р»РёР¶Р°Р№С€РёС… Рє Р·Р°СЏРІРёС‚РµР»СЋ </summary>
        public string? CallerNearCameras { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ Р·Р°РІРµСЂС€РµРЅРёСЏ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? Complete { get; set; }
        ///<summary> id СЂРµРіРёРѕРЅР° </summary>
        public int? RegionId { get; set; }
        ///<summary> id СЂР°Р№РѕРЅР° </summary>
        public int? LocalDistrictId { get; set; }
        ///<summary> Р’Р»РѕР¶РµРЅРёСЏ </summary>
        public string? AttachmentList { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? Deadline { get; set; }
        ///<summary> РЇР·С‹Рє РѕР±С‰РµРЅРёСЏ </summary>
        public int? LanguageId { get; set; }
        ///<summary> Р СЏРґРѕРј </summary>
        public bool IsNear { get; set; }
        ///<summary> РљРј./Рј. </summary>
        public string? Km { get; set; }
        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕСЃС‚СЂР°РґР°РІС€РёС… </summary>
        public int? Casualties { get; set; }
        ///<summary> РЈРіСЂРѕР·Р° Р»СЋРґСЏРј </summary>
        public bool HumanThreat { get; set; }
        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ Р·РѕРЅС‹ РІ РєРѕС‚РѕСЂРѕР№ Р±С‹Р»Р° СЃРѕР·РґР°РЅР° РєР°СЂС‚РѕС‡РєР° </summary>
        public int? SourceZoneId { get; set; }
        ///<summary> GUID РєР°СЂС‚РѕС‡РєРё </summary>
        public string? GlobalId { get; set; }
        ///<summary> Р¤РРћ РѕРїРµСЂР°С‚РѕСЂР° </summary>
        public string? OperatorName { get; set; }
        ///<summary> Р’Р°Р¶РЅР°СЏ </summary>
        public bool? Priority { get; set; }
        ///<summary> РЎРёСЃС‚РµРјР° РїРѕСЃР»РµРґРЅРµР№ РјРѕРґРёС„РёС†РёСЂРѕРІР°РІС€Р°СЏ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? LatestSys { get; set; }
        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ РєР°СЂС‚РѕС‡РєРё Р­Р Рђ-Р“Р›РћРќРђРЎРЎ </summary>
        public string? EraCardId { get; set; }
        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? CallDuration { get; set; }
        ///<summary> Р РµР·СѓР»СЊС‚Р°С‚ Р·РІРѕРЅРєР° </summary>
        public CallStatusModel? CallStatus { get; set; }
        ///<summary> P-Visited-Network-Id </summary>
        public string? VisitedNetworkId { get; set; }
        ///<summary> РЈС‡РµР±РЅР°СЏ </summary>
        public bool TestCard { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅС‹Рµ РїРѕР»СЏ </summary>
        public string? ExtendedData { get; set; }
        ///<summary> РРЅС„РѕСЂРјР°С†РёСЏ РґР»СЏ РјР°СЂС€СЂСѓС‚РёР·Р°С†РёРё РїРµСЂРµР°РґСЂРµСЃРѕРІР°РЅРЅРѕРіРѕ РІС‹Р·РѕРІР° </summary>
        public string? CallRoutingTag { get; set; }
        ///<summary> РўРёРї РёСЃС‚РѕС‡РЅРёРєР° </summary>
        public int? SourceTypeId { get; set; }
        ///<summary> externalId2 </summary>
        public string? ExternalId2 { get; set; }
        ///<summary> РРЅС„РѕСЂРјР°С†РёСЏ РѕР± РёСЃС‚РѕС‡РЅРёРєРµ </summary>
        public string? SourceTypeInfo { get; set; }
        ///<summary> РђРІС‚РѕРјР°С‚РёС‡РµСЃРєРё СЂР°СЃРїСЂРµРґРµР»СЏС‚СЊ РєР°СЂС‚РѕС‡РєСѓ РЅР° РѕРїРµСЂР°С‚РѕСЂР° </summary>
        public bool? AutoDistribute { get; set; }
        ///<summary> РЇРІР»СЏРµС‚СЃСЏ Р»Рё РєР°СЂС‚РѕС‡РєР° С‡РµСЂРЅРѕРІРёРєРѕРј </summary>
        public bool? Draft { get; set; }
        ///<summary> metadata РїРѕ РєР°СЂС‚РѕС‡РєРµ </summary>
        public MetaDataModel? Metadata { get; set; }
        ///<summary> РљРѕРЅС‚СЂРѕР»СЊ </summary>
        public bool? Control { get; set; }
        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ С‡Р°С‚Р° </summary>
        public string? ChatId { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° Р±С‹Р»Р° РёР·РјРµРЅРµРЅР° РїРѕСЃР»Рµ РїРµСЂРІРѕРіРѕ СЃРѕС…СЂР°РЅРµРЅРёСЏ </summary>
        public bool? WasChangedAfterFirstSave { get; set; }
        ///<summary> РќРѕРјРµСЂ СЃС‚СЂРѕРµРЅРёСЏ </summary>
        public string? Structure { get; set; }
        ///<summary> РќРѕРјРµСЂ СЃС‚СЂРѕРµРЅРёСЏ РІ Р°РґСЂРµСЃРµ Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public string? DeclarantStructure { get; set; }
        ///<summary> Р’С‹Р·РѕРІС‹, РїСЂРёРІСЏР·Р°РЅРЅС‹Рµ Рє РєР°СЂС‚РѕС‡РєРµ </summary> 
        public List<CallHistoryItemModel>? CallHistory { get; set; }
        ///<summary> РЎРµСЂРІРёСЃС‹, РЅР° РєРѕС‚РѕСЂС‹Рµ РЅРµ СѓРґР°Р»РѕСЃСЊ РїРµСЂРµРґР°С‚СЊ РєР°СЂС‚РѕС‡РєСѓ </summary> 
        public List<ReplicationTargetModel>? FailedReplicationTargets { get; set; }
        ///<summary> РЎРµСЂРІРёСЃС‹ РЅР° РєРѕС‚РѕСЂС‹Рµ СѓРґР°Р»РѕСЃСЊ РїРµСЂРµРґР°С‚СЊ РєР°СЂС‚РѕС‡РєСѓ </summary>        
        public List<ReplicationTargetModel>? SucceededReplicationTargets { get; set; }
        ///<summary> РћС‚РґРµР»РµРЅРёСЏ Р–РљРҐ </summary> 
        public List<int>? DirectCommServDepartments { get; set; }
        ///<summary> РџСЂРёРІР»РµС‡С‘РЅРЅС‹Рµ РєР°СЃС‚РѕРјРЅС‹Рµ СЃР»СѓР¶Р±С‹ </summary> 
        public List<CustomServiceModel>? CustomServices { get; set; }
    }
    public record Card01Model
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralDataModel? GeneralData { get; set; }
        ///<summary> Р”Р°РЅРЅС‹Рµ Рѕ РІР»Р°РґРµР»СЊС†Рµ РѕР±СЉРµРєС‚Р° </summary>
        public string? ObjectOwner { get; set; }
        ///<summary> Р’РёРґ РїРѕР¶Р°СЂРЅРѕР№ РѕС…СЂР°РЅС‹ </summary>
        public int? FirePreventionTypeID { get; set; }
        ///<summary> в„– РєР°СЂС‚РѕС‡РєРё РЈРџ </summary>
        public string? InternalCardNumber { get; set; }
        ///<summary> Р’СЂРµРјСЏ РїРѕРґР°С‡Рё РїРµСЂРІРѕРіРѕ СЃС‚РІРѕР»Р° (РІ РјРёРЅСѓС‚Р°С…) </summary>
        public int? FirstFireBarrel { get; set; }
        ///<summary> Р Р°СЃС…РѕРґ РІРѕРґС‹ (РІ Р»РёС‚СЂР°С…) </summary>
        public int? WaterConsumption { get; set; }
        ///<summary> Р’РѕРґРѕРёСЃС‚РѕС‡РЅРёРє </summary>
        public int? WaterSourceID { get; set; }
        ///<summary> РЈС‰РµСЂР± </summary>
        public int? DamageCost { get; set; }
        ///<summary> РЎРїР°СЃРµРЅРѕ РјР°С‚. С†РµРЅРЅРѕСЃС‚РµР№ </summary>
        public int? SavedCost { get; set; }
        ///<summary> РћРїРµСЂР°С‚РёРІРЅС‹Р№ РёРЅС‚РµСЂРµСЃ </summary>
        public bool PoliceInterest { get; set; }
        ///<summary> РЎРјРµРЅР° </summary>
        public string? Shift { get; set; }
        ///<summary> РЎРѕРѕР±С‰РµРЅРёРµ </summary>
        public string? Message { get; set; }
        ///<summary> Р”РѕРї.РёРЅС„Рѕ РѕР±СЉРµРєС‚Р° </summary>
        public string? ObjectAdditionalInfo { get; set; }
        ///<summary> РћР±СЉРµРєС‚ </summary>
        public int? ObjectId { get; set; }
        ///<summary> РџР»Р°РЅ СЂРµР°РіРёСЂРѕРІР°РЅРёСЏ </summary>
        public int? ReactionPlanId { get; set; }
        ///<summary> РўРёРї РѕР±СЉРµРєС‚Р° </summary>
        public int? ObjectTypeId { get; set; }
        ///<summary> РћР±СЉРµРєС‚ РіР°Р·РёС„РёС†РёСЂРѕРІР°РЅ </summary>
        public bool ObjectGasified { get; set; }
        ///<summary> Р Р°РЅРі РїРѕР¶Р°СЂР° </summary>
        public int? FireClassId { get; set; }
        ///<summary> РЈРіСЂРѕР·Р° Р»СЋРґСЏРј </summary>
        public bool HumanThreat { get; set; }
        ///<summary> РџСЂРёР·РЅР°Рє Р§РЎ </summary>
        public bool EmergencyFlag { get; set; }
        ///<summary> РџР»РѕС‰Р°РґСЊ (РєРІ.Рј.) </summary>
        public int? Space { get; set; }
        ///<summary> РџРѕРіРёР±Р»Рѕ Р»СЋРґРµР№ </summary>
        public int? PerishedPeople { get; set; }
        ///<summary> РџРѕРіРёР±Р»Рѕ РґРµС‚РµР№ </summary>
        public int? PerishedChildren { get; set; }
        ///<summary> РџРѕРіРёР±Р»Рѕ СЃРѕС‚СЂСѓРґРЅРёРєРѕРІ </summary>
        public int? PerishedCollaborators { get; set; }
        ///<summary> Р Р°РЅРµРЅРѕ Р»СЋРґРµР№ </summary>
        public int? Wounded { get; set; }
        ///<summary> Р Р°РЅРµРЅРѕ РґРµС‚РµР№ </summary>
        public int? WoundedChildren { get; set; }
        ///<summary> Р Р°РЅРµРЅРѕ СЃРѕС‚СЂСѓРґРЅРёРєРѕРІ </summary>
        public int? WoundedCollaborators { get; set; }
        ///<summary> РЎРїР°СЃРµРЅРѕ Р»СЋРґРµР№ </summary>
        public int? SavedPeople { get; set; }
        ///<summary> РЎРїР°СЃРµРЅРѕ РґРµС‚РµР{ get; set; } </summary>
        public int? SavedChildren { get; set; }
        ///<summary> РќР°СЂСѓС€РµРЅРѕ Сѓ/Р¶ </summary>
        public int? BrokenLivingConditions { get; set; }
        ///<summary> РќР°СЂСѓС€РµРЅРѕ Сѓ/Р¶ РґРµС‚РµР№ </summary>
        public int? BrokenLivingConditionsChildren { get; set; }
        ///<summary> РџСЂРёС‡РёРЅР° РїРѕР¶Р°СЂР° </summary>
        public int? FireReasonID { get; set; }
        ///<summary> Р’РёРґ РІС‹РµР·РґР° </summary>
        public int? FireIncidentTypeID { get; set; }
        ///<summary> Р’СЂРµРјСЏ Р»РѕРєР°Р»РёР·Р°С†РёРё </summary>
        public DateTime? Localization { get; set; }
        ///<summary> Р’СЂРµРјСЏ Р»РёРєРІРёРґР°С†РёРё </summary>
        public DateTime? Liquidation { get; set; }
        ///<summary> Р’СЂРµРјСЏ СѓСЃС‚СЂР°РЅРµРЅРёСЏ РѕС‚РєСЂС‹С‚РѕРіРѕ РѕРіРЅСЏ </summary>
        public DateTime? OpenFireLiquidation { get; set; }
        ///<summary> РЈС‚РѕС‡РЅРµРЅРЅР°СЏ РїСЂРёС‡РёРЅР° РїРѕР¶Р°СЂР° </summary>
        public string? Description { get; set; }
        ///<summary> Р Р°СЃСЃС‚РѕСЏРЅРёРµ </summary>
        public int? FireDistance { get; set; }
        ///<summary> Р¤РѕСЂРјР° СЃРѕР±СЃС‚РІРµРЅРЅРѕСЃС‚Рё </summary>
        public string? Ownership { get; set; }
        ///<summary> РћС€РёР±РѕС‡РЅР°СЏ РєР°СЂС‚РѕС‡РєР° </summary>
        public bool IsError { get; set; }
        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardCreate { get; set; }
        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardView { get; set; }
        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWork { get; set; }
        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWorkNext { get; set; }
        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardComplete { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? Deadline { get; set; }
        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? ServiceIncidentTypeId { get; set; }
        ///<summary> РћС†РµРЅРєР° РІСЂРµРјРµРЅРё СЂР°Р·РІРёС‚РёСЏ РїРѕР¶Р°СЂР° </summary>
        public int? FireStartEstimate { get; set; }
        ///<summary> РќР°Р±Р»СЋРґР°РµРјС‹Рµ РїРѕСЃР»РµРґСЃС‚РІРёСЏ РїРѕР¶Р°СЂР° </summary>
        public string? FireResults { get; set; }
        ///<summary> РҐР°СЂР°РєС‚РµСЂРёСЃС‚РёРєР° РїРѕРґСЉРµР·РґРЅС‹С… РїСѓС‚РµР№ </summary>
        public string? PathDescription { get; set; }
        ///<summary> РҐР°СЂР°РєС‚РµСЂРёСЃС‚РёРєР° СѓСЃР»РѕРІРёР№ СЂР°Р±РѕС‚С‹ </summary>
        public string? ConditionsDescription { get; set; }
        ///<summary> РћС†РµРЅРєР° РІРѕР·РјРѕР¶РЅРѕСЃС‚Рё СЌРІР°РєСѓР°С†РёРё </summary>
        public bool EvacuationAvail { get; set; }
        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? ServiceOperator { get; set; }
        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? RegistrationNumber { get; set; }
        ///<summary> Р­С‚Р°Р¶РЅРѕСЃС‚СЊ (РЎРџР‘) </summary>
        public int? NumberStoreys { get; set; }
        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? CallDuration { get; set; }
        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? DenialOfService { get; set; }
        ///<summary> РЎРїРµС†РёС„РёС‡РЅС‹Рµ РґР°РЅРЅС‹Рµ РґР»СЏ СЂРµРіРёРѕРЅР° СѓСЃС‚Р°РЅРѕРІРєРё </summary>
        public RegionDataModel? RegionData { get; set; }
        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ РњРќРРЎ </summary>
        public string? MNISId { get; set; }
        ///<summary> РЎРІРµРґРµРЅРёСЏ РњРќРРЎ </summary>
        public MNISReactionModel? MnisReactionInfo { get; set; }
        ///<summary> РџРѕРґР°РІР°Р»Рё СЃС‚РІРѕР»С‹ </summary> 
        public List<FireBarrelsItemModel>? FireBarrels { get; set; }
        ///<summary> РћРіРЅРµС‚СѓС€Р°С‰РёРµ СЃСЂРµРґСЃС‚РІР° </summary> 
        public List<FireExtinguishersItemModel>? FireExtinguishers { get; set; }
        ///<summary> Р СѓРєРѕРІРѕРґРёС‚РµР»Рё СѓС‡РµРЅРёР№ </summary>
        public List<DrillsChiefModel>? DrillsChiefs { get; set; }
        ///<summary> Р РўРџ-1 </summary> 
        public List<FireChiefModel>? FireChiefs { get; set; }
        ///<summary> Р›РёС‡РЅС‹Р№ СЃРѕСЃС‚Р°РІ </summary> 
        public List<FireFighterModel>? FireFighters { get; set; }
        ///<summary> Р—РІРµРЅСЊСЏ Р“Р”Р—РЎ </summary> 
        public List<GdzsUnitModel>? GdzsUnits { get; set; }
        ///<summary> РЎРІРµРґРµРЅРёСЏ Рѕ РїСЂРёРІР»РµС‡РµРЅРЅС‹С… РўРЎ 01 </summary> 
        public List<Vehicle01InfoModel>? InvolvedVehicles { get; set; }
    }
    public record Card02Model
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralDataModel? GeneralData { get; set; }
        ///<summary> РљР°СЂС‚РѕС‡РєР° РћР’Р” </summary>
        public CardOVDModel CardOVD { get; set; }
        ///<summary> РљРІР°Р»РёС„РёРєР°С†РёСЏ </summary>
        public int? ITypeID { get; set; }
        ///<summary> РџСЂРёРѕСЂРёС‚РµС‚РЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? ImportanceLevel { get; set; }
        ///<summary> Р­РєСЃРїРѕСЂС‚РёСЂРѕРІР°РЅР° Р»Рё </summary>
        public bool Exported { get; set; }
        ///<summary> РќРѕРјРµСЂ РљРЈРЎРџ </summary>
        public string? RegistrationNumber { get; set; }
        ///<summary> РћС‚РґРµР»РµРЅРёРµ </summary>
        public int? RegistrationDepartmentID { get; set; }
        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardCreate { get; set; }
        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardView { get; set; }
        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWork { get; set; }
        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWorkNext { get; set; }
        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardComplete { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? Deadline { get; set; }
        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? ServiceIncidentTypeId { get; set; }
        ///<summary> Р§РёСЃР»Рѕ РїСЂР°РІРѕРЅР°СЂСѓС€РёС‚РµР»РµР№ </summary>
        public int? CriminalsCount { get; set; }
        ///<summary> Р§РёСЃР»Рѕ С‚СЂР°РЅСЃРїРѕСЂС‚РЅС‹С… СЃСЂРµРґСЃС‚РІ </summary>
        public int? VehiclesCount { get; set; }
        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? ServiceOperator { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ Рѕ РїСЂРѕРёСЃС€РµСЃС‚РІРёРё </summary>
        public string? IncidentAdditionalInfo { get; set; }
        ///<summary> РќРѕРјРµСЂ РїРµСЂРІРѕРіРѕ РўРЎ РІ СЃРїРёСЃРєРµ </summary>
        public string? VehicleRegNumberReadOnly { get; set; }
        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? CallDuration { get; set; }
        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? DenialOfService { get; set; }
        ///<summary> СЃРїРµС†РёС„РёС‡РЅС‹Рµ РґР°РЅРЅС‹Рµ РґР»СЏ СЂРµРіРёРѕРЅР° СѓСЃС‚Р°РЅРѕРІРєРё </summary>
        public RegionDataModel? RegionData { get; set; }
        ///<summary> РџРѕРґРѕР·СЂРµРІР°РµРјС‹Рµ </summary> 
        public List<ISharerDescriptionModel>? CriminalDescriptionList { get; set; }
        ///<summary> Р Р°Р·С‹СЃРєРёРІР°РµРјС‹Рµ </summary> 
        public List<ISharerDescriptionModel>? LostPeopleDescriptionList { get; set; }
        ///<summary> РђРІС‚РѕС‚СЂР°РЅСЃРїРѕСЂС‚ </summary> 
        public List<IVehicleDescriptionModel>? VehicleList { get; set; }
        ///<summary> РџРѕСЃС‚СЂР°РґР°РІС€РёРµ </summary> 
        public List<IVictimDescriptionModel>? VictimList { get; set; }
    }
    public record CardOVDModel
    {
        ///<summary> РќРѕРјРµСЂ РєР°СЂС‚РѕС‡РєРё 112 </summary>
        public int EmergencyCardId { get; set; }
        ///<summary> РљС‚Рѕ РїСЂРёРЅСЏР» </summary>
        public string? Inspector { get; set; }
        ///<summary> РџСЂРёРЅСЏС‚РѕРµ СЂРµС€РµРЅРёРµ </summary>
        public int? StatusId { get; set; }
        ///<summary> РљРЈРЎРџ РћР’Р” </summary>
        public string? IntrinsicOVD { get; set; }
        ///<summary> Р”Р°С‚Р° СЂРµРі. </summary>
        public DateTime? RegDate { get; set; }
        ///<summary> в„–РґРµР»Р° / в„–РљРЈРЎРџ / в„–Р°РґРј. РїСЂРѕС‚. </summary>
        public string? DocNumber { get; set; }
        ///<summary> РЎС‚СЂР°РЅРёС†Р° </summary>
        public string? Page { get; set; }
        ///<summary> Р РµР·СѓР»СЊС‚Р°С‚ </summary>
        public bool Solved { get; set; }
        ///<summary> РљРІР°Р»РёС„РёРєР°С†РёСЏ РћР’Р” </summary>
        public int? OVDITypeId { get; set; }
        ///<summary> РљРЈРЎРџ Р”РџРЎ </summary>
        public string? IntrinsicDPS { get; set; }
        ///<summary> РРјРµРµС‚СЃСЏ РІРёРґРµРѕРЅР°Р±Р»СЋРґРµРЅРёРµ </summary>
        public bool? IsVideoObservation { get; set; }
        ///<summary> РРјРµРµС‚СЃСЏ РїРѕРґРѕР·СЂРµРІР°РµРјС‹Р№ РІ СЃРѕРІРµСЂС€РµРЅРёРё РїСЂРµСЃС‚СѓРїР»РµРЅРёСЏ </summary>
        public bool? IsSuspectedPerson { get; set; }
        ///<summary> РР·СЉСЏС‚С‹ СЃР»РµРґС‹, РІРµС‰РµСЃС‚РІРµРЅРЅС‹Рµ РґРѕРєР°Р·Р°С‚РµР»СЊСЃС‚РІР° </summary>
        public bool? IsEvidence { get; set; }
        ///<summary> РЈС‡Р°СЃС‚РёРµ СЂР°Р±РѕС‚РЅРёРєР° РЎРљ Р Р¤ </summary>
        public bool? IsSkRfStuff { get; set; }
        ///<summary> РџСЂРѕРІРµРґРµРЅРЅС‹Рµ РјРµСЂРѕРїСЂРёСЏС‚РёСЏ </summary>
        public int? PastEventId { get; set; }
        ///<summary> РРЅС„РѕСЂРјР°С†РёСЏ РїРѕ СЂРµР·СѓР»СЊС‚Р°С‚Р°Рј РІС‹РµР·РґР° </summary>
        public int? DepartureResultId { get; set; }
        ///<summary> РљС‚Рѕ РІС‹РµР·Р¶Р°Р» </summary> 
        public List<TaskForceItemModel>? TaskForceItemsList { get; set; }
    }
    public record Card03Model
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralDataModel? GeneralData { get; set; }
        ///<summary> ID РєР°СЂС‚РѕС‡РєРё РІ РєРѕРЅРєСЂРµС‚РЅС‹Р№ РґРµРЅСЊ </summary>
        public int? DailyId { get; set; }
        ///<summary> РўСЂР°РЅСЃРїРѕСЂС‚РёСЂРѕРІРєР° Р»Рё СЌС‚Р° РєР°СЂС‚РѕС‡РєР° </summary>
        public bool IsTransportation { get; set; }
        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ Р±РѕР»СЊРЅС‹С… </summary>
        public int? SickCount { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё </summary>
        public CardCompleteStatusModel? CompleteStatus { get; set; }
        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ Р›РџРЈ РѕС‚РїСЂР°РІРєРё </summary>
        public int? HospitalId { get; set; }
        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ Р›РџРЈ РЅР°Р·РЅР°С‡РµРЅРёСЏ </summary>
        public int? DstHospitalId { get; set; }
        ///<summary> РўРёРї С‚СЂР°РЅСЃРїРѕСЂС‚РёСЂРѕРІРєРё </summary>
        public int? TransportationId { get; set; }
        ///<summary> РџСЂРёС‡РёРЅР° С‚СЂР°РЅСЃРїРѕСЂС‚РёСЂРѕРІРєРё </summary>
        public int? TransportReasonId { get; set; }
        ///<summary> Р’СЂРµРјСЏ РѕРєРѕРЅС‡Р°РЅРёСЏ РѕР±СЃР»СѓР¶РёРІР°РЅРёСЏ РІС‹Р·РѕРІР° </summary>
        public DateTime? Closed { get; set; }
        ///<summary> Р’СЂРµРјСЏ РґРѕСЃС‚Р°РІР»РµРЅРёСЏ РІ Р›РџРЈ </summary>
        public DateTime? Admission { get; set; }
        ///<summary> РљСѓРґР° РґРѕСЃС‚Р°РІР»РµРЅ </summary>
        public string? DeliveredTo { get; set; }
        ///<summary> РЎРѕРѕР±С‰РµРЅРёРµ Р±СЂРёРіР°РґС‹ </summary>
        public string? TeamMessage { get; set; }
        ///<summary> РџСЂРёС‡РёРЅР° Р·Р°РєСЂС‹С‚РёСЏ РєР°СЂС‚РѕС‡РєРё </summary>
        public string? CloseReason { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ РґСѓР±Р»РёСЂРѕРІР°РЅРёСЏ </summary>
        public int? DuplicateStatus { get; set; }
        ///<summary> id РІРѕР·РјРѕР¶РЅРѕРіРѕ РѕСЂРёРіРёРЅР°Р»Р° </summary>
        public int? OriginalCardId { get; set; }
        ///<summary> Р РµРєРѕРјРµРЅРґРѕРІР°РЅРЅС‹Р№ РґРµРїР°СЂС‚Р°РјРµРЅС‚ </summary>
        public int? RecomendedDepId { get; set; }
        ///<summary> РЎС‚СЂРѕРєР° СЃ РёРЅС„РѕСЂРјР°С†РёРµР№ Рѕ Р±РѕР»СЊРЅС‹С… РґР»СЏ СЃРїРёСЃРєР° </summary>
        public string? SickPersonsInfo { get; set; }
        ///<summary> РЎС‚СЂРѕРєР° СЃ РїРµСЂРµС‡РёСЃР»РµРЅРёРµРј РїСЂРёС‡РёРЅ РІС‹Р·РѕРІР° РґР»СЏ РїРѕРґСЃРІРµС‚РєРё РІ СЃРїРёСЃРєРµ РїСЂРѕРёСЃС€РµСЃС‚РІРёР№ </summary>
        public string? SickPersonsReasons { get; set; }
        ///<summary> РЎС‚СЂРѕРєР° СЃ РїРµСЂРµС‡РёСЃР»РµРЅРёРµРј РјРµС‚РѕРє Рѕ С‚РѕРј, С‡С‚Рѕ РІС‹Р·РѕРІ СЏРІР»СЏРµС‚СЃСЏ РїСЂРёРѕСЂРёС‚РµС‚РЅС‹Рј </summary>
        public string? SickPersonsPriorities { get; set; }
        ///<summary> РЎС‚СЂРѕРєР° СЃ РёРЅС„РѕСЂРјР°С†РёРµР№ Рѕ Р±СЂРёРіР°РґР°С… </summary>
        public string? EnginesInfo { get; set; }
        ///<summary> РћСЃРІРѕР±РѕРґРёС‚СЊ Р±СЂРёРіР°РґС‹ </summary>
        public bool? IsFreeTransport { get; set; }
        ///<summary> РџРµСЂРµРґР°С‡Р° С†РµРЅС‚СЂР°Р»СЊРЅРѕРјСѓ РґРёСЃРїРµС‚С‡РµСЂСѓ </summary>
        public bool? IsTransfered { get; set; }
        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardCreate { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ Рѕ РїСЂРѕРёСЃС€РµСЃС‚РІРёРё </summary>
        public string? IncidentAdditionalInfo { get; set; }
        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardView { get; set; }
        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWork { get; set; }
        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWorkNext { get; set; }
        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardComplete { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? Deadline { get; set; }
        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? ServiceIncidentTypeId { get; set; }
        ///<summary> РљС‚Рѕ РІС‹Р·РІР°Р» </summary>
        public string? WhoCalled { get; set; }
        ///<summary> РљС‚Рѕ РІС‹Р·РІР°Р» (РєР»Р°СЃСЃРёС„РёРєР°С‚РѕСЂ) </summary>
        public int? WhoCalledId { get; set; }
        ///<summary> Р•СЃС‚СЊ РґРµС‚Рё </summary>
        public bool HaveChildren { get; set; }
        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? ServiceOperator { get; set; }
        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? RegistrationNumber { get; set; }
        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? CallDuration { get; set; }
        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? DenialOfService { get; set; }
        ///<summary> РџСЂРёРІР»РµС‡РµРЅС‹ РўРЎ 03 </summary>
        public bool? IsVehicleInvolved { get; set; }
        ///<summary> Р‘РѕР»СЊРЅС‹Рµ </summary> 
        public List<SickPersonModel>? SickPersons { get; set; }
        ///<summary> РЎРІРµРґРµРЅРёСЏ Рѕ РїСЂРёРІР»РµС‡РµРЅРЅС‹С… РўРЎ 03 </summary> 
        public List<Vehicle03InfoModel>? InvolvedVehicles { get; set; }
    }
    public record Card04Model
    {
        ///<summary> Общая информация </summary>
        public CardGeneralDataModel? GeneralData { get; set; }
        ///<summary> Сообщение </summary>
        public string? WhatHappened { get; set; }
        ///<summary> Коммунальная служба </summary>
        public int? CommunityServiceId { get; set; }
        ///<summary> Принятые меры </summary>
        public string? Measures { get; set; }
        ///<summary> Происшествие </summary>
        public int? CommunityServiceSituationId { get; set; }
        ///<summary> Экспортирована ли </summary>
        public bool? Exported { get; set; }
        ///<summary> Статус </summary>
        public CardCompleteStatusModel CompleteStatus { get; set; }
        ///<summary> Время создания сервисной карточки </summary>
        public DateTime? ServiceCardCreate { get; set; }
        ///<summary> Время просмотра сервисной карточки </summary>
        public DateTime? ServiceCardView { get; set; }
        ///<summary> Выезд на место </summary>
        public DateTime? ServiceCardWork { get; set; }
        ///<summary> Прибытие на место </summary>
        public DateTime? ServiceCardWorkNext { get; set; }
        ///<summary> Время закрытия сервисной карточки </summary>
        public DateTime? ServiceCardComplete { get; set; }
        ///<summary> Дата и время нарушения регламента </summary>
        public DateTime? Deadline { get; set; }
        ///<summary> Вид происшествия </summary>
        public int? ServiceIncidentTypeId { get; set; }
        ///<summary> Инструкции </summary>
        public int? InstructionId { get; set; }
        ///<summary> Консультация </summary>
        public bool IsConsulting { get; set; }
        ///<summary> Оператор ДДС принявший карточку </summary>
        public string? ServiceOperator { get; set; }
        ///<summary> Внутренний номер заявки ДДС </summary>
        public string? RegistrationNumber { get; set; }
        ///<summary> Продолжительность вызова </summary>
        public int? CallDuration { get; set; }
        ///<summary> Время отказа в обслуживании </summary>
        public DateTime? DenialOfService { get; set; }
    }
    public record CardCommServModel
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralDataModel? GeneralData { get; set; }
        ///<summary> РЎРѕРѕР±С‰РµРЅРёРµ </summary>
        public string? Message { get; set; }
        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ РїРѕ РѕР±СЉРµРєС‚Сѓ </summary>
        public string? ObjectInfo { get; set; }
        ///<summary> РЈРіСЂРѕР·Р° Р»СЋРґСЏРј </summary>
        public bool HumanThreat { get; set; }
        ///<summary> РџСЂРёР·РЅР°Рє Р§РЎ </summary>
        public bool EmergencyFlag { get; set; }
        ///<summary> Р’СЂРµРјСЏ СѓР±С‹С‚РёСЏ Р±СЂРёРіР°РґС‹ </summary>
        public DateTime? Depart { get; set; }
        ///<summary> Р’СЂРµРјСЏ РїСЂРёР±С‹С‚РёСЏ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? Arrival { get; set; }
        ///<summary> РўРёРї РѕР±СЉРµРєС‚Р° </summary>
        public int? ObjectTypeId { get; set; }
        ///<summary> Р’СЂРµРјСЏ СѓСЃС‚СЂР°РЅРµРЅРёСЏ </summary>
        public DateTime? Complete { get; set; }
        ///<summary> РЎС‚Р°С‚СѓСЃ </summary>
        public CardCompleteStatusModel CompleteStatus { get; set; }
        ///<summary> Р—Р°РґРµР№СЃС‚РІРѕРІР°РЅРЅС‹Рµ СЃРёР»С‹ </summary>
        public string? UsedMeans { get; set; }
        ///<summary> РљРѕРЅС‚СЂРѕР»СЊРЅРѕРµ РІСЂРµРјСЏ РІС‹РїРѕР»РЅРµРЅРёСЏ </summary>
        public DateTime? DeadlineExceeded { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РґРѕРІРµРґРµРЅРёСЏ РёРЅС„РѕСЂРјР°С†РёРё РґРѕ Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public DateTime? DeclarantNotify { get; set; }
        ///<summary> Р”РёСЃРїРµС‚С‡РµСЂ </summary>
        public string? AgentWhoNotifies { get; set; }
        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardCreate { get; set; }
        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardView { get; set; }
        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWork { get; set; }
        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWorkNext { get; set; }
        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardComplete { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? Deadline { get; set; }
        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? ServiceIncidentTypeId { get; set; }
        ///<summary> РљРѕРјРјСѓРЅР°Р»СЊРЅР°СЏ СЃР»СѓР¶Р±Р° </summary>
        public int? CommunityServiceId { get; set; }
        ///<summary> РРЅСЃС‚СЂСѓРєС†РёРё </summary>
        public int? InstructionId { get; set; }
        ///<summary> РљРѕРЅСЃСѓР»СЊС‚Р°С†РёСЏ </summary>
        public bool IsConsulting { get; set; }
        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? ServiceOperator { get; set; }
        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? RegistrationNumber { get; set; }
        ///<summary> РџСЂРёРЅСЏС‚С‹Рµ РјРµСЂС‹ </summary>
        public string? Measures { get; set; }
        ///<summary> РљР°С‚РµРіРѕСЂРёСЏ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? ServiceIncidentCategoryId { get; set; }
        ///<summary> РЈРїСЂР°РІР»СЏСЋС‰Р°СЏ РєРѕРјРїР°РЅРёСЏ </summary>
        public int? UKID { get; set; }
        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? CallDuration { get; set; }
        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? DenialOfService { get; set; }
    }
    public record CardATModel
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralDataModel? GeneralData { get; set; }
        ///<summary> РћРїРёСЃР°РЅРёРµ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public string? WhatHappened { get; set; }
        ///<summary> РџСЂРёРЅСЏС‚С‹Рµ РјРµСЂС‹ </summary>
        public string? Measures { get; set; }
        ///<summary> РЈС‰РµСЂР± </summary>
        public string? Damage { get; set; }
        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardCreate { get; set; }
        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardView { get; set; }
        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWork { get; set; }
        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? ServiceCardWorkNext { get; set; }
        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? ServiceCardComplete { get; set; }
        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? Deadline { get; set; }
        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? ServiceOperator { get; set; }
        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? RegistrationNumber { get; set; }
        ///<summary> Р’РёРґ С‚РµСЂСЂРѕСЂРёСЃС‚РёС‡РµСЃРєРѕРіРѕ Р°РєС‚Р° </summary>
        public int? ServiceIncidentTypeId { get; set; }
        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕРіРёР±С€РёС… </summary>
        public int? Died { get; set; }
        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕСЃС‚СЂР°РґР°РІС€РёС… </summary>
        public int? Victims { get; set; }
        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public int? Suspects { get; set; }
        ///<summary> РћРїРёСЃР°РЅРёРµ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? SuspectsDesc { get; set; }
        ///<summary> Р’РѕРѕСЂСѓР¶РµРЅРёРµ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? SuspectsEquipment { get; set; }
        ///<summary> РўСЂР°РЅСЃРїРѕСЂС‚РЅС‹Рµ СЃСЂРµРґСЃС‚РІР° РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? SuspectsVehicles { get; set; }
        ///<summary> РќР°РїСЂР°РІР»РµРЅРёРµ РґРІРёР¶РµРЅРёСЏ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? SuspectsDirection { get; set; }
        ///<summary> РџРѕРІСЂРµР¶РґРµРЅРёСЏ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? SuspectsInjury { get; set; }
        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? CallDuration { get; set; }
        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? DenialOfService { get; set; }
    }
    public record ServiceCard01Model
    {
        public Card112Model Card112Data { get; set; }
        public Card01Model Card01Data { get; set; }
    }
    public record ServiceCard02Model
    {
        public Card112Model Card112Data { get; set; }
        public Card02Model Card02Data { get; set; }
    }
    public record ServiceCard03Model
    {
        public Card112Model Card112Data { get; set; }
        public Card03Model Card03Data { get; set; }
    }
    public record ServiceCard04Model
    {
        public Card112Model Card112Data { get; set; }
        public Card04Model Card04Data { get; set; }
    }
    public record ServiceCardCommServModel
    {
        public Card112Model Card112Data { get; set; }
        public CardCommServModel CardCommServData { get; set; }
    }
    public record ServiceCardATModel
    {
        public Card112Model Card112Data { get; set; }
        public CardATModel CardATData { get; set; }
    }
    public record PrevDeclarantInfoModel
    {
        ///<summary> Р¤Р°РјРёР»РёСЏ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? PrevDeclarantLastName { get; set; }
        ///<summary> РРјСЏ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? PrevDeclarantName { get; set; }
        ///<summary> РћС‚С‡РµСЃС‚РІРѕ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? PrevDeclarantMiddleName { get; set; }
        ///<summary> РљРѕРЅС‚Р°РєС‚РЅС‹Р№ С‚РµР»РµС„РѕРЅ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? PrevCallerContactPhone { get; set; }
        ///<summary> Р“РѕСЂРѕРґ/РѕР±Р». Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public int? PrevDeclarantCityId { get; set; }
        ///<summary> РћРєСЂСѓРі Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public int? PrevDeclarantDistrictId { get; set; }
        ///<summary> РЈР»РёС†Р° Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public int? PrevDeclarantStreetId { get; set; }
        ///<summary> РќРѕРјРµСЂ РґРѕРјР° Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? PrevDeclarantBuildingNumber { get; set; }
        ///<summary> РљРѕСЂРїСѓСЃ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? PrevDeclarantCorps { get; set; }
        ///<summary> РљРІР°СЂС‚РёСЂР° Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? PrevDeclarantFlat { get; set; }
    }
    public record CardGeneralDataModel
    {
        public int EmergencyCardId { get; set; }
        public CardTypeModel CardType { get; set; }
        public bool CardCreated { get; set; }
    }
    public enum CardCompleteStatusModel
    {
        Submitted,
        Processing,
        Complete,
    }
    public enum CardTypeModel
    {
        /// <summary>
        /// Служба 112
        /// </summary>
        Card112,
        /// <summary>
        /// Служба 01
        /// </summary>
        Card01,
        /// <summary>
        /// Служба 02
        /// </summary>
        Card02,
        /// <summary>
        /// Служба 03
        /// </summary>
        Card03,
        /// <summary>
        /// Служба 04
        /// </summary>
        Card04,
        /// <summary>
        /// Служба ЕДДС
        /// </summary>
        CardCommServ,
        /// <summary>
        /// Служба Антитеррор
        /// </summary>
        CardAT,
    }
    public enum ValidatedCommandModel
    {
        CompleteCard,
        PrintCard,
    }
    public enum ErrorCodeModel
    {
        GENERAL_FAULT,
        UNKNOWN_ACTION,
        NO_FREE_HANDLERS,
        INTERRUPTED_CYCLE,
        DATABASE_FAULT,
        INVALID_CLIENT,
        INTERNAL_ERROR,
        SID_NOT_SPECIFIED,
        NON_INITIALIZED_MANAGERS,
        LOGIN_FAILED,
        LICENSE_ERROR,
        CLIENT_LICENSE_ERROR,
        INVALID_PARAMETERS,
    }
    public enum CallTypeModel
    {
        FalseCall,
        ChildPrank,
        Info,
        Card_01,
        Card_02,
        Card_03,
        Card_04,
        Card_CommServ,
        Repeated,
        Card_AT,
        Psychologist,
        Consultation,
        Interpreter,
        RosOhrana,
        GZHI,
        InterRegional,
    }
    public enum ServiceTypeModel
    {
        Service01,
        Service02,
        Service03,
        Service04,
        ServiceCommServ,
        Service112,
        ServiceAT,
        ServicePsychologist,
        ServiceConsultation,
        ServiceInterpreter,
        ServiceRosOhrana,
    }
    public enum ImportanceLevelModel
    {
        NotImportant,
        Important,
    }
    public enum CardSyntheticStateModelEnum
    {
        Request112,
        ServicesInvolvement,
        ServicesReaction,
        ServicesWork,
        Completed,
        ServicesStart,
        DenialOfService,
    }
    public enum SortingOrderModel
    {
        ASC,
        DESC,
    }
    public enum PhonogramSourceModel
    {
        Internal,
        External,
    }
    public enum DuplicateStatusModel
    {
        UnconfirmedDuplicate,
        Duplicate,
        DuplicateFalse,
        UnconfirmedRepeated,
        Repeated,
        RepeatedFalse,
    }
    public enum User03RoleModel
    {
        Operator_03,
        Dispatcher_03,
    }
    public enum ReflectionPriorityBy03ReasonModel
    {
        Emergency,
        Immediate,
        Urgent,
        Transportation,
        NoPriority,
    }
    public enum AttachmentTypeModel
    {
        IMAGE,
        ACTION,
        STRING,
        PHONE_NUMBER,
        GEOMETRY,
        DOWNLOAD,
        VP_ONLINE_URL,
        VP_ARCHIVE_URL,
        VP_THUMBNAIL,
        PROXY_DOWNLOAD,
    }
    public enum SMSTypeModel
    {
        Incoming,
        Outcoming,
    }
    public enum DirectionModel
    {
        Incoming,
        Outcoming,
    }
    public enum SMSStatusModel
    {
        Sent,
        NotSent,
        Received,
        NotReceived,
    }
    public enum SourceTypeModel
    {
        PHONE,
        SMS,
        ERA_GLONASS,
        WITHOUT_CALL,
        SENSORS,
        INTERNET_PORTAL,
    }
    public record CallCenterConnectionInfoModel
    {
        public string? Url { get; set; }
        public string? Description { get; set; }
    }
    public record AttachmentListModel
    {
        public List<AttachmentContentModel>? Attachments { get; set; }
    }
    public record AttachmentDataModel
    {
        public string? Url { get; set; }
        public string? Postdata { get; set; }
        public string? Value { get; set; }
        public string? Data { get; set; }
    }
    public record AttachmentContentModel
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public AttachmentTypeModel Type { get; set; }
        public AttachmentDataModel? Data { get; set; }
    }
    public enum ReportFormatTypeModel
    {
        pdf,
        xls,
        xlsx,
        docx,
        rtf,
    }
    public enum ExternalInfoTypeModel
    {
        Unknown,
        ContentList,
        SpbSvetetsAlert,
        Card112,
    }
    public record GeographicLocationModel
    {
        public double M_dLatitude { get; set; }
        public double M_dLongitude { get; set; }
    }
    public record CamertonEngineModel
    {
        public int EngineId { get; set; }
        public GeographicLocationModel? GeographicLocation { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? IconUrl { get; set; }
    }
    public record CardCommServFilterModel
    {
        public int? ServiceIncidentCategoryId { get; set; }
        public bool? IsDeadlineExceeded { get; set; }
    }
    public record Card03FilterModel
    {
        public bool? IsTransfered { get; set; }
        public bool? IsFilterEngine3 { get; set; }
        public bool? IsFilterEngine2 { get; set; }
        public int? HospitalId { get; set; }
        public int? StreetId { get; set; }
        public int? ReasonId { get; set; }
        public string? Age { get; set; }
        public int? Gender { get; set; }
        /// <summary> Id карточки </summary>
        public int? CardId { get; set; }
    }
    public record Card112FilterModel
    {
        public int? CardId { get; set; }
        public DateTime BeginPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string? PhoneNumber { get; set; }
        public int? ServiceId { get; set; }
        public int? LocalDistrictId { get; set; }
        public int? DistrictId { get; set; }
        public int? StreetId { get; set; }
        public string? Building { get; set; }
        public string? AgentLogin { get; set; }
        public string? CallerContactPhone { get; set; }
        public string? DeclarantLastName { get; set; }
        public int? CompleteStatus { get; set; }
        public ImportanceLevelModel? ImportanceLevel { get; set; }
        public bool? Completed { get; set; }
        public bool? IsUnwatched { get; set; }
        public string? IncidentDescription { get; set; }
        public DateTime? Deadline { get; set; }
        public bool? IsDayly { get; set; }
        public int? IncidentTypeId { get; set; }
        public bool? IsPriority { get; set; }
        public CardCommServFilterModel? CardCommServFilter { get; set; }
        public bool? TestCard { get; set; }
        public Card03FilterModel? Card03Filter { get; set; }
        public Card02FilterModel? Card02Filter { get; set; }
        public bool? IsServiceTypeIdCorrect { get; set; }
        public bool? WithEmptyStreet { get; set; }
        public string? DeclarantName { get; set; }
        public string? DeclarantMiddleName { get; set; }
        public bool? WithEmptyLocalDistrict { get; set; }
        public string? AdditionalLocationInfo { get; set; }
        /// <summary> Идентификатор района города звонящего </summary>
        public int? DeclarantLocalDistrictId { get; set; }
        /// <summary> Фильтровать по пустому району города звонящего </summary>
        public bool? WithEmptyDeclarantLocalDistrict { get; set; }
        /// <summary> Идентификатор улицы звонящего </summary>
        public int? DeclarantStreetId { get; set; }
        /// <summary> Фильтровать по пустой улице звонящего </summary>
        public bool? WithEmptyDeclarantStreet { get; set; }
        public string? DeclarantBuildingNumber { get; set; }
        /// <summary> Идентификатор региона </summary>
        public int? RegionId { get; set; }
        /// <summary> Количество привлеченных экстренных служб </summary>
        public int? ServiceCount { get; set; }
        public bool? Control { get; set; }
        /// <summary> Учитывать ли пустой город вместе с фильтром по идентификатору города </summary>
        public bool? WithEmptyCity { get; set; }
        public bool? WasInDenialOfService { get; set; }
        public List<int>? CallTypeIds { get; set; }
        public List<int>? SourceTypeIds { get; set; }
        /// <summary> список идентификаторов статусов карточек </summary>
        public List<int>? CardSyntheticStateIds { get; set; }
        /// <summary> список идентификаторов привлечённых отделений службы </summary>
        public List<int>? DepartmentIds { get; set; }
        /// <summary> список типов вызовов </summary>
        public List<int>? IncidentTypeIds { get; set; }
        /// <summary> районы </summary>
        public List<int>? CityIds { get; set; }
        /// <summary> Источники для исключения из списка </summary>
        public List<int>? ExcludeExternalCreatorsList { get; set; }
    }
    /// <summary> Правило валидации поля </summary>
    public record ValidationRuleModel
    {
        /// <summary> Тип правила, по которому определяется обязательность поля. Type обязательно используется во всех правилах ValidationRule.  </summary>
        public string? Type { get; set; }
        /// <summary> Другое поле карточки, которое используется при определении обязательности данного поля. CompareField не используется если данное поле безусловно обязательно. </summary>
        public string? CompareField { get; set; }
        /// <summary> Значение другого поля карточки при котором данное поле становится обязательным. CompareValue используется совместно с CompareField. </summary>
        public string? CompareValue { get; set; }
        /// <summary> Свойство служит для определения команды, для которой используется данное правило валидации. </summary>
        public ValidatedCommandModel? CommandProperty { get; set; }
    }
    public record Card112ValidationModel
    {
        /// <summary> Тип проиcшествия </summary>
        public List<ValidationRuleModel>? IncidentTypeId { get; set; }
        /// <summary> Отделение </summary>
        public List<ValidationRuleModel>? SelectedSubCallType { get; set; }
        /// <summary> Учебная </summary>
        public List<ValidationRuleModel>? IsTraining { get; set; }
        /// <summary> Важная </summary>
        public List<ValidationRuleModel>? IsPriority { get; set; }
        /// <summary> Улица </summary>
        public List<ValidationRuleModel>? StreetID { get; set; }
        /// <summary> Округ </summary>
        public List<ValidationRuleModel>? DistrictID { get; set; }
        /// <summary> Район </summary>
        public List<ValidationRuleModel>? CityID { get; set; }
        /// <summary> Дом </summary>
        public List<ValidationRuleModel>? Building { get; set; }
        /// <summary> Корпус </summary>
        public List<ValidationRuleModel>? Corps { get; set; }
        /// <summary> Квартира </summary>
        public List<ValidationRuleModel>? Room { get; set; }
        /// <summary> Подъезд </summary>
        public List<ValidationRuleModel>? Entrance { get; set; }
        /// <summary> Код в подъезд </summary>
        public List<ValidationRuleModel>? EntranceCode { get; set; }
        /// <summary> Объект </summary>
        public List<ValidationRuleModel>? ObjectId { get; set; }
        /// <summary> Этаж </summary>
        public List<ValidationRuleModel>? Floor { get; set; }
        /// <summary> Этажность </summary>
        public List<ValidationRuleModel>? TotalFloors { get; set; }
        /// <summary> Адресный участок </summary>
        public List<ValidationRuleModel>? AddressStrip { get; set; }
        /// <summary> Дополнительная информация </summary>
        public List<ValidationRuleModel>? AdditionalLocationInfo { get; set; }
        /// <summary> Угроза ЧС </summary>
        public List<ValidationRuleModel>? IsIncident { get; set; }
        /// <summary> Угроза людям </summary>
        public List<ValidationRuleModel>? IsHumanThreat { get; set; }
        /// <summary> Тип ЧС </summary>
        public List<ValidationRuleModel>? CCMC_TypeId { get; set; }
        /// <summary> Описание происшествия </summary>
        public List<ValidationRuleModel>? IncidentDescription { get; set; }
        /// <summary> Фамилия заявителя </summary>
        public List<ValidationRuleModel>? DeclarantLastName { get; set; }
        /// <summary> Имя заявителя </summary>
        public List<ValidationRuleModel>? DeclarantName { get; set; }
        /// <summary> Отчество заявителя </summary>
        public List<ValidationRuleModel>? DeclarantMiddleName { get; set; }
        /// <summary> Возраст заявителя </summary>
        public List<ValidationRuleModel>? AgeYear { get; set; }
        /// <summary> Контактный телефон </summary>
        public List<ValidationRuleModel>? CallerContactPhone { get; set; }
        /// <summary> Статус заявителя </summary>
        public List<ValidationRuleModel>? DeclarantStatusId { get; set; }
        /// <summary> Улица заявителя </summary>
        public List<ValidationRuleModel>? DeclarantStreetId { get; set; }
        /// <summary> Округ заявителя </summary>
        public List<ValidationRuleModel>? DeclarantDistrictId { get; set; }
        /// <summary> Район заявителя </summary>
        public List<ValidationRuleModel>? DeclarantCityId { get; set; }
        /// <summary> Дом заявителя </summary>
        public List<ValidationRuleModel>? DeclarantBuildingNumber { get; set; }
        /// <summary> Корпус заявителя </summary>
        public List<ValidationRuleModel>? DeclarantCorps { get; set; }
        /// <summary> Квартира заявителя </summary>
        public List<ValidationRuleModel>? DeclarantFlat { get; set; }
        /// <summary> Дополнительная информация о заявителе </summary>
        public List<ValidationRuleModel>? DeclarantAddress { get; set; }
        /// <summary> Координаты </summary>
        public List<ValidationRuleModel>? Coordinates { get; set; }
        /// <summary> Перекресток </summary>
        public List<ValidationRuleModel>? IsCrossroad { get; set; }
        /// <summary> Входящий номер телефона </summary>
        public List<ValidationRuleModel>? CgPN { get; set; }
        /// <summary> Дополнительная улица </summary>
        public List<ValidationRuleModel>? AdditionalStreetId { get; set; }
        /// <summary> Район города </summary>
        public List<ValidationRuleModel>? LocalDistrictId { get; set; }
        /// <summary> Рядом </summary>
        public List<ValidationRuleModel>? IsNear { get; set; }
        /// <summary> Км </summary>
        public List<ValidationRuleModel>? Km { get; set; }
        /// <summary> Количество пострадавших </summary>
        public List<ValidationRuleModel>? Casualties { get; set; }
        /// <summary> Язык </summary>
        public List<ValidationRuleModel>? LanguageId { get; set; }
        /// <summary> Район города заявителя </summary>
        public List<ValidationRuleModel>? DeclarantLocalDistrictId { get; set; }
        /// <summary> Этаж </summary>
        public List<ValidationRuleModel>? FloorString { get; set; }
        /// <summary> Строение </summary>
        public List<ValidationRuleModel>? Structure { get; set; }
        /// <summary> Строение заявителя </summary>
        public List<ValidationRuleModel>? DeclarantStructure { get; set; }
        /// <summary> Регион </summary>
        public List<ValidationRuleModel>? Region { get; set; }
    }
    /// <summary> Валидация полей карточки 01 </summary>
    public record Card01ValidationModel
    {
        /// <summary> Вид выезда </summary>
        public List<ValidationRuleModel>? FireIncidentTypeID { get; set; }
        /// <summary> Вид пожарной охраны </summary>
        public List<ValidationRuleModel>? FirePreventionTypeID { get; set; }
        /// <summary> Объект </summary>
        public List<ValidationRuleModel>? ObjectId { get; set; }
        /// <summary> Объект газифицирован </summary>
        public List<ValidationRuleModel>? ObjectGasified { get; set; }
        /// <summary> Хозяин объекта </summary>
        public List<ValidationRuleModel>? ObjectOwner { get; set; }
        /// <summary> Форма собственности </summary>
        public List<ValidationRuleModel>? Ownership { get; set; }
        /// <summary> Тип объекта </summary>
        public List<ValidationRuleModel>? ObjectTypeId { get; set; }
        /// <summary> Доп. инфо объекта </summary>
        public List<ValidationRuleModel>? ObjectAdditionalInfo { get; set; }
        /// <summary> План реагирования </summary>
        public List<ValidationRuleModel>? ReactionPlanId { get; set; }
        /// <summary> Ранг </summary>
        public List<ValidationRuleModel>? FireClassId { get; set; }
        /// <summary> Номер карточки УП </summary>
        public List<ValidationRuleModel>? InternalCardNumber { get; set; }
        /// <summary> Смена </summary>
        public List<ValidationRuleModel>? Shift { get; set; }
        /// <summary> Сообщение </summary>
        public List<ValidationRuleModel>? Message { get; set; }
        /// <summary> Расход воды (в литрах) </summary>
        public List<ValidationRuleModel>? WaterConsumption { get; set; }
        /// <summary> Время подачи первого ствола (в минутах) </summary>
        public List<ValidationRuleModel>? FirstFireBarrel { get; set; }
        /// <summary> Водоисточник </summary>
        public List<ValidationRuleModel>? WaterSourceID { get; set; }
        /// <summary> Всего (погибло) </summary>
        public List<ValidationRuleModel>? PerishedPeople { get; set; }
        /// <summary> Из них детей (погибло) </summary>
        public List<ValidationRuleModel>? PerishedChildren { get; set; }
        /// <summary> Сотрудников (погибло) </summary>
        public List<ValidationRuleModel>? PerishedCollaborators { get; set; }
        /// <summary> Всего (ранено) </summary>
        public List<ValidationRuleModel>? Wounded { get; set; }
        /// <summary> Из них детей (ранено) </summary>
        public List<ValidationRuleModel>? WoundedChildren { get; set; }
        /// <summary> Сотрудников (ранено) </summary>
        public List<ValidationRuleModel>? WoundedCollaborators { get; set; }
        /// <summary> Всего (спасено) </summary>
        public List<ValidationRuleModel>? SavedPeople { get; set; }
        /// <summary> Из них детей (спасено) </summary>
        public List<ValidationRuleModel>? SavedChildren { get; set; }
        /// <summary> Всего (нарушены ж/у) </summary>
        public List<ValidationRuleModel>? BrokenLivingConditions { get; set; }
        /// <summary> Из них детей (нарушены ж/у) </summary>
        public List<ValidationRuleModel>? BrokenLivingConditionsChildren { get; set; }
        /// <summary> Причина пожара </summary>
        public List<ValidationRuleModel>? FireReasonID { get; set; }
        /// <summary> Уточненная причина пожара </summary>
        public List<ValidationRuleModel>? Description { get; set; }
        /// <summary> Ущерб </summary>
        public List<ValidationRuleModel>? DamageCost { get; set; }
        /// <summary> Спасено мат. ценностей </summary>
        public List<ValidationRuleModel>? SavedCost { get; set; }
        /// <summary> Площадь </summary>
        public List<ValidationRuleModel>? Space { get; set; }
        /// <summary> Расстояние </summary>
        public List<ValidationRuleModel>? FireDistance { get; set; }
        /// <summary> Оперативный интерес </summary>
        public List<ValidationRuleModel>? PoliceInterest { get; set; }
        /// <summary> Характер происшествия </summary>
        public List<ValidationRuleModel>? ServiceIncidentTypeId { get; set; }
        /// <summary> Оценка времени развития пожара </summary>
        public List<ValidationRuleModel>? FireStartEstimate { get; set; }
        /// <summary> Последствия пожара </summary>
        public List<ValidationRuleModel>? FireResults { get; set; }
        /// <summary> Этажность </summary>
        public List<ValidationRuleModel>? NumberStoreys { get; set; }
    }
    /// <summary> Валидация полей карточки Силы и средства (в составе карточки 01) </summary>
    public record CardForceValidationModel
    {
        /// <summary> Локализация </summary>
        public List<ValidationRuleModel>? Localization { get; set; }
        /// <summary> Ликвидация </summary>
        public List<ValidationRuleModel>? Liquidation { get; set; }
        /// <summary> Ликвидация открытого огня </summary>
        public List<ValidationRuleModel>? OpenFireLiquidation { get; set; }
    }
    /// <summary> Валидация полей карточки 02 </summary>
    public record Card02ValidationModel
    {
        /// <summary> Квалификация </summary>
        public List<ValidationRuleModel>? ITypeID { get; set; }
        /// <summary> Номер КУСП </summary>
        public List<ValidationRuleModel>? RegistrationNumber { get; set; }
        /// <summary> Отдел </summary>
        public List<ValidationRuleModel>? RegistrationDepartmentID { get; set; }
        /// <summary> Вид правонарушения </summary>
        public List<ValidationRuleModel>? ServiceIncidentTypeId { get; set; }
        /// <summary> Количество правонарушителей </summary>
        public List<ValidationRuleModel>? CriminalsCount { get; set; }
        /// <summary> Количество ТС </summary>
        public List<ValidationRuleModel>? VehiclesCount { get; set; }
        /// <summary> Дополнительная информация о происшествии </summary>
        public List<ValidationRuleModel>? IncidentAdditionalInfo { get; set; }
    }
    /// <summary> Валидация полей карточки ОВД </summary>
    public record CardOvdValidationModel
    {
        /// <summary> № КУСП ОВД </summary>
        public List<ValidationRuleModel>? IntrinsicOVD_N { get; set; }
        /// <summary> № КУСП ДПС </summary>
        public List<ValidationRuleModel>? IntrinsicDPS_N { get; set; }
        /// <summary> Кто принял </summary>
        public List<ValidationRuleModel>? Inspector { get; set; }
        /// <summary> Информация по результатам выезда </summary>
        public List<ValidationRuleModel>? DepartureResultId { get; set; }
        /// <summary> Имеется подозреваемый в совершении преступления </summary>
        public List<ValidationRuleModel>? IsSuspectedPerson { get; set; }
        /// <summary> Изъяты следы, вещественные доказательства </summary>
        public List<ValidationRuleModel>? IsEvidence { get; set; }
        /// <summary> Имеется видеонаблюдение </summary>
        public List<ValidationRuleModel>? IsVideoObservation { get; set; }
        /// <summary> Участие работника СК РФ </summary>
        public List<ValidationRuleModel>? IsSkRfStuff { get; set; }
        /// <summary> Проведенные мероприятия </summary>
        public List<ValidationRuleModel>? PastEventId { get; set; }
        /// <summary> Принятое решение </summary>
        public List<ValidationRuleModel>? StatusId { get; set; }
        /// <summary> Дата рег. </summary>
        public List<ValidationRuleModel>? RegDate { get; set; }
        /// <summary> № дела/№ КУСП/№ адм. прот. </summary>
        public List<ValidationRuleModel>? DocNumber { get; set; }
        /// <summary> Страница </summary>
        public List<ValidationRuleModel>? Page { get; set; }
        /// <summary> Квалификация ОВД </summary>
        public List<ValidationRuleModel>? SelectedMalefactionGroup { get; set; }
        /// <summary> Квалификация ОВД </summary>
        public List<ValidationRuleModel>? OVDITypeId { get; set; }
        /// <summary> Результат </summary>
        public List<ValidationRuleModel>? Solved { get; set; }
    }
    /// <summary> Валидация полей карточки 02 Разыскиваемый </summary>
    public record Card02WantedValidationModel
    {
        /// <summary> На вид (Возраст) </summary>
        public List<ValidationRuleModel>? InLooksAge { get; set; }
        /// <summary> Пол </summary>
        public List<ValidationRuleModel>? Gender { get; set; }
        /// <summary> Рост </summary>
        public List<ValidationRuleModel>? StatureID { get; set; }
        /// <summary> Телосложение </summary>
        public List<ValidationRuleModel>? FigureID { get; set; }
        /// <summary> Одет </summary>
        public List<ValidationRuleModel>? Exterior { get; set; }
        /// <summary> Особые примеры </summary>
        public List<ValidationRuleModel>? Extra { get; set; }
        /// <summary> Фамилия </summary>
        public List<ValidationRuleModel>? LastName { get; set; }
        /// <summary> Имя </summary>
        public List<ValidationRuleModel>? FirstName { get; set; }
        /// <summary> Отчество </summary>
        public List<ValidationRuleModel>? MiddleName { get; set; }
        /// <summary> Дата рождения </summary>
        public List<ValidationRuleModel>? BirthdayDate { get; set; }
    }
    /// <summary> Валидация полей карточки 02 Подозреваемый </summary>
    public record Card02SuspectValidationModel
    {
        /// <summary> На вид (Возраст) </summary>
        public List<ValidationRuleModel>? InLooksAge { get; set; }
        /// <summary> Пол </summary>
        public List<ValidationRuleModel>? Gender { get; set; }
        /// <summary> Рост </summary>
        public List<ValidationRuleModel>? StatureID { get; set; }
        /// <summary> Телосложение </summary>
        public List<ValidationRuleModel>? FigureID { get; set; }
        /// <summary> Одет </summary>
        public List<ValidationRuleModel>? Exterior { get; set; }
        /// <summary> Особые примеры </summary>
        public List<ValidationRuleModel>? Extra { get; set; }
        /// <summary> Фамилия </summary>
        public List<ValidationRuleModel>? LastName { get; set; }
        /// <summary> Имя </summary>
        public List<ValidationRuleModel>? FirstName { get; set; }
        /// <summary> Отчество </summary>
        public List<ValidationRuleModel>? MiddleName { get; set; }
        /// <summary> Дата рождения </summary>
        public List<ValidationRuleModel>? BirthdayDate { get; set; }
    }
    /// <summary> Валидация полей карточки 02 Транспорт </summary>
    public record Card02VehicleValidationModel
    {
        /// <summary> Марка </summary>
        public List<ValidationRuleModel>? Vendor { get; set; }
        /// <summary> Модель </summary>
        public List<ValidationRuleModel>? Name { get; set; }
        /// <summary> Цвет </summary>
        public List<ValidationRuleModel>? Color { get; set; }
        /// <summary> Номер </summary>
        public List<ValidationRuleModel>? RegistrationNumber { get; set; }
        /// <summary> Дополнительная информация </summary>
        public List<ValidationRuleModel>? Extra { get; set; }
        /// <summary> Регион </summary>
        public List<ValidationRuleModel>? Region { get; set; }
        /// <summary> Тип ТС из классификатора </summary>
        public List<ValidationRuleModel>? TypeId { get; set; }
        /// <summary> Цвет ТС из классификатора </summary>
        public List<ValidationRuleModel>? ColorId { get; set; }
        /// <summary> Скрылось с места происшествия </summary>
        public List<ValidationRuleModel>? Hided { get; set; }
    }
    /// <summary> Валидация полей карточки 02 Пострадавший </summary>
    public record Card02VictimValidationModel
    {
        /// <summary> Фамилия </summary>
        public List<ValidationRuleModel>? LastName { get; set; }
        /// <summary> Имя </summary>
        public List<ValidationRuleModel>? FirstName { get; set; }
        /// <summary> Отчество </summary>
        public List<ValidationRuleModel>? MiddleName { get; set; }
        /// <summary> Район (пострадавшего) </summary>
        public List<ValidationRuleModel>? CityId { get; set; }
        /// <summary> Улица (пострадавшего) </summary>
        public List<ValidationRuleModel>? StreetId { get; set; }
        /// <summary> Дом </summary>
        public List<ValidationRuleModel>? BuildingNumber { get; set; }
        /// <summary> Корпус </summary>
        public List<ValidationRuleModel>? Corps { get; set; }
        /// <summary> Квартира </summary>
        public List<ValidationRuleModel>? Flat { get; set; }
        /// <summary> Телефон </summary>
        public List<ValidationRuleModel>? ContactPhone { get; set; }
        /// <summary> Доп. инфо </summary>
        public List<ValidationRuleModel>? AdditionalInfo { get; set; }
    }
    /// <summary> Валидация полей карточки 03 </summary>
    public record Card03ValidationModel
    {
        /// <summary> Перевозка </summary>
        public List<ValidationRuleModel>? IsTransportation { get; set; }
        /// <summary> Тип объекта </summary>
        public List<ValidationRuleModel>? ObjectTypeId { get; set; }
        /// <summary> Объект </summary>
        public List<ValidationRuleModel>? ObjectId { get; set; }
        /// <summary> Тип перевозки </summary>
        public List<ValidationRuleModel>? TransportReasonId { get; set; }
        /// <summary> Вид транспортировки </summary>
        public List<ValidationRuleModel>? TransportationId { get; set; }
        /// <summary> Откуда </summary>
        public List<ValidationRuleModel>? HospitalId { get; set; }
        /// <summary> Куда </summary>
        public List<ValidationRuleModel>? DstHospitalId { get; set; }
        /// <summary> Куда доставлен </summary>
        public List<ValidationRuleModel>? DeliveredTo { get; set; }
        /// <summary> Время поступления в ЛПУ </summary>
        public List<ValidationRuleModel>? Admission { get; set; }
        /// <summary> Время окончания обслуживания вызова </summary>
        public List<ValidationRuleModel>? Closed { get; set; }
        /// <summary> Сообщение бригады </summary>
        public List<ValidationRuleModel>? TeamMessage { get; set; }
        /// <summary> Причина закрытия </summary>
        public List<ValidationRuleModel>? CloseReason { get; set; }
        /// <summary> Выезд на место </summary>
        public List<ValidationRuleModel>? ServiceCardWork { get; set; }
        /// <summary> Прибытие на место </summary>
        public List<ValidationRuleModel>? ServiceCardWorkNext { get; set; }
        /// <summary> Вид происшествия </summary>
        public List<ValidationRuleModel>? ServiceIncidentTypeId { get; set; }
        /// <summary> Кто вызвал </summary>
        public List<ValidationRuleModel>? WhoCalledId { get; set; }
        /// <summary> Имеются дети </summary>
        public List<ValidationRuleModel>? HaveChildren { get; set; }
        /// <summary> Дополнительная информация </summary>
        public List<ValidationRuleModel>? IncidentAdditionalInfo { get; set; }
    }
    /// <summary> Валидация полей карточки 03 Пострадавший </summary>
    public record Card03SickPersonValidationModel
    {
        /// <summary> Имя </summary>
        public List<ValidationRuleModel>? Name { get; set; }
        /// <summary> Повод </summary>
        public List<ValidationRuleModel>? ReasonId { get; set; }
        /// <summary> Пол </summary>
        public List<ValidationRuleModel>? IsMale { get; set; }
        /// <summary> Приметы </summary>
        public List<ValidationRuleModel>? SickPersonSigns { get; set; }
        /// <summary> Дата рождения </summary>
        public List<ValidationRuleModel>? Birth { get; set; }
        /// <summary> Bозраст (лет) </summary>
        public List<ValidationRuleModel>? AgeYear { get; set; }
        /// <summary> Bозраст (месяцев) </summary>
        public List<ValidationRuleModel>? AgeMonth { get; set; }
        /// <summary> Bозраст (дней) </summary>
        public List<ValidationRuleModel>? AgeDay { get; set; }
        /// <summary> Приоритетный </summary>
        public List<ValidationRuleModel>? IsReasonPriority { get; set; }
        /// <summary> Диагноз </summary>
        public List<ValidationRuleModel>? ConsultDiagnosId { get; set; }
        /// <summary> Фамилия </summary>
        public List<ValidationRuleModel>? LastName { get; set; }
        /// <summary> Отчество </summary>
        public List<ValidationRuleModel>? MiddleName { get; set; }
        /// <summary> Возраст </summary>
        public List<ValidationRuleModel>? Age { get; set; }
    }
    /// <summary> Валидация полей карточки 04 </summary>
    public record Card04ValidationModel
    {
        /// <summary> Сообщение </summary>
        public List<ValidationRuleModel>? WhatHappened { get; set; }
        /// <summary> Коммунальная служба </summary>
        public List<ValidationRuleModel>? CommunityServiceId { get; set; }
        /// <summary> Происшествие </summary>
        public List<ValidationRuleModel>? CommunityServiceSituationId { get; set; }
        /// <summary> Принятые меры </summary>
        public List<ValidationRuleModel>? Measures { get; set; }
        /// <summary> Тип происшествия </summary>
        public List<ValidationRuleModel>? ServiceIncidentTypeId { get; set; }
        /// <summary> Инструкции </summary>
        public List<ValidationRuleModel>? InstructionId { get; set; }
        /// <summary> Консультация </summary>
        public List<ValidationRuleModel>? IsConsulting { get; set; }
        /// <summary> Инструкции </summary>
        public List<ValidationRuleModel>? GasInstructions { get; set; }
        /// <summary> Выезд на место </summary>
        public List<ValidationRuleModel>? ServiceCardWork { get; set; }
        /// <summary> Прибытие на место </summary>
        public List<ValidationRuleModel>? ServiceCardWorkNext { get; set; }
    }
    /// <summary> Валидация полей карточки AT </summary>
    public record CardATValidationModel
    {
        /// <summary> Описание происшествия </summary>
        public List<ValidationRuleModel>? WhatHappened { get; set; }
        /// <summary> Принятые меры </summary>
        public List<ValidationRuleModel>? Measures { get; set; }
        /// <summary> Ущерб </summary>
        public List<ValidationRuleModel>? Damage { get; set; }
        /// <summary> Вид террористического акта </summary>
        public List<ValidationRuleModel>? ServiceIncidentTypeId { get; set; }
        /// <summary> Количество погибших </summary>
        public List<ValidationRuleModel>? Died { get; set; }
        /// <summary> Количество пострадавших </summary>
        public List<ValidationRuleModel>? Victims { get; set; }
        /// <summary> Количество подозреваемых </summary>
        public List<ValidationRuleModel>? Suspects { get; set; }
        /// <summary> Описание подозреваемых </summary>
        public List<ValidationRuleModel>? SuspectsDesc { get; set; }
        /// <summary> Вооружение подозреваемых </summary>
        public List<ValidationRuleModel>? SuspectsEquipment { get; set; }
        /// <summary> Транспортные средства подозреваемых </summary>
        public List<ValidationRuleModel>? SuspectsVehicles { get; set; }
        /// <summary> Направление движения подозреваемых </summary>
        public List<ValidationRuleModel>? SuspectsDirection { get; set; }
        /// <summary> Повреждения подозреваемых </summary>
        public List<ValidationRuleModel>? SuspectsInjury { get; set; }
        /// <summary> Выезд на место </summary>
        public List<ValidationRuleModel>? ServiceCardWork { get; set; }
        /// <summary> Прибытие на место </summary>
        public List<ValidationRuleModel>? ServiceCardWorkNext { get; set; }
    }
    /// <summary> Валидация полей карточки ЕДДС/ЖКХ </summary>
    public record CardCommServValidationModel
    {
        /// <summary> Тема обращения </summary>
        public List<ValidationRuleModel>? CategoryCommServId { get; set; }
        /// <summary> Сообщение </summary>
        public List<ValidationRuleModel>? Message { get; set; }
        /// <summary> Дополнительная информация по объекту </summary>
        public List<ValidationRuleModel>? ObjectInfo { get; set; }
        /// <summary> Контрольное время устранения </summary>
        public List<ValidationRuleModel>? DeadlineExceeded { get; set; }
        /// <summary> Задействованные силы </summary>
        public List<ValidationRuleModel>? UsedMeans { get; set; }
        /// <summary> Время убытия бригады </summary>
        public List<ValidationRuleModel>? Depart { get; set; }
        /// <summary> Время прибытия на место </summary>
        public List<ValidationRuleModel>? Arrival { get; set; }
        /// <summary> Время устранения </summary>
        public List<ValidationRuleModel>? Complete { get; set; }
        /// <summary> Дата и время доведения информации до заявителя </summary>
        public List<ValidationRuleModel>? DeclarantNotify { get; set; }
        /// <summary> Диспетчер </summary>
        public List<ValidationRuleModel>? AgentWhoNotifies { get; set; }
        /// <summary> Коммунальная служба </summary>
        public List<ValidationRuleModel>? CommunityServiceId { get; set; }
        /// <summary> Принятые меры </summary>
        public List<ValidationRuleModel>? Measures { get; set; }
        /// <summary> Управляющая компания </summary>
        public List<ValidationRuleModel>? ManagementCompanyId { get; set; }
        /// <summary> Объект </summary>
        public List<ValidationRuleModel>? ObjectTypeId { get; set; }
        /// <summary> Признак ЧС </summary>
        public List<ValidationRuleModel>? EmergencyFlag { get; set; }
        /// <summary> Аварийная </summary>
        public List<ValidationRuleModel>? EmergencyFlagId { get; set; }
        /// <summary> Вид происшествия </summary>
        public List<ValidationRuleModel>? ServiceIncidentTypeId { get; set; }
        /// <summary> Инструкции </summary>
        public List<ValidationRuleModel>? InstructionId { get; set; }
        /// <summary> Консультация </summary>
        public List<ValidationRuleModel>? IsConsulting { get; set; }
    }
    /// <summary> Валидация полей карточки кастомной службы (старой) </summary>
    public record CardCustomServiceValidationModel
    {
        /// <summary> Комментарий </summary>
        public List<ValidationRuleModel>? Comment { get; set; }
        /// <summary> Вид выезда </summary>
        public List<ValidationRuleModel>? IncidentTypeId { get; set; }
        /// <summary> Силы и средства </summary>
        public List<ValidationRuleModel>? DepartmentId { get; set; }
        /// <summary> Выезд на место </summary>
        public List<ValidationRuleModel>? DepartureAtTime { get; set; }
        /// <summary> Прибытие на место </summary>
        public List<ValidationRuleModel>? ArrivedAtTime { get; set; }
        /// <summary> Принятые меры </summary>
        public List<ValidationRuleModel>? Measures { get; set; }
    }
    public record CardCustomServiceValidationItemModel
    {
        /// <summary> Id службы </summary>
        public int ServiceTypeId { get; set; }
        public CardCustomServiceValidationModel? Validation { get; set; }
    }
    /// <summary> Валидация всех карточек </summary>
    public record ValidationsModel
    {
        public Card112ValidationModel? Card112 { get; set; }
        public Card01ValidationModel? Card01 { get; set; }
        public Card02ValidationModel? Card02 { get; set; }
        public CardOvdValidationModel? CardOvd { get; set; }
        public CardForceValidationModel? CardForce { get; set; }
        public Card02SuspectValidationModel? Card02Suspect { get; set; }
        public Card02WantedValidationModel? Card02Wanted { get; set; }
        public Card02VehicleValidationModel? Card02Vehicle { get; set; }
        public Card02VictimValidationModel? Card02Victim { get; set; }
        public Card03ValidationModel? Card03 { get; set; }
        public Card03SickPersonValidationModel? Card03SickPerson { get; set; }
        public Card04ValidationModel? Card04 { get; set; }
        public CardATValidationModel? CardAT { get; set; }
        public CardCommServValidationModel? CardCommServ { get; set; }
        public List<CardCustomServiceValidationItemModel>? CardCustomServices { get; set; }
    }
    public record ButtonCommandModel
    {
        /// <summary> Основная команда кнопки </summary>
        public CommandModel? DefaultCommand { get; set; }
        /// <summary> Дополнительная команда кнопки </summary>
        public CommandModel? AdditionalCommand { get; set; }
    }
    public enum CommandModel
    {
        SaveCardWithTransferCommand,
        InitConferenceCommand,
    }
    public record RoleSettingsModel
    {
        /// <summary> Директория для сохранения карточки в xml формате </summary>
        public string? SaveFileToXmlPath { get; set; }
        public ValidationsModel? Validations { get; set; }
        /// <summary> Название роли </summary>
        public string? RoleTitle { get; set; }
        /// <summary> Возможность создавать карточки без вызова </summary>
        public bool CreateCardWithoutCall { get; set; }
        /// <summary> Показывать вкладку дубликатов </summary>
        public bool ShowDuplicates { get; set; }
        public bool EditCard { get; set; }
        public bool FilterCards { get; set; }
        /// <summary> Отображать кнопку История </summary>
        public bool ShowHistory { get; set; }
        /// <summary> Возможность прослушивать записи переговоров </summary>
        public bool LoadVoiceRecord { get; set; }
        public bool DeadlineControl { get; set; }
        public bool ShowReports { get; set; }
        public bool CompleteOnSave { get; set; }
        public bool CanCompleteCards { get; set; }
        /// <summary> Имя пользователя на Геосервере (в частности, используется для получения пользовательских слоев) </summary>
        public string? GeoServerUser { get; set; }
        /// <summary> Фильтр по Типу вызова карточек и переопределение типа вызова по умолчанию </summary>
        public int? CallTypeIdFilter { get; set; }
        /// <summary> На рабочих местах 3-го уровня показывать все карточки не учитывая отделение </summary>
        public bool DoNotUseCardDepartmentFilter { get; set; }
        public bool? IsImportanceLevelEnabled { get; set; }
        public ImportanceLevelModel? ImportanceLevelDefaultValue { get; set; }
        /// <summary> Измеряется в секундах (целое число), при получении нотификаций прежде чем обновлять список карточек будет сделана пауза в столько секунд, сколько указано в настройке </summary>
        public int? UselessRefreshTimeout { get; set; }
        /// <summary> Sets the timeout when downloading reports </summary>
        public int? ReportTimeout { get; set; }
        /// <summary> Gets or sets a time-out in milliseconds when writing to or reading from a stream for reports downloading </summary>
        public int? ReportReadWriteTimeout { get; set; }
        /// <summary> Gets or sets a time-out in milliseconds when writing to or reading from a stream for pinger </summary>
        public int? PingerReadWriteTimeout { get; set; }
        /// <summary> Gets or sets a time-out in milliseconds when writing to or reading from a stream </summary>
        public int? ReadWriteTimeout { get; set; }
        public int? LocalDistrictId { get; set; }
        /// <summary> Уровень приближения при автофокусе на адресном объекте </summary>
        public int? AutoZoomLevel { get; set; }
        /// <summary> Минимальный уровень приближения на карте </summary>
        public int? MinZoomLevel { get; set; }
        /// <summary> Максимальный уровень приближения на карте </summary>
        public int? MaxZoomLevel { get; set; }
        /// <summary> Текстовый идентификатор службы </summary>
        public ServiceTypeModel? ServiceType { get; set; }
        /// <summary> Настройки кнопки Передать с вызовом </summary>
        public ButtonCommandModel? TransferButtonCommand { get; set; }
        /// <summary> Включить всплывающие подсказки к полям карточки (режим УТК УСПО) </summary>
        public bool? InteractiveToolTipsEnabled { get; set; }
        /// <summary> Оператору доступна кнопка Сообщения </summary>
        public bool? CanSendMessage { get; set; }
        /// <summary> Параметры колл центра для проигрывания звука </summary>
        public CallCenterParameterModel? CallCenterParameters { get; set; }
        /// <summary> Количество гео-объектов, подгружаемых в одном запросе к гео-серверу </summary>
        public int? GisPageSize { get; set; }
        /// <summary> Должен ли быть выбран город в фильтре при старте приложения </summary>
        public bool? IsCitySelectedInFilterDefault { get; set; }
        /// <summary> Пользователю запрещен доступ к локальной папке с аудио записями вызовов. </summary>
        public bool? RecordsFolderAccessDenied { get; set; }
        /// <summary> Пользователю разрешено включать отображение внешних слоев. </summary>
        public bool? CanShowRemoteLayers { get; set; }
        /// <summary> Не проигрывать сирену при поступлении уведомления с новой карточкой. Указание этого значения переопределит значение, заданное в БД. </summary>
        public bool? NoCardCreationSiren { get; set; }
        /// <summary> Показывать метеоданные (только для IsMap = true). </summary>
        public bool? ShowWeather { get; set; }
        /// <summary> Таймаут ожидания ответа от сервера (кроме пинга, отчетов и загрузки словарей) </summary>
        public int? WebRequestTimeout { get; set; }
        /// <summary> Переключаться в оперативный режим при разблокировке РМО и приёме вызова </summary>
        public bool? SwitchToNormalModeWhenUnlockedOrAnsweredCall { get; set; }
        /// <summary> Фильтр по дате при переходе в режим статистики, в днях (если 1 - то 24 часа) </summary>
        public int? DefaultSerfingModeFilterPeriod { get; set; }
        /// <summary> Максимальный период в фильтре по дате в режиме статистики </summary>
        public int? MaxSerfingModeFilterPeriod { get; set; }
        /// <summary> Показывать кнопку Конференция </summary>
        public bool? ShowConferenceButton { get; set; }
        /// <summary> Идентификатор службы </summary>
        public int? ServiceTypeId { get; set; }
        /// <summary> Является ли CallType полем только для чтения </summary>
        public bool? IsCallTypeReadOnly { get; set; }
        /// <summary> Цвет подсветки карточек, не просмотренных службой </summary>
        public string? UnviewedCardsHighlightColor { get; set; }
        /// <summary> Возможность для оператора 112 отправлять СМС </summary>
        public bool? CanOperator112SendSms { get; set; }
        /// <summary> Возможность для оператора 112 использовать вкладку мониторинга </summary>
        public bool? MonitoringTabEnabled { get; set; }
        /// <summary> Измеряется в миллисекундах (целое число, минимальное значение - 50), при скролле списка карточек прежде чем обновлять список карточек будет сделана пауза в столько миллисекунд, сколько указано в настройке </summary>
        public int? CardListScrollThrottlingDelay { get; set; }
        /// <summary> Показывать вкладку с вложениями </summary>
        public bool? ShowAttachments { get; set; }
        /// <summary> Возможность копировать данные ЭРА в описание происшествия </summary>
        public bool? CanCopyEraDataToDescription { get; set; }
        /// <summary> Возможность открывать карточку в новом окне </summary>
        public bool? CanOpenCardInNewWindow { get; set; }
        /// <summary> Пропускать добавление вызова в историю вызовов в режиме статистики </summary>
        public bool? SkipCallAppendToCallHistoryOnStatistics { get; set; }
        /// <summary> Возможность для оператора 112 отправлять отправлять сообщение в чат </summary>
        public bool? CanOperator112SendChatMessage { get; set; }
        /// <summary> На клиенте будут храниться логи последних KeepLogsLatestLaunches запусков (не учитывая текущий) и последних KeepLogsLatestDays дней включительно. Логи более старших запусков будут стираться </summary>
        public int? KeepLogsLatestLaunches { get; set; }
        /// <summary> На клиенте будут храниться логи последних KeepLogsLatestLaunches запусков (не учитывая текущий) и последних KeepLogsLatestDays дней включительно. Логи более старших запусков будут стираться </summary>
        public int? KeepLogsLatestDays { get; set; }
        /// <summary> Отключить панель служб в карточке при пустом типе происшествия </summary>
        public bool? DisableServicesChoiceWhenEmptyIncidentTypeId { get; set; }
        /// <summary> Цвет подсветки карточек, которые были изменены после первого сохранения (в hex-виде, например, #bbedbb) </summary>
        public string? ChangedAfterFirstSaveCardsHighlightColor { get; set; }
        /// <summary> Показывать чекбокс Без КСОМБ в фильтре </summary>
        public bool? ShowWithoutKsombFilterCheckbox { get; set; }
        /// <summary> Показывать чекбокс Контроль в фильтре </summary>
        public bool? ShowControlFilterCheckbox { get; set; }
        /// <summary> Не показывать поле Адресный участок </summary>
        public bool? DoNotShowAddressArea { get; set; }
        /// <summary> Допускать в поле подъезд только цифры </summary>
        public bool? EntranceOnlyDigits { get; set; }
        /// <summary> Новый вид кастомной службы </summary>
        public bool? EnableNewCustomServices { get; set; }
        /// <summary> Показывать кнопку Изменить формат координат </summary>
        public bool? IsShowChangeCoordinatesFormatButton { get; set; }
        /// <summary> Требуется авторизация для работы в приложении </summary>
        public bool? EnableMandatoryAuthorization { get; set; }
        /// <summary> Таймер для отображения времени регламента </summary>
        public bool? IsDeadlinesTimerEnable { get; set; }
        /// <summary> Показать вкладку с отчётами о статистике вызовов системы-112 </summary>
        public bool? Is112CallStatisticReportsShow { get; set; }
        /// <summary> Минимизировать данные от ЭРЫ-ГЛОНАСС </summary>
        public bool? MinimizeEraData { get; set; }
        /// <summary> Включить возможность влиять на реагирование службы ЕДДС/ЖКХ </summary>
        public bool? CanChangeReactionOfCommServ { get; set; }
        /// <summary> Отображать единое поле координат в окне 'Координаты центра карты' </summary>
        public bool? SingleFieldCenterMapCoordinates { get; set; }
        /// <summary> Отправлять 'ServiceTypeId' для направления передачи карточки с вызовом </summary>
        public bool? IsSendServiceTypeIdForCallTransfer { get; set; }
        /// <summary> Отправка СМС осуществляется по 'Ctrl-Enter', перенос по 'Enter' (по умолчанию: 'Enter' - отправка, 'Ctrl-Enter' - перенос) </summary>
        public bool? SendSmsByCtrlEnter { get; set; }
        /// <summary> Отображать вкладку 'СМС' в окне 'Просмотр дубликата' </summary>
        public bool? ShowSmsTabInDuplicate { get; set; }
        /// <summary> Отображать кнопку 'В работу' </summary>
        public bool? ShowToWorkButton { get; set; }
        /// <summary> Отображать кнопку 'Реагирование' </summary>
        public bool? ShowReactionButton { get; set; }
        /// <summary> Список IP адресов applicast </summary>
        public List<string>? ApplicastAddresses { get; set; }
        /// <summary> Список Url до гео сервера для получения подложки </summary>
        public List<MapTileUrlModelFromGenerated>? MapTileUrls { get; set; }
        /// <summary> Список Url до гео сервера </summary>
        public List<string>? MapUrls { get; set; }
        /// <summary> Список Url КОН </summary>
        public List<string>? ConsultUrls { get; set; }
        /// <summary> Список url MRS </summary>
        public List<MRSSettingsModel>? MrsSettings { get; set; }
        /// <summary> Список типов карточек доступных для изменения  </summary>
        public List<OperatorCanEditItemModel>? OperatorCanEditCollection { get; set; }
        /// <summary> Список настроек адресной книги </summary>
        public List<AddressbookSettingModel>? AddressbookSettings { get; set; }
        /// <summary> Список правил подсветки карточек в списке карточек </summary>
        public List<CardHighlightItemModel>? CardHighlightCollection { get; set; }
        /// <summary> Список видимых слоев по умолчанию </summary>
        public List<int>? DefaultVisibleLayers { get; set; }
        /// <summary> Список id типов вызовов, при выборе которых панель служб в карточке должна быть отключена </summary>
        public List<int>? DisableServicesChoiceForCallTypeIds { get; set; }
        /// <summary> Запретить менять остальные id типы вызовов на эти id типов вызовов. В этом списке обязательно должны быть id типов вызовов Ложный (1), Детская шалость (2), Справочный (3), Повторный (9) </summary>
        public List<int>? DisallowToChangeOtherCallTypeIdsToTheseCallTypeIds { get; set; }
        /// <summary> Список id служб, которые будут всегда привлечены при создании карточки. </summary>
        public List<int>? DefaultInvolvedServiceTypeIds { get; set; }
    }
    public enum CallStatusModel
    {
        TransferedTo01,
        TransferedTo02,
        TransferedTo03,
        TransferedTo04,
        TransferedToAT,
        TransferedToCommServ,
        TerminatedByOperator,
        TerminatedByAbonent,
    }
    public record EmergencyCardModel
    {
        public Card112Model Card112 { get; set; }
        public Card01Model Card01 { get; set; }
        public Card02Model Card02 { get; set; }
        public Card03Model Card03 { get; set; }
        public Card04Model Card04 { get; set; }
        public CardATModel CardAT { get; set; }
        public CardCommServModel CardCommServ { get; set; }
    }
    public record OperatorCanEditItemModel
    {
        public CardTypeModel Card { get; set; }
        public ServiceCardEditViewModel View { get; set; }
        public bool CanComplete { get; set; }
        public bool CanChangeState { get; set; }
    }
    public enum ServiceCardEditViewModel
    {
        ///<summary>Карточка 01 как у ДДС 01</summary>
        Card01View,
        ///<summary>Карточка 01 Санкт-Петербург для просмотра</summary>
        Card01SpbView,
        ///<summary>Карточка 01 Санкт-Петербург для редактирования</summary>
        Card01SpbEditView,
        ///<summary>Карточка 02 как у ДДС 02</summary>
        Card02View,
        ///<summary>Карточка 02 Санкт-Петербург для просмотра</summary>
        Card02SpbView,
        ///<summary>Карточка 02 Санкт-Петербург для редактирования</summary>
        Card02SpbEditView,
        ///<summary>Карточка 02 'Интеграция' для редактирования</summary>
        Card02IntegrationView,
        ///<summary>Карточка 03 как у Диспетчера 03</summary>
        Card03DispatcherView,
        ///<summary>Карточка 03 Санкт-Петербург для просмотра</summary>
        Card03SpbView,
        ///<summary>Карточка 03 Санкт-Петербург для редактирования</summary>
        Card03SpbEditView,
        ///<summary>Карточка 03 только добавление пострадавших</summary>
        Card03AddVictimsView,
        ///<summary>Карточка 04 как у ДДС 04</summary>
        Card04View,
        ///<summary>Карточка 04 Санкт-Петербург для просмотра</summary>
        Card04SpbView,
        ///<summary>Карточка 04 Санкт-Петербург для редактирования</summary>
        Card04SpbEditView,
        ///<summary>Карточка ЖКХ/ЕДДС как у ДДС ЖКХ/ЕДДС</summary>
        CardCommServView,
        ///<summary>Карточка ЖКХ/ЕДДС Санкт-Петербург для просмотра</summary>
        CardCommServSpbView,
        ///<summary>Карточка ЖКХ/ЕДДС Санкт-Петербург для редактирования</summary>
        CardCommServSpbEditView,
        ///<summary>Карточка АТ как у ДДС АТ</summary>
        CardATView,
        ///<summary>Карточка АТ Санкт-Петербург для просмотра</summary>
        CardATSpbView,
        ///<summary>Карточка АТ Санкт-Петербург для редактирования</summary>
        CardATSpbEditView,
    }
    public record EmergencyServersCollectionModel
    {
        public List<EmergencyServerInfoModel>? EmergencyServers { get; set; }
    }
    public record EmergencyServerInfoModel
    {
        public string? Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsFirstPriority { get; set; }
        public bool IsAvailable { get; set; }
    }
    public record WeatherModel
    {
        public short Temperature { get; set; }
        public short Pressure { get; set; }
        public byte Clouds { get; set; }
        public byte WindDirection { get; set; }
        public short WindStrength { get; set; }
        public short Humidity { get; set; }
    }
    public record WeatherLayerModel
    {
        public long Id { get; set; }
        public string? Description { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public WeatherModel? Weather { get; set; }
    }
    public record AddressbookSettingModel
    {
        /// <summary> IP базы адресной книги </summary>
        public string? DbIp { get; set; }
        /// <summary> Порт базы адресной книги </summary>
        public int DbPort { get; set; }
        /// <summary> Имя базы адресной книги </summary>
        public string? DbName { get; set; }
        /// <summary> Пользователь </summary>
        public string? User { get; set; }
        /// <summary> Пароль </summary>
        public string? Password { get; set; }
    }
    public record AddressbookSettingsItemModel
    {
        /// <summary> Список настроек адресной книги </summary>
        public List<AddressbookSettingModel>? AddressbookSettings { get; set; }
    }
    public record VisualAttributesModel
    {
        /// <summary> Текстовое название стандартного цвета </summary>
        public string? BackgroundColor { get; set; }
    }
    public record CardConditionModel
    {
        /// <summary> Признак Комплексное реагирование </summary>
        public bool? IsComplex { get; set; }
        /// <summary> Признак Важная </summary>
        public bool? IsPriority { get; set; }
        /// <summary> Признак Угроза ЧС </summary>
        public bool? IsIncident { get; set; }
        /// <summary> Признак Учебная </summary>
        public bool? IsTest { get; set; }
        /// <summary> Признак Контроль </summary>
        public bool? IsControl { get; set; }
    }
    public record CardHighlightItemModel
    {
        /// <summary> Визуальное состояние карточки, которое будет применено при совпадении CardCondition </summary>
        public VisualAttributesModel VisualAttributes { get; set; }
        /// <summary> Состояние карточки, при котором будут применены VisualAttributes </summary>
        public CardConditionModel CardCondition { get; set; }
    }
    public record CustomServiceModel
    {
        /// <summary> Идентификатор имени кастомной службы </summary>
        public int? NameId { get; set; }
        /// <summary> Идентификатор службы </summary>
        public int ServiceTypeId { get; set; }
        /// <summary> Идентификатор состояния кастомной службы </summary>
        public int? StateId { get; set; }
        /// <summary> Дата привлечения кастомной службы </summary>
        public DateTime? DateInvolve { get; set; }
        /// <summary> Данные карточки кастомной службы </summary>
        public CustomServiceDataModel Data { get; set; }
    }
    public record CustomServiceDataModel
    {
        /// <summary> Вид выезда </summary>
        public int? IncidentTypeId { get; set; }
        /// <summary> Комментарий </summary>
        public string? AdditionalInfo { get; set; }
        /// <summary> Принятые меры </summary>
        public string? PerformActions { get; set; }
        /// <summary> Выезд на место </summary>
        public DateTime? ServiceCardWork { get; set; }
        /// <summary> Прибытие на место </summary>
        public DateTime? ServiceCardWorkNext { get; set; }
        /// <summary> Время закрытия сервисной карточки </summary>
        public DateTime? ServiceCardComplete { get; set; }
        /// <summary> Время просмотра карточки </summary>
        public DateTime? ServiceCardView { get; set; }
        /// <summary> Коллекция задействованных бригад </summary>
        public List<int>? DepartmentIds { get; set; }
    }
    public record CardCustomServiceModel
    {
        /// <summary> Идентификатор службы </summary>
        public int ServiceTypeId { get; set; }
        /// <summary> Доп. информация </summary>
        public MetaFieldsModel? MetaFields { get; set; }
        /// <summary> Список кастомных полей службы </summary>
        public CustomFieldsModel? CustomFields { get; set; }
    }
    public record MetaFieldsModel
    {
        /// <summary> Идентификатор состояния кастомной службы </summary>
        public int? StateId { get; set; }
        /// <summary> Дата привлечения кастомной службы </summary>
        public DateTime? DateInvolve { get; set; }
    }
    public record CustomFieldsModel
    {
        /// <summary> Список логических полей </summary>
        public List<BoolFieldModel>? BoolFields { get; set; }
        /// <summary> Список целочисленных полей </summary>
        public List<IntFieldModel>? IntFields { get; set; }
        /// <summary> Список строковых полей </summary>
        public List<StringFieldModel>? StringFields { get; set; }
        /// <summary> Список полей с выпадающим списком </summary>
        public List<ComboFieldModel>? ComboFields { get; set; }
        /// <summary> Список полей с датой/временем </summary>
        public List<DateTimeFieldModel>? DateTimeFields { get; set; }
        /// <summary> Список таблиц </summary>
        public List<TableModel>? Tables { get; set; }
    }
    public record BoolFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int TemplateId { get; set; }
        /// <summary> Значение </summary>
        public bool? Value { get; set; }
    }
    public record IntFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int TemplateId { get; set; }
        /// <summary> Значение </summary>
        public int? Value { get; set; }
    }
    public record StringFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int TemplateId { get; set; }
        /// <summary> Значение </summary>
        public string? Value { get; set; }
    }
    public record ComboFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int TemplateId { get; set; }
        /// <summary> Значение </summary>
        public int? Value { get; set; }
    }
    public record DateTimeFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int TemplateId { get; set; }
        /// <summary> Значение </summary>
        public DateTime? Value { get; set; }
    }
    public record TableModel
    {
        /// <summary> Идентификатор шаблона таблицы </summary>
        public int TemplateId { get; set; }
        /// <summary> Список столбцов с логическим значением </summary>
        public List<BoolColumnModel>? BoolColumns { get; set; }
        /// <summary> Список столбцов с целочисленным значением </summary>
        public List<IntColumnModel>? IntColumns { get; set; }
        /// <summary> Список столбцов со строковым значением </summary>
        public List<StringColumnModel>? StringColumns { get; set; }
        /// <summary> Список столбцов с датой/временем </summary>
        public List<DateTimeColumnModel>? DateTimeColumns { get; set; }
        /// <summary> Список столбцов с выпадающим списком </summary>
        public List<ComboColumnModel>? ComboColumns { get; set; }
    }
    public record BoolColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int TemplateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<BoolCellModel>? Values { get; set; }
    }
    public record BoolCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int Id { get; set; }
        /// <summary> Значение </summary>
        public bool? Value { get; set; }
    }
    public record StringColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int TemplateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<StringCellModel>? Values { get; set; }
    }
    public record StringCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int Id { get; set; }
        /// <summary> Значение </summary>
        public string? Value { get; set; }
    }
    public record IntColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int TemplateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<IntCellModel>? Values { get; set; }
    }
    public record IntCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int Id { get; set; }
        /// <summary> Значение </summary>
        public int? Value { get; set; }
    }
    public record DateTimeColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int TemplateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<DateTimeCellModel>? Values { get; set; }
    }
    public record DateTimeCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int Id { get; set; }
        /// <summary> Значение </summary>
        public DateTime? Value { get; set; }
    }
    public record ComboColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int TemplateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<ComboCellModel>? Values { get; set; }
    }
    public record ComboCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int Id { get; set; }
        /// <summary> Значение </summary>
        public int? Value { get; set; }
    }
    public record ServiceEventModel
    {
        public int ServiceTypeId { get; set; }
        public bool Opened { get; set; }
    }
    public record MetaDataModel
    {
        public ReplicationMetaDataModel? Replication { get; set; }
        /// <summary> Список событий службы </summary>
        public List<ServiceEventModel>? ServiceEvents { get; set; }
    }
    public record ReplicationTargetInfoModel
    {
        public int ReplicationTargetId { get; set; }
        public string? ReplicationTargetName { get; set; }
        public bool IsDelivered { get; set; }
    }
    public record ReplicationMetaDataModel
    {
        public bool IsDelivered { get; set; }
        /// <summary> Список информации о доставке по каждому направлению. </summary>
        public List<ReplicationTargetInfoModel>? TargetsInfo { get; set; }
    }
    public record RegionAdditionalInfoModelFromGenerated
    {
        public int Id { get; set; }
        public bool? Autocomplete { get; set; }
    }
    public record PhoneBookDictionaryModel
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int CommTypeId { get; set; }
        public int CommPhoneId { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? Deleted { get; set; }
    }
    public record RegionDataModel
    {
        public string? RegistrationDepartment { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? DepartmentTransfer { get; set; }
        public string? DenialOfServiceReason { get; set; }
    }
    public record MNISReactionModel
    {
        public List<MNISReactionItemModel>? Reaction { get; set; }
    }
    public record MNISReactionItemModel
    {
        public List<MNISEventModel>? Events { get; set; }
    }
    public record MNISEventModel
    {
        public string? Resource { get; set; }
        public MNISEventTypeModel? EventType { get; set; }
        public DateTime? EventTime { get; set; }
        public string? EventName { get; set; }
    }
    public enum MNISEventTypeModel
    {
        Other,
        Accepted,
        Departure,
        OnTheWay,
        WayIncedent,
        TrafficDelay,
        Reject,
        Redirect,
        Arrived,
        Deployment,
        Performance,
        Completed,
        Undeployment,
        Retuning,
        Comeback,
        ArrivalToBase,
        Closed,
    }
    public record Vehicle03InfoModel
    {
        public string? VehicleId { get; set; }
        public DateTime? Involve { get; set; }
    }
    public record Vehicle01InfoModel
    {
        public string? VehicleId { get; set; }
        public DateTime? LatestEventTime { get; set; }
        public MNISEventTypeModel? LatestEventType { get; set; }
    }
    public enum VehicleInfoSourceNameModel
    {
        MNIS,
        RNIS,
    }
    public record VehicleArrivalModel
    {
        public string? ExternalVehicleId { get; set; }
        public GeoPointModelFromGenerated? CurrentLocation { get; set; }
        public int? EstimatedTravelTimeMinutes { get; set; }
        public DateTime? EstimatedArrivalTime { get; set; }
        public string? StateRegNumber { get; set; }
    }
    public record ArrivalInfoModel
    {
        public GeoPointModelFromGenerated? Destination { get; set; }
        public List<VehicleArrivalModel>? VehiclesArrival { get; set; }
    }
    public record VehicleTrackInfoModel
    {
        public GeoPointModelFromGenerated? Coords { get; set; }
        public string? StateRegNumber { get; set; }
    }
    public enum MapTypeModel
    {
        /// <summary> Protei GEO server </summary>
        Protei,
        /// <summary> IAC GIS </summary>
        IAC,
        /// <summary> ArcGIS rest API </summary>
        ArcGIS,
        /// <summary> External map view with PPPUR integration by chrome webdriver </summary>
        ChromeBrowserPppur,
    }
    public enum CallCenterProviderTypeModel
    {
        NotSet,
        Protei,
        Avaya7,
        ProteiEACD3,
        EmergencyServer,
        GridBookServer,
        ProteiEACDWPServer,
    }
    public record ConnectionInfoModel
    {
        public string? ActionUrl { get; set; }
        public string? NotificationUrl { get; set; }
        public string? NotificationWebSocketUrl { get; set; }
        public string? ReportUrl { get; set; }
        public int Priority { get; set; }
        public int Attempts { get; set; }
    }
    public record MRSSettingsModel
    {
        public string? Mrs { get; set; }
        public string? RemotePath { get; set; }
        public string? FtpUser { get; set; }
        public string? FtpPassword { get; set; }
        public string? CallIdFilter { get; set; }
        public int? GetFileListTimeout { get; set; }
    }
    public record MapsSettingsModel
    {
        public int? VideoPortalUserID { get; set; }
        public string? CityName { get; set; }
        public MapTypeModel MapManufacturer { get; set; }
    }
    public record MapTileUrlModelFromGenerated
    {
        public string? Url { get; set; }
        public MapTypeModel? MapManufacturer { get; set; }
        public string? HomeCity { get; set; }
    }
    public record CallCenterSettingsModel
    {
        public CallCenterProviderTypeModel CallCenterProvider { get; set; }
        public string? Url { get; set; }
        public int? RunProcessWaitTimeout { get; set; }
        public int? PollingInterval { get; set; }
    }
    public record CallCenterParameterModel
    {
        /// <summary> Проигрывать звук в динамики/колонки </summary>
        public bool? PlaySpeakers { get; set; }
        /// <summary> Проигрывать звук в наушники/гарнитуру </summary>
        public bool? PlayHeadPhones { get; set; }
        /// <summary> Возможность работы в 'Аварийном режиме' </summary>
        public bool? EmergencyModeEnable { get; set; }
        /// <summary> Длительность ожидания (секунды), до переключения из 'Режима работы без РМО' в 'Аварийный режим' </summary>
        public int? WaitSecondsBeforeEmergencyMode { get; set; }
    }
    public record SettingsModel
    {
        public MapsSettingsModel? MapsSettings { get; set; }
        public CallCenterSettingsModel? CallCenterSettings { get; set; }
        public string? AcdTerminalWindowStyleRunMode { get; set; }
        public User03RoleModel? User03Role { get; set; }
        public int? ActualDepartmentID { get; set; }
        public bool IsCallCenterUsed { get; set; }
        public bool NoCardCreationSiren { get; set; }
        public bool IsCard112ReadOnly { get; set; }
        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public bool? BlockFilterCityAndDistrict { get; set; }
        public bool IsReadOnlyMode { get; set; }
        public bool IsMap { get; set; }
        public bool CityReadOnly { get; set; }
        public bool ShowNonTransferedCardsForDispatcher03 { get; set; }
        public string? Installation { get; set; }
        public bool? ShowConsultMenu { get; set; }
        public RoleSettingsModel? RoleSettings { get; set; }
        public int? SourceZoneId { get; set; }
        public string? SirenName { get; set; }
        public List<ConnectionInfoModel>? ConnectionInfos { get; set; }
        public List<int>? ForcesAvailableDepartments { get; set; }
        public List<int>? AdditionalCities { get; set; }
    }
    public record CallDataModel
    {
        public long CallId { get; set; }
        public string? ExtCallId { get; set; }
        public string? ExtCallId2 { get; set; }
        public string? CdPN { get; set; }
        public string? CgPN { get; set; }
        public int Category { get; set; }
        public string? GatewayIPAddr { get; set; }
        public string? ESGlobalID { get; set; }
        public ExternalInfoTypeModel ExternalInfoType { get; set; }
        public int? CcRegionID { get; set; }
        public string? VisitedNetworkId { get; set; }
        public SMSDataModel? SmsData { get; set; }
        public string? ResultInfo { get; set; }
        public int? CallDuration { get; set; }
        public DirectionModel? CallDirection { get; set; }
        public int? DistributeDuration { get; set; }
        public List<string>? ExternalInfo { get; set; }
    }
    public record SMSDataModel
    {
        /// <summary> Текст сообщения </summary>
        public string? MessageText { get; set; }
        /// <summary> Тип СМС (входящее, исходящее) </summary>
        public SMSTypeModel? SmsType { get; set; }
        /// <summary> Статус СМС (отправлено, получено) </summary>
        public SMSStatusModel? SmsStatus { get; set; }
        /// <summary> SMPP Id </summary>
        public string? SMPPId { get; set; }
        /// <summary> Идентификатор СМС для Авая </summary>
        public int? SmsId { get; set; }
    }
    public record IncidentTypeRecordModel
    {
        public int IncidentTypeId { get; set; }
        public int? CallTypeId { get; set; }
        public int? RegionId { get; set; }
        public bool Deleted { get; set; }
        public List<int>? ServiceTypeIds { get; set; }
    }
    public record ServiceIncidentTypeRecordModel
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public int? IncidentTypeId { get; set; }
        public string? AdditionalInfo { get; set; }
        public bool Deleted { get; set; }
        public List<int>? AuxIncidentIds { get; set; }
    }
    public record ServiceDeadlinesModel
    {
        public int ServiceTypeId { get; set; }
        public int? ServiceCreateTimeout { get; set; }
    }
    public record ReplicationTargetModel
    {
        public int ReplicationTargetId { get; set; }
        public string? ReplicationServiceName { get; set; }
        public int? ReplicationTargetServiceTypeId { get; set; }
    }
    public record Card112ListModel
    {
        public int Total { get; set; }
        public List<Card112Model>? CardList { get; set; }
    }
    public record ISharerDescriptionModel
    {
        /// <summary> На вид </summary>
        public string? InLooksAge { get; set; }
        /// <summary> Рост </summary>
        public int? StatureID { get; set; }
        /// <summary> Телосложение </summary>
        public int? FigureID { get; set; }
        /// <summary> Рост </summary>
        public string? Stature { get; set; }
        /// <summary> Телосложение </summary>
        public string? Figure { get; set; }
        /// <summary> Одет </summary>
        public string? Exterior { get; set; }
        /// <summary> Особые приметы </summary>
        public string? Extra { get; set; }
        /// <summary> Пол </summary>
        public int? Gender { get; set; }
        /// <summary> Фамилия </summary>
        public string? LastName { get; set; }
        /// <summary> Имя </summary>
        public string? FirstName { get; set; }
        /// <summary> Отчество </summary>
        public string? MiddleName { get; set; }
        /// <summary> Дата рождения </summary>
        public DateTime? Birthday { get; set; }
    }
    public record IVehicleDescriptionModel
    {
        /// <summary> Производитель </summary>
        public string? Vendor { get; set; }
        /// <summary> Модель </summary>
        public string? Name { get; set; }
        /// <summary> Цвет </summary>
        public string? Color { get; set; }
        /// <summary> Тип ТС из классификатора </summary>
        public string? Type { get; set; }
        /// <summary> Цвет ТС из классификатора </summary>
        public int? ColorID { get; set; }
        /// <summary> Тип ТС из классификатора </summary>
        public int? TypeID { get; set; }
        /// <summary> Особые приметы </summary>
        public string? Extra { get; set; }
        /// <summary> Номер </summary>
        public string? RegistrationNumber { get; set; }
        /// <summary> Регион </summary>
        public string? Region { get; set; }
        /// <summary> Скрылось с места происшествия </summary>
        public bool Hided { get; set; }
    }
    public record IVictimDescriptionModel
    {
        /// <summary> Фамилия </summary>
        public string? LastName { get; set; }
        /// <summary> Отчество </summary>
        public string? MiddleName { get; set; }
        /// <summary> Имя </summary>
        public string? FirstName { get; set; }
        /// <summary> Телефон </summary>
        public string? ContactPhone { get; set; }
        /// <summary> Доп. инфо </summary>
        public string? AdditionalInfo { get; set; }
        /// <summary> Id района </summary>
        public int? CityId { get; set; }
        /// <summary> Id улицы </summary>
        public int? StreetId { get; set; }
        /// <summary> Телосложение </summary>
        public string? BuildingNumber { get; set; }
        /// <summary> Корпус </summary>
        public string? Corps { get; set; }
        /// <summary> Квартира </summary>
        public string? Flat { get; set; }
    }
    public record TaskForceItemModel
    {
        public int OvdServiceId { get; set; }
        public string? LastName { get; set; }
    }
    public record Card02FilterModel
    {
        /// <summary> КУСП ОВД </summary>
        public string? InstrinsicOvd { get; set; }
        /// <summary> КУСП ДПС </summary>
        public string? InstrinsicDps { get; set; }
        /// <summary> Фильтровать ли карточки с неуказанной улицей </summary>
        public bool? IsFilterEmptyStreet { get; set; }
        /// <summary> Id улицы </summary>
        public int? StreetId { get; set; }
        /// <summary> Квалификация ОВД </summary>
        public int? ITypeId { get; set; }
        /// <summary> Id карточки </summary>
        public int? CardId { get; set; }
        /// <summary> Фамилия заявителя </summary>
        public string? DeclarantLastName { get; set; }
    }
    public record DictionaryItemModel
    {
        public int Id { get; set; }
        public string? Value { get; set; }
        public string? ExtId { get; set; }
        public bool Deleted { get; set; }
        public string? Description { get; set; }
    }
    public record DCRecordModel
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public bool Deleted { get; set; }
    }
    public record SDCRecordModel
    {
        public int StreetId { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public bool Deleted { get; set; }
    }
    public record CardStateDescStructModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Nextid { get; set; }
        public int? Previd { get; set; }
        public int? StandardMinutes { get; set; }
    }
    public record CardSyntheticStateModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ColorR { get; set; }
        public int ColorG { get; set; }
        public int ColorB { get; set; }
    }
    public record SubCallTypeItemModel
    {
        public int Id { get; set; }
        public int CallTypeId { get; set; }
        public int CityId { get; set; }
        public string? GroupNumber { get; set; }
        public string? Description { get; set; }
    }
    public record FieldConstraintModel
    {
        public string? Name { get; set; }
        public int Size { get; set; }
    }
    public record ObjectStructModel
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public int? StreetID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public string? Building { get; set; }
        public string? Corps { get; set; }
        public bool Gasified { get; set; }
        public int BaseClassID { get; set; }
        public int DepartmentID { get; set; }
        public int? TypeID { get; set; }
        public bool Deleted { get; set; }
        public List<int>? FireReactionPlanIDs { get; set; }
    }
    public record FireObjectRangeStructModel
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public int? StreetID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public int DepartmentID { get; set; }
        public int? BuildingFrom { get; set; }
        public int? BuildingTo { get; set; }
        public int? Odd { get; set; }
        public List<int>? FireReactionPlanIDs { get; set; }
    }
    public record FireReactionPlanItemStructModel
    {
        public int? ID { get; set; }
        public int FireRectionPlanID { get; set; }
        public int FireEngineTypeID { get; set; }
        public string? FireEngineType { get; set; }
        public int FireDepartmentID { get; set; }
        public int Count { get; set; }
        public int Order { get; set; }
        public int FireClassID { get; set; }
    }
    public record FireReactionPlanStructModel
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public int DepartmentID { get; set; }
        public List<FireReactionPlanItemStructModel>? Items { get; set; }
    }
    public record MalefactionStructModel
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public int Code { get; set; }
    }
    public record MalefactionGroupStructModel
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public int Code { get; set; }
        public List<MalefactionStructModel>? Items { get; set; }
    }
    public record Tm_SnapshotDataModel
    {
        public int Id { get; set; }
        public string? Modifier { get; set; }
        public DateTime Modified { get; set; }
        public int CardId { get; set; }
        public int CardTypeId { get; set; }
        public int Version { get; set; }
        public string? Modifications { get; set; }
    }
    public record CustomServiceCardTemplateModel
    {
        /// <summary> Идентификатор шаблона внешнего вида карточки </summary>
        public int Id { get; set; }
        /// <summary> Список полей </summary>
        public List<FieldInfoModel>? Fields { get; set; }
    }
    public record ServiceTypeIdToCustomServiceCardTemplateModel
    {
        /// <summary> Идентификатор службы </summary>
        public int ServiceTypeId { get; set; }
        /// <summary> Идентификатор шаблона поля </summary>
        public int TemplateId { get; set; }
    }
    public record FieldInfoModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int TemplateId { get; set; }
        /// <summary> Тип шаблона </summary>
        public TemplateTypeModel TemplateType { get; set; }
        /// <summary> Порядок поля </summary>
        public int Order { get; set; }
    }
    public record ControlTemplateModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int Id { get; set; }
        /// <summary> Название поля </summary>
        public string? Name { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? IsDeleted { get; set; }
    }
    public record ComboControlTemplateModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int Id { get; set; }
        /// <summary> Название поля </summary>
        public string? Name { get; set; }
        /// <summary> Id источника данных </summary>
        public int DataSetId { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? IsDeleted { get; set; }
    }
    public record DateTimeControlTemplateModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int Id { get; set; }
        /// <summary> Название поля </summary>
        public string? Name { get; set; }
        /// <summary> Формат поля </summary>
        public DateTimeFormat Format { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? IsDeleted { get; set; }
    }
    public record TableControlTemplateModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int Id { get; set; }
        /// <summary> Название таблицы </summary>
        public string? Name { get; set; }
        /// <summary> Id списка столбцов </summary>
        public int ColumnsSetId { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? IsDeleted { get; set; }
    }
    public record ColumnsSetModel
    {
        /// <summary> Идентификатор набора столбцов </summary>
        public int Id { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? IsDeleted { get; set; }
        /// <summary> Список столбцов </summary>
        public List<ColumnInfoModel>? Columns { get; set; }
    }
    public record ColumnInfoModel
    {
        /// <summary> Идентификатор шаблона столбца </summary>
        public int TemplateId { get; set; }
        /// <summary> Тип шаблона </summary>
        public TemplateTypeModel TemplateType { get; set; }
        /// <summary> Порядок столбца </summary>
        public int Order { get; set; }
    }
    public record DataSetModel
    {
        /// <summary> Идентификатор набора данных </summary>
        public int Id { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? IsDeleted { get; set; }
        /// <summary> Набор значений </summary>
        public List<DataSetItemModel>? Items { get; set; }
    }
    public record DataSetItemModel
    {
        /// <summary> Идентификатор значения в наборе данных </summary>
        public int Id { get; set; }
        /// <summary> Значение </summary>
        public string? Value { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? IsDeleted { get; set; }
    }
    public enum TemplateTypeModel
    {
        Bool,
        Int,
        String,
        DateTime,
        Combo,
        Table,
    }
    public enum DateTimeFormatModel
    {
        Date,
        DateTime,
    }
    public record BasicDictionariesModel
    {
        public List<DictionaryItemModel>? CallTypeDictionary { get; set; }
        public List<DictionaryItemModel>? ServiceTypeDictionary { get; set; }
        public List<SubCallTypeItemModel>? SubCallTypeDictionary { get; set; }
        public List<DictionaryItemModel>? CallTypeNumberDictionary { get; set; }
        public List<DictionaryItemModel>? AdditionalCallTypeDictionary { get; set; }
        public List<DictionaryItemModel>? DeclarantStatusDictionary { get; set; }
        public List<DictionaryItemModel>? CCMC_TypeDictionary { get; set; }
        public List<DictionaryItemModel>? ObjectTypeDictionary { get; set; }
        public List<DictionaryItemModel>? FireClassDictionary { get; set; }
        public List<DictionaryItemModel>? FireReasonDictionary { get; set; }
        public List<DictionaryItemModel>? FireIncidentTypeDictionary { get; set; }
        public List<DictionaryItemModel>? Departments01Dictionary { get; set; }
        public List<DictionaryItemModel>? FireReactionPlanDictionary { get; set; }
        public List<CardStateDescStructModel>? Card01StateDescStructs { get; set; }
        public List<FireObjectRangeStructModel>? FireObjectRangeStructs { get; set; }
        public List<FireReactionPlanStructModel>? FireReactionPlanStructs { get; set; }
        public List<DictionaryItemModel>? FireBarrelTypes { get; set; }
        public List<DictionaryItemModel>? FireExtinguisherTypes { get; set; }
        public List<DictionaryItemModel>? WaterSources { get; set; }
        public List<DictionaryItemModel>? FirePreventionTypes { get; set; }
        public List<DictionaryItemModel>? FireRoles { get; set; }
        public List<DictionaryItemModel>? FireIncidentGroupDictionary { get; set; }
        public List<DictionaryItemModel>? Departments02Dictionary { get; set; }
        public List<DictionaryItemModel>? OVDServiceDictionary { get; set; }
        public List<DictionaryItemModel>? ITypeDictionary { get; set; }
        public List<DictionaryItemModel>? ITypeDetailedDictionary { get; set; }
        public List<DictionaryItemModel>? StatureDictionary { get; set; }
        public List<DictionaryItemModel>? FigureDictionary { get; set; }
        public List<DictionaryItemModel>? StatusDictionary { get; set; }
        public List<CardStateDescStructModel>? Card02StateDescStructs { get; set; }
        public List<MalefactionGroupStructModel>? MalefactionGroupStructs { get; set; }
        public List<DictionaryItemModel>? OvdPastEvents { get; set; }
        public List<DictionaryItemModel>? OvdDepartureResults { get; set; }
        public List<DictionaryItemModel>? Departments03Dictionary { get; set; }
        public List<DictionaryItemModel>? ReasonDictionary { get; set; }
        public List<CardStateDescStructModel>? Card03StateDescStructs { get; set; }
        public List<DictionaryItemModel>? DiagnosisDictionary { get; set; }
        public List<HospitalModel>? Hospitals { get; set; }
        public List<DictionaryItemModel>? TransportationTypesDictionary { get; set; }
        public List<DictionaryItemModel>? Card03TransportReasonDictionary { get; set; }
        public List<DictionaryItemModel>? GasServicesDictionary { get; set; }
        public List<DictionaryItemModel>? GasServiceSituationsDictionary { get; set; }
        public List<DictionaryItemModel>? GasSituationInstructions { get; set; }
        public List<DictionaryItemModel>? DepartmentsCommServDictionary { get; set; }
        public List<CardStateDescStructModel>? CardCommServStateDescStructs { get; set; }
        public List<DictionaryItemModel>? IncidentCommServCategoryDictionary { get; set; }
        public List<DictionaryItemModel>? CardCommServUKDictionary { get; set; }
        public List<DictionaryItemModel>? IncidentCommServObjectTypeDictionary { get; set; }
        public List<IntMapItemModel>? IncidentCommServType2ObjectTypeMap { get; set; }
        public List<DictionaryItemModel>? CityDictionary { get; set; }
        public List<DictionaryItemModel>? DistrictDictionary { get; set; }
        public List<DictionaryItemModel>? StreetDictionary { get; set; }
        public List<DictionaryItemModel>? RegionDictionary { get; set; }
        public List<DictionaryItemModel>? LocalDistrictDictionary { get; set; }
        public List<RegionAdditionalInfoModelFromGenerated>? RegionsAdditionalInfo { get; set; }
        public List<DictionaryItemModel>? IncidentTypeDictionary { get; set; }
        public List<IncidentTypeRecordModel>? IncidentTypeRecords { get; set; }
        public List<ServiceIncidentTypeRecordModel>? Incident01TypeRecords { get; set; }
        public List<ServiceIncidentTypeRecordModel>? Incident02TypeRecords { get; set; }
        public List<ServiceIncidentTypeRecordModel>? Incident03TypeRecords { get; set; }
        public List<ServiceIncidentTypeRecordModel>? Incident04TypeRecords { get; set; }
        public List<ServiceIncidentTypeRecordModel>? IncidentATTypeRecords { get; set; }
        public List<ServiceIncidentTypeRecordModel>? IncidentCommServTypeRecords { get; set; }
        public List<ObjectStructModel>? ObjectStructs { get; set; }
        public List<DCRecordModel>? DCRecords { get; set; }
        public List<SDCRecordModel>? SDCRecords { get; set; }
        public List<CardSyntheticStateModel>? CardSyntheticStateDictionary { get; set; }
        public List<DictionaryItemModel>? LanguageDictionary { get; set; }
        public List<DictionaryItemModel>? SourceTypeDictionary { get; set; }
        public List<DictionaryItemModel>? VehicleTypeDictionary { get; set; }
        public List<DictionaryItemModel>? Card03WhoCalledDictionary { get; set; }
        public List<DictionaryItemModel>? ExternalCreatorsDictionary { get; set; }
        public List<ServiceDeadlinesModel>? ServiceDeadlinesDictionary { get; set; }
        public List<FieldConstraintModel>? Card02Constraints { get; set; }
        public List<FieldConstraintModel>? Card03Constraints { get; set; }
        public List<FieldConstraintModel>? CardOVDConstraints { get; set; }
        public List<FieldConstraintModel>? Card04Constraints { get; set; }
        public List<FieldConstraintModel>? CardATConstraints { get; set; }
        public List<FieldConstraintModel>? CardCommServConstraints { get; set; }
        public List<FieldConstraintModel>? FireFighterCardConstraints { get; set; }
        public List<FieldConstraintModel>? ISharerDescriptionConstraints { get; set; }
        public List<FieldConstraintModel>? IVehicleDescriptionConstraints { get; set; }
        public List<FieldConstraintModel>? IVictimDescriptionConstraints { get; set; }
        public List<FieldConstraintModel>? Card112Constraints { get; set; }
        public List<FieldConstraintModel>? CallHistoryConstraints { get; set; }
        public List<DictionaryItemModel>? CustomServiceIncidentType { get; set; }
        public List<DictionaryItemModel>? CustomServiceDepartment { get; set; }
        public List<DictionaryItemModel>? ServiceType2CustomServiceTypeDictionary { get; set; }
        public List<ControlTemplateModel>? BoolControlTemplates { get; set; }
        public List<ControlTemplateModel>? IntControlTemplates { get; set; }
        public List<ControlTemplateModel>? StringControlTemplates { get; set; }
        public List<DateTimeControlTemplateModel>? DateTimeControlTemplates { get; set; }
        public List<ComboControlTemplateModel>? ComboControlTemplates { get; set; }
        public List<TableControlTemplateModel>? TableControlTemplates { get; set; }
        public List<CustomServiceCardTemplateModel>? CustomServiceCardTemplates { get; set; }
        public List<DataSetModel>? DataSets { get; set; }
        public List<ServiceTypeIdToCustomServiceCardTemplateModel>? ServiceTypeIdToCustomServiceCardTemplateDictionary { get; set; }
        public List<ColumnsSetModel>? ColumnsSets { get; set; }
        public List<DictionaryItemModel>? CommunicationTypeDictionary { get; set; }
        public List<DictionaryItemModel>? CommunicationPhonesDictionary { get; set; }
        public List<PhoneBookDictionaryModel>? PhoneBookDictionary { get; set; }
        public List<DictionaryItemModel>? PerformActionsTypeDictionary { get; set; }
    }
    public record CardMessageModelFromGenerated
    {
        public int? ServiceTypeId { get; set; }
        public int ID { get; set; }
        public string? Creator { get; set; }
        public int EmergencyCardID { get; set; }
        public int? DepartmentID { get; set; }
        public string? Message { get; set; }
        public bool IsServiceMessage { get; set; }
        public DateTime Create { get; set; }
    }
    public record DepartmentModelFromGenerated
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public GeographicLocationModel? GeographicLocation { get; set; }
        public int DistrictID { get; set; }
        public List<EngineModel>? Engines { get; set; }
    }
    public record EngineModel
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public string? Number { get; set; }
        public int? StateID { get; set; }
        public int? ShiftReportStateID { get; set; }
        public int? EmergencyCardID { get; set; }
        public int? EmergencyCardImportnaceLevelID { get; set; }
        public Engine03AdditionalInfoModel? Engine03AdditionalInfo { get; set; }
    }
    public record Engine03AdditionalInfoModel
    {
        public int ProfileID { get; set; }
        /// <summary> Врач </summary>
        public int? PrimarySpecialistID { get; set; }
        /// <summary> Фельдшер </summary>
        public int? SecondarySpecialistID { get; set; }
        /// <summary> Санитар </summary>
        public int? OrderlyID { get; set; }
        /// <summary> Начало смены </summary>
        public DateTime ShiftBegin { get; set; }
        /// <summary> Конец смены </summary>
        public DateTime ShiftEnd { get; set; }
        public DateTime ShiftBeginReal { get; set; }
        public DateTime WorkBegin { get; set; }
        public DateTime LastAction { get; set; }
        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public int? StreetID { get; set; }
        public string? Building { get; set; }
        public string? Corps { get; set; }
        public string? Room { get; set; }
        public DateTime EmergencyCardCreate { get; set; }
        public int? CallCount { get; set; }
    }
    public record DepartmentStatePairModel
    {
        public int DepartmentID { get; set; }
        public int StateID { get; set; }
    }
    public record CardDepartmentStateModel
    {
        public int Id { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Action { get; set; }
        public int DepartmentID { get; set; }
        public int CardStateDescID { get; set; }
        public int? ServiceTypeId { get; set; }
        public string? Message { get; set; }
    }
    public record DepartmentStateHistoryModel
    {
        public int ActiveState { get; set; }
        public List<CardDepartmentStateModel>? StateHistory { get; set; }
    }
    public record DepartmentInvolvedFilterModel
    {
        public int? WantsServiceTypeId { get; set; }
    }
    public record DepartmentStateChangedFilterModel
    {
        public int? WantsServiceTypeId { get; set; }
    }
    public record RequestedEnginesListChangedFilterModel
    {
        public int? WantsServiceTypeId { get; set; }
        public int WantsEmergencyCardID { get; set; }
    }
    public record CardCurrentStatesInDepartmentsChangedFilterModel
    {
        public int? WantsServiceTypeId { get; set; }
        public int WantsEmergencyCardID { get; set; }
    }
    public record CardMessageListChangedFilterModel
    {
        public int? WantsServiceTypeId { get; set; }
        public int WantsEmergencyCardID { get; set; }
    }
    public record BroadcastMessageFilterModel
    {
        public int? WantsServiceTypeId { get; set; }
        public List<int>? WantsDepartmentIDs { get; set; }
    }
    public record ShiftReportChangedFilterModel
    {
        public int? WantsServiceTypeId { get; set; }
    }
    public record CardAdditionalInfoAddedFilterModel
    {
        public int CardId { get; set; }
    }
    public enum CardEventTypeModel
    {
        CardCreated,
        CardChanged,
    }
    public record NotificationFiltersModel
    {
        public bool WantsCard01Changed { get; set; }
        public bool WantsCard02Changed { get; set; }
        public bool WantsCard03Changed { get; set; }
        public bool WantsCard04Changed { get; set; }
        public bool WantsCardATChanged { get; set; }
        public bool WantsCardCommServChanged { get; set; }
        public bool WantsCard112Changed { get; set; }
        public bool WantsCard01Created { get; set; }
        public bool WantsCard02Created { get; set; }
        public bool WantsCard03Created { get; set; }
        public bool WantsCard04Created { get; set; }
        public bool WantsCardATCreated { get; set; }
        public bool WantsCardCommServCreated { get; set; }
        public bool WantsCard112Created { get; set; }
        public bool? WantsGlonassCardChanged { get; set; }
        public bool? WantsClientRegistered { get; set; }
        public bool? WantsUpdateRequested { get; set; }
        public bool? WantsActiveCallCenterIndexChanged { get; set; }
        public CardMessageListChangedFilterModel? WantsCardMessageListChangedFilter { get; set; }
        public BroadcastMessageFilterModel? WantsBroadcastMessageFilter { get; set; }
        public DepartmentInvolvedFilterModel? WantsDepartmentInvolvedFilter { get; set; }
        public DepartmentStateChangedFilterModel? WantsDepartmentStateChangedFilter { get; set; }
        public RequestedEnginesListChangedFilterModel? WantsRequestedEnginesListChangedFilter { get; set; }
        public CardCurrentStatesInDepartmentsChangedFilterModel? WantsCardCurrentStatesInDepartmentsChangedFilter { get; set; }
        public ShiftReportChangedFilterModel? WantsShiftReportChangedFilter { get; set; }
        public UpdatingCoordsFilterModel? WantsUpdatingCoordsFilter { get; set; }
        public bool? WantsCamertonEnginesPositionFilter { get; set; }
        public bool? WantsCommServDeadlineExceededFilter { get; set; }
        public CardAdditionalInfoAddedFilterModel? WantsCardAdditionalInfoAddedFilter { get; set; }
        public bool? WantsWeatherLayersChanged { get; set; }
        public bool? WantsAllServiceTypeIdsCardChanged { get; set; }
        public bool? WantsAllServiceTypeIdsCardCreated { get; set; }
        public bool? WantsSmsStatusChanged { get; set; }
        public bool? WantsSmsUpdatedEvent { get; set; }
        public List<int>? WantsServiceTypeIdsCardChanged { get; set; }
        public List<int>? WantsServiceTypeIdsCardCreated { get; set; }
    }
    public record UpdatingCoordsFilterModel
    {
        public int? ServiceTypeId { get; set; }
    }
    public record FireBarrelsItemModel
    {
        public int TypeID { get; set; }
        public int Count { get; set; }
        public DateTime? Supply { get; set; }
    }
    public record FireExtinguishersItemModel
    {
        public int TypeID { get; set; }
        public int Count { get; set; }
        public DateTime? Supply { get; set; }
    }
    public record FireChiefModel
    {
        public string? Name { get; set; }
        public int JobId { get; set; }
        public DateTime Arrive { get; set; }
    }
    public record DrillsChiefModel
    {
        public string? Name { get; set; }
        public int JobId { get; set; }
    }
    public record GdzsUnitModel
    {
        public int NumOfPeoples { get; set; }
        public int NumOfMinutes { get; set; }
        public DateTime? StartWorking { get; set; }
    }
    public record FireFighterModel
    {
        public string? Name { get; set; }
        public int JobId { get; set; }
    }
    /// <summary> Больной </summary>
    public record SickPersonModel
    {
        /// <summary> ID пациента </summary>
        public int? Id { get; set; }
        /// <summary> ФИО пациента </summary>
        public string? Name { get; set; }
        /// <summary> Отчество пациента </summary>
        public string? MiddleName { get; set; }
        /// <summary> Фамилия пациента </summary>
        public string? LastName { get; set; }
        /// <summary> Приметы пациента </summary>
        public string? SickPersonSigns { get; set; }
        /// <summary> Пол (мужчина ли) </summary>
        public bool? IsMale { get; set; }
        /// <summary> Дата рождения </summary>
        public DateTime? Birth { get; set; }
        /// <summary> Возраст лет </summary>
        public int? AgeYear { get; set; }
        /// <summary> Возраст месяцев </summary>
        public int? AgeMonth { get; set; }
        /// <summary> Возраст дней </summary>
        public int? AgeDay { get; set; }
        /// <summary> Причина вызова </summary>
        public int? ReasonId { get; set; }
        /// <summary> Описание причины </summary>
        public string? ReasonTags { get; set; }
        /// <summary> Диагноз консультанта </summary>
        public int? ConsultDiagnosId { get; set; }
        /// <summary> Диагноз ЛПУ </summary>
        public int? DiagnosId { get; set; }
        /// <summary> Результат обслуживания </summary>
        public int? ResultId { get; set; }
        /// <summary> Причина смерти </summary>
        public string? DeathCause { get; set; }
        /// <summary> Дефекты оказания помощи </summary>
        public string? EmcDefects { get; set; }
        /// <summary> Оказаная помощь </summary>
        public string? EmcAssistance { get; set; }
        /// <summary> Приоритетный ли вызов </summary>
        public bool? IsReasonPriority { get; set; }
    }
    public record HospitalModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sign { get; set; }
        public int? CityId { get; set; }
    }
    /// <summary> Информация о настройках на компьютере клиента </summary>
    public record SettingsInfoModel
    {
        public User03RoleModel? User03Role { get; set; }
        public int? CityId { get; set; }
        public int? LocalDistrictId { get; set; }
        public int? RegionId { get; set; }
        public int? NumberOfForcesAvailableDeps { get; set; }
        public int? CurrentDepartmentId { get; set; }
        public bool? IsRegion { get; set; }
        public int? ActualDepartmentID { get; set; }
        public string? WpID { get; set; }
        public string? RoleTitle { get; set; }
        public int? SourceZoneId { get; set; }
        public ImportanceLevelModel? ImportanceLevelDefaultValue { get; set; }
        public bool? IsImportanceLevelEnabled { get; set; }
        public List<int>? AdditionalCityIds { get; set; }
    }
    public record PcInfoModel
    {
        public string? OsName { get; set; }
        public SettingsInfoModel? SettingsInfo { get; set; }
        public string? MaxDotNetFramework { get; set; }
        public string? MissingVcRedistribs { get; set; }
        public string? ClientDictionariesCache { get; set; }
    }
    public record VideoQACameraModel
    {
        public int CameraID { get; set; }
        public int OperatorID { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public bool IsPtz { get; set; }
        public bool IsDigital { get; set; }
        public string? Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Azimuth { get; set; }
        public double Angle { get; set; }
        public string? Codec { get; set; }
        public int ResolutionX { get; set; }
        public int ResolutionY { get; set; }
        public int Fps { get; set; }
        public int Bitrate { get; set; }
        public double LostPackets { get; set; }
        public string? IpAddress { get; set; }
        public int StreamPort { get; set; }
        public int WebPort { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public int State { get; set; }
        public string? GatewayHost { get; set; }
        public string? Name { get; set; }
    }
    public record EraGlonassECallLocationModel
    {
        /// <summary> Широта местоположения ТС </summary>
        public long? Latitude { get; set; }
        /// <summary> Долгота местоположения ТС </summary>
        public long? Longitude { get; set; }
        /// <summary> Достоверность определения местоположения ТС </summary>
        public bool? PositionCanBeTrusted { get; set; }
        /// <summary> Момент определения местоположения </summary>
        public string? Timestamp { get; set; }
    }
    public record EraGlonassECallIntegrationModel
    {
        /// <summary> Уникальный идентификатор карточки вызова </summary>
        public string? CardId { get; set; }
        /// <summary> Краткий ссылочный идентификатор (КСИ) карточки вызова </summary>
        public int CardShortId { get; set; }
        /// <summary> Идентификатор КВ в СЭР (в случае отправки уточненной КВ) </summary>
        public string? EsgCardId { get; set; }
        /// <summary> Язык общения с заявителем </summary>
        public string? DeclarantLanguageCode { get; set; }
        /// <summary> Состояние голосового канала между заявителем и оператором </summary>
        public string? VoiceChannelState { get; set; }
        /// <summary> Число пострадавших </summary>
        public string? InjuredPersons { get; set; }
        /// <summary> Контактный телефонный номер заявителя </summary>
        public string? DriverPhone { get; set; }
        /// <summary> ФИО заявителя </summary>
        public string? DriverFullName { get; set; }
        /// <summary> Телефонный номер абонентского терминала </summary>
        public string? TerminalPhone { get; set; }
        /// <summary> Тип активации (автоматически/вручную) </summary>
        public bool? AutomaticActivation { get; set; }
        /// <summary> Тип вызова (тестовый/экстренный) </summary>
        public bool? TestCall { get; set; }
        /// <summary> Тип ТС </summary>
        public string? VehicleType { get; set; }
        /// <summary> Идентификатор ТС по ISO 3779 </summary>
        public string? VehicleIdentificationNumber { get; set; }
        /// <summary> Тип энергоносителя ТС </summary>
        public string? VehiclePropulsionStorageType { get; set; }
        /// <summary> Время события или создания карточки вызова (с временной зоной) </summary>
        public string? CallTimestamp { get; set; }
        /// <summary> Местоположение ТС в момент события </summary>
        public EraGlonassECallLocationModel? VehicleLocation { get; set; }
        /// <summary> Число пассажиров </summary>
        public int? NumberOfPassengers { get; set; }
        /// <summary> Оценка тяжести ДТП (0 = низкая вероятность ущерба здоровью людей, 10 = максимальная вероятность) </summary>
        public int? SevereCrashEstimate { get; set; }
        /// <summary> Адресная информация о местоположении ТС в текстовом виде </summary>
        public string? LocationDescription { get; set; }
        /// <summary> Удар спереди </summary>
        public bool? CrashInfoFrontCrash { get; set; }
        /// <summary> Удар слева </summary>
        public bool? CrashInfoLeftCrash { get; set; }
        /// <summary> Удар справа </summary>
        public bool? CrashInfoRightCrash { get; set; }
        /// <summary> Удар сбоку </summary>
        public bool? CrashInfoSideCrash { get; set; }
        /// <summary> Удар сзади </summary>
        public bool? CrashInfoRearCrash { get; set; }
        /// <summary> Переворот </summary>
        public bool? CrashInfoRollover { get; set; }
        /// <summary> Другой тип происшествия </summary>
        public bool? CrashInfoOtherCrashType { get; set; }
        /// <summary> Государственный регистрационный номер ТС </summary>
        public string? VehicleRegistryNumber { get; set; }
        /// <summary> Цвет кузова ТС </summary>
        public string? VehicleBodyColor { get; set; }
        /// <summary> Марка и/или модель ТС </summary>
        public string? VehicleModel { get; set; }
        /// <summary> Направление движения ТС </summary>
        public string? VehicleDirection { get; set; }
    }
    /// <summary> Карты </summary>
    public record MapAddressModel
    {
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? Localdistrict { get; set; }
        public string? AdditionalStreet { get; set; }
        public string? House { get; set; }
        public string? Building { get; set; }
        public string? Floors { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? StreetId { get; set; }
        public int? LocaldistrictId { get; set; }
        public int? AdditionalStreetId { get; set; }
        public string? InvalidStreet { get; set; }
        public string? Structure { get; set; }
    }
    public record GeoPointModelFromGenerated
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
    public record GeoAreaModelFromGenerated
    {
        public GeoPointModelFromGenerated? LowerCorner { get; set; }
        public GeoPointModelFromGenerated? UpperCorner { get; set; }
        public string? Kind { get; set; }
        public string? Text { get; set; }
        public bool IsLocality { get; set; }
        public long? IacObject { get; set; }
        public string? Floors { get; set; }
    }
    public record CardMarkerInfoModel
    {
        public string? GlobalId { get; set; }
        public int CardID { get; set; }
        public GeoPointModelFromGenerated? Coord { get; set; }
        public int? CardState { get; set; }
        public int? CallType { get; set; }
        public string? Description { get; set; }
        public bool NeedToShow { get; set; }
    }
    public record CallHistoryItemModel
    {
        public CallDataModel? CallData { get; set; }
        public DateTime CallTime { get; set; }
        public string? OperatorPin { get; set; }
        public List<PhonogramModel>? Phonograms { get; set; }
    }
    public record PhonogramModel
    {
        public string? Url { get; set; }
        public DateTime? Dtcreate { get; set; }
        public PhonogramSourceModel? SourceType { get; set; }
    }
    public record Card112ListExcelReportParamsModel
    {
        public Card112FilterModel? Filter { get; set; }
        public bool? UsePaging { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string? OrderBy { get; set; }
        public SortingOrderModel? SortingOrder { get; set; }
        public List<ColumnModel>? ReportColumns { get; set; }
    }
    public record ColumnModel
    {
        public string? Header { get; set; }
        public int? ServiceTypeId { get; set; }
        public string? FieldName { get; set; }
    }
    public enum LayerTypeModel
    {
        FIRES,
    }
    public record IntMapItemModel
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public string? Value { get; set; }
    }
    public record GisServiceGeoObjectModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? GeoJsonLocation { get; set; }
        public string? IconUrl { get; set; }
        public string? FillColor { get; set; }
        public string? StrokeColor { get; set; }
        public string? PointRadius { get; set; }
        public string? FillOpacity { get; set; }
        public string? StrokeOpacity { get; set; }
        public string? StrokeWidth { get; set; }
        public LocationModel? Location { get; set; }
        public List<GisServiceGeoObjectFieldModel>? Fields { get; set; }
    }
    public record GisServiceGeoObjectFieldModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
    }
    public record GisServiceLayerModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? ParentId { get; set; }
        public List<GisServiceGeoObjectModel>? GeoObjects { get; set; }
        public List<GisServiceLayerModel>? Layers { get; set; }
    }
    public record GeometryModel
    {
        public string? Type { get; set; }
        public List<double>? Coordinates { get; set; }
    }
    public record LocationModel
    {
        public string? Type { get; set; }
        public GeometryModel? Geometry { get; set; }
    }
    public record DistanceInfoModel
    {
        public double Distance { get; set; }
    }
    public record DistanceOnRouteInfoModel
    {
        public double Distance { get; set; }
        public List<GeoPointModelFromGenerated>? Points { get; set; }
    }
    public record LayersInfoModel
    {
        public bool? WithObjects { get; set; }
        public List<GisServiceLayerModel>? Layers { get; set; }
    }
    public record GeoObjectsInfoModel
    {
        public bool LastPage { get; set; }
        public long TotalCount { get; set; }
        public List<GisServiceGeoObjectModel>? GeoObjects { get; set; }
    }
    public record SearchInfoModel
    {
        public bool? WithObjects { get; set; }
        public List<GisServiceLayerModel>? Layers { get; set; }
    }

}
