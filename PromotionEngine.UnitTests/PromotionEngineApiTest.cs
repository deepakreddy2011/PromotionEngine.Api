using Moq;
using NUnit.Framework;
using PromotionEngine.Api.Controllers;
using PromotionEngine.Core;
using PromotionEngine.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.UnitTests
{
    [TestFixture]
    public class PromotionEngineApiTest
    {
        private Mock<IPromotionEngineHandler> mockPromotionEngineHandler;

        [SetUp]
        public void SetUp()
        {
            this.mockPromotionEngineHandler = new Mock<IPromotionEngineHandler>();
        }

        [TestCase]
        public void TestCalculateTotalPriceScenario1()
        {
            var inputItemList = new List<Item>();
            inputItemList.Add(new Item {Id = "A",Quantity = 1 });
            inputItemList.Add(new Item {Id = "B",Quantity = 1 });
            inputItemList.Add(new Item {Id = "C",Quantity = 1 });
            this.mockPromotionEngineHandler.Setup(x => x.CalculateTotalPrice(It.IsAny<List<Item>>())).Returns(100);

            var apiController = new PromotionEngineController(this.mockPromotionEngineHandler.Object);
            var price = apiController.CalculateTotalPrice(inputItemList);

            Assert.AreEqual(price, 100);
        }

        [TestCase]
        public void TestCalculateTotalPriceScenario2()
        {
            var inputItemList = new List<Item>();
            inputItemList.Add(new Item { Id = "A", Quantity = 5 });
            inputItemList.Add(new Item { Id = "B", Quantity = 5 });
            inputItemList.Add(new Item { Id = "C", Quantity = 1 });
            this.mockPromotionEngineHandler.Setup(x => x.CalculateTotalPrice(It.IsAny<List<Item>>())).Returns(370);

            var apiController = new PromotionEngineController(this.mockPromotionEngineHandler.Object);
            var price = apiController.CalculateTotalPrice(inputItemList);

            Assert.AreEqual(price, 100);
        }

        [TestCase]
        public void TestCalculateTotalPriceScenario3()
        {
            var inputItemList = new List<Item>();
            inputItemList.Add(new Item { Id = "A", Quantity = 3 });
            inputItemList.Add(new Item { Id = "B", Quantity = 5 });
            inputItemList.Add(new Item { Id = "C", Quantity = 1 });
            inputItemList.Add(new Item { Id = "D", Quantity = 1 });
            this.mockPromotionEngineHandler.Setup(x => x.CalculateTotalPrice(It.IsAny<List<Item>>())).Returns(280);

            var apiController = new PromotionEngineController(this.mockPromotionEngineHandler.Object);
            var price = apiController.CalculateTotalPrice(inputItemList);

            Assert.AreEqual(price, 100);
        }
    }
}
