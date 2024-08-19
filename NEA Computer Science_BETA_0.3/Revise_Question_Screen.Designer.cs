namespace NEA_Computer_Science_BETA_0._3
{
    partial class Revise_Question_Screen
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
            this.question_richtextbox = new System.Windows.Forms.RichTextBox();
            this.showanswer_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question_richtextbox
            // 
            this.question_richtextbox.Location = new System.Drawing.Point(61, 35);
            this.question_richtextbox.Name = "question_richtextbox";
            this.question_richtextbox.ReadOnly = true;
            this.question_richtextbox.Size = new System.Drawing.Size(653, 324);
            this.question_richtextbox.TabIndex = 0;
            this.question_richtextbox.Text = "";
            this.question_richtextbox.TextChanged += new System.EventHandler(this.question_richtextbox_TextChanged);
            // 
            // showanswer_button
            // 
            this.showanswer_button.Location = new System.Drawing.Point(61, 388);
            this.showanswer_button.Name = "showanswer_button";
            this.showanswer_button.Size = new System.Drawing.Size(653, 37);
            this.showanswer_button.TabIndex = 1;
            this.showanswer_button.Text = "Show Answer";
            this.showanswer_button.UseVisualStyleBackColor = true;
            this.showanswer_button.Click += new System.EventHandler(this.showanswer_button_Click);
            // 
            // Revise_Question_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showanswer_button);
            this.Controls.Add(this.question_richtextbox);
            this.Name = "Revise_Question_Screen";
            this.Text = "Revise_Question_Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox question_richtextbox;
        private System.Windows.Forms.Button showanswer_button;
    }
}