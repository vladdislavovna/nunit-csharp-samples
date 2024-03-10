public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer()
    {
        _manager = new LibraryManager();
    }

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }

    /// <summary>
    /// Gets books by author.
    /// </summary>
    /// <param name="author">Book author.</param>
    /// <returns>Book list.</returns>
    public List<Book> GetBooksByAuthor(string author)
    {
        return _manager.Books.Where(b => b.Author == author).ToList();
    }

    /// <summary>
    /// Gets book by title.
    /// </summary>
    /// <param name="title">Book title.</param>
    /// <returns>Book.</returns>
    public Book? GetBookByTitle(string title)
    {
        return _manager.Books.FirstOrDefault(b => b.Title == title);
    }

    /// <summary>
    /// Gets book by articul.
    /// </summary>
    /// <param name="articul">Book articul.</param>
    /// <returns>Book.</returns>
    public Book? GetBookByArticul(string articul)
    {
        return _manager.Books.FirstOrDefault(b => b.Articul == articul);
    }
}