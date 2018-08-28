namespace WindowsFormsApp1
{
    partial class TestingForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(13, 13);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(12, 36);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(14, 13);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(12, 60);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(14, 13);
            this.radio2.TabIndex = 2;
            this.radio2.TabStop = true;
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(12, 84);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(14, 13);
            this.radio3.TabIndex = 3;
            this.radio3.TabStop = true;
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(12, 108);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(14, 13);
            this.radio4.TabIndex = 4;
            this.radio4.TabStop = true;
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(193, 135);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 5;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(32, 36);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(31, 13);
            this.lblAnswer1.TabIndex = 6;
            this.lblAnswer1.Text = "none";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(32, 60);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(31, 13);
            this.lblAnswer2.TabIndex = 6;
            this.lblAnswer2.Text = "none";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(32, 84);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(31, 13);
            this.lblAnswer3.TabIndex = 6;
            this.lblAnswer3.Text = "none";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Location = new System.Drawing.Point(32, 108);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(31, 13);
            this.lblAnswer4.TabIndex = 6;
            this.lblAnswer4.Text = "none";
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 170);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "TestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
    }
}