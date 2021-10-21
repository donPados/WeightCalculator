using System;

namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiameterTextBox = new System.Windows.Forms.TextBox();
            this.DiameterLengthTextBox = new System.Windows.Forms.TextBox();
            this.LabelDiam2 = new System.Windows.Forms.Label();
            this.labelDiam3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.HexaLengthTextBox = new System.Windows.Forms.TextBox();
            this.HexaTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.labelHexa2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.labelDiam1 = new System.Windows.Forms.Label();
            this.labelHexa1 = new System.Windows.Forms.Label();
            this.labelHexa3 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDiam1
            // 
            this.labelDiam1.BackColor = System.Drawing.Color.Aqua;
            this.labelDiam1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiam1.Location = new System.Drawing.Point(10, -1);
            this.labelDiam1.Name = "labelDiam1";
            this.labelDiam1.Size = new System.Drawing.Size(126, 24);
            this.labelDiam1.TabIndex = 46;
            this.labelDiam1.Text = "Átmérő";
            this.labelDiam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiameterTextBox
            // 
            this.DiameterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DiameterTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiameterTextBox.Location = new System.Drawing.Point(10, 36);
            this.DiameterTextBox.Name = "DiameterTextBox";
            this.DiameterTextBox.Size = new System.Drawing.Size(60, 24);
            this.DiameterTextBox.TabIndex = 1;
            this.DiameterTextBox.TextChanged += new System.EventHandler(this.ChangeDiameter);
            // 
            // DiameterLengthTextBox
            // 
            this.DiameterLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DiameterLengthTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DiameterLengthTextBox.Location = new System.Drawing.Point(76, 36);
            this.DiameterLengthTextBox.Name = "DiameterLengthTextBox";
            this.DiameterLengthTextBox.Size = new System.Drawing.Size(60, 24);
            this.DiameterLengthTextBox.TabIndex = 2;
            this.DiameterLengthTextBox.TextChanged += new System.EventHandler(this.ChangeDiameterLength);
            // 
            // LabelDiam2
            // 
            this.LabelDiam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelDiam2.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDiam2.Location = new System.Drawing.Point(10, 21);
            this.LabelDiam2.Name = "LabelDiam2";
            this.LabelDiam2.Size = new System.Drawing.Size(60, 12);
            this.LabelDiam2.TabIndex = 0;
            this.LabelDiam2.Text = "Átmérő";
            this.LabelDiam2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDiam3
            // 
            this.labelDiam3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelDiam3.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiam3.Location = new System.Drawing.Point(76, 23);
            this.labelDiam3.Name = "labelDiam3";
            this.labelDiam3.Size = new System.Drawing.Size(60, 12);
            this.labelDiam3.TabIndex = 0;
            this.labelDiam3.Text = "Hossz";
            this.labelDiam3.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            
            // 
            // labelHexa1
            // 
            this.labelHexa1.BackColor = System.Drawing.Color.Aqua;
            this.labelHexa1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHexa1.Location = new System.Drawing.Point(10, 62);
            this.labelHexa1.Name = "labelHexa1";
            this.labelHexa1.Size = new System.Drawing.Size(126, 24);
            this.labelHexa1.TabIndex = 0;
            this.labelHexa1.Text = "Hatszög";
            this.labelHexa1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HexaTextBox
            // 
            this.HexaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HexaTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexaTextBox.Location = new System.Drawing.Point(10, 101);
            this.HexaTextBox.Name = "HexaTextBox";
            this.HexaTextBox.Size = new System.Drawing.Size(60, 24);
            this.HexaTextBox.TabIndex = 22;
            this.HexaTextBox.TextChanged += new System.EventHandler(this.ChangeHexa);
            // 
            // HexaLengthTextBox
            // 
            this.HexaLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HexaLengthTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexaLengthTextBox.Location = new System.Drawing.Point(76, 101);
            this.HexaLengthTextBox.Name = "HexaLengthTextBox";
            this.HexaLengthTextBox.Size = new System.Drawing.Size(60, 24);
            this.HexaLengthTextBox.TabIndex = 23;
            this.HexaLengthTextBox.TextChanged += new System.EventHandler(this.ChangeHexaLength);
            // 
            // labelHexa2
            // 
            this.labelHexa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHexa2.Location = new System.Drawing.Point(12, 87);
            this.labelHexa2.Name = "labelHexa2";
            this.labelHexa2.Size = new System.Drawing.Size(60, 12);
            this.labelHexa2.TabIndex = 0;
            this.labelHexa2.Text = "Laptáv";
            this.labelHexa2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHexa3
            // 
            this.labelHexa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHexa3.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHexa3.Location = new System.Drawing.Point(76, 86);
            this.labelHexa3.Name = "labelHexa3";
            this.labelHexa3.Size = new System.Drawing.Size(60, 13);
            this.labelHexa3.TabIndex = 48;
            this.labelHexa3.Text = "Hossz";
            this.labelHexa3.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            
            



            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(309, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vas";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(348, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alu";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(387, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Réz";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(426, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Műa";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(309, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(348, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(387, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "label8";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(426, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kilépés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PressExitButton);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(309, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "label7";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(348, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "label8";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(387, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "label8";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(426, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "label7";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(309, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "label8";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.Location = new System.Drawing.Point(348, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "label7";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.Location = new System.Drawing.Point(387, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 20);
            this.label17.TabIndex = 14;
            this.label17.Text = "label8";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(426, 165);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "label7";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(426, 239);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = "label8";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label20.Location = new System.Drawing.Point(387, 239);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "label7";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label21.Location = new System.Drawing.Point(348, 239);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 20);
            this.label21.TabIndex = 18;
            this.label21.Text = "label8";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label22.Location = new System.Drawing.Point(309, 239);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 20);
            this.label22.TabIndex = 19;
            this.label22.Text = "label7";

            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox3.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(76, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 24);
            this.textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox4.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(10, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 24);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox5.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(74, 239);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(60, 24);
            this.textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox6.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(8, 239);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 24);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox7.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(75, 305);
            this.textBox7.MaximumSize = new System.Drawing.Size(60, 25);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(60, 24);
            this.textBox7.TabIndex = 29;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox8.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(9, 305);
            this.textBox8.MaximumSize = new System.Drawing.Size(60, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(60, 24);
            this.textBox8.TabIndex = 28;

            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label25.Location = new System.Drawing.Point(76, 150);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 12);
            this.label25.TabIndex = 32;
            this.label25.Text = "magasság";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label26.Location = new System.Drawing.Point(10, 151);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 12);
            this.label26.TabIndex = 33;
            this.label26.Text = "Lapos";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label27.Location = new System.Drawing.Point(74, 224);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 12);
            this.label27.TabIndex = 34;
            this.label27.Text = "Fal";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label29.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(75, 288);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 12);
            this.label29.TabIndex = 36;
            this.label29.Text = "magasság";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label30.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(9, 288);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 12);
            this.label30.TabIndex = 37;
            this.label30.Text = "Szélesség";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox9.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.Location = new System.Drawing.Point(207, 305);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 24);
            this.textBox9.TabIndex = 39;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox10.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox10.Location = new System.Drawing.Point(141, 305);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(60, 24);
            this.textBox10.TabIndex = 38;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox11.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox11.Location = new System.Drawing.Point(141, 239);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(60, 24);
            this.textBox11.TabIndex = 40;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox12.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox12.Location = new System.Drawing.Point(142, 165);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(60, 24);
            this.textBox12.TabIndex = 41;
            this.textBox12.Text = "6000";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label33.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(140, 288);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(60, 12);
            this.label33.TabIndex = 44;
            this.label33.Text = "fal";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.Aqua;
            this.label37.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label37.Location = new System.Drawing.Point(10, 126);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(191, 24);
            this.label37.TabIndex = 49;
            this.label37.Text = "Lapos";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label38.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label38.Location = new System.Drawing.Point(142, 150);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 13);
            this.label38.TabIndex = 50;
            this.label38.Text = "Hossz";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Aqua;
            this.label31.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(12, 200);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(191, 24);
            this.label31.TabIndex = 51;
            this.label31.Text = "Lapos";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label28.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(12, 224);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 12);
            this.label28.TabIndex = 52;
            this.label28.Text = "Átmérő";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label32.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(142, 224);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(60, 12);
            this.label32.TabIndex = 53;
            this.label32.Text = "Hossz";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label34
            // 
            this.label34.BackColor = System.Drawing.Color.Aqua;
            this.label34.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(8, 266);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(259, 24);
            this.label34.TabIndex = 54;
            this.label34.Text = "Zártszelvény";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label39.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label39.Location = new System.Drawing.Point(207, 290);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 13);
            this.label39.TabIndex = 55;
            this.label39.Text = "Hossz";
            this.label39.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label40.Location = new System.Drawing.Point(426, 305);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 20);
            this.label40.TabIndex = 58;
            this.label40.Text = "label8";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label41.Location = new System.Drawing.Point(387, 305);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(33, 20);
            this.label41.TabIndex = 59;
            this.label41.Text = "label7";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label42.Location = new System.Drawing.Point(348, 305);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(33, 20);
            this.label42.TabIndex = 56;
            this.label42.Text = "label8";
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label43.Location = new System.Drawing.Point(309, 305);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(33, 20);
            this.label43.TabIndex = 57;
            this.label43.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 341);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.labelHexa3);
            this.Controls.Add(this.labelHexa1);
            this.Controls.Add(this.labelDiam1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.labelHexa2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.HexaLengthTextBox);
            this.Controls.Add(this.HexaTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDiam3);
            this.Controls.Add(this.LabelDiam2);
            this.Controls.Add(this.DiameterLengthTextBox);
            this.Controls.Add(this.DiameterTextBox);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Súly számoló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox DiameterTextBox;
        private System.Windows.Forms.TextBox DiameterLengthTextBox;
        private System.Windows.Forms.Label LabelDiam2;
        private System.Windows.Forms.Label labelDiam3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox HexaLengthTextBox;
        private System.Windows.Forms.TextBox HexaTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label labelHexa2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label labelDiam1;
        private System.Windows.Forms.Label labelHexa1;
        private System.Windows.Forms.Label labelHexa3;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
    }
}

