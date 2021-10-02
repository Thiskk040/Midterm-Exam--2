using System;
namespace _48
{
    class Person //Class person เป็นคลาสแม่ที่จะสามารถลืบทอด Class ไปต่อ ที่ Register student และ Register empolyee
    {
        protected string name;
        protected string password;

        public Person(string name,string password)
        {
            this.name = name;
            this.password = password;
        }
        public string Getname()//รีีเทรินค่า Getname
        {
            return this.name;
        }
    }
}
