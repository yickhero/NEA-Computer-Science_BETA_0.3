namespace NEA_Computer_Science_BETA_0._3
{
    partial class Form1
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
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.signin_button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.temp_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(463, 235);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(189, 25);
            this.password_textbox.TabIndex = 0;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(463, 194);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(189, 25);
            this.email_textbox.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(576, 295);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 27);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signin_button
            // 
            this.signin_button.Location = new System.Drawing.Point(435, 295);
            this.signin_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(100, 27);
            this.signin_button.TabIndex = 3;
            this.signin_button.Text = "Sign In";
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(368, 239);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(60, 15);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(368, 197);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 15);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(0, 0);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(41, 15);
            this.login_label.TabIndex = 6;
            this.login_label.Text = "Login";
            // 
            // temp_button
            // 
            this.temp_button.Location = new System.Drawing.Point(463, 61);
            this.temp_button.Name = "temp_button";
            this.temp_button.Size = new System.Drawing.Size(127, 50);
            this.temp_button.TabIndex = 7;
            this.temp_button.Text = "temp button for table creation test";
            this.temp_button.UseVisualStyleBackColor = true;
            this.temp_button.Click += new System.EventHandler(this.temp_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.temp_button);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.signin_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_textbox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button temp_button;
    }
}

