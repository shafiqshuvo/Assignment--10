using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    public class Vehicle
    {
        private string name;
        private string regNo;

        List<double> speeds = new List<double>();

        public string GetName { set; get;   }
        public string GetRegNo { set; get; }
        public double GetSpeed { set; get; }

        public void AddSpeedToList()
        {
            speeds.Add(GetSpeed);
        }

        public double MaxSpeed()
        {
            return speeds.Max();
        }

        public double MinSpeed()
        {
            
                return speeds.Min();
         
        }

        public double AverageSpeed()
        {
            return speeds.Average();
        }

    }
}
