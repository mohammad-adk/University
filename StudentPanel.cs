using System;
using System.Windows.Forms;
using UniversityClasses;
namespace University
{
    
    public partial class StudentPanel : Form
    {
        string id;
   
        public StudentPanel(string id)
        {
            this.id = id;
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            EnterPage enterPagePanel = new EnterPage();
            enterPagePanel.Show();
            this.Hide();
        }

        private void btn_editPassword_Click(object sender, EventArgs e)
        {
            ChangePasswordStudent changePasswordPanel = new ChangePasswordStudent();
            changePasswordPanel.getId(id);
            changePasswordPanel.ShowDialog();
            this.Hide();
        }

        private void btn_addRemove_Click(object sender, EventArgs e)
        {
        
            Add_Remove_Course add_remove_Panel = new Add_Remove_Course(id);
            add_remove_Panel.ShowDialog();
            this.Hide();
        }

        private void btn_unitChoose_Click(object sender, EventArgs e)
        {
            ChooseCourse chooseCoursePanel = new ChooseCourse();
            chooseCoursePanel.ShowDialog();
            this.Close();
        }

        private void btn_getResult_Click(object sender, EventArgs e)
        {
            Grades gradesPanel = new Grades(id);
            gradesPanel.ShowDialog();
            this.Close();
        }

        private void btn_passed_courses_Click(object sender, EventArgs e)
        {
            PassedCoursesListPanel passedCoursesListPanel = new PassedCoursesListPanel(id);
            passedCoursesListPanel.ShowDialog();
            this.Close();
        }

        private void btn_presentedLessons_Click(object sender, EventArgs e)
        {
            TermCourses termCourses = new TermCourses(id);
            termCourses.ShowDialog();
            this.Close();
        }

        private void StudentPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

    }
}