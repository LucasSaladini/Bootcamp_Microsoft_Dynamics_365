using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValueManipulation.Models
{
    public class Course
    {
        public string Name { get; set; }

        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetEnrolledStudentsQuantity()
        {
            int quantity = Students.Count();
            return quantity;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"Alunos do curso de: {Name}");
            for (int count = 0; count < Students.Count; count++)
            {
                string text = "Nº " + count + " - " + Students[count].FullName;
                Console.WriteLine(text);
            }
        }
    }
}