using System;
using System.Collections.Generic;

#nullable enable
namespace Dt.EsApi.Models
{

    public record CardsContainerModel
    {
        ///<summary> РљР°СЂС‚РѕС‡РєР° 112 </summary>
        public Card112Model card112 { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° 01 </summary>
        public Card01Model? card01 { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° 02 </summary>
        public Card02Model? card02 { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° 03 </summary>
        public Card03Model? card03 { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° 04 </summary>
        public Card04Model? card04 { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° AT </summary>
        public CardATModel? cardAT { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° Р•Р”Р”РЎ/Р–РљРҐ </summary>
        public CardCommServModel? cardCommServ { get; set; }


        ///<summary> РљР°СЂС‚РѕС‡РєРё РєР°СЃС‚РѕРјРЅС‹С… СЃР»СѓР¶Р± </summary> 
        public List<CardCustomServiceModel>? customServicesCards { get; set; }
    }

    public record Card112Model
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralData? m_GeneralData { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ </summary>
        public DateTime dtCreate { get; set; }

        ///<summary> ID РІС‹Р·РѕРІР° </summary>
        public long? nCallId { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅС‹Р№ Id РІС‹Р·РѕРІР° </summary>
        public string? extCallId { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅС‹Р№ Id РІС‹Р·РѕРІР° </summary>
        public string? extCallId2 { get; set; }

        ///<summary> РќР°Р±СЂР°РЅРЅС‹Р№ РЅРѕРјРµСЂ </summary>
        public string? strCdPN { get; set; }

        ///<summary> РќРѕРјРµСЂ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strCgPN { get; set; }

        ///<summary> РљР°РєР°СЏ-С‚Рѕ РёРЅС‚РµРіСЂР°С†РёСЏ СЃ 04 </summary>
        public int? Category { get; set; }

        ///<summary> РўРёРї РІС‹Р·РѕРІР° </summary>
        public int? CallTypeId { get; set; }

        ///<summary> РўРёРї РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? IncidentTypeId { get; set; }

        ///<summary> РЈСЂРѕРІРµРЅСЊ СѓРіСЂРѕР·С‹ Р§РЎ </summary>
        public ImportanceLevel? ImportanceLevelId { get; set; }

        ///<summary> Р’Р»Р°РґРµР»РµС† С‚РµР»РµС„РѕРЅРЅРѕРіРѕ РЅРѕРјРµСЂР° </summary>
        public string? strPhoneOwner { get; set; }

        ///<summary> РђРґСЂРµСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strPhoneAddress { get; set; }

        ///<summary> РЎРѕР·РґР°С‚РµР»СЊ </summary>
        public string? strCreator { get; set; }

        ///<summary> Р Р°Р№РѕРЅ </summary>
        public int? nCityID { get; set; }

        ///<summary> РћРєСЂСѓРі </summary>
        public int? nDistrictID { get; set; }

        ///<summary> РЈР»РёС†Р° </summary>
        public int? nStreetID { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ СѓР»РёС†Р° </summary>
        public int? nAdditionalStreetId { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 112 </summary>
        public int? nCardSyntheticStateId { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 01 </summary>
        public int? nCard01SyntheticStateId { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 02 </summary>
        public int? nCard02SyntheticStateId { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 03 </summary>
        public int? nCard03SyntheticStateId { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё 04 </summary>
        public int? nCard04SyntheticStateId { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё Р•Р”Р”РЎ </summary>
        public int? nCardCommServSyntheticStateId { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё РђРў </summary>
        public int? nCardATSyntheticStateId { get; set; }

        ///<summary> РќРѕРјРµСЂ РґРѕРјР° </summary>
        public string? strBuilding { get; set; }

        ///<summary> РљРѕСЂРїСѓСЃ </summary>
        public string? strCorps { get; set; }

        ///<summary> РљРІР°СЂС‚РёСЂР° </summary>
        public string? strRoom { get; set; }

        ///<summary> РђРґСЂРµСЃРЅС‹Р№ СѓС‡Р°СЃС‚РѕРє </summary>
        public string? strAddressStrip { get; set; }

        ///<summary> Р­С‚Р°Р¶РЅРѕСЃС‚СЊ </summary>
        public string? strStoreys { get; set; }

        ///<summary> РљРѕРЅС‚Р°РєС‚РЅС‹Р№ С‚РµР»РµС„РѕРЅ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strCallerContactPhone { get; set; }

        ///<summary> Р­С‚Р°Р¶ </summary>
        public int? nFloor { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ РїРѕ РѕР±СЉРµРєС‚Сѓ </summary>
        public string? strAdditionalLocationInfo { get; set; }

        ///<summary> РџРѕРґСЉРµР·Рґ </summary>
        public string? strEntrance { get; set; }

        ///<summary> РљРѕРґ РґРѕРјРѕС„РѕРЅР° РЅР° РїРѕРґСЉРµР·РґРµ </summary>
        public string? strEntranceCode { get; set; }

        ///<summary> РћРїРёСЃР°РЅРёРµ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public string? strIncidentDescription { get; set; }

        ///<summary> РРјСЏ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strDeclarantName { get; set; }

        ///<summary> Р¤Р°РјРёР»РёСЏ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strDeclarantLastName { get; set; }

        ///<summary> РћС‚С‡РµСЃС‚РІРѕ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strDeclarantMiddleName { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? nDeclarantStatusId { get; set; }

        ///<summary> РђРґСЂРµСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strDeclarantAddress { get; set; }

        ///<summary> Р“РѕСЂРѕРґ/РѕР±Р». Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? nDeclarantCityId { get; set; }

        ///<summary> РћРєСЂСѓРі Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? nDeclarantDistrictId { get; set; }

        ///<summary> id СЂР°Р№РѕРЅР° Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public int? nDeclarantLocalDistrictId { get; set; }

        ///<summary> РЈР»РёС†Р° Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public int? nDeclarantStreetId { get; set; }

        ///<summary> РќРѕРјРµСЂ РґРѕРјР° Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strDeclarantBuildingNumber { get; set; }

        ///<summary> РљРѕСЂРїСѓСЃ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strDeclarantCorps { get; set; }

        ///<summary> РљРІР°СЂС‚РёСЂР° Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public string? strDeclarantFlat { get; set; }

        ///<summary> РўРёРї Р§РЎ </summary>
        public int? nCCMC_TypeId { get; set; }

        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 01 </summary>
        public bool lHasCard01 { get; set; }

        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 02 </summary>
        public bool lHasCard02 { get; set; }

        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 03 </summary>
        public bool lHasCard03 { get; set; }

        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° 04 </summary>
        public bool lHasCard04 { get; set; }

        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° AT </summary>
        public bool lHasCardAT { get; set; }

        ///<summary> РџРѕРґРєР»СЋС‡РµРЅР° СЃР»СѓР¶Р±Р° Р•Р”Р”РЎ </summary>
        public bool lHasCardCommServ { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РґСѓР±Р»РёСЂРѕРІР°РЅРёСЏ, РѕРїСЂРµРґРµР»РµРЅРЅС‹Р№ РїРѕР»СЊР·РѕРІР°С‚РµР»РµРј </summary>
        public int? nDuplicateUserStatus { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РґСѓР±Р»РёСЂРѕРІР°РЅРёСЏ, РѕРїСЂРµРґРµР»РµРЅРЅС‹Р№ СЃРёСЃС‚РµРјРѕР№ </summary>
        public int? nDuplicateSystemStatus { get; set; }

        ///<summary> id РІРѕР·РјРѕР¶РЅРѕРіРѕ РѕСЂРёРіРёРЅР°Р»Р° </summary>
        public int? nOriginalCardId { get; set; }

        ///<summary> GUID РІРѕР·РјРѕР¶РЅРѕРіРѕ РѕСЂРёРіРёРЅР°Р»Р° </summary>
        public string? originalGlobalId { get; set; }

        ///<summary> РњСѓР»СЊС‚РёР·РѕРЅР°Р»СЊРЅРѕСЃС‚СЊ </summary>
        public bool? isMultizone { get; set; }

        ///<summary> Р”Р°С‚Р° СЂРѕР¶РґРµРЅРёСЏ Р·РІРѕРЅСЏС‰РµРіРѕ </summary>
        public DateTime? dtDeclarantDateOfBirth { get; set; }

        ///<summary> Р’РѕР·СЂР°СЃС‚ Р·РІРѕРЅСЏС‰РµРіРѕ (Р»РµС‚) </summary>
        public int? nAgeYear { get; set; }

        ///<summary> РћР±СЉРµРєС‚ </summary>
        public int? nObjectId { get; set; }

        ///<summary> РќРѕРјРµСЂ СЂРµРІРёР·РёРё РєР°СЂС‚РѕС‡РєРё </summary>
        public int? revision { get; set; }

        ///<summary> РќРѕРјРµСЂ СЏС‡РµР№РєРё Tele2 </summary>
        public long? cellId { get; set; }

        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р°: (С€РёСЂРѕС‚Р°) </summary>
        public double? geoLatitude { get; set; }

        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р° (РґРѕР»РіРѕС‚Р°) </summary>
        public double? geoLongitude { get; set; }

        ///<summary> РћРїРёСЃР°РЅРёРµ РіРµРѕ РїРѕР·РёС†РёРё </summary>
        public string? geoRegionDesc { get; set; }

        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р° Р·Р°СЏРІРёС‚РµР»СЏ: (С€РёСЂРѕС‚Р°) </summary>
        public double? declarantGeoLatitude { get; set; }

        ///<summary> РљРѕРѕСЂРґРёРЅР°С‚Р° Р·Р°СЏРІРёС‚РµР»СЏ (РґРѕР»РіРѕС‚Р°) </summary>
        public double? declarantGeoLongitude { get; set; }

        ///<summary> РўРёРї РіРµРѕ РїРѕР·РёС†РёРё Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public string? declarantGeoRegionDesc { get; set; }

        ///<summary> РЈР»РёС†Р° РЅРµРїСЂРѕС€РµРґС€Р°СЏ РІР°Р»РёРґР°С†РёСЋ </summary>
        public string? invalidStreet { get; set; }

        ///<summary> XML РґР»СЏ РёРЅС‚РµРіСЂР°С†РёРё СЃ EraGlonass </summary>
        public string? eraIntegrationXml { get; set; }

        ///<summary> РўРµРєСЃС‚РѕРІС‹Р№ Р°РґСЂРµСЃ </summary>
        public string? strTextAddress { get; set; }

        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂС‹ РєР°РјРµСЂ РІРёРґРµРѕРїРѕСЂС‚Р°Р»Р° Р±Р»РёР¶Р°Р№С€РёС… Рє Р·Р°СЏРІРёС‚РµР»СЋ </summary>
        public string? callerNearCameras { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ Р·Р°РІРµСЂС€РµРЅРёСЏ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtComplete { get; set; }

        ///<summary> id СЂРµРіРёРѕРЅР° </summary>
        public int? nRegionId { get; set; }

        ///<summary> id СЂР°Р№РѕРЅР° </summary>
        public int? nLocalDistrictId { get; set; }

        ///<summary> Р’Р»РѕР¶РµРЅРёСЏ </summary>
        public string? attachmentList { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? dtDeadline { get; set; }

        ///<summary> РЇР·С‹Рє РѕР±С‰РµРЅРёСЏ </summary>
        public int? nLanguageId { get; set; }

        ///<summary> Р СЏРґРѕРј </summary>
        public bool isNear { get; set; }

        ///<summary> РљРј./Рј. </summary>
        public string? strKm { get; set; }

        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕСЃС‚СЂР°РґР°РІС€РёС… </summary>
        public int? nCasualties { get; set; }

        ///<summary> РЈРіСЂРѕР·Р° Р»СЋРґСЏРј </summary>
        public bool lHumanThreat { get; set; }

        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ Р·РѕРЅС‹ РІ РєРѕС‚РѕСЂРѕР№ Р±С‹Р»Р° СЃРѕР·РґР°РЅР° РєР°СЂС‚РѕС‡РєР° </summary>
        public int? sourceZoneId { get; set; }

        ///<summary> GUID РєР°СЂС‚РѕС‡РєРё </summary>
        public string? globalId { get; set; }

        ///<summary> Р¤РРћ РѕРїРµСЂР°С‚РѕСЂР° </summary>
        public string? strOperatorName { get; set; }

        ///<summary> Р’Р°Р¶РЅР°СЏ </summary>
        public bool? lPriority { get; set; }

        ///<summary> РЎРёСЃС‚РµРјР° РїРѕСЃР»РµРґРЅРµР№ РјРѕРґРёС„РёС†РёСЂРѕРІР°РІС€Р°СЏ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? strLatestSys { get; set; }

        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ РєР°СЂС‚РѕС‡РєРё Р­Р Рђ-Р“Р›РћРќРђРЎРЎ </summary>
        public string? strEraCardId { get; set; }

        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? callDuration { get; set; }

        ///<summary> Р РµР·СѓР»СЊС‚Р°С‚ Р·РІРѕРЅРєР° </summary>
        public CallStatus? callStatus { get; set; }

        ///<summary> P-Visited-Network-Id </summary>
        public string? visitedNetworkId { get; set; }

        ///<summary> РЈС‡РµР±РЅР°СЏ </summary>
        public bool lTestCard { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅС‹Рµ РїРѕР»СЏ </summary>
        public string? extendedData { get; set; }

        ///<summary> РРЅС„РѕСЂРјР°С†РёСЏ РґР»СЏ РјР°СЂС€СЂСѓС‚РёР·Р°С†РёРё РїРµСЂРµР°РґСЂРµСЃРѕРІР°РЅРЅРѕРіРѕ РІС‹Р·РѕРІР° </summary>
        public string? callRoutingTag { get; set; }

        ///<summary> РўРёРї РёСЃС‚РѕС‡РЅРёРєР° </summary>
        public int? nSourceTypeId { get; set; }

        ///<summary> externalId2 </summary>
        public string? externalId2 { get; set; }

        ///<summary> РРЅС„РѕСЂРјР°С†РёСЏ РѕР± РёСЃС‚РѕС‡РЅРёРєРµ </summary>
        public string? strSourceTypeInfo { get; set; }

        ///<summary> РђРІС‚РѕРјР°С‚РёС‡РµСЃРєРё СЂР°СЃРїСЂРµРґРµР»СЏС‚СЊ РєР°СЂС‚РѕС‡РєСѓ РЅР° РѕРїРµСЂР°С‚РѕСЂР° </summary>
        public bool? autoDistribute { get; set; }

        ///<summary> РЇРІР»СЏРµС‚СЃСЏ Р»Рё РєР°СЂС‚РѕС‡РєР° С‡РµСЂРЅРѕРІРёРєРѕРј </summary>
        public bool? draft { get; set; }

        ///<summary> metadata РїРѕ РєР°СЂС‚РѕС‡РєРµ </summary>
        public MetaDataModel? metadata { get; set; }

        ///<summary> РљРѕРЅС‚СЂРѕР»СЊ </summary>
        public bool? control { get; set; }

        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ С‡Р°С‚Р° </summary>
        public string? ChatId { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° Р±С‹Р»Р° РёР·РјРµРЅРµРЅР° РїРѕСЃР»Рµ РїРµСЂРІРѕРіРѕ СЃРѕС…СЂР°РЅРµРЅРёСЏ </summary>
        public bool? wasChangedAfterFirstSave { get; set; }

        ///<summary> РќРѕРјРµСЂ СЃС‚СЂРѕРµРЅРёСЏ </summary>
        public string? strStructure { get; set; }

        ///<summary> РќРѕРјРµСЂ СЃС‚СЂРѕРµРЅРёСЏ РІ Р°РґСЂРµСЃРµ Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public string? strDeclarantStructure { get; set; }

        ///<summary> Р’С‹Р·РѕРІС‹, РїСЂРёРІСЏР·Р°РЅРЅС‹Рµ Рє РєР°СЂС‚РѕС‡РєРµ </summary> 
        public List<CallHistoryItemModel>? callHistory { get; set; }

        ///<summary> РЎРµСЂРІРёСЃС‹, РЅР° РєРѕС‚РѕСЂС‹Рµ РЅРµ СѓРґР°Р»РѕСЃСЊ РїРµСЂРµРґР°С‚СЊ РєР°СЂС‚РѕС‡РєСѓ </summary> 
        public List<ReplicationTargetModel>? failedReplicationTargets { get; set; }

        ///<summary> РЎРµСЂРІРёСЃС‹ РЅР° РєРѕС‚РѕСЂС‹Рµ СѓРґР°Р»РѕСЃСЊ РїРµСЂРµРґР°С‚СЊ РєР°СЂС‚РѕС‡РєСѓ </summary> 
        public List<ReplicationTargetModel>? succeededReplicationTargets { get; set; }

        ///<summary> РћС‚РґРµР»РµРЅРёСЏ Р–РљРҐ </summary> 
        public List<int>? directCommServDepartments { get; set; }

        ///<summary> РџСЂРёРІР»РµС‡С‘РЅРЅС‹Рµ РєР°СЃС‚РѕРјРЅС‹Рµ СЃР»СѓР¶Р±С‹ </summary> 
        public List<CustomServiceModel>? customServices { get; set; }
    }

    public record Card01Model
    {

        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralData? m_GeneralData { get; set; }

        ///<summary> Р”Р°РЅРЅС‹Рµ Рѕ РІР»Р°РґРµР»СЊС†Рµ РѕР±СЉРµРєС‚Р° </summary>
        public string? strObjectOwner { get; set; }

        ///<summary> Р’РёРґ РїРѕР¶Р°СЂРЅРѕР№ РѕС…СЂР°РЅС‹ </summary>
        public int? nFirePreventionTypeID { get; set; }

        ///<summary> в„– РєР°СЂС‚РѕС‡РєРё РЈРџ </summary>
        public string? strInternalCardNumber { get; set; }

        ///<summary> Р’СЂРµРјСЏ РїРѕРґР°С‡Рё РїРµСЂРІРѕРіРѕ СЃС‚РІРѕР»Р° (РІ РјРёРЅСѓС‚Р°С…) </summary>
        public int? firstFireBarrel { get; set; }

        ///<summary> Р Р°СЃС…РѕРґ РІРѕРґС‹ (РІ Р»РёС‚СЂР°С…) </summary>
        public int? waterConsumption { get; set; }

        ///<summary> Р’РѕРґРѕРёСЃС‚РѕС‡РЅРёРє </summary>
        public int? nWaterSourceID { get; set; }

        ///<summary> РЈС‰РµСЂР± </summary>
        public int? damageCost { get; set; }

        ///<summary> РЎРїР°СЃРµРЅРѕ РјР°С‚. С†РµРЅРЅРѕСЃС‚РµР№ </summary>
        public int? savedCost { get; set; }

        ///<summary> РћРїРµСЂР°С‚РёРІРЅС‹Р№ РёРЅС‚РµСЂРµСЃ </summary>
        public bool policeInterest { get; set; }

        ///<summary> РЎРјРµРЅР° </summary>
        public string? strShift { get; set; }

        ///<summary> РЎРѕРѕР±С‰РµРЅРёРµ </summary>
        public string? strMessage { get; set; }

        ///<summary> Р”РѕРї.РёРЅС„Рѕ РѕР±СЉРµРєС‚Р° </summary>
        public string? strObjectAdditionalInfo { get; set; }

        ///<summary> РћР±СЉРµРєС‚ </summary>
        public int? nObjectId { get; set; }

        ///<summary> РџР»Р°РЅ СЂРµР°РіРёСЂРѕРІР°РЅРёСЏ </summary>
        public int? nReactionPlanId { get; set; }

        ///<summary> РўРёРї РѕР±СЉРµРєС‚Р° </summary>
        public int? nObjectTypeId { get; set; }

        ///<summary> РћР±СЉРµРєС‚ РіР°Р·РёС„РёС†РёСЂРѕРІР°РЅ </summary>
        public bool lObjectGasified { get; set; }

        ///<summary> Р Р°РЅРі РїРѕР¶Р°СЂР° </summary>
        public int? nFireClassId { get; set; }

        ///<summary> РЈРіСЂРѕР·Р° Р»СЋРґСЏРј </summary>
        public bool lHumanThreat { get; set; }

        ///<summary> РџСЂРёР·РЅР°Рє Р§РЎ </summary>
        public bool lEmergencyFlag { get; set; }

        ///<summary> РџР»РѕС‰Р°РґСЊ (РєРІ.Рј.) </summary>
        public int? nSpace { get; set; }

        ///<summary> РџРѕРіРёР±Р»Рѕ Р»СЋРґРµР№ </summary>
        public int? nPerishedPeople { get; set; }

        ///<summary> РџРѕРіРёР±Р»Рѕ РґРµС‚РµР№ </summary>
        public int? nPerishedChildren { get; set; }

        ///<summary> РџРѕРіРёР±Р»Рѕ СЃРѕС‚СЂСѓРґРЅРёРєРѕРІ </summary>
        public int? nPerishedCollaborators { get; set; }

        ///<summary> Р Р°РЅРµРЅРѕ Р»СЋРґРµР№ </summary>
        public int? nWounded { get; set; }

        ///<summary> Р Р°РЅРµРЅРѕ РґРµС‚РµР№ </summary>
        public int? nWoundedChildren { get; set; }

        ///<summary> Р Р°РЅРµРЅРѕ СЃРѕС‚СЂСѓРґРЅРёРєРѕРІ </summary>
        public int? nWoundedCollaborators { get; set; }

        ///<summary> РЎРїР°СЃРµРЅРѕ Р»СЋРґРµР№ </summary>
        public int? nSavedPeople { get; set; }

        ///<summary> РЎРїР°СЃРµРЅРѕ РґРµС‚РµР{ get; set; } </summary>
        public int? nSavedChildren { get; set; }

        ///<summary> РќР°СЂСѓС€РµРЅРѕ Сѓ/Р¶ </summary>
        public int? nBrokenLivingConditions { get; set; }

        ///<summary> РќР°СЂСѓС€РµРЅРѕ Сѓ/Р¶ РґРµС‚РµР№ </summary>
        public int? nBrokenLivingConditionsChildren { get; set; }

        ///<summary> РџСЂРёС‡РёРЅР° РїРѕР¶Р°СЂР° </summary>
        public int? nFireReasonID { get; set; }

        ///<summary> Р’РёРґ РІС‹РµР·РґР° </summary>
        public int? nFireIncidentTypeID { get; set; }

        ///<summary> Р’СЂРµРјСЏ Р»РѕРєР°Р»РёР·Р°С†РёРё </summary>
        public DateTime? dtLocalization { get; set; }

        ///<summary> Р’СЂРµРјСЏ Р»РёРєРІРёРґР°С†РёРё </summary>
        public DateTime? dtLiquidation { get; set; }

        ///<summary> Р’СЂРµРјСЏ СѓСЃС‚СЂР°РЅРµРЅРёСЏ РѕС‚РєСЂС‹С‚РѕРіРѕ РѕРіРЅСЏ </summary>
        public DateTime? dtOpenFireLiquidation { get; set; }

        ///<summary> РЈС‚РѕС‡РЅРµРЅРЅР°СЏ РїСЂРёС‡РёРЅР° РїРѕР¶Р°СЂР° </summary>
        public string? strDescription { get; set; }

        ///<summary> Р Р°СЃСЃС‚РѕСЏРЅРёРµ </summary>
        public int? nFireDistance { get; set; }

        ///<summary> Р¤РѕСЂРјР° СЃРѕР±СЃС‚РІРµРЅРЅРѕСЃС‚Рё </summary>
        public string? strOwnership { get; set; }

        ///<summary> РћС€РёР±РѕС‡РЅР°СЏ РєР°СЂС‚РѕС‡РєР° </summary>
        public bool isError { get; set; }

        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardCreate { get; set; }

        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardView { get; set; }

        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWork { get; set; }

        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWorkNext { get; set; }

        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardComplete { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? dtDeadline { get; set; }

        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? nServiceIncidentTypeId { get; set; }

        ///<summary> РћС†РµРЅРєР° РІСЂРµРјРµРЅРё СЂР°Р·РІРёС‚РёСЏ РїРѕР¶Р°СЂР° </summary>
        public int? nFireStartEstimate { get; set; }

        ///<summary> РќР°Р±Р»СЋРґР°РµРјС‹Рµ РїРѕСЃР»РµРґСЃС‚РІРёСЏ РїРѕР¶Р°СЂР° </summary>
        public string? strFireResults { get; set; }

        ///<summary> РҐР°СЂР°РєС‚РµСЂРёСЃС‚РёРєР° РїРѕРґСЉРµР·РґРЅС‹С… РїСѓС‚РµР№ </summary>
        public string? strPathDescription { get; set; }

        ///<summary> РҐР°СЂР°РєС‚РµСЂРёСЃС‚РёРєР° СѓСЃР»РѕРІРёР№ СЂР°Р±РѕС‚С‹ </summary>
        public string? strConditionsDescription { get; set; }

        ///<summary> РћС†РµРЅРєР° РІРѕР·РјРѕР¶РЅРѕСЃС‚Рё СЌРІР°РєСѓР°С†РёРё </summary>
        public bool lEvacuationAvail { get; set; }

        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? strServiceOperator { get; set; }

        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? strRegistrationNumber { get; set; }

        ///<summary> Р­С‚Р°Р¶РЅРѕСЃС‚СЊ (РЎРџР‘) </summary>
        public int? nNumberStoreys { get; set; }

        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? callDuration { get; set; }

        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? dtDenialOfService { get; set; }

        ///<summary> РЎРїРµС†РёС„РёС‡РЅС‹Рµ РґР°РЅРЅС‹Рµ РґР»СЏ СЂРµРіРёРѕРЅР° СѓСЃС‚Р°РЅРѕРІРєРё </summary>
        public RegionDataModel? regionData { get; set; }

        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ РњРќРРЎ </summary>
        public string? strMNISId { get; set; }

        ///<summary> РЎРІРµРґРµРЅРёСЏ РњРќРРЎ </summary>
        public MNISReactionModel? mnisReactionInfo { get; set; }

        ///<summary> РџРѕРґР°РІР°Р»Рё СЃС‚РІРѕР»С‹ </summary> 
        public List<FireBarrelsItemModel>? fireBarrels { get; set; }

        ///<summary> РћРіРЅРµС‚СѓС€Р°С‰РёРµ СЃСЂРµРґСЃС‚РІР° </summary> 
        public List<FireExtinguishersItemModel>? fireExtinguishers { get; set; }

        ///<summary> Р СѓРєРѕРІРѕРґРёС‚РµР»Рё СѓС‡РµРЅРёР№ </summary>
        public List<DrillsChiefModel>? drillsChiefs { get; set; }

        ///<summary> Р РўРџ-1 </summary> 
        public List<FireChiefModel>? fireChiefs { get; set; }

        ///<summary> Р›РёС‡РЅС‹Р№ СЃРѕСЃС‚Р°РІ </summary> 
        public List<FireFighterModel>? fireFighters { get; set; }

        ///<summary> Р—РІРµРЅСЊСЏ Р“Р”Р—РЎ </summary> 
        public List<GdzsUnitModel>? gdzsUnits { get; set; }

        ///<summary> РЎРІРµРґРµРЅРёСЏ Рѕ РїСЂРёРІР»РµС‡РµРЅРЅС‹С… РўРЎ 01 </summary> 
        public List<Vehicle01InfoModel>? involvedVehicles { get; set; }
    }

    public record Card02Model
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralData? m_GeneralData { get; set; }

        ///<summary> РљР°СЂС‚РѕС‡РєР° РћР’Р” </summary>
        public CardOVDModel m_CardOVD { get; set; }

        ///<summary> РљРІР°Р»РёС„РёРєР°С†РёСЏ </summary>
        public int? nITypeID { get; set; }

        ///<summary> РџСЂРёРѕСЂРёС‚РµС‚РЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? importanceLevel { get; set; }

        ///<summary> Р­РєСЃРїРѕСЂС‚РёСЂРѕРІР°РЅР° Р»Рё </summary>
        public bool lExported { get; set; }

        ///<summary> РќРѕРјРµСЂ РљРЈРЎРџ </summary>
        public string? strRegistrationNumber { get; set; }

        ///<summary> РћС‚РґРµР»РµРЅРёРµ </summary>
        public int? registrationDepartmentID { get; set; }

        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardCreate { get; set; }

        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardView { get; set; }

        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWork { get; set; }

        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWorkNext { get; set; }

        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardComplete { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? dtDeadline { get; set; }

        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? nServiceIncidentTypeId { get; set; }

        ///<summary> Р§РёСЃР»Рѕ РїСЂР°РІРѕРЅР°СЂСѓС€РёС‚РµР»РµР№ </summary>
        public int? nCriminalsCount { get; set; }

        ///<summary> Р§РёСЃР»Рѕ С‚СЂР°РЅСЃРїРѕСЂС‚РЅС‹С… СЃСЂРµРґСЃС‚РІ </summary>
        public int? nVehiclesCount { get; set; }

        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? strServiceOperator { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ Рѕ РїСЂРѕРёСЃС€РµСЃС‚РІРёРё </summary>
        public string? strIncidentAdditionalInfo { get; set; }

        ///<summary> РќРѕРјРµСЂ РїРµСЂРІРѕРіРѕ РўРЎ РІ СЃРїРёСЃРєРµ </summary>
        public string? strVehicleRegNumberReadOnly { get; set; }

        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? callDuration { get; set; }

        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? dtDenialOfService { get; set; }

        ///<summary> СЃРїРµС†РёС„РёС‡РЅС‹Рµ РґР°РЅРЅС‹Рµ РґР»СЏ СЂРµРіРёРѕРЅР° СѓСЃС‚Р°РЅРѕРІРєРё </summary>
        public RegionDataModel? regionData { get; set; }

        ///<summary> РџРѕРґРѕР·СЂРµРІР°РµРјС‹Рµ </summary> 
        public List<Tm_ISharerDescriptionModel>? m_CriminalDescriptionList { get; set; }

        ///<summary> Р Р°Р·С‹СЃРєРёРІР°РµРјС‹Рµ </summary> 
        public List<Tm_ISharerDescriptionModel>? m_LostPeopleDescriptionList { get; set; }

        ///<summary> РђРІС‚РѕС‚СЂР°РЅСЃРїРѕСЂС‚ </summary> 
        public List<Tm_IVehicleDescriptionModel>? m_VehicleList { get; set; }

        ///<summary> РџРѕСЃС‚СЂР°РґР°РІС€РёРµ </summary> 
        public List<Tm_IVictimDescriptionModel>? m_VictimList { get; set; }
    }

    public record CardOVDModel
    {
        ///<summary> РќРѕРјРµСЂ РєР°СЂС‚РѕС‡РєРё 112 </summary>
        public int nEmergencyCardId { get; set; }

        ///<summary> РљС‚Рѕ РїСЂРёРЅСЏР» </summary>
        public string? strInspector { get; set; }

        ///<summary> РџСЂРёРЅСЏС‚РѕРµ СЂРµС€РµРЅРёРµ </summary>
        public int? nStatusId { get; set; }

        ///<summary> РљРЈРЎРџ РћР’Р” </summary>
        public string? strIntrinsicOVD_N { get; set; }

        ///<summary> Р”Р°С‚Р° СЂРµРі. </summary>
        public DateTime? dtRegDate { get; set; }

        ///<summary> в„–РґРµР»Р° / в„–РљРЈРЎРџ / в„–Р°РґРј. РїСЂРѕС‚. </summary>
        public string? strDocNumber { get; set; }

        ///<summary> РЎС‚СЂР°РЅРёС†Р° </summary>
        public string? strPage { get; set; }

        ///<summary> Р РµР·СѓР»СЊС‚Р°С‚ </summary>
        public bool lSolved { get; set; }

        ///<summary> РљРІР°Р»РёС„РёРєР°С†РёСЏ РћР’Р” </summary>
        public int? nOVDITypeId { get; set; }

        ///<summary> РљРЈРЎРџ Р”РџРЎ </summary>
        public string? strIntrinsicDPS_N { get; set; }

        ///<summary> РРјРµРµС‚СЃСЏ РІРёРґРµРѕРЅР°Р±Р»СЋРґРµРЅРёРµ </summary>
        public bool? isVideoObservation { get; set; }

        ///<summary> РРјРµРµС‚СЃСЏ РїРѕРґРѕР·СЂРµРІР°РµРјС‹Р№ РІ СЃРѕРІРµСЂС€РµРЅРёРё РїСЂРµСЃС‚СѓРїР»РµРЅРёСЏ </summary>
        public bool? isSuspectedPerson { get; set; }

        ///<summary> РР·СЉСЏС‚С‹ СЃР»РµРґС‹, РІРµС‰РµСЃС‚РІРµРЅРЅС‹Рµ РґРѕРєР°Р·Р°С‚РµР»СЊСЃС‚РІР° </summary>
        public bool? isEvidence { get; set; }

        ///<summary> РЈС‡Р°СЃС‚РёРµ СЂР°Р±РѕС‚РЅРёРєР° РЎРљ Р Р¤ </summary>
        public bool? isSkRfStuff { get; set; }

        ///<summary> РџСЂРѕРІРµРґРµРЅРЅС‹Рµ РјРµСЂРѕРїСЂРёСЏС‚РёСЏ </summary>
        public int? nPastEventId { get; set; }

        ///<summary> РРЅС„РѕСЂРјР°С†РёСЏ РїРѕ СЂРµР·СѓР»СЊС‚Р°С‚Р°Рј РІС‹РµР·РґР° </summary>
        public int? nDepartureResultId { get; set; }

        ///<summary> РљС‚Рѕ РІС‹РµР·Р¶Р°Р» </summary> 
        public List<TaskForceItemModel>? taskForceItemsList { get; set; }
    }

    public record Card03Model
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralData? generalData { get; set; }

        ///<summary> ID РєР°СЂС‚РѕС‡РєРё РІ РєРѕРЅРєСЂРµС‚РЅС‹Р№ РґРµРЅСЊ </summary>
        public int? nDailyId { get; set; }

        ///<summary> РўСЂР°РЅСЃРїРѕСЂС‚РёСЂРѕРІРєР° Р»Рё СЌС‚Р° РєР°СЂС‚РѕС‡РєР° </summary>
        public bool isTransportation { get; set; }

        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ Р±РѕР»СЊРЅС‹С… </summary>
        public int? nSickCount { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РєР°СЂС‚РѕС‡РєРё </summary>
        public CardCompleteStatus? nCompleteStatus { get; set; }

        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ Р›РџРЈ РѕС‚РїСЂР°РІРєРё </summary>
        public int? nHospitalId { get; set; }

        ///<summary> РРґРµРЅС‚РёС„РёРєР°С‚РѕСЂ Р›РџРЈ РЅР°Р·РЅР°С‡РµРЅРёСЏ </summary>
        public int? nDstHospitalId { get; set; }

        ///<summary> РўРёРї С‚СЂР°РЅСЃРїРѕСЂС‚РёСЂРѕРІРєРё </summary>
        public int? nTransportationId { get; set; }

        ///<summary> РџСЂРёС‡РёРЅР° С‚СЂР°РЅСЃРїРѕСЂС‚РёСЂРѕРІРєРё </summary>
        public int? nTransportReasonId { get; set; }

        ///<summary> Р’СЂРµРјСЏ РѕРєРѕРЅС‡Р°РЅРёСЏ РѕР±СЃР»СѓР¶РёРІР°РЅРёСЏ РІС‹Р·РѕРІР° </summary>
        public DateTime? dtClosed { get; set; }

        ///<summary> Р’СЂРµРјСЏ РґРѕСЃС‚Р°РІР»РµРЅРёСЏ РІ Р›РџРЈ </summary>
        public DateTime? dtAdmission { get; set; }

        ///<summary> РљСѓРґР° РґРѕСЃС‚Р°РІР»РµРЅ </summary>
        public string? strDeliveredTo { get; set; }

        ///<summary> РЎРѕРѕР±С‰РµРЅРёРµ Р±СЂРёРіР°РґС‹ </summary>
        public string? strTeamMessage { get; set; }

        ///<summary> РџСЂРёС‡РёРЅР° Р·Р°РєСЂС‹С‚РёСЏ РєР°СЂС‚РѕС‡РєРё </summary>
        public string? strCloseReason { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ РґСѓР±Р»РёСЂРѕРІР°РЅРёСЏ </summary>
        public int? nDuplicateStatus { get; set; }

        ///<summary> id РІРѕР·РјРѕР¶РЅРѕРіРѕ РѕСЂРёРіРёРЅР°Р»Р° </summary>
        public int? nOriginalCardId { get; set; }

        ///<summary> Р РµРєРѕРјРµРЅРґРѕРІР°РЅРЅС‹Р№ РґРµРїР°СЂС‚Р°РјРµРЅС‚ </summary>
        public int? nRecomendedDepId { get; set; }

        ///<summary> РЎС‚СЂРѕРєР° СЃ РёРЅС„РѕСЂРјР°С†РёРµР№ Рѕ Р±РѕР»СЊРЅС‹С… РґР»СЏ СЃРїРёСЃРєР° </summary>
        public string? strSickPersonsInfo { get; set; }

        ///<summary> РЎС‚СЂРѕРєР° СЃ РїРµСЂРµС‡РёСЃР»РµРЅРёРµРј РїСЂРёС‡РёРЅ РІС‹Р·РѕРІР° РґР»СЏ РїРѕРґСЃРІРµС‚РєРё РІ СЃРїРёСЃРєРµ РїСЂРѕРёСЃС€РµСЃС‚РІРёР№ </summary>
        public string? strSickPersonsReasons { get; set; }

        ///<summary> РЎС‚СЂРѕРєР° СЃ РїРµСЂРµС‡РёСЃР»РµРЅРёРµРј РјРµС‚РѕРє Рѕ С‚РѕРј, С‡С‚Рѕ РІС‹Р·РѕРІ СЏРІР»СЏРµС‚СЃСЏ РїСЂРёРѕСЂРёС‚РµС‚РЅС‹Рј </summary>
        public string? strSickPersonsPriorities { get; set; }

        ///<summary> РЎС‚СЂРѕРєР° СЃ РёРЅС„РѕСЂРјР°С†РёРµР№ Рѕ Р±СЂРёРіР°РґР°С… </summary>
        public string? strEnginesInfo { get; set; }

        ///<summary> РћСЃРІРѕР±РѕРґРёС‚СЊ Р±СЂРёРіР°РґС‹ </summary>
        public bool? isFreeTransport { get; set; }

        ///<summary> РџРµСЂРµРґР°С‡Р° С†РµРЅС‚СЂР°Р»СЊРЅРѕРјСѓ РґРёСЃРїРµС‚С‡РµСЂСѓ </summary>
        public bool? isTransfered { get; set; }

        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardCreate { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ Рѕ РїСЂРѕРёСЃС€РµСЃС‚РІРёРё </summary>
        public string? strIncidentAdditionalInfo { get; set; }

        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardView { get; set; }

        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWork { get; set; }

        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWorkNext { get; set; }

        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardComplete { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? dtDeadline { get; set; }

        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? nServiceIncidentTypeId { get; set; }

        ///<summary> РљС‚Рѕ РІС‹Р·РІР°Р» </summary>
        public string? strWhoCalled { get; set; }

        ///<summary> РљС‚Рѕ РІС‹Р·РІР°Р» (РєР»Р°СЃСЃРёС„РёРєР°С‚РѕСЂ) </summary>
        public int? nWhoCalledId { get; set; }

        ///<summary> Р•СЃС‚СЊ РґРµС‚Рё </summary>
        public bool haveChildren { get; set; }

        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? strServiceOperator { get; set; }

        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? strRegistrationNumber { get; set; }

        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? callDuration { get; set; }

        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? dtDenialOfService { get; set; }

        ///<summary> РџСЂРёРІР»РµС‡РµРЅС‹ РўРЎ 03 </summary>
        public bool? isVehicleInvolved { get; set; }

        ///<summary> Р‘РѕР»СЊРЅС‹Рµ </summary> 
        public List<SickPersonModel>? sickPersons { get; set; }

        ///<summary> РЎРІРµРґРµРЅРёСЏ Рѕ РїСЂРёРІР»РµС‡РµРЅРЅС‹С… РўРЎ 03 </summary> 
        public List<Vehicle03InfoModel>? involvedVehicles { get; set; }
    }

    public record Card04Model
    {
        ///<summary> Общая информация </summary>
        public CardGeneralData? GeneralData;

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
        public CardCompleteStatus CompleteStatus { get; set; }

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
        public CardGeneralData? m_GeneralData { get; set; }

        ///<summary> РЎРѕРѕР±С‰РµРЅРёРµ </summary>
        public string? strMessage { get; set; }

        ///<summary> Р”РѕРїРѕР»РЅРёС‚РµР»СЊРЅР°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ РїРѕ РѕР±СЉРµРєС‚Сѓ </summary>
        public string? strObjectInfo { get; set; }

        ///<summary> РЈРіСЂРѕР·Р° Р»СЋРґСЏРј </summary>
        public bool lHumanThreat { get; set; }

        ///<summary> РџСЂРёР·РЅР°Рє Р§РЎ </summary>
        public bool lEmergencyFlag { get; set; }

        ///<summary> Р’СЂРµРјСЏ СѓР±С‹С‚РёСЏ Р±СЂРёРіР°РґС‹ </summary>
        public DateTime? dtDepart { get; set; }

        ///<summary> Р’СЂРµРјСЏ РїСЂРёР±С‹С‚РёСЏ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtArrival { get; set; }

        ///<summary> РўРёРї РѕР±СЉРµРєС‚Р° </summary>
        public int? nObjectTypeId { get; set; }

        ///<summary> Р’СЂРµРјСЏ СѓСЃС‚СЂР°РЅРµРЅРёСЏ </summary>
        public DateTime? dtComplete { get; set; }

        ///<summary> РЎС‚Р°С‚СѓСЃ </summary>
        public CardCompleteStatus nCompleteStatus { get; set; }

        ///<summary> Р—Р°РґРµР№СЃС‚РІРѕРІР°РЅРЅС‹Рµ СЃРёР»С‹ </summary>
        public string? strUsedMeans { get; set; }

        ///<summary> РљРѕРЅС‚СЂРѕР»СЊРЅРѕРµ РІСЂРµРјСЏ РІС‹РїРѕР»РЅРµРЅРёСЏ </summary>
        public DateTime? dtDeadlineExceeded { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РґРѕРІРµРґРµРЅРёСЏ РёРЅС„РѕСЂРјР°С†РёРё РґРѕ Р·Р°СЏРІРёС‚РµР»СЏ </summary>
        public DateTime? dtDeclarantNotify { get; set; }

        ///<summary> Р”РёСЃРїРµС‚С‡РµСЂ </summary>
        public string? strAgentWhoNotifies { get; set; }

        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardCreate { get; set; }

        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardView { get; set; }

        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWork { get; set; }

        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWorkNext { get; set; }

        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardComplete { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? dtDeadline { get; set; }

        ///<summary> Р’РёРґ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? nServiceIncidentTypeId { get; set; }

        ///<summary> РљРѕРјРјСѓРЅР°Р»СЊРЅР°СЏ СЃР»СѓР¶Р±Р° </summary>
        public int? nCommunityServiceId { get; set; }

        ///<summary> РРЅСЃС‚СЂСѓРєС†РёРё </summary>
        public int? nInstructionId { get; set; }

        ///<summary> РљРѕРЅСЃСѓР»СЊС‚Р°С†РёСЏ </summary>
        public bool lIsConsulting { get; set; }

        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? strServiceOperator { get; set; }

        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? strRegistrationNumber { get; set; }

        ///<summary> РџСЂРёРЅСЏС‚С‹Рµ РјРµСЂС‹ </summary>
        public string? strMeasures { get; set; }

        ///<summary> РљР°С‚РµРіРѕСЂРёСЏ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public int? nServiceIncidentCategoryId { get; set; }

        ///<summary> РЈРїСЂР°РІР»СЏСЋС‰Р°СЏ РєРѕРјРїР°РЅРёСЏ </summary>
        public int? nUKID { get; set; }

        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? callDuration { get; set; }

        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? dtDenialOfService { get; set; }
    }

    public record CardATModel
    {
        ///<summary> РћР±С‰Р°СЏ РёРЅС„РѕСЂРјР°С†РёСЏ </summary>
        public CardGeneralData? m_GeneralData { get; set; }

        ///<summary> РћРїРёСЃР°РЅРёРµ РїСЂРѕРёСЃС€РµСЃС‚РІРёСЏ </summary>
        public string? strWhatHappened { get; set; }

        ///<summary> РџСЂРёРЅСЏС‚С‹Рµ РјРµСЂС‹ </summary>
        public string? strMeasures { get; set; }

        ///<summary> РЈС‰РµСЂР± </summary>
        public string? strDamage { get; set; }

        ///<summary> Р’СЂРµРјСЏ СЃРѕР·РґР°РЅРёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardCreate { get; set; }

        ///<summary> Р’СЂРµРјСЏ РїСЂРѕСЃРјРѕС‚СЂР° СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardView { get; set; }

        ///<summary> Р’С‹РµР·Рґ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWork { get; set; }

        ///<summary> РџСЂРёР±С‹С‚РёРµ РЅР° РјРµСЃС‚Рѕ </summary>
        public DateTime? dtServiceCardWorkNext { get; set; }

        ///<summary> Р’СЂРµРјСЏ Р·Р°РєСЂС‹С‚РёСЏ СЃРµСЂРІРёСЃРЅРѕР№ РєР°СЂС‚РѕС‡РєРё </summary>
        public DateTime? dtServiceCardComplete { get; set; }

        ///<summary> Р”Р°С‚Р° Рё РІСЂРµРјСЏ РЅР°СЂСѓС€РµРЅРёСЏ СЂРµРіР»Р°РјРµРЅС‚Р° </summary>
        public DateTime? dtDeadline { get; set; }

        ///<summary> РћРїРµСЂР°С‚РѕСЂ Р”Р”РЎ РїСЂРёРЅСЏРІС€РёР№ РєР°СЂС‚РѕС‡РєСѓ </summary>
        public string? strServiceOperator { get; set; }

        ///<summary> Р’РЅСѓС‚СЂРµРЅРЅРёР№ РЅРѕРјРµСЂ Р·Р°СЏРІРєРё Р”Р”РЎ </summary>
        public string? strRegistrationNumber { get; set; }

        ///<summary> Р’РёРґ С‚РµСЂСЂРѕСЂРёСЃС‚РёС‡РµСЃРєРѕРіРѕ Р°РєС‚Р° </summary>
        public int? nServiceIncidentTypeId { get; set; }

        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕРіРёР±С€РёС… </summary>
        public int? nDied { get; set; }

        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕСЃС‚СЂР°РґР°РІС€РёС… </summary>
        public int? nVictims { get; set; }

        ///<summary> РљРѕР»РёС‡РµСЃС‚РІРѕ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public int? nSuspects { get; set; }

        ///<summary> РћРїРёСЃР°РЅРёРµ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? strSuspectsDesc { get; set; }

        ///<summary> Р’РѕРѕСЂСѓР¶РµРЅРёРµ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? strSuspectsEquipment { get; set; }

        ///<summary> РўСЂР°РЅСЃРїРѕСЂС‚РЅС‹Рµ СЃСЂРµРґСЃС‚РІР° РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? strSuspectsVehicles { get; set; }

        ///<summary> РќР°РїСЂР°РІР»РµРЅРёРµ РґРІРёР¶РµРЅРёСЏ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? strSuspectsDirection { get; set; }

        ///<summary> РџРѕРІСЂРµР¶РґРµРЅРёСЏ РїРѕРґРѕР·СЂРµРІР°РµРјС‹С… </summary>
        public string? strSuspectsInjury { get; set; }

        ///<summary> РџСЂРѕРґРѕР»Р¶РёС‚РµР»СЊРЅРѕСЃС‚СЊ РІС‹Р·РѕРІР° </summary>
        public int? callDuration { get; set; }

        ///<summary> Р’СЂРµРјСЏ РѕС‚РєР°Р·Р° РІ РѕР±СЃР»СѓР¶РёРІР°РЅРёРё </summary>
        public DateTime? dtDenialOfService { get; set; }
    }

    public record ServiceCard01Model
    {
        public Card112Model card112Data { get; set; }

        public Card01Model card01Data { get; set; }
    }

    public record ServiceCard02Model
    {
        public Card112Model card112Data { get; set; }

        public Card02Model card02Data { get; set; }
    }

    public record ServiceCard03Model
    {
        public Card112Model card112Data { get; set; }

        public Card03Model card03Data { get; set; }
    }

    public record ServiceCard04Model
    {
        public Card112Model card112Data { get; set; }

        public Card04Model card04Data { get; set; }
    }

    public record ServiceCardCommServModel
    {
        public Card112Model card112Data { get; set; }

        public CardCommServModel cardCommServData { get; set; }
    }

    public record ServiceCardATModel
    {
        public Card112Model card112Data { get; set; }

        public CardATModel cardATData { get; set; }
    }

    public record PrevDeclarantInfoModel
    {
        ///<summary> Р¤Р°РјРёР»РёСЏ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? strPrevDeclarantLastName { get; set; }

        ///<summary> РРјСЏ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? strPrevDeclarantName { get; set; }

        ///<summary> РћС‚С‡РµСЃС‚РІРѕ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? strPrevDeclarantMiddleName { get; set; }

        ///<summary> РљРѕРЅС‚Р°РєС‚РЅС‹Р№ С‚РµР»РµС„РѕРЅ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? strPrevCallerContactPhone { get; set; }

        ///<summary> Р“РѕСЂРѕРґ/РѕР±Р». Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public int? nPrevDeclarantCityId { get; set; }

        ///<summary> РћРєСЂСѓРі Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public int? nPrevDeclarantDistrictId { get; set; }

        ///<summary> РЈР»РёС†Р° Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public int? nPrevDeclarantStreetId { get; set; }

        ///<summary> РќРѕРјРµСЂ РґРѕРјР° Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? strPrevDeclarantBuildingNumber { get; set; }

        ///<summary> РљРѕСЂРїСѓСЃ Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? strPrevDeclarantCorps { get; set; }

        ///<summary> РљРІР°СЂС‚РёСЂР° Р·РІРѕРЅСЏС‰РµРіРѕ РІ РїСЂРµРґС‹РґСѓС‰РµРј РІС‹Р·РѕРІРµ </summary>
        public string? strPrevDeclarantFlat { get; set; }
    }

    public record CardGeneralData
    {
        public int EmergencyCardId { get; set; }

        public CardType CardType { get; set; }

        public bool CardCreated { get; set; }
    }

    public enum CardCompleteStatus
    {
        Submitted,
        Processing,
        Complete,
    }

    public enum CardType
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

    public enum ValidatedCommand
    {
        CompleteCard = 1,
        PrintCard = 2,

    }

    public enum En_ErrorCode
    {
        GENERAL_FAULT = 1,
        UNKNOWN_ACTION = 2,
        NO_FREE_HANDLERS = 3,
        INTERRUPTED_CYCLE = 4,
        DATABASE_FAULT = 5,
        INVALID_CLIENT = 6,
        INTERNAL_ERROR = 7,
        SID_NOT_SPECIFIED = 8,
        NON_INITIALIZED_MANAGERS = 9,
        LOGIN_FAILED = 10,
        LICENSE_ERROR = 11,
        CLIENT_LICENSE_ERROR = 12,
        INVALID_PARAMETERS = 13,

    }

    public enum CallType
    {
        FalseCall = 1,
        ChildPrank = 2,
        Info = 3,
        Card_01 = 4,
        Card_02 = 5,
        Card_03 = 6,
        Card_04 = 7,
        Card_CommServ = 8,
        Repeated = 9,
        Card_AT = 10,
        Psychologist = 13,
        Consultation = 14,
        Interpreter = 15,
        RosOhrana = 16,
        GZHI = 17,
        InterRegional = 18,

    }

    public enum ServiceType
    {
        Service01 = 0,
        Service02 = 1,
        Service03 = 2,
        Service04 = 3,
        ServiceCommServ = 4,
        Service112 = 5,
        ServiceAT = 6,
        ServicePsychologist = 9,
        ServiceConsultation = 10,
        ServiceInterpreter = 11,
        ServiceRosOhrana = 12,

    }

    public enum ImportanceLevel
    {
        NotImportant = 0,
        Important = 1,

    }

    public enum CardSyntheticState
    {
        Request112 = 1,
        ServicesInvolvement = 2,
        ServicesReaction = 3,
        ServicesWork = 4,
        Completed = 5,
        ServicesStart = 6,
        DenialOfService = 7,

    }

    public enum SortingOrder
    {
        ASC = 1,
        DESC = 2,

    }

    public enum PhonogramSource
    {
        Internal = 1,
        External = 2,

    }

    public enum DuplicateStatus
    {
        UnconfirmedDuplicate = 1,
        Duplicate = 2,
        DuplicateFalse = 3,
        UnconfirmedRepeated = 4,
        Repeated = 5,
        RepeatedFalse = 6,

    }

    public enum User03Role
    {
        Operator_03 = 1,
        Dispatcher_03 = 2,

    }

    public enum ReflectionPriorityBy03Reason
    {
        Emergency = 0,
        Immediate = 1,
        Urgent = 2,
        Transportation = 3,
        NoPriority = 4,

    }

    public enum AttachmentType
    {
        IMAGE = 0,
        ACTION = 1,
        STRING = 2,
        PHONE_NUMBER = 3,
        GEOMETRY = 4,
        DOWNLOAD = 5,
        VP_ONLINE_URL = 6,
        VP_ARCHIVE_URL = 7,
        VP_THUMBNAIL = 8,
        PROXY_DOWNLOAD = 9,

    }

    public enum SMSType
    {
        Incoming = 1,
        Outcoming = 2,

    }

    public enum Direction
    {
        Incoming = 1,
        Outcoming = 2,

    }

    public enum SMSStatus
    {
        Sent = 1,
        NotSent = 2,
        Received = 3,
        NotReceived = 4,

    }

    public enum SourceType
    {
        PHONE = 1,
        SMS = 2,
        ERA_GLONASS = 3,
        WITHOUT_CALL = 4,
        SENSORS = 5,
        INTERNET_PORTAL = 6,

    }

    public record CallCenterConnectionInfoModel
    {
        public string? Url { get; set; }
        public string? Description { get; set; }
    }

    public record AttachmentListModel
    {
        public List<AttachmentContentModel>? attachments { get; set; }
    }

    public record AttachmentDataModel
    {
        public string? url;
        public string? postdata;
        public string? value;
        public string? data;
    }

    public record AttachmentContentModel
    {
        public string? name;
        public string? title;
        public AttachmentType type;
        public AttachmentDataModel? data;
    }

    public enum En_ReportFormatType
    {
        pdf = 1,
        xls = 2,
        xlsx = 3,
        docx = 4,
        rtf = 5,

    }

    public enum ExternalInfoType
    {
        Unknown = 0,
        ContentList = 1,
        SpbSvetetsAlert = 2,
        Card112 = 3,

    }

    public record GeographicLocationModel
    {
        public double m_dLatitude { get; set; }
        public double m_dLongitude { get; set; }
    }

    public record CamertonEngineModel
    {
        public int engineId { get; set; }
        public GeographicLocationModel? geographicLocation { get; set; }
        public string? additionalInfo { get; set; }
        public string? iconUrl { get; set; }
    }

    public record CardCommServFilterModel
    {
        public int? nServiceIncidentCategoryId { get; set; }
        public bool? isDeadlineExceeded { get; set; }
    }

    public record Card03FilterModel
    {
        public bool? isTransfered { get; set; }
        public bool? isFilterEngine3 { get; set; }
        public bool? isFilterEngine2 { get; set; }
        public int? nHospitalId { get; set; }
        public int? nStreetId { get; set; }
        public int? nReasonId { get; set; }
        public string? strAge { get; set; }
        public int? nGender { get; set; }
        /// <summary> Id карточки </summary>
        public int? nCardId { get; set; }
    }

    public record Card112FilterModel
    {
        public int? nCardId { get; set; }
        public DateTime dtBeginPeriod { get; set; }
        public DateTime dtEndPeriod { get; set; }
        public string? strPhoneNumber { get; set; }
        public int? nServiceId { get; set; }
        public int? nLocalDistrictId { get; set; }
        public int? nDistrictId { get; set; }
        public int? nStreetId { get; set; }
        public string? strBuilding { get; set; }
        public string? strAgentLogin { get; set; }
        public string? strCallerContactPhone { get; set; }
        public string? strDeclarantLastName { get; set; }
        public int? completeStatus { get; set; }
        public ImportanceLevel? importanceLevel { get; set; }
        public bool? lCompleted { get; set; }
        public bool? isUnwatched { get; set; }
        public string? strIncidentDescription { get; set; }
        public DateTime? dtDeadline { get; set; }
        public bool? isDayly { get; set; }
        public int? nIncidentTypeId { get; set; }
        public bool? isPriority { get; set; }
        public CardCommServFilterModel? CardCommServFilter { get; set; }
        public bool? lTestCard { get; set; }
        public Card03FilterModel? Card03Filter { get; set; }
        public Card02FilterModel? Card02Filter { get; set; }
        public bool? isServiceTypeIdCorrect { get; set; } = true;
        public bool? withEmptyStreet { get; set; }
        public string? strDeclarantName { get; set; }
        public string? strDeclarantMiddleName { get; set; }
        public bool? withEmptyLocalDistrict { get; set; }
        public string? strAdditionalLocationInfo { get; set; }
        /// <summary> Идентификатор района города звонящего </summary>
        public int? nDeclarantLocalDistrictId { get; set; }
        /// <summary> Фильтровать по пустому району города звонящего </summary>
        public bool? withEmptyDeclarantLocalDistrict { get; set; }
        /// <summary> Идентификатор улицы звонящего </summary>
        public int? nDeclarantStreetId { get; set; }
        /// <summary> Фильтровать по пустой улице звонящего </summary>
        public bool? withEmptyDeclarantStreet { get; set; }
        public string? strDeclarantBuildingNumber { get; set; }
        /// <summary> Идентификатор региона </summary>
        public int? nRegionId { get; set; }
        /// <summary> Количество привлеченных экстренных служб </summary>
        public int? nServiceCount { get; set; }
        public bool? control { get; set; }
        /// <summary> Учитывать ли пустой город вместе с фильтром по идентификатору города </summary>
        public bool? withEmptyCity { get; set; }
        public bool? wasInDenialOfService { get; set; }
        public List<int>? nCallTypeIds { get; set; }
        public List<int>? nSourceTypeIds { get; set; }
        /// <summary> список идентификаторов статусов карточек </summary>
        public List<int>? nCardSyntheticStateIds { get; set; }
        /// <summary> список идентификаторов привлечённых отделений службы </summary>
        public List<int>? nDepartmentIds { get; set; }
        /// <summary> список типов вызовов </summary>
        public List<int>? nIncidentTypeIds { get; set; }
        /// <summary> районы </summary>
        public List<int>? cityIds { get; set; }
        /// <summary> Источники для исключения из списка </summary>
        public List<int>? excludeExternalCreatorsList { get; set; }
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
        public ValidatedCommand? CommandProperty { get; set; }
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
        public En_Command? DefaultCommand { get; set; }
        /// <summary> Дополнительная команда кнопки </summary>
        public En_Command? AdditionalCommand { get; set; }
    }

    public enum En_Command
    {
        SaveCardWithTransferCommand = 0,
        InitConferenceCommand = 1,

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
        public ImportanceLevel? ImportanceLevelDefaultValue { get; set; }
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
        public ServiceType? ServiceType { get; set; }
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
        public List<OperatorCanEditItemModel>? OperatorCanEditCllection { get; set; }
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

    public enum CallStatus
    {
        TransferedTo01 = 0,
        TransferedTo02 = 1,
        TransferedTo03 = 2,
        TransferedTo04 = 3,
        TransferedToAT = 4,
        TransferedToCommServ = 5,
        TerminatedByOperator = 6,
        TerminatedByAbonent = 7,

    }

    public record EmergencyCardModel
    {
        public Card112Model card112 { get; set; }
        public Card01Model card01 { get; set; }
        public Card02Model card02 { get; set; }
        public Card03Model card03 { get; set; }
        public Card04Model card04 { get; set; }
        public CardATModel cardAT { get; set; }
        public CardCommServModel cardCommServ { get; set; }
    }

    public record OperatorCanEditItemModel
    {
        public CardType Card { get; set; }
        public En_ServiceCardEditView View { get; set; }
        public bool CanComplete { get; set; }
        public bool CanChangeState { get; set; }
    }

    public enum En_ServiceCardEditView
    {
        ///<summary>Карточка 01 как у ДДС 01</summary>
        Card01View = 1,
        ///<summary>Карточка 01 Санкт-Петербург для просмотра</summary>
        Card01SpbView = 2,
        ///<summary>Карточка 01 Санкт-Петербург для редактирования</summary>
        Card01SpbEditView = 3,
        ///<summary>Карточка 02 как у ДДС 02</summary>
        Card02View = 4,
        ///<summary>Карточка 02 Санкт-Петербург для просмотра</summary>
        Card02SpbView = 5,
        ///<summary>Карточка 02 Санкт-Петербург для редактирования</summary>
        Card02SpbEditView = 6,
        ///<summary>Карточка 02 'Интеграция' для редактирования</summary>
        Card02IntegrationView = 21,
        ///<summary>Карточка 03 как у Диспетчера 03</summary>
        Card03DispatcherView = 7,
        ///<summary>Карточка 03 Санкт-Петербург для просмотра</summary>
        Card03SpbView = 8,
        ///<summary>Карточка 03 Санкт-Петербург для редактирования</summary>
        Card03SpbEditView = 9,
        ///<summary>Карточка 03 только добавление пострадавших</summary>
        Card03AddVictimsView = 11,
        ///<summary>Карточка 04 как у ДДС 04</summary>
        Card04View = 12,
        ///<summary>Карточка 04 Санкт-Петербург для просмотра</summary>
        Card04SpbView = 13,
        ///<summary>Карточка 04 Санкт-Петербург для редактирования</summary>
        Card04SpbEditView = 14,
        ///<summary>Карточка ЖКХ/ЕДДС как у ДДС ЖКХ/ЕДДС</summary>
        CardCommServView = 15,
        ///<summary>Карточка ЖКХ/ЕДДС Санкт-Петербург для просмотра</summary>
        CardCommServSpbView = 16,
        ///<summary>Карточка ЖКХ/ЕДДС Санкт-Петербург для редактирования</summary>
        CardCommServSpbEditView = 17,
        ///<summary>Карточка АТ как у ДДС АТ</summary>
        CardATView = 18,
        ///<summary>Карточка АТ Санкт-Петербург для просмотра</summary>
        CardATSpbView = 19,
        ///<summary>Карточка АТ Санкт-Петербург для редактирования</summary>
        CardATSpbEditView = 20,

    }

    public record EmergencyServersCollectionModel
    {
        public List<EmergencyServerInfoModel>? emergencyServers { get; set; }
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
        public short temperature { get; set; }
        public short pressure { get; set; }
        public byte clouds { get; set; }
        public byte windDirection { get; set; }
        public short windStrength { get; set; }
        public short humidity { get; set; }
    }

    public record WeatherLayerModel
    {
        public long id { get; set; }
        public string? description { get; set; }
        public double? longitude { get; set; }
        public double? latitude { get; set; }
        public WeatherModel? weather { get; set; }
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
        public int? nameId { get; set; }
        /// <summary> Идентификатор службы </summary>
        public int nServiceTypeId { get; set; }
        /// <summary> Идентификатор состояния кастомной службы </summary>
        public int? stateId { get; set; }
        /// <summary> Дата привлечения кастомной службы </summary>
        public DateTime? dateInvolve { get; set; }
        /// <summary> Данные карточки кастомной службы </summary>
        public CustomServiceDataModel data { get; set; }
    }

    public record CustomServiceDataModel
    {
        /// <summary> Вид выезда </summary>
        public int? nIncidentTypeId { get; set; }
        /// <summary> Комментарий </summary>
        public string? additionalInfo { get; set; }
        /// <summary> Принятые меры </summary>
        public string? performActions { get; set; }
        /// <summary> Выезд на место </summary>
        public DateTime? dtServiceCardWork { get; set; }
        /// <summary> Прибытие на место </summary>
        public DateTime? dtServiceCardWorkNext { get; set; }
        /// <summary> Время закрытия сервисной карточки </summary>
        public DateTime? dtServiceCardComplete { get; set; }
        /// <summary> Время просмотра карточки </summary>
        public DateTime? dtServiceCardView { get; set; }
        /// <summary> Коллекция задействованных бригад </summary>
        public List<int>? departmentIds { get; set; }
    }

    public record CardCustomServiceModel
    {
        /// <summary> Идентификатор службы </summary>
        public int serviceTypeId { get; set; }
        /// <summary> Доп. информация </summary>
        public MetaFieldsModel? metaFields { get; set; }
        /// <summary> Список кастомных полей службы </summary>
        public CustomFieldsModel? customFields { get; set; }
    }

    public record MetaFieldsModel
    {
        /// <summary> Идентификатор состояния кастомной службы </summary>
        public int? stateId { get; set; }
        /// <summary> Дата привлечения кастомной службы </summary>
        public DateTime? dateInvolve { get; set; }
    }

    public record CustomFieldsModel
    {
        /// <summary> Список логических полей </summary>
        public List<BoolFieldModel>? boolFields { get; set; }
        /// <summary> Список целочисленных полей </summary>
        public List<IntFieldModel>? intFields { get; set; }
        /// <summary> Список строковых полей </summary>
        public List<StringFieldModel>? stringFields { get; set; }
        /// <summary> Список полей с выпадающим списком </summary>
        public List<ComboFieldModel>? comboFields { get; set; }
        /// <summary> Список полей с датой/временем </summary>
        public List<DateTimeFieldModel>? dateTimeFields { get; set; }
        /// <summary> Список таблиц </summary>
        public List<TableModel>? tables { get; set; }
    }

    public record BoolFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int templateId { get; set; }
        /// <summary> Значение </summary>
        public bool? value { get; set; }
    }

    public record IntFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int templateId { get; set; }
        /// <summary> Значение </summary>
        public int? value { get; set; }
    }

    public record StringFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int templateId { get; set; }
        /// <summary> Значение </summary>
        public string? value { get; set; }
    }

    public record ComboFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int templateId { get; set; }
        /// <summary> Значение </summary>
        public int? value { get; set; }
    }

    public record DateTimeFieldModel
    {
        /// <summary> Идентификатор шаблона поля </summary>
        public int templateId { get; set; }
        /// <summary> Значение </summary>
        public DateTime? value { get; set; }
    }

    public record TableModel
    {
        /// <summary> Идентификатор шаблона таблицы </summary>
        public int templateId { get; set; }
        /// <summary> Список столбцов с логическим значением </summary>
        public List<BoolColumnModel>? boolColumns { get; set; }
        /// <summary> Список столбцов с целочисленным значением </summary>
        public List<IntColumnModel>? intColumns { get; set; }
        /// <summary> Список столбцов со строковым значением </summary>
        public List<StringColumnModel>? stringColumns { get; set; }
        /// <summary> Список столбцов с датой/временем </summary>
        public List<DateTimeColumnModel>? dateTimeColumns { get; set; }
        /// <summary> Список столбцов с выпадающим списком </summary>
        public List<ComboColumnModel>? comboColumns { get; set; }
    }

    public record BoolColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int templateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<BoolCellModel>? values { get; set; }
    }

    public record BoolCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int id { get; set; }
        /// <summary> Значение </summary>
        public bool? value { get; set; }
    }

    public record StringColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int templateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<StringCellModel>? values { get; set; }
    }

    public record StringCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int id { get; set; }
        /// <summary> Значение </summary>
        public string? value { get; set; }
    }

    public record IntColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int templateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<IntCellModel>? values { get; set; }
    }

    public record IntCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int id { get; set; }
        /// <summary> Значение </summary>
        public int? value { get; set; }
    }

    public record DateTimeColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int templateId { get; set; }
        /// <summary> Список значений стобца </summary>
        public List<DateTimeCellModel>? values { get; set; }
    }

    public record DateTimeCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int id { get; set; }
        /// <summary> Значение </summary>
        public DateTime? value { get; set; }
    }

    public record ComboColumnModel
    {
        /// <summary> Идентификатор шаблона ячейки столбца </summary>
        public int templateId;
        /// <summary> Список значений стобца </summary>
        public List<ComboCellModel>? values { get; set; }
    }

    public record ComboCellModel
    {
        /// <summary> Идентификатор ячейки </summary>
        public int id { get; set; }
        /// <summary> Значение </summary>
        public int? value { get; set; }
    }

    public record ServiceEventModel
    {
        public int serviceTypeId { get; set; }
        public bool opened { get; set; }
    }

    public record MetaDataModel
    {
        public ReplicationMetaDataModel? replication { get; set; }
        /// <summary> Список событий службы </summary>
        public List<ServiceEventModel>? serviceEvents { get; set; }
    }

    public record ReplicationTargetInfoModel
    {
        public int replicationTargetId { get; set; }
        public string? replicationTargetName { get; set; }
        public bool isDelivered { get; set; }
    }

    public record ReplicationMetaDataModel
    {
        public bool isDelivered { get; set; }
        /// <summary> Список информации о доставке по каждому направлению. </summary>
        public List<ReplicationTargetInfoModel>? targetsInfo { get; set; }
    }

    public record RegionAdditionalInfoModelFromGenerated
    {
        public int nId { get; set; }
        public bool? autocomplete { get; set; }
    }

    public record PhoneBookDictionaryModel
    {
        public int id { get; set; }
        public int regionId { get; set; }
        public int commTypeId { get; set; }
        public int commPhoneId { get; set; }
        public string? phoneNumber { get; set; }
        public bool? deleted { get; set; }
    }

    public record RegionDataModel
    {
        public string? strRegistrationDepartment { get; set; }
        public DateTime? dtRegDate { get; set; }
        public DateTime? dtDepartmentTransfer { get; set; }
        public string? strDenialOfServiceReason { get; set; }
    }

    public record MNISReactionModel
    {
        public List<MNISReactionItemModel>? reaction { get; set; }
    }

    public record MNISReactionItemModel
    {
        public List<MNISEventModel>? events { get; set; }
    }

    public record MNISEventModel
    {
        public string? resource { get; set; }
        public MNISEventType? eventType { get; set; }
        public DateTime? eventTime { get; set; }
        public string? eventName { get; set; }
    }

    public enum MNISEventType
    {
        Other = 0,
        Accepted = 1,
        Departure = 2,
        OnTheWay = 3,
        WayIncedent = 4,
        TrafficDelay = 5,
        Reject = 6,
        Redirect = 7,
        Arrived = 8,
        Deployment = 9,
        Performance = 10,
        Completed = 11,
        Undeployment = 12,
        Retuning = 13,
        Comeback = 14,
        ArrivalToBase = 15,
        Closed = 16,

    }

    public record Vehicle03InfoModel
    {
        public string? vehicleId { get; set; }
        public DateTime? dtInvolve { get; set; }
    }

    public class Vehicle01InfoModel
    {
        public string? vehicleId { get; set; }
        public DateTime? latestEventTime { get; set; }
        public MNISEventType? latestEventType { get; set; }
    }

    public enum VehicleInfoSourceName
    {
        MNIS = 1,
        RNIS = 2,

    }

    public record VehicleArrivalModel
    {
        public string? externalVehicleId { get; set; }
        public GeoPointModelFromGenerated? currentLocation { get; set; }
        public int? estimatedTravelTimeMinutes { get; set; }
        public DateTime? estimatedArrivalTime { get; set; }
        public string? stateRegNumber { get; set; }
    }

    public record ArrivalInfoModel
    {
        public GeoPointModelFromGenerated? destination { get; set; }
        public List<VehicleArrivalModel>? vehiclesArrival { get; set; }
    }

    public record VehicleTrackInfoModel
    {
        public GeoPointModelFromGenerated? coords { get; set; }
        public string? stateRegNumber { get; set; }
    }

    public enum En_MapType
    {
        /// <summary> Protei GEO server </summary>
        Protei = 3,
        /// <summary> IAC GIS </summary>
        IAC = 5,
        /// <summary> ArcGIS rest API </summary>
        ArcGIS = 6,
        /// <summary> External map view with PPPUR integration by chrome webdriver </summary>
        ChromeBrowserPppur = 7,

    }

    public enum En_CallCenterProviderType
    {
        NotSet = 0,
        Protei = 1,
        Avaya7 = 3,
        ProteiEACD3 = 4,
        EmergencyServer = 5,
        GridBookServer = 6,
        ProteiEACDWPServer = 7,

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
        public En_MapType MapManufacturer { get; set; }
    }

    public record MapTileUrlModelFromGenerated
    {
        public string? Url { get; set; }
        public En_MapType? MapManufacturer { get; set; }
        public string? HomeCity { get; set; }
    }

    public record CallCenterSettingsModel
    {
        public En_CallCenterProviderType CallCenterProvider { get; set; }
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
        public User03Role? User03Role { get; set; }
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

        public long nCallId { get; set; }
        public string? extCallId { get; set; }
        public string? extCallId2 { get; set; }
        public string? strCdPN { get; set; }
        public string? strCgPN { get; set; }
        public int nCategory { get; set; }
        public string? GatewayIPAddr { get; set; }
        public string? ESGlobalID { get; set; }
        public ExternalInfoType externalInfoType { get; set; }
        public int? ccRegionID { get; set; }
        public string? visitedNetworkId { get; set; }
        public SMSDataModel? smsData { get; set; }
        public string? resultInfo { get; set; }
        public int? callDuration { get; set; }
        public Direction? callDirection { get; set; }
        public int? distributeDuration { get; set; }
        public List<string>? externalInfo { get; set; }

    }

    public record SMSDataModel
    {

        /// <summary> Текст сообщения </summary>
        public string? strMessageText { get; set; }
        /// <summary> Тип СМС (входящее, исходящее) </summary>
        public SMSType? smsType { get; set; }
        /// <summary> Статус СМС (отправлено, получено) </summary>
        public SMSStatus? smsStatus { get; set; }
        /// <summary> SMPP Id </summary>
        public string? strSMPPId { get; set; }
        /// <summary> Идентификатор СМС для Авая </summary>
        public int? nSmsId { get; set; }

    }

    public record IncidentTypeRecordModel
    {

        public int nIncidentTypeId { get; set; }
        public int? callTypeId { get; set; }
        public int? regionId { get; set; }
        public bool deleted { get; set; }
        public List<int>? ServiceTypeIds { get; set; }

    }

    public record ServiceIncidentTypeRecordModel
    {

        public int nId { get; set; }
        public string? strValue { get; set; }
        public int? nIncidentTypeId { get; set; }
        public string? additionalInfo { get; set; }
        public bool deleted { get; set; }
        public List<int>? auxIncidentIds { get; set; }

    }

    public record ServiceDeadlinesModel
    {

        public int serviceTypeId { get; set; }
        public int? serviceCreateTimeout { get; set; }


    }

    public record ReplicationTargetModel
    {

        public int replicationTargetId { get; set; }
        public string? replicationServiceName { get; set; }
        public int? replicationTargetServiceTypeId { get; set; }


    }

    public record Card112ListModel
    {

        public int total { get; set; }
        public List<Card112Model>? cardList { get; set; }


    }

    public record Tm_ISharerDescriptionModel
    {

        /// <summary> На вид </summary>
        public string? strInLooksAge { get; set; }
        /// <summary> Рост </summary>
        public int? nStatureID { get; set; }
        /// <summary> Телосложение </summary>
        public int? nFigureID { get; set; }
        /// <summary> Рост </summary>
        public string? strStature { get; set; }
        /// <summary> Телосложение </summary>
        public string? strFigure { get; set; }
        /// <summary> Одет </summary>
        public string? strExterior { get; set; }
        /// <summary> Особые приметы </summary>
        public string? strExtra { get; set; }
        /// <summary> Пол </summary>
        public int? nGender { get; set; }
        /// <summary> Фамилия </summary>
        public string? strLastName { get; set; }
        /// <summary> Имя </summary>
        public string? strFirstName { get; set; }
        /// <summary> Отчество </summary>
        public string? strMiddleName { get; set; }
        /// <summary> Дата рождения </summary>
        public DateTime? dtBirthday { get; set; }


    }

    public record Tm_IVehicleDescriptionModel
    {

        /// <summary> Производитель </summary>
        public string? strVendor { get; set; }
        /// <summary> Модель </summary>
        public string? strName { get; set; }
        /// <summary> Цвет </summary>
        public string? strColor { get; set; }
        /// <summary> Тип ТС из классификатора </summary>
        public string? strType { get; set; }
        /// <summary> Цвет ТС из классификатора </summary>
        public int? nColorID { get; set; }
        /// <summary> Тип ТС из классификатора </summary>
        public int? nTypeID { get; set; }
        /// <summary> Особые приметы </summary>
        public string? strExtra { get; set; }
        /// <summary> Номер </summary>
        public string? strRegistrationNumber { get; set; }
        /// <summary> Регион </summary>
        public string? strRegion { get; set; }
        /// <summary> Скрылось с места происшествия </summary>
        public bool lHided { get; set; }


    }

    public record Tm_IVictimDescriptionModel
    {

        /// <summary> Фамилия </summary>
        public string? strLastName { get; set; }
        /// <summary> Отчество </summary>
        public string? strMiddleName { get; set; }
        /// <summary> Имя </summary>
        public string? strFirstName { get; set; }
        /// <summary> Телефон </summary>
        public string? strContactPhone { get; set; }
        /// <summary> Доп. инфо </summary>
        public string? strAdditionalInfo { get; set; }
        /// <summary> Id района </summary>
        public int? nCityId { get; set; }
        /// <summary> Id улицы </summary>
        public int? nStreetId { get; set; }
        /// <summary> Телосложение </summary>
        public string? strBuildingNumber { get; set; }
        /// <summary> Корпус </summary>
        public string? strCorps { get; set; }
        /// <summary> Квартира </summary>
        public string? strFlat { get; set; }

    }

    public record TaskForceItemModel
    {

        public int ovdServiceId { get; set; }
        public string? lastName { get; set; }

    }

    public record Card02FilterModel
    {

        /// <summary> КУСП ОВД </summary>
        public string? strInstrinsicOvd { get; set; }
        /// <summary> КУСП ДПС </summary>
        public string? strInstrinsicDps { get; set; }
        /// <summary> Фильтровать ли карточки с неуказанной улицей </summary>
        public bool? isFilterEmptyStreet { get; set; }
        /// <summary> Id улицы </summary>
        public int? nStreetId { get; set; }
        /// <summary> Квалификация ОВД </summary>
        public int? nITypeId { get; set; }
        /// <summary> Id карточки </summary>
        public int? nCardId { get; set; }
        /// <summary> Фамилия заявителя </summary>
        public string? strDeclarantLastName { get; set; }

    }

    public record Tm_DictionaryItemModel
    {

        public int nId { get; set; }
        public string? strValue { get; set; }
        public string? extId { get; set; }
        public bool deleted { get; set; }
        public string? strDescription { get; set; }

    }

    public record DCRecordModel
    {

        public int districtId { get; set; }
        public int cityId { get; set; }
        public bool deleted { get; set; }

    }

    public record SDCRecordModel
    {

        public int streetId { get; set; }
        public int districtId { get; set; }
        public int cityId { get; set; }
        public bool deleted { get; set; }

    }

    public record CardStateDescStructModel
    {

        public int _id { get; set; }
        public string? _name { get; set; }
        public int? _nextid { get; set; }
        public int? _previd { get; set; }
        public int? _standardMinutes { get; set; }

    }

    public record CardSyntheticStateModel
    {

        public int _id { get; set; }
        public string? _name { get; set; }
        public int _color_r { get; set; }
        public int _color_g { get; set; }
        public int _color_b { get; set; }

    }

    public record Tm_SubCallTypeItemModel
    {

        public int nId { get; set; }
        public int nCallTypeId { get; set; }
        public int nCityId { get; set; }
        public string? strGroupNumber { get; set; }
        public string? description { get; set; }

    }

    public record FieldConstraintModel
    {

        public string? name { get; set; }
        public int size { get; set; }


    }

    public record ObjectStructModel
    {

        public int _ID { get; set; }
        public string? _name { get; set; }
        public int? _streetID { get; set; }
        public int _cityID { get; set; }
        public int _districtID { get; set; }
        public string? _building { get; set; }
        public string? _corps { get; set; }
        public bool _gasified { get; set; }
        public int _baseClassID { get; set; }
        public int _departmentID { get; set; }
        public int? _typeID { get; set; }
        public bool _deleted { get; set; }
        public List<int>? _fireReactionPlanIDs { get; set; }

    }

    public record FireObjectRangeStructModel
    {

        public int _ID { get; set; }
        public string? _name { get; set; }
        public int? _streetID { get; set; }
        public int _cityID { get; set; }
        public int _districtID { get; set; }
        public int _departmentID { get; set; }
        public int? _buildingFrom { get; set; }
        public int? _buildingTo { get; set; }
        public int? _odd { get; set; }
        public List<int>? _fireReactionPlanIDs { get; set; }

    }

    public record FireReactionPlanItemStructModel
    {

        public int _ID { get; set; }
        public int _fireRectionPlanID { get; set; }
        public int _fireEngineTypeID { get; set; }
        public string? _fireEngineType { get; set; }
        public int _fireDepartmentID { get; set; }
        public int _count { get; set; }
        public int _order { get; set; }
        public int _fireClassID { get; set; }

    }

    public record FireReactionPlanStructModel
    {

        public int _ID { get; set; }
        public string? _name { get; set; }
        public int _departmentID { get; set; }
        public List<FireReactionPlanItemStructModel>? _items { get; set; }


    }

    public record MalefactionStructModel
    {

        public int _ID { get; set; }
        public string? _name { get; set; }
        public int _code { get; set; }


    }

    public record MalefactionGroupStructModel
    {

        public int _ID { get; set; }
        public string? _name { get; set; }
        public int _code { get; set; }
        public List<MalefactionStructModel>? _items { get; set; }


    }

    public record Tm_SnapshotDataModel
    {

        public int nId { get; set; }
        public string? strModifier { get; set; }
        public DateTime dtModified { get; set; }
        public int nCardId { get; set; }
        public int nCardTypeId { get; set; }
        public int nVersion { get; set; }
        public string? strModifications { get; set; }


    }


    public record CustomServiceCardTemplateModel
    {

        /// <summary> Идентификатор шаблона внешнего вида карточки </summary>
        public int id { get; set; }
        /// <summary> Список полей </summary>
        public List<FieldInfoModel>? fields { get; set; }


    }

    public record ServiceTypeIdToCustomServiceCardTemplateModel
    {

        /// <summary> Идентификатор службы </summary>
        public int serviceTypeId { get; set; }
        /// <summary> Идентификатор шаблона поля </summary>
        public int templateId { get; set; }


    }

    public record FieldInfoModel
    {

        /// <summary> Идентификатор шаблона поля </summary>
        public int templateId { get; set; }
        /// <summary> Тип шаблона </summary>
        public En_TemplateType templateType { get; set; }
        /// <summary> Порядок поля </summary>
        public int order { get; set; }


    }

    public record ControlTemplateModel
    {

        /// <summary> Идентификатор шаблона поля </summary>
        public int id { get; set; }
        /// <summary> Название поля </summary>
        public string? name { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? isDeleted { get; set; }


    }

    public record ComboControlTemplateModel
    {

        /// <summary> Идентификатор шаблона поля </summary>
        public int id { get; set; }
        /// <summary> Название поля </summary>
        public string? name { get; set; }
        /// <summary> Id источника данных </summary>
        public int dataSetId { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? isDeleted { get; set; }


    }

    public record DateTimeControlTemplateModel
    {

        /// <summary> Идентификатор шаблона поля </summary>
        public int id { get; set; }
        /// <summary> Название поля </summary>
        public string? name { get; set; }
        /// <summary> Формат поля </summary>
        public DateTimeFormat format { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? isDeleted { get; set; }


    }

    public record TableControlTemplateModel
    {

        /// <summary> Идентификатор шаблона поля </summary>
        public int id { get; set; }
        /// <summary> Название таблицы </summary>
        public string? name { get; set; }
        /// <summary> Id списка столбцов </summary>
        public int columnsSetId { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? isDeleted { get; set; }


    }

    public record ColumnsSetModel
    {

        /// <summary> Идентификатор набора столбцов </summary>
        public int id { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? isDeleted { get; set; }
        /// <summary> Список столбцов </summary>
        public List<ColumnInfoModel>? columns { get; set; }


    }

    public record ColumnInfoModel
    {

        /// <summary> Идентификатор шаблона столбца </summary>
        public int templateId { get; set; }
        /// <summary> Тип шаблона </summary>
        public En_TemplateType templateType { get; set; }
        /// <summary> Порядок столбца </summary>
        public int order { get; set; }


    }

    public record DataSetModel
    {

        /// <summary> Идентификатор набора данных </summary>
        public int id { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? isDeleted { get; set; }
        /// <summary> Набор значений </summary>
        public List<DataSetItemModel>? items { get; set; }


    }

    public record DataSetItemModel
    {

        /// <summary> Идентификатор значения в наборе данных </summary>
        public int id { get; set; }
        /// <summary> Значение </summary>
        public string? value { get; set; }
        /// <summary> Признак того, что запись удалена </summary>
        public bool? isDeleted { get; set; }


    }

    public enum En_TemplateType
    {
        Bool = 0,
        Int = 1,
        String = 2,
        DateTime = 3,
        Combo = 4,
        Table = 5,

    }

    public enum DateTimeFormat
    {
        Date = 0,
        DateTime = 1,

    }

    public record BasicDictionariesModel
    {

        public List<Tm_DictionaryItemModel>? CallTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? ServiceTypeDictionary { get; set; }
        public List<Tm_SubCallTypeItemModel>? SubCallTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? CallTypeNumberDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? AdditionalCallTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? DeclarantStatusDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? CCMC_TypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? ObjectTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? FireClassDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? FireReasonDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? FireIncidentTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? Departments01Dictionary { get; set; }
        public List<Tm_DictionaryItemModel>? FireReactionPlanDictionary { get; set; }
        public List<CardStateDescStructModel>? Card01StateDescStructs { get; set; }
        public List<FireObjectRangeStructModel>? FireObjectRangeStructs { get; set; }
        public List<FireReactionPlanStructModel>? FireReactionPlanStructs { get; set; }
        public List<Tm_DictionaryItemModel>? FireBarrelTypes { get; set; }
        public List<Tm_DictionaryItemModel>? FireExtinguisherTypes { get; set; }
        public List<Tm_DictionaryItemModel>? WaterSources { get; set; }
        public List<Tm_DictionaryItemModel>? FirePreventionTypes { get; set; }
        public List<Tm_DictionaryItemModel>? FireRoles { get; set; }
        public List<Tm_DictionaryItemModel>? FireIncidentGroupDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? Departments02Dictionary { get; set; }
        public List<Tm_DictionaryItemModel>? OVDServiceDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? ITypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? ITypeDetailedDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? StatureDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? FigureDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? StatusDictionary { get; set; }
        public List<CardStateDescStructModel>? Card02StateDescStructs { get; set; }
        public List<MalefactionGroupStructModel>? MalefactionGroupStructs { get; set; }
        public List<Tm_DictionaryItemModel>? OvdPastEvents { get; set; }
        public List<Tm_DictionaryItemModel>? OvdDepartureResults { get; set; }
        public List<Tm_DictionaryItemModel>? Departments03Dictionary { get; set; }
        public List<Tm_DictionaryItemModel>? ReasonDictionary { get; set; }
        public List<CardStateDescStructModel>? Card03StateDescStructs { get; set; }
        public List<Tm_DictionaryItemModel>? DiagnosisDictionary { get; set; }
        public List<HospitalModel>? Hospitals { get; set; }
        public List<Tm_DictionaryItemModel>? TransportationTypesDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? Card03TransportReasonDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? GasServicesDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? GasServiceSituationsDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? GasSituationInstructions { get; set; }
        public List<Tm_DictionaryItemModel>? DepartmentsCommServDictionary { get; set; }
        public List<CardStateDescStructModel>? CardCommServStateDescStructs { get; set; }
        public List<Tm_DictionaryItemModel>? IncidentCommServCategoryDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? CardCommServUKDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? IncidentCommServObjectTypeDictionary { get; set; }
        public List<IntMapItemModel>? IncidentCommServType2ObjectTypeMap { get; set; }
        public List<Tm_DictionaryItemModel>? CityDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? DistrictDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? StreetDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? RegionDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? LocalDistrictDictionary { get; set; }
        public List<RegionAdditionalInfoModelFromGenerated>? RegionsAdditionalInfo { get; set; }
        public List<Tm_DictionaryItemModel>? IncidentTypeDictionary { get; set; }
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
        public List<Tm_DictionaryItemModel>? LanguageDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? sourceTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? VehicleTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? Card03WhoCalledDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? ExternalCreatorsDictionary { get; set; }
        public List<ServiceDeadlinesModel>? ServiceDeadlinesDictionary { get; set; }
        public List<FieldConstraintModel>? Tm_Card_02_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_Card_03_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_Card_OVD_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_Card_04_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_Card_AT_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_Card_CommServ_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_FireFighterCard_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_ISharerDescription_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_IVehicleDescription_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_IVictimDescription_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_Card_112_Constraints { get; set; }
        public List<FieldConstraintModel>? Tm_Call_History_Constraints { get; set; }
        public List<Tm_DictionaryItemModel>? customServiceIncidentType { get; set; }
        public List<Tm_DictionaryItemModel>? customServiceDepartment { get; set; }
        public List<Tm_DictionaryItemModel>? ServiceType2CustomServiceTypeDictionary { get; set; }
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
        public List<Tm_DictionaryItemModel>? CommunicationTypeDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? CommunicationPhonesDictionary { get; set; }
        public List<PhoneBookDictionaryModel>? PhoneBookDictionary { get; set; }
        public List<Tm_DictionaryItemModel>? PerformActionsTypeDictionary { get; set; }


    }

    public record CardMessageModelFromGenerated
    {

        public int? serviceTypeId { get; set; }
        public int nID { get; set; }
        public string? strCreator { get; set; }
        public int nEmergencyCardID { get; set; }
        public int? nDepartmentID { get; set; }
        public string? strMessage { get; set; }
        public bool isServiceMessage { get; set; }
        public DateTime dtCreate { get; set; }


    }

    public record DepartmentModelFromGenerated
    {

        public int m_nID { get; set; }
        public string? m_strName { get; set; }
        public GeographicLocationModel? m_GeographicLocation { get; set; }
        public int m_nDistrictID { get; set; }
        public List<EngineModel>? m_Engines { get; set; }


    }

    public record EngineModel
    {

        public int nID { get; set; }
        public int nDepartmentID { get; set; }
        public string? strNumber { get; set; }
        public int? nStateID { get; set; }
        public int? nShiftReportStateID { get; set; }
        public int? nEmergencyCardID { get; set; }
        public int? nEmergencyCardImportnaceLevelID { get; set; }
        public Engine03AdditionalInfoModel? engine03AdditionalInfo { get; set; }


    }

    public record Engine03AdditionalInfoModel
    {

        public int nProfileID { get; set; }
        /// <summary> Врач </summary>
        public int? nPrimarySpecialistID { get; set; }
        /// <summary> Фельдшер </summary>
        public int? nSecondarySpecialistID { get; set; }
        /// <summary> Санитар </summary>
        public int? nOrderlyID { get; set; }
        /// <summary> Начало смены </summary>
        public DateTime dtShiftBegin { get; set; }
        /// <summary> Конец смены </summary>
        public DateTime dtShiftEnd { get; set; }
        public DateTime dtShiftBeginReal { get; set; }
        public DateTime dtWorkBegin { get; set; }
        public DateTime dtLastAction { get; set; }
        public int? nCityID { get; set; }
        public int? nDistrictID { get; set; }
        public int? nStreetID { get; set; }
        public string? strBuilding { get; set; }
        public string? strCorps { get; set; }
        public string? strRoom { get; set; }
        public DateTime dtEmergencyCardCreate { get; set; }
        public int? nCallCount { get; set; }


    }

    public record Tm_DepartmentStatePairModel
    {

        public int departmentID { get; set; }
        public int stateID { get; set; }


    }

    public record CardDepartmentStateModel
    {

        public int id { get; set; }
        public DateTime modified { get; set; }
        public DateTime action { get; set; }
        public int departmentID { get; set; }
        public int cardStateDescID { get; set; }
        public int? serviceTypeId { get; set; }
        public string? strMessage { get; set; }


    }

    public record DepartmentStateHistoryModel
    {

        public int activeState { get; set; }
        public List<CardDepartmentStateModel>? stateHistory { get; set; }


    }

    public record DepartmentInvolvedFilterModel
    {

        public int? wantsServiceTypeId { get; set; }


    }

    public record DepartmentStateChangedFilterModel
    {

        public int? wantsServiceTypeId { get; set; }


    }

    public record RequestedEnginesListChangedFilterModel
    {

        public int? wantsServiceTypeId { get; set; }
        public int wantsEmergencyCardID { get; set; }


    }

    public record CardCurrentStatesInDepartmentsChangedFilterModel
    {

        public int? wantsServiceTypeId { get; set; }
        public int wantsEmergencyCardID { get; set; }


    }

    public record CardMessageListChangedFilterModel
    {

        public int? wantsServiceTypeId { get; set; }
        public int wantsEmergencyCardID { get; set; }


    }

    public record BroadcastMessageFilterModel
    {

        public int? wantsServiceTypeId { get; set; }
        public List<int>? wantsDepartmentIDs { get; set; }


    }

    public record ShiftReportChangedFilterModel
    {

        public int? wantsServiceTypeId { get; set; }

    }

    public record CardAdditionalInfoAddedFilterModel
    {

        public int cardId { get; set; }


    }

    public enum CardEventType
    {
        CardCreated = 1,
        CardChanged = 2,

    }

    public record NotificationFiltersModel
    {

        public bool wantsCard01Changed { get; set; }
        public bool wantsCard02Changed { get; set; }
        public bool wantsCard03Changed { get; set; }
        public bool wantsCard04Changed { get; set; }
        public bool wantsCardATChanged { get; set; }
        public bool wantsCardCommServChanged { get; set; }
        public bool wantsCard112Changed { get; set; }
        public bool wantsCard01Created { get; set; }
        public bool wantsCard02Created { get; set; }
        public bool wantsCard03Created { get; set; }
        public bool wantsCard04Created { get; set; }
        public bool wantsCardATCreated { get; set; }
        public bool wantsCardCommServCreated { get; set; }
        public bool wantsCard112Created { get; set; }
        public bool? wantsGlonassCardChanged { get; set; }
        public bool? wantsClientRegistered { get; set; }
        public bool? wantsUpdateRequested { get; set; }
        public bool? wantsActiveCallCenterIndexChanged { get; set; }
        public CardMessageListChangedFilterModel? wantsCardMessageListChangedFilter { get; set; }
        public BroadcastMessageFilterModel? wantsBroadcastMessageFilter { get; set; }
        public DepartmentInvolvedFilterModel? wantsDepartmentInvolvedFilter { get; set; }
        public DepartmentStateChangedFilterModel? wantsDepartmentStateChangedFilter { get; set; }
        public RequestedEnginesListChangedFilterModel? wantsRequestedEnginesListChangedFilter { get; set; }
        public CardCurrentStatesInDepartmentsChangedFilterModel? wantsCardCurrentStatesInDepartmentsChangedFilter { get; set; }
        public ShiftReportChangedFilterModel? wantsShiftReportChangedFilter { get; set; }
        public UpdatingCoordsFilterModel? wantsUpdatingCoordsFilter { get; set; }
        public bool? wantsCamertonEnginesPositionFilter { get; set; }
        public bool? wantsCommServDeadlineExceededFilter { get; set; }
        public CardAdditionalInfoAddedFilterModel? wantsCardAdditionalInfoAddedFilter { get; set; }
        public bool? wantsWeatherLayersChanged { get; set; }
        public bool? wantsAllServiceTypeIdsCardChanged { get; set; }
        public bool? wantsAllServiceTypeIdsCardCreated { get; set; }
        public bool? wantsSmsStatusChanged { get; set; }
        public bool? wantsSmsUpdatedEvent { get; set; }
        public List<int>? wantsServiceTypeIdsCardChanged { get; set; }
        public List<int>? wantsServiceTypeIdsCardCreated { get; set; }


    }

    public record UpdatingCoordsFilterModel
    {

        public int? serviceTypeId { get; set; }


    }

    public record FireBarrelsItemModel
    {

        public int nTypeID { get; set; }
        public int count { get; set; }
        public DateTime? dtSupply { get; set; }


    }

    public record FireExtinguishersItemModel
    {

        public int nTypeID { get; set; }
        public int count { get; set; }
        public DateTime? dtSupply { get; set; }


    }

    public record FireChiefModel
    {

        public string? strName { get; set; }
        public int nJobId { get; set; }
        public DateTime dtArrive { get; set; }


    }

    public record DrillsChiefModel
    {

        public string? strName { get; set; }
        public int nJobId { get; set; }


    }


    public record GdzsUnitModel
    {

        public int nNumOfPeoples { get; set; }
        public int nNumOfMinutes { get; set; }
        public DateTime? dtStartWorking { get; set; }


    }

    public record FireFighterModel
    {

        public string? strName { get; set; }
        public int nJobId { get; set; }


    }

    /// <summary> Больной </summary>
    public record SickPersonModel
    {

        /// <summary> ID пациента </summary>
        public int? nId { get; set; }
        /// <summary> ФИО пациента </summary>
        public string? strName { get; set; }
        /// <summary> Отчество пациента </summary>
        public string? strMiddleName { get; set; }
        /// <summary> Фамилия пациента </summary>
        public string? strLastName { get; set; }
        /// <summary> Приметы пациента </summary>
        public string? strSickPersonSigns { get; set; }
        /// <summary> Пол (мужчина ли) </summary>
        public bool? isMale { get; set; }
        /// <summary> Дата рождения </summary>
        public DateTime? dtBirth { get; set; }
        /// <summary> Возраст лет </summary>
        public int? nAgeYear { get; set; }
        /// <summary> Возраст месяцев </summary>
        public int? nAgeMonth { get; set; }
        /// <summary> Возраст дней </summary>
        public int? nAgeDay { get; set; }
        /// <summary> Причина вызова </summary>
        public int? nReasonId { get; set; }
        /// <summary> Описание причины </summary>
        public string? strReasonTags { get; set; }
        /// <summary> Диагноз консультанта </summary>
        public int? nConsultDiagnosId { get; set; }
        /// <summary> Диагноз ЛПУ </summary>
        public int? nDiagnosId { get; set; }
        /// <summary> Результат обслуживания </summary>
        public int? nResultId { get; set; }
        /// <summary> Причина смерти </summary>
        public string? strDeathCause { get; set; }
        /// <summary> Дефекты оказания помощи </summary>
        public string? strEmcDefects { get; set; }
        /// <summary> Оказаная помощь </summary>
        public string? strEmcAssistance { get; set; }
        /// <summary> Приоритетный ли вызов </summary>
        public bool? isReasonPriority { get; set; }


    }

    public record HospitalModel
    {

        public int nId { get; set; }
        public string? strName { get; set; }
        public string? strSign { get; set; }
        public int? nCityId { get; set; }


    }


    /// <summary> Информация о настройках на компьютере клиента </summary>
    public record SettingsInfoModel
    {

        public User03Role? user03Role { get; set; }
        public int? cityId { get; set; }
        public int? localDistrictId { get; set; }
        public int? regionId { get; set; }
        public int? numberOfForcesAvailableDeps { get; set; }
        public int? currentDepartmentId { get; set; }
        public bool? isRegion { get; set; }
        public int? actualDepartmentID { get; set; }
        public string? wpID { get; set; }
        public string? roleTitle { get; set; }
        public int? sourceZoneId { get; set; }
        public ImportanceLevel? importanceLevelDefaultValue { get; set; }
        public bool? isImportanceLevelEnabled { get; set; }
        public List<int>? nAdditionalCityIds { get; set; }


    }

    public record PcInfoModel
    {

        public string? osName { get; set; }
        public SettingsInfoModel? settingsInfo { get; set; }
        public string? maxDotNetFramework { get; set; }
        public string? missingVcRedistribs { get; set; }
        public string? clientDictionariesCache { get; set; }


    }

    public record VideoQACameraModel
    {

        public int cameraID { get; set; }
        public int operatorID { get; set; }
        public string? manufacturer { get; set; }
        public string? model { get; set; }
        public bool isPtz { get; set; }
        public bool isDigital { get; set; }
        public string? address { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public double azimuth { get; set; }
        public double angle { get; set; }
        public string? codec { get; set; }
        public int resolutionX { get; set; }
        public int resolutionY { get; set; }
        public int fps { get; set; }
        public int bitrate { get; set; }
        public double lostPackets { get; set; }
        public string? ipAddress { get; set; }
        public int streamPort { get; set; }
        public int webPort { get; set; }
        public string? login { get; set; }
        public string? password { get; set; }
        public int state { get; set; }
        public string? gatewayHost { get; set; }
        public string? name { get; set; }


    }

    public record EraGlonassECallLocationModel
    {

        /// <summary> Широта местоположения ТС </summary>
        public long? latitude { get; set; }
        /// <summary> Долгота местоположения ТС </summary>
        public long? longitude { get; set; }
        /// <summary> Достоверность определения местоположения ТС </summary>
        public bool? positionCanBeTrusted { get; set; }
        /// <summary> Момент определения местоположения </summary>
        public string? timestamp { get; set; }


    }

    public record EraGlonassECallIntegrationModel
    {

        /// <summary> Уникальный идентификатор карточки вызова </summary>
        public string? cardId { get; set; }
        /// <summary> Краткий ссылочный идентификатор (КСИ) карточки вызова </summary>
        public int cardShortId { get; set; }
        /// <summary> Идентификатор КВ в СЭР (в случае отправки уточненной КВ) </summary>
        public string? esgCardId { get; set; }
        /// <summary> Язык общения с заявителем </summary>
        public string? declarantLanguageCode { get; set; }
        /// <summary> Состояние голосового канала между заявителем и оператором </summary>
        public string? voiceChannelState { get; set; }
        /// <summary> Число пострадавших </summary>
        public string? injuredPersons { get; set; }
        /// <summary> Контактный телефонный номер заявителя </summary>
        public string? driverPhone { get; set; }
        /// <summary> ФИО заявителя </summary>
        public string? driverFullName { get; set; }
        /// <summary> Телефонный номер абонентского терминала </summary>
        public string? terminalPhone { get; set; }
        /// <summary> Тип активации (автоматически/вручную) </summary>
        public bool? automaticActivation { get; set; }
        /// <summary> Тип вызова (тестовый/экстренный) </summary>
        public bool? testCall { get; set; }
        /// <summary> Тип ТС </summary>
        public string? vehicleType { get; set; }
        /// <summary> Идентификатор ТС по ISO 3779 </summary>
        public string? vehicleIdentificationNumber { get; set; }
        /// <summary> Тип энергоносителя ТС </summary>
        public string? vehiclePropulsionStorageType { get; set; }
        /// <summary> Время события или создания карточки вызова (с временной зоной) </summary>
        public string? callTimestamp { get; set; }
        /// <summary> Местоположение ТС в момент события </summary>
        public EraGlonassECallLocationModel? vehicleLocation { get; set; }
        /// <summary> Число пассажиров </summary>
        public int? numberOfPassengers { get; set; }
        /// <summary> Оценка тяжести ДТП (0 = низкая вероятность ущерба здоровью людей, 10 = максимальная вероятность) </summary>
        public int? severeCrashEstimate { get; set; }
        /// <summary> Адресная информация о местоположении ТС в текстовом виде </summary>
        public string? locationDescription { get; set; }
        /// <summary> Удар спереди </summary>
        public bool? crashInfoFrontCrash { get; set; }
        /// <summary> Удар слева </summary>
        public bool? crashInfoLeftCrash { get; set; }
        /// <summary> Удар справа </summary>
        public bool? crashInfoRightCrash { get; set; }
        /// <summary> Удар сбоку </summary>
        public bool? crashInfoSideCrash { get; set; }
        /// <summary> Удар сзади </summary>
        public bool? crashInfoRearCrash { get; set; }
        /// <summary> Переворот </summary>
        public bool? crashInfoRollover { get; set; }
        /// <summary> Другой тип происшествия </summary>
        public bool? crashInfoOtherCrashType { get; set; }
        /// <summary> Государственный регистрационный номер ТС </summary>
        public string? vehicleRegistryNumber { get; set; }
        /// <summary> Цвет кузова ТС </summary>
        public string? vehicleBodyColor { get; set; }
        /// <summary> Марка и/или модель ТС </summary>
        public string? vehicleModel { get; set; }
        /// <summary> Направление движения ТС </summary>
        public string? vehicleDirection { get; set; }


    }

    /// <summary> Карты </summary>
    public record MapAddressModel
    {

        public string? country { get; set; }
        public string? region { get; set; }
        public string? city { get; set; }
        public string? district { get; set; }
        public string? street { get; set; }
        public string? localdistrict { get; set; }
        public string? additionalStreet { get; set; }
        public string? house { get; set; }
        public string? building { get; set; }
        public string? floors { get; set; }
        public int? cityId { get; set; }
        public int? districtId { get; set; }
        public int? streetId { get; set; }
        public int? localdistrictId { get; set; }
        public int? additionalStreetId { get; set; }
        public string? invalidStreet { get; set; }
        public string? structure { get; set; }


    }

    public record GeoPointModelFromGenerated
    {

        public double lat { get; set; }
        public double lng { get; set; }


    }

    public record GeoAreaModelFromGenerated
    {

        public GeoPointModelFromGenerated? lowerCorner { get; set; }
        public GeoPointModelFromGenerated? upperCorner { get; set; }
        public string? kind { get; set; }
        public string? text { get; set; }
        public bool isLocality { get; set; }
        public long? iacObject { get; set; }
        public string? floors { get; set; }


    }

    public record CardMarkerInfoModel
    {

        public string? globalId { get; set; }
        public int cardID { get; set; }
        public GeoPointModelFromGenerated? coord { get; set; }
        public int? cardState { get; set; }
        public int? callType { get; set; }
        public string? description { get; set; }
        public bool needToShow { get; set; }


    }

    public record CallHistoryItemModel
    {

        public CallDataModel? callData { get; set; }
        public DateTime callTime { get; set; }
        public string? operatorPin { get; set; }
        public List<PhonogramModel>? phonograms { get; set; }


    }

    public record PhonogramModel
    {

        public string? url { get; set; }
        public DateTime? dtcreate { get; set; }
        public PhonogramSource? sourceType { get; set; }


    }

    public record Card112ListExcelReportParamsModel
    {

        public Card112FilterModel? filter { get; set; }
        public bool? usePaging { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public string? orderBy { get; set; }
        public SortingOrder? sortingOrder { get; set; }
        public List<ColumnModel>? reportColumns { get; set; }


    }

    public record ColumnModel
    {

        public string? header { get; set; }
        public int? serviceTypeId { get; set; }
        public string? fieldName { get; set; }


    }

    public enum LayerType
    {
        FIRES = 1,

    }

    public record IntMapItemModel
    {

        public int id1 { get; set; }
        public int id2 { get; set; }
        public string? strValue { get; set; }

    }

    public record GisServiceGeoObjectModel
    {

        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? geoJsonLocation { get; set; }
        public string? iconUrl { get; set; }
        public string? fillColor { get; set; }
        public string? strokeColor { get; set; }
        public string? pointRadius { get; set; }
        public string? fillOpacity { get; set; }
        public string? strokeOpacity { get; set; }
        public string? strokeWidth { get; set; }
        public LocationModel? location { get; set; }
        public List<GisServiceGeoObjectFieldModel>? fields { get; set; }

    }

    public record GisServiceGeoObjectFieldModel
    {

        public int id { get; set; }
        public string? name { get; set; }
        public string? value { get; set; }

    }

    public record GisServiceLayerModel
    {

        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int? parentId { get; set; }
        public List<GisServiceGeoObjectModel>? geoObjects { get; set; }
        public List<GisServiceLayerModel>? layers { get; set; }

    }

    public record GeometryModel
    {

        public string? type { get; set; }
        public List<double>? coordinates { get; set; }

    }

    public record LocationModel
    {

        public string? type { get; set; }
        public GeometryModel? geometry { get; set; }

    }

    public record DistanceInfoModel
    {

        public double distance { get; set; }

    }

    public record DistanceOnRouteInfoModel
    {

        public double distance { get; set; }
        public List<GeoPointModelFromGenerated>? points { get; set; }

    }

    public record LayersInfoModel
    {
        public bool? withObjects { get; set; }
        public List<GisServiceLayerModel>? layers { get; set; }

    }

    public record GeoObjectsInfoModel
    {
        public bool lastPage { get; set; }
        public long totalCount { get; set; }
        public List<GisServiceGeoObjectModel>? geoObjects { get; set; }

    }

    public record SearchInfoModel
    {

        public bool? withObjects { get; set; }
        public List<GisServiceLayerModel>? layers { get; set; }

    }

}
