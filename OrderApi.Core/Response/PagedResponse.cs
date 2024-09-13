namespace OrderApi.Core.Response
{
    public class PagedResponse<TData> : Response<TData> where TData : class
    {
        public PagedResponse(TData? datas, int pageNumber = 1, int pageSize = 5, int totalPages = 10) : base(datas, message: "Recuperado com sucesso")
        {
            Data = datas;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalPages = totalPages;
        }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}
