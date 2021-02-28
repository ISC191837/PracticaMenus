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
        private int optionSelected;

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
            optionSelected = 1;
        }

        private void longitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Metros";
            controlLabel2.Text = "Centímetros";
            controlLabel3.Text = "Kilometros";
            controlLabel4.Text = "Yardas";
            controlLabel4.Visible = true;
            input4.Visible = true;
            optionSelected = 1;
            resetForm();
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Centigrados";
            controlLabel2.Text = "Kelvin";
            controlLabel3.Text = "Farenheit";
            controlLabel4.Visible = false;
            input4.Visible = false;
            optionSelected = 4;
            resetForm();
        }

        private void divisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Peso";
            controlLabel2.Text = "Dolar";
            controlLabel3.Text = "Euros";
            controlLabel4.Visible = false;
            input4.Visible = false;
            optionSelected = 2;
            resetForm();
        }

        private void masaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlLabel1.Text = "Libras";
            controlLabel2.Text = "Kilogramo";
            controlLabel3.Text = "Toneladas";
            controlLabel4.Visible = false;
            input4.Visible = false;
            optionSelected = 3;
            resetForm();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void convertLong() {
            float cm, km, y;
            float m = (float)input1.Value;

            cm = m * 100;
            km = m / 1000;
            y = (float)(m * 1.094);

            input2.Value = (decimal)cm;
            input3.Value = (decimal)km;
            input4.Value = (decimal)y;
        }

        private void convertCurrency() {
            float usa, eur;
            float mxn = (float)input1.Value;

            usa = (float)(mxn * 0.048);
            eur = (float)(mxn * 0.040);

            input2.Value = (decimal)usa;
            input3.Value = (decimal)eur;
        }

        private void convertMass() {
            float kg, t;
            float lb = (float)input1.Value;

            kg = (float)(lb * 0.453);
            t = (float)(lb * 0.000453);

            input2.Value = (decimal)kg;
            input3.Value = (decimal)t;
        }

        private void convertTemperature()
        {
            float k, f;
            float c = (float)input1.Value;

            k = (float)(c + 273.15);
            f = (float)((c * 9/5) + 32);

            input2.Value = (decimal)k;
            input3.Value = (decimal)f;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            switch (optionSelected) {
                case 1:
                    convertLong();
                    break;
                case 2:
                    convertCurrency();
                    break;
                case 3:
                    convertMass();
                    break;
                case 4:
                    convertTemperature();
                    break;
                default:
                    convertLong();
                    break;
            }
        }
    }
}
