using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10
{
    public class Items
    {
        private string name;
        private double price;
        private int count;

        public Items()
        {
            this.name = string.Empty;
            this.price = 0;
            this.count = 0;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
       
        public override string ToString() {
            return $"{name} {price}₽ {count}\n";
        }
        

    }
}
