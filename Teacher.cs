using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIS
{
    internal class Teacher
    {
        public int teacherId;
        public string firstName;
        public string lastName;
        public string email;
        public string expertise;
        public int TeacherID
        {
            set
            {
                teacherId = value;
            }
            get
            {
                return teacherId;
            }
        }
        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }

        public string Expertise
        {
            set
            {
                expertise = value;
            }
            get
            {
                return expertise;
            }
        }
        public List<Course> AssignedCourses = new List<Course>();

        public Teacher(int teacherID, string firstName, string lastName, string email)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(email))
                throw new InvalidTeacherDataException("Invalid teacher data provided.");

            TeacherID = teacherID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher ID: {TeacherID}, Teacher Name: {FirstName} {LastName},, Email: {Email}, Expertise: {Expertise}");
        }
    }
}
