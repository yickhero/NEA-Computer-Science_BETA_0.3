using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Computer_Science_BETA_0._3
{
    public partial class Form1 : Form
    {
        public static string email_login = "";
        public static string password_login = "";
        public Form1()
        {
            InitializeComponent();
            password_textbox.PasswordChar = '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            email_login = email_textbox.Text;
            password_login = password_textbox.Text;
            DatabaseControl.CheckUsers(email_login, password_login);
            
        }
        public static void CreateAndDeleteForm()
        {
            application form = new application();
            form.Show();
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            
        }

        private void temp_button_Click(object sender, EventArgs e)
        {
            DatabaseControl.InitializeDatabase();
        }
    }
}
