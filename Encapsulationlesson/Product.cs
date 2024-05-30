using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulationlesson
{
     class Product
    {
        private string _name;
        public Double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, double price, int quantity) : this(name, price)
        {

            Quantity = quantity;
        }
        public Product(string name, Double price) : this()
        {
            _name = name;
            Price = price;

        }
        public Product()
        {
            Quantity = 10;
        }
        public string Name
        {
            get { return _name; }
            set {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
            
        }
        /*public Double Price
        {
            get { return _price; }
        }
        public int Quantity
        {
            get { return _quantity; }
        }*/
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
            
        }
        /*public Double GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }*/

        public Double TotalValueStock()
        {
            return Price * Quantity;
        }
        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }
        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return _name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity + " unidades, Total value: $" + TotalValueStock();
        }
    }
}
