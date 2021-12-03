using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IContentRepository
    {
        Task<Content> GetById();

        Task<Content> GetByCreatedOn(DateTimeOffset createdOn);

        Task<Content> GetByLatestUpdatedOn(DateTimeOffset latestUpdatedOn);

        Task<IEnumerable<Content>> GetAll();

        void Add(Content content);

        void Update(Content content);

        void Remove(Content content);
    }
}
