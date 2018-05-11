using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 10-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Percentage Program
 * This program let's you enter what level you got and tells you what your mark would be in a percentage
*/

namespace PercentageProgramTivaR
{
    public partial class frmPercentageProgram : Form
    {
        public frmPercentageProgram()
        {
            InitializeComponent();
        }

        // Function: ConvertToPercent
        // Input: String level
        // Output: int percentage
        // Description: This function accepts a level of type string and returns the percentage equivalent as an integer.
        private int ConvertToPercent(String level)
        {
            int percentage;
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4-":
                    percentage = 87;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }

            return percentage;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Declare variables 
            string level;
            int mark;

            // Assign variable
            level = (txtUserLevel.Text);

            // Call the function
            mark = ConvertToPercent(level);

            // Show the message box
            MessageBox.Show("Level " + level + " is equivalent to " + mark + "%", "Percentage Program");
        }
    }
}
