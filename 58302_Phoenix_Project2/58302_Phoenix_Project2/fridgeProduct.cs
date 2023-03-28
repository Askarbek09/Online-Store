using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58302_Phoenix_Project2
{
    class fridgeProduct : Product
    {
        string CAPACITY;
        string ELECTRICITY;
        string NOISE;
        public fridgeProduct(string type, string id, string model, string brand, string price, string capacity, string electricity, string noise)
        {
            type = Type;
            id = Id;
            model = Model;
            brand = Brand;
            price = Price;
            capacity = CAPACITY;
            electricity = ELECTRICITY;
            noise = NOISE;
        }
    }
}
