using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Product
    {
        public Product(int no,string name,double price)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
        }
        public int No;
        public string Name;
        public int Count;
        public double Price;

        public virtual string GetInfo()
        {
            return $"No : {this.No}  - Name:{this.Name}";
        }
    }
}
