using PromotionEngine.Core;
using PromotionEngine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Infrastructure.Promotions
{
    public class PromotionForB : IPromotion
    {
        public int Apply(List<Item> items)
        {
            var itemACount = items.Where(x => x.Id == "B").Select(x => x.Quantity).Sum();
            var remainder = itemACount % 2;
            var quotient = itemACount / 2;
            var price = quotient * 45 + remainder * 30;
            return price;
        }
    }
}
