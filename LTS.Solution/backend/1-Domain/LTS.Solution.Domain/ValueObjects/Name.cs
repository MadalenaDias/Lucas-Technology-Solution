using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.ValueObjects
{
    public class Name : EntityBase
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
                       
            
        }



        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
