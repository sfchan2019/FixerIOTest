using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FixerIOTest.Fixer_Latest_Rates_Service.Data_Handling
{
    public class FixerLatestDTO
    {
        public LatestRatesRoot latestRatesRoot { get; set; }
        public void DeserializeLatestRates(string latestRatesResponse)
        {
            latestRatesRoot = JsonConvert.DeserializeObject<LatestRatesRoot>(latestRatesResponse);
        }
    }
}
