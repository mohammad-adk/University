using System;
using System.Windows.Forms;

namespace University
{
    public partial class ChooseCourse : Form
    {
        public ChooseCourse()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanelPanel = new StudentPanel("");
            studentPanelPanel.Show();
            this.Hide();

        }
    }
}
