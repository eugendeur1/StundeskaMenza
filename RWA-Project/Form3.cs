﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWA_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frmStudents = new Form5();
            frmStudents.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 frmStudents = new Form7();
            frmStudents.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 frmStudents = new Form9();
            frmStudents.ShowDialog();
        }
    }
}
