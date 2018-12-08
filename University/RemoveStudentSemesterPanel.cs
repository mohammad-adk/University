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
    public partial class RemoveStudentSemesterPanel : Form
    {
        public RemoveStudentSemesterPanel()
        {
            InitializeComponent();
        }

        private void btn_back9_Click(object sender, EventArgs e)
        {
            ManagerPanel managerpanel = new ManagerPanel("");
            managerpanel.Show();
            this.Hide();
        }
    }
}
