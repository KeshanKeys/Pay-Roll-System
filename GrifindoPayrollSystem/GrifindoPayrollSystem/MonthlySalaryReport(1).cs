using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace GrifindoPayrollSystem
{
    public partial class MonthlySalaryReport : Form
    {
        public MonthlySalaryReport()
        {
            InitializeComponent();
        }

        private void MonthlySalaryReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Salary s = new Salary();


            string[] vals = s.getEmployeeValues(textBox9.Text,dateTimePicker1.Text);


                label16.Text = vals[0];
                label17.Text = vals[1];
                label18.Text = vals[2];








                 label11.Text = vals[3];
                 label12.Text = vals[4];
                 label13.Text = vals[5];



        










        }
    }
}
