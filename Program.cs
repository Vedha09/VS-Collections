using System.Text.RegularExpressions;
using System.Xml.Linq;
using SIS.Data;
using SIS.Models;
using static System.Console;

namespace SIS
{
    class InvalidStudentDataException : ApplicationException
    {
        public InvalidStudentDataException(string message) : base(message) { }
    }

    class InvalidCourseDataException : ApplicationException
    {
        public InvalidCourseDataException(string message) : base(message) { }
    }

    class InvalidEnrollmentDataException : ApplicationException
    {
        public InvalidEnrollmentDataException(string message) : base(message) { }
    }

    class InvalidTeacherDataException : ApplicationException
    {
        public InvalidTeacherDataException(string message) : base(message) { }
    }

    class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    internal class Program
    {
        static void Main()
        {
            //SISDaoImpl SISdaoUtil = new SISDaoImpl();
            //UserInteface ui = new UserInteface();

            //try 
            //{
                /*Console.WriteLine("Enter the Student Id: ");
                int id = ui.GetProductId();*/

                //int result = ao.UpdateProductPrice(id, price);

                /*Student1 s = new Student1();
                s.StudentId = ui.GetStudentId();
                s.FirstName = ui.GetStudentFirstName();
                s.LastName = ui.GetStudentLastName();
                s.DateOfBirth = ui.GetStudentDateOfBirth();
                s.Email = ui.GetStudentEmail();
                s.PhoneNumber = ui.GetStudentPhoneNumber();*/

                /*Console.WriteLine("Enter the Student FirstName: ");
                string firstname = Console.ReadLine();
                Student1 s = SISdaoUtil.GetStudentByFirstName(firstname);
                Console.WriteLine(s);

                Console.WriteLine("Enter the Student LastName: ");
                string lastname = Console.ReadLine();
                Student1 s1 = SISdaoUtil.GetStudentByLastName(lastname);
                Console.WriteLine(s1);
                Console.WriteLine();*/

                //int id = ui.GetStudentId();
                //string firstName = ui.GetStudentName();
                //int result = SISdaoUtil.UpdateStudentName(id, firstName);
                //Console.WriteLine("The Updated Student Name: " + SISdaoUtil.GetStudentById(id));

                /*Console.WriteLine("-------------------------Student List-------------------------");
                List<Student1> studentList = SISdaoUtil.GetAllStudents();
                Display(studentList);*/

                /*Student1 s = new Student1();
                s.StudentId = ui.GetStudentId();
                s.FirstName = ui.GetStudentFirstName();
                s.LastName = ui.GetStudentLastName();
                s.DateOfBirth = ui.GetStudentDateOfBirth();
                s.Email = ui.GetStudentEmail();
                s.PhoneNumber = ui.GetStudentPhoneNumber();
                SISdaoUtil.AddStudent(s);
                int rowsAffected = SISdaoUtil.AddStudent(p);
                Console.WriteLine($"Rows affected: {rowsAffected}");*/

                //GetStudentByID
                /*Console.WriteLine("Enter the Student Id: ");
                int id = int.Parse(ReadLine());
                Student s = SISdaoUtil.GetStudentById(id);
                Console.WriteLine(s);*/

                //GetAllStudents
                /*List<Student1> studentList = SISdaoUtil.GetAllStudents();
                Display(studentList);*/
            //}

            /*catch (Exception e)
            {
                {
                    //Console.WriteLine(e.Message);
                }
            }

            static void Display(List<Student1> studentList)
            {
                foreach (Student1 student in studentList)
                {
                    Console.WriteLine(student);
                }
            }*/

            SIS sis = new SIS();

            Student student = new Student(101, "Alice", "son", "2025-04-07", "alice@gmail.com", "9876543210");
            Course course = new Course(1001, "C# Programming", "CS101", "Mr.John");
            Teacher teacher = new Teacher(201, "Ben", "tom", "bentom@gmail.com");

            sis.AddStudent(student);
            sis.AddCourse(course);
            sis.AddTeacher(teacher);

            sis.AddEnrollment(student, course, DateTime.Now);
            sis.AssignCourseToTeacher(course, teacher);
            sis.AddPayment(student, 1500, DateTime.Now);

            Console.WriteLine("Enrollments for student: ");
            foreach (var e in sis.GetEnrollmentsForStudent(student))
                Console.WriteLine($"{e.Course.CourseName} on {e.EnrollmentDate.ToString()}");

            Console.WriteLine("Courses assigned to teacher: ");
            foreach (var c in sis.GetCoursesForTeacher(teacher))
                Console.WriteLine(c.CourseName);

            SISUtility.DisplayStudentDetails(student);
            SISUtility.DisplayCourseDetails(course);
            SISUtility.DisplayTeacherDetails(teacher);

            Console.WriteLine("SIS executed successfully!!");
        }
    }
}
