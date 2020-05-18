using Moq;
using NUnit.Framework;
using PromotionEngine.Core;
using PromotionEngine.Infrastructure;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using PromotionEngine.Core.Interfaces;
using PromotionEngine.Infrastructure.Promotions;

namespace PromotionEngine.UnitTests
{
    [TestFixture]
    public class PromotionEngineHandlerTest
    {
        private Mock<IServiceProvider> mockServiceProvider;

        [SetUp]
        public void SetUp()
        {
            this.mockServiceProvider = new Mock<IServiceProvider>();
        }

        [TestCase]
        public void TestCalculateTotalPriceScenario1()
        {
            var inputItemList = new List<Item>();
            inputItemList.Add(new Item { Id = "A", Quantity = 1 });
            inputItemList.Add(new Item { Id = "B", Quantity = 1 });
            inputItemList.Add(new Item { Id = "C", Quantity = 1 });


            var services = new ServiceCollection();
            services.AddTransient<IPromotion, PromotionForA>();
            services.AddTransient<IPromotion, PromotionForB>();
            services.AddTransient<IPromotion, PromotionForCandD>();
            var serviceProvider = services.BuildServiceProvider();


            var handler = new PromotionEngineHandler(serviceProvider);
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


            var services = new ServiceCollection();
            services.AddTransient<IPromotion, PromotionForA>();
            services.AddTransient<IPromotion, PromotionForB>();
            services.AddTransient<IPromotion, PromotionForCandD>();
            var serviceProvider = services.BuildServiceProvider();


            var handler = new PromotionEngineHandler(serviceProvider);
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


            var services = new ServiceCollection();
            services.AddTransient<IPromotion, PromotionForA>();
            services.AddTransient<IPromotion, PromotionForB>();
            services.AddTransient<IPromotion, PromotionForCandD>();
            var serviceProvider = services.BuildServiceProvider();


            var handler = new PromotionEngineHandler(serviceProvider);
            var price = handler.CalculateTotalPrice(inputItemList);

            Assert.AreEqual(price, 280);
        }
    }
}
