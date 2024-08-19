using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Computer_Science_BETA_0._3
{
    public partial class Form2 : Form
    {
        public bool verified = false;
        public int ver_code = 0;
        public int verify_code = 0;
        public Form2()
        {
            InitializeComponent();
            password_textbox.PasswordChar = '*';
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            ver_code = Convert.ToInt32(verifyemail_textbox.Text);
            if (username_textbox.TextLength == 0)
            {
                MessageBox.Show("invalid username");
            }
            else if (email_textbox.TextLength == 0)
            {
                MessageBox.Show("invalid email");
            }
            else if (password_textbox.TextLength == 0)
            {
                MessageBox.Show("invalid password");
            }
            else if (verify_code != ver_code)
            {
                MessageBox.Show("invalid verification code");
            }
            else if (verify_code == ver_code)
            {
                string username_signin = username_textbox.Text;
                string password_signin = password_textbox.Text;
                string email_signin = email_textbox.Text;


                DatabaseControl.AddUsers(username_signin, email_signin, password_signin);
                MessageBox.Show("sign in successfully!");
            }
        }

        private void sendverificationcode_button_Click(object sender, EventArgs e)
        {
            verify_code = new Random().Next(1000, 9999);
            MessageBox.Show("your verification code is: " + verify_code);
            


        }
    }
}
