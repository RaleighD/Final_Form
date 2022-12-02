using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    public class FlightManager
    {
        private Flight[] flightList;
        private int maxFlights;
        private int numFlights;
        private int flightSeed;

        public FlightManager(int maxFlights)
        {
            this.maxFlights = maxFlights;
            numFlights = 0;
            flightList = new Flight[maxFlights];
            flightSeed = 1000;
        }


        public Flight search(int ID)
        {
            for (int x = 0; x < numFlights; x++)
            {
                if (flightList[x].getID() == ID)
                {
                    return flightList[x];
                }

            }
            return null;

        }

        public int getSeed()
        {
            return flightSeed;
        }

        public Flight getFlight(int index)
        {
            return flightList[index];
        }

        public Flight[] getFlightList()
        {
            return flightList;
        }

        public int getNumFlights()
        {
            return numFlights;
        }

        private bool verifyUnique(int id)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getID() == id)
                {
                    return false;
                }
            }
            return true;
        }

        public bool flightExists(Flight flight)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i] == flight)
                {
                    return true;
                }
            }
            return false;
        }

        public bool addFlight(string flightNum, string date, string origin, string destination, string aircraft, int capacity, int duration)
        {
            if (numFlights < maxFlights && verifyUnique(flightSeed))
            {

                flightList[numFlights] = new Flight(flightSeed, flightNum, date, origin, destination, aircraft, capacity, duration);
                numFlights++;
                flightSeed++;
                return true;
            }
            return false;
        }

        public void removeFlight(int id)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getID() == id && flightList[i].getNumPassengers() == 0)
                {
                    for (int x = i; x < (numFlights - 1); x++)
                    {
                        flightList[x] = flightList[x + 1];
                    }
                    numFlights--;
                }
            }
        }

        public string viewFlights()
        {
            string s = "";
            for (int i = 0; i < numFlights; i++)
            {
                s += flightList[i].ToString() + "\n";
            }
            return s;
        }

        public string viewFlight(string flightNum)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getFlightNum() == flightNum)
                {
                    return flightList[i].ToString();
                }  
            }
            return null;
        } 
    }
}
