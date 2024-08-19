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
    public partial class Revise_Answer_Screen : Form
    {
        public Revise_Answer_Screen()
        {
            InitializeComponent();
            Question_richtextbox.Text = application.cards.Dequeue();
            answer_richtextbox.Text = application.cards.Dequeue();
        }

        private void Question_richtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void verydifficult_button_Click(object sender, EventArgs e)
        {
            Revise_Question_Screen form = new Revise_Question_Screen();
            this.Close();
            form.Show();

        }

        private void difficult_button_Click(object sender, EventArgs e)
        {
            Revise_Question_Screen form = new Revise_Question_Screen();
            this.Close();
            form.Show();
        }

        private void okay_button_Click(object sender, EventArgs e)
        {
            Revise_Question_Screen form = new Revise_Question_Screen();
            this.Close();
            form.Show();
        }

        private void easy_button_Click(object sender, EventArgs e)
        {
            Revise_Question_Screen form = new Revise_Question_Screen();
            this.Close();
            form.Show();
        }

        private void veryeasy_button_Click(object sender, EventArgs e)
        {
            Revise_Question_Screen form = new Revise_Question_Screen();
            this.Close();
            form.Show();
        }
    }
}
