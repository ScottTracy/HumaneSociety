using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Import
    {
        
        public static string[][] ImportCSV()
        {
            string csvFile = @"C:/projects/HumaneSocietyStarter/HumaneSocietyStarter/HumaneSocietyAnimals/HumaneSocietyAnimals/Animals.csv";
            string[] lines = System.IO.File.ReadAllLines(csvFile);

            var data = lines.Select(d => d.Split(',')).ToArray();
            return data;

        }
        public static  void PopulateAnimals(string[][] data)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            
           foreach (var animal in data)
            {
                Animal a = new Animal();
                a.ID = int.Parse(animal[0]);
                a.name = animal[1].Replace(@"\", "");
                a.breed = ToNullableInt(animal[2]);
                a.weight = ToNullableInt(animal[3]);
                a.age = ToNullableInt(animal[4]);
                a.diet = ToNullableInt(animal[5]);
                a.location = ToNullableInt(animal[6]);
                a.demeanor =animal[7].Replace(@"\", "");
                if (int.Parse(animal[8]) == 1)
                {
                    a.kidFriendly = true;
                }
                else
                {
                    a.kidFriendly = false;
                }
                ;
                if( int.Parse(animal[9])== 1)
                {
                    a.petFriendly = true;
                }
                else
                {
                    a.petFriendly = false;
                }
                a.gender = ToNullableBool(animal[10]);
                a.adoptionStatus = animal[11].Replace(@"\", "");
                a.Employee_ID = ToNullableInt(animal[12]);
                db.Animals.InsertOnSubmit(a);
                db.SubmitChanges();


            }
        }
        public static  int? ToNullableInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }
        public static bool? ToNullableBool(this string s)
        {
            bool b;
            if (bool.TryParse(s, out b)) return b;
            return null;
        }
    }
}
