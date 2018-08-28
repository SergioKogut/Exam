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
    public partial class TestingForm : Form
    {
        private readonly EFContext _context;
        private int questionNumber = 0;
        public TestingForm()
        {
           
        }

        public TestingForm(EFContext context, int id)
        {
            InitializeComponent();
            _context = context;
            var test = _context.Tests.SingleOrDefault(t => t.Id == id);
            if (test != null)
            {
                ShowQuestion(test, questionNumber);
            }
           
        }

        private void ShowQuestion(Test test, int id)
        {
            var questions = test.Questions.ToArray();
            lblQuestion.Text = questions[id].Text;
            try
            {
                lblAnswer1.Text = questions[id].Answers.ToArray()[0].Text;
            }
            catch (IndexOutOfRangeException)
            {
                lblAnswer1.Text = "none";
            }
            try
            {
                lblAnswer2.Text = questions[id].Answers.ToArray()[1].Text;
            }
            catch (IndexOutOfRangeException)
            {
                lblAnswer1.Text = "none";
            }
            try
            {
                lblAnswer3.Text = questions[id].Answers.ToArray()[2].Text;
            }
            catch (IndexOutOfRangeException)
            {
                lblAnswer1.Text = "none";
            }
            try
            {
                lblAnswer4.Text = questions[id].Answers.ToArray()[3].Text;
            }
            catch (IndexOutOfRangeException)
            {
                lblAnswer1.Text = "none";
            }
        }
    }
}
