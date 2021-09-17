using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBorrowBookCount
{
    class Student
    {
        public int studentId;
        public string studentName;

        public void student(int id, string name)
        {
            studentId = id;
            studentName = name;
        }

        public void getStudentDetails()
        {
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Name: " + studentName + "\n");
        }
    }
}
