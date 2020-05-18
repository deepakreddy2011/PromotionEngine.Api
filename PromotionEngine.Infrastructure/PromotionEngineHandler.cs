using PromotionEngine.Core;
using PromotionEngine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace PromotionEngine.Infrastructure
{
    public class PromotionEngineHandler : IPromotionEngineHandler
    {
        private IServiceProvider serviceProvider;

        public PromotionEngineHandler(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public int CalculateTotalPrice(List<Item> inputItemList)
        {
            var services = serviceProvider.GetServices<IPromotion>();
            var totalPrice = 0;
            services.ToList().ForEach(x =>
            {
                totalPrice += x.Apply(inputItemList);
            });

            
            return totalPrice;
        }
    }
}
