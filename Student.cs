using System;
using System.Collections.Generic;
namespace _48
{
    class RegisterStudent:Person //สร้าง Class Register student และใช้การสืบทอดโดยการใช้ Person
    {
        private string studentID; // แค่เพิ่ม student ID เข้ามา ส่วน Password กับ Name
        private List<RegisterStudent> studentlist;

        public RegisterStudent(string name,string password,string studentID)
            :base(name,password) 
        {
            this.studentID = studentID;
            
            
        }
    }
}
