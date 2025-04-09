using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIS
{
    internal class Student
    {
        public int studentId;
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string email;
        public string phoneNumber;
        public decimal balance;
        public int StudentID
        {
            set
            {
                studentId = value;
            }
            get
            {
                return studentId;
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
        public string DateOfBirth
        {
            set
            {
                dateOfBirth = value;
            }
            get
            {
                return dateOfBirth;
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
        public string PhoneNumber
        {
            set
            {
                phoneNumber = value;
            }
            get
            {
                return phoneNumber;
            }
        }

        public decimal Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

        public List<Enrollment> Enrollments = new List<Enrollment>();
        public List<Payment> Payments = new List<Payment>();

        public Student(int studentID, string firstName, string lastName, string dateOfBirth, string email, string phoneNumber)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(email))
                throw new InvalidStudentDataException("Invalid student data provided.");
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Student(string firstName, string email, decimal balance)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(email))
                throw new InvalidStudentDataException("Invalid student name or email.");
            FirstName = firstName;
            Email = email;
            Balance = balance;
        }
        public void MakePayment(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientFundsException("Not enough funds to complete the payment.");
            Balance -= amount;
            Console.WriteLine($"Payment of {amount:C} successful. Remaining balance: {Balance:C}");
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {StudentID}, Student Name: {FirstName} {LastName}, Date of Birth: {DateOfBirth}, Email: {Email}, Phone: {PhoneNumber}");
        }
    }
}
