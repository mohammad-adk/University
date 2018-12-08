using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClasses;

namespace University
{
    public partial class ManagerPanel : Form
    {
        SignUpManagerPanel signUpManagerPanel = new SignUpManagerPanel();
        ChangePassword changePasswordPanel = new ChangePassword();
        EnterPage enterPagePanel = new EnterPage();
        AddMasterPanel addMasterPanelPanel = new AddMasterPanel();
        SignUpStudent signupStudentPanel = new SignUpStudent();
        RemovingStudentPanel removeStudentPanel = new RemovingStudentPanel();
        RemoveStudentSemesterPanel removeStudentSemesterPanel = new RemoveStudentSemesterPanel();
        RemoveManagerPanel removeManagerPanel = new RemoveManagerPanel();
        RemoveMasterPanel removeMasterPanel = new RemoveMasterPanel();
        string id;
        public ManagerPanel(string id)
        {
            this.id = id;
            InitializeComponent();
            if (id != "")
            {
                Manager mng = Manager.SearchManager(id).info;

                managername.Text = mng.firstName + " " + mng.lastName;
                managerid.Text = mng.id.ToString();
            }
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            changePasswordPanel.getId(id);
            changePasswordPanel.Show();
            this.Hide();
        }

        private void btn_control_unit_choose_Click(object sender, EventArgs e)
        {

        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_sign_up_master_Click(object sender, EventArgs e)
        {           
            addMasterPanelPanel.Show();
            this.Hide();
        }

  

        private void btn_sign_up_student_Click(object sender, EventArgs e)
        {
            signupStudentPanel.ShowDialog();
            this.Hide();
        }

        private void btn_sign_up_manager_Click(object sender, EventArgs e)
        { 
            signUpManagerPanel.ShowDialog();
            this.Hide();
        }

        private void btn_remove_student_Click(object sender, EventArgs e)
        {
            removeStudentPanel.ShowDialog();
            this.Hide();


        }

        private void btn_remove_manager_Click(object sender, EventArgs e)
        {
            
            removeManagerPanel.ShowDialog();
            this.Hide();
        }

        private void btn_remove_student_term_Click(object sender, EventArgs e)
        {
            
            removeStudentSemesterPanel.ShowDialog();
            this.Hide();
        }

        private void btn_remove_master_Click(object sender, EventArgs e)
        {
            
            removeMasterPanel.ShowDialog();
            this.Hide();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            AddCoursePanel addCoursePanel = new AddCoursePanel();
            addCoursePanel.Show();
        }

        private void btn_control_add_remove_course_Click(object sender, EventArgs e)
        {
            controlerPanel controlerPanel = new controlerPanel();
            controlerPanel.Show();
        }

        private void ManagerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
