using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class UserInput
    {
        public static int SelectSoda()
        {
            Console.WriteLine("Choose soda:\n(1) Grape $0.60\n(2) Orange $0.35\n(3) Meat $0.06\n(4) Cancel");
            int sodaChoice = Tools.VerifyNumber();
            return sodaChoice;
        }
        public static int CollectPennies()
        {
            Console.Write("How many pennies? ");
            int numOfpennies = Tools.VerifyNumber();
            return numOfpennies;
        }

        public static int CollectNickels()
        {
            Console.Write("How many nickels? ");
            int numOfNickels = Tools.VerifyNumber();
            return numOfNickels;
        }

        public static int CollectDimes()
        {
            Console.Write("How many Dimes? ");
            int numOfDimes = Tools.VerifyNumber();
            return numOfDimes;
        }

        public static int CollectQuarters()
        {
            Console.Write("How many quarters? ");
            int numOfQuarters = Tools.VerifyNumber();
            return numOfQuarters;
        }
    }
}
