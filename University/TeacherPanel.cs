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
    public partial class TeacherPanel : Form
    {
        public TeacherPanel()
        {
            InitializeComponent();
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            EnterPage enterPagePanel = new EnterPage();
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            ChangePasswordMaster changePasswordPanel = new ChangePasswordMaster();
            changePasswordPanel.Show();
            this.Hide();
        }

        private void btn_set_grades_Click(object sender, EventArgs e)
        {

        }

        private void btn_get_classes_list_Click(object sender, EventArgs e)
        {

        }

        private void TeacherPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
