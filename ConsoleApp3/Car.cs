using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car
    {
        private String type { get; set; }
        private int numTires { get; set; }
        private int year { get; set; }
        private Boolean runs { get; set; }

        public Car() { }

        public Car(String type, int numTires, int year, bool runs)
        {
            this.type = type;
            this.numTires = numTires;
            this.year = year;
            this.runs = runs;
        }

        

        public string printInfo()
        {
            String info, engine;
            if (this.runs)
            {
                engine = "runing";
            }
            else
            {
                engine = "off";
            }
            info = "Type of car: " + this.type + " number of tires: " + this.numTires.ToString() + " made in: " + this.year.ToString() + " engine " + engine;

            Console.WriteLine(info);

            return info;
        }
    }
}
