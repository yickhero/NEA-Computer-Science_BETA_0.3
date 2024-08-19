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
    public partial class application : Form
    {
        //List<List<string>> folderList = DatabaseControl.GetFolderList();
        public static string foldername = "";
        public static string foldertype = "";
        public static string folderid = "";
        public static string tags = "";
        public static string email = "";
        public static string username = "";
        public static string userid = "";
        public static Queue<string> cards = new Queue<string>();

        public application()
        {
            InitializeComponent();
            string search = search_textbox.Text;
            int search_length = search_textbox.Text.Length;
            email = Form1.email_login;
            string[] users = DatabaseControl.GetUserFromEmail(email);
            userid = users[0];
            username = users[1];
            username_label.Text = ("username: " + username);
            userid_label.Text = ("userid: " + userid);
            email_label.Text = ("email: " + email);
            //DataTable dataTable = ConvertToDataTable(folderList);
            folders_datagridview.DataSource = DatabaseControl.GetFolderList();


        }

        private void addfolder_button_Click(object sender, EventArgs e)
        {
            this.Close();
            folder_add form = new folder_add();
            form.Show();
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {

        }


        //chatgpt code
        public static DataTable ConvertToDataTable(List<List<string>> list)
        {
            DataTable table = new DataTable();

            // Add columns to the DataTable
            table.Columns.Add("Folder Name");
            table.Columns.Add("Folder Type");
            table.Columns.Add("Tags");
            table.Columns.Add("Folder ID");

            // Add rows to the DataTable
            foreach (var row in list)
            {
                DataRow dataRow = table.NewRow();
                dataRow["Folder Name"] = row[0];
                dataRow["Folder Type"] = row[1];
                dataRow["Tags"] = row[2];
                dataRow["Folder ID"] = row[3];
                table.Rows.Add(dataRow);
            }

            return table;
        }
        //chatgpt code

        private void folders_datagridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = folders_datagridview.Rows[e.RowIndex];
                foldername = row.Cells["Folder Name"].Value.ToString();
                foldertype = row.Cells["Folder Type"].Value.ToString();
                tags = row.Cells["tags"].Value.ToString();
                folderid = row.Cells["Folder ID"].Value.ToString();
                DataStore.cards.Clear();
                cards = DatabaseControl.GetCardsFromFolderID(folderid);
                folder_app form = new folder_app();
                form.Show();
            }
        }
    }
}
