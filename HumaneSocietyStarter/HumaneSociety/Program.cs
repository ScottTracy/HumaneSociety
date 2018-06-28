using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal[] animals = new Animal[]
            //{
            //    new Animal {ID = 1001, name = "Murdock", breed = null, weight = 15, age = 2, diet = null, location = null, demeanor = "skittish", kidFriendly = true, petFriendly = false, gender = null, adoptionStatus = "adopted", Employee_ID = null },
            //    new Animal {ID = 1002, name = "Loki", breed = null, weight = 18, age = 3, diet = null, location = null, demeanor = "cuddly", kidFriendly = true, petFriendly = true, gender = null, adoptionStatus = "adopted", Employee_ID = null },
            //    new Animal {ID = 1003, name = "Rowdy", breed = null, weight = 20, age = 8, diet = null, location = null, demeanor = "deceased", kidFriendly = true, petFriendly = true, gender = null, adoptionStatus = "not adopted", Employee_ID = null },
            //};

            //PointOfEntry.Run();
            Import import = new Import();
            import.ImportCSV();

            PointOfEntry.Run();

        }
    }
}
