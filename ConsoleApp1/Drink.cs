using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Drink : Product
    {
        protected override double Price => 150.0;

        private double Volume {  get; set; }
        public Drink(string name, double volume)
        {
            Name = name;
            Volume=volume;

        }
        public override string GetInformation()
        {
            return $"Drink: {Name}, Volume: {Volume} L, Price: {Price * 0.8}";
        }
    }
}
