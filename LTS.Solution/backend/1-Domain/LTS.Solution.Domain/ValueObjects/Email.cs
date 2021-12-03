using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;


        }

        public string Address { get; private set; }
    }
}
