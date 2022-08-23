namespace Models.Models
{
    public class PagedModel<T> where T : class
    {
        private int _page;
        private int _pageSize;
        public int Page
        {
            get => _page;
            set
            {
                _page = value <= 0 ? 1 : value;
            }
        }
        public int PageSize
        {
            get => _pageSize;
            set
            {
                _pageSize = value <= 0 ? 5 : value;
            }
        }
        public string SearchString { get; set; }
        public int Skip => _pageSize * (_page - 1);
        public IEnumerable<T> List { get; set; }
        public int PageCount { get; set; }
    }
}
