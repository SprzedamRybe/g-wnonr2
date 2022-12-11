using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dziennik
{
    class Subject
    {
        private string subjectname;
        List<float> Grades = new List<float>();


        public string GetSubjectname()
        {
            return subjectname;
        }

        public Subject(string sub)
        {
            subjectname = sub;
        }

        
        public void AddGrade(float grade)
        {
            Grades.Add(grade);
        }
        public void DelGrade(float grade)
        {

            Grades.Remove(grade);


        }

        public void GetGrades()
        {

            Console.Write($"Twoja lista ocen z {subjectname}: ");

            for (int i = 0; i < Grades.Count; i++)
            {
                if (Grades.Count - 1 > i)
                {

                    Console.Write(Grades[i] + ", ");
                }
                else
                {

                    Console.Write(Grades[i] + ".");
                }
            }


            Console.WriteLine();
        }

        public void GetAverage()
        {
            if (Grades.Count == 0)
            {
                Console.WriteLine("Nie masz jeszcze ocen");
            }
            else
            {
                Console.WriteLine("Twoja średnia ocen: " + Grades.Average());
            }
        }

    }
}
