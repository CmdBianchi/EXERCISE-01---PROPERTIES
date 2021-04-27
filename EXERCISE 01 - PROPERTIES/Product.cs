using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___PROPERTIES {
    //------------------------------- START -------------------------------//
    class Product {
        private string _name;
        private double _price;
        private int _amount;
        public Product() {
        }
        public Product(string name, double price, int amount) {
            _name = name;
            _price = price;
            _amount = amount;
        }
        public string Name {
            get { return _name; }
            set { if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }       
        public double Price {
            get { return _price; }
        }
        public int Amount {
            get { return _amount; }
        }
        
        public double AmountValueStock() {
            return _price * _amount;
        }
        public void AddProducts(int quantidade) {
            _amount += quantidade;
        }
        public void RemoveProducts(int quantidade) {
            _amount -= quantidade;
        }
        public override string ToString() {
            return _name
            + ", $ " + _price.ToString("F2") + ", " + _amount + " unidades, Total: $ " + AmountValueStock().ToString("F2");
        }
    }
    //-------------------------------- END -------------------------------// 
}