/* 
Exercise 2: Student Dictionary (Medium)
Description: Create a Dictionary<int, string> to store a list of students, where the key is the student ID (int) and the value is the student name (string). Implement the following functions:

Add new students.
Remove a student by ID.
Find a student by ID.
Display all students.

Requirements:
Use Dictionary<int, string> to store students.
Implement the functions as separate methods.
Ensure that each student ID is unique.

Tips:
Use ContainsKey to check if an ID already exists before adding a student.
Use Remove() and TryGetValue() to manage entries in the dictionary.
 */

namespace Collection
{
    class Program
    {
        private static Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Caio"},
            {2, "Niedja"},
            {3, "Rodrigo"}
        };
        static void Main(string[] args)
        {
            DisplayStudents(students);
            AddNewStudent(4, "Claudia");
            RemoveStudentById(2);
            FindStudentById(4);
            DisplayStudents(students);
        }

        static void AddNewStudent(int id, string name)
        {
            if (students.ContainsKey(id))
            {
                Console.WriteLine($"The student ID: {id} already exists.");
                return;
            }
            students.Add(id, name);
            Console.WriteLine($"Student {name} added.");

        }

        static void RemoveStudentById(int id)
        {
            if (students.Remove(id))
            {
                Console.WriteLine($"Student with {id} was removed.");
            }
            else
            {
                Console.WriteLine($"This ID {id} doesn't exist.");
            }
        }

        static void FindStudentById(int id)
        {
            if (students.TryGetValue(id, out string name))
            {
                Console.WriteLine($"The student with ID {id} is {name}.");

            }
            else
            {
                Console.WriteLine("Student not found.");
            }

        }

        static void DisplayStudents(Dictionary<int, string> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students in the list.");
                return;
            }

            Console.WriteLine("Student list:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}