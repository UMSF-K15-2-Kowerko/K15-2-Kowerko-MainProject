using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant7_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.1. Базовi елементи мови С#. Варiант 7");

            Console.WriteLine("\nЗавдання 1. Введiть данi: ");
            Console.Write("Hомiнал купюри - ");
            int denominationBanknotes = int.Parse(Console.ReadLine());
            Console.Write("Kiлькiсть купюр - ");
            int numberOfBills = int.Parse(Console.ReadLine());
            int sum = denominationBanknotes * numberOfBills;
            Console.WriteLine("Сума - " + sum + " грн.");

            Console.Write("\nЗавдання 2. Введiть об'єм куба  - ");
            double volumeOfCube  = double.Parse(Console.ReadLine());
            double edgeOfCube = Math.Pow(volumeOfCube, 1.0/3.0);
            Console.WriteLine("a= {0:F3}", edgeOfCube);

            Console.Write("\nЗавдання 3. Введiть тризначне число  - ");
            int number = int.Parse(Console.ReadLine()),
                hundredsDigit = number / 100, 
                unitsDigit = number % 10;
            if (hundredsDigit < unitsDigit)
                Console.WriteLine("Кiлькiсть одиниць бiльше за кiлькiсть сотень!");
            else if (hundredsDigit > unitsDigit)
                Console.WriteLine("Кiлькiсть одиниць менше за кiлькiсть сотень!");
            else
                Console.WriteLine("Кiлькостi одиниць та сотень спiвпадають!");

            Console.ReadKey();
        }
    }
}
