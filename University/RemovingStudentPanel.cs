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
    public partial class RemovingStudentPanel : Form
    {
        public RemovingStudentPanel()
        {
            InitializeComponent();
        }
        private void btn_back32_Click(object sender, EventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel("");
            managerPanel.Show();
            this.Hide();
        }
    }
}
