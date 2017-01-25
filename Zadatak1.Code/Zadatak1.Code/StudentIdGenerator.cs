using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Code
{
    public class StudentIdGenerator
    {
        int id1 = 0;
        private static StudentIdGenerator instance;

        private StudentIdGenerator()
        {

        }

        public static StudentIdGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentIdGenerator();
                }
                return instance;
            }
        }
        public int IncID()
        {
            return id1++;
        }
    }
}

