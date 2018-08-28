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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        EFContext _context=null;
        public MainForm()
        {
            InitializeComponent();
            _context = new EFContext();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCommandTest_Click(object sender, EventArgs e)
        {
            TestForm dlg = new TestForm(_context);
            dlg.ShowDialog();
        }
    }
}
