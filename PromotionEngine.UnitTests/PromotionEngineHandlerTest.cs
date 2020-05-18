using NUnit.Framework;
using PromotionEngine.Core;
using PromotionEngine.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.UnitTests
{
    [TestFixture]
    public class PromotionEngineHandlerTest
    {
        [TestCase]
        public void TestCalculateTotalPriceScenario1()
        {
            var inputItemList = new List<Item>();
            inputItemList.Add(new Item { Id = "A", Quantity = 1 });
            inputItemList.Add(new Item { Id = "B", Quantity = 1 });
            inputItemList.Add(new Item { Id = "C", Quantity = 1 });

            var handler = new PromotionEngineHandler();
            var price = handler.CalculateTotalPrice(inputItemList);

            Assert.AreEqual(price, 100);
        }

        [TestCase]
        public void TestCalculateTotalPriceScenario2()
        {
            var inputItemList = new List<Item>();
            inputItemList.Add(new Item { Id = "A", Quantity = 5 });
            inputItemList.Add(new Item { Id = "B", Quantity = 5 });
            inputItemList.Add(new Item { Id = "C", Quantity = 1 });


            var handler = new PromotionEngineHandler();
            var price = handler.CalculateTotalPrice(inputItemList);

            Assert.AreEqual(price, 370);
        }

        [TestCase]
        public void TestCalculateTotalPriceScenario3()
        {
            var inputItemList = new List<Item>();
            inputItemList.Add(new Item { Id = "A", Quantity = 3 });
            inputItemList.Add(new Item { Id = "B", Quantity = 5 });
            inputItemList.Add(new Item { Id = "C", Quantity = 1 });
            inputItemList.Add(new Item { Id = "D", Quantity = 1 });

            var handler = new PromotionEngineHandler();
            var price = handler.CalculateTotalPrice(inputItemList);

            Assert.AreEqual(price, 280);
        }
    }
}
