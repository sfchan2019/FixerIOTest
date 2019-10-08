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
        private JObject results;
        public FixerLatestRateTest()
        {
            //results = fixerLatestRatesService.Result;
        }

        [Test]
        public void SuccessfulRequestTest()
        {
            //Assert.AreEqual("true", result["success"].toString());
        }

        [Test]
        public void GPBValueTest()
        {

        }

        [Test]
        public void TotalRateTest()
        {

        }

        [Test]
        public void BaseTest()
        {

        }
    }
}
