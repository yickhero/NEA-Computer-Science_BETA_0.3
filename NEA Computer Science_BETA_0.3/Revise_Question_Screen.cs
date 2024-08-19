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
    public partial class Revise_Question_Screen : Form
    {
        
        public Revise_Question_Screen()
        {
            InitializeComponent();
            DataStore.totalcardnum = application.cards.Count/2;
            DataStore.currentcardcount = DataStore.currentcardcount + 1;
            question_richtextbox.Text = application.cards.Peek();

        }

        private void question_richtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showanswer_button_Click(object sender, EventArgs e)
        {
            Revise_Answer_Screen form = new Revise_Answer_Screen();
            this.Close();
            form.Show();
        }
    }
}
