using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dziennik
{
    class Program 
    {

        static void Main(string[] args)
        {
            int nr, id;
            string subject;

            List<string> schoolSubjects = new List<string>();

            schoolSubjects.Add("Biologia");
            schoolSubjects.Add("Historia");
            schoolSubjects.Add("Angielski");
            
            List<Student> uczen = new List<Student>();
            uczen.Add(new Student("Bartek","Kowalski"));
            uczen.Add(new Student("Adam", "Kowzłowski"));          
            uczen.Add(new Student("Damian","Zjeb"));
            uczen.Add(new Student("Przemek", "Prostak"));
            uczen.Add(new Student("Artur","KurwaJebana"));
            uczen.Add(new Student("Wiktor","Wiktor"));

            foreach (var item in uczen)
            {
                foreach (var item2 in schoolSubjects)
                {
                    item.AddSubjectDiary(item2);
                }
            }

            uczen[0].AddGrade(1, "Biologia");
            uczen[0].AddGrade(1, "Biologia");
            uczen[1].AddGrade(1, "Biologia");
            uczen[1].AddGrade(1, "Biologia");
            uczen[2].AddGrade(1, "Biologia");
            uczen[2].AddGrade(1, "Biologia");
            uczen[3].AddGrade(1, "Biologia");
            uczen[4].AddGrade(1, "Biologia");
            uczen[4].AddGrade(1, "Biologia");
            uczen[2].AddGrade(1, "Biologia");
            uczen[2].AddGrade(1, "Biologia");
            uczen[3].AddGrade(1, "Biologia");
            uczen[5].AddGrade(1, "Biologia");
            uczen[5].AddGrade(1, "Biologia");

            uczen[0].AddGrade(2, "Historia");
            uczen[0].AddGrade(2, "Historia");
            uczen[1].AddGrade(2, "Historia");
            uczen[1].AddGrade(2.5f, "Historia");
            uczen[2].AddGrade(2, "Historia");
            uczen[2].AddGrade(2, "Historia");
            uczen[3].AddGrade(2.5f, "Historia");
            uczen[4].AddGrade(2, "Historia");
            uczen[4].AddGrade(2.5f, "Historia");
            uczen[2].AddGrade(2, "Historia");
            uczen[2].AddGrade(2, "Historia");
            uczen[3].AddGrade(2, "Historia");
            uczen[5].AddGrade(2, "Historia");
            uczen[5].AddGrade(2.5f, "Historia");

            uczen[0].AddGrade(3.5f, "Angielski");
            uczen[0].AddGrade(3, "Angielski");
            uczen[1].AddGrade(3, "Angielski");
            uczen[1].AddGrade(3.5f, "Angielski");
            uczen[2].AddGrade(3, "Angielski");
            uczen[2].AddGrade(3, "Angielski");
            uczen[3].AddGrade(3.5f, "Angielski");
            uczen[4].AddGrade(3, "Angielski");
            uczen[4].AddGrade(3.5f, "Angielski");
            uczen[2].AddGrade(3, "Angielski");
            uczen[2].AddGrade(3, "Angielski");
            uczen[3].AddGrade(3, "Angielski");
            uczen[5].AddGrade(3, "Angielski");
            uczen[5].AddGrade(3.5f, "Angielski");

            


            

            



            for (;;)
            {

                
                
                    Menu:

                Console.WriteLine("DZIENNIK");
                Console.WriteLine();
                Console.WriteLine("Przedmioty:");
                for (int i = 0; i <= schoolSubjects.Count; i++)
                {
                    if (i < schoolSubjects.Count)
                    {
                        Console.WriteLine($"{i + 1}. {schoolSubjects[i]}");
                    }else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{schoolSubjects.Count + 1}.Exit");
                    }
                    
                }

                bool result = int.TryParse(Console.ReadLine(), out nr);

                
                Console.Clear();

                if (result && nr == schoolSubjects.Count + 1)
                {
                    Environment.Exit(0);
                }
                else if(result && nr >0 || nr == schoolSubjects.Count)
                {
                    subject = schoolSubjects[nr - 1];
                    {
                        Lista:
                        Console.WriteLine($"Przedmiot: {subject}");
                        Console.WriteLine();
                        Console.WriteLine("Lista uczniów.");
                        Console.WriteLine();

                        for (int i = 0; i < uczen.Count; i++)
                        {
                            
                            if (uczen.Count  > i)
                            {

                                

                                Console.Write($"{i + 1}. ");
                                uczen[i].GetName();
                                if(i==uczen.Count-1)
                                {
                                    Console.Write("Wpisz nr ucznia:");
                                    bool result1 = int.TryParse(Console.ReadLine(), out id);
                                    Console.Clear();

                                    if(id <= uczen.Count && id>0)
                                    {
                                        for (;;)
                                        {
                                            Dziennikucznia:

                                            Console.Write($"Dziennik ucznia nr {id}. ");
                                            uczen[id - 1].GetName();
                                            Console.WriteLine();
                                            uczen[id - 1].GetGrades(subject);
                                            uczen[id - 1].GetAverage(subject);
                                            Console.WriteLine();
                                            Console.WriteLine("1.Dodaj ocenę.");
                                            Console.WriteLine("2.Usuń ocenę.");
                                            Console.WriteLine("3.Lista uczniów.");
                                            Console.WriteLine("4.Menu.");
                                            Console.WriteLine("5.Wyjście.");

                                            bool result2 = int.TryParse(Console.ReadLine(), out nr);
                                            Console.Clear();

                                            if (result2 && nr > 0 || nr > 6)
                                            {
                                                if (nr == 1)
                                                {
                                                    
                                                    float ocena=0;
                                                    Console.Write("Dodaj ocenę: ");
                                                    bool result3 = float.TryParse(Console.ReadLine(), out ocena);
                                                    if (result3 && ocena <= 6)
                                                    {
                                                        uczen[id-1].AddGrade(ocena,subject);
                                                    }else
                                                    {
                                                        Console.WriteLine("Podałeś zły format danych lub zbyt wysoka ocene!");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto Dziennikucznia;

                                                    }

                                                } else if (nr == 2)
                                                {
                                                
                                                    float ocena = 0;
                                                    Console.Write("Dodaj ocenę: ");
                                                    bool result3 = float.TryParse(Console.ReadLine(), out ocena);
                                                    if (result3 && ocena <= 6)
                                                    {
                                                        uczen[id-1].DelGrade(ocena,subject);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Podałeś zły format danych lub zbyt wysoka ocene!");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto Dziennikucznia;

                                                    }

                                                }
                                                else if(nr==3)
                                                {
                                                    goto Lista;

                                                }else if(nr==4)
                                                {
                                                    goto Menu;
                                                }
                                                else
                                                {
                                                    Environment.Exit(0);
                                                }

                                            }else if(result2 ! || nr > 5 || nr <=0)
                                            {
                                                Console.WriteLine("Podałeś błędne dane!");
                                                Console.Clear();
                                            }

                                        }
                                        

                                    }
                                    else
                                    {
                                        Console.WriteLine("Nie ma ucznia o ty numerze.");
                                    }

                                }

                            }
                            
                        }
                    
                    }
                }
                else
                {
                    
                    Console.WriteLine("Podałeś nieprawidłową wartość!!!");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;                          
                    
                }



            }

           


            Console.ReadLine();
            
        }
    }
}
