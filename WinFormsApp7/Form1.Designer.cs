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
            this.LabelProba = new System.Windows.Forms.Label();
            this.DiameterTextBox = new System.Windows.Forms.TextBox();
            this.DiameterLengthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelProba
            // 
            this.LabelProba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LabelProba.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelProba.Location = new System.Drawing.Point(386, 35);
            this.LabelProba.Name = "LabelProba";
            this.LabelProba.Size = new System.Drawing.Size(75, 14);
            this.LabelProba.TabIndex = 0;
            this.LabelProba.Text = "Súly";
            this.LabelProba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DiameterTextBox
            // 
            this.DiameterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DiameterTextBox.Location = new System.Drawing.Point(10, 54);
            this.DiameterTextBox.Name = "DiameterTextBox";
            this.DiameterTextBox.Size = new System.Drawing.Size(86, 20);
            this.DiameterTextBox.TabIndex = 1;
            this.DiameterTextBox.TextChanged += new System.EventHandler(this.ChangeDiameter);
            // 
            // DiameterLengthTextBox
            // 
            this.DiameterLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DiameterLengthTextBox.Location = new System.Drawing.Point(129, 54);
            this.DiameterLengthTextBox.Name = "DiameterLengthTextBox";
            this.DiameterLengthTextBox.Size = new System.Drawing.Size(86, 20);
            this.DiameterLengthTextBox.TabIndex = 2;
            this.DiameterLengthTextBox.TextChanged += new System.EventHandler(this.ChangeDiameterLength);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Átmérő";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(129, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Átmérő hossza";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(386, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vas";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(386, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alu";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(386, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Réz";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(386, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Műa";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(424, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(424, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(424, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "label8";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(424, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kilépés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiameterLengthTextBox);
            this.Controls.Add(this.DiameterTextBox);
            this.Controls.Add(this.LabelProba);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Súly számoló";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox DiameterTextBox;
        private System.Windows.Forms.TextBox DiameterLengthTextBox;
        private System.Windows.Forms.Label LabelProba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

