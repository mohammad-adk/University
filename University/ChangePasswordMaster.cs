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
    public partial class ChangePasswordMaster : Form
    {
        public ChangePasswordMaster()
        {
            InitializeComponent();
        }

        private void btn_Back2_Click(object sender, EventArgs e)
        {
            TeacherPanel teacherPanel = new TeacherPanel();
            teacherPanel.Show();
            this.Hide();
        }
    }
}
