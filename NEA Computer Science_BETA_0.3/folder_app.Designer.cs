namespace NEA_Computer_Science_BETA_0._3
{
    partial class folder_app
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
            this.createcards_button = new System.Windows.Forms.Button();
            this.cards_datagridview = new System.Windows.Forms.DataGridView();
            this.revise_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.foldername_label = new System.Windows.Forms.Label();
            this.foldertype_label = new System.Windows.Forms.Label();
            this.tags_label = new System.Windows.Forms.Label();
            this.folderid_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cards_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // createcards_button
            // 
            this.createcards_button.Location = new System.Drawing.Point(603, 33);
            this.createcards_button.Name = "createcards_button";
            this.createcards_button.Size = new System.Drawing.Size(96, 36);
            this.createcards_button.TabIndex = 0;
            this.createcards_button.Text = "Create Cards";
            this.createcards_button.UseVisualStyleBackColor = true;
            this.createcards_button.Click += new System.EventHandler(this.createcards_button_Click);
            // 
            // cards_datagridview
            // 
            this.cards_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cards_datagridview.Location = new System.Drawing.Point(119, 86);
            this.cards_datagridview.Name = "cards_datagridview";
            this.cards_datagridview.RowHeadersWidth = 51;
            this.cards_datagridview.RowTemplate.Height = 27;
            this.cards_datagridview.Size = new System.Drawing.Size(619, 311);
            this.cards_datagridview.TabIndex = 1;
            // 
            // revise_button
            // 
            this.revise_button.Location = new System.Drawing.Point(612, 403);
            this.revise_button.Name = "revise_button";
            this.revise_button.Size = new System.Drawing.Size(96, 46);
            this.revise_button.TabIndex = 2;
            this.revise_button.Text = "Revise";
            this.revise_button.UseVisualStyleBackColor = true;
            this.revise_button.Click += new System.EventHandler(this.revise_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(152, 403);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(101, 46);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // foldername_label
            // 
            this.foldername_label.AutoSize = true;
            this.foldername_label.Location = new System.Drawing.Point(12, 9);
            this.foldername_label.Name = "foldername_label";
            this.foldername_label.Size = new System.Drawing.Size(81, 15);
            this.foldername_label.TabIndex = 4;
            this.foldername_label.Text = "Folder Name";
            // 
            // foldertype_label
            // 
            this.foldertype_label.AutoSize = true;
            this.foldertype_label.Location = new System.Drawing.Point(12, 33);
            this.foldertype_label.Name = "foldertype_label";
            this.foldertype_label.Size = new System.Drawing.Size(77, 15);
            this.foldertype_label.TabIndex = 5;
            this.foldertype_label.Text = "Folder Type";
            // 
            // tags_label
            // 
            this.tags_label.AutoSize = true;
            this.tags_label.Location = new System.Drawing.Point(12, 54);
            this.tags_label.Name = "tags_label";
            this.tags_label.Size = new System.Drawing.Size(34, 15);
            this.tags_label.TabIndex = 6;
            this.tags_label.Text = "Tags";
            // 
            // folderid_label
            // 
            this.folderid_label.AutoSize = true;
            this.folderid_label.Location = new System.Drawing.Point(675, 9);
            this.folderid_label.Name = "folderid_label";
            this.folderid_label.Size = new System.Drawing.Size(63, 15);
            this.folderid_label.TabIndex = 7;
            this.folderid_label.Text = "Folder ID";
            // 
            // folder_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.folderid_label);
            this.Controls.Add(this.tags_label);
            this.Controls.Add(this.foldertype_label);
            this.Controls.Add(this.foldername_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.revise_button);
            this.Controls.Add(this.cards_datagridview);
            this.Controls.Add(this.createcards_button);
            this.Name = "folder_app";
            this.Text = "folder_app";
            ((System.ComponentModel.ISupportInitialize)(this.cards_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createcards_button;
        private System.Windows.Forms.DataGridView cards_datagridview;
        private System.Windows.Forms.Button revise_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label foldername_label;
        private System.Windows.Forms.Label foldertype_label;
        private System.Windows.Forms.Label tags_label;
        private System.Windows.Forms.Label folderid_label;
    }
}