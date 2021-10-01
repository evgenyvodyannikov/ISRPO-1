using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Payment
    {

        public string Name { get; set; }
        public string Category { get; set; }
        public string Destination { get; set; }
        public int Count { get; set; }
        public double Cost { get; set; }
        public string Date { get; set; }


        public Payment(string name, string category, string destination, int count, double cost, string date)
        {
            Name = name;
            Category = category;
            Destination = destination;
            Count = count;
            Cost = cost;
            Date = date;
        }
    }
}
