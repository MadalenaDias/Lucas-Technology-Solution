// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface ICompoundItemSelectorViewRepository
    {
        /// <summary>
        /// Performs count on ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of ICompoundItemSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "CompoundItemSelectorView" class from ICompoundItemSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "CompoundItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for ICompoundItemSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "CompoundItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "CompoundItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "CompoundItemSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "CompoundItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "CompoundItemSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from ICompoundItemSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "CompoundItemSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.CompoundItemSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}