﻿namespace RWA_Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(519, 59);
            button1.Name = "button1";
            button1.Size = new Size(148, 60);
            button1.TabIndex = 0;
            button1.Text = "Lista Svih Studenata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(44, 77);
            label1.Name = "label1";
            label1.Size = new Size(332, 21);
            label1.TabIndex = 1;
            label1.Text = "Dobro dosli u pretinac Korisnicke sluzbe ";
            // 
            // button3
            // 
            button3.Location = new Point(519, 174);
            button3.Name = "button3";
            button3.Size = new Size(148, 60);
            button3.TabIndex = 3;
            button3.Text = "Lista Svih Obroka";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(519, 286);
            button2.Name = "button2";
            button2.Size = new Size(148, 60);
            button2.TabIndex = 4;
            button2.Text = "Lista Svih Narudžbi po Id-u Studenta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Korisnička Služba";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button3;
        private Button button2;
    }
}