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
            Validation val = new Validation();
            string input;
            bool flag5;
            do
            {
                flag5 = false;
                
                    Console.WriteLine("Odaberite operaciju");
                    input = Console.ReadLine();
                    val.CheckOperation(input);

                    if (val.EnlistInput)
                    {
                        enlist();

                    }
                    else if (val.DisplayInput)
                    {
                        display();

                        flag5 = true;
                    }


            } while (!flag5);

        }


        public static void enlist()
        {
            Student novistudent = new Student();
            Validation val = new Validation();
       
            string gpa;
            int id;
            string name, lastname;

            do {
                Console.WriteLine("Unesite ime studenta");
                name = Console.ReadLine();
                novistudent.name = name;
                val.CheckForNull(name);
            }while(!val.CheckForNullInput);

            do{
                Console.WriteLine("Unesite prezime studenta");
                lastname = Console.ReadLine();
                novistudent.lastname = lastname;
                val.CheckForNull(lastname);
            } while (!val.CheckForNullInput);

            do{

                Console.WriteLine("Unesite GPA studenta");
                gpa = Console.ReadLine();
                val.CheckGpa(gpa);

            } while (!val.GpaInput);
            novistudent.gpa = gpa;

            StudentContainer lista = StudentContainer.Instance;
            lista.AddTopopis(novistudent);

            StudentIdGenerator ID = StudentIdGenerator.Instance;
            novistudent.id = ID.IncID();
        }

        public static void display()
        {
            StudentContainer lista = StudentContainer.Instance;
            List<Student> people = lista.GetList();

            for(int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].id + "," + people[i].name + "," + people[i].lastname + "," + people[i].gpa);
            }


        }
    }
}
