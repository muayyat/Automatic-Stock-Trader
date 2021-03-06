﻿using System.Collections.Generic;
using System.Linq;

namespace AutomaticStockTrader.Core.Configuration
{
    public class StockConfig
    {
        public string Stock_List_Raw { get; set; }
        public IList<string> Stock_List => Stock_List_Raw?.Split(',')?.Select(x => x.Trim())?.ToList();
    }
}
