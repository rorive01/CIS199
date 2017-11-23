// Raymmond Rivera
// Program 4
// 4-24-16
// CIS 199-01
// to take the known information of the package and come up with a cost while still tracking the details of the package, then catalog that info.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class program4 : Form
    {
        List<GroundPackage> packageInfo = new List<GroundPackage>();
        public program4()
        {
            InitializeComponent();
        }
        private void GetPackageInfo(GroundPackage package)
        {
            package.origen = int.Parse(origenInput.Text); //Precondtion: must contain text; Postcondition: None
            package.destination = int.Parse(destinationInput.Text);//Precondtion: must contain text; Postcondition: None
            package.length = double.Parse(lenghtInput.Text);//Precondtion: must contain text; Postcondition: None
            package.width = double.Parse(widthInput.Text);//Precondtion: must contain text; Postcondition: None
            package.height = double.Parse(heightInput.Text);//Precondtion: must contain text; Postcondition: None
            package.weight = double.Parse(weightInput.Text);//Precondtion: must contain text; Postcondition: None

        }
        //Precondition: Valid data entered
        //Postcondition: None
        private void addPackageButton_Click(object sender, EventArgs e)
        {
            GroundPackage inputPackage = new GroundPackage();
            {
                GetPackageInfo(inputPackage);
                packageInfo.Add(inputPackage);
                costListBox.Items.Add(inputPackage.CalcCost());

                origenInput.Clear(); // Clears the origen textbox
                destinationInput.Clear(); // Clears the destination textbox
                lenghtInput.Clear(); // Clears the length textbox
                widthInput.Clear(); // Clears width the textbox
                heightInput.Clear(); // Clears the height textbox
                weightInput.Clear();  // Clears the weight textbox

            }
        }
        private void costlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //Precondition: must have an entry in costlistbox
        //Postcondition: None
        private void detailsButton_Click(object sender, EventArgs e)
        {
            int index = costListBox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Package not Selected");// if no pakage is selected
            }
            else
            {
                MessageBox.Show(packageInfo[index].ToString());// if a pakage is selected
            }
        }
        //Precondition: None
        //Postcondition: sets destination to 40292
        private void sendToUofLButton_Click(object sender, EventArgs e)
        {
            int index = costListBox.SelectedIndex;
            if (index < 0)
            {
                origenInput.Clear();//clears origen text box
                destinationInput.Clear();// clears destination text box


                destinationInput.Text = "40292";
                MessageBox.Show("Package Reset");
            }
            else// if invalid does nothing
            {

            }

        }
        //Precondition: None
        //Postcondition: sets origen to 40292
        private void sendFromUofLButton_Click(object sender, EventArgs e)
        {
            int index = costListBox.SelectedIndex;
            if (index < 0)
            {
                origenInput.Clear();//clears origen text box
                destinationInput.Clear();// clears destination text box

                origenInput.Text = "40292";
                MessageBox.Show("Package Reset");
            }
            else//if invalid, do nothing
            {

            }
        }


    }
}
