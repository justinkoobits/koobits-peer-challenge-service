using System.Collections;
using System.Collections.Generic;

namespace Koobits.PeerChallenge.Application.Common.Utilities.Pagination
{
    public interface IPagedList
    {
        /// <summary>
        /// Gets the Page Number
        /// </summary>
        int PageIndex { get; }

        /// <summary>
        /// Gets the Page Size
        /// </summary>
        int PageSize { get; }

        /// <summary>
        /// Gets the Total Count of the list of <typeparamref name="T" />
        /// </summary>
        int TotalCount { get; }

        IList List { get; }
    }
    /// <summary>
    /// Provides the interface(s) for paged list of any type
    /// </summary>
    /// <typeparam name="T">The type for paging.</typeparam>
    public interface IPagedList<T> : IPagedList
    {
        /// <summary>
        /// Gets the Index Start Value
        /// </summary>
        int LastNoInPage { get; }





        /// <summary>
        /// Gets the Total Pages
        /// </summary>
        int TotalPages { get; }

        /// <summary>
        /// Gets the Current Page Items
        /// </summary>
        IList<T> List { get; }

        /// <summary>
        /// Gets a value indicating whether the paged list has a previous page
        /// </summary>
        bool HasPreviousPage { get; }

        /// <summary>
        /// Gets a value indicating whether the paged list has a next page
        /// </summary>
        bool HasNextPage { get; }
    }
}
