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
    public partial class AddCoursePanel : Form
    {
        public AddCoursePanel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_back39_Click(object sender, EventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel("");
            managerPanel.Show();
            this.Hide();
        }
    }
}
