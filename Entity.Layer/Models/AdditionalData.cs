using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Entity.Layer.Models
{
    public class AdditionalData
    {
        [JsonPropertyName("amazon")]
        public Amazon Amazon { get; set; }

    }
}
