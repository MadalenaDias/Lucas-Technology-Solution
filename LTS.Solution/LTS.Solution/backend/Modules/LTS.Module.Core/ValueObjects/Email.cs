using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.ValueObjects
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
