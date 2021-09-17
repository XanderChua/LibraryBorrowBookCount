using System;
using System.Collections.Generic;

namespace LibraryBorrowBookCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentInLibrary = new List<Student>();
            List<Book> BookInLibrary = new List<Book>();
            int borrowCount = 0;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("---Library Management System---");
                Console.WriteLine("1. Borrow books");
                Console.WriteLine("2. Amount of books borrowed by students");
                Console.WriteLine("3. Exit");

                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter student ID:");
                            int studentId = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter student name:");
                            string studentname = Console.ReadLine();
                            //Console.WriteLine("\n");
                            Student studentObj = new Student();
                            studentObj.student(studentId, studentname);
                            StudentInLibrary.Add(studentObj);
                            borrowCount++;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Total borrowed books: " + borrowCount + "\n");
                            Console.WriteLine("Students who borrowed books \n");
                            foreach(Student student in StudentInLibrary)
                            {
                                student.getStudentDetails();
                            }
                            break;
                        }
                    case 3:
                        {
                            loop = false;
                            break;
                        }
                }
            }
        }
    }
}
