using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace smkurs
{
    internal class Client
    {
        static public int id;
        static private string name;
        static private string password;
        static private string contact_information;

        private static List<Device> listOfDevices = new List<Device>();

        public string GetPass() {
            return password;
        }

        public Device GetDevice()
        {
            return listOfDevices.FirstOrDefault();
        }
    }
}
