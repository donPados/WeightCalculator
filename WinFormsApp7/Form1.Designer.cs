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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitButton = new System.Windows.Forms.Button();
            this.DiameterTextBox = new System.Windows.Forms.TextBox();
            this.DiameterLengthTextBox = new System.Windows.Forms.TextBox();
            this.HexaTextBox = new System.Windows.Forms.TextBox();
            this.HexaLengthTextBox = new System.Windows.Forms.TextBox();
            this.BrickWidthTextBox = new System.Windows.Forms.TextBox();
            this.BrickHeightTextBox = new System.Windows.Forms.TextBox();
            this.BrickLengthTextBox = new System.Windows.Forms.TextBox();
            this.PipeDiamtextBox = new System.Windows.Forms.TextBox();
            this.PipeWalltextBox = new System.Windows.Forms.TextBox();
            this.PipeLengthtextBox = new System.Windows.Forms.TextBox();
            this.HolSecWidthtextBox = new System.Windows.Forms.TextBox();
            this.HolSecHeigthtextBox = new System.Windows.Forms.TextBox();
            this.HolSecWalltextBox = new System.Windows.Forms.TextBox();
            this.HolSecLengthtextBox = new System.Windows.Forms.TextBox();
            this.labelDiam1 = new System.Windows.Forms.Label();
            this.LabelDiam2 = new System.Windows.Forms.Label();
            this.labelDiam3 = new System.Windows.Forms.Label();
            this.labelHexa1 = new System.Windows.Forms.Label();
            this.labelHexa2 = new System.Windows.Forms.Label();
            this.labelHexa3 = new System.Windows.Forms.Label();
            this.labelBrick1 = new System.Windows.Forms.Label();
            this.labelBrick2 = new System.Windows.Forms.Label();
            this.labelBrick3 = new System.Windows.Forms.Label();
            this.labelBrick4 = new System.Windows.Forms.Label();
            this.labelPipe1 = new System.Windows.Forms.Label();
            this.labelPipe2 = new System.Windows.Forms.Label();
            this.labelPipe3 = new System.Windows.Forms.Label();
            this.labelPipe4 = new System.Windows.Forms.Label();
            this.labelHolSec1 = new System.Windows.Forms.Label();
            this.labelHolSec2 = new System.Windows.Forms.Label();
            this.labelHolSec3 = new System.Windows.Forms.Label();
            this.labelHolSec4 = new System.Windows.Forms.Label();
            this.labelHolSec5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFeResult = new System.Windows.Forms.Label();
            this.labelAlResult = new System.Windows.Forms.Label();
            this.labelCuResult = new System.Windows.Forms.Label();
            this.labelPLResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(192, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Kilépés";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.PressExitButton);
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
            this.DiameterTextBox.GotFocus += new System.EventHandler(this.GotFocusDiamaterTextBox);
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
            this.DiameterTextBox.GotFocus += new System.EventHandler(this.GotFocusDiameterLengthTextBox);
            // 
            // HexaTextBox
            // 
            this.HexaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HexaTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexaTextBox.Location = new System.Drawing.Point(10, 101);
            this.HexaTextBox.Name = "HexaTextBox";
            this.HexaTextBox.Size = new System.Drawing.Size(60, 24);
            this.HexaTextBox.TabIndex = 3;
            this.HexaTextBox.TextChanged += new System.EventHandler(this.ChangeHexa);
            // 
            // HexaLengthTextBox
            // 
            this.HexaLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HexaLengthTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexaLengthTextBox.Location = new System.Drawing.Point(76, 101);
            this.HexaLengthTextBox.Name = "HexaLengthTextBox";
            this.HexaLengthTextBox.Size = new System.Drawing.Size(60, 24);
            this.HexaLengthTextBox.TabIndex = 4;
            this.HexaLengthTextBox.TextChanged += new System.EventHandler(this.ChangeHexaLength);
            // 
            // BrickWidthTextBox
            // 
            this.BrickWidthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BrickWidthTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrickWidthTextBox.Location = new System.Drawing.Point(10, 166);
            this.BrickWidthTextBox.Name = "BrickWidthTextBox";
            this.BrickWidthTextBox.Size = new System.Drawing.Size(60, 24);
            this.BrickWidthTextBox.TabIndex = 5;
            this.BrickWidthTextBox.TextChanged += new System.EventHandler(this.ChangeBrickWidth);
            // 
            // BrickHeightTextBox
            // 
            this.BrickHeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BrickHeightTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrickHeightTextBox.Location = new System.Drawing.Point(76, 165);
            this.BrickHeightTextBox.Name = "BrickHeightTextBox";
            this.BrickHeightTextBox.Size = new System.Drawing.Size(60, 24);
            this.BrickHeightTextBox.TabIndex = 6;
            this.BrickHeightTextBox.TextChanged += new System.EventHandler(this.ChangeBrickHeight);
            // 
            // BrickLengthTextBox
            // 
            this.BrickLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BrickLengthTextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrickLengthTextBox.Location = new System.Drawing.Point(142, 165);
            this.BrickLengthTextBox.Name = "BrickLengthTextBox";
            this.BrickLengthTextBox.Size = new System.Drawing.Size(60, 24);
            this.BrickLengthTextBox.TabIndex = 7;
            this.BrickLengthTextBox.TextChanged += new System.EventHandler(this.ChangeBrickLength);
            // 
            // PipeDiamtextBox
            // 
            this.PipeDiamtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PipeDiamtextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PipeDiamtextBox.Location = new System.Drawing.Point(8, 239);
            this.PipeDiamtextBox.Name = "PipeDiamtextBox";
            this.PipeDiamtextBox.Size = new System.Drawing.Size(60, 24);
            this.PipeDiamtextBox.TabIndex = 8;
            this.PipeDiamtextBox.TextChanged += new System.EventHandler(this.ChangePipeDiam);
            // 
            // PipeWalltextBox
            // 
            this.PipeWalltextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PipeWalltextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PipeWalltextBox.Location = new System.Drawing.Point(74, 239);
            this.PipeWalltextBox.Name = "PipeWalltextBox";
            this.PipeWalltextBox.Size = new System.Drawing.Size(60, 24);
            this.PipeWalltextBox.TabIndex = 9;
            this.PipeWalltextBox.TextChanged += new System.EventHandler(this.ChangePipeWall);
            // 
            // PipeLengthtextBox
            // 
            this.PipeLengthtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PipeLengthtextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PipeLengthtextBox.Location = new System.Drawing.Point(141, 239);
            this.PipeLengthtextBox.Name = "PipeLengthtextBox";
            this.PipeLengthtextBox.Size = new System.Drawing.Size(60, 24);
            this.PipeLengthtextBox.TabIndex = 10;
            this.PipeLengthtextBox.TextChanged += new System.EventHandler(this.ChangePipeLength);
            // 
            // HolSecWidthtextBox
            // 
            this.HolSecWidthtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HolSecWidthtextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HolSecWidthtextBox.Location = new System.Drawing.Point(9, 305);
            this.HolSecWidthtextBox.MaximumSize = new System.Drawing.Size(60, 25);
            this.HolSecWidthtextBox.Name = "HolSecWidthtextBox";
            this.HolSecWidthtextBox.Size = new System.Drawing.Size(60, 24);
            this.HolSecWidthtextBox.TabIndex = 11;
            // 
            // HolSecHeigthtextBox
            // 
            this.HolSecHeigthtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HolSecHeigthtextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HolSecHeigthtextBox.Location = new System.Drawing.Point(75, 305);
            this.HolSecHeigthtextBox.MaximumSize = new System.Drawing.Size(60, 25);
            this.HolSecHeigthtextBox.Name = "HolSecHeigthtextBox";
            this.HolSecHeigthtextBox.Size = new System.Drawing.Size(60, 24);
            this.HolSecHeigthtextBox.TabIndex = 12;
            // 
            // HolSecWalltextBox
            // 
            this.HolSecWalltextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HolSecWalltextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HolSecWalltextBox.Location = new System.Drawing.Point(141, 305);
            this.HolSecWalltextBox.Name = "HolSecWalltextBox";
            this.HolSecWalltextBox.Size = new System.Drawing.Size(60, 24);
            this.HolSecWalltextBox.TabIndex = 13;
            // 
            // HolSecLengthtextBox
            // 
            this.HolSecLengthtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HolSecLengthtextBox.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HolSecLengthtextBox.Location = new System.Drawing.Point(207, 305);
            this.HolSecLengthtextBox.Name = "HolSecLengthtextBox";
            this.HolSecLengthtextBox.Size = new System.Drawing.Size(60, 24);
            this.HolSecLengthtextBox.TabIndex = 14;
            // 
            // labelDiam1
            // 
            this.labelDiam1.BackColor = System.Drawing.Color.Aqua;
            this.labelDiam1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiam1.Location = new System.Drawing.Point(10, -1);
            this.labelDiam1.Name = "labelDiam1";
            this.labelDiam1.Size = new System.Drawing.Size(126, 24);
            this.labelDiam1.TabIndex = 0;
            this.labelDiam1.Text = "Átmérő";
            this.labelDiam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelHexa3.TabIndex = 0;
            this.labelHexa3.Text = "Hossz";
            this.labelHexa3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBrick1
            // 
            this.labelBrick1.BackColor = System.Drawing.Color.Aqua;
            this.labelBrick1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrick1.Location = new System.Drawing.Point(10, 126);
            this.labelBrick1.Name = "labelBrick1";
            this.labelBrick1.Size = new System.Drawing.Size(191, 24);
            this.labelBrick1.TabIndex = 0;
            this.labelBrick1.Text = "Lapos";
            this.labelBrick1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBrick2
            // 
            this.labelBrick2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelBrick2.Location = new System.Drawing.Point(10, 151);
            this.labelBrick2.Name = "labelBrick2";
            this.labelBrick2.Size = new System.Drawing.Size(60, 12);
            this.labelBrick2.TabIndex = 0;
            this.labelBrick2.Text = "Szélesség";
            this.labelBrick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBrick3
            // 
            this.labelBrick3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelBrick3.Location = new System.Drawing.Point(76, 150);
            this.labelBrick3.Name = "labelBrick3";
            this.labelBrick3.Size = new System.Drawing.Size(60, 12);
            this.labelBrick3.TabIndex = 0;
            this.labelBrick3.Text = "magasság";
            this.labelBrick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBrick4
            // 
            this.labelBrick4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelBrick4.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrick4.Location = new System.Drawing.Point(142, 150);
            this.labelBrick4.Name = "labelBrick4";
            this.labelBrick4.Size = new System.Drawing.Size(60, 13);
            this.labelBrick4.TabIndex = 0;
            this.labelBrick4.Text = "Hossz";
            this.labelBrick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPipe1
            // 
            this.labelPipe1.BackColor = System.Drawing.Color.Aqua;
            this.labelPipe1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPipe1.Location = new System.Drawing.Point(12, 200);
            this.labelPipe1.Name = "labelPipe1";
            this.labelPipe1.Size = new System.Drawing.Size(191, 24);
            this.labelPipe1.TabIndex = 0;
            this.labelPipe1.Text = "Cső";
            this.labelPipe1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPipe2
            // 
            this.labelPipe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPipe2.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPipe2.Location = new System.Drawing.Point(12, 224);
            this.labelPipe2.Name = "labelPipe2";
            this.labelPipe2.Size = new System.Drawing.Size(60, 12);
            this.labelPipe2.TabIndex = 0;
            this.labelPipe2.Text = "Átmérő";
            this.labelPipe2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPipe3
            // 
            this.labelPipe3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPipe3.Location = new System.Drawing.Point(74, 224);
            this.labelPipe3.Name = "labelPipe3";
            this.labelPipe3.Size = new System.Drawing.Size(60, 12);
            this.labelPipe3.TabIndex = 0;
            this.labelPipe3.Text = "Fal";
            this.labelPipe3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPipe4
            // 
            this.labelPipe4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPipe4.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPipe4.Location = new System.Drawing.Point(142, 224);
            this.labelPipe4.Name = "labelPipe4";
            this.labelPipe4.Size = new System.Drawing.Size(60, 12);
            this.labelPipe4.TabIndex = 0;
            this.labelPipe4.Text = "Hossz";
            this.labelPipe4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHolSec1
            // 
            this.labelHolSec1.BackColor = System.Drawing.Color.Aqua;
            this.labelHolSec1.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHolSec1.Location = new System.Drawing.Point(8, 266);
            this.labelHolSec1.Name = "labelHolSec1";
            this.labelHolSec1.Size = new System.Drawing.Size(259, 24);
            this.labelHolSec1.TabIndex = 0;
            this.labelHolSec1.Text = "Zártszelvény";
            this.labelHolSec1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHolSec2
            // 
            this.labelHolSec2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHolSec2.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHolSec2.Location = new System.Drawing.Point(9, 288);
            this.labelHolSec2.Name = "labelHolSec2";
            this.labelHolSec2.Size = new System.Drawing.Size(60, 12);
            this.labelHolSec2.TabIndex = 0;
            this.labelHolSec2.Text = "Szélesség";
            this.labelHolSec2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHolSec3
            // 
            this.labelHolSec3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHolSec3.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHolSec3.Location = new System.Drawing.Point(75, 288);
            this.labelHolSec3.Name = "labelHolSec3";
            this.labelHolSec3.Size = new System.Drawing.Size(60, 12);
            this.labelHolSec3.TabIndex = 0;
            this.labelHolSec3.Text = "magasság";
            this.labelHolSec3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHolSec4
            // 
            this.labelHolSec4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHolSec4.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHolSec4.Location = new System.Drawing.Point(140, 288);
            this.labelHolSec4.Name = "labelHolSec4";
            this.labelHolSec4.Size = new System.Drawing.Size(60, 12);
            this.labelHolSec4.TabIndex = 0;
            this.labelHolSec4.Text = "fal";
            this.labelHolSec4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHolSec5
            // 
            this.labelHolSec5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelHolSec5.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHolSec5.Location = new System.Drawing.Point(207, 290);
            this.labelHolSec5.Name = "labelHolSec5";
            this.labelHolSec5.Size = new System.Drawing.Size(60, 13);
            this.labelHolSec5.TabIndex = 0;
            this.labelHolSec5.Text = "Hossz";
            this.labelHolSec5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vas";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(348, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alu";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(387, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Réz";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(426, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Műa";
            // 
            // labelFeResult
            // 
            this.labelFeResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelFeResult.Location = new System.Drawing.Point(309, 36);
            this.labelFeResult.Name = "labelFeResult";
            this.labelFeResult.Size = new System.Drawing.Size(33, 20);
            this.labelFeResult.TabIndex = 0;
            this.labelFeResult.Text = "label7";
            // 
            // labelAlResult
            // 
            this.labelAlResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelAlResult.Location = new System.Drawing.Point(348, 36);
            this.labelAlResult.Name = "labelAlResult";
            this.labelAlResult.Size = new System.Drawing.Size(33, 20);
            this.labelAlResult.TabIndex = 0;
            this.labelAlResult.Text = "label8";
            // 
            // labelCuResult
            // 
            this.labelCuResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelCuResult.Location = new System.Drawing.Point(387, 36);
            this.labelCuResult.Name = "labelCuResult";
            this.labelCuResult.Size = new System.Drawing.Size(33, 20);
            this.labelCuResult.TabIndex = 0;
            this.labelCuResult.Text = "label8";
            // 
            // labelPLResult
            // 
            this.labelPLResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPLResult.Location = new System.Drawing.Point(426, 36);
            this.labelPLResult.Name = "labelPLResult";
            this.labelPLResult.Size = new System.Drawing.Size(33, 20);
            this.labelPLResult.TabIndex = 0;
            this.labelPLResult.Text = "label10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHolSec5);
            this.Controls.Add(this.labelHolSec1);
            this.Controls.Add(this.labelPipe4);
            this.Controls.Add(this.labelPipe2);
            this.Controls.Add(this.labelPipe1);
            this.Controls.Add(this.labelBrick4);
            this.Controls.Add(this.labelBrick1);
            this.Controls.Add(this.labelHexa3);
            this.Controls.Add(this.labelHexa1);
            this.Controls.Add(this.labelDiam1);
            this.Controls.Add(this.labelHolSec4);
            this.Controls.Add(this.BrickLengthTextBox);
            this.Controls.Add(this.PipeLengthtextBox);
            this.Controls.Add(this.HolSecLengthtextBox);
            this.Controls.Add(this.HolSecWalltextBox);
            this.Controls.Add(this.labelHolSec3);
            this.Controls.Add(this.labelHolSec2);
            this.Controls.Add(this.labelPipe3);
            this.Controls.Add(this.labelBrick3);
            this.Controls.Add(this.labelBrick2);
            this.Controls.Add(this.labelHexa2);
            this.Controls.Add(this.HolSecHeigthtextBox);
            this.Controls.Add(this.HolSecWidthtextBox);
            this.Controls.Add(this.PipeWalltextBox);
            this.Controls.Add(this.PipeDiamtextBox);
            this.Controls.Add(this.BrickHeightTextBox);
            this.Controls.Add(this.BrickWidthTextBox);
            this.Controls.Add(this.HexaLengthTextBox);
            this.Controls.Add(this.HexaTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.labelPLResult);
            this.Controls.Add(this.labelCuResult);
            this.Controls.Add(this.labelAlResult);
            this.Controls.Add(this.labelFeResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDiam3);
            this.Controls.Add(this.LabelDiam2);
            this.Controls.Add(this.DiameterLengthTextBox);
            this.Controls.Add(this.DiameterTextBox);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Súly számoló";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox DiameterTextBox;
        private System.Windows.Forms.TextBox DiameterLengthTextBox;
        private System.Windows.Forms.Label LabelDiam2;
        private System.Windows.Forms.Label labelDiam3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFeResult;
        private System.Windows.Forms.Label labelAlResult;
        private System.Windows.Forms.Label labelCuResult;
        private System.Windows.Forms.Label labelPLResult;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox HexaLengthTextBox;
        private System.Windows.Forms.TextBox HexaTextBox;
        private System.Windows.Forms.TextBox BrickHeightTextBox;
        private System.Windows.Forms.TextBox BrickWidthTextBox;
        private System.Windows.Forms.TextBox PipeWalltextBox;
        private System.Windows.Forms.TextBox PipeDiamtextBox;
        private System.Windows.Forms.TextBox HolSecHeigthtextBox;
        private System.Windows.Forms.TextBox HolSecWidthtextBox;
        private System.Windows.Forms.Label labelHexa2;
        private System.Windows.Forms.Label labelBrick3;
        private System.Windows.Forms.Label labelBrick2;
        private System.Windows.Forms.Label labelPipe3;
        private System.Windows.Forms.Label labelHolSec3;
        private System.Windows.Forms.Label labelHolSec2;
        private System.Windows.Forms.TextBox HolSecLengthtextBox;
        private System.Windows.Forms.TextBox HolSecWalltextBox;
        private System.Windows.Forms.TextBox PipeLengthtextBox;
        private System.Windows.Forms.TextBox BrickLengthTextBox;
        private System.Windows.Forms.Label labelHolSec4;
        private System.Windows.Forms.Label labelDiam1;
        private System.Windows.Forms.Label labelHexa1;
        private System.Windows.Forms.Label labelHexa3;
        private System.Windows.Forms.Label labelBrick1;
        private System.Windows.Forms.Label labelBrick4;
        private System.Windows.Forms.Label labelPipe1;
        private System.Windows.Forms.Label labelPipe2;
        private System.Windows.Forms.Label labelPipe4;
        private System.Windows.Forms.Label labelHolSec1;
        private System.Windows.Forms.Label labelHolSec5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

