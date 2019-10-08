using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;
using FixerIOTest.Fixer_Latest_Rates_Service.Data_Handling;
using FixerIOTest.Fixer_Latest_Rates_Service.HTTP_Manager;

namespace FixerIOTest.Fixer_Latest_Rates_Service
{
    public class FixerLatestRatesService
    {
        //We need DTO (Data Transfer Object)
        public FixerLatestDTO fixerLatestDTO = new FixerLatestDTO();

        //We need a call manager
        public FixerLatestCallManager fixerLatestCallManager = new FixerLatestCallManager();

        //JObject
        private JObject LatestRatesJson;

        public FixerLatestRatesService()
        {
            fixerLatestDTO.DeserializeLatestRates(fixerLatestCallManager.GetLatestRates());
            //LatestRatesJson = JObject.Parse(fixerLatestCallManager.GetLatestRates());

        }
    }
}
