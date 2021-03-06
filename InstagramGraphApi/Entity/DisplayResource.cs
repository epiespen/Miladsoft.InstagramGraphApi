﻿/*
 * Developer: Milad Raeisi [ miladsoft@yahoo.com ] [ My Telegram Account: https://t.me/miladsoft ]
 * 
 * Github source: https://github.com/miladsoft/InstagramGraphApi
 * Nuget package: https://www.nuget.org/packages/Miladsoft.InstagramGraphApi/
 * 
 */
using Newtonsoft.Json;

namespace InstagramGraphApi.Entity
{
    public class DisplayResource
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("config_width")]
        public int ConfigWidth { get; set; }

        [JsonProperty("config_height")]
        public int ConfigHeight { get; set; }
    }
}
