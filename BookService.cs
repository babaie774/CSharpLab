public class BookService
{
    private List<Book> _books = new List<Book>();

    public List<Book> GetBooks()
    {
        return _books;
    }

    public Book GetBook(int id)
    {
        return _books.Find(b => b.Id == id);
    }

    public void CreateBook(Book book)
    {
        _books.Add(book);
    }

    public void UpdateBook(Book book)
    {
        var existingBook = _books.Find(b => b.Id == book.Id);
        if (existingBook != null)
        {
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
        }
    }

    public void DeleteBook(int id)
    {
        var book = _books.Find(b => b.Id == id);
        if (book != null)
        {
            _books.Remove(book);
        }
    }
}