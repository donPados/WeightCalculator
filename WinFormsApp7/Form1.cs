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
        /// <summary>
        /// declaration of a variables
        /// </summary>
        public Double FirstSize;  
        public double SecondSize;
        public double ThirdSize;
        public double FourthSize;
        double Numb = double.NaN;
        //
        public Form1()
        {
            InitializeComponent();
            //Form1_Load();
        }

                    //Diameter profil

        /// <summary>
        /// Diameter Textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDiameter(object sender, EventArgs e)
        {
            if (DataValue(DiameterTextBox.Text))
            {
                FirstSize = Numb;
                DiameterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                FirstSize = 0;
                DiameterTextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.DiameterCalculate(FirstSize, SecondSize));
        }
        private void AllLabelBackColorIsGray()
        {
            labelDiam1 .BackColor = Color.Gray;
            labelHexa1.BackColor = Color.Gray;
            labelBrick1.BackColor = Color.Gray;
            labelPipe1.BackColor = Color.Gray;
            labelHolSec1.BackColor = Color.Gray;
        }
        private void GotFocusDiamaterTextBox(object sender, EventArgs e)
        {
            if (labelDiam1.BackColor != Color.Green)
            {
                AllLabelBackColorIsGray();
                labelDiam1.BackColor = Color.Green;
            }
        }
        private void GotFocusDiameterLengthTextBox(object sender, EventArgs e)
        {
            SetAllLabelBackColor(sender);
        }
        private void SetAllLabelBackColor(object Akarmi)
        {
            labelDiam1.BackColor = Color.Gray;
            labelHexa1.BackColor = Color.Gray;
            labelBrick1.BackColor = Color.Gray;
            labelPipe1.BackColor = Color.Gray;
            labelHolSec1.BackColor = Color.Gray;
            Akarmi.BackColor = Color.Green;
        }
        
        /// <summary>
        /// DiameterLength Textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDiameterLength(object sender, EventArgs e)
        {
            if (DataValue(DiameterLengthTextBox.Text))
            {
                SecondSize = Numb;
                DiameterLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                SecondSize = 0;
                DiameterLengthTextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.DiameterCalculate(FirstSize, SecondSize));
        }


                        // Hexagon Profil

        /// <summary>
        /// Hexagon Size textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeHexa(object sender, EventArgs e)
        {
            if (DataValue(HexaTextBox.Text))
            {
                FirstSize = Numb;
                HexaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                FirstSize = 0;
                HexaTextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.HexaCalculate(FirstSize, SecondSize));
        }
        /// <summary>
        /// HexagonLength textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeHexaLength(object sender, EventArgs e)
        {
            if (DataValue(HexaLengthTextBox.Text))
            {
                SecondSize = Numb;
                HexaLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                SecondSize = 0;
                HexaLengthTextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.HexaCalculate(FirstSize, SecondSize));
        }

                        //Flat or Square Profil

        /// <summary>
        /// BrickWidth textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBrickWidth(object sender, EventArgs e)
        {
                if (DataValue(BrickWidthTextBox.Text))
                {
                    FirstSize = Numb;
                    BrickWidthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                }
                else
                {
                    FirstSize = 0;
                    BrickWidthTextBox.BackColor = Color.Red;
                }
                WeigthPrint(Calculator.BrickCalculate(FirstSize, SecondSize, ThirdSize));
        }
        /// <summary>
        /// BrickHeight textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBrickHeight(object sender, EventArgs e)
        {
            if (DataValue(BrickHeightTextBox.Text))
            {
                FirstSize = Numb;
                BrickHeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                FirstSize = 0;
                BrickHeightTextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.BrickCalculate(FirstSize, SecondSize, ThirdSize));
        }
        /// <summary>
        /// BrickLength textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeBrickLength(object sender, EventArgs e)
        {
            if (DataValue(BrickLengthTextBox.Text))
            {
                FirstSize = Numb;
                BrickLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                FirstSize = 0;
                BrickLengthTextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.BrickCalculate(FirstSize, SecondSize, ThirdSize));
        }

                            //Pipe Profil

        /// <summary>
        /// Pipe out diameter textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePipeDiam(object sender, EventArgs e)
        {
            if (DataValue(PipeDiamtextBox.Text))
            {
                FirstSize = Numb;
                PipeDiamtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                FirstSize = 0;
                PipeDiamtextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.PipeCalculate(FirstSize, SecondSize, ThirdSize));
        }
        /// <summary>
        /// Pipe wall textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePipeWall(object sender, EventArgs e)
        {
            if (DataValue(PipeWalltextBox.Text))
            {
                SecondSize = Numb;
                PipeWalltextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                SecondSize = 0;
                PipeWalltextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.PipeCalculate(FirstSize, SecondSize, ThirdSize));
        }
        /// <summary>
        /// Pipe Length textbox change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePipeLength(object sender, EventArgs e)
        {
            if (DataValue(PipeLengthtextBox.Text))
            {
                ThirdSize = Numb;
                PipeLengthtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                ThirdSize = 0;
                PipeLengthtextBox.BackColor = Color.Red;
            }
            WeigthPrint(Calculator.PipeCalculate(FirstSize, SecondSize, ThirdSize));
        }

                            
        /// <summary>
        /// Write the weigth to ResultLabel
        /// </summary>
        /// <param name="Volume"></param>
        private void WeigthPrint(double Volume)
        {
            labelFeResult.Text = Convert.ToString(Math.Round((Volume * 7.8 / 1000000), 2));
            labelAlResult.Text = Convert.ToString(Math.Round((Volume * 2.7 / 1000000), 2));
            labelCuResult.Text = Convert.ToString(Math.Round((Volume * 8.9 / 1000000), 2));
            labelPLResult.Text = Convert.ToString(Math.Round((Volume * 1.2 / 1000000), 2));
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
        }
    }
}

