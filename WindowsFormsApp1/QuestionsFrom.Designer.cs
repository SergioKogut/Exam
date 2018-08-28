namespace WindowsFormsApp1
{
    partial class QuestionsFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.dataGridViewQuestion = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAnswers = new System.Windows.Forms.DataGridView();
            this.AnswerIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIsTrue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameQuestion = new System.Windows.Forms.TextBox();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.checkBoxIsTrue = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Питання тесту";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestName.ForeColor = System.Drawing.Color.Blue;
            this.lblTestName.Location = new System.Drawing.Point(159, 16);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(57, 20);
            this.lblTestName.TabIndex = 1;
            this.lblTestName.Text = "label2";
            // 
            // dataGridViewQuestion
            // 
            this.dataGridViewQuestion.AllowUserToAddRows = false;
            this.dataGridViewQuestion.AllowUserToDeleteRows = false;
            this.dataGridViewQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.QuestionColumn});
            this.dataGridViewQuestion.Location = new System.Drawing.Point(20, 19);
            this.dataGridViewQuestion.Name = "dataGridViewQuestion";
            this.dataGridViewQuestion.ReadOnly = true;
            this.dataGridViewQuestion.Size = new System.Drawing.Size(534, 199);
            this.dataGridViewQuestion.TabIndex = 2;
            this.dataGridViewQuestion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewQuestion_CellMouseClick);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // QuestionColumn
            // 
            this.QuestionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuestionColumn.HeaderText = "Питання";
            this.QuestionColumn.Name = "QuestionColumn";
            this.QuestionColumn.ReadOnly = true;
            // 
            // dataGridViewAnswers
            // 
            this.dataGridViewAnswers.AllowUserToAddRows = false;
            this.dataGridViewAnswers.AllowUserToDeleteRows = false;
            this.dataGridViewAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnswers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnswerIdCol,
            this.AnswerCol,
            this.ColIsTrue});
            this.dataGridViewAnswers.Location = new System.Drawing.Point(17, 19);
            this.dataGridViewAnswers.Name = "dataGridViewAnswers";
            this.dataGridViewAnswers.ReadOnly = true;
            this.dataGridViewAnswers.Size = new System.Drawing.Size(420, 170);
            this.dataGridViewAnswers.TabIndex = 3;
            // 
            // AnswerIdCol
            // 
            this.AnswerIdCol.HeaderText = "Відповідь";
            this.AnswerIdCol.Name = "AnswerIdCol";
            this.AnswerIdCol.ReadOnly = true;
            this.AnswerIdCol.Visible = false;
            // 
            // AnswerCol
            // 
            this.AnswerCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnswerCol.HeaderText = "Відповідь";
            this.AnswerCol.Name = "AnswerCol";
            this.AnswerCol.ReadOnly = true;
            // 
            // ColIsTrue
            // 
            this.ColIsTrue.HeaderText = "Варіант";
            this.ColIsTrue.Name = "ColIsTrue";
            this.ColIsTrue.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNameQuestion);
            this.groupBox1.Controls.Add(this.dataGridViewQuestion);
            this.groupBox1.Location = new System.Drawing.Point(24, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 310);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Питання";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(487, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Назва теста";
            // 
            // txtNameQuestion
            // 
            this.txtNameQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameQuestion.Location = new System.Drawing.Point(17, 264);
            this.txtNameQuestion.Name = "txtNameQuestion";
            this.txtNameQuestion.Size = new System.Drawing.Size(449, 22);
            this.txtNameQuestion.TabIndex = 4;
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.checkBoxIsTrue);
            this.gbAnswer.Controls.Add(this.buttonAdd);
            this.gbAnswer.Controls.Add(this.label3);
            this.gbAnswer.Controls.Add(this.textBoxAnswer);
            this.gbAnswer.Controls.Add(this.dataGridViewAnswers);
            this.gbAnswer.Location = new System.Drawing.Point(633, 54);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(472, 300);
            this.gbAnswer.TabIndex = 5;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "groupBox2";
            this.gbAnswer.Visible = false;
            // 
            // checkBoxIsTrue
            // 
            this.checkBoxIsTrue.AutoSize = true;
            this.checkBoxIsTrue.Location = new System.Drawing.Point(17, 258);
            this.checkBoxIsTrue.Name = "checkBoxIsTrue";
            this.checkBoxIsTrue.Size = new System.Drawing.Size(56, 17);
            this.checkBoxIsTrue.TabIndex = 10;
            this.checkBoxIsTrue.Text = "IsTrue";
            this.checkBoxIsTrue.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(242, 245);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 41);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Відповідь";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer.Location = new System.Drawing.Point(17, 221);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(206, 22);
            this.textBoxAnswer.TabIndex = 7;
            // 
            // QuestionsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 379);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.label1);
            this.Name = "QuestionsFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionsFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.DataGridView dataGridViewQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionColumn;
        private System.Windows.Forms.DataGridView dataGridViewAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColIsTrue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameQuestion;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.CheckBox checkBoxIsTrue;
    }
}