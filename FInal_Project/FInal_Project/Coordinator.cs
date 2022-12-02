using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    public class Coordinator
    {
        private BookingManager bookMan;
        private CustomerManager cusMan;
        private FlightManager flightMan;

        public Coordinator(BookingManager bookMan, CustomerManager cusMan, FlightManager flightMan)
        {
            this.bookMan = bookMan;
            this.cusMan = cusMan;
            this.flightMan = flightMan;
        }

        public bool addCustomer(string firstName, string lastName, string phoneNum)
        {
            cusMan.addCustomer(firstName, lastName, phoneNum);
            return true;
        }

        public bool addBooking(int customerID, int flightID)
        {
            Customer c = cusMan.search(customerID);
            Flight f = flightMan.search(flightID);
            bookMan.addBooking(c, f);
            return true;

        }

        public bool addFlight(string flightNum, string date, string origin, string destination, string aircraft, int capacity, int duration)
        {
            flightMan.addFlight(flightNum, date, origin, destination, aircraft, capacity, duration);
            return true;
        }

        public bool removeCustomer(int id)
        {
            cusMan.removeCustomer(id);
            return true;
        }

        public bool removeFlight(int id)
        {
            flightMan.removeFlight(id);
            return true;
        }

        public string viewFlights()
        {
            return flightMan.viewFlights();
        }
        
        public string viewFlight(string flightNum)
        {
            return flightMan.viewFlight(flightNum);
        }

        public string viewBooking(int id)
        {
            return bookMan.viewBooking(id);
        }
        public bool customerExists(int id)
        {
            if (cusMan.customerExists(id))
            {
                return true;
            }
            return false;
        }
        

        public string viewBookings()
        {
            return bookMan.viewBookings();
        }

        public string viewCustomers()
        {
            return cusMan.viewCustomers();
        }
    }
}