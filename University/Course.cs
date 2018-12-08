using System;
using System.Collections.Generic;

namespace UniversityClasses
{
    [System.Serializable]
    class Course
    {
        public string name
        {
            get; set;
        }
        public int code
        {
            get; set;
        }
        public Master master;
        public string time
        {
            get; set;

        }
        public string examTime
        {
            get; set;
        }
        public int val
        {
            get; set;
        }
        public int grade
        {
            get; set;
        }
        public List<Student> students
        {
            get; set;
        }

        public Course(string name, int code, int val, string time, string examTime, Master master)
        {
            this.name = name;
            Node<Course> lastLsnRow = Universal.instance.lastcrs;
            Node<Course> lastLsn = lastLsnRow;
            while (lastLsn.next != null)
            {
                lastLsn = lastLsn.next;
            }
            this.code = lastLsn == null ? 100 : (lastLsn.info.code + 1);
            this.val = val;
            this.time = time;
            this.examTime = examTime;
            this.master = master;
        }
    }
}
