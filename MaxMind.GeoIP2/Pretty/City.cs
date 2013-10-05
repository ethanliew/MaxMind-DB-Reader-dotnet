﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MaxMind.GeoIP2
{
    public class City
    {
        [JsonProperty("geoname_id")]
        public int GeonameID { get; set; }

        [JsonProperty("names")]
        public Hashtable Name { get; set; }
    }
}
