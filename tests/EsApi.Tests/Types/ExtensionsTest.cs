using System.Reflection;
using AutoFixture;
using ServerLogic.Types;
using Xunit;

namespace ServerLogic.Tests.Types
{
    public class ExtensionsTest
    {
        private readonly IFixture _builder;

        public ExtensionsTest()
        {
            _builder = new Fixture();
        }

        [Fact]
        public void NullPropertiesMeansEqualForIsMappingTo()
        {
            var cardConditionFirst = _builder.Build<CardCondition>()
                                             .With(x => x.IsIncident, true)
                                             .Without(x => x.IsComplex)
                                             .Without(x => x.IsPriority)
                                             .Without(x => x.IsTest)
                                             .Without(x => x.IsControl)
                                             .Create();

            var cardConditionSecond = _builder.Build<CardCondition>()
                                              .With(x => x.IsIncident, true)
                                              .Create();

            Assert.True(cardConditionFirst.IsMappingTo(cardConditionSecond));
        }

        [Fact]
        public void EqualsCardConditionsMappingAndNotEqualAreNot()
        {
            var cardConditionFirst = _builder.Create<CardCondition>();

            var cardConditionSecond = _builder.Create<CardCondition>();

            if (cardConditionFirst.Equals(cardConditionSecond))
            {
                Assert.True(cardConditionFirst.IsMappingTo(cardConditionSecond));
            }
            else
            {
                Assert.False(cardConditionFirst.IsMappingTo(cardConditionSecond));
            }
        }

        [Fact]
        public void CountConditionsUsesAllPublicInstanceFields()
        {
            var cardConditionFirst = _builder.Create<CardCondition>();

            var publicInstanceFieldsCount = cardConditionFirst.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance).Length;

            Assert.Equal(publicInstanceFieldsCount, cardConditionFirst.CountConditions());
        }
    }
}