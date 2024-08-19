namespace NEA_Computer_Science_BETA_0._3
{
    partial class folder_add
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
            this.foldername_textbox = new System.Windows.Forms.TextBox();
            this.folderadd_button = new System.Windows.Forms.Button();
            this.foldername_label = new System.Windows.Forms.Label();
            this.tags_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tagsadd_button = new System.Windows.Forms.Button();
            this.tags_listbox = new System.Windows.Forms.ListBox();
            this.foldertype_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foldername_textbox
            // 
            this.foldername_textbox.Location = new System.Drawing.Point(268, 68);
            this.foldername_textbox.Name = "foldername_textbox";
            this.foldername_textbox.Size = new System.Drawing.Size(271, 25);
            this.foldername_textbox.TabIndex = 0;
            this.foldername_textbox.TextChanged += new System.EventHandler(this.foldername_textbox_TextChanged);
            // 
            // folderadd_button
            // 
            this.folderadd_button.Location = new System.Drawing.Point(510, 412);
            this.folderadd_button.Name = "folderadd_button";
            this.folderadd_button.Size = new System.Drawing.Size(164, 26);
            this.folderadd_button.TabIndex = 1;
            this.folderadd_button.Text = "Add";
            this.folderadd_button.UseVisualStyleBackColor = true;
            this.folderadd_button.Click += new System.EventHandler(this.folderadd_button_Click);
            // 
            // foldername_label
            // 
            this.foldername_label.AutoSize = true;
            this.foldername_label.Location = new System.Drawing.Point(181, 75);
            this.foldername_label.Name = "foldername_label";
            this.foldername_label.Size = new System.Drawing.Size(81, 15);
            this.foldername_label.TabIndex = 2;
            this.foldername_label.Text = "Folder Name";
            // 
            // tags_textbox
            // 
            this.tags_textbox.Location = new System.Drawing.Point(284, 160);
            this.tags_textbox.Name = "tags_textbox";
            this.tags_textbox.Size = new System.Drawing.Size(100, 25);
            this.tags_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tags";
            // 
            // tagsadd_button
            // 
            this.tagsadd_button.Location = new System.Drawing.Point(390, 162);
            this.tagsadd_button.Name = "tagsadd_button";
            this.tagsadd_button.Size = new System.Drawing.Size(50, 23);
            this.tagsadd_button.TabIndex = 5;
            this.tagsadd_button.Text = "Add";
            this.tagsadd_button.UseVisualStyleBackColor = true;
            this.tagsadd_button.Click += new System.EventHandler(this.tagsadd_button_Click);
            // 
            // tags_listbox
            // 
            this.tags_listbox.FormattingEnabled = true;
            this.tags_listbox.ItemHeight = 15;
            this.tags_listbox.Location = new System.Drawing.Point(510, 142);
            this.tags_listbox.Name = "tags_listbox";
            this.tags_listbox.Size = new System.Drawing.Size(164, 229);
            this.tags_listbox.TabIndex = 6;
            this.tags_listbox.SelectedIndexChanged += new System.EventHandler(this.tags_listbox_SelectedIndexChanged);
            // 
            // foldertype_combobox
            // 
            this.foldertype_combobox.FormattingEnabled = true;
            this.foldertype_combobox.Items.AddRange(new object[] {
            "simple",
            "construct",
            "intermediate",
            "advanced"});
            this.foldertype_combobox.Location = new System.Drawing.Point(268, 99);
            this.foldertype_combobox.Name = "foldertype_combobox";
            this.foldertype_combobox.Size = new System.Drawing.Size(271, 23);
            this.foldertype_combobox.TabIndex = 7;
            this.foldertype_combobox.SelectedIndexChanged += new System.EventHandler(this.foldertype_combobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Folder Type";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(184, 412);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(151, 23);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(553, 377);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // folder_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foldertype_combobox);
            this.Controls.Add(this.tags_listbox);
            this.Controls.Add(this.tagsadd_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tags_textbox);
            this.Controls.Add(this.foldername_label);
            this.Controls.Add(this.folderadd_button);
            this.Controls.Add(this.foldername_textbox);
            this.Name = "folder_add";
            this.Text = "folder_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foldername_textbox;
        private System.Windows.Forms.Button folderadd_button;
        private System.Windows.Forms.Label foldername_label;
        private System.Windows.Forms.TextBox tags_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tagsadd_button;
        private System.Windows.Forms.ListBox tags_listbox;
        private System.Windows.Forms.ComboBox foldertype_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button delete_button;
    }
}