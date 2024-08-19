namespace NEA_Computer_Science_BETA_0._3
{
    partial class application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.addfolder_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.folders_datagridview = new System.Windows.Forms.DataGridView();
            this.username_label = new System.Windows.Forms.Label();
            this.userid_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.folders_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // search_textbox
            // 
            this.search_textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.search_textbox.Location = new System.Drawing.Point(184, 40);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(319, 25);
            this.search_textbox.TabIndex = 0;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // addfolder_button
            // 
            this.addfolder_button.Location = new System.Drawing.Point(543, 32);
            this.addfolder_button.Name = "addfolder_button";
            this.addfolder_button.Size = new System.Drawing.Size(70, 42);
            this.addfolder_button.TabIndex = 1;
            this.addfolder_button.Text = "Add Folder";
            this.addfolder_button.UseVisualStyleBackColor = true;
            this.addfolder_button.Click += new System.EventHandler(this.addfolder_button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // folders_datagridview
            // 
            this.folders_datagridview.AllowUserToAddRows = false;
            this.folders_datagridview.AllowUserToDeleteRows = false;
            this.folders_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.folders_datagridview.ColumnHeadersVisible = false;
            this.folders_datagridview.Location = new System.Drawing.Point(49, 71);
            this.folders_datagridview.MultiSelect = false;
            this.folders_datagridview.Name = "folders_datagridview";
            this.folders_datagridview.ReadOnly = true;
            this.folders_datagridview.RowHeadersWidth = 51;
            this.folders_datagridview.RowTemplate.Height = 27;
            this.folders_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.folders_datagridview.Size = new System.Drawing.Size(695, 367);
            this.folders_datagridview.TabIndex = 5;
            this.folders_datagridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folders_datagridview_CellContentDoubleClick);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(0, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(63, 15);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "Username";
            // 
            // userid_label
            // 
            this.userid_label.AutoSize = true;
            this.userid_label.Location = new System.Drawing.Point(0, 15);
            this.userid_label.Name = "userid_label";
            this.userid_label.Size = new System.Drawing.Size(48, 15);
            this.userid_label.TabIndex = 7;
            this.userid_label.Text = "UserID";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(0, 30);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 15);
            this.email_label.TabIndex = 8;
            this.email_label.Text = "Email";
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.userid_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.folders_datagridview);
            this.Controls.Add(this.addfolder_button);
            this.Controls.Add(this.search_textbox);
            this.Name = "application";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.folders_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button addfolder_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView folders_datagridview;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label userid_label;
        private System.Windows.Forms.Label email_label;
    }
}