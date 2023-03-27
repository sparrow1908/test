using System;

#nullable enable
namespace Dt.EsApi.Models
{
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
}
