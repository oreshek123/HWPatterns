using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тип мебели: современный - 1 или викторианский - 2");
            int.TryParse(Console.ReadLine(),out int clientChoice);
            IFurnitureFactory factory = null;
            if (clientChoice == 1)
            {
                factory = new ModernFurnitureFactory();
            }
            else if (clientChoice == 2)
            {
                factory = new VictorianFurnitureFactory();
            }
            else
            {
                Console.WriteLine("Please enter the correct type of furniture");
            }

            Client client = new Client(factory);

            client.CreateFurniture();

            client.SitDown();
            client.LieDown();

            Console.ReadLine();
        }
    }
}
