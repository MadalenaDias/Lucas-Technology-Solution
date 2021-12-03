using LTS.Solution.Domain.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Solution.Domain.Contracts.Core
{
    public interface IMediaRepository
    {
        Task<Media> GetById(Guid id);
        Task<Media> GetByCreatedOn(DateTimeOffset createdOn);
        Task<IEnumerable<Media>> GetAll();

        void Add(Media media);
        void Update(Media media);
        void Remove(Media media);
    }
}
