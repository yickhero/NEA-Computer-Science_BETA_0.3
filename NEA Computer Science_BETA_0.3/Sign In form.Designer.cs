namespace NEA_Computer_Science_BETA_0._3
{
    partial class Form2
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
            this.signin_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.signin_lable = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.sendverificationcode_button = new System.Windows.Forms.Button();
            this.verifyemail_textbox = new System.Windows.Forms.TextBox();
            this.verifyemail_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signin_button
            // 
            this.signin_button.Location = new System.Drawing.Point(448, 301);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(75, 23);
            this.signin_button.TabIndex = 0;
            this.signin_button.Text = "Sign In";
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.signin_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(353, 215);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(170, 25);
            this.password_textbox.TabIndex = 1;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(353, 184);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(170, 25);
            this.email_textbox.TabIndex = 2;
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(353, 147);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(170, 25);
            this.username_textbox.TabIndex = 3;
            // 
            // signin_lable
            // 
            this.signin_lable.AutoSize = true;
            this.signin_lable.Location = new System.Drawing.Point(32, 32);
            this.signin_lable.Name = "signin_lable";
            this.signin_lable.Size = new System.Drawing.Size(49, 15);
            this.signin_lable.TabIndex = 4;
            this.signin_lable.Text = "Sign In";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(270, 150);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(63, 15);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Username";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(270, 184);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 15);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(270, 218);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(60, 15);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password";
            // 
            // sendverificationcode_button
            // 
            this.sendverificationcode_button.Location = new System.Drawing.Point(529, 248);
            this.sendverificationcode_button.Name = "sendverificationcode_button";
            this.sendverificationcode_button.Size = new System.Drawing.Size(130, 40);
            this.sendverificationcode_button.TabIndex = 8;
            this.sendverificationcode_button.Text = "send verification code";
            this.sendverificationcode_button.UseVisualStyleBackColor = true;
            this.sendverificationcode_button.Click += new System.EventHandler(this.sendverificationcode_button_Click);
            // 
            // verifyemail_textbox
            // 
            this.verifyemail_textbox.Location = new System.Drawing.Point(353, 258);
            this.verifyemail_textbox.Name = "verifyemail_textbox";
            this.verifyemail_textbox.Size = new System.Drawing.Size(170, 25);
            this.verifyemail_textbox.TabIndex = 9;
            // 
            // verifyemail_label
            // 
            this.verifyemail_label.AutoSize = true;
            this.verifyemail_label.Location = new System.Drawing.Point(270, 261);
            this.verifyemail_label.Name = "verifyemail_label";
            this.verifyemail_label.Size = new System.Drawing.Size(82, 15);
            this.verifyemail_label.TabIndex = 10;
            this.verifyemail_label.Text = "Verify Email";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verifyemail_label);
            this.Controls.Add(this.verifyemail_textbox);
            this.Controls.Add(this.sendverificationcode_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.signin_lable);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.signin_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label signin_lable;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button sendverificationcode_button;
        private System.Windows.Forms.TextBox verifyemail_textbox;
        private System.Windows.Forms.Label verifyemail_label;
    }
}