namespace Dt.EsApi.Enums
{
    /// <summary>Тип направления передачи вызова</summary>
    public enum CommunicationPhoneType
    {
        /// <summary>Передача вызова по указанному в словарях номеру сервиса или группы</summary>
        DEFAULT = 0,

        /// <summary>Передача вызова на фиксированный номер</summary>
        PSTN_CDPN = 1,

        /// <summary>Передача вызова на номер переводчика</summary>
        TRANSLATOR_CDPN = 3
    }
}