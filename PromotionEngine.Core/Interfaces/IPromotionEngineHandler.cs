﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Core.Interfaces
{
    public interface IPromotionEngineHandler
    {
        int CalculateTotalPrice(List<Item> items);
       
    }
}
