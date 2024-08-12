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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Employee EMPP= new Employee();

            SqlDataAdapter sda = EMPP.getAllEmployees();

            DataTable DTT= new DataTable();

            sda.Fill(DTT);

            dataGridView1.DataSource = DTT;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee    EMP = new Employee();

            SqlDataAdapter sda = EMP.searchEmployees(textBox1.Text);

            DataTable DT = new DataTable();

            sda.Fill(DT);

            dataGridView1.DataSource = DT;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeMenu emp = new EmployeeMenu();
            emp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
