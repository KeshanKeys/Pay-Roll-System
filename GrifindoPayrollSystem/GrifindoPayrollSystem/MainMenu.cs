﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoPayrollSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            Settings.SetUpValues();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            EmployeeMenu EEM= new EmployeeMenu();
            EEM.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SettingsMenu SSM = new SettingsMenu();
            SSM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu SMM = new SalaryMenu();
            SMM.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm LLF= new LoginForm();
            LLF.Show();
            this.Hide();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}