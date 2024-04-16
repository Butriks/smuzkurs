using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace smkurs
{
    internal class Customers
    {
        private class order {
            public int price;
            public DateTime date;
            public Device device;
        }

        static public int id;
        static private string name;
        static private float salary;

        private static List<order> listoforders = new List<order>();

        public float GetSalary() {
            float totalCost = 0;

            foreach (var order in listoforders)
            {
                totalCost += order.device.cost;
            }

            return totalCost;
        }
    }
}
