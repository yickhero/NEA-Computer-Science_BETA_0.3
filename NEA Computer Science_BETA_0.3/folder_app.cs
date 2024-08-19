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
    public partial class folder_app : Form
    {
        public folder_app()
        {
            InitializeComponent();
            string foldername = application.foldername;
            string foldertype = application.foldertype;
            string tags = application.tags;
            string folderid = application.folderid;
            foldername_label.Text = ("Folder Name: " + foldername);
            foldertype_label.Text = ("Folder Type: " + foldertype);
            tags_label.Text = ("Folder Tags: \n" +  tags);
            folderid_label.Text = ("Folder ID: " + folderid);
            string folderid_ = DatabaseControl.GetFolderidFromFoldername(foldername);
            cards_datagridview.DataSource = DatabaseControl.GetCardList(folderid_);
        }

        private void createcards_button_Click(object sender, EventArgs e)
        {
            addcard_form form = new addcard_form();
            this.Close();
            form.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void revise_button_Click(object sender, EventArgs e)
        {
            if (application.cards.Count == 0)
            {
                MessageBox.Show("There are no cards");
            }
            else
            {
                Revise_Question_Screen form = new Revise_Question_Screen();
                form.Show();
            }

        }
    }
}
