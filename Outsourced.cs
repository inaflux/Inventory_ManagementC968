using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_ManagementC968
{
    public class Outsourced : Part
    {
        private string companyName;

        public string CompanyName { get; set; }

        public Outsourced() : base(0, string.Empty, 0, 0, 0, 0) { }

        public Outsourced(int partID, string name, decimal price, int inventory, int min, int max, string companyName)
            : base(partID, name, price, inventory, min, max)
        {
            CompanyName = companyName;
        }
    }
}
