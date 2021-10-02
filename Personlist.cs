using System;
using System.Collections.Generic;
namespace _48
{
    class Personlist //เป็นคลาสที่เอาไว้สำหรับ List ค่า เพื่อที่จะเก็บค่าไว้ ไปที่หน้า Login 
    {
        private List<RegisterStudent> studentlist;
        private List<RegisterEmpolyee> employeelist;

        public Personlist()
        {
            this.studentlist = new List<RegisterStudent>();
            this.employeelist = new List<RegisterEmpolyee>();
        }

        public static Personlist student1 { get; internal set; }

        public void Addnewperson(RegisterStudent student,RegisterEmpolyee employee)
        {
          studentlist.Add(student);
          employeelist.Add(employee);
        }

        internal void Addnewperson(RegisterStudent student)
        {
            throw new NotImplementedException();
        }

        internal void Addnewperson(RegisterEmpolyee empolyee)
        {
            throw new NotImplementedException();
        }
    }
}
