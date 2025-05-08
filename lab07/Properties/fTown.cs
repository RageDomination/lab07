using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static lab07.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab07.Properties
{
    public partial class fTown : Form
    {
        private Town town;

        public fTown(ref Town town)
        {
            InitializeComponent();
            this.town = town;
            textBox1.Text = town.Name;
            textBox2.Text = town.Country;
            textBox3.Text = town.Region;
            textBox4.Text = town.Population.ToString();
            textBox5.Text = town.YearIncome.ToString();
            textBox6.Text = town.Square.ToString();
            checkBox1.Checked = town.HasPort;
            checkBox2.Checked = town.HasAirport;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            town.Name = textBox1.Text;
            town.Country = textBox2.Text;
            town.Region = textBox3.Text;
            town.Population = int.Parse(textBox4.Text);
            town.YearIncome = double.Parse(textBox5.Text);
            town.Square = double.Parse(textBox6.Text);
            town.HasPort = checkBox1.Checked;
            town.HasAirport = checkBox2.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }


}
