﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace RestSharpEntity
{
    class Program
    {
        static void Main(string[] args)
        {
           JArray restSharpScrape = RSYahooAPI.YahooApiScrape();
           Console.ReadKey();
            SQLWrite.WriteDB(restSharpScrape);

        }
    }
}
