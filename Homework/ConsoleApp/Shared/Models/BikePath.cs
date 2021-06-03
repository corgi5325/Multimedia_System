using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleApp.Models
{
    public class BikePath
    {
       // [JsonProperty("NAME")]
        public string Name { get; set; }

        //[JsonProperty("S_PLACEDES")]
        public string S_PlaceDes { get; set; }

        //[JsonProperty("E_PLACEDES")]
        public string E_PlaceDes { get; set; }

        //[JsonProperty("DESCRIPTION")]
        public string Description { get; set; }

        //[JsonProperty("ADD")]
        public string Add { get; set; }  //地址

        //[JsonProperty(" TEL")]
        public string Tel { get; set; }

        //[JsonProperty("MAP")]
        public string Map { get; set; }   //網址

        //[JsonProperty("KEYWORD")]
        public string Keyword { get; set; }


    }
}
