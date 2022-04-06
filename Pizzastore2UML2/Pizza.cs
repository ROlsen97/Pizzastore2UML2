using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzastore2UML2
{
    public class Pizza
    {
        int _number;
        string _name;
        double _price;

        public Pizza()
        {
            _number = 0;
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set {_price = value;}
        }

        public override string ToString()
        {
            return $"Pizza name is : {Name}, Pizza price is : {Price}, Pizza number is : {Number}";
        }
    }
}
