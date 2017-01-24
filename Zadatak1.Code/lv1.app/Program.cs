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
           // bool flag = false;
           // do {
                Console.WriteLine("Odaberite operaciju");
                string input = Console.ReadLine();

                if (String.Compare(Operations.enlist, input, true) == 0)
                {
                    Console.WriteLine("Operacija uspješno odabrana");
                    enlist();
                }
                else if (String.Compare(Operations.display, input, true) == 0)
                {
                    Console.WriteLine("Operacija uspješno odabrana");
                    display();
                }
                else
                {
                    Console.WriteLine("Operacija neuspješno odabrana");
                   // flag = true;
                }
           // } while (flag == false);
        }

        public static void enlist()
        {
            Student novistudent = new Student();
            float gpa;
            int id;
            string name, lastname;

            Console.WriteLine("Unesite ime studenta");
            name = Console.ReadLine();
            novistudent.name = name;

            Console.WriteLine("Unesite prezime studenta");
            lastname = Console.ReadLine();
            novistudent.lastname = lastname;

            Console.WriteLine("Unesite GPA studenta");
            gpa = float.Parse(Console.ReadLine());
            novistudent.gpa = gpa;

            StudentContainer lista = StudentContainer.Instance;
            lista.AddTopopis(novistudent);
        }

        public static void display()
        {
            StudentContainer lista = StudentContainer.Instance;
            List<Student> people = lista.GetList();

            for(int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].name + "," + people[i].lastname + "," + people[i].gpa);
            }


        }
    }
}
