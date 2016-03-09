using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Tools
    {
        public static int VerifyNumber()
        {
            int number;
            string userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out number))
            {
                Console.WriteLine("Invalid: Input a valid number");
                userInput = Console.ReadLine();
            }
            return number;
        }

        public static void ClearConsole()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static List<Inventory> GetTempInventoryList()
        {
            List<Inventory> temp = FileReader.ReadInventoryFile(@"../../Inventory.txt");
            return temp;
        }
    }
}
