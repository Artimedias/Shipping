using System.Collections;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace Shipping.Models
{
    public class ShippingVarible
    {
        
        public string Distributor { get; set; }
        public string Description { get; set; }

        public string Time;
        public string Goods;

        public string OrderNumber { get; set; }

        public string Date
        {
            get
        {
                Console.WriteLine(Time);
                return Time;
            }
        set
            {
                Time = value;

                 Time = Regex.Replace(Time, @"-", "");

                int NewTime = int.Parse(Time);

                NewTime += 5;
                Time = NewTime.ToString();
                
            }
        }
        public string Order
        {
            get
            {
                return Goods;
            }
            set
            {
                Goods += (" , " + value);
            }
        }
    }
}