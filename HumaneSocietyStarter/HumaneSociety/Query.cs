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
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            db.Animals.DeleteOnSubmit(animal);
            db.SubmitChanges();            
        }
        public static void AddAnimal(Animal animal)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            db.Animals.InsertOnSubmit(animal);
            db.SubmitChanges();
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
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var employees = db.Employees.Where(e => e.email.Equals(email) && e.employeeNumber.Equals(employeeNumber));
            foreach (var e in employees)
            {
                employee = e;
            }
            return employee;
        }
        public static void AddUsernameAndPassword(Employee employee)
        {

        }
        public static bool CheckEmployeeUserNameExist(string username)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var employees = db.Clients.Where(c => c.userName.Equals(username));
            if (employees.Count() > 0)
            {
                return true;
            }
            return false;
        }
        public static Client GetClient(string userName, string password)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Client client = new Client();
            var clients = db.Clients.Where(c => (c.userName.Equals(userName) && c.pass.Equals(password)));
            foreach (var c in clients)
            {
                client = c;
            }
            return client;
        }
        public static List<ClientAnimalJunction> GetUserAdoptionStatus(Client client)
        {
            List<ClientAnimalJunction> adoptionStatus = new List<ClientAnimalJunction>();
            return adoptionStatus;
        }
        public static Animal GetAnimalByID(int iD)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Animal animal = new Animal();
            var animalsById = db.Animals.Where(a => a.ID.Equals(iD));
            foreach (var animalById in animalsById)
            {
                animal = animalById;
            }
            return animal;
        }
        public static void Adopt(Animal animal, Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            ClientAnimalJunction clientanimaljunction = new ClientAnimalJunction();
            var status = db.Animals.Where(a => a.adoptionStatus.Equals("not adopted"));
            foreach (var adoption in status)
            {
                adoption.adoptionStatus = "pending adoption";
            }
            clientanimaljunction.animal.Equals(animal.ID);
            clientanimaljunction.client.Equals(client.ID);
        }
        public static List<Client> RetrieveClients()
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var clients = db.Clients.ToList();
            return clients;
        }
        public static IQueryable<USState> GetStates()
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var states = db.USStates;           
            return states;
        }
        public static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            UserAddress address = new UserAddress(); 
            Client client = new Client();
            client.firstName = firstName;
            client.lastName = lastName;
            client.userName = username;
            client.pass = password;
            client.email = email;
            address.addessLine1 = streetAddress;
            address.addressLine2 = null;
            address.zipcode = zipCode;
            address.ID = state;
            db.Clients.InsertOnSubmit(client);
            db.UserAddresses.InsertOnSubmit(address);
            db.SubmitChanges();
        }
        public static void updateClient(Client client)
        {

        }
        public static void UpdateUsername(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Client updatedClient = new Client();
            updatedClient = client;
            updatedClient.userName = client.userName;
            db.Clients.DeleteOnSubmit(client);
            db.Clients.InsertOnSubmit(updatedClient);
            db.SubmitChanges();
        }
        public static void UpdateEmail(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Client updatedClient = new Client();
            updatedClient = client;
            updatedClient.email = client.email;
            db.Clients.DeleteOnSubmit(client);
            db.Clients.InsertOnSubmit(updatedClient);
            db.SubmitChanges();
        }
        public static void UpdateAddress(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Client updatedClient = new Client();
            updatedClient = client;
            updatedClient.userAddress = client.userAddress;
            updatedClient.UserAddress1 = client.UserAddress1;
            db.Clients.DeleteOnSubmit(client);
            db.Clients.InsertOnSubmit(updatedClient);
            db.SubmitChanges();
        }
        public static void UpdateFirstName(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Client updatedClient = new Client();
            updatedClient = client;
            updatedClient.firstName = client.firstName;
            db.Clients.DeleteOnSubmit(client);
            db.Clients.InsertOnSubmit(updatedClient);
            db.SubmitChanges();
        }
        public static void UpdateLastName(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Client updatedClient = new Client();
            updatedClient = client;
            updatedClient.lastName = client.lastName;
            db.Clients.DeleteOnSubmit(client);
            db.Clients.InsertOnSubmit(updatedClient);
            db.SubmitChanges(); 
        }
    }
}
