using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RestSharp;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using FixerIOTest.Fixer_Latest_Rates_Service;

namespace FixerIOTest.Test
{
    [TestFixture]
    public class FixerLatestRateTest
    {
        private FixerLatestRatesService fixerLatestRatesService = new FixerLatestRatesService();
        public FixerLatestRateTest()
        {
            
        }

        [Test]
        public void SuccessfulRequestTest()
        {
            Assert.AreEqual(true, fixerLatestRatesService.fixerLatestDTO.latestRatesRoot.success);
        }

        [Test]
        public void GPBValueTest()
        {
            Assert.AreEqual(0.897338, fixerLatestRatesService.fixerLatestDTO.latestRatesRoot.rates.GBP);
        }

        [Test]
        public void TotalRateTest()
        {
            Assert.AreEqual(168, fixerLatestRatesService.GetTotalRate());
        }

        [Test]
        public void BaseTest()
        {
            Assert.AreEqual("EUR", fixerLatestRatesService.fixerLatestDTO.latestRatesRoot.@base);
        }
    }
}
