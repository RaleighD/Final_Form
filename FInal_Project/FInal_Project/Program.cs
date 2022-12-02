using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager(500);
            FlightManager fm = new FlightManager(100);
            BookingManager bm = new BookingManager(1000);
            Coordinator coord = new Coordinator(bm, cm, fm);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(bm, cm, fm, coord));
        }
    }
}
