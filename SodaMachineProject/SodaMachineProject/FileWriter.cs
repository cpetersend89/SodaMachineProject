using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class FileWriter
    {
        public static void WriteToInventoryFile(string fileName, List<Inventory> inventory)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Inventory soda in inventory)
                    {
                        sw.WriteLine(soda);
                    }
                }
            }
        }

        public static void OverrideInventoryFile(string fileName, List<string> inventory)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (string soda in inventory)
                    {
                        sw.WriteLine(soda);
                    }
                }
            }
        }
        public static void OverrideCoinsFile(string fileName, List<int> inventory)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (int soda in inventory)
                    {
                        sw.WriteLine(soda);
                    }
                }
            }
        }

        public static void WriteToFile(string fileName, double total)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(total);
                }
            }
        }
    }
}
