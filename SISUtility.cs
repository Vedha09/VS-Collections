using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    internal class SISUtility
    {
        public static void DisplayStudentDetails(Student student)
        {
            Console.WriteLine($"ID: {student.StudentID}, Name: {student.FirstName} {student.LastName}, Email: {student.Email}");
        }

        public static void DisplayCourseDetails(Course course)
        {
            Console.WriteLine($"ID: {course.CourseID}, Course Name: {course.CourseName}, Course Code: {course.CourseCode}, Instructor: {course.InstructorName}");
        }

        public static void DisplayTeacherDetails(Teacher teacher)
        {
            Console.WriteLine($"ID: {teacher.TeacherID}, Name: {teacher.FirstName} {teacher.LastName}, Email: {teacher.Email}");
        }
    }
}
