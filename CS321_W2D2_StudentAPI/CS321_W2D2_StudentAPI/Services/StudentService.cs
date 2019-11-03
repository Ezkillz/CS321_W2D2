using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using CS321_W2D2_StudentAPI.Models;

namespace CS321_W2D2_StudentAPI.Services
{
    public class StudentService: IStudentsService
    {
        private List<Student> _student = new List<Student>()
        {
            new Student
            {
                Id = 1,
                FirstName = "John",
                LastName= "Doe",
                BirthDate = new DateTime(2010,1,1),
                Email ="john.doe@test.com",
                Phone = "555.555.5555"
            },
            new Student
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                BirthDate= new DateTime(2012,1,1),
                Email = "jane.smith@test.com",
                Phone = "555.555.5555"
            }
        };
        private int _nextId = 3;

        // implementations of IStudentServices  
        public IEnumerable<Student> GetAll()
        {
            return _student;
        }
        // Get(int id)
        public Student Get(int id)
        {
            var student = _student.FirstOrDefault(s => s.Id == id);
            return student;
        }
        // Add (Student student)
        public Student Add(Student student)
        {
            ValidateBithdate(student);
            student.Id = _nextId++;
            _student.Add(student);
            return student;
        }
        // Checking Age/ DateOfBirth
        public void ValidateBithdate(Student student)
        {
            if(student.BirthDate > DateTime.Now)
            {
                throw new Exception("Birthdate cant be in future!");
            }
            if(DateTime.Now.Year - student.BirthDate.Year>18)
            {
                throw new Exception("You are ")
            }
        }
        //Update
        public Student Update(Student student)
        {
            var currentStudent = this.Get(student.Id); // student.FirstOrDefault(s => s.Id == id)
            if (currentStudent == null) return null;
            currentStudent.FirstName = student.FirstName;
            currentStudent.LastName = student.LastName;
            currentStudent.BirthDate = student.BirthDate;
            currentStudent.Email = student.Email;
            currentStudent.Phone = student.Phone;
            return currentStudent;
        }
        // Remove
        public void Remove(Student student)
        {
            _student.Remove(student);
        }
    }
}
