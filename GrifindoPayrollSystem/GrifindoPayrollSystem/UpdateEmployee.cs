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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Employee EEMP= new Employee();
            EEMP.updateEmployee(textBox1.Text,comboBox1.Text,textBox2.Text);

            MessageBox.Show("Successfully updated!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeMenu EEMM= new EmployeeMenu();
            EEMM.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
