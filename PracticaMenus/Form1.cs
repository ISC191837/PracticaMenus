using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetForm() {
            input1.Value = 0;
            input2.Value = 0;
            input3.Value = 0;
            input4.Value = 0;
            errorLabel.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        private void longitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Metros";
            controlLabel2.Text = "Centímetros";
            controlLabel3.Text = "Kilometros";
            controlLabel4.Text = "Yardas";
            resetForm();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Centigrados";
            controlLabel2.Text = "Kelvin";
            controlLabel3.Text = "Farenheit";
            controlLabel4.Visible = false;
            input4.Visible = false;
            resetForm();
        }

        private void divisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Peso";
            controlLabel2.Text = "Dolar";
            controlLabel3.Text = "Euros";
            controlLabel4.Visible = false;
            input4.Visible = false;
            resetForm();
        }

        private void masaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Libras";
            controlLabel2.Text = "Kilogramo";
            controlLabel3.Text = "Toneladas";
            controlLabel4.Visible = false;
            input4.Visible = false;
            resetForm();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
