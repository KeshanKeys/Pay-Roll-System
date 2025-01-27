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
    public partial class SalaryMenu : Form
    {
        public SalaryMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateSalary cs = new CalculateSalary();
            cs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MonthlySalaryReport ems = new MonthlySalaryReport();
            ems.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MonthsSalaryReport msr = new MonthsSalaryReport();
            msr.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            AllEmployeeSalary aes = new AllEmployeeSalary();
            aes.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu= new MainMenu();
            mainMenu.Show();    
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
