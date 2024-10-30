using System;
using System.Collections;
using System.Collections.Generic;
namespace std
{
    class User
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }

        public List<User> users { get; set; }
        public void register(int userId, string name, string phoneNumber)
        {
            this.userId = userId;
            this.name = name;
            this.phoneNumber = phoneNumber;
            users.Add(this);

        }
        public void displayProfile()
        {
            Console.WriteLine("user id : " + userId);
            Console.WriteLine("user name : " + name);
            Console.WriteLine("Phone no : " + phoneNumber);
        }



    }
    class Trip
    {
        public int tripId { get; set; }
        public string riderName { get; set; }
        public string DriverName { get; set; }
        public string startLocation { get; set; }
        public string destination { get; set; }
        public int fare { get; set; }
        public int range { get; set; }
        public void caluculateFare()
        {
            fare = range * 5;
        }
        public void dispalyTripDetails()
        {
            Console.WriteLine("Trip Id : " + tripId);
            Console.WriteLine("Rider name : " + riderName);
            Console.WriteLine("Driver Name :" + DriverName);
            Console.WriteLine("Start Location :" + startLocation);
            Console.WriteLine("Destinaton : " + destination);
            Console.WriteLine("Fare : " + fare);
        }
    }
    class Rider : User
    {
        public List<Trip> rideHistory { get; set; }
        Dictionary<int, List<User>> riders { get; set; }
        public void requestRide(Trip trip)
        {
            rideHistory.Add(trip);
        }
        public void viewRideHistory(int id)
        {
            Console.WriteLine("Trip id " + rideHistory[id].tripId);
            Console.WriteLine("Driver Name :" + rideHistory[id].DriverName);
            Console.WriteLine("Start Location :" + rideHistory[id].startLocation);
            Console.WriteLine("Destinaton : " + rideHistory[id].destination);
            Console.WriteLine("Fare : " + rideHistory[id].fare);

        }

    }
    class Driver : User
    {
        public int driverId { get; set; }
        public string Vehicle { get; set; }
        public List<Trip> tripHistory { get; set; }
        public void viewtripHistory(int id)
        {
            Console.WriteLine("Trip id " + tripHistory[id].tripId);
            Console.WriteLine("Rider Name :" + tripHistory[id].riderName);
            Console.WriteLine("Start Location :" + tripHistory[id].startLocation);
            Console.WriteLine("Destinaton : " + tripHistory[id].destination);
            Console.WriteLine("Fare : " + tripHistory[id].fare);

        }
        public bool acceptRide(string Id, string start_loc, string destination, string ridername, int range)
        {
            Console.WriteLine("Rider Name :" + ridername);
            Console.WriteLine("Start Location :" + start_loc);
            Console.WriteLine("Destinaton : " + destination);
            Console.WriteLine("Range : " + range);
            Console.WriteLine("Do you want to accept the ride ");
            string opt;
            opt = Console.ReadLine();
            if (opt == "yes")
            {
                Trip t = new Trip();
                Console.WriteLine("Enter trip id : ");
                int id;
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your name : ");
                string name;
                name = Console.ReadLine();
                t.tripId = id;
                t.riderName = ridername;
                t.startLocation = start_loc;
                t.destination = destination;
                t.range = range;
                t.DriverName = name;
                tripHistory.Add(t);

                return true;


            }
            else
            {
                return false;
            }


        }
        class RideSharingSystem
        {
            public List<Trip> availableTrips { set; get; }
            public List<Rider> rider { set; get; }
            public List<Driver> drivers { set; get; }
            public void register_user()
            {

                Console.WriteLine("Are you rider or driver ");
                string user;
                user = Console.ReadLine();
                if (user == "rider" )
                {
                    Rider r = new Rider();
                    Console.WriteLine("your id : ");
                    r.userId = int.Parse(Console.ReadLine());
                    Console.WriteLine("your name : ");
                    r.name = Console.ReadLine();
                    Console.WriteLine("your phone number : ");
                    r.phoneNumber = Console.ReadLine();
                    rider.Add(r);

                }
                if (user == "driver")
                {
                    Driver d = new Driver();
                    Console.WriteLine("your id : ");
                    d.userId = int.Parse(Console.ReadLine());
                    Console.WriteLine("your name : ");
                    d.name = Console.ReadLine();
                    Console.WriteLine("your phone number : ");
                    d.phoneNumber = Console.ReadLine();
                    drivers.Add(d);

                }
            }


        class program
        {
            static void Main(string[] args)
            {
                    string option;
                    Console.WriteLine("1.Register as rider ");
                    Console.WriteLine("2.Register as driver ");
                    Console.WriteLine("3.Request a Ride ");
                    Console.WriteLine("4.Accept a Ride  ");
                    Console.WriteLine("5.Complete a trip ");
                    Console.WriteLine("6.View Ride History ");
                    Console.WriteLine("7.View Trip History ");
                    Console.WriteLine("8.Display all trips ");
                    Console.WriteLine("Exit");
                    Console.WriteLine("select option");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1" :
                            RideSharingSystem r = new RideSharingSystem();
                            r.register_user();

                            

                    }



                    

            }
        }

    }
