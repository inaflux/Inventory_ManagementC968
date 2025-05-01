using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_ManagementC968
{
    public class Product
    {
        private int productID;
        private string name;
        private decimal price;
        private int inventory;
        private int max;
        private int min;
        public BindingList<Part> AssociatedParts = new BindingList<Part>();


        public int ProductID{ get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Inventory { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }


        public Product(int productID, string name, decimal price, int inventory, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            for(int i = 0; i < AssociatedParts.Count; i++) //iterate through the AssociatedParts List
            {
                if (AssociatedParts[i].PartID == partID) // if the partId in the list matches the partID paramater
                {
                    AssociatedParts.RemoveAt(i); //remove that part from the list
                    return true;
                }

                
            }
            return false;
        }
       

        }
    }

