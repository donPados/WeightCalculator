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
        public Double Diam1;  //{ Get, Set};
        public double Diamleng1;//="";
        double Numb = double.NaN;
        public Form1()
        {
            InitializeComponent();
            //Form1_Load();
            //string Diam; //= DiameterTextBox.Text;
            //Diam = DiameterTextBox.Text;
        }

        private void ChangeDiameter(object sender, EventArgs e)
        {
            if (Diamvalue(DiameterTextBox.Text))
            {
                Diam1 = Numb;// Convert.ToDouble(DiameterTextBox.Text);
                DiameterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                Diam1 = 0;
                DiameterTextBox.BackColor = Color.Red;
            }
            label7.Text = Convert.ToString(Calculator.DiameterCalculate(Diam1, Diamleng1));
        }
        private void ChangeDiameterLength(object sender, EventArgs e)
        {
            if (Diamvalue(DiameterLengthTextBox.Text))
            {
                Diamleng1 = Numb;// Convert.ToDouble(DiameterTextBox.Text);
                DiameterLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
            else
            {
                Diamleng1 = 0;
                DiameterLengthTextBox.BackColor = Color.Red;
            }
            label7.Text = Convert.ToString(Calculator.DiameterCalculate(Diam1, Diamleng1));
        }
        /// <summary>
        ///  Convert the text to double, first need public declaring Numb!
        ///  and return value is boolean
        /// </summary>
        private bool Diamvalue(string ItemValue)
        { 
            bool TryConvert = double.TryParse(ItemValue, out Numb);
            return TryConvert;
        }
        /*
            private void Form1_Load() //(object sender, EventArgs e)
        {
            // Creating and setting the properties of label
            Label Ll = new Label();
            Ll.AutoSize = true;
            Ll.Text = "Do you want to submit this project?";
            Ll.Location = new Point(222, 145);
            Ll.Font = new Font("French Script MT", 18);
            // Adding this label to form
            this.Controls.Add(Ll);

            // Creating and setting the properties of Button
            Button Mybutton = new Button();
            Mybutton.Location = new Point(225, 198);
            Mybutton.Text = "Submit";
            Mybutton.AutoSize = true;
            Mybutton.BackColor = Color.LightBlue;
            Mybutton.Padding = new Padding(6);
            Mybutton.Font = new Font("French Script MT", 18);
            Mybutton.Name = "myButton";

            Mybutton.Click += new EventHandler(Mybutton_Click);
            // Adding this button to form
            Controls.Add(Mybutton);

            // Creating and setting the properties of Button
            Button CancelButton = new Button();
            CancelButton.Location = new Point(360, 198);
            CancelButton.Text = "Cancel";
            CancelButton.AutoSize = true;
            CancelButton.BackColor = Color.LightPink;
            CancelButton.Padding = new Padding(6);
            CancelButton.Font = new Font("French Script MT", 18);

            CancelButton.Click += new EventHandler(CancelButton_Click);

            // Adding this button to form
            this.Controls.Add(CancelButton);
            LabelForm();
            TextBoxForm();
        }

        private void Mybutton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("myButton megnyomva másik helyen");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dynamic button is clicked");
            
        }

        //A labelformok:
        public void LabelForm()
        {
            //*
            Label Label1 = new Label();
            // Set  properties  
            Label1.Height = 30;
            Label1.Width = 100;
            Label1.BackColor = Color.LightSkyBlue;
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(10, 30);
            Label1.AutoSize = false;
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            Label1.Text = "Átmérő";
            Label1.Name = "Label1";
            Label1.Font = new Font("Georgia", 16);

            this.Controls.Add(Label1);


            Label Label2 = new Label();
            // Set properties  
            Label2.Height = 30;
            Label2.Width = 100;
            Label2.BackColor = Color.LightSkyBlue;
            Label2.ForeColor = Color.Black;
            Label2.Location = new Point(150, 30);
            Label2.AutoSize = false;
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            Label2.Text = "Hossz";
            Label2.Name = "Label2";
            Label2.Font = new Font("Georgia", 16);

            this.Controls.Add(Label2);


            Label Label3 = new Label();
            // Set  properties  
            Label3.Height = 30;
            Label3.Width = 100;
            Label3.BackColor = Color.LightSkyBlue;
            Label3.ForeColor = Color.Black;
            Label3.Location = new Point(300, 30);
            Label3.AutoSize = false;
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            Label3.Text = "Súly:";
            Label3.Name = "Label3";
            Label3.Font = new Font("Georgia", 16);

            this.Controls.Add(Label3);


            Label LabelFe = new Label();
            // Set  properties  
            LabelFe.Height = 20;
            LabelFe.Width = 75;
            LabelFe.BackColor = Color.LightSkyBlue;
            LabelFe.ForeColor = Color.Black;
            LabelFe.Location = new Point(300, 60);
            LabelFe.AutoSize = false;
            LabelFe.TextAlign = ContentAlignment.MiddleRight;
            LabelFe.Text = "Vas:";
            LabelFe.Name = "LabelFe";
            LabelFe.Font = new Font("Arial", 12);

            this.Controls.Add(LabelFe);


            Label LabelAl = new Label();
            // Set  properties  
            LabelAl.Height = 20;
            LabelAl.Width = 75;
            LabelAl.BackColor = Color.LightSkyBlue;
            LabelAl.ForeColor = Color.Black;
            LabelAl.Location = new Point(300, 80);
            LabelAl.AutoSize = false;
            LabelAl.TextAlign = ContentAlignment.MiddleRight;
            LabelAl.Text = "Alu:";
            LabelAl.Name = "LabelAl";
            LabelAl.Font = new Font("Arial", 12);

            this.Controls.Add(LabelAl);


            Label LabelCu = new Label();
            // Set  properties  
            LabelCu.Height = 20;
            LabelCu.Width = 75;
            LabelCu.BackColor = Color.LightSkyBlue;
            LabelCu.ForeColor = Color.Black;
            LabelCu.Location = new Point(300, 100);
            LabelCu.AutoSize = false;
            LabelCu.TextAlign = ContentAlignment.MiddleRight;
            LabelCu.Text = "Réz:";
            LabelCu.Name = "LabelCu";
            LabelCu.Font = new Font("Arial", 12);

            this.Controls.Add(LabelCu);


            Label LabelPlastic = new Label();
            // Set  properties  
            LabelPlastic.Height = 20;
            LabelPlastic.Width = 75;
            LabelPlastic.BackColor = Color.LightSkyBlue;
            LabelPlastic.ForeColor = Color.Black;
            LabelPlastic.Location = new Point(300, 120);
            LabelPlastic.AutoSize = false;
            LabelPlastic.TextAlign = ContentAlignment.MiddleCenter;
            LabelPlastic.Text = "Műanyag:";
            LabelPlastic.Name = "LabelPlastic";
            LabelPlastic.Font = new Font("Arial", 12);

            this.Controls.Add(LabelPlastic);


            //Az eredménylabelek:
            Label ResultLabelFe = new Label();
            // Set  properties  
            ResultLabelFe.Height = 20;
            ResultLabelFe.Width = 75;
            ResultLabelFe.BackColor = Color.LightGreen;
            ResultLabelFe.ForeColor = Color.Black;
            ResultLabelFe.Location = new Point(375, 60);
            ResultLabelFe.AutoSize = false;
            ResultLabelFe.TextAlign = ContentAlignment.MiddleCenter;
            ResultLabelFe.Text = "Fe";
            ResultLabelFe.Name = "ResultLabelFe";
            ResultLabelFe.Font = new Font("Arial", 12);

            this.Controls.Add(ResultLabelFe);


            Label ResultLabelAl = new Label();
            // Set  properties  
            ResultLabelAl.Height = 20;
            ResultLabelAl.Width = 75;
            ResultLabelAl.BackColor = Color.LightGreen;
            ResultLabelAl.ForeColor = Color.Black;
            ResultLabelAl.Location = new Point(375, 80);
            ResultLabelAl.AutoSize = false;
            ResultLabelAl.TextAlign = ContentAlignment.MiddleCenter;
            ResultLabelAl.Text = "Al";
            ResultLabelAl.Name = "ResultLabelAl";
            ResultLabelAl.Font = new Font("Arial", 12);

            this.Controls.Add(ResultLabelAl);



            Label ResultLabelCu = new Label();
            // Set  properties  
            ResultLabelCu.Height = 20;
            ResultLabelCu.Width = 75;
            ResultLabelCu.BackColor = Color.LightGreen;
            ResultLabelCu.ForeColor = Color.Black;
            ResultLabelCu.Location = new Point(375, 100);
            ResultLabelCu.AutoSize = false;
            ResultLabelCu.TextAlign = ContentAlignment.MiddleCenter;
            ResultLabelCu.Text = "Cu";
            ResultLabelCu.Name = "ResultLabelCu";
            ResultLabelCu.Font = new Font("Arial", 12);

            this.Controls.Add(ResultLabelCu);


            Label ResultLabelPlastic = new Label();
            // Set  properties  
            ResultLabelPlastic.Height = 20;
            ResultLabelPlastic.Width = 75;
            ResultLabelPlastic.BackColor = Color.LightGreen;
            ResultLabelPlastic.ForeColor = Color.Black;
            ResultLabelPlastic.Location = new Point(375, 120);
            ResultLabelPlastic.AutoSize = false;
            ResultLabelPlastic.TextAlign = ContentAlignment.MiddleCenter;
            ResultLabelPlastic.Text = "Müa";
            ResultLabelPlastic.Name = "ResultLabelPlastic";
            ResultLabelPlastic.Font = new Font("Arial", 12);

            this.Controls.Add(ResultLabelPlastic);
            //
        }


        //a szövegdobozok:
        public void TextBoxForm()
        {
            //az átmérő:
            TextBox DiameterTextBox = new TextBox();
            DiameterTextBox.Height = 30;
            DiameterTextBox.Width = 100;
            DiameterTextBox.BackColor = Color.LightGreen;
            DiameterTextBox.ForeColor = Color.Black;
            DiameterTextBox.Location = new Point(10, 60);
            DiameterTextBox.AutoSize = false;
            //DiameterTextBox.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleCenter;
            DiameterTextBox.Name = "DaimeterTextBox";
            DiameterTextBox.Font = new Font("Arial", 16);

            this.Controls.Add(DiameterTextBox);
            
            DiameterTextBox.TextChanged += new EventHandler(ChangeDiameter);
            
            //az átmérő hossza:
            TextBox DiameterLengthTextBox = new TextBox();
            DiameterLengthTextBox.Height = 30;
            DiameterLengthTextBox.Width = 100;
            DiameterLengthTextBox.BackColor = Color.LightGreen;
            DiameterLengthTextBox.ForeColor = Color.Black;
            DiameterLengthTextBox.Location = new Point(150, 60);
            DiameterLengthTextBox.AutoSize = false;
            //DiameterLengthTextBox.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleCenter;
            DiameterLengthTextBox.Name = "DiameterLengthTexthBox";
            DiameterLengthTextBox.Font = new Font("Arail", 16);

            this.Controls.Add(DiameterLengthTextBox);
            try
            {

                if (Double.Parse(DiameterLengthTextBox.Text) < 0)
                {
                    DiameterLengthTextBox.ForeColor = Color.Red;
                }
                else
                {
                    DiameterLengthTextBox.ForeColor = Color.Black;
                }
            }
            catch
            {
                // If there is an error, display the text using the system colors.
                DiameterTextBox.ForeColor = SystemColors.ControlText;
            }
            DiameterLengthTextBox.TextChanged += new EventHandler(ChangeDiameterLength);
        }

        private void DiameterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //
            // Detect the KeyEventArg's key enumerated constant.
            //
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("You pressed enter! Good job!");
            }
        }*/


    }
}

