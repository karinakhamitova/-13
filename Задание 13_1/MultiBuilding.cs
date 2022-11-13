using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13_1
{
    sealed class MultiBuilding : Building

    {
        int floor;
        public MultiBuilding(string address, double lenght, double width, double height, int floor)
        : base(address, lenght, width, height)
        {
            this.floor = floor;
        }
        public string Print()
        {
            string result = base.Print();
            return result + $" {floor}";
        }
    }
}
