using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Bank
    {
        public void SubtractFromBank(double change)
        {
            string bankTotal = FileReader.ReadBankFile(@"../../Bank.txt");
            double newBankTotal = double.Parse(bankTotal) - change;
            FileWriter.WriteToFile(@"../../Bank.txt", newBankTotal);
        }

        public void AddToBank(double totalCoins)
        {
            string bankTotal = FileReader.ReadBankFile(@"../../Bank.txt");
            double newBankTotal = double.Parse(bankTotal) + totalCoins;
            FileWriter.WriteToFile(@"../../Bank.txt", newBankTotal);
        }

        public static double GetBankTotal()
        {
            string bankTotal = FileReader.ReadBankFile(@"../../Bank.txt");
            return double.Parse(bankTotal);
        }
        public void ReturnChangeAsCoins(double change)
        {
            int quarters = (int)(change / .25);
            double quartersRemaining = change % .25;
            int dimes = (int)(quartersRemaining / .10);
            double dimesRemaining = quartersRemaining % .10;
            int nickels = (int)(dimesRemaining / .05);
            double nickelsRemaining = dimesRemaining % .05;
            int pennies = (int)(nickelsRemaining / .01);
            Console.WriteLine($"Change Quarters: {quarters}, Dimes: {dimes}, Nickels: {nickels}, Pennies: {pennies}");
            UpdateCoins(change, quarters, dimes, nickels, pennies);
        }

        public void UpdateCoins(double change, int quarters, int dimes, int nickels, int pennies)
        {
            List<string> temp = FileReader.ReadStringListFromFile(@"../../Coins.txt");
            string quarter = temp[0];
            string dime = temp[1];
            string nickel = temp[2];
            string penny = temp[3];
            int newQuarter = int.Parse(quarter) - quarters;
            int newDime = int.Parse(dime) - dimes;
            int newNickel = int.Parse(nickel) - nickels;
            int newPenny = int.Parse(penny) - pennies;
            List<int> coins = new List<int>();
            coins.Add(newQuarter);
            coins.Add(newDime);
            coins.Add(newNickel);
            coins.Add(newPenny);
            FileWriter.OverrideCoinsFile(@"../../Coins.txt", coins);
            SubtractFromBank(change);
        }
    }
}
