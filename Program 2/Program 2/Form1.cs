//Raymond Rivera
//Program 2
//3-8-16
//CIS 199-01
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class program2 : Form
    {
        public program2()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            const double benchmark1 = 30; // declares the 30 credit hour variable 
            const double benchmark2 = 60; //declares the 60 credit hour variable
            const double benchmark3 = 90;// declares the 90 creedit hour variable
            double creditHoursEarend = double.Parse(creditHoursEarnedInput.Text);// what the user enters as there creadit hours
            string name = nameInput.Text; // waht the user enters as there name
            string lastName = name.ToUpper().First().ToString();// the first character of the users last name

            // the information need for a Senior
            if ((creditHoursEarend >= benchmark3) && (lastName == "A" || lastName == "B" || lastName == "C" || lastName == "D")) //if senior and if last name starts with A - D
            {
                MessageBox.Show("Wednesday, March 30, 4:00pm");
            }
            if ((creditHoursEarend >= benchmark3) && (lastName == "T" || lastName == "U" || lastName == "V" || lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z"))// if senior and last name starts with T -Z
            {
                MessageBox.Show("Wednesday, March 30, 2:00pm");
            }
            if ((creditHoursEarend >= benchmark3) && (lastName == "P" || lastName == "Q" || lastName == "R" || lastName == "S"))//if senior and last name starts with P - S
            {
                MessageBox.Show("Wednesday, March 30, 11:30am");
            }
            if ((creditHoursEarend >= benchmark3) && (lastName == "J" || lastName == "K" || lastName == "L" || lastName == "M" || lastName == "N" || lastName == "O"))// if senior and last name sarts with J - O
            {
                MessageBox.Show("Wednesday, March 30, 10:00am");
            }
            if ((creditHoursEarend >= benchmark3) && (lastName == "E" || lastName == "F" || lastName == "G" || lastName == "H" || lastName == "I"))//if senior and last name starts with E-H
            {
                MessageBox.Show("Wednesday, March 30, 8:30am");
            }
            // the information if Junior
            if (((creditHoursEarend >= benchmark2) && (creditHoursEarend < benchmark3)) && (lastName == "A" || lastName == "B" || lastName == "C" || lastName == "D"))//if junior and last name starts with A-D
            {
                MessageBox.Show("Wednesday, March 30, 4:00pmTEST");
            }
            if (((creditHoursEarend >= benchmark2) && (creditHoursEarend < benchmark3)) && (lastName == "T" || lastName == "U" || lastName == "V" || lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z"))//if junior and last nmae starts with T-Z
            {
                MessageBox.Show("Wednesday, March 30, 2:00pm");
            }
            if (((creditHoursEarend >= benchmark2) && (creditHoursEarend < benchmark3)) && (lastName == "P" || lastName == "Q" || lastName == "R" || lastName == "S"))//if junior and lastname starts with P-S
            {
                MessageBox.Show("Wednesday, March 30, 11:30am");
            }
            if (((creditHoursEarend >= benchmark2) && (creditHoursEarend < benchmark3)) && (lastName == "J" || lastName == "K" || lastName == "L" || lastName == "M" || lastName == "N" || lastName == "O"))//if junior and last name starts with J-O
            {
                MessageBox.Show("Wednesday, March 30, 10:00am");
            }
            if (((creditHoursEarend >= benchmark2) && (creditHoursEarend < benchmark3)) && (lastName == "E" || lastName == "F" || lastName == "G" || lastName == "H" || lastName == "I"))// if junior and last name starts with E-I
            {
                MessageBox.Show("Wednesday, March 30, 8:30am");
            }
            // the information if Sophmore
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "P" || lastName == "Q")) // If sophmore and last name starts with P-Q
            {
                MessageBox.Show("Friday, April 1, 4:00pm");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "M" || lastName == "O"))//if sophmore and last name starts with 
            {
                MessageBox.Show("Friday, April 1, 2:00pm");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "J" || lastName == "K" || lastName == "L"))//if sophmore and last name starts with J-L
            {
                MessageBox.Show("Friday, April 1, 11:30");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "G" || lastName == "H" || lastName == "I"))//if sophmore and last nmae starts with G-I
            {
                MessageBox.Show("Friday, April 1, 10:00am");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "E" || lastName == "F"))//if sophmore and last name starst with E-F
            {
                MessageBox.Show("Friday, April 1, 8:30am");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "C" || lastName == "D"))// if sophmore and last name starts with C-D
            {
                MessageBox.Show("Monday, April 4, 4:00pm");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "A" || lastName == "B"))//if sophmore and last name starts with A-B
            {
                MessageBox.Show("Monday, April 4, 2:00pm");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z"))//if sophmore and last name starts with W-Z
            {
                MessageBox.Show("Monday, April 4, 11:30");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "T" || lastName == "U" || lastName == "V"))// if sophmore and last name starts with T-V
            {
                MessageBox.Show("Friday, April 1, 10:00am");
            }
            if (((creditHoursEarend >= benchmark1) && (creditHoursEarend < benchmark2)) && (lastName == "R" || lastName == "S"))// if sophomore and last name starts with R-S
            {
                MessageBox.Show("Monday, April 4, 8:30am");
            }

            if (creditHoursEarend == 0) // if Graduate
            {
                MessageBox.Show("Tuesday, March 29, 10:30");
            }
            // information if Freshman

            if ((creditHoursEarend < benchmark1) && (lastName == "P" || lastName == "Q"))// if freshman and last name starts with P-Q
            {
                MessageBox.Show("Tuesday, April 5, 4:00pm");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "M" || lastName == "O"))// if freshman and last name starts with M-O
            {
                MessageBox.Show("Tuesday, April 5, 2:00pm");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "J" || lastName == "K" || lastName == "L"))// if freshman and last name starts with J-L
            {
                MessageBox.Show("Tuesday, April 5, 11:30");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "G" || lastName == "H" || lastName == "I"))// if freshman and last name starts with G-I
            {
                MessageBox.Show("Tuesday, April 5, 10:00am");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "C" || lastName == "D"))// if freshman and last name starts with C-D
            {
                MessageBox.Show("Wednesday, April 6, 4:00pm");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "A" || lastName == "B"))// if freshman and last name starts with A-B
            {
                MessageBox.Show("Wednesday, April 6, 2:00pm");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "W" || lastName == "X" || lastName == "Y" || lastName == "Z"))// if freshman and last name starts with W-Z
            {
                MessageBox.Show("Wednesday, April 6, 11:30");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "T" || lastName == "U" || lastName == "V"))// if freshman and last name starts with T-V
            {
                MessageBox.Show("Wednesday, April 6, 10:00am");
            }
            if ((creditHoursEarend < benchmark1) && (lastName == "R" || lastName == "S"))// if freshman and last name starts with R-S
            {
                MessageBox.Show("Wednesday, April 6, 8:30am");


            }
        }
    }
}