using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void Authenticate(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;
            string name = "";
            string password = "";

            if (textBoxUserName.Text.Equals(""))
            {
                errMsg += "Username required.\n";
                hasErr = true;
            }
            else
            {
                name = textBoxUserName.Text;
            }

            if (textBoxPassword.Text.Equals(""))
            {
                errMsg += "Password required.";
                hasErr = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }

            if (!hasErr)
            {
                if (name.Equals("nabobi") && password.Equals("18-38712-3"))
                {
                    new User_management().Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else
                MessageBox.Show(errMsg);


        }
    }
}
