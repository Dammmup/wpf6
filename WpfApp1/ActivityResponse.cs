using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ActivityResponse
    {
        [JsonProperty("activity")]
        public string Activity{ get; set; }

    }
}
