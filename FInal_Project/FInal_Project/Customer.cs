using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    public class Customer
    {

        private int customerID;
        private string firstName;
        private string lastName;
        private string phoneNum;
        private int numBookings;

        public Customer(int customerID, string firstName, string lastName, string phoneNum)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            numBookings = 0;
        }

        public int getID()
        {
            return customerID;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getPhoneNum()
        {
            return phoneNum;
        }

        public int getNumBookings()
        {
            return numBookings;
        }

        public void addBooking()
        {
            numBookings++;
        }

        public override string ToString()
        {
            return "Customer ID: " + getID() +
                "\nFirst Name: " + firstName +
                "\nLast Name: " + lastName +
                "\nPhone Number: " + phoneNum +
                "\nNumber of Bookings: " + numBookings + "\n";
        }
    }
}