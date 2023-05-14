using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n----- Student Control System -----");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter student marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            Student student = new Student { Id = id, Name = name, Marks = marks };
            students.Add(student);

            Console.WriteLine("Student added successfully!");
        }

        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n----- List of Students -----");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Marks: {student.Marks}");
            }
        }

        static void UpdateStudent()
        {
            Console.Write("Enter student ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student? student = students.Find(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter updated student name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter updated student marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            student.Name = name;
            student.Marks = marks;

            Console.WriteLine("Student updated successfully!");
        }

         static void DeleteStudent()
         {
         Console.Write("Enter student ID to delete: ");
         if (int.TryParse(Console.ReadLine(), out int id))
          {
         bool studentExists = students.Any(student => student.Id == id);
           if (studentExists)
         {
            students.RemoveAll(student => student.Id == id);
            Console.WriteLine("Student deleted successfully!");
         }
         else
         {
            Console.WriteLine("Student not found.");
         }
         }
         else
         {
          Console.WriteLine("Invalid input. Please enter a valid student ID.");
         }
       }
     }
}
