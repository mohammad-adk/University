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
    public partial class TermCourses : Form
    {
        public TermCourses(string id)
        {
            InitializeComponent();
        }

        private void TermCourses_Load(object sender, EventArgs e)
        {
            update();
        }
        public void update()
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
