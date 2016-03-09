using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Inventory
    {
        private readonly string _sodaType;

        public Inventory(string sodaType)
        {
            _sodaType = sodaType;
        }

        public static List<Inventory> GetSodaInventory(string sodaType)
        {
            List<Inventory> temp = Tools.GetTempInventoryList();
            List<Inventory> sodas = temp.FindAll(x => x._sodaType == sodaType);
            return sodas;
        }

        public static void RemoveSodaFromInventory(string sodaType)
        {
            List<string> temp = FileReader.ReadStringListFromFile(@"../../Inventory.txt");
            temp.Remove(sodaType);
            FileWriter.OverrideInventoryFile(@"../../Inventory.txt", temp);
        }

        public override string ToString()
        {
            return $"{_sodaType}";
        }
    }
}
