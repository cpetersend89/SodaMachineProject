using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class FileReader
    {
        public static List<Inventory> ReadInventoryFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<Inventory> inventory = new List<Inventory>();
                    while (!sr.EndOfStream)
                    {
                        string soda = sr.ReadLine();
                        inventory.Add(new Inventory(soda));
                    }
                    return inventory;
                }
            }
        }

        public static List<string> ReadStringListFromFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<string> inventory = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        string soda = sr.ReadLine();
                        inventory.Add(soda);
                    }
                    return inventory;
                }
            }
        }

        public static string ReadBankFile(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string total = sr.ReadLine();
                    return total;
                }
            }
        }
              
    }
}
