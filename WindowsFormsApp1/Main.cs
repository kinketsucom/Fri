using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void アカウント管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account_form = new Account();
            account_form.Show();
        }
    }
}
