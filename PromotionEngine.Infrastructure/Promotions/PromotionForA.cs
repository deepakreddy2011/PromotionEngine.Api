using PromotionEngine.Core;
using PromotionEngine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Infrastructure.Promotions
{
    public class PromotionForA : IPromotion
    {
        public int Apply(List<Item> items)
        {
            var itemACount = items.Where(x => x.Id == "A").Select(x => x.Quantity).Sum();
            var remainder = itemACount % 3;
            var quotient = itemACount / 3;
            var price = quotient * 130 + remainder * 50;
            return price;
        }
    }
}
