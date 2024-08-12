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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewEmployee VVE = new ViewEmployee();
            VVE.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertEmployee IEE = new InsertEmployee();
            IEE.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            UpdateEmployee UEE = new UpdateEmployee();
            UEE.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            DeleteEmployee DLE = new DeleteEmployee();
            DLE.Show();
            this.Hide();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu MEE= new MainMenu();
            MEE.Show();
            this.Hide();
        }

        private void EmployeeMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
