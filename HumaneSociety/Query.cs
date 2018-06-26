using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        public static void RunEmployeeQueries(Employee employee,string command)
        {

        }
        public static Employee RetrieveEmployeeUser(string email, int employeeNumber )
        {
            Employee employee = new Employee();
            return employee;
        }
        public static void EmployeeLogin()
        {

        }
        public static void AddUsernameAndPassword(Employee employee)
        {

        }
        public static void CheckEmployeeUserNameExist(string username)
        {

        }
        public static Client GetClient(string username,string password)
        {
            Client client = new Client();
            return client;
        }
        public static List<string> GetUserAdoptionStatus(Client client)
        {
            List<string> status = new List<string>();
            return status;
        }
        public static Animal GetAnimalByID(int iD)
        {
            Animal animal = new Animal();
            return animal;
        }
        public static void Adopt(Animal animal,Client client)
        {

        }
        public static Client RetrieveClients()
        {
            Client client = new Client();
            return client;
        }
        public static USState GetStates()
        {
            USState state = new USState();
            return state;
        }
        public static void updateClient(Client client)
        {

        }
        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode,int  state)
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
        public static void UpdateFirstName(Client Client)
        {

        }
        public static void UpdateLastName(Client client)
        {

        }
        public static List<string>  GetPendingAdoptions()
        {
            List<string> adoptions = new List<string>();
            return adoptions;
        }
        public static void UpdateAdoption(bool ifTrue, ClientAnimalJunction clientAnimalJunction)
        {

        }
        public static List<string> GetShots(Animal animal)
        {
            List<string> shots = new List<string>();
            return shots;
        }







    }
}
