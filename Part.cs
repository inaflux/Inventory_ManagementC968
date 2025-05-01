using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_ManagementC968
{
    public abstract class Part
    {
        // decalaring the variables within the Parts clas
        private int partID;
        private string name;
        private decimal price;
        private int inventory;
        private int min;
        private int max;


        // allowing other classes to modify the data stored inside these variables
        public int PartID { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Inventory { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        //Creates a constructor for the class
        public Part(int partID, string name, decimal price, int inventory, int min, int max)
        {
            PartID = partID;
            Name = name.ToString();
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
        }
         


    }
}
