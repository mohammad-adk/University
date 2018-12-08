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
    public partial class ChangePassword : Form
    {
        string id;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public void getId(string id)
        {
            this.id = id;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            
            ManagerPanel managerPanel = new ManagerPanel("");
            managerPanel.Show();
            this.Hide();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            




        }
    }
}
