using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FixerIOTest
{
    public static class FixerConfig
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings.Get("base_url");

    }
}
