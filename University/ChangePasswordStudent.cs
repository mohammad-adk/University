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
    public partial class ChangePasswordStudent : Form
    {
        string id;
        public ChangePasswordStudent()
        {
            InitializeComponent();
        }
        public void getId(string id)
        {
            this.id = id;

        }

        private void btn_Back1_Click(object sender, EventArgs e)
        {

            StudentPanel studentpanel = new StudentPanel("");
            studentpanel.Show();
            this.Hide();
        }
    }
}
