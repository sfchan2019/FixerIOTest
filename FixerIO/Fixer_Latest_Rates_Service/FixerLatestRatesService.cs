using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace FixerIOTest.Fixer_Latest_Rates_Service
{
    public class FixerLatestRatesService
    {
        public JObject Result { get; set; }
        //we need DTO (Data Transfer Object)
        //we need a call manager
        //JObject
        public FixerLatestRatesService()
        {

        }
    }
}
