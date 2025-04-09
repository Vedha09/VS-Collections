using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIS
{
    internal class Course
    {
        public int courseId;
        public string courseName;
        public string courseCode;
        public string instructorName;
        
        public int CourseID
        {
            set
            {
                courseId = value;
            }
            get
            {
                return courseId;
            }
        }
        public string CourseName
        {
            set
            {
                courseName = value;
            }
            get
            {
                return courseName;
            }
        }
        public string CourseCode
        {
            set
            {
                courseCode = value;
            }
            get
            {
                return courseCode;
            }
        }
        public string InstructorName
        {
            set
            {
                instructorName = value;
            }
            get
            {
                return instructorName;
            }
        }
        public List<Enrollment> Enrollments = new List<Enrollment>();
        
        public Course(int courseId, string courseName, string courseCode, string instructorName)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.instructorName = instructorName;
        }

        public string GetTeacher()
        {
            return instructorName;
        }

        public Course(string name, string code)
        {
            if (string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(courseCode))
                throw new InvalidCourseDataException("Invalid course name or code.");
            CourseName = name;
            CourseCode = code;
        }

        public void AssignTeacher(Teacher teacher)
        {
            InstructorName = "";
            teacher.AssignedCourses.Add(this);
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            Enrollments.Add(enrollment);
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Course ID: {CourseID}, Course Name: {CourseName}, Course Code: {CourseCode}, Instructor Name: {InstructorName} ");
        }
    }
}
