/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book?> _books = new List<Book?>();
    public List<Book?> Books { get => _books; }

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book? book)
    {
        if(book != null)
            _books.Add(book);
    }

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book? book)
    {
        if (_books.Contains(book))
        {
            _books.Remove(book);
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("The book is not in the collection.");
        }
    }
}