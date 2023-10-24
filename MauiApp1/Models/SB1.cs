using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MauiApp1.Models
{
    public class SB1
    {
        [JsonProperty("B1_COD")]
        public string CODPROD { get; set; }

        [JsonProperty("B1_DESC")]
        public string DESCPROD { get; set;}

        [JsonProperty("B1_UM")]
        public string UN { get; set;}

        [JsonProperty("B1_TIPO")]
        public string TIPO { get; set; }

        [JsonProperty("MOT")]
        public List<MOTIVOSAD> MOT { get; set; }
    }


    public class MOTIVOSAD
    {
        public string COD { get; set; }
        public string DESC { get; set; }

    }
}
