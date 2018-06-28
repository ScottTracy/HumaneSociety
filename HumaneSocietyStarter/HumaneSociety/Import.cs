using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Import
    {
        public  void ImportCSV()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:/projects/HumaneSocietyStarter/HumaneSocietyStarter/HumaneSocietyAnimals/HumaneSocietyAnimals/Animals.csv");
            Console.WriteLine(lines);

        }
    }
}
