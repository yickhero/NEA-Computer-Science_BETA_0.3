namespace NEA_Computer_Science_BETA_0._3
{
    partial class addcard_form
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
            this.front_richtextbox = new System.Windows.Forms.RichTextBox();
            this.back_richtextbox = new System.Windows.Forms.RichTextBox();
            this.front_label = new System.Windows.Forms.Label();
            this.back_label = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // front_richtextbox
            // 
            this.front_richtextbox.Location = new System.Drawing.Point(29, 27);
            this.front_richtextbox.Name = "front_richtextbox";
            this.front_richtextbox.Size = new System.Drawing.Size(721, 184);
            this.front_richtextbox.TabIndex = 0;
            this.front_richtextbox.Text = "";
            // 
            // back_richtextbox
            // 
            this.back_richtextbox.Location = new System.Drawing.Point(29, 232);
            this.back_richtextbox.Name = "back_richtextbox";
            this.back_richtextbox.Size = new System.Drawing.Size(721, 187);
            this.back_richtextbox.TabIndex = 1;
            this.back_richtextbox.Text = "";
            // 
            // front_label
            // 
            this.front_label.AutoSize = true;
            this.front_label.Location = new System.Drawing.Point(26, 9);
            this.front_label.Name = "front_label";
            this.front_label.Size = new System.Drawing.Size(38, 15);
            this.front_label.TabIndex = 2;
            this.front_label.Text = "Front";
            // 
            // back_label
            // 
            this.back_label.AutoSize = true;
            this.back_label.Location = new System.Drawing.Point(26, 214);
            this.back_label.Name = "back_label";
            this.back_label.Size = new System.Drawing.Size(35, 15);
            this.back_label.TabIndex = 3;
            this.back_label.Text = "Back";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(119, 425);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(590, 425);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 5;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // addcard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.back_label);
            this.Controls.Add(this.front_label);
            this.Controls.Add(this.back_richtextbox);
            this.Controls.Add(this.front_richtextbox);
            this.Name = "addcard_form";
            this.Text = "addcard_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox front_richtextbox;
        private System.Windows.Forms.RichTextBox back_richtextbox;
        private System.Windows.Forms.Label front_label;
        private System.Windows.Forms.Label back_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button create_button;
    }
}