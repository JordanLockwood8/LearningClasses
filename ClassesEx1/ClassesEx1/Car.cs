using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEx1
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public string Year { get; set; }

        public void Print()
        {

            Console.WriteLine($"{Make} | {Model} | {Year}");
        }
    }
}
