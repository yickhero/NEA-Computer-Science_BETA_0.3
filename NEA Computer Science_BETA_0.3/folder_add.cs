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
    public partial class folder_add : Form
    {
        public folder_add()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            application form = new application();
            form.Show();
        }

        private void foldername_textbox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void folderadd_button_Click(object sender, EventArgs e)
        {
            if (foldername_textbox.TextLength == 0)
            {
                MessageBox.Show("Invalid Folder Name");
            }
            else if (foldertype_combobox.SelectedItem == null)
            {
                MessageBox.Show("Invalid Folder Type");
            }
            else if (foldertype_combobox.SelectedItem != null & foldername_textbox.TextLength !=0)
            {
                string foldername = foldername_textbox.Text;
                string[] tags = tags_listbox.Items.Cast<string>().ToArray();

                string[] tagsArray = new string[10];

                for (int i = 0; i < tags.Length && i < 10; i++)
                {
                    tagsArray[i] = tags[i];
                }
                string foldertype = foldertype_combobox.Text;
                //chatgpt code
                string tags_1 = tagsArray.Length > 0 ? tagsArray[0] : "";
                string tags_2 = tagsArray.Length > 1 ? tagsArray[1] : "";
                string tags_3 = tagsArray.Length > 2 ? tagsArray[2] : "";
                string tags_4 = tagsArray.Length > 3 ? tagsArray[3] : "";
                string tags_5 = tagsArray.Length > 4 ? tagsArray[4] : "";
                string tags_6 = tagsArray.Length > 5 ? tagsArray[5] : "";
                string tags_7 = tagsArray.Length > 6 ? tagsArray[6] : "";
                string tags_8 = tagsArray.Length > 7 ? tagsArray[7] : "";
                string tags_9 = tagsArray.Length > 8 ? tagsArray[8] : "";
                string tags_10 = tagsArray.Length > 9 ? tagsArray[9] : "";
                //chatgpt code
                string userid = application.userid;
                DatabaseControl.CreateFolder(userid, foldername, foldertype, tags_1, tags_2, tags_3, tags_4, tags_5, tags_6, tags_7, tags_8, tags_9, tags_10);
                application form = new application();
                this.Close();
                form.Show();
            }
            
            
            
        }

        private void foldertype_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tagsadd_button_Click(object sender, EventArgs e)
        {
            tags_listbox.Items.Add(tags_textbox.Text);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            if (tags_listbox.SelectedIndex != -1)
            {
                tags_listbox.Items.RemoveAt(tags_listbox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void tags_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
