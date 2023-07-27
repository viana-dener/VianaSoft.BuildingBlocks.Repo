namespace VianaSoft.BuildingBlocks.Core.Pagination
{
    public class Pager
    {
        private const int _maxItemsPerPage = 50;
        private const int _minItemsPerPage = 10;
        private int page;
        private int itemsPerPage;
        private string? orderBy;
        private string? orderType;

        public int Page
        {
            get { return page <= 0 ? 1 : page; }
            set { page = value; }
        }
        public int ItemsPerPage
        {
            get { return itemsPerPage <= 0 ? _minItemsPerPage : itemsPerPage > _maxItemsPerPage ? _maxItemsPerPage : itemsPerPage; }
            set { itemsPerPage = value; }
        }
        public string? OrderBy
        {
            get { return !string.IsNullOrWhiteSpace(orderBy) ? orderBy : "id"; }
            set { orderBy = value; }
        }
        public string? OrderType
        {
            get { return !string.IsNullOrWhiteSpace(orderType) && (orderType.ToLower().Equals("asc") || orderType.ToLower().Equals("desc")) ? orderType : "asc"; }
            set { orderType = value; }
        }

        public static int MaxItemsPerPage() => _maxItemsPerPage;
        public static int MinItemsPerPage() => _minItemsPerPage;
    }
}
