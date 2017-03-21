﻿using System;
using Newtonsoft.Json;
using GoPay.Common;
using Newtonsoft.Json.Converters;

namespace GoPay.Model.Payments
{
    public class Image
    {
        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

    }
}
