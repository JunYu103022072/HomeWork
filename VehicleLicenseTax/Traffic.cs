using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLicenseTax
{
    public class Traffic
    {
        public static string Name { get; set; }
        public static string EngineCC { get; set; }
        public static int Tax { get; set; }

        public void GetTrafficData()
        {
            List<Traffic> datalist = new List<Traffic>();
            Traffic aaa = new Traffic();

            datalist.Add(aaa);
        }
    }

}



