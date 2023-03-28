using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace _58302_Phoenix_Project2
{
    class TVproduct: Product
    {
        string SIZE;
        string RESPONDTIME;
        Boolean SMART;
        public TVproduct(string type, string id, string model, string brand, string price, string size, string respondtime, Boolean smart)
        {
            type = Type;
            id = Id;
            model = Model;
            brand = Brand;
            price = Price;
            size = SIZE;
            respondtime = RESPONDTIME;
            smart = SMART;
        }

        public string getId()
        {
            return Id;
        }
        public string getBrand()
        {
            return Brand;
        }
        public string getModel()
        {
            return Model;

        }
        public string getPrice()
        {
            return Price;
        }
        public string getSize()
        {
            return SIZE;
        }
        public string getRes()
        {
            return RESPONDTIME;
        }
        public Boolean getSmart()
        {
            return SMART;
        }
    }
}
