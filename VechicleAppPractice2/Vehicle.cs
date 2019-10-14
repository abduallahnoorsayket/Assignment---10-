using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vehicle
    {
        private string vehicleName;
        private string regNo;

        public double Speed { private get; set; }

        List<double> _speeds = new List<double>();

        //Constructor
        public Vehicle(string vehicleName, string regNo)
        {
            this.vehicleName = vehicleName;
            this.regNo = regNo;

        }

        public void SetSpeed()
        {
            _speeds.Add(this.Speed);
        }
        public double GetMinSpeed()
        {
            double minSpeed = _speeds.Min();
            return minSpeed;
        }
        public double GetMaxSpeed()
        {
            double maxSpeed = _speeds.Max();
            return maxSpeed;
        }
        public double GetAverageSpeed()
        {
            double averageSpeed = _speeds.Average();
            return averageSpeed;
        }
    }
}