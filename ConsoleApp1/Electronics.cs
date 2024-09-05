using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Electronics : Product
    {
        protected override double Price => 200.0;

        private string Brand {  get; set; }
        public Electronics(string name, string brand)
        {
            Name = name;
            Brand = brand;

        }
        public override string GetInformation()
        {
            return $"Electronics: {Name}, Brand: {Brand}, Price: {Price}"; ;
        }
    }
}
