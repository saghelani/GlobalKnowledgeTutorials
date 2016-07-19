using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SingleWindow
{
    public partial class SearchForm : Form
    {
        private static SearchForm instance = null;

        private SearchForm()
        {
            InitializeComponent();
        }

        public static SearchForm GetInstance()
        {
            if (instance == null)
            {
                instance = new SearchForm(); 
            }
            return instance;
        }      

        private void findButton_Click(object sender, EventArgs e)
        {
            // Would typically do the actual find operation
            // but in this case just hide 
            this.Hide();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            base.OnClosing(e);
        }
    }
}