﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query

    {
        public delegate void  CrudFunction(Employee employee);
        public static void RunEmployeeQueries(Employee employee, string crudResponse)
        {
            CrudFunction EmployeeRef = setDelegate(crudResponse);
            EmployeeRef(employee);
        }
        private static CrudFunction setDelegate(string crudResponse)
        {
            switch (crudResponse)
            {
                case "create":
                    return new CrudFunction(EmployeeCreator);
                case "read":
                    return new CrudFunction(EmployeeReader);
                case "update":
                    return new CrudFunction(EmployeeUpdater);
                case "delete":
                    return new CrudFunction(EmployeeDeleter);
                default:
                    return new CrudFunction(EmployeeReader);
            }
        }
        private static void EmployeeCreator(Employee employee)
        {

        }
        private static void EmployeeReader(Employee employee)
        {

        }
        private static void EmployeeUpdater(Employee employee)
        {

        }
        private static void EmployeeDeleter(Employee employee)
        {

        }
        public static List<ClientAnimalJunction> GetPendingAdoptions()
        {
            List<ClientAnimalJunction> adoptions = new List<ClientAnimalJunction>();
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var _pendingAdoptions = db.ClientAnimalJunctions.Where(a => a.approvalStatus.ToLower() == "pending adoption").ToList();
            return _pendingAdoptions;
        }
        public static void UpdateAdoption(bool boolean, ClientAnimalJunction clientAnimalJunction)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            if (boolean)
            {
                var _animal = db.ClientAnimalJunctions.Where(s => s.animal == clientAnimalJunction.animal);
                foreach(var a in _animal)
                {
                    a.approvalStatus = "Approved";
                }
            }
        }
        public static List<AnimalShotJunction> GetShots(Animal animal)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var animals = db.AnimalShotJunctions.Where(a => a.Animal_ID.Equals(animal.ID)).ToList();
            return animals; 
        }
        public static void UpdateShot(String shot, Animal animal)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var animals = db.AnimalShotJunctions.Where(s => s.Animal_ID == animal.ID);
            foreach (var a in animals)
            {
                Console.WriteLine(animal.name + " recieved " + shot + " shot.");
                a.dateRecieved = DateTime.Today;
            }
            Console.ReadLine();
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
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animal's breed?");
            string _breed = Console.ReadLine();
            var breedKey = db.Breeds.Where(b => b.breed1.ToLower().Equals(_breed.ToLower()));
            int _breedKey = 0;
            foreach (var bK in breedKey)
            {
                _breedKey = bK.ID;
            }
            return _breedKey;
        }
        public static int GetDiet()
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animal's diet plan?");
            string _diet = Console.ReadLine();
            var diet = db.DietPlans.Where(d => d.food.ToLower().Equals(_diet.ToLower()));
            int _dietKey = 0;
            foreach (var dK in diet)
            {
                _dietKey = dK.ID;
            }
            return _dietKey;
        }
        public static int? GetLocation()
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Console.WriteLine("What is the animal's location?");
            string _location = Console.ReadLine();
            var location = db.Animals.Where(l => l.location.Equals(_location));
            int? locationKey = 0;
            foreach (var lK in location)
            {
                locationKey = lK.location;
            }
            return locationKey;
        }
        public static Employee EmployeeLogin(string userName, string password)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            Employee employee = new Employee();
            var employees = db.Employees.Where(e => e.userName.Equals(userName) && e.pass.Equals(password));
            foreach (var emp in employees)
            {
                employee = emp;
            }
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
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var worker = from item in db.Employees
                            where item.ID == employee .ID
                            select item;
            worker.First().pass = employee.pass;
            worker.First().userName = employee.userName;
            db.SubmitChanges();
        }
        public static bool CheckEmployeeUserNameExist(string username)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var employees = db.Employees.Where(c => c.userName.Equals(username));
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
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            List<ClientAnimalJunction> adoptionStatus = new List<ClientAnimalJunction>();
            var pendingAdoptions = db.ClientAnimalJunctions.Where(a => a.approvalStatus.ToLower().Equals("pending adoption"));
            foreach(var animal in pendingAdoptions)
            {
                adoptionStatus.Add(animal);
            }
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
            USState State = new USState();
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
            State.ID = state;
            address.USState = State;
            db.Clients.InsertOnSubmit(client);
            db.UserAddresses.InsertOnSubmit(address);
            db.SubmitChanges();
        }
        public static void updateClient(Client client)
        {
            HumaneSocietyDataContext db = new HumaneSocietyDataContext();
            var oldClient = from item in db.Clients
                            where item.ID == client.ID
                            select item;
            if (client.pass != null) { oldClient.First().pass = client.pass; }
            if (client.homeSize != null) { oldClient.First().homeSize = client.homeSize; }
            if (client.kids != null) { oldClient.First().kids = client.kids; }
            if(client.income !=null) { oldClient.First().income = client.income; }
            db.SubmitChanges();
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
