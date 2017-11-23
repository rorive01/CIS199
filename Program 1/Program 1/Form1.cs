//Raymond Rivera
// Program 1
//2-14-16
// CIS 199 -01

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class program1 : Form
    {
        public program1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            const decimal time  = 8m; // for every 325 sq ft, 8 hours of work is put in
            const decimal area = 325m; // the area that can be covered with in 8 hours of work
            const decimal workPay = 10.5m; // for every hour worked, the company charges $10.50 per hour
            decimal wallSpace; // declaring the variable to be assigned later
            decimal numberOfCoats; // decalring varibale to be assigned later
            decimal priceOfPaint; //declaring variable to be assigned later
            decimal totalWallSpace; //declaring variable to be assigned later
            decimal hoursOfLabor; //declaring variable to be assigned later
            decimal gallonsOfPaintNeeded; //declaring variable to be assigned later
            decimal totalPriceOfPaint; //declaring variable to be assigned later
            decimal totalPriceOfLabor; //declaring variable to be assigned later
            decimal totalPriceOfJob; //declaring variable to be assigned later

            wallSpace = decimal.Parse(wallSpaceTextBox.Text); // allows what the user inputs as wallspace to be used as a decimal for caculations
            numberOfCoats = decimal.Parse(numberOfCoatsTextBox.Text); // allows what the user enters as number of coats to be used for calculations
            priceOfPaint = decimal.Parse(priceOfPaintTextBox.Text); // allows what the user inputs as the price of paint to be used as a decimal in calculations

            totalWallSpace = Decimal.Round(wallSpace * numberOfCoats,1); // calculates the total wall space by mutiplying wall space by number of coats then rounded to
                                                                         // on decimal place
            hoursOfLabor = Decimal.Round(totalWallSpace / area * time,1); // calculates the hours of labor required by taking total wall space dividing by area and 
                                                                          // multipling by time. The product is then rounded to one decimal place
            gallonsOfPaintNeeded = Math.Ceiling(totalWallSpace / area); // calculates the gallons of paint needed by taking the total wall space and dividing by area.
                                                                        // the answer is then rounded up if it as any decimals
            totalPriceOfPaint = Decimal.Round(gallonsOfPaintNeeded * priceOfPaint,2); // calculates the total price of labor by mutipling gallons of paint by the
                                                                                    //  price of paint. the resulting product is then rounded to two decimal places
            totalPriceOfLabor = Decimal.Round(hoursOfLabor * workPay, 2); //calculates the total price of labor by multipling hours of labor by work pay
                                                                          // the resulting product is then rounded to two decimal places
            totalPriceOfJob = Decimal.Round(totalPriceOfPaint + totalPriceOfLabor,2); // calculates the total price of the job by adding total price of paint
                                                                                      // and total price of labor. the sum is then rounded to two decimal places

            totalWallSpaceOutPut.Text = totalWallSpace.ToString(); // converts the total wall space to string and assigns it to the ouput label of total wall space.
            hoursOfLaborOutPut.Text = hoursOfLabor.ToString(); // converts the hours of labor variabe to string and assigns it to the output label of hours of labor.
            gallonsOfPaintNeededOutPut.Text = gallonsOfPaintNeeded.ToString(); // converts the gallons of paint needed variable to string and assigns it to
                                                                               // gallons of paint needed out put label
            totalPriceOfPaintOutPut.Text = "$" + totalPriceOfPaint.ToString(); // converts the total price of paint variable to string, also places a dollar sign in
                                                                      //front of the string. the string is then assigned to the total price of paint out put label
            totalPriceOfLaborOutPut.Text = "$" + totalPriceOfLabor.ToString(); // converts total price of labor varibale in to a string and places a $ in front 
                                                                        // of the string. the string is then assigned to the total price of labor output label
            totalPriceOfJobOutPut.Text = "$" + totalPriceOfJob.ToString(); // converts the total price of job variable to a string and places a $ infront of it. 
                                                                           // the string is then assiged to the total price of job output label.



        }
    }
}
