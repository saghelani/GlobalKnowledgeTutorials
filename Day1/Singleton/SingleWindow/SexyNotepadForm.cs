using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SingleWindow
{
    public partial class SexyNotepadForm : Form
    {
        public SexyNotepadForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SexyNotepadForm().Show();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm findForm = SearchForm.GetInstance();
            findForm.Focus();
            findForm.Show();
        }
    }
}