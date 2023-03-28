using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58302_Phoenix_Project2
{

    class Product
    {
        public string type,id,model,brand,price;
        

        public Product()
        {

        }
        public Product(string type, string id, string model, string brand, string price)
        {
            this.type =type;
            this.id = id;
            this.model = model;
            this.brand = brand;
            this.price = price;
        }
        
       

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value;  }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
  
}
