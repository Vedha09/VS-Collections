using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    internal class SIS
    {
        public List<Student> Students = new List<Student>();
        public List<Course> Courses = new List<Course>();
        public List<Teacher> Teachers = new List<Teacher>();
        public List<Enrollment> Enrollments = new List<Enrollment>();
        public List<Payment> Payments = new List<Payment>();

        public void AddStudent(Student student) 
        { 
            Students.Add(student); 
        }
        public void AddCourse(Course course) 
        { 
            Courses.Add(course); 
        }
        public void AddTeacher(Teacher teacher) 
        { 
            Teachers.Add(teacher); 
        }

        public void AddEnrollment(Student student, Course course, DateTime enrollmentDate)
        {
            Enrollment enrollment = new Enrollment(Enrollments.Count + 1, student, course, enrollmentDate);
            student.Enrollments.Add(enrollment);
            course.Enrollments.Add(enrollment);
            Enrollments.Add(enrollment);
        }

        public void AssignCourseToTeacher(Course course, Teacher teacher)
        {
            teacher.AssignedCourses.Add(course);
        }

        public void AddPayment(Student student, decimal amount, DateTime paymentDate)
        {
            Payment payment = new Payment(Payments.Count + 1, student, amount, paymentDate);
            student.Payments.Add(payment);
            Payments.Add(payment);
        }

        public List<Enrollment> GetEnrollmentsForStudent(Student student) 
        { 
            return student.Enrollments; 
        }
        public List<Course> GetCoursesForTeacher(Teacher teacher)
        {
            return teacher.AssignedCourses;
        }
    }
}
