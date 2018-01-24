using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //listas
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            List<string> food = new List<string>();
            food.Add("apple");
            food.Add("banana");

            List<string> vegetables = new List<string>();
            vegetables.Add("tomato");
            vegetables.Add("carrot");

            //concatenar listas
            food.AddRange(vegetables);

            //dictionaries
            Dictionary<String, String> apple = new Dictionary<string, string>();
            apple.Add("Apple", "Fuji");
            apple.Add("Apple1", "Golden");
            apple.Add("Apple2", "Pink lady");

            Dictionary<String, int> oranges = new Dictionary<string, int>();
            oranges.Add("orange", 1);
            oranges.Add("orange1", 2);
            oranges.Add("orange2", 3);
            oranges.Add("orange3", 4);
            oranges.Add("orange4", 5);

            Dictionary<String, String> banana = new Dictionary<string, string>();
            banana.Add("banana", "canario");
            banana.Add("banana1", "no canario");

            //strings
            String firstName, lastName, age, sentence;
            firstName = "John";
            lastName = "Doe";
            age = "27";
            sentence = firstName + " " + lastName + " is " + age + " years old.";

            //loop for
            int X;
            Console.WriteLine("For: ");
            for (X = 0 ;X < 6;X++)
            {
                Console.WriteLine(X);
            }

            //while loop
            Console.WriteLine("While: ");
            X = 0;
            while (X < 6)
            {
                Console.WriteLine(X);
                X++;
            }

            //methods
            int a = 10, b = 20, result;

            result = DivideTheNumbers(a, b);
            Console.WriteLine("result: " + result);

            //classes

            Car car = new Car("car", 4, 2000, true);
            car.printInfo();

            Car coldCar = new Car("car", 4, 1980, true);
            coldCar.printInfo();

            String opcion = "";
            while(opcion != "out")
            {
                Console.WriteLine("To close the console write out.");
                try
                {
                    opcion = Console.ReadLine();
                }
                catch
                {

                }
                
            }
        }
        //ksuGDFÑUASGFAUGF
        public static int DivideTheNumbers(int a, int b)
        {
            return b / a;
        }
    }
}
