using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//NC-1 More namespaces.  
using System.Data.SqlClient;
using System.Configuration;

namespace Testinterfaz1
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //NC-16 Verify that Customer Name is present.  
        private bool isCustomerName()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void CreateSqlConnection()
        {
            string myConnectString = "Persist Security Info=False;Integrated Security=SSPI;database=base_datos_test1;server=SQLSERVER;Connect Timeout=30";
            SqlConnection myConnection = new SqlConnection(myConnectString);
            myConnection.Open();
        }

    }
}