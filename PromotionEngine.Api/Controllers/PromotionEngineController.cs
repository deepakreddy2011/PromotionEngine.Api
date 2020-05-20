using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromotionEngine.Core;
using PromotionEngine.Core.Interfaces;

namespace PromotionEngine.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class PromotionEngineController : ControllerBase
    {
        private IPromotionEngineHandler promotionEngineHandler;

        public PromotionEngineController(IPromotionEngineHandler promotionEngineHandler) 
        {
            this.promotionEngineHandler = promotionEngineHandler;
        }

        [HttpPost]
        public decimal CalculateTotalPrice(List<Item> items) 
        {
            var totalPrice = this.promotionEngineHandler.CalculateTotalPrice(items);
            return totalPrice;
        }
    }
}