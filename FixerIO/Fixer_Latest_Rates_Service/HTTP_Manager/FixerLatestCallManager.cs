using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Configuration;

namespace FixerIOTest.Fixer_Latest_Rates_Service.HTTP_Manager
{
    public class FixerLatestCallManager
    {
        readonly IRestClient client;
        public FixerLatestCallManager()
        {
            client = new RestClient();
        }
    }
}
