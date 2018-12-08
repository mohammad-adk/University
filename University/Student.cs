using System.Collections.Generic;

namespace UniversityClasses
{
    [System.Serializable]
    class Student
    {
        public string firstName
        {
            get; set;
        }
        public string lastName
        {
            get; set;
        }
        public string password
        {
            get; set;
        }
        public ulong id
        {
            get; set;
        }
        public string major;
        public double grade;
        public bool isAbleUnitChoice = false;
        public bool isAbleUnitEdit = false;
        public List<Course> choosenLessons
        {
            get; set;
        }
        public List<Course> passedLessons
        {
            get; set;
        }


        public Student(string firstName, string lastName, string major)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.major = major;
            Node<Student> lastStudentRow = Universal.instance.lastStd;
            Node<Student> lastStudent = lastStudentRow;
            while (lastStudent.next != null)
            {
                lastStudent = lastStudent.next;
            }
            this.id = lastStudent == null ? 97000000000 : lastStudent.info.id + 1;

            this.password = lastStudent == null ? "97000000000" : (lastStudent.info.id + 1).ToString();
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

        public bool addLesson(int code)
        {
            if (isAbleUnitChoice || Universal.instance.isAbleUnitChoice || isAbleUnitEdit || Universal.instance.isAbleUnitEdit)
            {
                Node<Course> plsn = Universal.instance.firstcrs;
                while (plsn != null)
                {
                    if (plsn.info.code == code)
                    {
                        plsn.info.students.Add(this);
                        this.choosenLessons.Add(plsn.info);
                        return true;
                    }
                }
                return false;
            }
            else return false;
            //End of Method
        }

        public bool removeLesson(int code)
        {
            Node<Course> plsn = Universal.instance.firstcrs;
            bool crsFound = false;
            while (plsn != null)
            {
                if (plsn.info.code == code)
                {
                    crsFound = true;
                    break;
                }
            }
            if ((isAbleUnitChoice || Universal.instance.isAbleUnitChoice || isAbleUnitEdit || Universal.instance.isAbleUnitEdit) && crsFound && choosenLessons.Contains(plsn.info))
            {
                plsn.info.students.Remove(this);
                choosenLessons.Remove(plsn.info);
                return true;
            }
            else return false;
        }
    }
}
