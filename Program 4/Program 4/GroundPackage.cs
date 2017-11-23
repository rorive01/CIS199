// Raymmond Rivera
// Program 4
// 4-24-16
// CIS 199-01
// to take the known information of the package and come up with a cost while still tracking the details of the package, then catalog that info.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
   public class GroundPackage
    {
        public int origen;// 00000 - 99999
        public int destination;// 00000 - 99999
        public double length;// > 0
        public double width;// > 0
        public double height;// > 0
        public double weight;// > 0 
        public int zoneDistance;// > 0
       //Constructor
        public GroundPackage(int o = 0, int d = 0, double l = 0, double w = 0, double h = 0, double wei = 0, int zd = 0)
   {      
       package(o, d, l, w, h, wei, zd);// Validates groundpackage by invoking package
    }
    public void package(int o, int d, double l, double w, double h, double wei, int zd)
{
    OrigenZip = o; // set origenzip property
    DestinationZip = d; // set destinationzip property
    Length = l; // set the Length property
    Width = w; // set the Width property
    Height = h; //set the Height property
    Weight = wei; // set the weight property

}
    public int OrigenZip// Origen zip code property
    {
        //Precondition: None
        //Postcondition: the origen has been returned
        get
        {
            return origen;
        }
        //Precondition: 00000 < value <= 99999
        //Postcondition: the origen zip has been set to the input value
        set
        {
            if (value > 00000 && value <= 99999)
            {
                origen = value;
            }
            else// when invalid do nothing
            {
                
            }
        }
    }
        public int DestinationZip// Destination zip code property
        {
            //Precondition: None
            //Postcondition: the destinationzip has been returned
            get
            {
                return destination;
            }
            //Precondition: 00000 < value <= 99999
            //Postcondition: the origen zip has been set to the input value
            set
            {
                if (value > 00000 && value <= 99999)
                {
                    destination = value;
                }
                else// when invalid, do nothing
                {

                }
            }
        }
        public double Length// Length property
        {
            //Precondition: None
            //PostConidtion: the length has been returned
            get
            {
                return length;
            }
            //Precondition: 0 < value
            //Postconditon: the length has been set to input value
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else// when invalid, do nothing
                {

                }
            }
        }
        public double Width// Width Property
        {
            //Postcondition: None
            //Precondition: the width has been returned
            get
            {
                return width;
            }
            //Precondition: 0 < value
            //Postcondition: the width has been set to the input value
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else// when invalid, do nothing
                {

                }
            }
        }
        public double Height // Height Property
        {
            //Preconition: None
            //Postcondition: the height has been returned
            get
            {
                return height;
            }
            //Precondition: 0 < value
            //Postcondition: the height has been set to the input value
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else// when invalid, do nothing
                {

                }
            }
        }
       public double Weight // Weight Property
        {
           //Precondition: None
           //Postcondition: the weight has been returned
            get
            {
                return weight;
            }
           //Precondition: 0 < value
           //Postcondition: the weight has been set to the specified value
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else// when invalid, do nothing
                {

                }
            }
        }
        public int ZoneDistance// property to determine ditance between zones
        {
            //Precondtion: Origen and destination input values
            //Postcondition: return zonedistance
            //read - only
            get
            {
                int origenFirstDigit = (int)(origen.ToString()[0]); // gets the first digit from origen value
                int destinationFirstDigit = (int)(destination.ToString()[0]); // gets the first digit from the detination value
                int zonedistance = (Math.Abs(origenFirstDigit)) - (Math.Abs(destinationFirstDigit)); // gets the ditance from between values
                int abszoneDistance = Math.Abs(zonedistance);// makes the number positive
                return zoneDistance;
            }

        }
        public double CalcCost() // method to calculate the cost 
        {
            double Cost;
            Cost = .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight);
            return  Cost;
        }

        public override string ToString()
        {
            string packageData; // holds package details
            packageData = "Origen Zip Code:" + OrigenZip.ToString("D5") + System.Environment.NewLine + "Destination Zip Code:" + DestinationZip.ToString("D5") + System.Environment.NewLine + "Zone Distance:" + ZoneDistance.ToString() + System.Environment.NewLine + "Length:" + Length.ToString() + System.Environment.NewLine + "Width: " + Width.ToString() + System.Environment.NewLine + "Height:" + Height.ToString() + System.Environment.NewLine + "Weight:" + Weight.ToString();
            return packageData;
        }

      }
  }



