using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book:Product
    {
        public Book(int no,string name,double price,string genre):base(no,name,price)
        {
            this.Genre = genre;
        }
        public string Genre;

        public override string GetInfo()
        {
            return $"No : {this.No}  - Name:{this.Name} - Genre: {this.Genre}";
        }
    }
}
