using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Meat:Product
    {
        protected override double Price => 100.0;

        private double Weight {  get; set; }
        public Meat(string name,double weight)
        {
            Name = name;
            Weight = weight;

        }

        public override string GetInformation()
        {
            return $"Meat: {Name}, Weight: {Weight} kg, Price: {Price * 0.85}";
        }
    }
}
