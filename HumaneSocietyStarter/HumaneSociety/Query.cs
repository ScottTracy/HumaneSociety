using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        public static void RunEmployeeQueries(Employee employee, string str)
        {

        }
        public static List<ClientAnimalJunction> GetPendingAdoptions()
        {
            List<ClientAnimalJunction> adoptions = new List<ClientAnimalJunction>();
            return adoptions;
        }
        public static void UpdateAdoption(bool genericBoolean, ClientAnimalJunction clientAnimalJunction)
        {

        }
        public static List<AnimalShotJunction> GetShots(Animal animal)
        {
            List<AnimalShotJunction> shots = new List<AnimalShotJunction>();
            return shots; 
        }
        public static void UpdateShot(String str, Animal animal)
        {

        }
        public static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {

        }
        public static void RemoveAnimal(Animal animal)
        {

        }
        public static void AddAnimal(Animal animal)
        {

        }
        public static int GetBreed()
        {
            return 0;
        }
        public static int GetDiet()
        {
            return 0;
        }
        public static int GetLocation()
        {
            return 0;
        }
        public static Employee EmployeeLogin(string userName, string password)
        {
            Employee employee = new Employee();
            return employee;
        }
        public static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            Employee employee = new Employee();
            return employee;
        }
        public static void AddUsernameAndPassword(Employee employee)
        {

        }
        public static bool CheckEmployeeUserNameExist(string username)
        {
            return false;
        }
        public static Client GetClient(string userName, string password)
        {
            Client client = new Client();
            return client;
        }
        public static List<ClientAnimalJunction> GetUserAdoptionStatus(Client client)
        {
            List<ClientAnimalJunction> adoptionStatus = new List<ClientAnimalJunction>();
            return adoptionStatus;
        }
        public static Animal GetAnimalByID(int iD)
        {
            Animal animal = new Animal();
            return animal;
        }
        public static void Adopt(Animal animal, Client client)
        {

        }

        public static List<Client> RetrieveClients()
        {
            List<Client> clients = new List<Client>();
            return clients;
        }
        public static Dictionary<string,string>  GetStates()
        {
            Dictionary<string, string> territory = new Dictionary<string, string>();
            return territory;
        }
        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {

        }
        public static void updateClient(Client client)
        {

        }
        public static void UpdateUsername(Client client)
        {

        }
        public static void UpdateEmail(Client client)
        {

        }
        public static void UpdateAddress(Client client)
        {

        }
        public static void UpdateFirstName(Client client)
        {

        }
        public static void UpdateLastName(Client client)
        {

        }
    }
}
