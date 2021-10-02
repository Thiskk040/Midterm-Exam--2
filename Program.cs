using System;

enum Menu
{
    Login = 1,
    Register = 2,
    
}
namespace _48
{
    class Program
    {
        static Personlist personlist;

        static void Main(string[] args)
        {
            
            printmueuscreen();
        }
        
        static void printmueuscreen()
        {
            Personlist student1 = new Personlist();
            Console.Clear();
            Printheader();
            Printlistmeun();
            inputmenuformkb();
           

        }
        static void Printheader()//หน้า Login
        {
            Console.WriteLine("Welcome to Digital library");
            Console.WriteLine("-----------------------------------");
        }
        static void Printlistmeun()// หน้า Menu
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            
        }
        static void inputmenuformkb()//รับค่าจาก Keyboard
        {
            Console.Write("Select the menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            Persentmenu(menu);
        }

        static void Persentmenu(Menu menu)//เมดทอดฟังก์ชั่นที่เอาไว้สำหรับ แสดง Menuต่างๆ
        {
            if (menu == Menu.Login)
            {
                ShowLoginScreen();
            }
            else if (menu == Menu.Register)
            {
                ShowInputRegisterNewPerson();
            }
            else
            {
                ShowMessageNewIsincorrect();
            }
        }

        
        static void ShowLoginScreen()// คำสั่ง Login
        {
            Console.Clear();
            PrintHeaderLogin();  
        }
        
        

        static void PrintHeaderLogin()//เขียนหน้า Login
        {
            Console.WriteLine("Login screen");
            Console.WriteLine("--------------------");
            LoginTheprogram();
        }
        
        
       
        static void ShowMessageNewIsincorrect()//โชว์ขึ้นเมื่อ User กรอกรหัสไม่ถูกต้อง
        {
            Console.Clear();
            Console.WriteLine("Error Please try again !!!");
            Console.WriteLine("**************************");
            inputmenuformkb();
        }
        static void ShowInputRegisterNewPerson()// คำสั่ง Register new Person
      
       {
           Console.Clear();
           PrintRegisterTeacher();
            Console.WriteLine("Input user type");
            Console.WriteLine("Input:1 = Student ");
            Console.WriteLine("Input:2 = Employee");
            Console.Write("Selected: ");
            int input = int.Parse(Console.ReadLine());

            if(input == 1)//ใส่ 1 ถ้าเป็นการลงทะเบียนนักเรียน
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Register Student");
                RegisterStudent student = CreatenewStudent();
                Program.personlist.Addnewperson(student);
            }
            else if(input == 2)//ใส่ 2 ถ้าเป็นการลงทะเบียนพนักงาน
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Register Empolyee");
                RegisterEmpolyee empolyee = CreatenewEmployee();
                Program.personlist.Addnewperson(empolyee);
            }
            else
            {
                ShowMessageNewIsincorrect();
            }
            
       }
        
        static void ShowMenuForEmpolyee()
        {
            Console.WriteLine("Empolyee Management");
            Console.WriteLine("-------------------");

            Console.Write("Name: {0}");
            Console.Write("EmpolyeeID: {0}");
            
        }
        static void PrintRegisterTeacher()//เขียนหน้า Register new Person
            {
                Console.WriteLine("Register  new  person");
                Console.WriteLine("----------------------");
            }
        
        
        static string Inputname()///ใส่ชื่อ
        {
            Console.Write("Input name: ");

            return Console.ReadLine();
        }
        static string InputPassword()//ใส่ Password
        {
            Console.Write("Input password: ");
            return Console.ReadLine();
        }
        static string InputStudentID()//ใส้ Student id
        {
            Console.Write("StudentID: ");
            return Console.ReadLine();
        }
        static string InputEmpolyeeID()//ใส่ Empolyee
        {
            Console.Write("EmpolyeeID: ");
            return (Console.ReadLine());
        }
        static void PrintListBook()
        {
            Book book1 = new Book("Now I Understand", "1");
            Book book2 = new Book("Revoluntary Health", "2");
            Book book3 = new Book("Six Degrees", "3");
            Book book4 = new Book("Les Vacances", "4");

            book1.Combine();
            book2.Combine();
            book3.Combine();
            book4.Combine();
        }


        static RegisterEmpolyee CreatenewEmployee() //เมดทอดสร้าง NewEmpolyee
        {
            return new RegisterEmpolyee (Inputname(),
                InputPassword(),
                InputEmpolyeeID()
                );
        }
        static RegisterStudent CreatenewStudent()// เมดทอดสร้าง NewStudent
        {
            return new RegisterStudent(Inputname(),
                InputPassword(),
                InputStudentID()
               );
        }
       static Person LoginTheprogram()// เมดทอด Login Program 
        {
            return new Person(Inputname(),
                InputPassword());
        }

        


        
       
    }
}
