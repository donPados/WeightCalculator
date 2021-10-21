using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLibrary2;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Double Diam1;  
        public double Diamleng1;
        double Numb = double.NaN;
        public Form1()
        {
            InitializeComponent();
            //Form1_Load();
        }

        private void ChangeDiameter(object sender, EventArgs e)
        {
            if (DataValue(DiameterTextBox.Text))
            {
                Diam1 = Numb;
                DiameterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                Diam1 = 0;
                DiameterTextBox.BackColor = Color.Red;
            }
            PrintWeightDiam();
        }
        private void ChangeDiameterLength(object sender, EventArgs e)
        {
            if (DataValue(DiameterLengthTextBox.Text))
            {
                Diamleng1 = Numb;
                DiameterLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                Diamleng1 = 0;
                DiameterLengthTextBox.BackColor = Color.Red;
            }
            PrintWeightDiam();
        }
        private void PrintWeightDiam()
        {
            double Volume = Calculator.DiameterCalculate(Diam1, Diamleng1);
            label7.Text = Convert.ToString(Math.Round((Volume * 7.8 / 1000000), 2));
            label8.Text = Convert.ToString(Math.Round((Volume * 2.7 / 1000000),2));
            label9.Text = Convert.ToString(Math.Round((Volume * 8.9 / 1000000),2));
            label10.Text = Convert.ToString(Math.Round((Volume * 1.2 / 1000000),2));
        }
        private void ChangeHexa(object sender, EventArgs e)
        {
            if (DataValue(HexaTextBox.Text))
            {
                Diam1 = Numb;
                HexaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                Diam1 = 0;
                HexaTextBox.BackColor = Color.Red;
            }
            PrintWeightHexa();
        }
        private void ChangeHexaLength(object sender, EventArgs e)
        {
            if (DataValue(HexaLengthTextBox.Text))
            {
                Diamleng1 = Numb;
                HexaLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                Diamleng1 = 0;
                HexaLengthTextBox.BackColor = Color.Red;
            }
            PrintWeightHexa();
        }
        private void PrintWeightHexa()
        {
            double Volume = Calculator.HexaCalculate(Diam1, Diamleng1);
            label11.Text = Convert.ToString(Math.Round((Volume * 7.8 / 1000000), 2));
            label12.Text = Convert.ToString(Math.Round((Volume * 2.7 / 1000000), 2));
            label13.Text = Convert.ToString(Math.Round((Volume * 8.9 / 1000000), 2));
            label14.Text = Convert.ToString(Math.Round((Volume * 1.2 / 1000000), 2));
        }
        /// <summary>
        ///  Convert the text to double, and put in Numb. But first need public declaring Numb!
        ///  and return value is True if convert is sucessfull. Else return False
        /// </summary>
        private bool DataValue(string ItemValue)
        { 
            bool TryConvert = double.TryParse(ItemValue, out Numb);
            return TryConvert;
        }
        private void PressExitButton(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
    }
}

