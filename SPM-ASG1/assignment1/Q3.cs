using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Q3 : Form
    {
        public Q3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SharedData.Row)!=1)
            {
                int x, y;
                x =Convert.ToInt32(SharedData.Row) - 1;
                y = Convert.ToInt32(SharedData.Column);
                PBL.x = x; PBL.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            this.Close();
        }

        private void bot_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(SharedData.Row) != 20)
            {
                int x, y;
                x = Convert.ToInt32(SharedData.Row) + 1;
                y = Convert.ToInt32(SharedData.Column);
                PBL.x = x; PBL.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            this.Close();
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SharedData.Column) != 1 || Convert.ToInt32(SharedData.Column) != 20)
            {
                int x, y;
                x = Convert.ToInt32(SharedData.Row);
                y = Convert.ToInt32(SharedData.Column)-1;
                PBL.x = x; PBL.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            this.Close();
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SharedData.Column) != 1 || Convert.ToInt32(SharedData.Column) != 20)
            {
                int x, y;
                x = Convert.ToInt32(SharedData.Row);
                y = Convert.ToInt32(SharedData.Column)+1;
                PBL.x = x; PBL.y = y;
                SharedData.Row = x.ToString();
                SharedData.Column = y.ToString();
            }
            else
            {
                MessageBox.Show("cant go top");
            }
            this.Close();
        }
    }
}
