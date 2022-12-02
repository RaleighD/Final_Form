using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    public class Booking
    {
        private int bookingID;
        private Customer passenger;
        private Flight flight;

        public Booking(int bookingID, Customer passenger, Flight flight)
        {
            this.passenger = passenger;
            this.flight = flight;
            this.bookingID = bookingID;
        }

        public int getID()
        {
            return bookingID;
        }

        public override string ToString()
        {
            return "Booking ID: " + bookingID +
                "\nCustomer: " + passenger.getFirstName() + " " + passenger.getLastName() +
                "\nFlight Number: " + flight.getFlightNum() +
                "\nDate: " + flight.getDate() +
                "\nOrigin: " + flight.getOrigin() +
                "\nDestination: " + flight.getDestination() + "\n";
        }
    }
}
