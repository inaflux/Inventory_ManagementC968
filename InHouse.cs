using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_ManagementC968
{
    public class InHouse : Part
    {
        private int machineID;

        public int MachineID { get; set; }

        public InHouse() : base(0, string.Empty, 0, 0, 0, 0) { }
        public InHouse(int partID, string name, decimal price, int inventory, int min, int max, int machineID)
            : base(partID, name, price, inventory, min, max)
        {
            MachineID = machineID;
        }
    }
}
