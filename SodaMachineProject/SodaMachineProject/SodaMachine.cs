using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class SodaMachine
    {
        private readonly double _grapeSoda = .60;
        private readonly double _orangeSoda = .35;
        private readonly double _meatSoda = .06;

        public int CheckInventory()
        {
            while (true)
            {
                int sodaChoice = UserInput.SelectSoda();
                switch (sodaChoice)
                {
                    case 1: //Grape
                        Console.Clear();
                        List<Inventory> grapeSoda = Inventory.GetSodaInventory("GRAPE");
                        if (grapeSoda.Count < 1)
                        {
                            Console.WriteLine("Out of inventory, try another soda");
                        }
                        else
                        {
                            return sodaChoice;
                        }
                        break;
                    case 2: //Orange
                        Console.Clear();
                        List<Inventory> orangeSoda = Inventory.GetSodaInventory("ORANGE");
                        if (orangeSoda.Count < 1)
                        {
                            Console.WriteLine("Out of inventory, try another soda");
                        }
                        else
                        {
                            return sodaChoice;
                        }
                        break;
                    case 3: //Meat
                        Console.Clear();
                        List<Inventory> meatSoda = Inventory.GetSodaInventory("MEAT");
                        if (meatSoda.Count < 1)
                        {
                            Console.WriteLine("Out of inventory, try another soda");
                        }
                        else
                        {
                            return sodaChoice;
                        }
                        break;
                    case 4: //Cancel
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: enter a valid option");
                        break;
                }
            }
        }
        private double CollectCoins()
        {
            Penny p = new Penny();
            Nickel n = new Nickel();
            Dime d = new Dime();
            Quarter q = new Quarter();
            double penny = double.Parse(p.ToString());
            double nickel = double.Parse(n.ToString());
            double dime = double.Parse(d.ToString());
            double quarter = double.Parse(q.ToString());
            int numOfPennies = UserInput.CollectPennies();
            int numOfNickels = UserInput.CollectNickels();
            int numOfDimes = UserInput.CollectNickels();
            int numOfQuarters = UserInput.CollectQuarters();
            double total = (penny * numOfPennies) + (nickel * numOfNickels) + (dime * numOfDimes) + (quarter * numOfQuarters);
            return total;
        }

        public double VerifyTotalCoins(int sodaSelection)
        {
            while (true)
            {
                double totalCoins = CollectCoins();
                switch (sodaSelection)
                {
                    case 1: //Grape
                        if (totalCoins < _grapeSoda)
                        {
                            Console.WriteLine(
                                $"Insufficient funds: Short ${_grapeSoda - totalCoins}, transaction canceled");
                            Tools.ClearConsole();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            return totalCoins;
                        }
                        break;
                    case 2: //Orange
                        if (totalCoins < _orangeSoda)
                        {
                            Console.WriteLine(
                                $"Insufficient funds: Short ${_orangeSoda - totalCoins}, transaction canceled");
                            Tools.ClearConsole();
                            CheckInventory();
                        }
                        else
                        {
                            Console.Clear();
                            return totalCoins;
                        }
                        break;
                    case 3: //Meat
                        if (totalCoins < _meatSoda)
                        {
                            Console.WriteLine(
                                $"Insufficient funds: Short ${_meatSoda - totalCoins}, transaction canceled");
                            Tools.ClearConsole();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Clear();
                            return totalCoins;
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: enter a valid option");
                        break;
                }
            }
        }

        public void VerifyBankSufficientFunds(double change)
        {
            double bankTotal = Bank.GetBankTotal();
            if (bankTotal < change)
            {
                Console.WriteLine("Insufficient funds in bank to process change, transaction canceled");
                Tools.ClearConsole();
                Environment.Exit(0);
            }
        }
        public void SellSoda(int sodaChoice)
        {
            switch (sodaChoice)
            {
                case 1: //Grape
                    Inventory.RemoveSodaFromInventory("GRAPE");
                    Console.WriteLine("Enjoy your grape soda!");
                    break;
                case 2: //Orange
                    Inventory.RemoveSodaFromInventory("ORANGE");
                    Console.WriteLine("Enjoy your orange soda!");
                    break;
                case 3: //Meat
                    Inventory.RemoveSodaFromInventory("MEAT");
                    Console.WriteLine("Enjoy your meat soda!");
                    break;
            }
        }

        public double GetChange(int sodaSelection, double totalCoins)
        {
            switch (sodaSelection)
            {
                case 1: //Grape
                    double grapeChange = totalCoins - _grapeSoda;
                    return grapeChange;
                case 2: //Orange
                    double orangeChange = totalCoins - _orangeSoda;
                    return orangeChange;
                case 3: //Meat
                    double meatChange = totalCoins - _meatSoda;
                    return meatChange;
                default:
                    return 0;
            }
        }
        public void ReturnChange(int sodaSelection, double totalCoins)
        {
            switch (sodaSelection)
            {
                case 1: //Grape
                    double grapeChange = totalCoins - _grapeSoda;
                    Console.WriteLine($"Your change is: ${grapeChange}");
                    Tools.ClearConsole();
                    break;
                case 2: //Orange
                    double orangeChange = totalCoins - _orangeSoda;
                    Console.WriteLine($"Your change is: ${orangeChange}");
                    Tools.ClearConsole();
                    break;
                case 3: //Meat
                    double meatChange = totalCoins - _meatSoda;
                    Console.WriteLine($"Your change is: ${meatChange}");
                    Tools.ClearConsole();
                    break;
            }
        }
    }
}
