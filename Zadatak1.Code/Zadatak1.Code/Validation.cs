using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Code
{
    public class Validation
    {
        public bool EnlistInput;
        public bool DisplayInput;
        public bool CheckForNullInput;
        public bool GpaInput;
        double Temp;

        public void CheckOperation(string s)
        {
            EnlistInput = false;
            DisplayInput = false;

            if (String.Compare(Operations.enlist, s, true) == 0)
            {
                EnlistInput = true;
            }
            else if (String.Compare(Operations.display, s, true) == 0)
            {
                DisplayInput = true;
            }
            else
            {
                Console.WriteLine("Krivi unos, izaberite izmedu Enlist i Display");
            }
        }
        public void CheckForNull(string a)
        {
            CheckForNullInput = false;
            if (String.IsNullOrEmpty(a))
            {
                CheckForNullInput = false; 
            }
            else
            {
                CheckForNullInput = true;
            }

        }
        public void CheckGpa(string b)
        {
            GpaInput = false;

            double.TryParse(b, out Temp);
            if(Temp >= 1 && Temp <= 5)
            {
                GpaInput = true;
            }
            else
            {
                GpaInput = false;
                Console.WriteLine("Krivi unos za prosjeka, pokusajte opet");
            }
           

        }
    }
}
