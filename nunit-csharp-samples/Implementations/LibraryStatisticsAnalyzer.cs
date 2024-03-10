public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }
    
    /// <summary>
    /// Gets books by author.
    /// </summary>
    /// <param name="author">Book author.</param>
    /// <returns>Book list.</returns>
    public List<Book?> GetBooksByAuthor(string author)
    {
        List<Book?> books = new List<Book?>();

        foreach (Book? b in _manager.Books)
        {
            if (author == b?.Author)
            {
                books.Add(b);
            }
        }

        return books;
    }
    
    /// <summary>
    /// Gets book by title.
    /// </summary>
    /// <param name="title">Book title.</param>
    /// <returns>Book.</returns>
    public Book? GetBookByTitle(string title)
    {
        foreach (Book? b in _manager.Books)
        {
            if (title == b?.Title)
            {
                return b;
            }
        }

        return null;
    }

    /// <summary>
    /// Gets book by articul.
    /// </summary>
    /// <param name="articul">Book articul.</param>
    /// <returns>Book.</returns>
    public Book? GetBookByArticul(string articul)
    {
        foreach (Book? b in _manager.Books)
        {
            if (articul == b?.Articul)
            {
                return b;
            }
        }

        return null;
    }
}