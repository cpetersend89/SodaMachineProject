using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine sm = new SodaMachine();
            int sodaChoice = sm.CheckInventory();
            double totalCoins = sm.VerifyTotalCoins(sodaChoice);
            double change = sm.GetChange(sodaChoice, totalCoins);
            sm.VerifyBankSufficientFunds(change);
            sm.SellSoda(sodaChoice);
            Bank bank = new Bank();
            bank.AddToBank(totalCoins);
            sm.ReturnChange(sodaChoice, totalCoins);
            bank.ReturnChangeAsCoins(change);

            Console.ReadKey();
        }
    }
}
