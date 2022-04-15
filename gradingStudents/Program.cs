using System;
using System.Collections.Generic;

namespace gradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = gradingStudents(new List<int> { 73, 67, 38, 33 });
            Console.ReadLine();
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> students = new List<int>();
            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    students.Add(grade);
                    continue;
                }
                int afterMod = 5 - grade % 5;
                if (afterMod < 3)
                {
                    students.Add(grade + afterMod);
                }
                else
                {
                    students.Add(grade);
                }
            }
            return students;
        }
    }
}
