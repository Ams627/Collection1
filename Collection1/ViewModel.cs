using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;

namespace Collection1
{
    public class CashType
    {
        public string Currency { get; set; }
        public int Amount { get; set; }
    }

    public class Stuff
    {
        public string Indentifier { get; set; }
        public CashType CashType { get; set; }
    }
    public class ViewModel
    {
        public Thickness MyMargin { get; set; } = new Thickness(50, 50, 50, 50);

        public List<Stuff> CashEntries { get; set; } = new List<Stuff>();

        public ViewModel()
        {
            CashEntries.Add(new Stuff { Indentifier = "Fred", CashType = new CashType { Currency = "USD", Amount = 201 } });
            CashEntries.Add(new Stuff { Indentifier = "Jim", CashType = new CashType { Currency = "GBP", Amount = 233 } });
        }
    }
}
