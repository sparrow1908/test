using System;
using AutoMapper;
using Dt.EsApi.Models;
using ServerLogic.Requests.Card_112;
using ServerLogic.Types;
using AutoMapper.Extensions.EnumMapping;

namespace Dt.EsApi.Mapper
{
    public record SnapshotModel
    {
        public int Id { get; init; }
        public string Modifier { get; init; }
        public DateTime Modified { get; init; }
        public int CardId { get; init; }
        public int CardTypeId { get; init; }
        public int Version { get; init; }
        public string? Modifications { get; init; }
    }

    public record UpdateDuplicateStatusModel
    {
        public int EmergencyCardId { get; set; }

        public int? OriginalCardId { get; set; }

        public string GlobalId { get; set; }

        public string OriginalGlobalId { get; set; }

        public DuplicateStatus? DuplicateStatus { get; set; }

        public UpdateDuplicateStatusModel(int emergencyCardId, int? originalCardId, string globalId,
            string originalGlobalId, DuplicateStatus? duplicateStatus)
        {
            EmergencyCardId = emergencyCardId;
            OriginalCardId = originalCardId;
            GlobalId = globalId;
            OriginalGlobalId = originalGlobalId;
            DuplicateStatus = duplicateStatus;
        }
    }

    public enum DuplicateStatus
    {
        Duplicate = 2,
    }

    public interface IDtoMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
    }

    internal class AutoMapperDtoWrapper : IDtoMapper
    {
        private readonly IMapper _mapper;

        public AutoMapperDtoWrapper(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
    }

    public static class MapperFabric
    {
        public static IDtoMapper CreateMapper()
        {
            var config = AutoMapperConfigurationFactory.ConfigureMapper();
            var mapper = config.CreateMapper();
            return new AutoMapperDtoWrapper(mapper);
        }
    }

    /// <summary>
    /// // TODO: public ради тестов в другом проекте, сделать по нормальному (создать проект тестов)
    /// </summary>
    public static class AutoMapperConfigurationFactory
    {
        public static MapperConfiguration ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.RecognizeDestinationPrefixes(new[] { "n", "str", "dt" });

                cfg
                    .AddDataTypes()
                    .AddCard112()
                    .AddCardData();
            });

            return config;
        }
    }

    internal static class MapperConfigurationExtension
    {
        public static IMapperConfigurationExpression AddDataTypes(this IMapperConfigurationExpression cfg)
        {
            // Properties
            cfg.CreateMap<Tm_SnapshotData, SnapshotModel>()
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.nCardId))
                .ForMember(dest => dest.CardTypeId, opt => opt.MapFrom(src => src.nCardTypeId))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.Modifications, opt => opt.MapFrom(src => src.strModifications))
                .ForMember(dest => dest.Modified, opt => opt.MapFrom(src => src.dtModified))
                .ForMember(dest => dest.Modifier, opt => opt.MapFrom(src => src.strModifier))
                .ForMember(dest => dest.Version, opt => opt.MapFrom(src => src.nVersion));

            // Constructor
            //cfg.CreateMap<Tm_SnapshotData, SnapshotModel>()
            //    .ConstructUsing(src => new SnapshotModel(src.nCardId, src.strModifier, src.dtModified, src.nCardId,
            //        src.nCardTypeId, src.nVersion, src.strModifications));

            return cfg;
        }

        public static IMapperConfigurationExpression AddCard112(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<UpdateDuplicateStatusModel, UpdateDuplicateStatus>();
            return cfg;
        }

        public static IMapperConfigurationExpression AddCardData(this IMapperConfigurationExpression cfg)
        {
            // Нужно заменять поля на свойства, чтобы можно было делать как в AddCard112
            cfg.CreateMap<Tm_CardGeneralData, CardGeneralDataModel>()
                .ForMember(dest => dest.CardType, opt => opt.MapFrom(src => src.m_nCardType))
                .ForMember(dest => dest.CardCreated, opt => opt.MapFrom(src => src.m_lCardCreated))
                .ForMember(dest => dest.EmergencyCardId, opt => opt.MapFrom(src => src.m_nEmergencyCardId))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_04_Data, Card04Model>()
                .ForMember(dest => dest.GeneralData, opt => opt.MapFrom(src => src.m_GeneralData))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.CommunityServiceId, opt => opt.MapFrom(src => src.nCommunityServiceId))
                .ForMember(dest => dest.CommunityServiceSituationId, opt => opt.MapFrom(src => src.nCommunityServiceSituationId))
                .ForMember(dest => dest.CompleteStatus, opt => opt.MapFrom(src => src.nCompleteStatus))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.DenialOfService, opt => opt.MapFrom(src => src.dtDenialOfService))
                .ForMember(dest => dest.Exported, opt => opt.MapFrom(src => src.lExported))
                .ForMember(dest => dest.InstructionId, opt => opt.MapFrom(src => src.nInstructionId))
                .ForMember(dest => dest.IsConsulting, opt => opt.MapFrom(src => src.lIsConsulting))
                .ForMember(dest => dest.Measures, opt => opt.MapFrom(src => src.strMeasures))
                .ForMember(dest => dest.WhatHappened, opt => opt.MapFrom(src => src.strWhatHappened))
                .ForMember(dest => dest.ServiceCardCreate, opt => opt.MapFrom(src => src.dtServiceCardCreate))
                .ForMember(dest => dest.ServiceCardView, opt => opt.MapFrom(src => src.dtServiceCardView))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.dtServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.dtServiceCardWorkNext))
                .ForMember(dest => dest.ServiceCardComplete, opt => opt.MapFrom(src => src.dtServiceCardComplete))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.nServiceIncidentTypeId))
                .ForMember(dest => dest.ServiceOperator, opt => opt.MapFrom(src => src.strServiceOperator))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.strRegistrationNumber))
                .ReverseMapWithValidation();






            cfg.CreateMap<En_CardCompleteStatus, CardCompleteStatusModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_CardCompleteStatus.Submitted, CardCompleteStatusModel.Submitted)
                        .MapValue(En_CardCompleteStatus.Processing, CardCompleteStatusModel.Processing)
                        .MapValue(En_CardCompleteStatus.Complete, CardCompleteStatusModel.Complete)
                )
                .ReverseMap();

            cfg.CreateMap<En_CardType, CardTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_CardType.Card_112, CardTypeModel.Card112)
                        .MapValue(En_CardType.Card_01, CardTypeModel.Card01)
                        .MapValue(En_CardType.Card_02, CardTypeModel.Card02)
                        .MapValue(En_CardType.Card_03, CardTypeModel.Card03)
                        .MapValue(En_CardType.Card_04, CardTypeModel.Card04)
                        .MapValue(En_CardType.Card_CommServ, CardTypeModel.CardCommServ)
                        .MapValue(En_CardType.Card_AT, CardTypeModel.CardAT)
                )
                .ReverseMap();

            cfg.CreateMap<En_ValidatedCommand, ValidatedCommandModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_ValidatedCommand.CompleteCard, ValidatedCommandModel.CompleteCard)
                        .MapValue(En_ValidatedCommand.PrintCard, ValidatedCommandModel.PrintCard)
                )
                .ReverseMap();

            cfg.CreateMap<ErrorCode, ErrorCodeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(ErrorCode.GENERAL_FAULT, ErrorCodeModel.GENERAL_FAULT)
                        .MapValue(ErrorCode.UNKNOWN_ACTION, ErrorCodeModel.UNKNOWN_ACTION)
                        .MapValue(ErrorCode.NO_FREE_HANDLERS, ErrorCodeModel.NO_FREE_HANDLERS)
                        .MapValue(ErrorCode.INTERRUPTED_CYCLE, ErrorCodeModel.INTERRUPTED_CYCLE)
                        .MapValue(ErrorCode.DATABASE_FAULT, ErrorCodeModel.DATABASE_FAULT)
                        .MapValue(ErrorCode.INVALID_CLIENT, ErrorCodeModel.INVALID_CLIENT)
                        .MapValue(ErrorCode.INTERNAL_ERROR, ErrorCodeModel.INTERNAL_ERROR)
                        .MapValue(ErrorCode.SID_NOT_SPECIFIED, ErrorCodeModel.SID_NOT_SPECIFIED)
                        .MapValue(ErrorCode.NON_INITIALIZED_MANAGERS, ErrorCodeModel.NON_INITIALIZED_MANAGERS)
                        .MapValue(ErrorCode.LOGIN_FAILED, ErrorCodeModel.LOGIN_FAILED)
                        .MapValue(ErrorCode.LICENSE_ERROR, ErrorCodeModel.LICENSE_ERROR)
                        .MapValue(ErrorCode.CLIENT_LICENSE_ERROR, ErrorCodeModel.CLIENT_LICENSE_ERROR)
                        .MapValue(ErrorCode.INVALID_PARAMETERS, ErrorCodeModel.INVALID_PARAMETERS)
                )
                .ReverseMap();

            cfg.CreateMap<En_CallType, CallTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_CallType.FalseCall, CallTypeModel.FalseCall)
                        .MapValue(En_CallType.ChildPrank, CallTypeModel.ChildPrank)
                        .MapValue(En_CallType.Info, CallTypeModel.Info)
                        .MapValue(En_CallType.Card_01, CallTypeModel.Card_01)
                        .MapValue(En_CallType.Card_02, CallTypeModel.Card_02)
                        .MapValue(En_CallType.Card_03, CallTypeModel.Card_03)
                        .MapValue(En_CallType.Card_04, CallTypeModel.Card_04)
                        .MapValue(En_CallType.Card_CommServ, CallTypeModel.Card_CommServ)
                        .MapValue(En_CallType.Repeated, CallTypeModel.Repeated)
                        .MapValue(En_CallType.Card_AT, CallTypeModel.Card_AT)
                        .MapValue(En_CallType.Psychologist, CallTypeModel.Psychologist)
                        .MapValue(En_CallType.Consultation, CallTypeModel.Consultation)
                        .MapValue(En_CallType.Interpreter, CallTypeModel.Interpreter)
                        .MapValue(En_CallType.RosOhrana, CallTypeModel.RosOhrana)
                        .MapValue(En_CallType.GZHI, CallTypeModel.GZHI)
                        .MapValue(En_CallType.InterRegional, CallTypeModel.InterRegional)
                )
                .ReverseMap();

            cfg.CreateMap<En_ServiceType, ServiceTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_ServiceType.Service01, ServiceTypeModel.Service01)
                        .MapValue(En_ServiceType.Service02, ServiceTypeModel.Service02)
                        .MapValue(En_ServiceType.Service03, ServiceTypeModel.Service03)
                        .MapValue(En_ServiceType.Service04, ServiceTypeModel.Service04)
                        .MapValue(En_ServiceType.ServiceCommServ, ServiceTypeModel.ServiceCommServ)
                        .MapValue(En_ServiceType.Service112, ServiceTypeModel.Service112)
                        .MapValue(En_ServiceType.ServiceAT, ServiceTypeModel.ServiceAT)
                        .MapValue(En_ServiceType.ServicePsychologist, ServiceTypeModel.ServicePsychologist)
                        .MapValue(En_ServiceType.ServiceConsultation, ServiceTypeModel.ServiceConsultation)
                        .MapValue(En_ServiceType.ServiceInterpreter, ServiceTypeModel.ServiceInterpreter)
                        .MapValue(En_ServiceType.ServiceRosOhrana, ServiceTypeModel.ServiceRosOhrana)
                )
                .ReverseMap();

            cfg.CreateMap<En_ImportanceLevel, ImportanceLevelModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_ImportanceLevel.NotImportant, ImportanceLevelModel.NotImportant)
                        .MapValue(En_ImportanceLevel.Important, ImportanceLevelModel.Important)
                )
                .ReverseMap();

            cfg.CreateMap<En_CardSyntheticState, CardSyntheticStateModelEnum>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_CardSyntheticState.Request112, CardSyntheticStateModelEnum.Request112)
                        .MapValue(En_CardSyntheticState.ServicesInvolvement, CardSyntheticStateModelEnum.ServicesInvolvement)
                        .MapValue(En_CardSyntheticState.ServicesReaction, CardSyntheticStateModelEnum.ServicesReaction)
                        .MapValue(En_CardSyntheticState.ServicesWork, CardSyntheticStateModelEnum.ServicesWork)
                        .MapValue(En_CardSyntheticState.Completed, CardSyntheticStateModelEnum.Completed)
                        .MapValue(En_CardSyntheticState.ServicesStart, CardSyntheticStateModelEnum.ServicesStart)
                        .MapValue(En_CardSyntheticState.DenialOfService, CardSyntheticStateModelEnum.DenialOfService)
                )
                .ReverseMap();

            cfg.CreateMap<En_SortingOrder, SortingOrderModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_SortingOrder.ASC, SortingOrderModel.ASC)
                        .MapValue(En_SortingOrder.DESC, SortingOrderModel.DESC)
                )
                .ReverseMap();

            cfg.CreateMap<En_PhonogramSource, PhonogramSourceModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_PhonogramSource.Internal, PhonogramSourceModel.Internal)
                        .MapValue(En_PhonogramSource.External, PhonogramSourceModel.External)
                )
                .ReverseMap();

            cfg.CreateMap<En_DuplicateStatus, DuplicateStatusModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_DuplicateStatus.UnconfirmedDuplicate, DuplicateStatusModel.UnconfirmedDuplicate)
                        .MapValue(En_DuplicateStatus.Duplicate, DuplicateStatusModel.Duplicate)
                        .MapValue(En_DuplicateStatus.DuplicateFalse, DuplicateStatusModel.DuplicateFalse)
                        .MapValue(En_DuplicateStatus.UnconfirmedRepeated, DuplicateStatusModel.UnconfirmedRepeated)
                        .MapValue(En_DuplicateStatus.Repeated, DuplicateStatusModel.Repeated)
                        .MapValue(En_DuplicateStatus.RepeatedFalse, DuplicateStatusModel.RepeatedFalse)
                )
                .ReverseMap();

            cfg.CreateMap<En_User03Role, User03RoleModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_User03Role.Operator_03, User03RoleModel.Operator_03)
                        .MapValue(En_User03Role.Dispatcher_03, User03RoleModel.Dispatcher_03)
                )
                .ReverseMap();

            cfg.CreateMap<En_ReflectionPriorityBy03Reason, ReflectionPriorityBy03ReasonModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_ReflectionPriorityBy03Reason.Emergency, ReflectionPriorityBy03ReasonModel.Emergency)
                        .MapValue(En_ReflectionPriorityBy03Reason.Immediate, ReflectionPriorityBy03ReasonModel.Immediate)
                        .MapValue(En_ReflectionPriorityBy03Reason.Urgent, ReflectionPriorityBy03ReasonModel.Urgent)
                        .MapValue(En_ReflectionPriorityBy03Reason.Transportation, ReflectionPriorityBy03ReasonModel.Transportation)
                        .MapValue(En_ReflectionPriorityBy03Reason.NoPriority, ReflectionPriorityBy03ReasonModel.NoPriority)
                )
                .ReverseMap();

            cfg.CreateMap<En_AttachmentType, AttachmentTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_AttachmentType.IMAGE, AttachmentTypeModel.IMAGE)
                        .MapValue(En_AttachmentType.ACTION, AttachmentTypeModel.ACTION)
                        .MapValue(En_AttachmentType.STRING, AttachmentTypeModel.STRING)
                        .MapValue(En_AttachmentType.PHONE_NUMBER, AttachmentTypeModel.PHONE_NUMBER)
                        .MapValue(En_AttachmentType.GEOMETRY, AttachmentTypeModel.GEOMETRY)
                        .MapValue(En_AttachmentType.DOWNLOAD, AttachmentTypeModel.DOWNLOAD)
                        .MapValue(En_AttachmentType.VP_ONLINE_URL, AttachmentTypeModel.VP_ONLINE_URL)
                        .MapValue(En_AttachmentType.VP_ARCHIVE_URL, AttachmentTypeModel.VP_ARCHIVE_URL)
                        .MapValue(En_AttachmentType.VP_THUMBNAIL, AttachmentTypeModel.VP_THUMBNAIL)
                        .MapValue(En_AttachmentType.PROXY_DOWNLOAD, AttachmentTypeModel.PROXY_DOWNLOAD)
                )
                .ReverseMap();

            cfg.CreateMap<En_SMSType, SMSTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_SMSType.Incoming, SMSTypeModel.Incoming)
                        .MapValue(En_SMSType.Outcoming, SMSTypeModel.Outcoming)
                )
                .ReverseMap();

            cfg.CreateMap<En_Direction, DirectionModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_Direction.Incoming, DirectionModel.Incoming)
                        .MapValue(En_Direction.Outcoming, DirectionModel.Outcoming)
                )
                .ReverseMap();

            cfg.CreateMap<En_SMSStatus, SMSStatusModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_SMSStatus.Sent, SMSStatusModel.Sent)
                        .MapValue(En_SMSStatus.NotSent, SMSStatusModel.NotSent)
                        .MapValue(En_SMSStatus.Received, SMSStatusModel.Received)
                        .MapValue(En_SMSStatus.NotReceived, SMSStatusModel.NotReceived)
                )
                .ReverseMap();

            cfg.CreateMap<En_SourceType, SourceTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_SourceType.PHONE, SourceTypeModel.PHONE)
                        .MapValue(En_SourceType.SMS, SourceTypeModel.SMS)
                        .MapValue(En_SourceType.ERA_GLONASS, SourceTypeModel.ERA_GLONASS)
                        .MapValue(En_SourceType.WITHOUT_CALL, SourceTypeModel.WITHOUT_CALL)
                        .MapValue(En_SourceType.SENSORS, SourceTypeModel.SENSORS)
                        .MapValue(En_SourceType.INTERNET_PORTAL, SourceTypeModel.INTERNET_PORTAL)
                )
                .ReverseMap();
            
            cfg.CreateMap<ReportFormatType, ReportFormatTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(ReportFormatType.pdf, ReportFormatTypeModel.pdf)
                        .MapValue(ReportFormatType.xls, ReportFormatTypeModel.xls)
                        .MapValue(ReportFormatType.xlsx, ReportFormatTypeModel.xlsx)
                        .MapValue(ReportFormatType.docx, ReportFormatTypeModel.docx)
                        .MapValue(ReportFormatType.rtf, ReportFormatTypeModel.rtf)
                )
                .ReverseMap();

            cfg.CreateMap<En_ExternalInfoType, ExternalInfoTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_ExternalInfoType.Unknown, ExternalInfoTypeModel.Unknown)
                        .MapValue(En_ExternalInfoType.ContentList, ExternalInfoTypeModel.ContentList)
                        .MapValue(En_ExternalInfoType.SpbSvetetsAlert, ExternalInfoTypeModel.SpbSvetetsAlert)
                        .MapValue(En_ExternalInfoType.Card112, ExternalInfoTypeModel.Card112)
                )
                .ReverseMap();

            cfg.CreateMap<Command, CommandModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(Command.SaveCardWithTransferCommand, CommandModel.SaveCardWithTransferCommand)
                        .MapValue(Command.InitConferenceCommand, CommandModel.InitConferenceCommand)
                )
                .ReverseMap();

            cfg.CreateMap<En_CallStatus, CallStatusModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_CallStatus.TransferedTo01, CallStatusModel.TransferedTo01)
                        .MapValue(En_CallStatus.TransferedTo02, CallStatusModel.TransferedTo02)
                        .MapValue(En_CallStatus.TransferedTo03, CallStatusModel.TransferedTo03)
                        .MapValue(En_CallStatus.TransferedTo04, CallStatusModel.TransferedTo04)
                        .MapValue(En_CallStatus.TransferedToAT, CallStatusModel.TransferedToAT)
                        .MapValue(En_CallStatus.TransferedToCommServ, CallStatusModel.TransferedToCommServ)
                        .MapValue(En_CallStatus.TerminatedByOperator, CallStatusModel.TerminatedByOperator)
                        .MapValue(En_CallStatus.TerminatedByAbonent, CallStatusModel.TerminatedByAbonent)
                )
                .ReverseMap();

            cfg.CreateMap<ServiceCardEditView, ServiceCardEditViewModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(ServiceCardEditView.Card01View, ServiceCardEditViewModel.Card01View)
                        .MapValue(ServiceCardEditView.Card01SpbView, ServiceCardEditViewModel.Card01SpbView)
                        .MapValue(ServiceCardEditView.Card01SpbEditView, ServiceCardEditViewModel.Card01SpbEditView)
                        .MapValue(ServiceCardEditView.Card02View, ServiceCardEditViewModel.Card02View)
                        .MapValue(ServiceCardEditView.Card02SpbView, ServiceCardEditViewModel.Card02SpbView)
                        .MapValue(ServiceCardEditView.Card02SpbEditView, ServiceCardEditViewModel.Card02SpbEditView)
                        .MapValue(ServiceCardEditView.Card02IntegrationView, ServiceCardEditViewModel.Card02IntegrationView)
                        .MapValue(ServiceCardEditView.Card03DispatcherView, ServiceCardEditViewModel.Card03DispatcherView)
                        .MapValue(ServiceCardEditView.Card03SpbView, ServiceCardEditViewModel.Card03SpbView)
                        .MapValue(ServiceCardEditView.Card03SpbEditView, ServiceCardEditViewModel.Card03SpbEditView)
                        .MapValue(ServiceCardEditView.Card03AddVictimsView, ServiceCardEditViewModel.Card03AddVictimsView)
                        .MapValue(ServiceCardEditView.Card04View, ServiceCardEditViewModel.Card04View)
                        .MapValue(ServiceCardEditView.Card04SpbView, ServiceCardEditViewModel.Card04SpbView)
                        .MapValue(ServiceCardEditView.Card04SpbEditView, ServiceCardEditViewModel.Card04SpbEditView)
                        .MapValue(ServiceCardEditView.CardCommServView, ServiceCardEditViewModel.CardCommServView)
                        .MapValue(ServiceCardEditView.CardCommServSpbView, ServiceCardEditViewModel.CardCommServSpbView)
                        .MapValue(ServiceCardEditView.CardCommServSpbEditView, ServiceCardEditViewModel.CardCommServSpbEditView)
                        .MapValue(ServiceCardEditView.CardATView, ServiceCardEditViewModel.CardATView)
                        .MapValue(ServiceCardEditView.CardATSpbView, ServiceCardEditViewModel.CardATSpbView)
                        .MapValue(ServiceCardEditView.CardATSpbEditView, ServiceCardEditViewModel.CardATSpbEditView)
                )
                .ReverseMap();

            cfg.CreateMap<En_MNISEventType, MNISEventTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_MNISEventType.Other, MNISEventTypeModel.Other)
                        .MapValue(En_MNISEventType.Accepted, MNISEventTypeModel.Accepted)
                        .MapValue(En_MNISEventType.Departure, MNISEventTypeModel.Departure)
                        .MapValue(En_MNISEventType.OnTheWay, MNISEventTypeModel.OnTheWay)
                        .MapValue(En_MNISEventType.WayIncedent, MNISEventTypeModel.WayIncedent)
                        .MapValue(En_MNISEventType.TrafficDelay, MNISEventTypeModel.TrafficDelay)
                        .MapValue(En_MNISEventType.Reject, MNISEventTypeModel.Reject)
                        .MapValue(En_MNISEventType.Redirect, MNISEventTypeModel.Redirect)
                        .MapValue(En_MNISEventType.Arrived, MNISEventTypeModel.Arrived)
                        .MapValue(En_MNISEventType.Deployment, MNISEventTypeModel.Deployment)
                        .MapValue(En_MNISEventType.Performance, MNISEventTypeModel.Performance)
                        .MapValue(En_MNISEventType.Completed, MNISEventTypeModel.Completed)
                        .MapValue(En_MNISEventType.Undeployment, MNISEventTypeModel.Undeployment)
                        .MapValue(En_MNISEventType.Retuning, MNISEventTypeModel.Retuning)
                        .MapValue(En_MNISEventType.Comeback, MNISEventTypeModel.Comeback)
                        .MapValue(En_MNISEventType.ArrivalToBase, MNISEventTypeModel.ArrivalToBase)
                        .MapValue(En_MNISEventType.Closed, MNISEventTypeModel.Closed)
                )
                .ReverseMap();

            cfg.CreateMap<En_VehicleInfoSourceName, VehicleInfoSourceNameModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_VehicleInfoSourceName.MNIS, VehicleInfoSourceNameModel.MNIS)
                        .MapValue(En_VehicleInfoSourceName.RNIS, VehicleInfoSourceNameModel.RNIS)
                )
                .ReverseMap();

            cfg.CreateMap<MapType, MapTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(MapType.Protei, MapTypeModel.Protei)
                        .MapValue(MapType.IAC, MapTypeModel.IAC)
                        .MapValue(MapType.ArcGIS, MapTypeModel.ArcGIS)
                        .MapValue(MapType.ChromeBrowserPppur, MapTypeModel.ChromeBrowserPppur)
                )
                .ReverseMap();

            cfg.CreateMap<CallCenterProviderType, CallCenterProviderTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(CallCenterProviderType.NotSet, CallCenterProviderTypeModel.NotSet)
                        .MapValue(CallCenterProviderType.Protei, CallCenterProviderTypeModel.Protei)
                        .MapValue(CallCenterProviderType.Avaya7, CallCenterProviderTypeModel.Avaya7)
                        .MapValue(CallCenterProviderType.ProteiEACD3, CallCenterProviderTypeModel.ProteiEACD3)
                        .MapValue(CallCenterProviderType.EmergencyServer, CallCenterProviderTypeModel.EmergencyServer)
                        .MapValue(CallCenterProviderType.GridBookServer, CallCenterProviderTypeModel.GridBookServer)
                        .MapValue(CallCenterProviderType.ProteiEACDWPServer, CallCenterProviderTypeModel.ProteiEACDWPServer)
                )
                .ReverseMap();

            cfg.CreateMap<En_TemplateType, TemplateTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_TemplateType.Bool, TemplateTypeModel.Bool)
                        .MapValue(En_TemplateType.Int, TemplateTypeModel.Int)
                        .MapValue(En_TemplateType.String, TemplateTypeModel.String)
                        .MapValue(En_TemplateType.DateTime, TemplateTypeModel.DateTime)
                        .MapValue(En_TemplateType.Combo, TemplateTypeModel.Combo)
                        .MapValue(En_TemplateType.Table, TemplateTypeModel.Table)
                )
                .ReverseMap();

            cfg.CreateMap<DateTimeFormat, DateTimeFormatModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(DateTimeFormat.Date, DateTimeFormatModel.Date)
                        .MapValue(DateTimeFormat.DateTime, DateTimeFormatModel.DateTime)
                )
                .ReverseMap();

            cfg.CreateMap<CardEventType, CardEventTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(CardEventType.CardCreated, CardEventTypeModel.CardCreated)
                        .MapValue(CardEventType.CardChanged, CardEventTypeModel.CardChanged)
                )
                .ReverseMap();

            cfg.CreateMap<En_LayerType, LayerTypeModel>()
                .ConvertUsingEnumMapping(opt => opt
                        .MapValue(En_LayerType.FIRES, LayerTypeModel.FIRES)
                )
                .ReverseMap();




            cfg.CreateMap<CardsContainer, CardsContainerModel>()
                .ForMember(dest => dest.Card112, opt => opt.MapFrom(src => src.card112))
                .ForMember(dest => dest.Card01, opt => opt.MapFrom(src => src.card01))
                .ForMember(dest => dest.Card02, opt => opt.MapFrom(src => src.card02))
                .ForMember(dest => dest.Card03, opt => opt.MapFrom(src => src.card03))
                .ForMember(dest => dest.Card04, opt => opt.MapFrom(src => src.card04))
                .ForMember(dest => dest.CardAT, opt => opt.MapFrom(src => src.cardAT))
                .ForMember(dest => dest.CardCommServ, opt => opt.MapFrom(src => src.cardCommServ))
                .ForMember(dest => dest.CustomServicesCards, opt => opt.MapFrom(src => src.customServicesCards))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_112_Data, Card112Model>()
                .ForMember(dest => dest.GeneralData, opt => opt.MapFrom(src => src.m_GeneralData))
                .ForMember(dest => dest.Create, opt => opt.MapFrom(src => src.dtCreate))
                .ForMember(dest => dest.CallId, opt => opt.MapFrom(src => src.nCallId))
                .ForMember(dest => dest.ExtCallId, opt => opt.MapFrom(src => src.extCallId))
                .ForMember(dest => dest.ExtCallId2, opt => opt.MapFrom(src => src.extCallId2))
                .ForMember(dest => dest.CdPN, opt => opt.MapFrom(src => src.strCdPN))
                .ForMember(dest => dest.CgPN, opt => opt.MapFrom(src => src.strCgPN))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.nCategory))
                .ForMember(dest => dest.CallTypeId, opt => opt.MapFrom(src => src.nCallTypeId))
                .ForMember(dest => dest.IncidentTypeId, opt => opt.MapFrom(src => src.nIncidentTypeId))
                .ForMember(dest => dest.ImportanceLevelId, opt => opt.MapFrom(src => src.nImportanceLevelId))
                .ForMember(dest => dest.PhoneOwner, opt => opt.MapFrom(src => src.strPhoneOwner))
                .ForMember(dest => dest.PhoneAddress, opt => opt.MapFrom(src => src.strPhoneAddress))
                .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.strCreator))
                .ForMember(dest => dest.CityID, opt => opt.MapFrom(src => src.nCityID))
                .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(src => src.nDistrictID))
                .ForMember(dest => dest.StreetID, opt => opt.MapFrom(src => src.nStreetID))
                .ForMember(dest => dest.AdditionalStreetId, opt => opt.MapFrom(src => src.nAdditionalStreetId))
                .ForMember(dest => dest.CardSyntheticStateId, opt => opt.MapFrom(src => src.nCardSyntheticStateId))
                .ForMember(dest => dest.Card01SyntheticStateId, opt => opt.MapFrom(src => src.nCard01SyntheticStateId))
                .ForMember(dest => dest.Card02SyntheticStateId, opt => opt.MapFrom(src => src.nCard02SyntheticStateId))
                .ForMember(dest => dest.Card03SyntheticStateId, opt => opt.MapFrom(src => src.nCard03SyntheticStateId))
                .ForMember(dest => dest.Card04SyntheticStateId, opt => opt.MapFrom(src => src.nCard04SyntheticStateId))
                .ForMember(dest => dest.CardCommServSyntheticStateId, opt => opt.MapFrom(src => src.nCardCommServSyntheticStateId))
                .ForMember(dest => dest.CardATSyntheticStateId, opt => opt.MapFrom(src => src.nCardATSyntheticStateId))
                .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src.strBuilding))
                .ForMember(dest => dest.Corps, opt => opt.MapFrom(src => src.strCorps))
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.strRoom))
                .ForMember(dest => dest.AddressStrip, opt => opt.MapFrom(src => src.strAddressStrip))
                .ForMember(dest => dest.Storeys, opt => opt.MapFrom(src => src.strStoreys))
                .ForMember(dest => dest.CallerContactPhone, opt => opt.MapFrom(src => src.strCallerContactPhone))
                .ForMember(dest => dest.Floor, opt => opt.MapFrom(src => src.nFloor))
                .ForMember(dest => dest.AdditionalLocationInfo, opt => opt.MapFrom(src => src.strAdditionalLocationInfo))
                .ForMember(dest => dest.Entrance, opt => opt.MapFrom(src => src.strEntrance))
                .ForMember(dest => dest.EntranceCode, opt => opt.MapFrom(src => src.strEntranceCode))
                .ForMember(dest => dest.IncidentDescription, opt => opt.MapFrom(src => src.strIncidentDescription))
                .ForMember(dest => dest.DeclarantName, opt => opt.MapFrom(src => src.strDeclarantName))
                .ForMember(dest => dest.DeclarantLastName, opt => opt.MapFrom(src => src.strDeclarantLastName))
                .ForMember(dest => dest.DeclarantMiddleName, opt => opt.MapFrom(src => src.strDeclarantMiddleName))
                .ForMember(dest => dest.DeclarantStatusId, opt => opt.MapFrom(src => src.nDeclarantStatusId))
                .ForMember(dest => dest.DeclarantAddress, opt => opt.MapFrom(src => src.strDeclarantAddress))
                .ForMember(dest => dest.DeclarantCityId, opt => opt.MapFrom(src => src.nDeclarantCityId))
                .ForMember(dest => dest.DeclarantDistrictId, opt => opt.MapFrom(src => src.nDeclarantDistrictId))
                .ForMember(dest => dest.DeclarantLocalDistrictId, opt => opt.MapFrom(src => src.nDeclarantLocalDistrictId))
                .ForMember(dest => dest.DeclarantStreetId, opt => opt.MapFrom(src => src.nDeclarantStreetId))
                .ForMember(dest => dest.DeclarantBuildingNumber, opt => opt.MapFrom(src => src.strDeclarantBuildingNumber))
                .ForMember(dest => dest.DeclarantCorps, opt => opt.MapFrom(src => src.strDeclarantCorps))
                .ForMember(dest => dest.DeclarantFlat, opt => opt.MapFrom(src => src.strDeclarantFlat))
                .ForMember(dest => dest.CCMC_TypeId, opt => opt.MapFrom(src => src.nCCMC_TypeId))
                .ForMember(dest => dest.HasCard01, opt => opt.MapFrom(src => src.lHasCard01))
                .ForMember(dest => dest.HasCard02, opt => opt.MapFrom(src => src.lHasCard02))
                .ForMember(dest => dest.HasCard03, opt => opt.MapFrom(src => src.lHasCard03))
                .ForMember(dest => dest.HasCard04, opt => opt.MapFrom(src => src.lHasCard04))
                .ForMember(dest => dest.HasCardAT, opt => opt.MapFrom(src => src.lHasCardAT))
                .ForMember(dest => dest.HasCardCommServ, opt => opt.MapFrom(src => src.lHasCardCommServ))
                .ForMember(dest => dest.DuplicateUserStatus, opt => opt.MapFrom(src => src.nDuplicateUserStatus))
                .ForMember(dest => dest.DuplicateSystemStatus, opt => opt.MapFrom(src => src.nDuplicateSystemStatus))
                .ForMember(dest => dest.OriginalCardId, opt => opt.MapFrom(src => src.nOriginalCardId))
                .ForMember(dest => dest.OriginalGlobalId, opt => opt.MapFrom(src => src.originalGlobalId))
                .ForMember(dest => dest.IsMultizone, opt => opt.MapFrom(src => src.isMultizone))
                .ForMember(dest => dest.DeclarantDateOfBirth, opt => opt.MapFrom(src => src.dtDeclarantDateOfBirth))
                .ForMember(dest => dest.AgeYear, opt => opt.MapFrom(src => src.nAgeYear))
                .ForMember(dest => dest.ObjectId, opt => opt.MapFrom(src => src.nObjectId))
                .ForMember(dest => dest.Revision, opt => opt.MapFrom(src => src.revision))
                .ForMember(dest => dest.CellId, opt => opt.MapFrom(src => src.cellId))
                .ForMember(dest => dest.GeoLatitude, opt => opt.MapFrom(src => src.geoLatitude))
                .ForMember(dest => dest.GeoLongitude, opt => opt.MapFrom(src => src.geoLongitude))
                .ForMember(dest => dest.GeoRegionDesc, opt => opt.MapFrom(src => src.geoRegionDesc))
                .ForMember(dest => dest.DeclarantGeoLatitude, opt => opt.MapFrom(src => src.declarantGeoLatitude))
                .ForMember(dest => dest.DeclarantGeoLongitude, opt => opt.MapFrom(src => src.declarantGeoLongitude))
                .ForMember(dest => dest.DeclarantGeoRegionDesc, opt => opt.MapFrom(src => src.declarantGeoRegionDesc))
                .ForMember(dest => dest.InvalidStreet, opt => opt.MapFrom(src => src.invalidStreet))
                .ForMember(dest => dest.EraIntegrationXml, opt => opt.MapFrom(src => src.eraIntegrationXml))
                .ForMember(dest => dest.TextAddress, opt => opt.MapFrom(src => src.strTextAddress))
                .ForMember(dest => dest.CallerNearCameras, opt => opt.MapFrom(src => src.callerNearCameras))
                .ForMember(dest => dest.Complete, opt => opt.MapFrom(src => src.dtComplete))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.nRegionId))
                .ForMember(dest => dest.LocalDistrictId, opt => opt.MapFrom(src => src.nLocalDistrictId))
                .ForMember(dest => dest.AttachmentList, opt => opt.MapFrom(src => src.attachmentList))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.nLanguageId))
                .ForMember(dest => dest.IsNear, opt => opt.MapFrom(src => src.isNear))
                .ForMember(dest => dest.Km, opt => opt.MapFrom(src => src.strKm))
                .ForMember(dest => dest.Casualties, opt => opt.MapFrom(src => src.nCasualties))
                .ForMember(dest => dest.HumanThreat, opt => opt.MapFrom(src => src.lHumanThreat))
                .ForMember(dest => dest.SourceZoneId, opt => opt.MapFrom(src => src.sourceZoneId))
                .ForMember(dest => dest.GlobalId, opt => opt.MapFrom(src => src.globalId))
                .ForMember(dest => dest.OperatorName, opt => opt.MapFrom(src => src.strOperatorName))
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.lPriority))
                .ForMember(dest => dest.LatestSys, opt => opt.MapFrom(src => src.strLatestSys))
                .ForMember(dest => dest.EraCardId, opt => opt.MapFrom(src => src.strEraCardId))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.CallStatus, opt => opt.MapFrom(src => src.callStatus))
                .ForMember(dest => dest.VisitedNetworkId, opt => opt.MapFrom(src => src.visitedNetworkId))
                .ForMember(dest => dest.TestCard, opt => opt.MapFrom(src => src.lTestCard))
                .ForMember(dest => dest.ExtendedData, opt => opt.MapFrom(src => src.extendedData))
                .ForMember(dest => dest.CallRoutingTag, opt => opt.MapFrom(src => src.callRoutingTag))
                .ForMember(dest => dest.SourceTypeId, opt => opt.MapFrom(src => src.nSourceTypeId))
                .ForMember(dest => dest.ExternalId2, opt => opt.MapFrom(src => src.externalId2))
                .ForMember(dest => dest.SourceTypeInfo, opt => opt.MapFrom(src => src.strSourceTypeInfo))
                .ForMember(dest => dest.AutoDistribute, opt => opt.MapFrom(src => src.autoDistribute))
                .ForMember(dest => dest.Draft, opt => opt.MapFrom(src => src.draft))
                .ForMember(dest => dest.Metadata, opt => opt.MapFrom(src => src.metadata))
                .ForMember(dest => dest.Control, opt => opt.MapFrom(src => src.control))
                .ForMember(dest => dest.ChatId, opt => opt.MapFrom(src => src.ChatId))
                .ForMember(dest => dest.WasChangedAfterFirstSave, opt => opt.MapFrom(src => src.wasChangedAfterFirstSave))
                .ForMember(dest => dest.Structure, opt => opt.MapFrom(src => src.strStructure))
                .ForMember(dest => dest.DeclarantStructure, opt => opt.MapFrom(src => src.strDeclarantStructure))
                .ForMember(dest => dest.CallHistory, opt => opt.MapFrom(src => src.callHistory))
                .ForMember(dest => dest.FailedReplicationTargets, opt => opt.MapFrom(src => src.failedReplicationTargets))
                .ForMember(dest => dest.SucceededReplicationTargets, opt => opt.MapFrom(src => src.succeededReplicationTargets))
                .ForMember(dest => dest.DirectCommServDepartments, opt => opt.MapFrom(src => src.directCommServDepartments))
                .ForMember(dest => dest.CustomServices, opt => opt.MapFrom(src => src.customServices))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_01_Data, Card01Model>()
                .ForMember(dest => dest.GeneralData, opt => opt.MapFrom(src => src.m_GeneralData))
                .ForMember(dest => dest.ObjectOwner, opt => opt.MapFrom(src => src.strObjectOwner))
                .ForMember(dest => dest.FirePreventionTypeID, opt => opt.MapFrom(src => src.nFirePreventionTypeID))
                .ForMember(dest => dest.InternalCardNumber, opt => opt.MapFrom(src => src.strInternalCardNumber))
                .ForMember(dest => dest.FirstFireBarrel, opt => opt.MapFrom(src => src.firstFireBarrel))
                .ForMember(dest => dest.WaterConsumption, opt => opt.MapFrom(src => src.waterConsumption))
                .ForMember(dest => dest.WaterSourceID, opt => opt.MapFrom(src => src.nWaterSourceID))
                .ForMember(dest => dest.DamageCost, opt => opt.MapFrom(src => src.damageCost))
                .ForMember(dest => dest.SavedCost, opt => opt.MapFrom(src => src.savedCost))
                .ForMember(dest => dest.PoliceInterest, opt => opt.MapFrom(src => src.policeInterest))
                .ForMember(dest => dest.Shift, opt => opt.MapFrom(src => src.strShift))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.strMessage))
                .ForMember(dest => dest.ObjectAdditionalInfo, opt => opt.MapFrom(src => src.strObjectAdditionalInfo))
                .ForMember(dest => dest.ObjectId, opt => opt.MapFrom(src => src.nObjectId))
                .ForMember(dest => dest.ReactionPlanId, opt => opt.MapFrom(src => src.nReactionPlanId))
                .ForMember(dest => dest.ObjectTypeId, opt => opt.MapFrom(src => src.nObjectTypeId))
                .ForMember(dest => dest.ObjectGasified, opt => opt.MapFrom(src => src.lObjectGasified))
                .ForMember(dest => dest.FireClassId, opt => opt.MapFrom(src => src.nFireClassId))
                .ForMember(dest => dest.HumanThreat, opt => opt.MapFrom(src => src.lHumanThreat))
                .ForMember(dest => dest.EmergencyFlag, opt => opt.MapFrom(src => src.lEmergencyFlag))
                .ForMember(dest => dest.Space, opt => opt.MapFrom(src => src.nSpace))
                .ForMember(dest => dest.PerishedPeople, opt => opt.MapFrom(src => src.nPerishedPeople))
                .ForMember(dest => dest.PerishedChildren, opt => opt.MapFrom(src => src.nPerishedChildren))
                .ForMember(dest => dest.PerishedCollaborators, opt => opt.MapFrom(src => src.nPerishedCollaborators))
                .ForMember(dest => dest.Wounded, opt => opt.MapFrom(src => src.nWounded))
                .ForMember(dest => dest.WoundedChildren, opt => opt.MapFrom(src => src.nWoundedChildren))
                .ForMember(dest => dest.WoundedCollaborators, opt => opt.MapFrom(src => src.nWoundedCollaborators))
                .ForMember(dest => dest.SavedPeople, opt => opt.MapFrom(src => src.nSavedPeople))
                .ForMember(dest => dest.SavedChildren, opt => opt.MapFrom(src => src.nSavedChildren))
                .ForMember(dest => dest.BrokenLivingConditions, opt => opt.MapFrom(src => src.nBrokenLivingConditions))
                .ForMember(dest => dest.BrokenLivingConditionsChildren, opt => opt.MapFrom(src => src.nBrokenLivingConditionsChildren))
                .ForMember(dest => dest.FireReasonID, opt => opt.MapFrom(src => src.nFireReasonID))
                .ForMember(dest => dest.FireIncidentTypeID, opt => opt.MapFrom(src => src.nFireIncidentTypeID))
                .ForMember(dest => dest.Localization, opt => opt.MapFrom(src => src.dtLocalization))
                .ForMember(dest => dest.Liquidation, opt => opt.MapFrom(src => src.dtLiquidation))
                .ForMember(dest => dest.OpenFireLiquidation, opt => opt.MapFrom(src => src.dtOpenFireLiquidation))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.strDescription))
                .ForMember(dest => dest.FireDistance, opt => opt.MapFrom(src => src.nFireDistance))
                .ForMember(dest => dest.Ownership, opt => opt.MapFrom(src => src.strOwnership))
                .ForMember(dest => dest.IsError, opt => opt.MapFrom(src => src.isError))
                .ForMember(dest => dest.ServiceCardCreate, opt => opt.MapFrom(src => src.dtServiceCardCreate))
                .ForMember(dest => dest.ServiceCardView, opt => opt.MapFrom(src => src.dtServiceCardView))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.dtServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.dtServiceCardWorkNext))
                .ForMember(dest => dest.ServiceCardComplete, opt => opt.MapFrom(src => src.dtServiceCardComplete))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.nServiceIncidentTypeId))
                .ForMember(dest => dest.FireStartEstimate, opt => opt.MapFrom(src => src.nFireStartEstimate))
                .ForMember(dest => dest.FireResults, opt => opt.MapFrom(src => src.strFireResults))
                .ForMember(dest => dest.PathDescription, opt => opt.MapFrom(src => src.strPathDescription))
                .ForMember(dest => dest.ConditionsDescription, opt => opt.MapFrom(src => src.strConditionsDescription))
                .ForMember(dest => dest.EvacuationAvail, opt => opt.MapFrom(src => src.lEvacuationAvail))
                .ForMember(dest => dest.ServiceOperator, opt => opt.MapFrom(src => src.strServiceOperator))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.strRegistrationNumber))
                .ForMember(dest => dest.NumberStoreys, opt => opt.MapFrom(src => src.nNumberStoreys))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.DenialOfService, opt => opt.MapFrom(src => src.dtDenialOfService))
                .ForMember(dest => dest.RegionData, opt => opt.MapFrom(src => src.regionData))
                .ForMember(dest => dest.MNISId, opt => opt.MapFrom(src => src.strMNISId))
                .ForMember(dest => dest.MnisReactionInfo, opt => opt.MapFrom(src => src.mnisReactionInfo))
                .ForMember(dest => dest.FireBarrels, opt => opt.MapFrom(src => src.fireBarrels))
                .ForMember(dest => dest.FireExtinguishers, opt => opt.MapFrom(src => src.fireExtinguishers))
                .ForMember(dest => dest.DrillsChiefs, opt => opt.MapFrom(src => src.drillsChiefs))
                .ForMember(dest => dest.FireChiefs, opt => opt.MapFrom(src => src.fireChiefs))
                .ForMember(dest => dest.FireFighters, opt => opt.MapFrom(src => src.fireFighters))
                .ForMember(dest => dest.GdzsUnits, opt => opt.MapFrom(src => src.gdzsUnits))
                .ForMember(dest => dest.InvolvedVehicles, opt => opt.MapFrom(src => src.involvedVehicles))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_02_Data, Card02Model>()
                .ForMember(dest => dest.GeneralData, opt => opt.MapFrom(src => src.m_GeneralData))
                .ForMember(dest => dest.CardOVD, opt => opt.MapFrom(src => src.m_CardOVD))
                .ForMember(dest => dest.ITypeID, opt => opt.MapFrom(src => src.nITypeID))
                .ForMember(dest => dest.ImportanceLevel, opt => opt.MapFrom(src => src.importanceLevel))
                .ForMember(dest => dest.Exported, opt => opt.MapFrom(src => src.lExported))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.strRegistrationNumber))
                .ForMember(dest => dest.RegistrationDepartmentID, opt => opt.MapFrom(src => src.registrationDepartmentID))
                .ForMember(dest => dest.ServiceCardCreate, opt => opt.MapFrom(src => src.dtServiceCardCreate))
                .ForMember(dest => dest.ServiceCardView, opt => opt.MapFrom(src => src.dtServiceCardView))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.dtServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.dtServiceCardWorkNext))
                .ForMember(dest => dest.ServiceCardComplete, opt => opt.MapFrom(src => src.dtServiceCardComplete))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.nServiceIncidentTypeId))
                .ForMember(dest => dest.CriminalsCount, opt => opt.MapFrom(src => src.nCriminalsCount))
                .ForMember(dest => dest.VehiclesCount, opt => opt.MapFrom(src => src.nVehiclesCount))
                .ForMember(dest => dest.ServiceOperator, opt => opt.MapFrom(src => src.strServiceOperator))
                .ForMember(dest => dest.IncidentAdditionalInfo, opt => opt.MapFrom(src => src.strIncidentAdditionalInfo))
                .ForMember(dest => dest.VehicleRegNumberReadOnly, opt => opt.MapFrom(src => src.strVehicleRegNumberReadOnly))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.DenialOfService, opt => opt.MapFrom(src => src.dtDenialOfService))
                .ForMember(dest => dest.RegionData, opt => opt.MapFrom(src => src.regionData))
                .ForMember(dest => dest.CriminalDescriptionList, opt => opt.MapFrom(src => src.m_CriminalDescriptionList))
                .ForMember(dest => dest.LostPeopleDescriptionList, opt => opt.MapFrom(src => src.m_LostPeopleDescriptionList))
                .ForMember(dest => dest.VehicleList, opt => opt.MapFrom(src => src.m_VehicleList))
                .ForMember(dest => dest.VictimList, opt => opt.MapFrom(src => src.m_VictimList))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_OVD_Data, CardOVDModel>()
                .ForMember(dest => dest.EmergencyCardId, opt => opt.MapFrom(src => src.nEmergencyCardId))
                .ForMember(dest => dest.Inspector, opt => opt.MapFrom(src => src.strInspector))
                .ForMember(dest => dest.StatusId, opt => opt.MapFrom(src => src.nStatusId))
                .ForMember(dest => dest.IntrinsicOVD, opt => opt.MapFrom(src => src.strIntrinsicOVD_N))
                .ForMember(dest => dest.RegDate, opt => opt.MapFrom(src => src.dtRegDate))
                .ForMember(dest => dest.DocNumber, opt => opt.MapFrom(src => src.strDocNumber))
                .ForMember(dest => dest.Page, opt => opt.MapFrom(src => src.strPage))
                .ForMember(dest => dest.Solved, opt => opt.MapFrom(src => src.lSolved))
                .ForMember(dest => dest.OVDITypeId, opt => opt.MapFrom(src => src.nOVDITypeId))
                .ForMember(dest => dest.IntrinsicDPS, opt => opt.MapFrom(src => src.strIntrinsicDPS_N))
                .ForMember(dest => dest.IsVideoObservation, opt => opt.MapFrom(src => src.isVideoObservation))
                .ForMember(dest => dest.IsSuspectedPerson, opt => opt.MapFrom(src => src.isSuspectedPerson))
                .ForMember(dest => dest.IsEvidence, opt => opt.MapFrom(src => src.isEvidence))
                .ForMember(dest => dest.IsSkRfStuff, opt => opt.MapFrom(src => src.isSkRfStuff))
                .ForMember(dest => dest.PastEventId, opt => opt.MapFrom(src => src.nPastEventId))
                .ForMember(dest => dest.DepartureResultId, opt => opt.MapFrom(src => src.nDepartureResultId))
                .ForMember(dest => dest.TaskForceItemsList, opt => opt.MapFrom(src => src.taskForceItemsList))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_03_Data, Card03Model>()
                .ForMember(dest => dest.GeneralData, opt => opt.MapFrom(src => src.generalData))
                .ForMember(dest => dest.DailyId, opt => opt.MapFrom(src => src.nDailyId))
                .ForMember(dest => dest.IsTransportation, opt => opt.MapFrom(src => src.isTransportation))
                .ForMember(dest => dest.SickCount, opt => opt.MapFrom(src => src.nSickCount))
                .ForMember(dest => dest.CompleteStatus, opt => opt.MapFrom(src => src.nCompleteStatus))
                .ForMember(dest => dest.HospitalId, opt => opt.MapFrom(src => src.nHospitalId))
                .ForMember(dest => dest.DstHospitalId, opt => opt.MapFrom(src => src.nDstHospitalId))
                .ForMember(dest => dest.TransportationId, opt => opt.MapFrom(src => src.nTransportationId))
                .ForMember(dest => dest.TransportReasonId, opt => opt.MapFrom(src => src.nTransportReasonId))
                .ForMember(dest => dest.Closed, opt => opt.MapFrom(src => src.dtClosed))
                .ForMember(dest => dest.Admission, opt => opt.MapFrom(src => src.dtAdmission))
                .ForMember(dest => dest.DeliveredTo, opt => opt.MapFrom(src => src.strDeliveredTo))
                .ForMember(dest => dest.TeamMessage, opt => opt.MapFrom(src => src.strTeamMessage))
                .ForMember(dest => dest.CloseReason, opt => opt.MapFrom(src => src.strCloseReason))
                .ForMember(dest => dest.DuplicateStatus, opt => opt.MapFrom(src => src.nDuplicateStatus))
                .ForMember(dest => dest.OriginalCardId, opt => opt.MapFrom(src => src.nOriginalCardId))
                .ForMember(dest => dest.RecomendedDepId, opt => opt.MapFrom(src => src.nRecomendedDepId))
                .ForMember(dest => dest.SickPersonsInfo, opt => opt.MapFrom(src => src.strSickPersonsInfo))
                .ForMember(dest => dest.SickPersonsReasons, opt => opt.MapFrom(src => src.strSickPersonsReasons))
                .ForMember(dest => dest.SickPersonsPriorities, opt => opt.MapFrom(src => src.strSickPersonsPriorities))
                .ForMember(dest => dest.EnginesInfo, opt => opt.MapFrom(src => src.strEnginesInfo))
                .ForMember(dest => dest.IsFreeTransport, opt => opt.MapFrom(src => src.isFreeTransport))
                .ForMember(dest => dest.IsTransfered, opt => opt.MapFrom(src => src.isTransfered))
                .ForMember(dest => dest.ServiceCardCreate, opt => opt.MapFrom(src => src.dtServiceCardCreate))
                .ForMember(dest => dest.IncidentAdditionalInfo, opt => opt.MapFrom(src => src.strIncidentAdditionalInfo))
                .ForMember(dest => dest.ServiceCardView, opt => opt.MapFrom(src => src.dtServiceCardView))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.dtServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.dtServiceCardWorkNext))
                .ForMember(dest => dest.ServiceCardComplete, opt => opt.MapFrom(src => src.dtServiceCardComplete))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.nServiceIncidentTypeId))
                .ForMember(dest => dest.WhoCalled, opt => opt.MapFrom(src => src.strWhoCalled))
                .ForMember(dest => dest.WhoCalledId, opt => opt.MapFrom(src => src.nWhoCalledId))
                .ForMember(dest => dest.HaveChildren, opt => opt.MapFrom(src => src.haveChildren))
                .ForMember(dest => dest.ServiceOperator, opt => opt.MapFrom(src => src.strServiceOperator))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.strRegistrationNumber))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.DenialOfService, opt => opt.MapFrom(src => src.dtDenialOfService))
                .ForMember(dest => dest.IsVehicleInvolved, opt => opt.MapFrom(src => src.isVehicleInvolved))
                .ForMember(dest => dest.SickPersons, opt => opt.MapFrom(src => src.sickPersons))
                .ForMember(dest => dest.InvolvedVehicles, opt => opt.MapFrom(src => src.involvedVehicles))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_CommServ_Data, CardCommServModel>()
                .ForMember(dest => dest.GeneralData, opt => opt.MapFrom(src => src.m_GeneralData))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.strMessage))
                .ForMember(dest => dest.ObjectInfo, opt => opt.MapFrom(src => src.strObjectInfo))
                .ForMember(dest => dest.HumanThreat, opt => opt.MapFrom(src => src.lHumanThreat))
                .ForMember(dest => dest.EmergencyFlag, opt => opt.MapFrom(src => src.lEmergencyFlag))
                .ForMember(dest => dest.Depart, opt => opt.MapFrom(src => src.dtDepart))
                .ForMember(dest => dest.Arrival, opt => opt.MapFrom(src => src.dtArrival))
                .ForMember(dest => dest.ObjectTypeId, opt => opt.MapFrom(src => src.nObjectTypeId))
                .ForMember(dest => dest.Complete, opt => opt.MapFrom(src => src.dtComplete))
                .ForMember(dest => dest.CompleteStatus, opt => opt.MapFrom(src => src.nCompleteStatus))
                .ForMember(dest => dest.UsedMeans, opt => opt.MapFrom(src => src.strUsedMeans))
                .ForMember(dest => dest.DeadlineExceeded, opt => opt.MapFrom(src => src.dtDeadlineExceeded))
                .ForMember(dest => dest.DeclarantNotify, opt => opt.MapFrom(src => src.dtDeclarantNotify))
                .ForMember(dest => dest.AgentWhoNotifies, opt => opt.MapFrom(src => src.strAgentWhoNotifies))
                .ForMember(dest => dest.ServiceCardCreate, opt => opt.MapFrom(src => src.dtServiceCardCreate))
                .ForMember(dest => dest.ServiceCardView, opt => opt.MapFrom(src => src.dtServiceCardView))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.dtServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.dtServiceCardWorkNext))
                .ForMember(dest => dest.ServiceCardComplete, opt => opt.MapFrom(src => src.dtServiceCardComplete))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.nServiceIncidentTypeId))
                .ForMember(dest => dest.CommunityServiceId, opt => opt.MapFrom(src => src.nCommunityServiceId))
                .ForMember(dest => dest.InstructionId, opt => opt.MapFrom(src => src.nInstructionId))
                .ForMember(dest => dest.IsConsulting, opt => opt.MapFrom(src => src.lIsConsulting))
                .ForMember(dest => dest.ServiceOperator, opt => opt.MapFrom(src => src.strServiceOperator))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.strRegistrationNumber))
                .ForMember(dest => dest.Measures, opt => opt.MapFrom(src => src.strMeasures))
                .ForMember(dest => dest.ServiceIncidentCategoryId, opt => opt.MapFrom(src => src.nServiceIncidentCategoryId))
                .ForMember(dest => dest.UKID, opt => opt.MapFrom(src => src.nUKID))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.DenialOfService, opt => opt.MapFrom(src => src.dtDenialOfService))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_Card_AT_Data, CardATModel>()
                .ForMember(dest => dest.GeneralData, opt => opt.MapFrom(src => src.m_GeneralData))
                .ForMember(dest => dest.WhatHappened, opt => opt.MapFrom(src => src.strWhatHappened))
                .ForMember(dest => dest.Measures, opt => opt.MapFrom(src => src.strMeasures))
                .ForMember(dest => dest.Damage, opt => opt.MapFrom(src => src.strDamage))
                .ForMember(dest => dest.ServiceCardCreate, opt => opt.MapFrom(src => src.dtServiceCardCreate))
                .ForMember(dest => dest.ServiceCardView, opt => opt.MapFrom(src => src.dtServiceCardView))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.dtServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.dtServiceCardWorkNext))
                .ForMember(dest => dest.ServiceCardComplete, opt => opt.MapFrom(src => src.dtServiceCardComplete))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.ServiceOperator, opt => opt.MapFrom(src => src.strServiceOperator))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.strRegistrationNumber))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.nServiceIncidentTypeId))
                .ForMember(dest => dest.Died, opt => opt.MapFrom(src => src.nDied))
                .ForMember(dest => dest.Victims, opt => opt.MapFrom(src => src.nVictims))
                .ForMember(dest => dest.Suspects, opt => opt.MapFrom(src => src.nSuspects))
                .ForMember(dest => dest.SuspectsDesc, opt => opt.MapFrom(src => src.strSuspectsDesc))
                .ForMember(dest => dest.SuspectsEquipment, opt => opt.MapFrom(src => src.strSuspectsEquipment))
                .ForMember(dest => dest.SuspectsVehicles, opt => opt.MapFrom(src => src.strSuspectsVehicles))
                .ForMember(dest => dest.SuspectsDirection, opt => opt.MapFrom(src => src.strSuspectsDirection))
                .ForMember(dest => dest.SuspectsInjury, opt => opt.MapFrom(src => src.strSuspectsInjury))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.DenialOfService, opt => opt.MapFrom(src => src.dtDenialOfService))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceCard01, ServiceCard01Model>()
                .ForMember(dest => dest.Card112Data, opt => opt.MapFrom(src => src.card112Data))
                .ForMember(dest => dest.Card01Data, opt => opt.MapFrom(src => src.card01Data))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceCard02, ServiceCard02Model>()
                .ForMember(dest => dest.Card112Data, opt => opt.MapFrom(src => src.card112Data))
                .ForMember(dest => dest.Card02Data, opt => opt.MapFrom(src => src.card02Data))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceCard03, ServiceCard03Model>()
                .ForMember(dest => dest.Card112Data, opt => opt.MapFrom(src => src.card112Data))
                .ForMember(dest => dest.Card03Data, opt => opt.MapFrom(src => src.card03Data))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceCard04, ServiceCard04Model>()
                .ForMember(dest => dest.Card112Data, opt => opt.MapFrom(src => src.card112Data))
                .ForMember(dest => dest.Card04Data, opt => opt.MapFrom(src => src.card04Data))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceCardCommServ, ServiceCardCommServModel>()
                .ForMember(dest => dest.Card112Data, opt => opt.MapFrom(src => src.card112Data))
                .ForMember(dest => dest.CardCommServData, opt => opt.MapFrom(src => src.cardCommServData))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceCardAT, ServiceCardATModel>()
                .ForMember(dest => dest.Card112Data, opt => opt.MapFrom(src => src.card112Data))
                .ForMember(dest => dest.CardATData, opt => opt.MapFrom(src => src.cardATData))
                .ReverseMapWithValidation();

            cfg.CreateMap<PrevDeclarantInfo, PrevDeclarantInfoModel>()
                .ForMember(dest => dest.PrevDeclarantLastName, opt => opt.MapFrom(src => src.strPrevDeclarantLastName))
                .ForMember(dest => dest.PrevDeclarantName, opt => opt.MapFrom(src => src.strPrevDeclarantName))
                .ForMember(dest => dest.PrevDeclarantMiddleName, opt => opt.MapFrom(src => src.strPrevDeclarantMiddleName))
                .ForMember(dest => dest.PrevCallerContactPhone, opt => opt.MapFrom(src => src.strPrevCallerContactPhone))
                .ForMember(dest => dest.PrevDeclarantCityId, opt => opt.MapFrom(src => src.nPrevDeclarantCityId))
                .ForMember(dest => dest.PrevDeclarantDistrictId, opt => opt.MapFrom(src => src.nPrevDeclarantDistrictId))
                .ForMember(dest => dest.PrevDeclarantStreetId, opt => opt.MapFrom(src => src.nPrevDeclarantStreetId))
                .ForMember(dest => dest.PrevDeclarantBuildingNumber, opt => opt.MapFrom(src => src.strPrevDeclarantBuildingNumber))
                .ForMember(dest => dest.PrevDeclarantCorps, opt => opt.MapFrom(src => src.strPrevDeclarantCorps))
                .ForMember(dest => dest.PrevDeclarantFlat, opt => opt.MapFrom(src => src.strPrevDeclarantFlat))
                .ReverseMapWithValidation();

            cfg.CreateMap<CallCenterConnectionInfo, CallCenterConnectionInfoModel>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ReverseMapWithValidation();

            cfg.CreateMap<AttachmentList, AttachmentListModel>()
                .ForMember(dest => dest.Attachments, opt => opt.MapFrom(src => src.attachments))
                .ReverseMapWithValidation();

            cfg.CreateMap<AttachmentData, AttachmentDataModel>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.url))
                .ForMember(dest => dest.Postdata, opt => opt.MapFrom(src => src.postdata))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.data))
                .ReverseMapWithValidation();

            cfg.CreateMap<AttachmentContent, AttachmentContentModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.title))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.type))
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.data))
                .ReverseMapWithValidation();
                                 
            cfg.CreateMap<GeographicLocation, GeographicLocationModel>()
                .ForMember(dest => dest.M_dLatitude, opt => opt.MapFrom(src => src.m_dLatitude))
                .ForMember(dest => dest.M_dLongitude, opt => opt.MapFrom(src => src.m_dLongitude))
                .ReverseMapWithValidation();

            cfg.CreateMap<CamertonEngine, CamertonEngineModel>()
                .ForMember(dest => dest.EngineId, opt => opt.MapFrom(src => src.engineId))
                .ForMember(dest => dest.GeographicLocation, opt => opt.MapFrom(src => src.geographicLocation))
                .ForMember(dest => dest.AdditionalInfo, opt => opt.MapFrom(src => src.additionalInfo))
                .ForMember(dest => dest.IconUrl, opt => opt.MapFrom(src => src.iconUrl))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardCommServFilter, CardCommServFilterModel>()
                .ForMember(dest => dest.ServiceIncidentCategoryId, opt => opt.MapFrom(src => src.nServiceIncidentCategoryId))
                .ForMember(dest => dest.IsDeadlineExceeded, opt => opt.MapFrom(src => src.isDeadlineExceeded))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card03Filter, Card03FilterModel>()
                .ForMember(dest => dest.IsTransfered, opt => opt.MapFrom(src => src.isTransfered))
                .ForMember(dest => dest.IsFilterEngine3, opt => opt.MapFrom(src => src.isFilterEngine3))
                .ForMember(dest => dest.IsFilterEngine2, opt => opt.MapFrom(src => src.isFilterEngine2))
                .ForMember(dest => dest.HospitalId, opt => opt.MapFrom(src => src.nHospitalId))
                .ForMember(dest => dest.StreetId, opt => opt.MapFrom(src => src.nStreetId))
                .ForMember(dest => dest.ReasonId, opt => opt.MapFrom(src => src.nReasonId))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.strAge))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.nGender))
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.nCardId))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card112Filter, Card112FilterModel>()
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.nCardId))
                .ForMember(dest => dest.BeginPeriod, opt => opt.MapFrom(src => src.dtBeginPeriod))
                .ForMember(dest => dest.EndPeriod, opt => opt.MapFrom(src => src.dtEndPeriod))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.strPhoneNumber))
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => src.nServiceId))
                .ForMember(dest => dest.LocalDistrictId, opt => opt.MapFrom(src => src.nLocalDistrictId))
                .ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.nDistrictId))
                .ForMember(dest => dest.StreetId, opt => opt.MapFrom(src => src.nStreetId))
                .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src.strBuilding))
                .ForMember(dest => dest.AgentLogin, opt => opt.MapFrom(src => src.strAgentLogin))
                .ForMember(dest => dest.CallerContactPhone, opt => opt.MapFrom(src => src.strCallerContactPhone))
                .ForMember(dest => dest.DeclarantLastName, opt => opt.MapFrom(src => src.strDeclarantLastName))
                .ForMember(dest => dest.CompleteStatus, opt => opt.MapFrom(src => src.completeStatus))
                .ForMember(dest => dest.ImportanceLevel, opt => opt.MapFrom(src => src.importanceLevel))
                .ForMember(dest => dest.Completed, opt => opt.MapFrom(src => src.lCompleted))
                .ForMember(dest => dest.IsUnwatched, opt => opt.MapFrom(src => src.isUnwatched))
                .ForMember(dest => dest.IncidentDescription, opt => opt.MapFrom(src => src.strIncidentDescription))
                .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.dtDeadline))
                .ForMember(dest => dest.IsDayly, opt => opt.MapFrom(src => src.isDayly))
                .ForMember(dest => dest.IncidentTypeId, opt => opt.MapFrom(src => src.nIncidentTypeId))
                .ForMember(dest => dest.IsPriority, opt => opt.MapFrom(src => src.isPriority))
                .ForMember(dest => dest.CardCommServFilter, opt => opt.MapFrom(src => src.CardCommServFilter))
                .ForMember(dest => dest.TestCard, opt => opt.MapFrom(src => src.lTestCard))
                .ForMember(dest => dest.Card03Filter, opt => opt.MapFrom(src => src.Card03Filter))
                .ForMember(dest => dest.Card02Filter, opt => opt.MapFrom(src => src.Card02Filter))
                .ForMember(dest => dest.IsServiceTypeIdCorrect, opt => opt.MapFrom(src => src.isServiceTypeIdCorrect))
                .ForMember(dest => dest.WithEmptyStreet, opt => opt.MapFrom(src => src.withEmptyStreet))
                .ForMember(dest => dest.DeclarantName, opt => opt.MapFrom(src => src.strDeclarantName))
                .ForMember(dest => dest.DeclarantMiddleName, opt => opt.MapFrom(src => src.strDeclarantMiddleName))
                .ForMember(dest => dest.WithEmptyLocalDistrict, opt => opt.MapFrom(src => src.withEmptyLocalDistrict))
                .ForMember(dest => dest.AdditionalLocationInfo, opt => opt.MapFrom(src => src.strAdditionalLocationInfo))
                .ForMember(dest => dest.DeclarantLocalDistrictId, opt => opt.MapFrom(src => src.nDeclarantLocalDistrictId))
                .ForMember(dest => dest.WithEmptyDeclarantLocalDistrict, opt => opt.MapFrom(src => src.withEmptyDeclarantLocalDistrict))
                .ForMember(dest => dest.DeclarantStreetId, opt => opt.MapFrom(src => src.nDeclarantStreetId))
                .ForMember(dest => dest.WithEmptyDeclarantStreet, opt => opt.MapFrom(src => src.withEmptyDeclarantStreet))
                .ForMember(dest => dest.DeclarantBuildingNumber, opt => opt.MapFrom(src => src.strDeclarantBuildingNumber))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.nRegionId))
                .ForMember(dest => dest.ServiceCount, opt => opt.MapFrom(src => src.nServiceCount))
                .ForMember(dest => dest.Control, opt => opt.MapFrom(src => src.control))
                .ForMember(dest => dest.WithEmptyCity, opt => opt.MapFrom(src => src.withEmptyCity))
                .ForMember(dest => dest.WasInDenialOfService, opt => opt.MapFrom(src => src.wasInDenialOfService))
                .ForMember(dest => dest.CallTypeIds, opt => opt.MapFrom(src => src.nCallTypeIds))
                .ForMember(dest => dest.SourceTypeIds, opt => opt.MapFrom(src => src.nSourceTypeIds))
                .ForMember(dest => dest.CardSyntheticStateIds, opt => opt.MapFrom(src => src.nCardSyntheticStateIds))
                .ForMember(dest => dest.DepartmentIds, opt => opt.MapFrom(src => src.nDepartmentIds))
                .ForMember(dest => dest.IncidentTypeIds, opt => opt.MapFrom(src => src.nIncidentTypeIds))
                .ForMember(dest => dest.CityIds, opt => opt.MapFrom(src => src.cityIds))
                .ForMember(dest => dest.ExcludeExternalCreatorsList, opt => opt.MapFrom(src => src.excludeExternalCreatorsList))
                .ReverseMapWithValidation();

            cfg.CreateMap<ValidationRule, ValidationRuleModel>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.CompareField, opt => opt.MapFrom(src => src.CompareField))
                .ForMember(dest => dest.CompareValue, opt => opt.MapFrom(src => src.CompareValue))
                .ForMember(dest => dest.CommandProperty, opt => opt.MapFrom(src => src.CommandProperty))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card112Validation, Card112ValidationModel>()
                .ForMember(dest => dest.IncidentTypeId, opt => opt.MapFrom(src => src.IncidentTypeId))
                .ForMember(dest => dest.SelectedSubCallType, opt => opt.MapFrom(src => src.SelectedSubCallType))
                .ForMember(dest => dest.IsTraining, opt => opt.MapFrom(src => src.IsTraining))
                .ForMember(dest => dest.IsPriority, opt => opt.MapFrom(src => src.IsPriority))
                .ForMember(dest => dest.StreetID, opt => opt.MapFrom(src => src.StreetID))
                .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(src => src.DistrictID))
                .ForMember(dest => dest.CityID, opt => opt.MapFrom(src => src.CityID))
                .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src.Building))
                .ForMember(dest => dest.Corps, opt => opt.MapFrom(src => src.Corps))
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.Room))
                .ForMember(dest => dest.Entrance, opt => opt.MapFrom(src => src.Entrance))
                .ForMember(dest => dest.EntranceCode, opt => opt.MapFrom(src => src.EntranceCode))
                .ForMember(dest => dest.ObjectId, opt => opt.MapFrom(src => src.ObjectId))
                .ForMember(dest => dest.Floor, opt => opt.MapFrom(src => src.Floor))
                .ForMember(dest => dest.TotalFloors, opt => opt.MapFrom(src => src.TotalFloors))
                .ForMember(dest => dest.AddressStrip, opt => opt.MapFrom(src => src.AddressStrip))
                .ForMember(dest => dest.AdditionalLocationInfo, opt => opt.MapFrom(src => src.AdditionalLocationInfo))
                .ForMember(dest => dest.IsIncident, opt => opt.MapFrom(src => src.IsIncident))
                .ForMember(dest => dest.IsHumanThreat, opt => opt.MapFrom(src => src.IsHumanThreat))
                .ForMember(dest => dest.CCMC_TypeId, opt => opt.MapFrom(src => src.CCMC_TypeId))
                .ForMember(dest => dest.IncidentDescription, opt => opt.MapFrom(src => src.IncidentDescription))
                .ForMember(dest => dest.DeclarantLastName, opt => opt.MapFrom(src => src.DeclarantLastName))
                .ForMember(dest => dest.DeclarantName, opt => opt.MapFrom(src => src.DeclarantName))
                .ForMember(dest => dest.DeclarantMiddleName, opt => opt.MapFrom(src => src.DeclarantMiddleName))
                .ForMember(dest => dest.AgeYear, opt => opt.MapFrom(src => src.AgeYear))
                .ForMember(dest => dest.CallerContactPhone, opt => opt.MapFrom(src => src.CallerContactPhone))
                .ForMember(dest => dest.DeclarantStatusId, opt => opt.MapFrom(src => src.DeclarantStatusId))
                .ForMember(dest => dest.DeclarantStreetId, opt => opt.MapFrom(src => src.DeclarantStreetId))
                .ForMember(dest => dest.DeclarantDistrictId, opt => opt.MapFrom(src => src.DeclarantDistrictId))
                .ForMember(dest => dest.DeclarantCityId, opt => opt.MapFrom(src => src.DeclarantCityId))
                .ForMember(dest => dest.DeclarantBuildingNumber, opt => opt.MapFrom(src => src.DeclarantBuildingNumber))
                .ForMember(dest => dest.DeclarantCorps, opt => opt.MapFrom(src => src.DeclarantCorps))
                .ForMember(dest => dest.DeclarantFlat, opt => opt.MapFrom(src => src.DeclarantFlat))
                .ForMember(dest => dest.DeclarantAddress, opt => opt.MapFrom(src => src.DeclarantAddress))
                .ForMember(dest => dest.Coordinates, opt => opt.MapFrom(src => src.Coordinates))
                .ForMember(dest => dest.IsCrossroad, opt => opt.MapFrom(src => src.IsCrossroad))
                .ForMember(dest => dest.CgPN, opt => opt.MapFrom(src => src.CgPN))
                .ForMember(dest => dest.AdditionalStreetId, opt => opt.MapFrom(src => src.AdditionalStreetId))
                .ForMember(dest => dest.LocalDistrictId, opt => opt.MapFrom(src => src.LocalDistrictId))
                .ForMember(dest => dest.IsNear, opt => opt.MapFrom(src => src.IsNear))
                .ForMember(dest => dest.Km, opt => opt.MapFrom(src => src.Km))
                .ForMember(dest => dest.Casualties, opt => opt.MapFrom(src => src.Casualties))
                .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId))
                .ForMember(dest => dest.DeclarantLocalDistrictId, opt => opt.MapFrom(src => src.DeclarantLocalDistrictId))
                .ForMember(dest => dest.FloorString, opt => opt.MapFrom(src => src.FloorString))
                .ForMember(dest => dest.Structure, opt => opt.MapFrom(src => src.Structure))
                .ForMember(dest => dest.DeclarantStructure, opt => opt.MapFrom(src => src.DeclarantStructure))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card01Validation, Card01ValidationModel>()
                .ForMember(dest => dest.FireIncidentTypeID, opt => opt.MapFrom(src => src.FireIncidentTypeID))
                .ForMember(dest => dest.FirePreventionTypeID, opt => opt.MapFrom(src => src.FirePreventionTypeID))
                .ForMember(dest => dest.ObjectId, opt => opt.MapFrom(src => src.ObjectId))
                .ForMember(dest => dest.ObjectGasified, opt => opt.MapFrom(src => src.ObjectGasified))
                .ForMember(dest => dest.ObjectOwner, opt => opt.MapFrom(src => src.ObjectOwner))
                .ForMember(dest => dest.Ownership, opt => opt.MapFrom(src => src.Ownership))
                .ForMember(dest => dest.ObjectTypeId, opt => opt.MapFrom(src => src.ObjectTypeId))
                .ForMember(dest => dest.ObjectAdditionalInfo, opt => opt.MapFrom(src => src.ObjectAdditionalInfo))
                .ForMember(dest => dest.ReactionPlanId, opt => opt.MapFrom(src => src.ReactionPlanId))
                .ForMember(dest => dest.FireClassId, opt => opt.MapFrom(src => src.FireClassId))
                .ForMember(dest => dest.InternalCardNumber, opt => opt.MapFrom(src => src.InternalCardNumber))
                .ForMember(dest => dest.Shift, opt => opt.MapFrom(src => src.Shift))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message))
                .ForMember(dest => dest.WaterConsumption, opt => opt.MapFrom(src => src.WaterConsumption))
                .ForMember(dest => dest.FirstFireBarrel, opt => opt.MapFrom(src => src.FirstFireBarrel))
                .ForMember(dest => dest.WaterSourceID, opt => opt.MapFrom(src => src.WaterSourceID))
                .ForMember(dest => dest.PerishedPeople, opt => opt.MapFrom(src => src.PerishedPeople))
                .ForMember(dest => dest.PerishedChildren, opt => opt.MapFrom(src => src.PerishedChildren))
                .ForMember(dest => dest.PerishedCollaborators, opt => opt.MapFrom(src => src.PerishedCollaborators))
                .ForMember(dest => dest.Wounded, opt => opt.MapFrom(src => src.Wounded))
                .ForMember(dest => dest.WoundedChildren, opt => opt.MapFrom(src => src.WoundedChildren))
                .ForMember(dest => dest.WoundedCollaborators, opt => opt.MapFrom(src => src.WoundedCollaborators))
                .ForMember(dest => dest.SavedPeople, opt => opt.MapFrom(src => src.SavedPeople))
                .ForMember(dest => dest.SavedChildren, opt => opt.MapFrom(src => src.SavedChildren))
                .ForMember(dest => dest.BrokenLivingConditions, opt => opt.MapFrom(src => src.BrokenLivingConditions))
                .ForMember(dest => dest.BrokenLivingConditionsChildren, opt => opt.MapFrom(src => src.BrokenLivingConditionsChildren))
                .ForMember(dest => dest.FireReasonID, opt => opt.MapFrom(src => src.FireReasonID))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.DamageCost, opt => opt.MapFrom(src => src.DamageCost))
                .ForMember(dest => dest.SavedCost, opt => opt.MapFrom(src => src.SavedCost))
                .ForMember(dest => dest.Space, opt => opt.MapFrom(src => src.Space))
                .ForMember(dest => dest.FireDistance, opt => opt.MapFrom(src => src.FireDistance))
                .ForMember(dest => dest.PoliceInterest, opt => opt.MapFrom(src => src.PoliceInterest))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.ServiceIncidentTypeId))
                .ForMember(dest => dest.FireStartEstimate, opt => opt.MapFrom(src => src.FireStartEstimate))
                .ForMember(dest => dest.FireResults, opt => opt.MapFrom(src => src.FireResults))
                .ForMember(dest => dest.NumberStoreys, opt => opt.MapFrom(src => src.NumberStoreys))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardForceValidation, CardForceValidationModel>()
                .ForMember(dest => dest.Localization, opt => opt.MapFrom(src => src.Localization))
                .ForMember(dest => dest.Liquidation, opt => opt.MapFrom(src => src.Liquidation))
                .ForMember(dest => dest.OpenFireLiquidation, opt => opt.MapFrom(src => src.OpenFireLiquidation))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card02Validation, Card02ValidationModel>()
                .ForMember(dest => dest.ITypeID, opt => opt.MapFrom(src => src.ITypeID))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.RegistrationNumber))
                .ForMember(dest => dest.RegistrationDepartmentID, opt => opt.MapFrom(src => src.RegistrationDepartmentID))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.ServiceIncidentTypeId))
                .ForMember(dest => dest.CriminalsCount, opt => opt.MapFrom(src => src.CriminalsCount))
                .ForMember(dest => dest.VehiclesCount, opt => opt.MapFrom(src => src.VehiclesCount))
                .ForMember(dest => dest.IncidentAdditionalInfo, opt => opt.MapFrom(src => src.IncidentAdditionalInfo))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardOvdValidation, CardOvdValidationModel>()
                .ForMember(dest => dest.IntrinsicOVD_N, opt => opt.MapFrom(src => src.IntrinsicOVD_N))
                .ForMember(dest => dest.IntrinsicDPS_N, opt => opt.MapFrom(src => src.IntrinsicDPS_N))
                .ForMember(dest => dest.Inspector, opt => opt.MapFrom(src => src.Inspector))
                .ForMember(dest => dest.DepartureResultId, opt => opt.MapFrom(src => src.DepartureResultId))
                .ForMember(dest => dest.IsSuspectedPerson, opt => opt.MapFrom(src => src.IsSuspectedPerson))
                .ForMember(dest => dest.IsEvidence, opt => opt.MapFrom(src => src.IsEvidence))
                .ForMember(dest => dest.IsVideoObservation, opt => opt.MapFrom(src => src.IsVideoObservation))
                .ForMember(dest => dest.IsSkRfStuff, opt => opt.MapFrom(src => src.IsSkRfStuff))
                .ForMember(dest => dest.PastEventId, opt => opt.MapFrom(src => src.PastEventId))
                .ForMember(dest => dest.StatusId, opt => opt.MapFrom(src => src.StatusId))
                .ForMember(dest => dest.RegDate, opt => opt.MapFrom(src => src.RegDate))
                .ForMember(dest => dest.DocNumber, opt => opt.MapFrom(src => src.DocNumber))
                .ForMember(dest => dest.Page, opt => opt.MapFrom(src => src.Page))
                .ForMember(dest => dest.SelectedMalefactionGroup, opt => opt.MapFrom(src => src.SelectedMalefactionGroup))
                .ForMember(dest => dest.OVDITypeId, opt => opt.MapFrom(src => src.OVDITypeId))
                .ForMember(dest => dest.Solved, opt => opt.MapFrom(src => src.Solved))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card02WantedValidation, Card02WantedValidationModel>()
                .ForMember(dest => dest.InLooksAge, opt => opt.MapFrom(src => src.InLooksAge))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.StatureID, opt => opt.MapFrom(src => src.StatureID))
                .ForMember(dest => dest.FigureID, opt => opt.MapFrom(src => src.FigureID))
                .ForMember(dest => dest.Exterior, opt => opt.MapFrom(src => src.Exterior))
                .ForMember(dest => dest.Extra, opt => opt.MapFrom(src => src.Extra))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.BirthdayDate, opt => opt.MapFrom(src => src.BirthdayDate))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card02SuspectValidation, Card02SuspectValidationModel>()
                .ForMember(dest => dest.InLooksAge, opt => opt.MapFrom(src => src.InLooksAge))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.StatureID, opt => opt.MapFrom(src => src.StatureID))
                .ForMember(dest => dest.FigureID, opt => opt.MapFrom(src => src.FigureID))
                .ForMember(dest => dest.Exterior, opt => opt.MapFrom(src => src.Exterior))
                .ForMember(dest => dest.Extra, opt => opt.MapFrom(src => src.Extra))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.BirthdayDate, opt => opt.MapFrom(src => src.BirthdayDate))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card02VehicleValidation, Card02VehicleValidationModel>()
                .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.Vendor))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.RegistrationNumber))
                .ForMember(dest => dest.Extra, opt => opt.MapFrom(src => src.Extra))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region))
                .ForMember(dest => dest.TypeId, opt => opt.MapFrom(src => src.TypeId))
                .ForMember(dest => dest.ColorId, opt => opt.MapFrom(src => src.ColorId))
                .ForMember(dest => dest.Hided, opt => opt.MapFrom(src => src.Hided))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card02VictimValidation, Card02VictimValidationModel>()
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                .ForMember(dest => dest.StreetId, opt => opt.MapFrom(src => src.StreetId))
                .ForMember(dest => dest.BuildingNumber, opt => opt.MapFrom(src => src.BuildingNumber))
                .ForMember(dest => dest.Corps, opt => opt.MapFrom(src => src.Corps))
                .ForMember(dest => dest.Flat, opt => opt.MapFrom(src => src.Flat))
                .ForMember(dest => dest.ContactPhone, opt => opt.MapFrom(src => src.ContactPhone))
                .ForMember(dest => dest.AdditionalInfo, opt => opt.MapFrom(src => src.AdditionalInfo))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card03Validation, Card03ValidationModel>()
                .ForMember(dest => dest.IsTransportation, opt => opt.MapFrom(src => src.IsTransportation))
                .ForMember(dest => dest.ObjectTypeId, opt => opt.MapFrom(src => src.ObjectTypeId))
                .ForMember(dest => dest.ObjectId, opt => opt.MapFrom(src => src.ObjectId))
                .ForMember(dest => dest.TransportReasonId, opt => opt.MapFrom(src => src.TransportReasonId))
                .ForMember(dest => dest.TransportationId, opt => opt.MapFrom(src => src.TransportationId))
                .ForMember(dest => dest.HospitalId, opt => opt.MapFrom(src => src.HospitalId))
                .ForMember(dest => dest.DstHospitalId, opt => opt.MapFrom(src => src.DstHospitalId))
                .ForMember(dest => dest.DeliveredTo, opt => opt.MapFrom(src => src.DeliveredTo))
                .ForMember(dest => dest.Admission, opt => opt.MapFrom(src => src.Admission))
                .ForMember(dest => dest.Closed, opt => opt.MapFrom(src => src.Closed))
                .ForMember(dest => dest.TeamMessage, opt => opt.MapFrom(src => src.TeamMessage))
                .ForMember(dest => dest.CloseReason, opt => opt.MapFrom(src => src.CloseReason))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.ServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.ServiceCardWorkNext))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.ServiceIncidentTypeId))
                .ForMember(dest => dest.WhoCalledId, opt => opt.MapFrom(src => src.WhoCalledId))
                .ForMember(dest => dest.HaveChildren, opt => opt.MapFrom(src => src.HaveChildren))
                .ForMember(dest => dest.IncidentAdditionalInfo, opt => opt.MapFrom(src => src.IncidentAdditionalInfo))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card03SickPersonValidation, Card03SickPersonValidationModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ReasonId, opt => opt.MapFrom(src => src.ReasonId))
                .ForMember(dest => dest.IsMale, opt => opt.MapFrom(src => src.IsMale))
                .ForMember(dest => dest.SickPersonSigns, opt => opt.MapFrom(src => src.SickPersonSigns))
                .ForMember(dest => dest.Birth, opt => opt.MapFrom(src => src.Birth))
                .ForMember(dest => dest.AgeYear, opt => opt.MapFrom(src => src.AgeYear))
                .ForMember(dest => dest.AgeMonth, opt => opt.MapFrom(src => src.AgeMonth))
                .ForMember(dest => dest.AgeDay, opt => opt.MapFrom(src => src.AgeDay))
                .ForMember(dest => dest.IsReasonPriority, opt => opt.MapFrom(src => src.IsReasonPriority))
                .ForMember(dest => dest.ConsultDiagnosId, opt => opt.MapFrom(src => src.ConsultDiagnosId))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.Age))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card04Validation, Card04ValidationModel>()
                .ForMember(dest => dest.WhatHappened, opt => opt.MapFrom(src => src.WhatHappened))
                .ForMember(dest => dest.CommunityServiceId, opt => opt.MapFrom(src => src.CommunityServiceId))
                .ForMember(dest => dest.CommunityServiceSituationId, opt => opt.MapFrom(src => src.CommunityServiceSituationId))
                .ForMember(dest => dest.Measures, opt => opt.MapFrom(src => src.Measures))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.ServiceIncidentTypeId))
                .ForMember(dest => dest.InstructionId, opt => opt.MapFrom(src => src.InstructionId))
                .ForMember(dest => dest.IsConsulting, opt => opt.MapFrom(src => src.IsConsulting))
                .ForMember(dest => dest.GasInstructions, opt => opt.MapFrom(src => src.GasInstructions))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.ServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.ServiceCardWorkNext))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardATValidation, CardATValidationModel>()
                .ForMember(dest => dest.WhatHappened, opt => opt.MapFrom(src => src.WhatHappened))
                .ForMember(dest => dest.Measures, opt => opt.MapFrom(src => src.Measures))
                .ForMember(dest => dest.Damage, opt => opt.MapFrom(src => src.Damage))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.ServiceIncidentTypeId))
                .ForMember(dest => dest.Died, opt => opt.MapFrom(src => src.Died))
                .ForMember(dest => dest.Victims, opt => opt.MapFrom(src => src.Victims))
                .ForMember(dest => dest.Suspects, opt => opt.MapFrom(src => src.Suspects))
                .ForMember(dest => dest.SuspectsDesc, opt => opt.MapFrom(src => src.SuspectsDesc))
                .ForMember(dest => dest.SuspectsEquipment, opt => opt.MapFrom(src => src.SuspectsEquipment))
                .ForMember(dest => dest.SuspectsVehicles, opt => opt.MapFrom(src => src.SuspectsVehicles))
                .ForMember(dest => dest.SuspectsDirection, opt => opt.MapFrom(src => src.SuspectsDirection))
                .ForMember(dest => dest.SuspectsInjury, opt => opt.MapFrom(src => src.SuspectsInjury))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.ServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.ServiceCardWorkNext))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardCommServValidation, CardCommServValidationModel>()
                .ForMember(dest => dest.CategoryCommServId, opt => opt.MapFrom(src => src.CategoryCommServId))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message))
                .ForMember(dest => dest.ObjectInfo, opt => opt.MapFrom(src => src.ObjectInfo))
                .ForMember(dest => dest.DeadlineExceeded, opt => opt.MapFrom(src => src.DeadlineExceeded))
                .ForMember(dest => dest.UsedMeans, opt => opt.MapFrom(src => src.UsedMeans))
                .ForMember(dest => dest.Depart, opt => opt.MapFrom(src => src.Depart))
                .ForMember(dest => dest.Arrival, opt => opt.MapFrom(src => src.Arrival))
                .ForMember(dest => dest.Complete, opt => opt.MapFrom(src => src.Complete))
                .ForMember(dest => dest.DeclarantNotify, opt => opt.MapFrom(src => src.DeclarantNotify))
                .ForMember(dest => dest.AgentWhoNotifies, opt => opt.MapFrom(src => src.AgentWhoNotifies))
                .ForMember(dest => dest.CommunityServiceId, opt => opt.MapFrom(src => src.CommunityServiceId))
                .ForMember(dest => dest.Measures, opt => opt.MapFrom(src => src.Measures))
                .ForMember(dest => dest.ManagementCompanyId, opt => opt.MapFrom(src => src.ManagementCompanyId))
                .ForMember(dest => dest.ObjectTypeId, opt => opt.MapFrom(src => src.ObjectTypeId))
                .ForMember(dest => dest.EmergencyFlag, opt => opt.MapFrom(src => src.EmergencyFlag))
                .ForMember(dest => dest.EmergencyFlagId, opt => opt.MapFrom(src => src.EmergencyFlagId))
                .ForMember(dest => dest.ServiceIncidentTypeId, opt => opt.MapFrom(src => src.ServiceIncidentTypeId))
                .ForMember(dest => dest.InstructionId, opt => opt.MapFrom(src => src.InstructionId))
                .ForMember(dest => dest.IsConsulting, opt => opt.MapFrom(src => src.IsConsulting))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardCustomServiceValidation, CardCustomServiceValidationModel>()
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.IncidentTypeId, opt => opt.MapFrom(src => src.IncidentTypeId))
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.DepartureAtTime, opt => opt.MapFrom(src => src.DepartureAtTime))
                .ForMember(dest => dest.ArrivedAtTime, opt => opt.MapFrom(src => src.ArrivedAtTime))
                .ForMember(dest => dest.Measures, opt => opt.MapFrom(src => src.Measures))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardCustomServiceValidationItem, CardCustomServiceValidationItemModel>()
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.ServiceTypeId))
                .ForMember(dest => dest.Validation, opt => opt.MapFrom(src => src.Validation))
                .ReverseMapWithValidation();

            cfg.CreateMap<Validations, ValidationsModel>()
                .ForMember(dest => dest.Card112, opt => opt.MapFrom(src => src.Card112))
                .ForMember(dest => dest.Card01, opt => opt.MapFrom(src => src.Card01))
                .ForMember(dest => dest.Card02, opt => opt.MapFrom(src => src.Card02))
                .ForMember(dest => dest.CardOvd, opt => opt.MapFrom(src => src.CardOvd))
                .ForMember(dest => dest.CardForce, opt => opt.MapFrom(src => src.CardForce))
                .ForMember(dest => dest.Card02Suspect, opt => opt.MapFrom(src => src.Card02Suspect))
                .ForMember(dest => dest.Card02Wanted, opt => opt.MapFrom(src => src.Card02Wanted))
                .ForMember(dest => dest.Card02Vehicle, opt => opt.MapFrom(src => src.Card02Vehicle))
                .ForMember(dest => dest.Card02Victim, opt => opt.MapFrom(src => src.Card02Victim))
                .ForMember(dest => dest.Card03, opt => opt.MapFrom(src => src.Card03))
                .ForMember(dest => dest.Card03SickPerson, opt => opt.MapFrom(src => src.Card03SickPerson))
                .ForMember(dest => dest.Card04, opt => opt.MapFrom(src => src.Card04))
                .ForMember(dest => dest.CardAT, opt => opt.MapFrom(src => src.CardAT))
                .ForMember(dest => dest.CardCommServ, opt => opt.MapFrom(src => src.CardCommServ))
                .ForMember(dest => dest.CardCustomServices, opt => opt.MapFrom(src => src.CardCustomServices))
                .ReverseMapWithValidation();

            cfg.CreateMap<ButtonCommand, ButtonCommandModel>()
                .ForMember(dest => dest.DefaultCommand, opt => opt.MapFrom(src => src.DefaultCommand))
                .ForMember(dest => dest.AdditionalCommand, opt => opt.MapFrom(src => src.AdditionalCommand))
                .ReverseMapWithValidation();

            cfg.CreateMap<RoleSettings, RoleSettingsModel>()
                .ForMember(dest => dest.SaveFileToXmlPath, opt => opt.MapFrom(src => src.SaveFileToXmlPath))
                .ForMember(dest => dest.Validations, opt => opt.MapFrom(src => src.Validations))
                .ForMember(dest => dest.RoleTitle, opt => opt.MapFrom(src => src.RoleTitle))
                .ForMember(dest => dest.CreateCardWithoutCall, opt => opt.MapFrom(src => src.CreateCardWithoutCall))
                .ForMember(dest => dest.ShowDuplicates, opt => opt.MapFrom(src => src.ShowDuplicates))
                .ForMember(dest => dest.EditCard, opt => opt.MapFrom(src => src.EditCard))
                .ForMember(dest => dest.FilterCards, opt => opt.MapFrom(src => src.FilterCards))
                .ForMember(dest => dest.ShowHistory, opt => opt.MapFrom(src => src.ShowHistory))
                .ForMember(dest => dest.LoadVoiceRecord, opt => opt.MapFrom(src => src.LoadVoiceRecord))
                .ForMember(dest => dest.DeadlineControl, opt => opt.MapFrom(src => src.DeadlineControl))
                .ForMember(dest => dest.ShowReports, opt => opt.MapFrom(src => src.ShowReports))
                .ForMember(dest => dest.CompleteOnSave, opt => opt.MapFrom(src => src.CompleteOnSave))
                .ForMember(dest => dest.CanCompleteCards, opt => opt.MapFrom(src => src.CanCompleteCards))
                .ForMember(dest => dest.GeoServerUser, opt => opt.MapFrom(src => src.GeoServerUser))
                .ForMember(dest => dest.CallTypeIdFilter, opt => opt.MapFrom(src => src.CallTypeIdFilter))
                .ForMember(dest => dest.DoNotUseCardDepartmentFilter, opt => opt.MapFrom(src => src.DoNotUseCardDepartmentFilter))
                .ForMember(dest => dest.IsImportanceLevelEnabled, opt => opt.MapFrom(src => src.IsImportanceLevelEnabled))
                .ForMember(dest => dest.ImportanceLevelDefaultValue, opt => opt.MapFrom(src => src.ImportanceLevelDefaultValue))
                .ForMember(dest => dest.UselessRefreshTimeout, opt => opt.MapFrom(src => src.UselessRefreshTimeout))
                .ForMember(dest => dest.ReportTimeout, opt => opt.MapFrom(src => src.ReportTimeout))
                .ForMember(dest => dest.ReportReadWriteTimeout, opt => opt.MapFrom(src => src.ReportReadWriteTimeout))
                .ForMember(dest => dest.PingerReadWriteTimeout, opt => opt.MapFrom(src => src.PingerReadWriteTimeout))
                .ForMember(dest => dest.ReadWriteTimeout, opt => opt.MapFrom(src => src.ReadWriteTimeout))
                .ForMember(dest => dest.LocalDistrictId, opt => opt.MapFrom(src => src.LocalDistrictId))
                .ForMember(dest => dest.AutoZoomLevel, opt => opt.MapFrom(src => src.AutoZoomLevel))
                .ForMember(dest => dest.MinZoomLevel, opt => opt.MapFrom(src => src.MinZoomLevel))
                .ForMember(dest => dest.MaxZoomLevel, opt => opt.MapFrom(src => src.MaxZoomLevel))
                .ForMember(dest => dest.ServiceType, opt => opt.MapFrom(src => src.ServiceType))
                .ForMember(dest => dest.TransferButtonCommand, opt => opt.MapFrom(src => src.TransferButtonCommand))
                .ForMember(dest => dest.InteractiveToolTipsEnabled, opt => opt.MapFrom(src => src.InteractiveToolTipsEnabled))
                .ForMember(dest => dest.CanSendMessage, opt => opt.MapFrom(src => src.CanSendMessage))
                .ForMember(dest => dest.CallCenterParameters, opt => opt.MapFrom(src => src.CallCenterParameters))
                .ForMember(dest => dest.GisPageSize, opt => opt.MapFrom(src => src.GisPageSize))
                .ForMember(dest => dest.IsCitySelectedInFilterDefault, opt => opt.MapFrom(src => src.IsCitySelectedInFilterDefault))
                .ForMember(dest => dest.RecordsFolderAccessDenied, opt => opt.MapFrom(src => src.RecordsFolderAccessDenied))
                .ForMember(dest => dest.CanShowRemoteLayers, opt => opt.MapFrom(src => src.CanShowRemoteLayers))
                .ForMember(dest => dest.NoCardCreationSiren, opt => opt.MapFrom(src => src.NoCardCreationSiren))
                .ForMember(dest => dest.ShowWeather, opt => opt.MapFrom(src => src.ShowWeather))
                .ForMember(dest => dest.WebRequestTimeout, opt => opt.MapFrom(src => src.WebRequestTimeout))
                .ForMember(dest => dest.SwitchToNormalModeWhenUnlockedOrAnsweredCall, opt => opt.MapFrom(src => src.SwitchToNormalModeWhenUnlockedOrAnsweredCall))
                .ForMember(dest => dest.DefaultSerfingModeFilterPeriod, opt => opt.MapFrom(src => src.DefaultSerfingModeFilterPeriod))
                .ForMember(dest => dest.MaxSerfingModeFilterPeriod, opt => opt.MapFrom(src => src.MaxSerfingModeFilterPeriod))
                .ForMember(dest => dest.ShowConferenceButton, opt => opt.MapFrom(src => src.ShowConferenceButton))
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.ServiceTypeId))
                .ForMember(dest => dest.IsCallTypeReadOnly, opt => opt.MapFrom(src => src.IsCallTypeReadOnly))
                .ForMember(dest => dest.UnviewedCardsHighlightColor, opt => opt.MapFrom(src => src.UnviewedCardsHighlightColor))
                .ForMember(dest => dest.CanOperator112SendSms, opt => opt.MapFrom(src => src.CanOperator112SendSms))
                .ForMember(dest => dest.MonitoringTabEnabled, opt => opt.MapFrom(src => src.MonitoringTabEnabled))
                .ForMember(dest => dest.CardListScrollThrottlingDelay, opt => opt.MapFrom(src => src.CardListScrollThrottlingDelay))
                .ForMember(dest => dest.ShowAttachments, opt => opt.MapFrom(src => src.ShowAttachments))
                .ForMember(dest => dest.CanCopyEraDataToDescription, opt => opt.MapFrom(src => src.CanCopyEraDataToDescription))
                .ForMember(dest => dest.CanOpenCardInNewWindow, opt => opt.MapFrom(src => src.CanOpenCardInNewWindow))
                .ForMember(dest => dest.SkipCallAppendToCallHistoryOnStatistics, opt => opt.MapFrom(src => src.SkipCallAppendToCallHistoryOnStatistics))
                .ForMember(dest => dest.CanOperator112SendChatMessage, opt => opt.MapFrom(src => src.CanOperator112SendChatMessage))
                .ForMember(dest => dest.KeepLogsLatestLaunches, opt => opt.MapFrom(src => src.KeepLogsLatestLaunches))
                .ForMember(dest => dest.KeepLogsLatestDays, opt => opt.MapFrom(src => src.KeepLogsLatestDays))
                .ForMember(dest => dest.DisableServicesChoiceWhenEmptyIncidentTypeId, opt => opt.MapFrom(src => src.DisableServicesChoiceWhenEmptyIncidentTypeId))
                .ForMember(dest => dest.ChangedAfterFirstSaveCardsHighlightColor, opt => opt.MapFrom(src => src.ChangedAfterFirstSaveCardsHighlightColor))
                .ForMember(dest => dest.ShowWithoutKsombFilterCheckbox, opt => opt.MapFrom(src => src.ShowWithoutKsombFilterCheckbox))
                .ForMember(dest => dest.ShowControlFilterCheckbox, opt => opt.MapFrom(src => src.ShowControlFilterCheckbox))
                .ForMember(dest => dest.DoNotShowAddressArea, opt => opt.MapFrom(src => src.DoNotShowAddressArea))
                .ForMember(dest => dest.EntranceOnlyDigits, opt => opt.MapFrom(src => src.EntranceOnlyDigits))
                .ForMember(dest => dest.EnableNewCustomServices, opt => opt.MapFrom(src => src.EnableNewCustomServices))
                .ForMember(dest => dest.IsShowChangeCoordinatesFormatButton, opt => opt.MapFrom(src => src.IsShowChangeCoordinatesFormatButton))
                .ForMember(dest => dest.EnableMandatoryAuthorization, opt => opt.MapFrom(src => src.EnableMandatoryAuthorization))
                .ForMember(dest => dest.IsDeadlinesTimerEnable, opt => opt.MapFrom(src => src.IsDeadlinesTimerEnable))
                .ForMember(dest => dest.Is112CallStatisticReportsShow, opt => opt.MapFrom(src => src.Is112CallStatisticReportsShow))
                .ForMember(dest => dest.MinimizeEraData, opt => opt.MapFrom(src => src.MinimizeEraData))
                .ForMember(dest => dest.CanChangeReactionOfCommServ, opt => opt.MapFrom(src => src.CanChangeReactionOfCommServ))
                .ForMember(dest => dest.SingleFieldCenterMapCoordinates, opt => opt.MapFrom(src => src.SingleFieldCenterMapCoordinates))
                .ForMember(dest => dest.IsSendServiceTypeIdForCallTransfer, opt => opt.MapFrom(src => src.IsSendServiceTypeIdForCallTransfer))
                .ForMember(dest => dest.SendSmsByCtrlEnter, opt => opt.MapFrom(src => src.SendSmsByCtrlEnter))
                .ForMember(dest => dest.ShowSmsTabInDuplicate, opt => opt.MapFrom(src => src.ShowSmsTabInDuplicate))
                .ForMember(dest => dest.ShowToWorkButton, opt => opt.MapFrom(src => src.ShowToWorkButton))
                .ForMember(dest => dest.ShowReactionButton, opt => opt.MapFrom(src => src.ShowReactionButton))
                .ForMember(dest => dest.ApplicastAddresses, opt => opt.MapFrom(src => src.ApplicastAddresses))
                .ForMember(dest => dest.MapTileUrls, opt => opt.MapFrom(src => src.MapTileUrls))
                .ForMember(dest => dest.MapUrls, opt => opt.MapFrom(src => src.MapUrls))
                .ForMember(dest => dest.ConsultUrls, opt => opt.MapFrom(src => src.ConsultUrls))
                .ForMember(dest => dest.MrsSettings, opt => opt.MapFrom(src => src.MrsSettings))
                .ForMember(dest => dest.OperatorCanEditCollection, opt => opt.MapFrom(src => src.OperatorCanEditCollection))
                .ForMember(dest => dest.AddressbookSettings, opt => opt.MapFrom(src => src.AddressbookSettings))
                .ForMember(dest => dest.CardHighlightCollection, opt => opt.MapFrom(src => src.CardHighlightCollection))
                .ForMember(dest => dest.DefaultVisibleLayers, opt => opt.MapFrom(src => src.DefaultVisibleLayers))
                .ForMember(dest => dest.DisableServicesChoiceForCallTypeIds, opt => opt.MapFrom(src => src.DisableServicesChoiceForCallTypeIds))
                .ForMember(dest => dest.DisallowToChangeOtherCallTypeIdsToTheseCallTypeIds, opt => opt.MapFrom(src => src.DisallowToChangeOtherCallTypeIdsToTheseCallTypeIds))
                .ForMember(dest => dest.DefaultInvolvedServiceTypeIds, opt => opt.MapFrom(src => src.DefaultInvolvedServiceTypeIds))
                .ReverseMapWithValidation();

            cfg.CreateMap<EmergencyCard, EmergencyCardModel>()
                .ForMember(dest => dest.Card112, opt => opt.MapFrom(src => src.card112))
                .ForMember(dest => dest.Card01, opt => opt.MapFrom(src => src.card01))
                .ForMember(dest => dest.Card02, opt => opt.MapFrom(src => src.card02))
                .ForMember(dest => dest.Card03, opt => opt.MapFrom(src => src.card03))
                .ForMember(dest => dest.Card04, opt => opt.MapFrom(src => src.card04))
                .ForMember(dest => dest.CardAT, opt => opt.MapFrom(src => src.cardAT))
                .ForMember(dest => dest.CardCommServ, opt => opt.MapFrom(src => src.cardCommServ))
                .ReverseMapWithValidation();

            cfg.CreateMap<OperatorCanEditItem, OperatorCanEditItemModel>()
                .ForMember(dest => dest.Card, opt => opt.MapFrom(src => src.Card))
                .ForMember(dest => dest.View, opt => opt.MapFrom(src => src.View))
                .ForMember(dest => dest.CanComplete, opt => opt.MapFrom(src => src.CanComplete))
                .ForMember(dest => dest.CanChangeState, opt => opt.MapFrom(src => src.CanChangeState))
                .ReverseMapWithValidation();

            cfg.CreateMap<EmergencyServersCollection, EmergencyServersCollectionModel>()
                .ForMember(dest => dest.EmergencyServers, opt => opt.MapFrom(src => src.emergencyServers))
                .ReverseMapWithValidation();

            cfg.CreateMap<EmergencyServerInfo, EmergencyServerInfoModel>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.IsFirstPriority, opt => opt.MapFrom(src => src.IsFirstPriority))
                .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.IsAvailable))
                .ReverseMapWithValidation();

            cfg.CreateMap<Weather, WeatherModel>()
                .ForMember(dest => dest.Temperature, opt => opt.MapFrom(src => src.temperature))
                .ForMember(dest => dest.Pressure, opt => opt.MapFrom(src => src.pressure))
                .ForMember(dest => dest.Clouds, opt => opt.MapFrom(src => src.clouds))
                .ForMember(dest => dest.WindDirection, opt => opt.MapFrom(src => src.windDirection))
                .ForMember(dest => dest.WindStrength, opt => opt.MapFrom(src => src.windStrength))
                .ForMember(dest => dest.Humidity, opt => opt.MapFrom(src => src.humidity))
                .ReverseMapWithValidation();

            cfg.CreateMap<WeatherLayer, WeatherLayerModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.description))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.longitude))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.latitude))
                .ForMember(dest => dest.Weather, opt => opt.MapFrom(src => src.weather))
                .ReverseMapWithValidation();

            cfg.CreateMap<AddressbookSetting, AddressbookSettingModel>()
                .ForMember(dest => dest.DbIp, opt => opt.MapFrom(src => src.DbIp))
                .ForMember(dest => dest.DbPort, opt => opt.MapFrom(src => src.DbPort))
                .ForMember(dest => dest.DbName, opt => opt.MapFrom(src => src.DbName))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                .ReverseMapWithValidation();

            cfg.CreateMap<AddressbookSettingsItem, AddressbookSettingsItemModel>()
                .ForMember(dest => dest.AddressbookSettings, opt => opt.MapFrom(src => src.AddressbookSettings))
                .ReverseMapWithValidation();

            cfg.CreateMap<VisualAttributes, VisualAttributesModel>()
                .ForMember(dest => dest.BackgroundColor, opt => opt.MapFrom(src => src.BackgroundColor))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardCondition, CardConditionModel>()
                .ForMember(dest => dest.IsComplex, opt => opt.MapFrom(src => src.IsComplex))
                .ForMember(dest => dest.IsPriority, opt => opt.MapFrom(src => src.IsPriority))
                .ForMember(dest => dest.IsIncident, opt => opt.MapFrom(src => src.IsIncident))
                .ForMember(dest => dest.IsTest, opt => opt.MapFrom(src => src.IsTest))
                .ForMember(dest => dest.IsControl, opt => opt.MapFrom(src => src.IsControl))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardHighlightItem, CardHighlightItemModel>()
                .ForMember(dest => dest.VisualAttributes, opt => opt.MapFrom(src => src.VisualAttributes))
                .ForMember(dest => dest.CardCondition, opt => opt.MapFrom(src => src.CardCondition))
                .ReverseMapWithValidation();

            cfg.CreateMap<CustomService, CustomServiceModel>()
                .ForMember(dest => dest.NameId, opt => opt.MapFrom(src => src.nameId))
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.nServiceTypeId))
                .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.stateId))
                .ForMember(dest => dest.DateInvolve, opt => opt.MapFrom(src => src.dateInvolve))
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.data))
                .ReverseMapWithValidation();

            cfg.CreateMap<CustomServiceData, CustomServiceDataModel>()
                .ForMember(dest => dest.IncidentTypeId, opt => opt.MapFrom(src => src.nIncidentTypeId))
                .ForMember(dest => dest.AdditionalInfo, opt => opt.MapFrom(src => src.additionalInfo))
                .ForMember(dest => dest.PerformActions, opt => opt.MapFrom(src => src.performActions))
                .ForMember(dest => dest.ServiceCardWork, opt => opt.MapFrom(src => src.dtServiceCardWork))
                .ForMember(dest => dest.ServiceCardWorkNext, opt => opt.MapFrom(src => src.dtServiceCardWorkNext))
                .ForMember(dest => dest.ServiceCardComplete, opt => opt.MapFrom(src => src.dtServiceCardComplete))
                .ForMember(dest => dest.ServiceCardView, opt => opt.MapFrom(src => src.dtServiceCardView))
                .ForMember(dest => dest.DepartmentIds, opt => opt.MapFrom(src => src.departmentIds))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardCustomService, CardCustomServiceModel>()
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ForMember(dest => dest.MetaFields, opt => opt.MapFrom(src => src.metaFields))
                .ForMember(dest => dest.CustomFields, opt => opt.MapFrom(src => src.customFields))
                .ReverseMapWithValidation();

            cfg.CreateMap<MetaFields, MetaFieldsModel>()
                .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.stateId))
                .ForMember(dest => dest.DateInvolve, opt => opt.MapFrom(src => src.dateInvolve))
                .ReverseMapWithValidation();

            cfg.CreateMap<CustomFields, CustomFieldsModel>()
                .ForMember(dest => dest.BoolFields, opt => opt.MapFrom(src => src.boolFields))
                .ForMember(dest => dest.IntFields, opt => opt.MapFrom(src => src.intFields))
                .ForMember(dest => dest.StringFields, opt => opt.MapFrom(src => src.stringFields))
                .ForMember(dest => dest.ComboFields, opt => opt.MapFrom(src => src.comboFields))
                .ForMember(dest => dest.DateTimeFields, opt => opt.MapFrom(src => src.dateTimeFields))
                .ForMember(dest => dest.Tables, opt => opt.MapFrom(src => src.tables))
                .ReverseMapWithValidation();

            cfg.CreateMap<BoolField, BoolFieldModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<IntField, IntFieldModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<StringField, StringFieldModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<ComboField, ComboFieldModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<DateTimeField, DateTimeFieldModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<Table, TableModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.BoolColumns, opt => opt.MapFrom(src => src.boolColumns))
                .ForMember(dest => dest.IntColumns, opt => opt.MapFrom(src => src.intColumns))
                .ForMember(dest => dest.StringColumns, opt => opt.MapFrom(src => src.stringColumns))
                .ForMember(dest => dest.DateTimeColumns, opt => opt.MapFrom(src => src.dateTimeColumns))
                .ForMember(dest => dest.ComboColumns, opt => opt.MapFrom(src => src.comboColumns))
                .ReverseMapWithValidation();

            cfg.CreateMap<BoolColumn, BoolColumnModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Values, opt => opt.MapFrom(src => src.values))
                .ReverseMapWithValidation();

            cfg.CreateMap<BoolCell, BoolCellModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<StringColumn, StringColumnModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Values, opt => opt.MapFrom(src => src.values))
                .ReverseMapWithValidation();

            cfg.CreateMap<StringCell, StringCellModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<IntColumn, IntColumnModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Values, opt => opt.MapFrom(src => src.values))
                .ReverseMapWithValidation();

            cfg.CreateMap<IntCell, IntCellModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<DateTimeColumn, DateTimeColumnModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Values, opt => opt.MapFrom(src => src.values))
                .ReverseMapWithValidation();

            cfg.CreateMap<DateTimeCell, DateTimeCellModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<ComboColumn, ComboColumnModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.Values, opt => opt.MapFrom(src => src.values))
                .ReverseMapWithValidation();

            cfg.CreateMap<ComboCell, ComboCellModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceEvent, ServiceEventModel>()
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ForMember(dest => dest.Opened, opt => opt.MapFrom(src => src.opened))
                .ReverseMapWithValidation();

            cfg.CreateMap<MetaData, MetaDataModel>()
                .ForMember(dest => dest.Replication, opt => opt.MapFrom(src => src.replication))
                .ForMember(dest => dest.ServiceEvents, opt => opt.MapFrom(src => src.serviceEvents))
                .ReverseMapWithValidation();

            cfg.CreateMap<ReplicationTargetInfo, ReplicationTargetInfoModel>()
                .ForMember(dest => dest.ReplicationTargetId, opt => opt.MapFrom(src => src.replicationTargetId))
                .ForMember(dest => dest.ReplicationTargetName, opt => opt.MapFrom(src => src.replicationTargetName))
                .ForMember(dest => dest.IsDelivered, opt => opt.MapFrom(src => src.isDelivered))
                .ReverseMapWithValidation();

            cfg.CreateMap<ReplicationMetaData, ReplicationMetaDataModel>()
                .ForMember(dest => dest.IsDelivered, opt => opt.MapFrom(src => src.isDelivered))
                .ForMember(dest => dest.TargetsInfo, opt => opt.MapFrom(src => src.targetsInfo))
                .ReverseMapWithValidation();

            cfg.CreateMap<RegionAdditionalInfo, RegionAdditionalInfoModelFromGenerated>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.Autocomplete, opt => opt.MapFrom(src => src.autocomplete))
                .ReverseMapWithValidation();

            cfg.CreateMap<PhoneBookDictionary, PhoneBookDictionaryModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.regionId))
                .ForMember(dest => dest.CommTypeId, opt => opt.MapFrom(src => src.commTypeId))
                .ForMember(dest => dest.CommPhoneId, opt => opt.MapFrom(src => src.commPhoneId))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.phoneNumber))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.deleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<RegionData, RegionDataModel>()
                .ForMember(dest => dest.RegistrationDepartment, opt => opt.MapFrom(src => src.strRegistrationDepartment))
                .ForMember(dest => dest.RegDate, opt => opt.MapFrom(src => src.dtRegDate))
                .ForMember(dest => dest.DepartmentTransfer, opt => opt.MapFrom(src => src.dtDepartmentTransfer))
                .ForMember(dest => dest.DenialOfServiceReason, opt => opt.MapFrom(src => src.strDenialOfServiceReason))
                .ReverseMapWithValidation();

            cfg.CreateMap<MNISReaction, MNISReactionModel>()
                .ForMember(dest => dest.Reaction, opt => opt.MapFrom(src => src.reaction))
                .ReverseMapWithValidation();

            cfg.CreateMap<MNISReactionItem, MNISReactionItemModel>()
                .ForMember(dest => dest.Events, opt => opt.MapFrom(src => src.events))
                .ReverseMapWithValidation();

            cfg.CreateMap<MNISEvent, MNISEventModel>()
                .ForMember(dest => dest.Resource, opt => opt.MapFrom(src => src.resource))
                .ForMember(dest => dest.EventType, opt => opt.MapFrom(src => src.eventType))
                .ForMember(dest => dest.EventTime, opt => opt.MapFrom(src => src.eventTime))
                .ForMember(dest => dest.EventName, opt => opt.MapFrom(src => src.eventName))
                .ReverseMapWithValidation();

            cfg.CreateMap<Vehicle03Info, Vehicle03InfoModel>()
                .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.vehicleId))
                .ForMember(dest => dest.Involve, opt => opt.MapFrom(src => src.dtInvolve))
                .ReverseMapWithValidation();

            cfg.CreateMap<Vehicle01Info, Vehicle01InfoModel>()
                .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.vehicleId))
                .ForMember(dest => dest.LatestEventTime, opt => opt.MapFrom(src => src.latestEventTime))
                .ForMember(dest => dest.LatestEventType, opt => opt.MapFrom(src => src.latestEventType))
                .ReverseMapWithValidation();

            cfg.CreateMap<VehicleArrival, VehicleArrivalModel>()
                .ForMember(dest => dest.ExternalVehicleId, opt => opt.MapFrom(src => src.externalVehicleId))
                .ForMember(dest => dest.CurrentLocation, opt => opt.MapFrom(src => src.currentLocation))
                .ForMember(dest => dest.EstimatedTravelTimeMinutes, opt => opt.MapFrom(src => src.estimatedTravelTimeMinutes))
                .ForMember(dest => dest.EstimatedArrivalTime, opt => opt.MapFrom(src => src.estimatedArrivalTime))
                .ForMember(dest => dest.StateRegNumber, opt => opt.MapFrom(src => src.stateRegNumber))
                .ReverseMapWithValidation();

            cfg.CreateMap<ArrivalInfo, ArrivalInfoModel>()
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.destination))
                .ForMember(dest => dest.VehiclesArrival, opt => opt.MapFrom(src => src.vehiclesArrival))
                .ReverseMapWithValidation();

            cfg.CreateMap<VehicleTrackInfo, VehicleTrackInfoModel>()
                .ForMember(dest => dest.Coords, opt => opt.MapFrom(src => src.coords))
                .ForMember(dest => dest.StateRegNumber, opt => opt.MapFrom(src => src.stateRegNumber))
                .ReverseMapWithValidation();

            cfg.CreateMap<ConnectionInfo, ConnectionInfoModel>()
                .ForMember(dest => dest.ActionUrl, opt => opt.MapFrom(src => src.ActionUrl))
                .ForMember(dest => dest.NotificationUrl, opt => opt.MapFrom(src => src.NotificationUrl))
                .ForMember(dest => dest.NotificationWebSocketUrl, opt => opt.MapFrom(src => src.NotificationWebSocketUrl))
                .ForMember(dest => dest.ReportUrl, opt => opt.MapFrom(src => src.ReportUrl))
                .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                .ForMember(dest => dest.Attempts, opt => opt.MapFrom(src => src.Attempts))
                .ReverseMapWithValidation();

            cfg.CreateMap<MRSSettings, MRSSettingsModel>()
                .ForMember(dest => dest.Mrs, opt => opt.MapFrom(src => src.Mrs))
                .ForMember(dest => dest.RemotePath, opt => opt.MapFrom(src => src.RemotePath))
                .ForMember(dest => dest.FtpUser, opt => opt.MapFrom(src => src.FtpUser))
                .ForMember(dest => dest.FtpPassword, opt => opt.MapFrom(src => src.FtpPassword))
                .ForMember(dest => dest.CallIdFilter, opt => opt.MapFrom(src => src.CallIdFilter))
                .ForMember(dest => dest.GetFileListTimeout, opt => opt.MapFrom(src => src.GetFileListTimeout))
                .ReverseMapWithValidation();

            cfg.CreateMap<MapsSettings, MapsSettingsModel>()
                .ForMember(dest => dest.VideoPortalUserID, opt => opt.MapFrom(src => src.VideoPortalUserID))
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.CityName))
                .ForMember(dest => dest.MapManufacturer, opt => opt.MapFrom(src => src.MapManufacturer))
                .ReverseMapWithValidation();

            cfg.CreateMap<MapTileUrl, MapTileUrlModelFromGenerated>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.MapManufacturer, opt => opt.MapFrom(src => src.MapManufacturer))
                .ForMember(dest => dest.HomeCity, opt => opt.MapFrom(src => src.HomeCity))
                .ReverseMapWithValidation();

            cfg.CreateMap<CallCenterSettings, CallCenterSettingsModel>()
                .ForMember(dest => dest.CallCenterProvider, opt => opt.MapFrom(src => src.CallCenterProvider))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.RunProcessWaitTimeout, opt => opt.MapFrom(src => src.RunProcessWaitTimeout))
                .ForMember(dest => dest.PollingInterval, opt => opt.MapFrom(src => src.PollingInterval))
                .ReverseMapWithValidation();

            cfg.CreateMap<CallCenterParameter, CallCenterParameterModel>()
                .ForMember(dest => dest.PlaySpeakers, opt => opt.MapFrom(src => src.PlaySpeakers))
                .ForMember(dest => dest.PlayHeadPhones, opt => opt.MapFrom(src => src.PlayHeadPhones))
                .ForMember(dest => dest.EmergencyModeEnable, opt => opt.MapFrom(src => src.EmergencyModeEnable))
                .ForMember(dest => dest.WaitSecondsBeforeEmergencyMode, opt => opt.MapFrom(src => src.WaitSecondsBeforeEmergencyMode))
                .ReverseMapWithValidation();

            cfg.CreateMap<Settings, SettingsModel>()
                .ForMember(dest => dest.MapsSettings, opt => opt.MapFrom(src => src.MapsSettings))
                .ForMember(dest => dest.CallCenterSettings, opt => opt.MapFrom(src => src.CallCenterSettings))
                .ForMember(dest => dest.AcdTerminalWindowStyleRunMode, opt => opt.MapFrom(src => src.AcdTerminalWindowStyleRunMode))
                .ForMember(dest => dest.User03Role, opt => opt.MapFrom(src => src.User03Role))
                .ForMember(dest => dest.ActualDepartmentID, opt => opt.MapFrom(src => src.ActualDepartmentID))
                .ForMember(dest => dest.IsCallCenterUsed, opt => opt.MapFrom(src => src.IsCallCenterUsed))
                .ForMember(dest => dest.NoCardCreationSiren, opt => opt.MapFrom(src => src.NoCardCreationSiren))
                .ForMember(dest => dest.IsCard112ReadOnly, opt => opt.MapFrom(src => src.IsCard112ReadOnly))
                .ForMember(dest => dest.CityID, opt => opt.MapFrom(src => src.CityID))
                .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(src => src.DistrictID))
                .ForMember(dest => dest.BlockFilterCityAndDistrict, opt => opt.MapFrom(src => src.BlockFilterCityAndDistrict))
                .ForMember(dest => dest.IsReadOnlyMode, opt => opt.MapFrom(src => src.IsReadOnlyMode))
                .ForMember(dest => dest.IsMap, opt => opt.MapFrom(src => src.IsMap))
                .ForMember(dest => dest.CityReadOnly, opt => opt.MapFrom(src => src.CityReadOnly))
                .ForMember(dest => dest.ShowNonTransferedCardsForDispatcher03, opt => opt.MapFrom(src => src.ShowNonTransferedCardsForDispatcher03))
                .ForMember(dest => dest.Installation, opt => opt.MapFrom(src => src.Installation))
                .ForMember(dest => dest.ShowConsultMenu, opt => opt.MapFrom(src => src.ShowConsultMenu))
                .ForMember(dest => dest.RoleSettings, opt => opt.MapFrom(src => src.RoleSettings))
                .ForMember(dest => dest.SourceZoneId, opt => opt.MapFrom(src => src.SourceZoneId))
                .ForMember(dest => dest.SirenName, opt => opt.MapFrom(src => src.SirenName))
                .ForMember(dest => dest.ConnectionInfos, opt => opt.MapFrom(src => src.ConnectionInfos))
                .ForMember(dest => dest.ForcesAvailableDepartments, opt => opt.MapFrom(src => src.ForcesAvailableDepartments))
                .ForMember(dest => dest.AdditionalCities, opt => opt.MapFrom(src => src.AdditionalCities))
                .ReverseMapWithValidation();

            cfg.CreateMap<CallData, CallDataModel>()
                .ForMember(dest => dest.CallId, opt => opt.MapFrom(src => src.nCallId))
                .ForMember(dest => dest.ExtCallId, opt => opt.MapFrom(src => src.extCallId))
                .ForMember(dest => dest.ExtCallId2, opt => opt.MapFrom(src => src.extCallId2))
                .ForMember(dest => dest.CdPN, opt => opt.MapFrom(src => src.strCdPN))
                .ForMember(dest => dest.CgPN, opt => opt.MapFrom(src => src.strCgPN))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.nCategory))
                .ForMember(dest => dest.GatewayIPAddr, opt => opt.MapFrom(src => src.GatewayIPAddr))
                .ForMember(dest => dest.ESGlobalID, opt => opt.MapFrom(src => src.ESGlobalID))
                .ForMember(dest => dest.ExternalInfoType, opt => opt.MapFrom(src => src.externalInfoType))
                .ForMember(dest => dest.CcRegionID, opt => opt.MapFrom(src => src.ccRegionID))
                .ForMember(dest => dest.VisitedNetworkId, opt => opt.MapFrom(src => src.visitedNetworkId))
                .ForMember(dest => dest.SmsData, opt => opt.MapFrom(src => src.smsData))
                .ForMember(dest => dest.ResultInfo, opt => opt.MapFrom(src => src.resultInfo))
                .ForMember(dest => dest.CallDuration, opt => opt.MapFrom(src => src.callDuration))
                .ForMember(dest => dest.CallDirection, opt => opt.MapFrom(src => src.callDirection))
                .ForMember(dest => dest.DistributeDuration, opt => opt.MapFrom(src => src.distributeDuration))
                .ForMember(dest => dest.ExternalInfo, opt => opt.MapFrom(src => src.externalInfo))
                .ReverseMapWithValidation();

            cfg.CreateMap<SMSData, SMSDataModel>()
                .ForMember(dest => dest.MessageText, opt => opt.MapFrom(src => src.strMessageText))
                .ForMember(dest => dest.SmsType, opt => opt.MapFrom(src => src.smsType))
                .ForMember(dest => dest.SmsStatus, opt => opt.MapFrom(src => src.smsStatus))
                .ForMember(dest => dest.SMPPId, opt => opt.MapFrom(src => src.strSMPPId))
                .ForMember(dest => dest.SmsId, opt => opt.MapFrom(src => src.nSmsId))
                .ReverseMapWithValidation();

            cfg.CreateMap<IncidentTypeRecord, IncidentTypeRecordModel>()
                .ForMember(dest => dest.IncidentTypeId, opt => opt.MapFrom(src => src.nIncidentTypeId))
                .ForMember(dest => dest.CallTypeId, opt => opt.MapFrom(src => src.callTypeId))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.regionId))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.deleted))
                .ForMember(dest => dest.ServiceTypeIds, opt => opt.MapFrom(src => src.ServiceTypeIds))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceIncidentTypeRecord, ServiceIncidentTypeRecordModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.strValue))
                .ForMember(dest => dest.IncidentTypeId, opt => opt.MapFrom(src => src.nIncidentTypeId))
                .ForMember(dest => dest.AdditionalInfo, opt => opt.MapFrom(src => src.additionalInfo))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.deleted))
                .ForMember(dest => dest.AuxIncidentIds, opt => opt.MapFrom(src => src.auxIncidentIds))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceDeadlines, ServiceDeadlinesModel>()
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ForMember(dest => dest.ServiceCreateTimeout, opt => opt.MapFrom(src => src.serviceCreateTimeout))
                .ReverseMapWithValidation();

            cfg.CreateMap<ReplicationTarget, ReplicationTargetModel>()
                .ForMember(dest => dest.ReplicationTargetId, opt => opt.MapFrom(src => src.replicationTargetId))
                .ForMember(dest => dest.ReplicationServiceName, opt => opt.MapFrom(src => src.replicationServiceName))
                .ForMember(dest => dest.ReplicationTargetServiceTypeId, opt => opt.MapFrom(src => src.replicationTargetServiceTypeId))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card112List, Card112ListModel>()
                .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.total))
                .ForMember(dest => dest.CardList, opt => opt.MapFrom(src => src.cardList))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_ISharerDescription, ISharerDescriptionModel>()
                .ForMember(dest => dest.InLooksAge, opt => opt.MapFrom(src => src.strInLooksAge))
                .ForMember(dest => dest.StatureID, opt => opt.MapFrom(src => src.nStatureID))
                .ForMember(dest => dest.FigureID, opt => opt.MapFrom(src => src.nFigureID))
                .ForMember(dest => dest.Stature, opt => opt.MapFrom(src => src.strStature))
                .ForMember(dest => dest.Figure, opt => opt.MapFrom(src => src.strFigure))
                .ForMember(dest => dest.Exterior, opt => opt.MapFrom(src => src.strExterior))
                .ForMember(dest => dest.Extra, opt => opt.MapFrom(src => src.strExtra))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.nGender))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.strLastName))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.strFirstName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.strMiddleName))
                .ForMember(dest => dest.Birthday, opt => opt.MapFrom(src => src.dtBirthday))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_IVehicleDescription, IVehicleDescriptionModel>()
                .ForMember(dest => dest.Vendor, opt => opt.MapFrom(src => src.strVendor))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.strName))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.strColor))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.strType))
                .ForMember(dest => dest.ColorID, opt => opt.MapFrom(src => src.nColorID))
                .ForMember(dest => dest.TypeID, opt => opt.MapFrom(src => src.nTypeID))
                .ForMember(dest => dest.Extra, opt => opt.MapFrom(src => src.strExtra))
                .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.strRegistrationNumber))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.strRegion))
                .ForMember(dest => dest.Hided, opt => opt.MapFrom(src => src.lHided))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_IVictimDescription, IVictimDescriptionModel>()
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.strLastName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.strMiddleName))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.strFirstName))
                .ForMember(dest => dest.ContactPhone, opt => opt.MapFrom(src => src.strContactPhone))
                .ForMember(dest => dest.AdditionalInfo, opt => opt.MapFrom(src => src.strAdditionalInfo))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.nCityId))
                .ForMember(dest => dest.StreetId, opt => opt.MapFrom(src => src.nStreetId))
                .ForMember(dest => dest.BuildingNumber, opt => opt.MapFrom(src => src.strBuildingNumber))
                .ForMember(dest => dest.Corps, opt => opt.MapFrom(src => src.strCorps))
                .ForMember(dest => dest.Flat, opt => opt.MapFrom(src => src.strFlat))
                .ReverseMapWithValidation();

            cfg.CreateMap<TaskForceItem, TaskForceItemModel>()
                .ForMember(dest => dest.OvdServiceId, opt => opt.MapFrom(src => src.ovdServiceId))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.lastName))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card02Filter, Card02FilterModel>()
                .ForMember(dest => dest.InstrinsicOvd, opt => opt.MapFrom(src => src.strInstrinsicOvd))
                .ForMember(dest => dest.InstrinsicDps, opt => opt.MapFrom(src => src.strInstrinsicDps))
                .ForMember(dest => dest.IsFilterEmptyStreet, opt => opt.MapFrom(src => src.isFilterEmptyStreet))
                .ForMember(dest => dest.StreetId, opt => opt.MapFrom(src => src.nStreetId))
                .ForMember(dest => dest.ITypeId, opt => opt.MapFrom(src => src.nITypeId))
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.nCardId))
                .ForMember(dest => dest.DeclarantLastName, opt => opt.MapFrom(src => src.strDeclarantLastName))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_DictionaryItem, DictionaryItemModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.strValue))
                .ForMember(dest => dest.ExtId, opt => opt.MapFrom(src => src.extId))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.deleted))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.strDescription))
                .ReverseMapWithValidation();

            cfg.CreateMap<DCRecord, DCRecordModel>()
                .ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.districtId))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.cityId))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.deleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<SDCRecord, SDCRecordModel>()
                .ForMember(dest => dest.StreetId, opt => opt.MapFrom(src => src.streetId))
                .ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.districtId))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.cityId))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.deleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardStateDescStruct, CardStateDescStructModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src._id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src._name))
                .ForMember(dest => dest.Nextid, opt => opt.MapFrom(src => src._nextid))
                .ForMember(dest => dest.Previd, opt => opt.MapFrom(src => src._previd))
                .ForMember(dest => dest.StandardMinutes, opt => opt.MapFrom(src => src._standardMinutes))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardSyntheticState, CardSyntheticStateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src._id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src._name))
                .ForMember(dest => dest.ColorR, opt => opt.MapFrom(src => src._color_r))
                .ForMember(dest => dest.ColorG, opt => opt.MapFrom(src => src._color_g))
                .ForMember(dest => dest.ColorB, opt => opt.MapFrom(src => src._color_b))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_SubCallTypeItem, SubCallTypeItemModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.CallTypeId, opt => opt.MapFrom(src => src.nCallTypeId))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.nCityId))
                .ForMember(dest => dest.GroupNumber, opt => opt.MapFrom(src => src.strGroupNumber))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.description))
                .ReverseMapWithValidation();

            cfg.CreateMap<FieldConstraint, FieldConstraintModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.size))
                .ReverseMapWithValidation();

            cfg.CreateMap<ObjectStruct, ObjectStructModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src._ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src._name))
                .ForMember(dest => dest.StreetID, opt => opt.MapFrom(src => src._streetID))
                .ForMember(dest => dest.CityID, opt => opt.MapFrom(src => src._cityID))
                .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(src => src._districtID))
                .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src._building))
                .ForMember(dest => dest.Corps, opt => opt.MapFrom(src => src._corps))
                .ForMember(dest => dest.Gasified, opt => opt.MapFrom(src => src._gasified))
                .ForMember(dest => dest.BaseClassID, opt => opt.MapFrom(src => src._baseClassID))
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src._departmentID))
                .ForMember(dest => dest.TypeID, opt => opt.MapFrom(src => src._typeID))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src._deleted))
                .ForMember(dest => dest.FireReactionPlanIDs, opt => opt.MapFrom(src => src._fireReactionPlanIDs))
                .ReverseMapWithValidation();

            cfg.CreateMap<FireObjectRangeStruct, FireObjectRangeStructModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src._ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src._name))
                .ForMember(dest => dest.StreetID, opt => opt.MapFrom(src => src._streetID))
                .ForMember(dest => dest.CityID, opt => opt.MapFrom(src => src._cityID))
                .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(src => src._districtID))
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src._departmentID))
                .ForMember(dest => dest.BuildingFrom, opt => opt.MapFrom(src => src._buildingFrom))
                .ForMember(dest => dest.BuildingTo, opt => opt.MapFrom(src => src._buildingTo))
                .ForMember(dest => dest.Odd, opt => opt.MapFrom(src => src._odd))
                .ForMember(dest => dest.FireReactionPlanIDs, opt => opt.MapFrom(src => src._fireReactionPlanIDs))
                .ReverseMapWithValidation();

            cfg.CreateMap<FireReactionPlanItemStruct, FireReactionPlanItemStructModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src._ID))
                .ForMember(dest => dest.FireRectionPlanID, opt => opt.MapFrom(src => src._fireRectionPlanID))
                .ForMember(dest => dest.FireEngineTypeID, opt => opt.MapFrom(src => src._fireEngineTypeID))
                .ForMember(dest => dest.FireEngineType, opt => opt.MapFrom(src => src._fireEngineType))
                .ForMember(dest => dest.FireDepartmentID, opt => opt.MapFrom(src => src._fireDepartmentID))
                .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src._count))
                .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src._order))
                .ForMember(dest => dest.FireClassID, opt => opt.MapFrom(src => src._fireClassID))
                .ReverseMapWithValidation();

            cfg.CreateMap<FireReactionPlanStruct, FireReactionPlanStructModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src._ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src._name))
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src._departmentID))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src._items))
                .ReverseMapWithValidation();

            cfg.CreateMap<MalefactionStruct, MalefactionStructModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src._ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src._name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src._code))
                .ReverseMapWithValidation();

            cfg.CreateMap<MalefactionGroupStruct, MalefactionGroupStructModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src._ID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src._name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src._code))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src._items))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_SnapshotData, Tm_SnapshotDataModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.Modifier, opt => opt.MapFrom(src => src.strModifier))
                .ForMember(dest => dest.Modified, opt => opt.MapFrom(src => src.dtModified))
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.nCardId))
                .ForMember(dest => dest.CardTypeId, opt => opt.MapFrom(src => src.nCardTypeId))
                .ForMember(dest => dest.Version, opt => opt.MapFrom(src => src.nVersion))
                .ForMember(dest => dest.Modifications, opt => opt.MapFrom(src => src.strModifications))
                .ReverseMapWithValidation();

            cfg.CreateMap<CustomServiceCardTemplate, CustomServiceCardTemplateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Fields, opt => opt.MapFrom(src => src.fields))
                .ReverseMapWithValidation();

            cfg.CreateMap<ServiceTypeIdToCustomServiceCardTemplate, ServiceTypeIdToCustomServiceCardTemplateModel>()
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ReverseMapWithValidation();

            cfg.CreateMap<FieldInfo, FieldInfoModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.TemplateType, opt => opt.MapFrom(src => src.templateType))
                .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.order))
                .ReverseMapWithValidation();

            cfg.CreateMap<ControlTemplate, ControlTemplateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.isDeleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<ComboControlTemplate, ComboControlTemplateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.DataSetId, opt => opt.MapFrom(src => src.dataSetId))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.isDeleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<DateTimeControlTemplate, DateTimeControlTemplateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Format, opt => opt.MapFrom(src => src.format))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.isDeleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<TableControlTemplate, TableControlTemplateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.ColumnsSetId, opt => opt.MapFrom(src => src.columnsSetId))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.isDeleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<ColumnsSet, ColumnsSetModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.isDeleted))
                .ForMember(dest => dest.Columns, opt => opt.MapFrom(src => src.columns))
                .ReverseMapWithValidation();

            cfg.CreateMap<ColumnInfo, ColumnInfoModel>()
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.templateId))
                .ForMember(dest => dest.TemplateType, opt => opt.MapFrom(src => src.templateType))
                .ForMember(dest => dest.Order, opt => opt.MapFrom(src => src.order))
                .ReverseMapWithValidation();

            cfg.CreateMap<DataSet, DataSetModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.isDeleted))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.items))
                .ReverseMapWithValidation();

            cfg.CreateMap<DataSetItem, DataSetItemModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.isDeleted))
                .ReverseMapWithValidation();

            cfg.CreateMap<BasicDictionaries, BasicDictionariesModel>()
                .ForMember(dest => dest.CallTypeDictionary, opt => opt.MapFrom(src => src.CallTypeDictionary))
                .ForMember(dest => dest.ServiceTypeDictionary, opt => opt.MapFrom(src => src.ServiceTypeDictionary))
                .ForMember(dest => dest.SubCallTypeDictionary, opt => opt.MapFrom(src => src.SubCallTypeDictionary))
                .ForMember(dest => dest.CallTypeNumberDictionary, opt => opt.MapFrom(src => src.CallTypeNumberDictionary))
                .ForMember(dest => dest.AdditionalCallTypeDictionary, opt => opt.MapFrom(src => src.AdditionalCallTypeDictionary))
                .ForMember(dest => dest.DeclarantStatusDictionary, opt => opt.MapFrom(src => src.DeclarantStatusDictionary))
                .ForMember(dest => dest.CCMC_TypeDictionary, opt => opt.MapFrom(src => src.CCMC_TypeDictionary))
                .ForMember(dest => dest.ObjectTypeDictionary, opt => opt.MapFrom(src => src.ObjectTypeDictionary))
                .ForMember(dest => dest.FireClassDictionary, opt => opt.MapFrom(src => src.FireClassDictionary))
                .ForMember(dest => dest.FireReasonDictionary, opt => opt.MapFrom(src => src.FireReasonDictionary))
                .ForMember(dest => dest.FireIncidentTypeDictionary, opt => opt.MapFrom(src => src.FireIncidentTypeDictionary))
                .ForMember(dest => dest.Departments01Dictionary, opt => opt.MapFrom(src => src.Departments01Dictionary))
                .ForMember(dest => dest.FireReactionPlanDictionary, opt => opt.MapFrom(src => src.FireReactionPlanDictionary))
                .ForMember(dest => dest.Card01StateDescStructs, opt => opt.MapFrom(src => src.Card01StateDescStructs))
                .ForMember(dest => dest.FireObjectRangeStructs, opt => opt.MapFrom(src => src.FireObjectRangeStructs))
                .ForMember(dest => dest.FireReactionPlanStructs, opt => opt.MapFrom(src => src.FireReactionPlanStructs))
                .ForMember(dest => dest.FireBarrelTypes, opt => opt.MapFrom(src => src.FireBarrelTypes))
                .ForMember(dest => dest.FireExtinguisherTypes, opt => opt.MapFrom(src => src.FireExtinguisherTypes))
                .ForMember(dest => dest.WaterSources, opt => opt.MapFrom(src => src.WaterSources))
                .ForMember(dest => dest.FirePreventionTypes, opt => opt.MapFrom(src => src.FirePreventionTypes))
                .ForMember(dest => dest.FireRoles, opt => opt.MapFrom(src => src.FireRoles))
                .ForMember(dest => dest.FireIncidentGroupDictionary, opt => opt.MapFrom(src => src.FireIncidentGroupDictionary))
                .ForMember(dest => dest.Departments02Dictionary, opt => opt.MapFrom(src => src.Departments02Dictionary))
                .ForMember(dest => dest.OVDServiceDictionary, opt => opt.MapFrom(src => src.OVDServiceDictionary))
                .ForMember(dest => dest.ITypeDictionary, opt => opt.MapFrom(src => src.ITypeDictionary))
                .ForMember(dest => dest.ITypeDetailedDictionary, opt => opt.MapFrom(src => src.ITypeDetailedDictionary))
                .ForMember(dest => dest.StatureDictionary, opt => opt.MapFrom(src => src.StatureDictionary))
                .ForMember(dest => dest.FigureDictionary, opt => opt.MapFrom(src => src.FigureDictionary))
                .ForMember(dest => dest.StatusDictionary, opt => opt.MapFrom(src => src.StatusDictionary))
                .ForMember(dest => dest.Card02StateDescStructs, opt => opt.MapFrom(src => src.Card02StateDescStructs))
                .ForMember(dest => dest.MalefactionGroupStructs, opt => opt.MapFrom(src => src.MalefactionGroupStructs))
                .ForMember(dest => dest.OvdPastEvents, opt => opt.MapFrom(src => src.OvdPastEvents))
                .ForMember(dest => dest.OvdDepartureResults, opt => opt.MapFrom(src => src.OvdDepartureResults))
                .ForMember(dest => dest.Departments03Dictionary, opt => opt.MapFrom(src => src.Departments03Dictionary))
                .ForMember(dest => dest.ReasonDictionary, opt => opt.MapFrom(src => src.ReasonDictionary))
                .ForMember(dest => dest.Card03StateDescStructs, opt => opt.MapFrom(src => src.Card03StateDescStructs))
                .ForMember(dest => dest.DiagnosisDictionary, opt => opt.MapFrom(src => src.DiagnosisDictionary))
                .ForMember(dest => dest.Hospitals, opt => opt.MapFrom(src => src.Hospitals))
                .ForMember(dest => dest.TransportationTypesDictionary, opt => opt.MapFrom(src => src.TransportationTypesDictionary))
                .ForMember(dest => dest.Card03TransportReasonDictionary, opt => opt.MapFrom(src => src.Card03TransportReasonDictionary))
                .ForMember(dest => dest.GasServicesDictionary, opt => opt.MapFrom(src => src.GasServicesDictionary))
                .ForMember(dest => dest.GasServiceSituationsDictionary, opt => opt.MapFrom(src => src.GasServiceSituationsDictionary))
                .ForMember(dest => dest.GasSituationInstructions, opt => opt.MapFrom(src => src.GasSituationInstructions))
                .ForMember(dest => dest.DepartmentsCommServDictionary, opt => opt.MapFrom(src => src.DepartmentsCommServDictionary))
                .ForMember(dest => dest.CardCommServStateDescStructs, opt => opt.MapFrom(src => src.CardCommServStateDescStructs))
                .ForMember(dest => dest.IncidentCommServCategoryDictionary, opt => opt.MapFrom(src => src.IncidentCommServCategoryDictionary))
                .ForMember(dest => dest.CardCommServUKDictionary, opt => opt.MapFrom(src => src.CardCommServUKDictionary))
                .ForMember(dest => dest.IncidentCommServObjectTypeDictionary, opt => opt.MapFrom(src => src.IncidentCommServObjectTypeDictionary))
                .ForMember(dest => dest.IncidentCommServType2ObjectTypeMap, opt => opt.MapFrom(src => src.IncidentCommServType2ObjectTypeMap))
                .ForMember(dest => dest.CityDictionary, opt => opt.MapFrom(src => src.CityDictionary))
                .ForMember(dest => dest.DistrictDictionary, opt => opt.MapFrom(src => src.DistrictDictionary))
                .ForMember(dest => dest.StreetDictionary, opt => opt.MapFrom(src => src.StreetDictionary))
                .ForMember(dest => dest.RegionDictionary, opt => opt.MapFrom(src => src.RegionDictionary))
                .ForMember(dest => dest.LocalDistrictDictionary, opt => opt.MapFrom(src => src.LocalDistrictDictionary))
                .ForMember(dest => dest.RegionsAdditionalInfo, opt => opt.MapFrom(src => src.RegionsAdditionalInfo))
                .ForMember(dest => dest.IncidentTypeDictionary, opt => opt.MapFrom(src => src.IncidentTypeDictionary))
                .ForMember(dest => dest.IncidentTypeRecords, opt => opt.MapFrom(src => src.IncidentTypeRecords))
                .ForMember(dest => dest.Incident01TypeRecords, opt => opt.MapFrom(src => src.Incident01TypeRecords))
                .ForMember(dest => dest.Incident02TypeRecords, opt => opt.MapFrom(src => src.Incident02TypeRecords))
                .ForMember(dest => dest.Incident03TypeRecords, opt => opt.MapFrom(src => src.Incident03TypeRecords))
                .ForMember(dest => dest.Incident04TypeRecords, opt => opt.MapFrom(src => src.Incident04TypeRecords))
                .ForMember(dest => dest.IncidentATTypeRecords, opt => opt.MapFrom(src => src.IncidentATTypeRecords))
                .ForMember(dest => dest.IncidentCommServTypeRecords, opt => opt.MapFrom(src => src.IncidentCommServTypeRecords))
                .ForMember(dest => dest.ObjectStructs, opt => opt.MapFrom(src => src.ObjectStructs))
                .ForMember(dest => dest.DCRecords, opt => opt.MapFrom(src => src.DCRecords))
                .ForMember(dest => dest.SDCRecords, opt => opt.MapFrom(src => src.SDCRecords))
                .ForMember(dest => dest.CardSyntheticStateDictionary, opt => opt.MapFrom(src => src.CardSyntheticStateDictionary))
                .ForMember(dest => dest.LanguageDictionary, opt => opt.MapFrom(src => src.LanguageDictionary))
                .ForMember(dest => dest.SourceTypeDictionary, opt => opt.MapFrom(src => src.sourceTypeDictionary))
                .ForMember(dest => dest.VehicleTypeDictionary, opt => opt.MapFrom(src => src.VehicleTypeDictionary))
                .ForMember(dest => dest.Card03WhoCalledDictionary, opt => opt.MapFrom(src => src.Card03WhoCalledDictionary))
                .ForMember(dest => dest.ExternalCreatorsDictionary, opt => opt.MapFrom(src => src.ExternalCreatorsDictionary))
                .ForMember(dest => dest.ServiceDeadlinesDictionary, opt => opt.MapFrom(src => src.ServiceDeadlinesDictionary))
                .ForMember(dest => dest.Card02Constraints, opt => opt.MapFrom(src => src.Tm_Card_02_Constraints))
                .ForMember(dest => dest.Card03Constraints, opt => opt.MapFrom(src => src.Tm_Card_03_Constraints))
                .ForMember(dest => dest.CardOVDConstraints, opt => opt.MapFrom(src => src.Tm_Card_OVD_Constraints))
                .ForMember(dest => dest.Card04Constraints, opt => opt.MapFrom(src => src.Tm_Card_04_Constraints))
                .ForMember(dest => dest.CardATConstraints, opt => opt.MapFrom(src => src.Tm_Card_AT_Constraints))
                .ForMember(dest => dest.CardCommServConstraints, opt => opt.MapFrom(src => src.Tm_Card_CommServ_Constraints))
                .ForMember(dest => dest.FireFighterCardConstraints, opt => opt.MapFrom(src => src.Tm_FireFighterCard_Constraints))
                .ForMember(dest => dest.ISharerDescriptionConstraints, opt => opt.MapFrom(src => src.Tm_ISharerDescription_Constraints))
                .ForMember(dest => dest.IVehicleDescriptionConstraints, opt => opt.MapFrom(src => src.Tm_IVehicleDescription_Constraints))
                .ForMember(dest => dest.IVictimDescriptionConstraints, opt => opt.MapFrom(src => src.Tm_IVictimDescription_Constraints))
                .ForMember(dest => dest.Card112Constraints, opt => opt.MapFrom(src => src.Tm_Card_112_Constraints))
                .ForMember(dest => dest.CallHistoryConstraints, opt => opt.MapFrom(src => src.Tm_Call_History_Constraints))
                .ForMember(dest => dest.CustomServiceIncidentType, opt => opt.MapFrom(src => src.customServiceIncidentType))
                .ForMember(dest => dest.CustomServiceDepartment, opt => opt.MapFrom(src => src.customServiceDepartment))
                .ForMember(dest => dest.ServiceType2CustomServiceTypeDictionary, opt => opt.MapFrom(src => src.ServiceType2CustomServiceTypeDictionary))
                .ForMember(dest => dest.BoolControlTemplates, opt => opt.MapFrom(src => src.BoolControlTemplates))
                .ForMember(dest => dest.IntControlTemplates, opt => opt.MapFrom(src => src.IntControlTemplates))
                .ForMember(dest => dest.StringControlTemplates, opt => opt.MapFrom(src => src.StringControlTemplates))
                .ForMember(dest => dest.DateTimeControlTemplates, opt => opt.MapFrom(src => src.DateTimeControlTemplates))
                .ForMember(dest => dest.ComboControlTemplates, opt => opt.MapFrom(src => src.ComboControlTemplates))
                .ForMember(dest => dest.TableControlTemplates, opt => opt.MapFrom(src => src.TableControlTemplates))
                .ForMember(dest => dest.CustomServiceCardTemplates, opt => opt.MapFrom(src => src.CustomServiceCardTemplates))
                .ForMember(dest => dest.DataSets, opt => opt.MapFrom(src => src.DataSets))
                .ForMember(dest => dest.ServiceTypeIdToCustomServiceCardTemplateDictionary, opt => opt.MapFrom(src => src.ServiceTypeIdToCustomServiceCardTemplateDictionary))
                .ForMember(dest => dest.ColumnsSets, opt => opt.MapFrom(src => src.ColumnsSets))
                .ForMember(dest => dest.CommunicationTypeDictionary, opt => opt.MapFrom(src => src.CommunicationTypeDictionary))
                .ForMember(dest => dest.CommunicationPhonesDictionary, opt => opt.MapFrom(src => src.CommunicationPhonesDictionary))
                .ForMember(dest => dest.PhoneBookDictionary, opt => opt.MapFrom(src => src.PhoneBookDictionary))
                .ForMember(dest => dest.PerformActionsTypeDictionary, opt => opt.MapFrom(src => src.PerformActionsTypeDictionary))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardMessage, CardMessageModelFromGenerated>()
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.nID))
                .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.strCreator))
                .ForMember(dest => dest.EmergencyCardID, opt => opt.MapFrom(src => src.nEmergencyCardID))
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src.nDepartmentID))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.strMessage))
                .ForMember(dest => dest.IsServiceMessage, opt => opt.MapFrom(src => src.isServiceMessage))
                .ForMember(dest => dest.Create, opt => opt.MapFrom(src => src.dtCreate))
                .ReverseMapWithValidation();

            cfg.CreateMap<Department, DepartmentModelFromGenerated>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.m_nID))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.m_strName))
                .ForMember(dest => dest.GeographicLocation, opt => opt.MapFrom(src => src.m_GeographicLocation))
                .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(src => src.m_nDistrictID))
                .ForMember(dest => dest.Engines, opt => opt.MapFrom(src => src.m_Engines))
                .ReverseMapWithValidation();

            cfg.CreateMap<Engine, EngineModel>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.nID))
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src.nDepartmentID))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.strNumber))
                .ForMember(dest => dest.StateID, opt => opt.MapFrom(src => src.nStateID))
                .ForMember(dest => dest.ShiftReportStateID, opt => opt.MapFrom(src => src.nShiftReportStateID))
                .ForMember(dest => dest.EmergencyCardID, opt => opt.MapFrom(src => src.nEmergencyCardID))
                .ForMember(dest => dest.EmergencyCardImportnaceLevelID, opt => opt.MapFrom(src => src.nEmergencyCardImportnaceLevelID))
                .ForMember(dest => dest.Engine03AdditionalInfo, opt => opt.MapFrom(src => src.engine03AdditionalInfo))
                .ReverseMapWithValidation();

            cfg.CreateMap<Engine03AdditionalInfo, Engine03AdditionalInfoModel>()
                .ForMember(dest => dest.ProfileID, opt => opt.MapFrom(src => src.nProfileID))
                .ForMember(dest => dest.PrimarySpecialistID, opt => opt.MapFrom(src => src.nPrimarySpecialistID))
                .ForMember(dest => dest.SecondarySpecialistID, opt => opt.MapFrom(src => src.nSecondarySpecialistID))
                .ForMember(dest => dest.OrderlyID, opt => opt.MapFrom(src => src.nOrderlyID))
                .ForMember(dest => dest.ShiftBegin, opt => opt.MapFrom(src => src.dtShiftBegin))
                .ForMember(dest => dest.ShiftEnd, opt => opt.MapFrom(src => src.dtShiftEnd))
                .ForMember(dest => dest.ShiftBeginReal, opt => opt.MapFrom(src => src.dtShiftBeginReal))
                .ForMember(dest => dest.WorkBegin, opt => opt.MapFrom(src => src.dtWorkBegin))
                .ForMember(dest => dest.LastAction, opt => opt.MapFrom(src => src.dtLastAction))
                .ForMember(dest => dest.CityID, opt => opt.MapFrom(src => src.nCityID))
                .ForMember(dest => dest.DistrictID, opt => opt.MapFrom(src => src.nDistrictID))
                .ForMember(dest => dest.StreetID, opt => opt.MapFrom(src => src.nStreetID))
                .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src.strBuilding))
                .ForMember(dest => dest.Corps, opt => opt.MapFrom(src => src.strCorps))
                .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.strRoom))
                .ForMember(dest => dest.EmergencyCardCreate, opt => opt.MapFrom(src => src.dtEmergencyCardCreate))
                .ForMember(dest => dest.CallCount, opt => opt.MapFrom(src => src.nCallCount))
                .ReverseMapWithValidation();

            cfg.CreateMap<Tm_DepartmentStatePair, DepartmentStatePairModel>()
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src.departmentID))
                .ForMember(dest => dest.StateID, opt => opt.MapFrom(src => src.stateID))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardDepartmentState, CardDepartmentStateModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Modified, opt => opt.MapFrom(src => src.modified))
                .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.action))
                .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src.departmentID))
                .ForMember(dest => dest.CardStateDescID, opt => opt.MapFrom(src => src.cardStateDescID))
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.strMessage))
                .ReverseMapWithValidation();

            cfg.CreateMap<DepartmentStateHistory, DepartmentStateHistoryModel>()
                .ForMember(dest => dest.ActiveState, opt => opt.MapFrom(src => src.activeState))
                .ForMember(dest => dest.StateHistory, opt => opt.MapFrom(src => src.stateHistory))
                .ReverseMapWithValidation();

            cfg.CreateMap<DepartmentInvolvedFilter, DepartmentInvolvedFilterModel>()
                .ForMember(dest => dest.WantsServiceTypeId, opt => opt.MapFrom(src => src.wantsServiceTypeId))
                .ReverseMapWithValidation();

            cfg.CreateMap<DepartmentStateChangedFilter, DepartmentStateChangedFilterModel>()
                .ForMember(dest => dest.WantsServiceTypeId, opt => opt.MapFrom(src => src.wantsServiceTypeId))
                .ReverseMapWithValidation();

            cfg.CreateMap<RequestedEnginesListChangedFilter, RequestedEnginesListChangedFilterModel>()
                .ForMember(dest => dest.WantsServiceTypeId, opt => opt.MapFrom(src => src.wantsServiceTypeId))
                .ForMember(dest => dest.WantsEmergencyCardID, opt => opt.MapFrom(src => src.wantsEmergencyCardID))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardCurrentStatesInDepartmentsChangedFilter, CardCurrentStatesInDepartmentsChangedFilterModel>()
                .ForMember(dest => dest.WantsServiceTypeId, opt => opt.MapFrom(src => src.wantsServiceTypeId))
                .ForMember(dest => dest.WantsEmergencyCardID, opt => opt.MapFrom(src => src.wantsEmergencyCardID))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardMessageListChangedFilter, CardMessageListChangedFilterModel>()
                .ForMember(dest => dest.WantsServiceTypeId, opt => opt.MapFrom(src => src.wantsServiceTypeId))
                .ForMember(dest => dest.WantsEmergencyCardID, opt => opt.MapFrom(src => src.wantsEmergencyCardID))
                .ReverseMapWithValidation();

            cfg.CreateMap<BroadcastMessageFilter, BroadcastMessageFilterModel>()
                .ForMember(dest => dest.WantsServiceTypeId, opt => opt.MapFrom(src => src.wantsServiceTypeId))
                .ForMember(dest => dest.WantsDepartmentIDs, opt => opt.MapFrom(src => src.wantsDepartmentIDs))
                .ReverseMapWithValidation();

            cfg.CreateMap<ShiftReportChangedFilter, ShiftReportChangedFilterModel>()
                .ForMember(dest => dest.WantsServiceTypeId, opt => opt.MapFrom(src => src.wantsServiceTypeId))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardAdditionalInfoAddedFilter, CardAdditionalInfoAddedFilterModel>()
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.cardId))
                .ReverseMapWithValidation();

            cfg.CreateMap<NotificationFilters, NotificationFiltersModel>()
                .ForMember(dest => dest.WantsCard01Changed, opt => opt.MapFrom(src => src.wantsCard01Changed))
                .ForMember(dest => dest.WantsCard02Changed, opt => opt.MapFrom(src => src.wantsCard02Changed))
                .ForMember(dest => dest.WantsCard03Changed, opt => opt.MapFrom(src => src.wantsCard03Changed))
                .ForMember(dest => dest.WantsCard04Changed, opt => opt.MapFrom(src => src.wantsCard04Changed))
                .ForMember(dest => dest.WantsCardATChanged, opt => opt.MapFrom(src => src.wantsCardATChanged))
                .ForMember(dest => dest.WantsCardCommServChanged, opt => opt.MapFrom(src => src.wantsCardCommServChanged))
                .ForMember(dest => dest.WantsCard112Changed, opt => opt.MapFrom(src => src.wantsCard112Changed))
                .ForMember(dest => dest.WantsCard01Created, opt => opt.MapFrom(src => src.wantsCard01Created))
                .ForMember(dest => dest.WantsCard02Created, opt => opt.MapFrom(src => src.wantsCard02Created))
                .ForMember(dest => dest.WantsCard03Created, opt => opt.MapFrom(src => src.wantsCard03Created))
                .ForMember(dest => dest.WantsCard04Created, opt => opt.MapFrom(src => src.wantsCard04Created))
                .ForMember(dest => dest.WantsCardATCreated, opt => opt.MapFrom(src => src.wantsCardATCreated))
                .ForMember(dest => dest.WantsCardCommServCreated, opt => opt.MapFrom(src => src.wantsCardCommServCreated))
                .ForMember(dest => dest.WantsCard112Created, opt => opt.MapFrom(src => src.wantsCard112Created))
                .ForMember(dest => dest.WantsGlonassCardChanged, opt => opt.MapFrom(src => src.wantsGlonassCardChanged))
                .ForMember(dest => dest.WantsClientRegistered, opt => opt.MapFrom(src => src.wantsClientRegistered))
                .ForMember(dest => dest.WantsUpdateRequested, opt => opt.MapFrom(src => src.wantsUpdateRequested))
                .ForMember(dest => dest.WantsActiveCallCenterIndexChanged, opt => opt.MapFrom(src => src.wantsActiveCallCenterIndexChanged))
                .ForMember(dest => dest.WantsCardMessageListChangedFilter, opt => opt.MapFrom(src => src.wantsCardMessageListChangedFilter))
                .ForMember(dest => dest.WantsBroadcastMessageFilter, opt => opt.MapFrom(src => src.wantsBroadcastMessageFilter))
                .ForMember(dest => dest.WantsDepartmentInvolvedFilter, opt => opt.MapFrom(src => src.wantsDepartmentInvolvedFilter))
                .ForMember(dest => dest.WantsDepartmentStateChangedFilter, opt => opt.MapFrom(src => src.wantsDepartmentStateChangedFilter))
                .ForMember(dest => dest.WantsRequestedEnginesListChangedFilter, opt => opt.MapFrom(src => src.wantsRequestedEnginesListChangedFilter))
                .ForMember(dest => dest.WantsCardCurrentStatesInDepartmentsChangedFilter, opt => opt.MapFrom(src => src.wantsCardCurrentStatesInDepartmentsChangedFilter))
                .ForMember(dest => dest.WantsShiftReportChangedFilter, opt => opt.MapFrom(src => src.wantsShiftReportChangedFilter))
                .ForMember(dest => dest.WantsUpdatingCoordsFilter, opt => opt.MapFrom(src => src.wantsUpdatingCoordsFilter))
                .ForMember(dest => dest.WantsCamertonEnginesPositionFilter, opt => opt.MapFrom(src => src.wantsCamertonEnginesPositionFilter))
                .ForMember(dest => dest.WantsCommServDeadlineExceededFilter, opt => opt.MapFrom(src => src.wantsCommServDeadlineExceededFilter))
                .ForMember(dest => dest.WantsCardAdditionalInfoAddedFilter, opt => opt.MapFrom(src => src.wantsCardAdditionalInfoAddedFilter))
                .ForMember(dest => dest.WantsWeatherLayersChanged, opt => opt.MapFrom(src => src.wantsWeatherLayersChanged))
                .ForMember(dest => dest.WantsAllServiceTypeIdsCardChanged, opt => opt.MapFrom(src => src.wantsAllServiceTypeIdsCardChanged))
                .ForMember(dest => dest.WantsAllServiceTypeIdsCardCreated, opt => opt.MapFrom(src => src.wantsAllServiceTypeIdsCardCreated))
                .ForMember(dest => dest.WantsSmsStatusChanged, opt => opt.MapFrom(src => src.wantsSmsStatusChanged))
                .ForMember(dest => dest.WantsSmsUpdatedEvent, opt => opt.MapFrom(src => src.wantsSmsUpdatedEvent))
                .ForMember(dest => dest.WantsServiceTypeIdsCardChanged, opt => opt.MapFrom(src => src.wantsServiceTypeIdsCardChanged))
                .ForMember(dest => dest.WantsServiceTypeIdsCardCreated, opt => opt.MapFrom(src => src.wantsServiceTypeIdsCardCreated))
                .ReverseMapWithValidation();

            cfg.CreateMap<UpdatingCoordsFilter, UpdatingCoordsFilterModel>()
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ReverseMapWithValidation();

            cfg.CreateMap<FireBarrelsItem, FireBarrelsItemModel>()
                .ForMember(dest => dest.TypeID, opt => opt.MapFrom(src => src.nTypeID))
                .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.count))
                .ForMember(dest => dest.Supply, opt => opt.MapFrom(src => src.dtSupply))
                .ReverseMapWithValidation();

            cfg.CreateMap<FireExtinguishersItem, FireExtinguishersItemModel>()
                .ForMember(dest => dest.TypeID, opt => opt.MapFrom(src => src.nTypeID))
                .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.count))
                .ForMember(dest => dest.Supply, opt => opt.MapFrom(src => src.dtSupply))
                .ReverseMapWithValidation();

            cfg.CreateMap<FireChief, FireChiefModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.strName))
                .ForMember(dest => dest.JobId, opt => opt.MapFrom(src => src.nJobId))
                .ForMember(dest => dest.Arrive, opt => opt.MapFrom(src => src.dtArrive))
                .ReverseMapWithValidation();

            cfg.CreateMap<DrillsChief, DrillsChiefModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.strName))
                .ForMember(dest => dest.JobId, opt => opt.MapFrom(src => src.nJobId))
                .ReverseMapWithValidation();

            cfg.CreateMap<GdzsUnit, GdzsUnitModel>()
                .ForMember(dest => dest.NumOfPeoples, opt => opt.MapFrom(src => src.nNumOfPeoples))
                .ForMember(dest => dest.NumOfMinutes, opt => opt.MapFrom(src => src.nNumOfMinutes))
                .ForMember(dest => dest.StartWorking, opt => opt.MapFrom(src => src.dtStartWorking))
                .ReverseMapWithValidation();

            cfg.CreateMap<FireFighter, FireFighterModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.strName))
                .ForMember(dest => dest.JobId, opt => opt.MapFrom(src => src.nJobId))
                .ReverseMapWithValidation();

            cfg.CreateMap<SickPerson, SickPersonModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.strName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.strMiddleName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.strLastName))
                .ForMember(dest => dest.SickPersonSigns, opt => opt.MapFrom(src => src.strSickPersonSigns))
                .ForMember(dest => dest.IsMale, opt => opt.MapFrom(src => src.isMale))
                .ForMember(dest => dest.Birth, opt => opt.MapFrom(src => src.dtBirth))
                .ForMember(dest => dest.AgeYear, opt => opt.MapFrom(src => src.nAgeYear))
                .ForMember(dest => dest.AgeMonth, opt => opt.MapFrom(src => src.nAgeMonth))
                .ForMember(dest => dest.AgeDay, opt => opt.MapFrom(src => src.nAgeDay))
                .ForMember(dest => dest.ReasonId, opt => opt.MapFrom(src => src.nReasonId))
                .ForMember(dest => dest.ReasonTags, opt => opt.MapFrom(src => src.strReasonTags))
                .ForMember(dest => dest.ConsultDiagnosId, opt => opt.MapFrom(src => src.nConsultDiagnosId))
                .ForMember(dest => dest.DiagnosId, opt => opt.MapFrom(src => src.nDiagnosId))
                .ForMember(dest => dest.ResultId, opt => opt.MapFrom(src => src.nResultId))
                .ForMember(dest => dest.DeathCause, opt => opt.MapFrom(src => src.strDeathCause))
                .ForMember(dest => dest.EmcDefects, opt => opt.MapFrom(src => src.strEmcDefects))
                .ForMember(dest => dest.EmcAssistance, opt => opt.MapFrom(src => src.strEmcAssistance))
                .ForMember(dest => dest.IsReasonPriority, opt => opt.MapFrom(src => src.isReasonPriority))
                .ReverseMapWithValidation();

            cfg.CreateMap<Hospital, HospitalModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.nId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.strName))
                .ForMember(dest => dest.Sign, opt => opt.MapFrom(src => src.strSign))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.nCityId))
                .ReverseMapWithValidation();

            cfg.CreateMap<SettingsInfo, SettingsInfoModel>()
                .ForMember(dest => dest.User03Role, opt => opt.MapFrom(src => src.user03Role))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.cityId))
                .ForMember(dest => dest.LocalDistrictId, opt => opt.MapFrom(src => src.localDistrictId))
                .ForMember(dest => dest.RegionId, opt => opt.MapFrom(src => src.regionId))
                .ForMember(dest => dest.NumberOfForcesAvailableDeps, opt => opt.MapFrom(src => src.numberOfForcesAvailableDeps))
                .ForMember(dest => dest.CurrentDepartmentId, opt => opt.MapFrom(src => src.currentDepartmentId))
                .ForMember(dest => dest.IsRegion, opt => opt.MapFrom(src => src.isRegion))
                .ForMember(dest => dest.ActualDepartmentID, opt => opt.MapFrom(src => src.actualDepartmentID))
                .ForMember(dest => dest.WpID, opt => opt.MapFrom(src => src.wpID))
                .ForMember(dest => dest.RoleTitle, opt => opt.MapFrom(src => src.roleTitle))
                .ForMember(dest => dest.SourceZoneId, opt => opt.MapFrom(src => src.sourceZoneId))
                .ForMember(dest => dest.ImportanceLevelDefaultValue, opt => opt.MapFrom(src => src.importanceLevelDefaultValue))
                .ForMember(dest => dest.IsImportanceLevelEnabled, opt => opt.MapFrom(src => src.isImportanceLevelEnabled))
                .ForMember(dest => dest.AdditionalCityIds, opt => opt.MapFrom(src => src.nAdditionalCityIds))
                .ReverseMapWithValidation();

            cfg.CreateMap<PcInfo, PcInfoModel>()
                .ForMember(dest => dest.OsName, opt => opt.MapFrom(src => src.osName))
                .ForMember(dest => dest.SettingsInfo, opt => opt.MapFrom(src => src.settingsInfo))
                .ForMember(dest => dest.MaxDotNetFramework, opt => opt.MapFrom(src => src.maxDotNetFramework))
                .ForMember(dest => dest.MissingVcRedistribs, opt => opt.MapFrom(src => src.missingVcRedistribs))
                .ForMember(dest => dest.ClientDictionariesCache, opt => opt.MapFrom(src => src.clientDictionariesCache))
                .ReverseMapWithValidation();

            cfg.CreateMap<VideoQACamera, VideoQACameraModel>()
                .ForMember(dest => dest.CameraID, opt => opt.MapFrom(src => src.cameraID))
                .ForMember(dest => dest.OperatorID, opt => opt.MapFrom(src => src.operatorID))
                .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.manufacturer))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.model))
                .ForMember(dest => dest.IsPtz, opt => opt.MapFrom(src => src.isPtz))
                .ForMember(dest => dest.IsDigital, opt => opt.MapFrom(src => src.isDigital))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.address))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.longitude))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.latitude))
                .ForMember(dest => dest.Azimuth, opt => opt.MapFrom(src => src.azimuth))
                .ForMember(dest => dest.Angle, opt => opt.MapFrom(src => src.angle))
                .ForMember(dest => dest.Codec, opt => opt.MapFrom(src => src.codec))
                .ForMember(dest => dest.ResolutionX, opt => opt.MapFrom(src => src.resolutionX))
                .ForMember(dest => dest.ResolutionY, opt => opt.MapFrom(src => src.resolutionY))
                .ForMember(dest => dest.Fps, opt => opt.MapFrom(src => src.fps))
                .ForMember(dest => dest.Bitrate, opt => opt.MapFrom(src => src.bitrate))
                .ForMember(dest => dest.LostPackets, opt => opt.MapFrom(src => src.lostPackets))
                .ForMember(dest => dest.IpAddress, opt => opt.MapFrom(src => src.ipAddress))
                .ForMember(dest => dest.StreamPort, opt => opt.MapFrom(src => src.streamPort))
                .ForMember(dest => dest.WebPort, opt => opt.MapFrom(src => src.webPort))
                .ForMember(dest => dest.Login, opt => opt.MapFrom(src => src.login))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.password))
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.state))
                .ForMember(dest => dest.GatewayHost, opt => opt.MapFrom(src => src.gatewayHost))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ReverseMapWithValidation();

            cfg.CreateMap<EraGlonassECallLocation, EraGlonassECallLocationModel>()
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.latitude))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.longitude))
                .ForMember(dest => dest.PositionCanBeTrusted, opt => opt.MapFrom(src => src.positionCanBeTrusted))
                .ForMember(dest => dest.Timestamp, opt => opt.MapFrom(src => src.timestamp))
                .ReverseMapWithValidation();

            cfg.CreateMap<EraGlonassECallIntegration, EraGlonassECallIntegrationModel>()
                .ForMember(dest => dest.CardId, opt => opt.MapFrom(src => src.cardId))
                .ForMember(dest => dest.CardShortId, opt => opt.MapFrom(src => src.cardShortId))
                .ForMember(dest => dest.EsgCardId, opt => opt.MapFrom(src => src.esgCardId))
                .ForMember(dest => dest.DeclarantLanguageCode, opt => opt.MapFrom(src => src.declarantLanguageCode))
                .ForMember(dest => dest.VoiceChannelState, opt => opt.MapFrom(src => src.voiceChannelState))
                .ForMember(dest => dest.InjuredPersons, opt => opt.MapFrom(src => src.injuredPersons))
                .ForMember(dest => dest.DriverPhone, opt => opt.MapFrom(src => src.driverPhone))
                .ForMember(dest => dest.DriverFullName, opt => opt.MapFrom(src => src.driverFullName))
                .ForMember(dest => dest.TerminalPhone, opt => opt.MapFrom(src => src.terminalPhone))
                .ForMember(dest => dest.AutomaticActivation, opt => opt.MapFrom(src => src.automaticActivation))
                .ForMember(dest => dest.TestCall, opt => opt.MapFrom(src => src.testCall))
                .ForMember(dest => dest.VehicleType, opt => opt.MapFrom(src => src.vehicleType))
                .ForMember(dest => dest.VehicleIdentificationNumber, opt => opt.MapFrom(src => src.vehicleIdentificationNumber))
                .ForMember(dest => dest.VehiclePropulsionStorageType, opt => opt.MapFrom(src => src.vehiclePropulsionStorageType))
                .ForMember(dest => dest.CallTimestamp, opt => opt.MapFrom(src => src.callTimestamp))
                .ForMember(dest => dest.VehicleLocation, opt => opt.MapFrom(src => src.vehicleLocation))
                .ForMember(dest => dest.NumberOfPassengers, opt => opt.MapFrom(src => src.numberOfPassengers))
                .ForMember(dest => dest.SevereCrashEstimate, opt => opt.MapFrom(src => src.severeCrashEstimate))
                .ForMember(dest => dest.LocationDescription, opt => opt.MapFrom(src => src.locationDescription))
                .ForMember(dest => dest.CrashInfoFrontCrash, opt => opt.MapFrom(src => src.crashInfoFrontCrash))
                .ForMember(dest => dest.CrashInfoLeftCrash, opt => opt.MapFrom(src => src.crashInfoLeftCrash))
                .ForMember(dest => dest.CrashInfoRightCrash, opt => opt.MapFrom(src => src.crashInfoRightCrash))
                .ForMember(dest => dest.CrashInfoSideCrash, opt => opt.MapFrom(src => src.crashInfoSideCrash))
                .ForMember(dest => dest.CrashInfoRearCrash, opt => opt.MapFrom(src => src.crashInfoRearCrash))
                .ForMember(dest => dest.CrashInfoRollover, opt => opt.MapFrom(src => src.crashInfoRollover))
                .ForMember(dest => dest.CrashInfoOtherCrashType, opt => opt.MapFrom(src => src.crashInfoOtherCrashType))
                .ForMember(dest => dest.VehicleRegistryNumber, opt => opt.MapFrom(src => src.vehicleRegistryNumber))
                .ForMember(dest => dest.VehicleBodyColor, opt => opt.MapFrom(src => src.vehicleBodyColor))
                .ForMember(dest => dest.VehicleModel, opt => opt.MapFrom(src => src.vehicleModel))
                .ForMember(dest => dest.VehicleDirection, opt => opt.MapFrom(src => src.vehicleDirection))
                .ReverseMapWithValidation();

            cfg.CreateMap<MapAddress, MapAddressModel>()
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.country))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.region))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.city))
                .ForMember(dest => dest.District, opt => opt.MapFrom(src => src.district))
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.street))
                .ForMember(dest => dest.Localdistrict, opt => opt.MapFrom(src => src.localdistrict))
                .ForMember(dest => dest.AdditionalStreet, opt => opt.MapFrom(src => src.additionalStreet))
                .ForMember(dest => dest.House, opt => opt.MapFrom(src => src.house))
                .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src.building))
                .ForMember(dest => dest.Floors, opt => opt.MapFrom(src => src.floors))
                .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.cityId))
                .ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.districtId))
                .ForMember(dest => dest.StreetId, opt => opt.MapFrom(src => src.streetId))
                .ForMember(dest => dest.LocaldistrictId, opt => opt.MapFrom(src => src.localdistrictId))
                .ForMember(dest => dest.AdditionalStreetId, opt => opt.MapFrom(src => src.additionalStreetId))
                .ForMember(dest => dest.InvalidStreet, opt => opt.MapFrom(src => src.invalidStreet))
                .ForMember(dest => dest.Structure, opt => opt.MapFrom(src => src.structure))
                .ReverseMapWithValidation();

            cfg.CreateMap<GeoPoint, GeoPointModelFromGenerated>()
                .ForMember(dest => dest.Lat, opt => opt.MapFrom(src => src.lat))
                .ForMember(dest => dest.Lng, opt => opt.MapFrom(src => src.lng))
                .ReverseMapWithValidation();

            cfg.CreateMap<GeoArea, GeoAreaModelFromGenerated>()
                .ForMember(dest => dest.LowerCorner, opt => opt.MapFrom(src => src.lowerCorner))
                .ForMember(dest => dest.UpperCorner, opt => opt.MapFrom(src => src.upperCorner))
                .ForMember(dest => dest.Kind, opt => opt.MapFrom(src => src.kind))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.text))
                .ForMember(dest => dest.IsLocality, opt => opt.MapFrom(src => src.isLocality))
                .ForMember(dest => dest.IacObject, opt => opt.MapFrom(src => src.iacObject))
                .ForMember(dest => dest.Floors, opt => opt.MapFrom(src => src.floors))
                .ReverseMapWithValidation();

            cfg.CreateMap<CardMarkerInfo, CardMarkerInfoModel>()
                .ForMember(dest => dest.GlobalId, opt => opt.MapFrom(src => src.globalId))
                .ForMember(dest => dest.CardID, opt => opt.MapFrom(src => src.cardID))
                .ForMember(dest => dest.Coord, opt => opt.MapFrom(src => src.coord))
                .ForMember(dest => dest.CardState, opt => opt.MapFrom(src => src.cardState))
                .ForMember(dest => dest.CallType, opt => opt.MapFrom(src => src.callType))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.description))
                .ForMember(dest => dest.NeedToShow, opt => opt.MapFrom(src => src.needToShow))
                .ReverseMapWithValidation();

            cfg.CreateMap<CallHistoryItem, CallHistoryItemModel>()
                .ForMember(dest => dest.CallData, opt => opt.MapFrom(src => src.callData))
                .ForMember(dest => dest.CallTime, opt => opt.MapFrom(src => src.callTime))
                .ForMember(dest => dest.OperatorPin, opt => opt.MapFrom(src => src.operatorPin))
                .ForMember(dest => dest.Phonograms, opt => opt.MapFrom(src => src.phonograms))
                .ReverseMapWithValidation();

            cfg.CreateMap<Phonogram, PhonogramModel>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.url))
                .ForMember(dest => dest.Dtcreate, opt => opt.MapFrom(src => src.dtcreate))
                .ForMember(dest => dest.SourceType, opt => opt.MapFrom(src => src.sourceType))
                .ReverseMapWithValidation();

            cfg.CreateMap<Card112ListExcelReportParams, Card112ListExcelReportParamsModel>()
                .ForMember(dest => dest.Filter, opt => opt.MapFrom(src => src.filter))
                .ForMember(dest => dest.UsePaging, opt => opt.MapFrom(src => src.usePaging))
                .ForMember(dest => dest.From, opt => opt.MapFrom(src => src.from))
                .ForMember(dest => dest.To, opt => opt.MapFrom(src => src.to))
                .ForMember(dest => dest.OrderBy, opt => opt.MapFrom(src => src.orderBy))
                .ForMember(dest => dest.SortingOrder, opt => opt.MapFrom(src => src.sortingOrder))
                .ForMember(dest => dest.ReportColumns, opt => opt.MapFrom(src => src.reportColumns))
                .ReverseMapWithValidation();

            cfg.CreateMap<Column, ColumnModel>()
                .ForMember(dest => dest.Header, opt => opt.MapFrom(src => src.header))
                .ForMember(dest => dest.ServiceTypeId, opt => opt.MapFrom(src => src.serviceTypeId))
                .ForMember(dest => dest.FieldName, opt => opt.MapFrom(src => src.fieldName))
                .ReverseMapWithValidation();

            cfg.CreateMap<IntMapItem, IntMapItemModel>()
                .ForMember(dest => dest.Id1, opt => opt.MapFrom(src => src.id1))
                .ForMember(dest => dest.Id2, opt => opt.MapFrom(src => src.id2))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.strValue))
                .ReverseMapWithValidation();

            cfg.CreateMap<GisServiceGeoObject, GisServiceGeoObjectModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.description))
                .ForMember(dest => dest.GeoJsonLocation, opt => opt.MapFrom(src => src.geoJsonLocation))
                .ForMember(dest => dest.IconUrl, opt => opt.MapFrom(src => src.iconUrl))
                .ForMember(dest => dest.FillColor, opt => opt.MapFrom(src => src.fillColor))
                .ForMember(dest => dest.StrokeColor, opt => opt.MapFrom(src => src.strokeColor))
                .ForMember(dest => dest.PointRadius, opt => opt.MapFrom(src => src.pointRadius))
                .ForMember(dest => dest.FillOpacity, opt => opt.MapFrom(src => src.fillOpacity))
                .ForMember(dest => dest.StrokeOpacity, opt => opt.MapFrom(src => src.strokeOpacity))
                .ForMember(dest => dest.StrokeWidth, opt => opt.MapFrom(src => src.strokeWidth))
                .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.location))
                .ForMember(dest => dest.Fields, opt => opt.MapFrom(src => src.fields))
                .ReverseMapWithValidation();

            cfg.CreateMap<GisServiceGeoObjectField, GisServiceGeoObjectFieldModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.value))
                .ReverseMapWithValidation();

            cfg.CreateMap<GisServiceLayer, GisServiceLayerModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.description))
                .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.parentId))
                .ForMember(dest => dest.GeoObjects, opt => opt.MapFrom(src => src.geoObjects))
                .ForMember(dest => dest.Layers, opt => opt.MapFrom(src => src.layers))
                .ReverseMapWithValidation();

            cfg.CreateMap<Geometry, GeometryModel>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.type))
                .ForMember(dest => dest.Coordinates, opt => opt.MapFrom(src => src.coordinates))
                .ReverseMapWithValidation();

            cfg.CreateMap<Location, LocationModel>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.type))
                .ForMember(dest => dest.Geometry, opt => opt.MapFrom(src => src.geometry))
                .ReverseMapWithValidation();

            cfg.CreateMap<DistanceInfo, DistanceInfoModel>()
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.distance))
                .ReverseMapWithValidation();

            cfg.CreateMap<DistanceOnRouteInfo, DistanceOnRouteInfoModel>()
                .ForMember(dest => dest.Distance, opt => opt.MapFrom(src => src.distance))
                .ForMember(dest => dest.Points, opt => opt.MapFrom(src => src.points))
                .ReverseMapWithValidation();

            cfg.CreateMap<LayersInfo, LayersInfoModel>()
                .ForMember(dest => dest.WithObjects, opt => opt.MapFrom(src => src.withObjects))
                .ForMember(dest => dest.Layers, opt => opt.MapFrom(src => src.layers))
                .ReverseMapWithValidation();

            cfg.CreateMap<GeoObjectsInfo, GeoObjectsInfoModel>()
                .ForMember(dest => dest.LastPage, opt => opt.MapFrom(src => src.lastPage))
                .ForMember(dest => dest.TotalCount, opt => opt.MapFrom(src => src.totalCount))
                .ForMember(dest => dest.GeoObjects, opt => opt.MapFrom(src => src.geoObjects))
                .ReverseMapWithValidation();

            cfg.CreateMap<SearchInfo, SearchInfoModel>()
                .ForMember(dest => dest.WithObjects, opt => opt.MapFrom(src => src.withObjects))
                .ForMember(dest => dest.Layers, opt => opt.MapFrom(src => src.layers))
                .ReverseMapWithValidation();


            return cfg;
        }

        private static IMappingExpression<TDestination, TSource> ReverseMapWithValidation<TSource, TDestination>(this IMappingExpression<TSource, TDestination> mapping)
            => mapping.ReverseMap().ValidateMemberList(MemberList.Destination);
    }
}