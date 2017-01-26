using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Code
{
    public class StudentContainer
    {
        List<Student> Lista = new List<Student>();

        private static StudentContainer instance;
        private StudentContainer() { }
        public static StudentContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentContainer();
                }
                return instance;
            }
        }

        

        public void AddToPopis(Student a)
        {
            Lista.Add(a);
        }

        public List<Student> GetList()
        {
            return Sort(Lista);
        }
        public List<Student> Sort(List<Student> studenti)
        {
            return studenti.OrderBy(a => a.LastName).ToList();
        }
    }

    

}
