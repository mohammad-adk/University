using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{


    [System.Serializable]
    class Master
    {
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }
        public ulong id
        {

            get; set;
        }
        public string password
        {
            get; set;
        }
        public List<Course> lessons
        {
            get; set;
        }
        //-------------------------------
        public Master(string firstName, string lastName, List<Course> lessons)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Node<Master> lastMasterRow = Universal.instance.lastMst;
            Node<Master> lastMaster = lastMasterRow;
            while (lastMaster.next != null)
            {
                lastMaster = lastMaster.next;
            }
            id = lastMaster == null ? 97000000000 : (lastMaster.info.id + 1);
            password = lastMaster == null ? "97000000000" : (lastMaster.info.id + 1).ToString();
            this.lessons = lessons;
        }
        public bool EditPassword(string currentPassWord, string newPassword, string newPasswordAgain)
        {
            if (currentPassWord != this.password)
            {
                // Have To Show Error
                return false;
            }
            else
            {
                if (newPassword != newPasswordAgain)
                {
                    // Have To Show Error
                    return false;
                }
                else
                {
                    this.password = newPassword;
                    return true;
                }
            }

            //End of Method
        }
        public void insertingGrade(string id, int grade, int code)
        {
            Node<Student> std;
            std = Manager.SearchStudent(id);
            Course crs = std.info.choosenLessons[0];
            int i;
            for (i = 0; i < std.info.choosenLessons.Count; i++)
            {
                if (std.info.choosenLessons[i].code == code)
                {
                    break;
                }
            }
            std.info.choosenLessons[i].grade = grade;
        }
    }
}


