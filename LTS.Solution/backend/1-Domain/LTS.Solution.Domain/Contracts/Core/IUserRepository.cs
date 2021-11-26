using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LTS.Solution.Domain.Models.Core;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IUserRepository
    {
        Task<User> GetById(Guid id);
        Task<User> GetByCreatedOn(DateTimeOffset createdOn);
        Task<User> GetByLatestUpdatedOn(string latestUpdatedOn);
        Task<IEnumerable<User>> GetAll();

        void Add(User user);
        void Update(User user);
        void Remove(User user);
         
    }
}