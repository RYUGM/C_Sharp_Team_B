using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap09_02
{
    public class Product : IComparable<Product>
    {
        public String Name { get; set; }    
        public int Price { get; set; }

        public int CompareTo(Product other)
        {
           return Price.CompareTo(other.Price);
            
        }
    }
}
