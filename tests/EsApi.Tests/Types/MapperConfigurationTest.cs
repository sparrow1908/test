using AutoFixture;
using Dt.EsApi.Mapper;
using Dt.EsApi.Models;
using ServerLogic.Types;
using System.Linq;
using Xunit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ServerLogic.Tests.Types
{
    public class MapperConfigurationTest
    {
        [Fact]
        public void AllFieldAreMappingTest()
        {
            var config = AutoMapperConfigurationFactory.ConfigureMapper();
            config.AssertConfigurationIsValid();
        }

        [Fact]
        public void Card04MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_04_Data>();

            // Act
            var cardModel = mapper.Map<Tm_Card_04_Data, Card04Model>(cardDto);
            var cardNewDto = mapper.Map<Card04Model, Tm_Card_04_Data>(cardModel);

            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardsContainerMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardsContainer>();
            // Act
            var cardModel = mapper.Map<CardsContainer, CardsContainerModel>(cardDto);
            var cardNewDto = mapper.Map<CardsContainerModel, CardsContainer>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card112MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_112_Data>();
            // Act
            var cardModel = mapper.Map<Tm_Card_112_Data, Card112Model>(cardDto);
            var cardNewDto = mapper.Map<Card112Model, Tm_Card_112_Data>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card01MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_01_Data>();
            // Act
            var cardModel = mapper.Map<Tm_Card_01_Data, Card01Model>(cardDto);
            var cardNewDto = mapper.Map<Card01Model, Tm_Card_01_Data>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card02MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_02_Data>();
            // Act
            var cardModel = mapper.Map<Tm_Card_02_Data, Card02Model>(cardDto);
            var cardNewDto = mapper.Map<Card02Model, Tm_Card_02_Data>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardOVDMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_OVD_Data>();
            // Act
            var cardModel = mapper.Map<Tm_Card_OVD_Data, CardOVDModel>(cardDto);
            var cardNewDto = mapper.Map<CardOVDModel, Tm_Card_OVD_Data>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card03MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_03_Data>();
            // Act
            var cardModel = mapper.Map<Tm_Card_03_Data, Card03Model>(cardDto);
            var cardNewDto = mapper.Map<Card03Model, Tm_Card_03_Data>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardCommServMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_CommServ_Data>();
            // Act
            var cardModel = mapper.Map<Tm_Card_CommServ_Data, CardCommServModel>(cardDto);
            var cardNewDto = mapper.Map<CardCommServModel, Tm_Card_CommServ_Data>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardATMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_Card_AT_Data>();
            // Act
            var cardModel = mapper.Map<Tm_Card_AT_Data, CardATModel>(cardDto);
            var cardNewDto = mapper.Map<CardATModel, Tm_Card_AT_Data>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceCard01MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceCard01>();
            // Act
            var cardModel = mapper.Map<ServiceCard01, ServiceCard01Model>(cardDto);
            var cardNewDto = mapper.Map<ServiceCard01Model, ServiceCard01>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceCard02MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceCard02>();
            // Act
            var cardModel = mapper.Map<ServiceCard02, ServiceCard02Model>(cardDto);
            var cardNewDto = mapper.Map<ServiceCard02Model, ServiceCard02>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceCard03MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceCard03>();
            // Act
            var cardModel = mapper.Map<ServiceCard03, ServiceCard03Model>(cardDto);
            var cardNewDto = mapper.Map<ServiceCard03Model, ServiceCard03>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceCard04MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceCard04>();
            // Act
            var cardModel = mapper.Map<ServiceCard04, ServiceCard04Model>(cardDto);
            var cardNewDto = mapper.Map<ServiceCard04Model, ServiceCard04>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceCardCommServMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceCardCommServ>();
            // Act
            var cardModel = mapper.Map<ServiceCardCommServ, ServiceCardCommServModel>(cardDto);
            var cardNewDto = mapper.Map<ServiceCardCommServModel, ServiceCardCommServ>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceCardATMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceCardAT>();
            // Act
            var cardModel = mapper.Map<ServiceCardAT, ServiceCardATModel>(cardDto);
            var cardNewDto = mapper.Map<ServiceCardATModel, ServiceCardAT>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void PrevDeclarantInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<PrevDeclarantInfo>();
            // Act
            var cardModel = mapper.Map<PrevDeclarantInfo, PrevDeclarantInfoModel>(cardDto);
            var cardNewDto = mapper.Map<PrevDeclarantInfoModel, PrevDeclarantInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_CardGeneralData>();
            // Act
            var cardModel = mapper.Map <Tm_CardGeneralData, CardGeneralDataModel> (cardDto);
            var cardNewDto = mapper.Map<CardGeneralDataModel, Tm_CardGeneralData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CallCenterConnectionInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CallCenterConnectionInfo>();
            // Act
            var cardModel = mapper.Map<CallCenterConnectionInfo, CallCenterConnectionInfoModel>(cardDto);
            var cardNewDto = mapper.Map<CallCenterConnectionInfoModel, CallCenterConnectionInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void AttachmentListMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<AttachmentList>();
            // Act
            var cardModel = mapper.Map<AttachmentList, AttachmentListModel>(cardDto);
            var cardNewDto = mapper.Map<AttachmentListModel, AttachmentList>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void AttachmentDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<AttachmentData>();
            // Act
            var cardModel = mapper.Map<AttachmentData, AttachmentDataModel>(cardDto);
            var cardNewDto = mapper.Map<AttachmentDataModel, AttachmentData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void AttachmentContentMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<AttachmentContent>();
            // Act
            var cardModel = mapper.Map<AttachmentContent, AttachmentContentModel>(cardDto);
            var cardNewDto = mapper.Map<AttachmentContentModel, AttachmentContent>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GeographicLocationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<GeographicLocation>();
            // Act
            var cardModel = mapper.Map<GeographicLocation, GeographicLocationModel>(cardDto);
            var cardNewDto = mapper.Map<GeographicLocationModel, GeographicLocation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CamertonEngineMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CamertonEngine>();
            // Act
            var cardModel = mapper.Map<CamertonEngine, CamertonEngineModel>(cardDto);
            var cardNewDto = mapper.Map<CamertonEngineModel, CamertonEngine>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardCommServFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardCommServFilter>();
            // Act
            var cardModel = mapper.Map<CardCommServFilter, CardCommServFilterModel>(cardDto);
            var cardNewDto = mapper.Map<CardCommServFilterModel, CardCommServFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card03FilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card03Filter>();
            // Act
            var cardModel = mapper.Map<Card03Filter, Card03FilterModel>(cardDto);
            var cardNewDto = mapper.Map<Card03FilterModel, Card03Filter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card112FilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card112Filter>();
            // Act
            var cardModel = mapper.Map<Card112Filter, Card112FilterModel>(cardDto);
            var cardNewDto = mapper.Map<Card112FilterModel, Card112Filter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ValidationRuleMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ValidationRule>();
            // Act
            var cardModel = mapper.Map<ValidationRule, ValidationRuleModel>(cardDto);
            var cardNewDto = mapper.Map<ValidationRuleModel, ValidationRule>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card112ValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card112Validation>();
            // Act
            var cardModel = mapper.Map<Card112Validation, Card112ValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card112ValidationModel, Card112Validation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card01ValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card01Validation>();
            // Act
            var cardModel = mapper.Map<Card01Validation, Card01ValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card01ValidationModel, Card01Validation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardForceValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardForceValidation>();
            // Act
            var cardModel = mapper.Map<CardForceValidation, CardForceValidationModel>(cardDto);
            var cardNewDto = mapper.Map<CardForceValidationModel, CardForceValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card02ValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card02Validation>();
            // Act
            var cardModel = mapper.Map<Card02Validation, Card02ValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card02ValidationModel, Card02Validation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardOvdValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardOvdValidation>();
            // Act
            var cardModel = mapper.Map<CardOvdValidation, CardOvdValidationModel>(cardDto);
            var cardNewDto = mapper.Map<CardOvdValidationModel, CardOvdValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card02WantedValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card02WantedValidation>();
            // Act
            var cardModel = mapper.Map<Card02WantedValidation, Card02WantedValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card02WantedValidationModel, Card02WantedValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card02SuspectValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card02SuspectValidation>();
            // Act
            var cardModel = mapper.Map<Card02SuspectValidation, Card02SuspectValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card02SuspectValidationModel, Card02SuspectValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card02VehicleValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card02VehicleValidation>();
            // Act
            var cardModel = mapper.Map<Card02VehicleValidation, Card02VehicleValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card02VehicleValidationModel, Card02VehicleValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card02VictimValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card02VictimValidation>();
            // Act
            var cardModel = mapper.Map<Card02VictimValidation, Card02VictimValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card02VictimValidationModel, Card02VictimValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card03ValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card03Validation>();
            // Act
            var cardModel = mapper.Map<Card03Validation, Card03ValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card03ValidationModel, Card03Validation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card03SickPersonValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card03SickPersonValidation>();
            // Act
            var cardModel = mapper.Map<Card03SickPersonValidation, Card03SickPersonValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card03SickPersonValidationModel, Card03SickPersonValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card04ValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card04Validation>();
            // Act
            var cardModel = mapper.Map<Card04Validation, Card04ValidationModel>(cardDto);
            var cardNewDto = mapper.Map<Card04ValidationModel, Card04Validation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardATValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardATValidation>();
            // Act
            var cardModel = mapper.Map<CardATValidation, CardATValidationModel>(cardDto);
            var cardNewDto = mapper.Map<CardATValidationModel, CardATValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardCommServValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardCommServValidation>();
            // Act
            var cardModel = mapper.Map<CardCommServValidation, CardCommServValidationModel>(cardDto);
            var cardNewDto = mapper.Map<CardCommServValidationModel, CardCommServValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardCustomServiceValidationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardCustomServiceValidation>();
            // Act
            var cardModel = mapper.Map<CardCustomServiceValidation, CardCustomServiceValidationModel>(cardDto);
            var cardNewDto = mapper.Map<CardCustomServiceValidationModel, CardCustomServiceValidation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardCustomServiceValidationItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardCustomServiceValidationItem>();
            // Act
            var cardModel = mapper.Map<CardCustomServiceValidationItem, CardCustomServiceValidationItemModel>(cardDto);
            var cardNewDto = mapper.Map<CardCustomServiceValidationItemModel, CardCustomServiceValidationItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ValidationsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Validations>();
            // Act
            var cardModel = mapper.Map<Validations, ValidationsModel>(cardDto);
            var cardNewDto = mapper.Map<ValidationsModel, Validations>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ButtonCommandMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ButtonCommand>();
            // Act
            var cardModel = mapper.Map<ButtonCommand, ButtonCommandModel>(cardDto);
            var cardNewDto = mapper.Map<ButtonCommandModel, ButtonCommand>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void RoleSettingsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<RoleSettings>();
            // Act
            var cardModel = mapper.Map<RoleSettings, RoleSettingsModel>(cardDto);
            var cardNewDto = mapper.Map<RoleSettingsModel, RoleSettings>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void EmergencyCardMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<EmergencyCard>();
            // Act
            var cardModel = mapper.Map<EmergencyCard, EmergencyCardModel>(cardDto);
            var cardNewDto = mapper.Map<EmergencyCardModel, EmergencyCard>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void OperatorCanEditItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<OperatorCanEditItem>();
            // Act
            var cardModel = mapper.Map<OperatorCanEditItem, OperatorCanEditItemModel>(cardDto);
            var cardNewDto = mapper.Map<OperatorCanEditItemModel, OperatorCanEditItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void EmergencyServersCollectionMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<EmergencyServersCollection>();
            // Act
            var cardModel = mapper.Map<EmergencyServersCollection, EmergencyServersCollectionModel>(cardDto);
            var cardNewDto = mapper.Map<EmergencyServersCollectionModel, EmergencyServersCollection>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void EmergencyServerInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<EmergencyServerInfo>();
            // Act
            var cardModel = mapper.Map<EmergencyServerInfo, EmergencyServerInfoModel>(cardDto);
            var cardNewDto = mapper.Map<EmergencyServerInfoModel, EmergencyServerInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void WeatherMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Weather>();
            // Act
            var cardModel = mapper.Map<Weather, WeatherModel>(cardDto);
            var cardNewDto = mapper.Map<WeatherModel, Weather>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void WeatherLayerMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<WeatherLayer>();
            // Act
            var cardModel = mapper.Map<WeatherLayer, WeatherLayerModel>(cardDto);
            var cardNewDto = mapper.Map<WeatherLayerModel, WeatherLayer>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void AddressbookSettingMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<AddressbookSetting>();
            // Act
            var cardModel = mapper.Map<AddressbookSetting, AddressbookSettingModel>(cardDto);
            var cardNewDto = mapper.Map<AddressbookSettingModel, AddressbookSetting>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void AddressbookSettingsItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<AddressbookSettingsItem>();
            // Act
            var cardModel = mapper.Map<AddressbookSettingsItem, AddressbookSettingsItemModel>(cardDto);
            var cardNewDto = mapper.Map<AddressbookSettingsItemModel, AddressbookSettingsItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void VisualAttributesMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<VisualAttributes>();
            // Act
            var cardModel = mapper.Map<VisualAttributes, VisualAttributesModel>(cardDto);
            var cardNewDto = mapper.Map<VisualAttributesModel, VisualAttributes>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardConditionMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardCondition>();
            // Act
            var cardModel = mapper.Map<CardCondition, CardConditionModel>(cardDto);
            var cardNewDto = mapper.Map<CardConditionModel, CardCondition>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardHighlightItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardHighlightItem>();
            // Act
            var cardModel = mapper.Map<CardHighlightItem, CardHighlightItemModel>(cardDto);
            var cardNewDto = mapper.Map<CardHighlightItemModel, CardHighlightItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CustomServiceMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CustomService>();
            // Act
            var cardModel = mapper.Map<CustomService, CustomServiceModel>(cardDto);
            var cardNewDto = mapper.Map<CustomServiceModel, CustomService>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CustomServiceDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CustomServiceData>();
            // Act
            var cardModel = mapper.Map<CustomServiceData, CustomServiceDataModel>(cardDto);
            var cardNewDto = mapper.Map<CustomServiceDataModel, CustomServiceData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardCustomServiceMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardCustomService>();
            // Act
            var cardModel = mapper.Map<CardCustomService, CardCustomServiceModel>(cardDto);
            var cardNewDto = mapper.Map<CardCustomServiceModel, CardCustomService>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MetaFieldsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MetaFields>();
            // Act
            var cardModel = mapper.Map<MetaFields, MetaFieldsModel>(cardDto);
            var cardNewDto = mapper.Map<MetaFieldsModel, MetaFields>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CustomFieldsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CustomFields>();
            // Act
            var cardModel = mapper.Map<CustomFields, CustomFieldsModel>(cardDto);
            var cardNewDto = mapper.Map<CustomFieldsModel, CustomFields>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void BoolFieldMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<BoolField>();
            // Act
            var cardModel = mapper.Map<BoolField, BoolFieldModel>(cardDto);
            var cardNewDto = mapper.Map<BoolFieldModel, BoolField>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void IntFieldMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<IntField>();
            // Act
            var cardModel = mapper.Map<IntField, IntFieldModel>(cardDto);
            var cardNewDto = mapper.Map<IntFieldModel, IntField>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void StringFieldMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<StringField>();
            // Act
            var cardModel = mapper.Map<StringField, StringFieldModel>(cardDto);
            var cardNewDto = mapper.Map<StringFieldModel, StringField>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ComboFieldMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ComboField>();
            // Act
            var cardModel = mapper.Map<ComboField, ComboFieldModel>(cardDto);
            var cardNewDto = mapper.Map<ComboFieldModel, ComboField>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DateTimeFieldMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DateTimeField>();
            // Act
            var cardModel = mapper.Map<DateTimeField, DateTimeFieldModel>(cardDto);
            var cardNewDto = mapper.Map<DateTimeFieldModel, DateTimeField>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void TableMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Table>();
            // Act
            var cardModel = mapper.Map<Table, TableModel>(cardDto);
            var cardNewDto = mapper.Map<TableModel, Table>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void BoolColumnMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<BoolColumn>();
            // Act
            var cardModel = mapper.Map<BoolColumn, BoolColumnModel>(cardDto);
            var cardNewDto = mapper.Map<BoolColumnModel, BoolColumn>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void BoolCellMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<BoolCell>();
            // Act
            var cardModel = mapper.Map<BoolCell, BoolCellModel>(cardDto);
            var cardNewDto = mapper.Map<BoolCellModel, BoolCell>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void StringColumnMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<StringColumn>();
            // Act
            var cardModel = mapper.Map<StringColumn, StringColumnModel>(cardDto);
            var cardNewDto = mapper.Map<StringColumnModel, StringColumn>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void StringCellMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<StringCell>();
            // Act
            var cardModel = mapper.Map<StringCell, StringCellModel>(cardDto);
            var cardNewDto = mapper.Map<StringCellModel, StringCell>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void IntColumnMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<IntColumn>();
            // Act
            var cardModel = mapper.Map<IntColumn, IntColumnModel>(cardDto);
            var cardNewDto = mapper.Map<IntColumnModel, IntColumn>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void IntCellMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<IntCell>();
            // Act
            var cardModel = mapper.Map<IntCell, IntCellModel>(cardDto);
            var cardNewDto = mapper.Map<IntCellModel, IntCell>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DateTimeColumnMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DateTimeColumn>();
            // Act
            var cardModel = mapper.Map<DateTimeColumn, DateTimeColumnModel>(cardDto);
            var cardNewDto = mapper.Map<DateTimeColumnModel, DateTimeColumn>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DateTimeCellMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DateTimeCell>();
            // Act
            var cardModel = mapper.Map<DateTimeCell, DateTimeCellModel>(cardDto);
            var cardNewDto = mapper.Map<DateTimeCellModel, DateTimeCell>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ComboColumnMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ComboColumn>();
            // Act
            var cardModel = mapper.Map<ComboColumn, ComboColumnModel>(cardDto);
            var cardNewDto = mapper.Map<ComboColumnModel, ComboColumn>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ComboCellMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ComboCell>();
            // Act
            var cardModel = mapper.Map<ComboCell, ComboCellModel>(cardDto);
            var cardNewDto = mapper.Map<ComboCellModel, ComboCell>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceEventMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceEvent>();
            // Act
            var cardModel = mapper.Map<ServiceEvent, ServiceEventModel>(cardDto);
            var cardNewDto = mapper.Map<ServiceEventModel, ServiceEvent>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MetaDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MetaData>();
            // Act
            var cardModel = mapper.Map<MetaData, MetaDataModel>(cardDto);
            var cardNewDto = mapper.Map<MetaDataModel, MetaData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ReplicationTargetInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ReplicationTargetInfo>();
            // Act
            var cardModel = mapper.Map<ReplicationTargetInfo, ReplicationTargetInfoModel>(cardDto);
            var cardNewDto = mapper.Map<ReplicationTargetInfoModel, ReplicationTargetInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ReplicationMetaDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ReplicationMetaData>();
            // Act
            var cardModel = mapper.Map<ReplicationMetaData, ReplicationMetaDataModel>(cardDto);
            var cardNewDto = mapper.Map<ReplicationMetaDataModel, ReplicationMetaData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void RegionAdditionalInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<RegionAdditionalInfo>();
            // Act
            var cardModel = mapper.Map<RegionAdditionalInfo, RegionAdditionalInfoModelFromGenerated>(cardDto);
            var cardNewDto = mapper.Map<RegionAdditionalInfoModelFromGenerated, RegionAdditionalInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void PhoneBookDictionaryMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<PhoneBookDictionary>();
            // Act
            var cardModel = mapper.Map<PhoneBookDictionary, PhoneBookDictionaryModel>(cardDto);
            var cardNewDto = mapper.Map<PhoneBookDictionaryModel, PhoneBookDictionary>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void RegionDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<RegionData>();
            // Act
            var cardModel = mapper.Map<RegionData, RegionDataModel>(cardDto);
            var cardNewDto = mapper.Map<RegionDataModel, RegionData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MNISReactionMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MNISReaction>();
            // Act
            var cardModel = mapper.Map<MNISReaction, MNISReactionModel>(cardDto);
            var cardNewDto = mapper.Map<MNISReactionModel, MNISReaction>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MNISReactionItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MNISReactionItem>();
            // Act
            var cardModel = mapper.Map<MNISReactionItem, MNISReactionItemModel>(cardDto);
            var cardNewDto = mapper.Map<MNISReactionItemModel, MNISReactionItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MNISEventMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MNISEvent>();
            // Act
            var cardModel = mapper.Map<MNISEvent, MNISEventModel>(cardDto);
            var cardNewDto = mapper.Map<MNISEventModel, MNISEvent>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Vehicle03InfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Vehicle03Info>();
            // Act
            var cardModel = mapper.Map<Vehicle03Info, Vehicle03InfoModel>(cardDto);
            var cardNewDto = mapper.Map<Vehicle03InfoModel, Vehicle03Info>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Vehicle01InfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Vehicle01Info>();
            // Act
            var cardModel = mapper.Map<Vehicle01Info, Vehicle01InfoModel>(cardDto);
            var cardNewDto = mapper.Map<Vehicle01InfoModel, Vehicle01Info>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void VehicleArrivalMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<VehicleArrival>();
            // Act
            var cardModel = mapper.Map<VehicleArrival, VehicleArrivalModel>(cardDto);
            var cardNewDto = mapper.Map<VehicleArrivalModel, VehicleArrival>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ArrivalInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ArrivalInfo>();
            // Act
            var cardModel = mapper.Map<ArrivalInfo, ArrivalInfoModel>(cardDto);
            var cardNewDto = mapper.Map<ArrivalInfoModel, ArrivalInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void VehicleTrackInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<VehicleTrackInfo>();
            // Act
            var cardModel = mapper.Map<VehicleTrackInfo, VehicleTrackInfoModel>(cardDto);
            var cardNewDto = mapper.Map<VehicleTrackInfoModel, VehicleTrackInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ConnectionInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ConnectionInfo>();
            // Act
            var cardModel = mapper.Map<ConnectionInfo, ConnectionInfoModel>(cardDto);
            var cardNewDto = mapper.Map<ConnectionInfoModel, ConnectionInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MRSSettingsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MRSSettings>();
            // Act
            var cardModel = mapper.Map<MRSSettings, MRSSettingsModel>(cardDto);
            var cardNewDto = mapper.Map<MRSSettingsModel, MRSSettings>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MapsSettingsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MapsSettings>();
            // Act
            var cardModel = mapper.Map<MapsSettings, MapsSettingsModel>(cardDto);
            var cardNewDto = mapper.Map<MapsSettingsModel, MapsSettings>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MapTileUrlMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MapTileUrl>();
            // Act
            var cardModel = mapper.Map<MapTileUrl, MapTileUrlModelFromGenerated>(cardDto);
            var cardNewDto = mapper.Map<MapTileUrlModelFromGenerated, MapTileUrl>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CallCenterSettingsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CallCenterSettings>();
            // Act
            var cardModel = mapper.Map<CallCenterSettings, CallCenterSettingsModel>(cardDto);
            var cardNewDto = mapper.Map<CallCenterSettingsModel, CallCenterSettings>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CallCenterParameterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CallCenterParameter>();
            // Act
            var cardModel = mapper.Map<CallCenterParameter, CallCenterParameterModel>(cardDto);
            var cardNewDto = mapper.Map<CallCenterParameterModel, CallCenterParameter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void SettingsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Settings>();
            // Act
            var cardModel = mapper.Map<Settings, SettingsModel>(cardDto);
            var cardNewDto = mapper.Map<SettingsModel, Settings>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CallDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CallData>();
            // Act
            var cardModel = mapper.Map<CallData, CallDataModel>(cardDto);
            var cardNewDto = mapper.Map<CallDataModel, CallData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void SMSDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<SMSData>();
            // Act
            var cardModel = mapper.Map<SMSData, SMSDataModel>(cardDto);
            var cardNewDto = mapper.Map<SMSDataModel, SMSData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void IncidentTypeRecordMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<IncidentTypeRecord>();
            // Act
            var cardModel = mapper.Map<IncidentTypeRecord, IncidentTypeRecordModel>(cardDto);
            var cardNewDto = mapper.Map<IncidentTypeRecordModel, IncidentTypeRecord>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceIncidentTypeRecordMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceIncidentTypeRecord>();
            // Act
            var cardModel = mapper.Map<ServiceIncidentTypeRecord, ServiceIncidentTypeRecordModel>(cardDto);
            var cardNewDto = mapper.Map<ServiceIncidentTypeRecordModel, ServiceIncidentTypeRecord>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceDeadlinesMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceDeadlines>();
            // Act
            var cardModel = mapper.Map<ServiceDeadlines, ServiceDeadlinesModel>(cardDto);
            var cardNewDto = mapper.Map<ServiceDeadlinesModel, ServiceDeadlines>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ReplicationTargetMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ReplicationTarget>();
            // Act
            var cardModel = mapper.Map<ReplicationTarget, ReplicationTargetModel>(cardDto);
            var cardNewDto = mapper.Map<ReplicationTargetModel, ReplicationTarget>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card112ListMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card112List>();
            // Act
            var cardModel = mapper.Map<Card112List, Card112ListModel>(cardDto);
            var cardNewDto = mapper.Map<Card112ListModel, Card112List>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Tm_ISharerDescriptionMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_ISharerDescription>();
            // Act
            var cardModel = mapper.Map<Tm_ISharerDescription, ISharerDescriptionModel>(cardDto);
            var cardNewDto = mapper.Map<ISharerDescriptionModel, Tm_ISharerDescription>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Tm_IVehicleDescriptionMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_IVehicleDescription>();
            // Act
            var cardModel = mapper.Map<Tm_IVehicleDescription, IVehicleDescriptionModel>(cardDto);
            var cardNewDto = mapper.Map<IVehicleDescriptionModel, Tm_IVehicleDescription>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Tm_IVictimDescriptionMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_IVictimDescription>();
            // Act
            var cardModel = mapper.Map<Tm_IVictimDescription, IVictimDescriptionModel>(cardDto);
            var cardNewDto = mapper.Map<IVictimDescriptionModel, Tm_IVictimDescription>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void TaskForceItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<TaskForceItem>();
            // Act
            var cardModel = mapper.Map<TaskForceItem, TaskForceItemModel>(cardDto);
            var cardNewDto = mapper.Map<TaskForceItemModel, TaskForceItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card02FilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card02Filter>();
            // Act
            var cardModel = mapper.Map<Card02Filter, Card02FilterModel>(cardDto);
            var cardNewDto = mapper.Map<Card02FilterModel, Card02Filter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Tm_DictionaryItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_DictionaryItem>();
            // Act
            var cardModel = mapper.Map<Tm_DictionaryItem, DictionaryItemModel>(cardDto);
            var cardNewDto = mapper.Map<DictionaryItemModel, Tm_DictionaryItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DCRecordMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DCRecord>();
            // Act
            var cardModel = mapper.Map<DCRecord, DCRecordModel>(cardDto);
            var cardNewDto = mapper.Map<DCRecordModel, DCRecord>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void SDCRecordMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<SDCRecord>();
            // Act
            var cardModel = mapper.Map<SDCRecord, SDCRecordModel>(cardDto);
            var cardNewDto = mapper.Map<SDCRecordModel, SDCRecord>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardStateDescStructMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardStateDescStruct>();
            // Act
            var cardModel = mapper.Map<CardStateDescStruct, CardStateDescStructModel>(cardDto);
            var cardNewDto = mapper.Map<CardStateDescStructModel, CardStateDescStruct>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardSyntheticStateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardSyntheticState>();
            // Act
            var cardModel = mapper.Map<CardSyntheticState, CardSyntheticStateModel>(cardDto);
            var cardNewDto = mapper.Map<CardSyntheticStateModel, CardSyntheticState>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Tm_SubCallTypeItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_SubCallTypeItem>();
            // Act
            var cardModel = mapper.Map<Tm_SubCallTypeItem, SubCallTypeItemModel>(cardDto);
            var cardNewDto = mapper.Map<SubCallTypeItemModel, Tm_SubCallTypeItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FieldConstraintMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FieldConstraint>();
            // Act
            var cardModel = mapper.Map<FieldConstraint, FieldConstraintModel>(cardDto);
            var cardNewDto = mapper.Map<FieldConstraintModel, FieldConstraint>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ObjectStructMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ObjectStruct>();
            // Act
            var cardModel = mapper.Map<ObjectStruct, ObjectStructModel>(cardDto);
            var cardNewDto = mapper.Map<ObjectStructModel, ObjectStruct>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FireObjectRangeStructMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FireObjectRangeStruct>();
            // Act
            var cardModel = mapper.Map<FireObjectRangeStruct, FireObjectRangeStructModel>(cardDto);
            var cardNewDto = mapper.Map<FireObjectRangeStructModel, FireObjectRangeStruct>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FireReactionPlanItemStructMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FireReactionPlanItemStruct>();
            // Act
            var cardModel = mapper.Map<FireReactionPlanItemStruct, FireReactionPlanItemStructModel>(cardDto);
            var cardNewDto = mapper.Map<FireReactionPlanItemStructModel, FireReactionPlanItemStruct>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FireReactionPlanStructMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FireReactionPlanStruct>();
            // Act
            var cardModel = mapper.Map<FireReactionPlanStruct, FireReactionPlanStructModel>(cardDto);
            var cardNewDto = mapper.Map<FireReactionPlanStructModel, FireReactionPlanStruct>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MalefactionStructMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MalefactionStruct>();
            // Act
            var cardModel = mapper.Map<MalefactionStruct, MalefactionStructModel>(cardDto);
            var cardNewDto = mapper.Map<MalefactionStructModel, MalefactionStruct>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MalefactionGroupStructMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MalefactionGroupStruct>();
            // Act
            var cardModel = mapper.Map<MalefactionGroupStruct, MalefactionGroupStructModel>(cardDto);
            var cardNewDto = mapper.Map<MalefactionGroupStructModel, MalefactionGroupStruct>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Tm_SnapshotDataMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_SnapshotData>();
            // Act
            var cardModel = mapper.Map<Tm_SnapshotData, Tm_SnapshotDataModel>(cardDto);
            var cardNewDto = mapper.Map<Tm_SnapshotDataModel, Tm_SnapshotData>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CustomServiceCardTemplateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CustomServiceCardTemplate>();
            // Act
            var cardModel = mapper.Map<CustomServiceCardTemplate, CustomServiceCardTemplateModel>(cardDto);
            var cardNewDto = mapper.Map<CustomServiceCardTemplateModel, CustomServiceCardTemplate>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ServiceTypeIdToCustomServiceCardTemplateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ServiceTypeIdToCustomServiceCardTemplate>();
            // Act
            var cardModel = mapper.Map<ServiceTypeIdToCustomServiceCardTemplate, ServiceTypeIdToCustomServiceCardTemplateModel>(cardDto);
            var cardNewDto = mapper.Map<ServiceTypeIdToCustomServiceCardTemplateModel, ServiceTypeIdToCustomServiceCardTemplate>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FieldInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FieldInfo>();
            // Act
            var cardModel = mapper.Map<FieldInfo, FieldInfoModel>(cardDto);
            var cardNewDto = mapper.Map<FieldInfoModel, FieldInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ControlTemplateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ControlTemplate>();
            // Act
            var cardModel = mapper.Map<ControlTemplate, ControlTemplateModel>(cardDto);
            var cardNewDto = mapper.Map<ControlTemplateModel, ControlTemplate>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ComboControlTemplateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ComboControlTemplate>();
            // Act
            var cardModel = mapper.Map<ComboControlTemplate, ComboControlTemplateModel>(cardDto);
            var cardNewDto = mapper.Map<ComboControlTemplateModel, ComboControlTemplate>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DateTimeControlTemplateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DateTimeControlTemplate>();
            // Act
            var cardModel = mapper.Map<DateTimeControlTemplate, DateTimeControlTemplateModel>(cardDto);
            var cardNewDto = mapper.Map<DateTimeControlTemplateModel, DateTimeControlTemplate>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void TableControlTemplateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<TableControlTemplate>();
            // Act
            var cardModel = mapper.Map<TableControlTemplate, TableControlTemplateModel>(cardDto);
            var cardNewDto = mapper.Map<TableControlTemplateModel, TableControlTemplate>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ColumnsSetMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ColumnsSet>();
            // Act
            var cardModel = mapper.Map<ColumnsSet, ColumnsSetModel>(cardDto);
            var cardNewDto = mapper.Map<ColumnsSetModel, ColumnsSet>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ColumnInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ColumnInfo>();
            // Act
            var cardModel = mapper.Map<ColumnInfo, ColumnInfoModel>(cardDto);
            var cardNewDto = mapper.Map<ColumnInfoModel, ColumnInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DataSetMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DataSet>();
            // Act
            var cardModel = mapper.Map<DataSet, DataSetModel>(cardDto);
            var cardNewDto = mapper.Map<DataSetModel, DataSet>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DataSetItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DataSetItem>();
            // Act
            var cardModel = mapper.Map<DataSetItem, DataSetItemModel>(cardDto);
            var cardNewDto = mapper.Map<DataSetItemModel, DataSetItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void BasicDictionariesMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<BasicDictionaries>();
            // Act
            var cardModel = mapper.Map<BasicDictionaries, BasicDictionariesModel>(cardDto);
            var cardNewDto = mapper.Map<BasicDictionariesModel, BasicDictionaries>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardMessageMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardMessage>();
            // Act
            var cardModel = mapper.Map<CardMessage, CardMessageModelFromGenerated>(cardDto);
            var cardNewDto = mapper.Map<CardMessageModelFromGenerated, CardMessage>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DepartmentMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Department>();
            // Act
            var cardModel = mapper.Map<Department, DepartmentModelFromGenerated>(cardDto);
            var cardNewDto = mapper.Map<DepartmentModelFromGenerated, Department>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void EngineMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Engine>();
            // Act
            var cardModel = mapper.Map<Engine, EngineModel>(cardDto);
            var cardNewDto = mapper.Map<EngineModel, Engine>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Engine03AdditionalInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Engine03AdditionalInfo>();
            // Act
            var cardModel = mapper.Map<Engine03AdditionalInfo, Engine03AdditionalInfoModel>(cardDto);
            var cardNewDto = mapper.Map<Engine03AdditionalInfoModel, Engine03AdditionalInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Tm_DepartmentStatePairMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Tm_DepartmentStatePair>();
            // Act
            var cardModel = mapper.Map<Tm_DepartmentStatePair, DepartmentStatePairModel>(cardDto);
            var cardNewDto = mapper.Map<DepartmentStatePairModel, Tm_DepartmentStatePair>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardDepartmentStateMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardDepartmentState>();
            // Act
            var cardModel = mapper.Map<CardDepartmentState, CardDepartmentStateModel>(cardDto);
            var cardNewDto = mapper.Map<CardDepartmentStateModel, CardDepartmentState>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DepartmentStateHistoryMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DepartmentStateHistory>();
            // Act
            var cardModel = mapper.Map<DepartmentStateHistory, DepartmentStateHistoryModel>(cardDto);
            var cardNewDto = mapper.Map<DepartmentStateHistoryModel, DepartmentStateHistory>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DepartmentInvolvedFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DepartmentInvolvedFilter>();
            // Act
            var cardModel = mapper.Map<DepartmentInvolvedFilter, DepartmentInvolvedFilterModel>(cardDto);
            var cardNewDto = mapper.Map<DepartmentInvolvedFilterModel, DepartmentInvolvedFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DepartmentStateChangedFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DepartmentStateChangedFilter>();
            // Act
            var cardModel = mapper.Map<DepartmentStateChangedFilter, DepartmentStateChangedFilterModel>(cardDto);
            var cardNewDto = mapper.Map<DepartmentStateChangedFilterModel, DepartmentStateChangedFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void RequestedEnginesListChangedFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<RequestedEnginesListChangedFilter>();
            // Act
            var cardModel = mapper.Map<RequestedEnginesListChangedFilter, RequestedEnginesListChangedFilterModel>(cardDto);
            var cardNewDto = mapper.Map<RequestedEnginesListChangedFilterModel, RequestedEnginesListChangedFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardCurrentStatesInDepartmentsChangedFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardCurrentStatesInDepartmentsChangedFilter>();
            // Act
            var cardModel = mapper.Map<CardCurrentStatesInDepartmentsChangedFilter, CardCurrentStatesInDepartmentsChangedFilterModel>(cardDto);
            var cardNewDto = mapper.Map<CardCurrentStatesInDepartmentsChangedFilterModel, CardCurrentStatesInDepartmentsChangedFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardMessageListChangedFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardMessageListChangedFilter>();
            // Act
            var cardModel = mapper.Map<CardMessageListChangedFilter, CardMessageListChangedFilterModel>(cardDto);
            var cardNewDto = mapper.Map<CardMessageListChangedFilterModel, CardMessageListChangedFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void BroadcastMessageFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<BroadcastMessageFilter>();
            // Act
            var cardModel = mapper.Map<BroadcastMessageFilter, BroadcastMessageFilterModel>(cardDto);
            var cardNewDto = mapper.Map<BroadcastMessageFilterModel, BroadcastMessageFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ShiftReportChangedFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<ShiftReportChangedFilter>();
            // Act
            var cardModel = mapper.Map<ShiftReportChangedFilter, ShiftReportChangedFilterModel>(cardDto);
            var cardNewDto = mapper.Map<ShiftReportChangedFilterModel, ShiftReportChangedFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardAdditionalInfoAddedFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardAdditionalInfoAddedFilter>();
            // Act
            var cardModel = mapper.Map<CardAdditionalInfoAddedFilter, CardAdditionalInfoAddedFilterModel>(cardDto);
            var cardNewDto = mapper.Map<CardAdditionalInfoAddedFilterModel, CardAdditionalInfoAddedFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void NotificationFiltersMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<NotificationFilters>();
            // Act
            var cardModel = mapper.Map<NotificationFilters, NotificationFiltersModel>(cardDto);
            var cardNewDto = mapper.Map<NotificationFiltersModel, NotificationFilters>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void UpdatingCoordsFilterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<UpdatingCoordsFilter>();
            // Act
            var cardModel = mapper.Map<UpdatingCoordsFilter, UpdatingCoordsFilterModel>(cardDto);
            var cardNewDto = mapper.Map<UpdatingCoordsFilterModel, UpdatingCoordsFilter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FireBarrelsItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FireBarrelsItem>();
            // Act
            var cardModel = mapper.Map<FireBarrelsItem, FireBarrelsItemModel>(cardDto);
            var cardNewDto = mapper.Map<FireBarrelsItemModel, FireBarrelsItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FireExtinguishersItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FireExtinguishersItem>();
            // Act
            var cardModel = mapper.Map<FireExtinguishersItem, FireExtinguishersItemModel>(cardDto);
            var cardNewDto = mapper.Map<FireExtinguishersItemModel, FireExtinguishersItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FireChiefMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FireChief>();
            // Act
            var cardModel = mapper.Map<FireChief, FireChiefModel>(cardDto);
            var cardNewDto = mapper.Map<FireChiefModel, FireChief>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DrillsChiefMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DrillsChief>();
            // Act
            var cardModel = mapper.Map<DrillsChief, DrillsChiefModel>(cardDto);
            var cardNewDto = mapper.Map<DrillsChiefModel, DrillsChief>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GdzsUnitMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<GdzsUnit>();
            // Act
            var cardModel = mapper.Map<GdzsUnit, GdzsUnitModel>(cardDto);
            var cardNewDto = mapper.Map<GdzsUnitModel, GdzsUnit>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void FireFighterMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<FireFighter>();
            // Act
            var cardModel = mapper.Map<FireFighter, FireFighterModel>(cardDto);
            var cardNewDto = mapper.Map<FireFighterModel, FireFighter>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void SickPersonMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<SickPerson>();
            // Act
            var cardModel = mapper.Map<SickPerson, SickPersonModel>(cardDto);
            var cardNewDto = mapper.Map<SickPersonModel, SickPerson>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void HospitalMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Hospital>();
            // Act
            var cardModel = mapper.Map<Hospital, HospitalModel>(cardDto);
            var cardNewDto = mapper.Map<HospitalModel, Hospital>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void SettingsInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<SettingsInfo>();
            // Act
            var cardModel = mapper.Map<SettingsInfo, SettingsInfoModel>(cardDto);
            var cardNewDto = mapper.Map<SettingsInfoModel, SettingsInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void PcInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<PcInfo>();
            // Act
            var cardModel = mapper.Map<PcInfo, PcInfoModel>(cardDto);
            var cardNewDto = mapper.Map<PcInfoModel, PcInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void VideoQACameraMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<VideoQACamera>();
            // Act
            var cardModel = mapper.Map<VideoQACamera, VideoQACameraModel>(cardDto);
            var cardNewDto = mapper.Map<VideoQACameraModel, VideoQACamera>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void EraGlonassECallLocationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<EraGlonassECallLocation>();
            // Act
            var cardModel = mapper.Map<EraGlonassECallLocation, EraGlonassECallLocationModel>(cardDto);
            var cardNewDto = mapper.Map<EraGlonassECallLocationModel, EraGlonassECallLocation>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void EraGlonassECallIntegrationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<EraGlonassECallIntegration>();
            // Act
            var cardModel = mapper.Map<EraGlonassECallIntegration, EraGlonassECallIntegrationModel>(cardDto);
            var cardNewDto = mapper.Map<EraGlonassECallIntegrationModel, EraGlonassECallIntegration>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void MapAddressMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<MapAddress>();
            // Act
            var cardModel = mapper.Map<MapAddress, MapAddressModel>(cardDto);
            var cardNewDto = mapper.Map<MapAddressModel, MapAddress>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GeoPointMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<GeoPoint>();
            // Act
            var cardModel = mapper.Map<GeoPoint, GeoPointModelFromGenerated>(cardDto);
            var cardNewDto = mapper.Map<GeoPointModelFromGenerated, GeoPoint>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GeoAreaMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<GeoArea>();
            // Act
            var cardModel = mapper.Map<GeoArea, GeoAreaModelFromGenerated>(cardDto);
            var cardNewDto = mapper.Map<GeoAreaModelFromGenerated, GeoArea>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CardMarkerInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CardMarkerInfo>();
            // Act
            var cardModel = mapper.Map<CardMarkerInfo, CardMarkerInfoModel>(cardDto);
            var cardNewDto = mapper.Map<CardMarkerInfoModel, CardMarkerInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void CallHistoryItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<CallHistoryItem>();
            // Act
            var cardModel = mapper.Map<CallHistoryItem, CallHistoryItemModel>(cardDto);
            var cardNewDto = mapper.Map<CallHistoryItemModel, CallHistoryItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void PhonogramMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Phonogram>();
            // Act
            var cardModel = mapper.Map<Phonogram, PhonogramModel>(cardDto);
            var cardNewDto = mapper.Map<PhonogramModel, Phonogram>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void Card112ListExcelReportParamsMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Card112ListExcelReportParams>();
            // Act
            var cardModel = mapper.Map<Card112ListExcelReportParams, Card112ListExcelReportParamsModel>(cardDto);
            var cardNewDto = mapper.Map<Card112ListExcelReportParamsModel, Card112ListExcelReportParams>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void ColumnMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Column>();
            // Act
            var cardModel = mapper.Map<Column, ColumnModel>(cardDto);
            var cardNewDto = mapper.Map<ColumnModel, Column>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void IntMapItemMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<IntMapItem>();
            // Act
            var cardModel = mapper.Map<IntMapItem, IntMapItemModel>(cardDto);
            var cardNewDto = mapper.Map<IntMapItemModel, IntMapItem>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GisServiceGeoObjectMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<GisServiceGeoObject>();
            // Act
            var cardModel = mapper.Map<GisServiceGeoObject, GisServiceGeoObjectModel>(cardDto);
            var cardNewDto = mapper.Map<GisServiceGeoObjectModel, GisServiceGeoObject>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GisServiceGeoObjectFieldMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<GisServiceGeoObjectField>();
            // Act
            var cardModel = mapper.Map<GisServiceGeoObjectField, GisServiceGeoObjectFieldModel>(cardDto);
            var cardNewDto = mapper.Map<GisServiceGeoObjectFieldModel, GisServiceGeoObjectField>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GisServiceLayerMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();

            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var cardDto = fixture.Create<GisServiceLayer>();
            // Act
            var cardModel = mapper.Map<GisServiceLayer, GisServiceLayerModel>(cardDto);
            var cardNewDto = mapper.Map<GisServiceLayerModel, GisServiceLayer>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GeometryMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Geometry>();
            // Act
            var cardModel = mapper.Map<Geometry, GeometryModel>(cardDto);
            var cardNewDto = mapper.Map<GeometryModel, Geometry>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void LocationMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<Location>();
            // Act
            var cardModel = mapper.Map<Location, LocationModel>(cardDto);
            var cardNewDto = mapper.Map<LocationModel, Location>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DistanceInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DistanceInfo>();
            // Act
            var cardModel = mapper.Map<DistanceInfo, DistanceInfoModel>(cardDto);
            var cardNewDto = mapper.Map<DistanceInfoModel, DistanceInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void DistanceOnRouteInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<DistanceOnRouteInfo>();
            // Act
            var cardModel = mapper.Map<DistanceOnRouteInfo, DistanceOnRouteInfoModel>(cardDto);
            var cardNewDto = mapper.Map<DistanceOnRouteInfoModel, DistanceOnRouteInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void LayersInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();

            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var cardDto = fixture.Create<LayersInfo>();
            // Act
            var cardModel = mapper.Map<LayersInfo, LayersInfoModel>(cardDto);
            var cardNewDto = mapper.Map<LayersInfoModel, LayersInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void GeoObjectsInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();
            var cardDto = fixture.Create<GeoObjectsInfo>();
            // Act
            var cardModel = mapper.Map<GeoObjectsInfo, GeoObjectsInfoModel>(cardDto);
            var cardNewDto = mapper.Map<GeoObjectsInfoModel, GeoObjectsInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }

        [Fact]
        public void SearchInfoMappingTest()
        {
            // Arrange
            var mapper = MapperFabric.CreateMapper();
            var fixture = new Fixture();

            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            var cardDto = fixture.Create<SearchInfo>();
            // Act
            var cardModel = mapper.Map<SearchInfo, SearchInfoModel>(cardDto);
            var cardNewDto = mapper.Map<SearchInfoModel, SearchInfo>(cardModel);
            // Assert
            Assert.Equal(cardDto, cardNewDto);
        }


    }
}