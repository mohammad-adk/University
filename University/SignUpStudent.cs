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
    public partial class SignUpStudent : Form
    {
        public SignUpStudent()
        {
            InitializeComponent();
        }

        private void btn_back35_Click(object sender, EventArgs e)
        {
            ManagerPanel managerpanel = new ManagerPanel("");
            managerpanel.Show();
            this.Hide();
        }

        private void SignUpStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel("");
            managerPanel.Show();
        }
    }
}
