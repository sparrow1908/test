using System;
using AutoMapper;
using Dt.EsApi.Models;
using ServerLogic.Requests.Card_112;
using ServerLogic.Types;

namespace Dt.EsApi.Mapper
{
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
            cfg.CreateMap<Tm_CardGeneralData, CardGeneralData>()
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

            return cfg;
        }

        private static IMappingExpression<TDestination, TSource> ReverseMapWithValidation<TSource, TDestination>(this IMappingExpression<TSource, TDestination> mapping)
            => mapping.ReverseMap().ValidateMemberList(MemberList.Destination);
    }
}