using System;
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
    public partial class AllEmployeeSalary : Form
    {
        public AllEmployeeSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DTT = new DataTable();

            Salary sy = new Salary();

            sy.getAllSalarySummaryMonths(dateTimePicker1.Text, dateTimePicker2.Text).Fill(DTT);

            dataGridView1.DataSource = DTT;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu SMM=new SalaryMenu();
            SMM.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
