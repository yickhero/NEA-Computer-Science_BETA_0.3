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
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(347, 204);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(143, 20);
            this.password_textbox.TabIndex = 0;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(347, 168);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(143, 20);
            this.email_textbox.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(432, 256);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signin_button
            // 
            this.signin_button.Location = new System.Drawing.Point(326, 256);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(75, 23);
            this.signin_button.TabIndex = 3;
            this.signin_button.Text = "Sign In";
            this.signin_button.UseVisualStyleBackColor = true;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(276, 207);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(276, 171);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "Email";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(0, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(33, 13);
            this.login_label.TabIndex = 6;
            this.login_label.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.signin_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_textbox);
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
    }
}

