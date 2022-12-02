using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    
    public partial class Form1 : Form
    {
        BookingManager bm;
        CustomerManager cm;
        FlightManager fm;
        Coordinator coord;


        public Form1(BookingManager bm, CustomerManager cm, FlightManager fm, Coordinator coord)
        {

            this.bm = bm;
            this.cm = cm;
            this.fm = fm;
            this.coord = coord; 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // Add Booking Submit
        {
            if (int.TryParse(textBox7.Text, out int number) && int.TryParse(textBox8.Text, out int number2))
            {
                coord.addBooking(int.Parse(textBox7.Text), int.Parse(textBox8.Text));
                bookingMessage.Text = "Booking successfully added.";
            }
            else bookingMessage.Text = "There was an error with your booking. Please try again.";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e) // Textbox 10 - Flight Num box
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) // View Flights Submit Click 
        {
            textBox19.Text = coord.viewFlights();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) // Add flight Submit on Click 
        {
            coord.addFlight(textBox10.Text, textBox12.Text, textBox11.Text, textBox13.Text, textBox14.Text, 
                int.Parse(textBox16.Text), int.Parse(textBox15.Text));
        }

        private void textBox12_TextChanged(object sender, EventArgs e) // Date textBox
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e) // To display Flights
        {
            
        }

        private void button9_Click(object sender, EventArgs e) // View Particular Flight Button
        {
            ViewFlight_TxtBox.Text = coord.viewFlight(int.Parse(textBox17.Text));
        }

        private void ViewFlight_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) // Delete Flight Submit
        {
            coord.removeFlight(int.Parse(textBox18.Text));
            label23.Text = "Flight " + textBox18.Text + " successfuly deleted.";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) // View Booking Submit
        {
            ViewBookingBox.Text = coord.viewBooking(int.Parse(textBox9.Text));
        }

        private void ViewBookingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // Add Customer Submit
        {
            if (coord.addCustomer(textBox2.Text, textBox3.Text, textBox4.Text) == true)
            {
                AddCustomerConfirm.Text = $"Customer {textBox2.Text} {textBox3.Text} added.";
            }
            else
            {
                AddCustomerConfirm.Text = "User already Exists.";
            }

        }

        private void button3_Click(object sender, EventArgs e) // View Customer Submit
        {
            ViewCustomersBox.Text = coord.viewCustomers();
        }

        private void deleteConfirm_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) // Delete Customer submit
        {
            if (coord.customerExists(int.Parse(textBox6.Text)))
            {
                coord.removeCustomer(int.Parse(textBox6.Text));
                deleteConfirm.Text = "User successfully deleted";
            }
            else
            {
                deleteConfirm.Text = "User does not exist.";
            }
            
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
