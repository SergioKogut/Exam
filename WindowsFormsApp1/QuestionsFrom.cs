using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestSystem;
using TestSystem.Entities;

namespace WindowsFormsApp1
{
    public partial class QuestionsFrom : Form
    {
        private readonly EFContext _context;
        private readonly int _testId;
        private int questionIdSelect;
        public QuestionsFrom(EFContext context, int testId)
        {
            InitializeComponent();
            _context = context;
            _testId = testId;
            var test=_context.Tests.SingleOrDefault(t => t.Id == testId);
            if(test!=null)
            {
                lblTestName.Text = test.Name;
                UpdateDataGridTestQuestion();
                UpdateDataGridAnswer();
            }
        }

        private void UpdateDataGridTestQuestion()
        {
            dataGridViewQuestion.Rows.Clear();
            foreach (var test in _context.Questions.Where(q=>q.TestId== _testId).ToList())
            {
                object[] row = { test.Id, test.Text };
                dataGridViewQuestion.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNameQuestion.Text))
            {
                MessageBox.Show("Вкажіть питання");
                return;
            }

            Question question = new Question();
            question.TestId = _testId;
            question.Text = txtNameQuestion.Text;
            _context.Questions.Add(question);
            _context.SaveChanges();
            UpdateDataGridTestQuestion();
        }

        private void dataGridViewQuestion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            questionIdSelect = (int)dataGridViewQuestion.Rows[e.RowIndex].Cells[0].Value;
            gbAnswer.Visible=true;
            UpdateDataGridAnswer();
            //MessageBox.Show(questionIdSelect.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxAnswer.Text))
            {
                MessageBox.Show("Введдіть щось");
                return;
            }
            Answer answer = new Answer();
            answer.Text = textBoxAnswer.Text;
            answer.IsTrue = checkBoxIsTrue.Checked;
            answer.QuestionId = questionIdSelect;
            _context.Answers.Add(answer);
            _context.SaveChanges();
            UpdateDataGridAnswer();
        }

        private void UpdateDataGridAnswer()
        {
            dataGridViewAnswers.Rows.Clear();
            foreach (var test in _context.Answers.Where(a=>a.QuestionId==questionIdSelect).ToList())
            {
                object[] row = { test.Id, test.Text, test.IsTrue };
                dataGridViewAnswers.Rows.Add(row);
            }
        }
    }
}
