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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text=="Keshan" && textBox2.Text=="1234") {

                MainMenu mm = new MainMenu();
                mm.Show();
                this.Hide();



            }
            else {


                MessageBox.Show("Wrong username or password!");

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
