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
            //string[] firstNames = new string[10];

            // adding names to array
            //firstNames[0] = "Lone";
            //firstNames[1] = "Lene";
            //firstNames[2] = "Peter";
            //firstNames[3] = "Hans";
            //firstNames[4] = "Karl";
            //firstNames[5] = "Børge";
            //firstNames[6] = "Egon";
            //firstNames[7] = "Bente";
            //firstNames[8] = "Linda";
            //firstNames[9] = "Gerda";

            // another way to initialize arrays
            string[] firstNames = { "Lone", "Lene", "Peter", "Hans", "Karl", "Børge", "Egon", "Bente", "Linda", "Gerda" };

            for (int i = 0; i < firstNames.Length; i++) // going through firstNames array
            {
                if (firstNames[i] == textBoxName.Text.Trim()) // if input fits with an entry in firstNames
                {
                    labelInfo.Text = "We do have the name!"; // prints to label
                }
            }

        }
    }
}
