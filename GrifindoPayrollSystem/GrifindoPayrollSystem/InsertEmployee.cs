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
    public partial class InsertEmployee : Form
    {
        public InsertEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee EEMP = new Employee();
            EEMP.InsertEmployee(textBox1.Text,textBox2.Text,dateTimePicker1.Text,comboBox1.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text);



            MessageBox.Show("Successfully inserted values!");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            EmployeeMenu EMM= new EmployeeMenu();
            EMM.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
