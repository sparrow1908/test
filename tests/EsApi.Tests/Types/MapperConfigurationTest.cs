using AutoFixture;
using Dt.EsApi.Mapper;
using Dt.EsApi.Models;
using ServerLogic.Types;
using Xunit;

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
    }
}