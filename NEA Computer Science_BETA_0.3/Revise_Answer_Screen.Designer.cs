namespace NEA_Computer_Science_BETA_0._3
{
    partial class Revise_Answer_Screen
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
            this.Question_richtextbox = new System.Windows.Forms.RichTextBox();
            this.answer_richtextbox = new System.Windows.Forms.RichTextBox();
            this.question_label = new System.Windows.Forms.Label();
            this.answer_label = new System.Windows.Forms.Label();
            this.veryeasy_button = new System.Windows.Forms.Button();
            this.easy_button = new System.Windows.Forms.Button();
            this.okay_button = new System.Windows.Forms.Button();
            this.difficult_button = new System.Windows.Forms.Button();
            this.verydifficult_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question_richtextbox
            // 
            this.Question_richtextbox.Location = new System.Drawing.Point(68, 24);
            this.Question_richtextbox.Name = "Question_richtextbox";
            this.Question_richtextbox.Size = new System.Drawing.Size(651, 171);
            this.Question_richtextbox.TabIndex = 0;
            this.Question_richtextbox.Text = "";
            this.Question_richtextbox.TextChanged += new System.EventHandler(this.Question_richtextbox_TextChanged);
            // 
            // answer_richtextbox
            // 
            this.answer_richtextbox.Location = new System.Drawing.Point(68, 201);
            this.answer_richtextbox.Name = "answer_richtextbox";
            this.answer_richtextbox.Size = new System.Drawing.Size(651, 185);
            this.answer_richtextbox.TabIndex = 1;
            this.answer_richtextbox.Text = "";
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Location = new System.Drawing.Point(12, 24);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(57, 15);
            this.question_label.TabIndex = 2;
            this.question_label.Text = "Question";
            // 
            // answer_label
            // 
            this.answer_label.AutoSize = true;
            this.answer_label.Location = new System.Drawing.Point(12, 204);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(50, 15);
            this.answer_label.TabIndex = 3;
            this.answer_label.Text = "Answer";
            // 
            // veryeasy_button
            // 
            this.veryeasy_button.Location = new System.Drawing.Point(68, 392);
            this.veryeasy_button.Name = "veryeasy_button";
            this.veryeasy_button.Size = new System.Drawing.Size(83, 46);
            this.veryeasy_button.TabIndex = 4;
            this.veryeasy_button.Text = "Very Easy";
            this.veryeasy_button.UseVisualStyleBackColor = true;
            this.veryeasy_button.Click += new System.EventHandler(this.veryeasy_button_Click);
            // 
            // easy_button
            // 
            this.easy_button.Location = new System.Drawing.Point(201, 392);
            this.easy_button.Name = "easy_button";
            this.easy_button.Size = new System.Drawing.Size(86, 46);
            this.easy_button.TabIndex = 5;
            this.easy_button.Text = "Easy";
            this.easy_button.UseVisualStyleBackColor = true;
            this.easy_button.Click += new System.EventHandler(this.easy_button_Click);
            // 
            // okay_button
            // 
            this.okay_button.Location = new System.Drawing.Point(347, 392);
            this.okay_button.Name = "okay_button";
            this.okay_button.Size = new System.Drawing.Size(89, 46);
            this.okay_button.TabIndex = 6;
            this.okay_button.Text = "Okay";
            this.okay_button.UseVisualStyleBackColor = true;
            this.okay_button.Click += new System.EventHandler(this.okay_button_Click);
            // 
            // difficult_button
            // 
            this.difficult_button.Location = new System.Drawing.Point(491, 392);
            this.difficult_button.Name = "difficult_button";
            this.difficult_button.Size = new System.Drawing.Size(93, 46);
            this.difficult_button.TabIndex = 7;
            this.difficult_button.Text = "Difficult";
            this.difficult_button.UseVisualStyleBackColor = true;
            this.difficult_button.Click += new System.EventHandler(this.difficult_button_Click);
            // 
            // verydifficult_button
            // 
            this.verydifficult_button.Location = new System.Drawing.Point(636, 392);
            this.verydifficult_button.Name = "verydifficult_button";
            this.verydifficult_button.Size = new System.Drawing.Size(83, 46);
            this.verydifficult_button.TabIndex = 8;
            this.verydifficult_button.Text = "Very Difficult";
            this.verydifficult_button.UseVisualStyleBackColor = true;
            this.verydifficult_button.Click += new System.EventHandler(this.verydifficult_button_Click);
            // 
            // Revise_Answer_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verydifficult_button);
            this.Controls.Add(this.difficult_button);
            this.Controls.Add(this.okay_button);
            this.Controls.Add(this.easy_button);
            this.Controls.Add(this.veryeasy_button);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.answer_richtextbox);
            this.Controls.Add(this.Question_richtextbox);
            this.Name = "Revise_Answer_Screen";
            this.Text = "Revise_Answer_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Question_richtextbox;
        private System.Windows.Forms.RichTextBox answer_richtextbox;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Label answer_label;
        private System.Windows.Forms.Button veryeasy_button;
        private System.Windows.Forms.Button easy_button;
        private System.Windows.Forms.Button okay_button;
        private System.Windows.Forms.Button difficult_button;
        private System.Windows.Forms.Button verydifficult_button;
    }
}