﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipment mn = new Equipment();
            mn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer mn = new Customer();
            mn.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Installation mn = new Installation();
            mn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff mn = new Staff();
            mn.Show();
        }

        private void Facility_Click(object sender, EventArgs e)
        {
            Facility mn = new Facility();
            mn.Show();
        }
    }
}
