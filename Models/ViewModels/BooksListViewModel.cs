namespace Mission11_Fowler.Models.ViewModels
{
    public class BooksListViewModel // Basically a container we can use to pass multiple pieces of data into a view
    {
        public IQueryable<Book> Books { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
