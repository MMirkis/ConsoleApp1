using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Toy : Product
    {
        private string Material { get; set; }

        protected override double Price => 20.0;

      

        public Toy(string name, string material)
        {
            Name = name;
            Material = material;
         
        }
        public override string GetInformation()
        {
            return $"Toy: {Name}, Material: {Material}, Price: {Price * 0.9}";
        }
    }
}
