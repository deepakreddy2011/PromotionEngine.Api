using Moq;
using NUnit.Framework;
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
        public void TestToGetTotalPrice()
        {
            this.mockPromotionEngineHandler.Setup(x => x.CalculateTotalPrice(new List<Item> { }));
        }

    }
}
