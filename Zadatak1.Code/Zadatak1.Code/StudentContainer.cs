using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Code
{
    public class StudentContainer
    {
        List<Student> popis = new List<Student>();

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

        

        public void AddTopopis(Student a)
        {
            popis.Add(a);
        }

        public List<Student> GetList()
        {
            return popis;
        }
    }

    

}
