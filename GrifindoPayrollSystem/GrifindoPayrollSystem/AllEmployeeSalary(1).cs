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
            DataTable dt = new DataTable();

            Salary s = new Salary();

            s.getAllSalarySummaryMonths(dateTimePicker1.Text, dateTimePicker2.Text).Fill(dt);

            dataGridView1.DataSource = dt;

        }
    }
}
