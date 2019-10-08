using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Configuration;
using FixerIOTest;

namespace FixerIOTest.Fixer_Latest_Rates_Service.HTTP_Manager
{
    public class FixerLatestCallManager
    {
        readonly IRestClient client;
        public FixerLatestCallManager()
        {
            client = new RestClient(FixerConfig.BaseUrl);
        }

        public string GetLatestRates()
        {
            RestRequest request = new RestRequest("/latest" + FixerConfig.ApiUrlMod + FixerConfig.ApiKey);
            IRestResponse response =  client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
