using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Code;


namespace lv1.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation Validation = new Validation();
            string input;
            bool CheckForDisplay;
            do
            {
                CheckForDisplay = false;
                
                    Console.WriteLine("Odaberite operaciju");
                    input = Console.ReadLine();
                    Validation.CheckOperation(input);

                    if (Validation.EnlistInput)
                    {
                        Enlist();

                    }
                    else if (Validation.DisplayInput)
                    {
                        Display();

                        CheckForDisplay = true;
                    }


            } while (!CheckForDisplay);

        }


        public static void Enlist()
        {
            Student NewStudent = new Student();
            Validation Validation = new Validation();
       
            string name, lastname, gpa;

            do {
                Console.WriteLine("Unesite ime studenta");
                name = Console.ReadLine();
                NewStudent.Name = name;
                Validation.CheckForNull(name);
            }while(!Validation.CheckForNullInput);

            do{
                Console.WriteLine("Unesite prezime studenta");
                lastname = Console.ReadLine();
                NewStudent.LastName = lastname;
                Validation.CheckForNull(lastname);
            } while (!Validation.CheckForNullInput);

            do{

                Console.WriteLine("Unesite GPA studenta");
                gpa = Console.ReadLine();
                Validation.CheckGpa(gpa);

            } while (!Validation.GpaInput);
            NewStudent.Gpa = gpa;

            StudentContainer lista = StudentContainer.Instance;
            lista.AddToPopis(NewStudent);

            StudentIdGenerator ID = StudentIdGenerator.Instance;
            NewStudent.Id = ID.IncID();
        }

        public static void Display()
        {
            StudentContainer Lista = StudentContainer.Instance;
            List<Student> People = Lista.GetList();

            for(int i = 0; i < People.Count; i++)
            {
                Console.WriteLine(People[i].Id + ". " + People[i].Name + " " + People[i].LastName + " - " + People[i].Gpa);
            }


        }
    }
}
