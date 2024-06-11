using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace assignment1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "" && passwordInput.Text == "")
            {
                MessageBox.Show("Signed up succesfully", "", MessageBoxButtons.OK);
            }
            else
            {
               SqlConnection con = new SqlConnection();
                SqlDataAdapter da = SqlDataAdapter();
                SqlCo
                MessageBox.Show("Please choose a unique username.", "", MessageBoxButtons.OK);
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
