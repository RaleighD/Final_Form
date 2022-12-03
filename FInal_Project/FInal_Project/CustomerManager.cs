using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    public class CustomerManager
    {
        private Customer[] customerList;
        private int maxCustomers;
        private int numCustomers;
        private static int customerSeed;

        public CustomerManager(int maxCustomers)
        {
            this.maxCustomers = maxCustomers;
            numCustomers = 0;
            customerList = new Customer[maxCustomers];
            customerSeed = 1000;
        }

        public int getNumCustomers()
        {
            return numCustomers;
        }

        public Customer search(int ID)
        {
            for (int x = 0; x < numCustomers; x++)
            {
                if (customerList[x].getID() == ID)
                {
                    return customerList[x];
                }
            }
            return null;

        }

        public bool customerExists(int customerID)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerList[i].getID() == customerID)
                {
                    return true;
                }
            }
            return false;
        }

        private bool verifyUnique(string first, string last, string phone)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerList[i].getFirstName() == first && customerList[i].getLastName() == last
                    && customerList[i].getPhoneNum() == phone)
                {
                    return false;
                }
            }
            return true;
        }

        public bool addCustomer(string firstName, string lastName, string phoneNum)
        {
            if (numCustomers < maxCustomers && verifyUnique(firstName, lastName, phoneNum))
            {
                customerList[numCustomers] = new Customer(customerSeed, firstName, lastName, phoneNum);
                numCustomers++;
                customerSeed++;
                return true;
            }
            return false;
        }

        public bool removeCustomer(int id)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerList[i].getID() == id && customerList[i].getNumBookings() == 0)
                {
                    for (int x = i; x < (numCustomers - 1); x++)
                    {
                        customerList[x] = customerList[x + 1];
                    }
                    numCustomers--;
                    return true;
                }
            }
            return false;
        }

        public string viewCustomers()
        {
            string s = "";
            for (int i = 0; i < numCustomers; i++)
            {
                s += customerList[i].ToString();
            }
            return s;
        }

        public string viewCustomer(int id)
        {
            for (int i = 0; i < numCustomers; i++)
                {
                    if (customerList[i].getID() == id)
                    {
                        return customerList[i].ToString();
                    }
                }
            return null;
        }

    }
}
