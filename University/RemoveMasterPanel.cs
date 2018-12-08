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
    public partial class RemoveMasterPanel : Form
    {
        public RemoveMasterPanel()
        {
            InitializeComponent();
        }

        private void btn_back31_Click(object sender, EventArgs e)
        {
            ManagerPanel managerPanel = new ManagerPanel("");
            managerPanel.Show();
            this.Close();

        }
    }
}
