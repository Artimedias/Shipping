using System.Collections;
using System.Collections.Generic;
using System;

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

                Console.WriteLine(Time);
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