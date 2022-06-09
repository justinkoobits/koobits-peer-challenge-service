using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koobits.PeerChallenge.Application.Common.Utilities.Pagination
{
    /// <summary>
    /// Represents the default implementation of the <see cref="IPagedList{T}" /> interface
    /// </summary>
    /// <typeparam name="T">The type of the data to page</typeparam>
    public class PagedList<T> : IPagedList<T>
    {
        /// <inheritdoc />
        public int PageIndex { get; set; }

        /// <inheritdoc />
        public int PageSize { get; set; }

        /// <inheritdoc />
        public int TotalCount { get; set; }

        /// <inheritdoc />
        public int TotalPages { get; set; }

        /// <inheritdoc />
        public int LastNoInPage { get; set; }

        /// <inheritdoc />
        public IList<T> List { get; set; }

        /// <inheritdoc />
        public bool HasPreviousPage => this.TotalPages - (this.TotalCount / this.LastNoInPage) > 1;

        /// <inheritdoc />
        public bool HasNextPage => (this.LastNoInPage) < (this.TotalCount);
        IList IPagedList.List
        {
            get { return (IList)List; }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{T}"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="totalCount">The total count.</param>
        /// <param name="needToSetup">if set to <c>true</c> [need to setup].</param>
        /// <param name="LastNoInPage">The last index in page</param>
        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize, int totalCount, bool needToSetup = true, int LastNoInPage = 0)
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;

            if (needToSetup)
            {
                this.LastNoInPage = pageIndex * pageSize == 0 ? pageSize : pageIndex + 1 * pageSize;
                this.TotalCount = totalCount == 0 && source != null ? source.Count() : totalCount;
                this.List = source.Skip(pageIndex * pageSize).Take(this.PageSize).ToList();
            }
            else
            {
                this.LastNoInPage = LastNoInPage;
                this.TotalCount = totalCount;
                this.List = source.ToList();
            }

            this.TotalPages = (int)Math.Ceiling(this.TotalCount / (double)this.PageSize);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{T}" /> class
        /// </summary>
        /// <param name="source">The Source Collection</param>
        /// <param name="pageIndex">The Page Number</param>
        /// <param name="pageSize">The Page Size</param>
        public PagedList(IEnumerable<T> source, int pageIndex, int pageSize)
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.LastNoInPage = pageIndex * pageSize == 0 ? pageSize : pageIndex + 1 * pageSize;
            this.TotalCount = source.Count();
            this.TotalPages = (int)Math.Ceiling(this.TotalCount / (double)this.PageSize);
            this.List = source.Skip(pageIndex * pageSize).Take(this.PageSize).ToList();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{T}" /> class
        /// </summary>
        public PagedList()
        {
            this.List = new T[0];
        }
    }

    /// <summary>
    /// Provides the implementation of the <see cref="IPagedList{T}" /> and Converter
    /// </summary>
    /// <typeparam name="TSource">The type of the source.</typeparam>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public class PagedList<TSource, TResult> : IPagedList<TResult>
    {
        /// <inheritdoc />
        public int PageIndex { get; }

        /// <inheritdoc />
        public int PageSize { get; }

        /// <inheritdoc />
        public int TotalCount { get; }

        /// <inheritdoc />
        public int TotalPages { get; }

        /// <inheritdoc />
        public int LastNoInPage { get; }

        /// <inheritdoc />
        public IList<TResult> List { get; }
        /// <inheritdoc />
        public bool HasPreviousPage => this.TotalPages - (this.TotalCount / this.LastNoInPage) > 1;

        /// <inheritdoc />
        public bool HasNextPage => (this.LastNoInPage) < (this.TotalCount);

        IList IPagedList.List
        {
            get { return (IList)List; }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{TSource, TResult}" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="converter">The converter.</param>
        /// <param name="pageIndex">The index of the page.</param>
        /// <param name="pageSize">The size of the page.</param>
        /// <param name="indexFrom">The index from. Starting from 1</param>
        public PagedList(IEnumerable<TSource> source, Func<IEnumerable<TSource>, IEnumerable<TResult>> converter, int pageIndex, int pageSize, int indexFrom)
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.LastNoInPage = indexFrom;

            var itemList = source.ToList();
            this.TotalCount = itemList.Count;
            this.TotalPages = (int)Math.Ceiling(this.TotalCount / (double)this.PageSize);

            var items = source.Skip((this.PageIndex - this.LastNoInPage) * this.PageSize).Take(this.PageSize).ToArray();
            this.List = new List<TResult>(converter(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedList{TSource, TResult}" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="converter">The converter.</param>
        public PagedList(IPagedList<TSource> source, Func<IEnumerable<TSource>, IEnumerable<TResult>> converter)
        {
            this.PageIndex = source.PageIndex;
            this.PageSize = source.PageSize;
            this.LastNoInPage = source.LastNoInPage;
            this.TotalCount = source.TotalCount;
            this.TotalPages = source.TotalPages;
            this.List = new List<TResult>(converter(source.List));
        }
    }

    /// <summary>
    /// Provides some help methods for <see cref="IPagedList{T}" /> interface.
    /// </summary>
    public static class PagedList
    {
        /// <summary>
        /// Creates an empty of <see cref="IPagedList{T}" />.
        /// </summary>
        /// <typeparam name="T">The type for paging</typeparam>
        /// <returns>An empty instance of <see cref="IPagedList{T}" />.</returns>
        public static IPagedList<T> Empty<T>() => new PagedList<T>();

        /// <summary>
        /// Creates a new instance of <see cref="IPagedList{TResult}" /> from source of <see cref="IPagedList{TSource}" />
        /// instance.
        /// </summary>
        /// <typeparam name="TResult">The Type of the Result</typeparam>
        /// <typeparam name="TSource">The Type of the Source</typeparam>
        /// <param name="source">The Source</param>
        /// <param name="converter">The Converter</param>
        /// <returns>An instance of <see cref="IPagedList{TResult}" />.</returns>
        public static IPagedList<TResult> From<TResult, TSource>(IPagedList<TSource> source, Func<IEnumerable<TSource>, IEnumerable<TResult>> converter) => new PagedList<TSource, TResult>(source, converter);
    }
}
