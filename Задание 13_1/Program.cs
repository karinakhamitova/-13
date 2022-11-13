using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Задание_13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("aaaa", 2000, 3000, 25);
            MultiBuilding muilding = new MultiBuilding("dddd", 2000, 3000, 25, 5);
            Console.WriteLine(muilding.Print());
            Console.WriteLine(building.Print()); 
            Console.ReadKey();
        }
    }
}
