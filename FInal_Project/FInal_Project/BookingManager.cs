using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    public class BookingManager
    {
        private Booking[] bookingList;
        private int maxBookings;
        private int numBookings;
        private static int bookingSeed;

        public BookingManager(int maxBookings)
        {
            this.maxBookings = maxBookings;
            numBookings = 0;
            bookingList = new Booking[maxBookings];
            bookingSeed = 1000;

        }

        public bool verifyUnique(int id)
        {
            for (int i = 0; i < numBookings; i++)
            {
                if (bookingList[i].getID() == id)
                {
                    return false;
                }
            }
            return true;
        }


        public int getSeed()
        {
            return bookingSeed;
        }

        public int getNumBookings()
        {
            return numBookings;
        }


        public bool addBooking(Customer passenger, Flight flight)
        {
            if (verifyUnique(bookingSeed) == true && flight.getNumPassengers() < flight.getCapacity() && numBookings < maxBookings)
            {
                bookingList[numBookings] = new Booking(bookingSeed, passenger, flight);
                flight.addPassenger(passenger);
                passenger.addBooking();
                bookingSeed++;
                numBookings++;
                return true;
            }
            return false;
        }

        public string viewBooking(int id)
        {
            for (int i = 0; i < numBookings; i++)
            {
                if (bookingList[i].getID() == id)
                {
                    return bookingList[i].ToString();
                }
            }
            return "";

        }

        public string viewBookings()
        {
            string s = "";
            for (int i = 0; i < numBookings; i++)
            {
                s += "\n" + bookingList[i].ToString();
            }
            return s;
        }

        public Booking[] getBookingList()
        {
            return bookingList;
        }
    }
}
