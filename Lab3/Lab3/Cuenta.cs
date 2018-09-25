
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Cuenta
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Cuenta(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string GetSummary()
        {
            return FirstName + " " + LastName;
        }

    }

}
}
