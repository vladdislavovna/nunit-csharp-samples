/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    public List<Book> Books => _books;

    public LibraryManager()
    {
        _books = [];
    }

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        if (_books.FirstOrDefault(a => a.Articul == book.Articul) != null)
            return;
        _books.Add(book);
    }

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        _books.Remove(book);
    }
}