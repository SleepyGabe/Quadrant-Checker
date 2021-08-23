using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTFI1B_Parinas_Quadrants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //Main Operation: Recieve inputs for X and Y coordinates and determine which quadrant they belong to.
            //1.) Declare Variables for 1st input and 2nd input.
            float Coord1, Coord2;

            //2A.) Check text boxes for blank inputs.
            //2B.) Declare variables for X value and Y value.
            bool XValue, YValue;

            XValue = float.TryParse(XCoord.Text, out Coord1);

            if (XValue == false)
            {
                MessageBox.Show("Please enter a NUMBER for the X-Value.");
                XCoord.Clear();
                XCoord.Select();
                return;
            }

            YValue = float.TryParse(YCoord.Text, out Coord2);

            if (YValue == false)
            {
                MessageBox.Show("Please enter a NUMBER for the Y-Value.");
                YCoord.Clear();
                YCoord.Select();
                return;
            }

            //3.) Retrieve User's inputs.
            Coord1 = float.Parse(XCoord.Text);
            Coord2 = float.Parse(YCoord.Text);

            //4A.) Set conditions that the input must satisfy to be included in each quadrant.
            //4B.) Check if user's input satisfies any of the conditions.
            //4C.) Give appropriate output based on conditions satisfied.
            if (Coord1 > 0 && Coord2 > 0)
            {
                QuadOut.Text = "1st Quadrant";
            }
            else if (Coord1 < 0 && Coord2 > 0)
            {
                QuadOut.Text = "2nd Quadrant";
            }
            else if (Coord1 < 0 && Coord2 < 0)
            {
                QuadOut.Text = "3rd Quadrant";
            }
            else if (Coord1 > 0 && Coord2 < 0)
            {
                QuadOut.Text = "4th Quadrant";
            }
            else if (Coord1 != 0 && Coord2 == 0)
            {
                QuadOut.Text = "On X-Axis";
            }
            else if (Coord1 == 0 && Coord2 != 0)
            {
                QuadOut.Text = "On Y-Axis";
            }
            else if (Coord1 == 0 && Coord2 == 0)
            {
                QuadOut.Text = "Point of origin";
            }
            else
            {
                return;
            }

        }
    }
}
