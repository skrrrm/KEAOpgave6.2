using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelInfo.Text = "Write a name, and we'll check if we have it.";
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            // one way to initialize array
            string[] firstNames1 = new string[10];

            // adding names to array
            firstNames1[0] = "Lone";
            firstNames1[1] = "Lene";
            firstNames1[2] = "Peter";
            firstNames1[3] = "Hans";
            firstNames1[4] = "Karl";
            firstNames1[5] = "Børge";
            firstNames1[6] = "Egon";
            firstNames1[7] = "Bente";
            firstNames1[8] = "Linda";
            firstNames1[9] = "Gerda";

            // another way to initialize arrays
            string[] firstNames = { "Lone", "Lene", "Peter", "Hans", "Karl", "Børge", "Egon", "Bente", "Linda", "Gerda" };

            // going through firstNames array
            for (int i = 0; i < firstNames.Length; i++)
            {
                // if input fits with an entry in firstNames, also trims input of spaces
                if (firstNames[i] == textBoxName.Text.Trim())
                {
                    labelInfo.Text = "We do have the name!"; // prints to label
                }
            }
        }
    }
}
