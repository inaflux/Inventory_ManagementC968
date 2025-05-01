using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Inventory_ManagementC968
{
     class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static  BindingList<Part> AllParts = new BindingList<Part>();





        //generates a new partId everytime  a part is added
        public static  int GeneratePartID ()
        {
            int highestPartID = 0;

            foreach (Part part in AllParts)
            {
                if(part.PartID > highestPartID)
                {
                    highestPartID  = part.PartID;
                }
            }

            return highestPartID + 1;
        }

        //generates a new productId everytime  a part is added
        public static int GenerateProdID()
        {
            int highestProdID = 0;

            foreach (Product product in Products)
            {
                if (product.ProductID > highestProdID)
                {
                     highestProdID = product.ProductID;
                }
            }

            return highestProdID + 1;
        }



        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct (int productID)
        {
            //we have to get the product somehow
            //we have to match the product that we want to delete with a product that is in the list Products
            //the product we want to delete will be in a datagridview which is bound to a list <product>
            //the only unique identifier the products have is the ProdID
            //so if the prodIDs equal eachother then we have a match!
            //We then can pass that matching productID as an argument throught the parameter
            // we could use a for or foreach loop to loop through the <Product> list
            //once the Product product.prodID == productId of the removeProduct Method
            //we want to return that prodID

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products.RemoveAt(i);
                }

                return true;
            }

            return false;
        }

        public static Product LookUpProduct (int productID)
        {
            
            foreach (Product product in Products)
            {
                if ( product.ProductID == productID) 
                {
                    return product;
                }
            }

            return null;
        }

        public static void UpdateProduct(int productID, Product product)
        {
            RemoveProduct(productID);
            AddProduct(product);
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static  bool DeletePart(int partID)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts.RemoveAt(i);
                    return true;
                }

                
            }

            return false;
        }

        public static Part LookUpPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if(part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void UpdatePart(int partID, Part updatedPart)
        {


            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = updatedPart;
                    return;
                }
            }
        }

        //Example Inputs
        public static void GetExampleInputs()
        {
            InHouse examplePart1 = new InHouse(3, "Chain", 44.33m, 5, 1, 30, 2);
            AllParts.Add(examplePart1);

            Outsourced examplePart2 = new Outsourced(7, "Wheel", 59.42m, 8, 1, 30, "Element");
            AllParts.Add(examplePart2);

            Product exampleProd1 = new Product(4, "Bike", 90.57m, 14, 1, 30 );
            Products.Add(exampleProd1);
            Product exampleProd2 = new Product(5, "Car", 3379.57m, 15, 1, 30);
            Products.Add(exampleProd2);
        }
    }


  


}
