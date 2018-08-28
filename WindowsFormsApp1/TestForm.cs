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
    public partial class TestForm : Form
    {
        private readonly EFContext _context;
        public TestForm(EFContext context)
        {
            InitializeComponent();
            _context = context;
            UpdateDataGridTest();
        }
        private void UpdateDataGridTest()
        {
            dgvTests.Rows.Clear();
            foreach (var test in _context.Tests.ToList())
            {
                int questionCount = 0;
                if (test.Questions != null)
                    questionCount = test.Questions.Count;
                object[] row = { test.Id, test.Name, questionCount, 0 };
                dgvTests.Rows.Add(row);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Test test = new Test
            {
                Name= txtName.Text
            };
            _context.Tests.Add(test);
            _context.SaveChanges();
            UpdateDataGridTest();

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows.Count > 0)
            {
                int id =(int)dgvTests.SelectedRows[0].Cells[0].Value;
                QuestionsFrom dlg = new QuestionsFrom(_context, id);
                dlg.ShowDialog();
                //MessageBox.Show(id.ToString());
            }
            else
                MessageBox.Show("Оберіть тест для роботи");
        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            if (dgvTests.SelectedRows.Count > 0)
            {
                int id = (int)dgvTests.SelectedRows[0].Cells[0].Value;
                TestingForm dlg = new TestingForm(_context, id);
                dlg.ShowDialog();
                //MessageBox.Show(id.ToString());
            }
            else
                MessageBox.Show("Оберіть тест для роботи");
        }
    }
}
