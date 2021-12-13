using LTSSolution.Infrastructure.Models;


namespace LTS.Module.Core.Models
{
    public class Customer : EntityBase
    {
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public CpfCnpj Cpf { get; private set; }
        
    }
}