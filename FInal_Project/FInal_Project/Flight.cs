using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    public class Flight
    {
        private int flightID;
        private string flightNum;
        private string date;
        private string origin;
        private string destination;
        private string aircraft;
        private int capacity;
        private int duration; // duration is in minutes
        private Customer[] manifest;
        private int numPassengers;


        public Flight(int flightID, string flightNum, string date, string origin, string destination, string aircraft, int capacity, int duration)
        {
            this.flightID = flightID;
            this.flightNum = flightNum;
            this.date = date;
            this.origin = origin;
            this.destination = destination;
            this.aircraft = aircraft;
            this.capacity = capacity;
            this.duration = duration;
            manifest = new Customer[capacity];
            numPassengers = 0;
        }

        public int getID()
        {
            return flightID;
        }

        public string getFlightNum()
        {
            return flightNum;
        }

        public string getDate()
        {
            return date;
        }

        public string getOrigin()
        {
            return origin;
        }

        public string getDestination()
        {
            return destination;
        }

        public string getAircraft()
        {
            return aircraft;
        }

        public int getCapacity()
        {
            return capacity;
        }

        public int getDuration()
        {
            return duration;
        }

        public Customer[] getManifest()
        {
            return manifest;
        }

        public int getNumPassengers()
        {
            return numPassengers;
        }

        public void addPassenger(Customer passenger)
        {
            manifest[numPassengers] = passenger;
            numPassengers++;
        }

        public string viewPassengers()
        {
            string s = "";
            for (int i = 0; i < numPassengers; i++)
            {
                s += "\n" + manifest[i].ToString();

            }
            return s;
        }

        public override string ToString()
        {
            return "\nFlight ID: " + flightID + " " +
                "\nIATA Flight Number: " + flightNum + " " +
                "\nDate: " + date + " " +
                "\nOrigin: " + origin + " " +
                "\nDestination: " + destination + " " +
                "\nAircraft: " + aircraft + " " +
                "\nFlight Capacity: " + capacity + " " +
                "\nDuration: " + duration + " minutes" + " " +
                "\nPassenger List: \n" + viewPassengers() "                      ";
        }

    }
}


