using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Exceptions
{
    public class StorageException : Exception
    {
        public StorageException(Exception innerException = null)
           : base(innerException.Message, innerException)
        {
        }

        public StorageException(string message = null, Exception innerException = null)
            : base(message, innerException)
        {
        }
    }
}
