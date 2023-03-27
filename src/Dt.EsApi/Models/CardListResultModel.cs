using System;
using System.Collections.Generic;
using ServerLogic.Types;

#nullable enable
namespace Dt.EsApi.Models
{
    public class CardListResultModel
    {
        public CardListResultModel()
        {
            CardList = new();
            Total = 0;
        }

        public CardListResultModel(List<EmergencyCard> cardList, int total)
        {
            CardList = cardList ?? throw new ArgumentNullException(nameof(cardList));
            Total = total;
        }

        public List<EmergencyCard> CardList { get; }

        public int Total { get; }
    }
}
