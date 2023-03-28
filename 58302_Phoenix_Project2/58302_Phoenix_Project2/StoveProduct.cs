using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58302_Phoenix_Project2
{
    class StoveProduct : Product
    {
        private string NUMOFHEATERS;
        private Boolean OVEN;
        private Boolean GAS;

        

        public StoveProduct(string numOfHeaters, Boolean oven, Boolean gas)
        {

            NUMOFHEATERS = numOfHeaters;
            OVEN = oven;
            GAS = gas;
        }
        public string NumOfHeaters
        {
            get { return NUMOFHEATERS; }
            set { NUMOFHEATERS = value; }
        }
        public Boolean Oven
        { 
            get { return OVEN; }
            set { OVEN = value; }

        }
        public Boolean Gas
        {
            get { return GAS; }
            set { GAS = value; }
        }
        
        //string type, string id, string model, string brand, string price,
    }
}
