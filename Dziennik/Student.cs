using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dziennik
{
    class Student
    {
        private string name;
        private string secname;

        List<Subject> subject = new List<Subject>();

        


        public void GetName()
        {
            Console.Write(name +" " + secname +". ");
            Console.WriteLine();
        }

        public void AddSubjectDiary(string subjectname)
        {
            subject.Add(new Subject(subjectname));
        }

        public Student(string namee, string secnamee)
        {
            name = namee;
            secname = secnamee;
        }

        public void AddGrade(float grade,string sub)
        {

            for (int i = 0; i < subject.Count; i++)
            {
                if(sub == subject[i].GetSubjectname())
                {
                    subject[i].AddGrade(grade);
                }
            }

            
            
        }
        public void DelGrade(float grade, string sub)
        {

            for (int i = 0; i < subject.Count; i++)
            {
                if (sub == subject[i].GetSubjectname())
                {
                    subject[i].DelGrade(grade);
                }
            }


        }

        public void GetGrades(string sub)
        {
            
            
            foreach (var item in subject)
            {
                if(sub == item.GetSubjectname())
                {
                    item.GetGrades();
                }

                
                

            }
           
            
            Console.WriteLine("");
        }

        public void GetAverage(string sub)
        {
            foreach (var item in subject)
            {
                if (sub == item.GetSubjectname())
                {
                    item.GetAverage();
                }




            }
        }

    }
}
