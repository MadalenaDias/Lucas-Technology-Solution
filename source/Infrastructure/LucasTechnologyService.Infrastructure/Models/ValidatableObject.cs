using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyService.Infrastructure.Models
{
    public abstract class ValidatableObject
    {
        public virtual bool IsValid()
        {
            return Validate().Count == 0;
        }

        public virtual IList<ValidationResult> Validate()
        {
            IList<ValidationResult> validationResult = new List<ValidationResult>();
            validator.
        }
    }
}
