using System;
using System.Collections.Generic;
namespace _48
{
    class RegisterEmpolyee : Person//สร้าง Class Register Empolyee และใช้การสืบทอดโดยการใช้ Person
    { 
    private string employeeID;// แค่เพิ่ม student ID เข้ามา ส่วน Password กับ Name


        public RegisterEmpolyee(string name,string password,string empolyeeID):base(name,password)
        {
            this.employeeID = employeeID;
           
        }
  }
}
