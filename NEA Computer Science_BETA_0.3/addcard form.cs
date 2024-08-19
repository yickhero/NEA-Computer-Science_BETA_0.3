using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA_Computer_Science_BETA_0._3
{
    public partial class addcard_form : Form
    {
        public addcard_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            string answer = back_richtextbox.Text;
            string question = front_richtextbox.Text;
            int folderid = DatabaseControl.GetFolderIDFromFolderName(application.foldername);
            int userid = Convert.ToInt32(application.userid);
            DatabaseControl.CreateCards(folderid, userid, question, answer);
            folder_app form = new folder_app();
            this.Close();
            form.Show();
        }
    }
}
