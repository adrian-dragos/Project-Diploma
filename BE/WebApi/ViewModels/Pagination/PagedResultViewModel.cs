namespace WebApi.ViewModels.Pagination
{
    public sealed class PagedResultViewModel<T>
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public IList<T> Items { get; set; }
    }
}
