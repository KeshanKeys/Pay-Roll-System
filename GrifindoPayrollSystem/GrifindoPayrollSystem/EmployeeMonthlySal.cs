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
    public partial class EmployeeMonthlySal : Form
    {
        public EmployeeMonthlySal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryMenu smm= new SalaryMenu();
            smm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
