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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void labelPI_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void SubClicked(object sender, EventArgs e)
        {

            string errMsg = "";
            bool hasErr = false;

            string firstName = "";
            string lastName = "";
            string month = "";
            string day = "";
            string year = "";
            string gender = "";
            string email = "";
            string reEmail = "";
            string sQue = "";
            string sAns = "";
            string address = "";
            string city = "";
            string state = "";
            string zip = "";
            string phone = "";
            string phoneType = "";
            string pass = "";
            string rePass = "";

            
            

            if (textBoxFirstName.Text.Equals(""))
            {
                errMsg += "First Name required.\n";
                hasErr = true;
            }
            else
            {
                firstName = textBoxFirstName.Text;
            }


            if (textBoxLastName.Text.Equals(""))
            {
                errMsg += "Last Name required.\n";
                hasErr = true;
            }
            else
            {
                lastName = textBoxLastName.Text;
            }


            if (comboBoxM.Text.Equals("") || comboBoxM.Text.Equals("Month"))
            {
                errMsg += "Month required.\n";
                hasErr = true;
            }
            else
            {
                month = comboBoxM.Text;
            }

            if (comboBoxD.Text.Equals("") || comboBoxD.Text.Equals("Day"))
            {
                errMsg += "Day required.\n";
                hasErr = true;
            }
            else
            {
                day = comboBoxD.Text;
            }

            if (comboBoxY.Text.Equals("") || comboBoxY.Text.Equals("Year"))
            {
                errMsg += "Year required.\n";
                hasErr = true;
            }
            else
            {
                year = comboBoxY.Text;
            }

            if (comboBoxGender.Text.Equals("") || comboBoxGender.Text.Equals("Choose a gender"))
            {
                errMsg += "Gender required.\n";
                hasErr = true;
            }
            else
            {
                gender = comboBoxGender.Text;
            }

            if (textBoxEmail.Text.Equals(""))
            {
                errMsg += "Email required.\n";
                hasErr = true;
            }
            else
            {
                email = textBoxEmail.Text;
            }

            if (textBoxReEmail.Text.Equals(""))
            {
                errMsg += "Re entering Email required.\n";
                hasErr = true;
            }
            else
            {
                reEmail = textBoxReEmail.Text;
            }

            if (email.Equals(reEmail))
            {
               
            }
            else
            {
                errMsg += "Email doesn't match\n";
                hasErr = true;
            }

            if (textBoxPass.Text.Equals(""))
            {
                errMsg += "Password required.\n";
                hasErr = true;
            }
            else
            {
                pass = textBoxPass.Text;
            }

            if (textBoxRePass.Text.Equals(""))
            {
                errMsg += "Re entering Password required.\n";
                hasErr = true;
            }
            else
            {
                rePass = textBoxRePass.Text;
            }

            if (pass.Equals(rePass))
            {
                
            }
            else
            {
                errMsg += "Password doesn't match\n";
                hasErr = true;
            }


            if (comboBoxSQue.Text.Equals("") || comboBoxSQue.Text.Equals("Choose a security question"))
            {
                errMsg += "Security Question required.\n";
                hasErr = true;
            }
            else
            {
                sQue = comboBoxSQue.Text;
            }

            if (textBoxSAns.Text.Equals(""))
            {
                errMsg += "Security Answer required.\n";
                hasErr = true;
            }
            else
            {
                sAns = textBoxSAns.Text;
            }

            if (textBoxAddress.Text.Equals(""))
            {
                errMsg += "Address required.\n";
                hasErr = true;
            }
            else
            {
                address = textBoxAddress.Text;
            }

            if (textBoxCity.Text.Equals(""))
            {
                errMsg += "City required.\n";
                hasErr = true;
            }
            else
            {
                city = textBoxCity.Text;
            }

            if (comboBoxState.Text.Equals("") || comboBoxState.Text.Equals("Choose a state"))
            {
                errMsg += "State required.\n";
                hasErr = true;
            }
            else
            {
                state = comboBoxState.Text;
            }

            if (textBoxZip.Text.Equals(""))
            {
                errMsg += "Zip Code required.\n";
                hasErr = true;
            }
            else
            {
                zip = textBoxZip.Text;
            }

            if (textBoxPhone.Text.Equals(""))
            {
                errMsg += "Phone Number required.\n";
                hasErr = true;
            }
            else
            {
                phone = textBoxPhone.Text;
            }

            if (comboBoxMType.Text.Equals(""))
            {
                errMsg += "Phone Type required.\n";
                hasErr = true;
            }
            else
            {
                phoneType = comboBoxMType.Text;
            }

            if (!hasErr)
            {
                string output = String.Format("User Details: \n \n" +
                "First Name: {0} \n" +
                "Last Name: {1} \n" +
                "DOB: {2}-{3}-{4} \n" +
                "Gender: {5} \n" +
                "Email: {6} \n" +
                "Security Question: {7} \n" +
                "Security Answer: {8} \n" +
                "Address: {9} \n" +
                "City: {10} \n" +
                "State: {11} \n" +
                "Zip Code: {12}\n" +
                "Phone: {13} ({14})\n"

                , firstName, lastName, month, day, year, gender, email, sQue, sAns,
                address, city, state, zip, phone, phoneType);
                rTOutput.Text = output;
            }

            else
            {
                MessageBox.Show(errMsg);
            }
                
        }
    }
}
