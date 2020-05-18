using PromotionEngine.Core;
using PromotionEngine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Infrastructure.Promotions
{
    public class PromotionForCandD : IPromotion
    {
        public int Apply(List<Item> items)
        {
            var itemCCount = items.Where(x => x.Id == "C").Select(x => x.Quantity).Sum();
            var itemDCount = items.Where(x => x.Id == "D").Select(x => x.Quantity).Sum();
            var price = 0;
            var Cremainder = 0;
            var Dremainder = 0;
            if (itemCCount > itemDCount)
            {
                Cremainder = itemCCount - itemDCount;
                price = itemDCount * 30 + Cremainder * 20;
            }

            if (itemCCount < itemDCount)
            {
                Dremainder = itemDCount - itemCCount;
                price = itemCCount * 30 + Dremainder * 15;
            }

            if (itemCCount == itemDCount)
            {
                price = itemCCount * 30;
            }

            return price;
        }
    }
}
