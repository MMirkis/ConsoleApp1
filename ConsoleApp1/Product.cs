using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Product
    {

        protected string Name {  get; set; }

        protected abstract double Price { get; }
        

        public abstract string GetInformation();

    }
}
