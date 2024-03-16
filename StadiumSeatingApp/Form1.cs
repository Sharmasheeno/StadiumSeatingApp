using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeatingApp
{
    public partial class Form1 : Form
    {
        private const int ClassAPrice = 15;
        private const int ClassBPrice = 12;
        private const int ClassCPrice = 9;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Parse the number of tickets sold from the text boxes
            int ticketsA = int.Parse(classATextBox.Text);
            int ticketsB = int.Parse(classBTextBox.Text);
            int ticketsC = int.Parse(classCTextBox.Text);

            // Calculate the income for each class
            int incomeA = ticketsA * ClassAPrice;
            int incomeB = ticketsB * ClassBPrice;
            int incomeC = ticketsC * ClassCPrice;

            // Calculate the total revenue
            int totalRevenue = incomeA + incomeB + incomeC;

            // Display the income generated from each class of ticket sales
            lblclassA.Text = "Class A Income:"+incomeA.ToString("c");
            lblclassB.Text = $"Class B Income: ${incomeB}";
            lblclassC.Text = $"Class C Income: ${incomeC}";

            // Display the total revenue generated
            lblTotalRevenue.Text = $"Total Revenue: ${totalRevenue}";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            classATextBox.Clear();
            classBTextBox.Clear();
            classCTextBox.Clear();
            lblclassA.Text = "";
            lblclassB.Text = "";
            lblclassC.Text = "";
            lblTotalRevenue.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
