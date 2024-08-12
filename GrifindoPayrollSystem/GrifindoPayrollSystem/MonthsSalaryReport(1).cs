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
    public partial class MonthsSalaryReport : Form
    {
        public MonthsSalaryReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu sm = new SalaryMenu();
            sm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            Salary s = new Salary();

            s.getSalarySummaryMonths(dateTimePicker1.Text,dateTimePicker2.Text,textBox9.Text).Fill(dt);

            dataGridView1.DataSource = dt;


        }
    }
}
