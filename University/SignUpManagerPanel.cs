using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class SignUpManagerPanel : Form
    {
        public SignUpManagerPanel()
        {
            InitializeComponent();
        }

        private void btn_back34_Click(object sender, EventArgs e)
        {
            ManagerPanel managerpanel = new ManagerPanel("");
            managerpanel.Show();
            this.Hide();
        }

        private void SignUpManagerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel("");
            managerPanel.Show();
        }
    }
}
