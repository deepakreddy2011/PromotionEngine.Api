using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Core.Interfaces
{
    public interface IPromotion
    {
        int Apply(List<Item> items);
    }
}
