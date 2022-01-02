using LTSSolution.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.ValueObjects
{
    public class Name : EntityBase
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;


        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
