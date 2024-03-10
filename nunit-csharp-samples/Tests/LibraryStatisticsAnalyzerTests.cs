namespace nunit_csharp_samples.Tests;

using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class LibraryStatisticsAnalyzerTests
{
    [Test]
    public void GetBooksByAuthor_WhenBooksExist_ShouldReturnCorrectListOfBooks()
    {
        // Arrange
        LibraryManager manager = new LibraryManager();
        LibraryStatisticsAnalyzer analyzer = new LibraryStatisticsAnalyzer(manager);
        Book? book1 = new Book { Title = "Book 1", Articul = "111AAA", Author = "Author 1" };
        Book? book2 = new Book { Title = "Book 2", Articul = "222BBB", Author = "Author 2" };
        manager.AddBook(book1);
        manager.AddBook(book2);

        // Act
        List<Book?> booksByAuthor1 = analyzer.GetBooksByAuthor("Author 1");
        List<Book?> booksByAuthor2 = analyzer.GetBooksByAuthor("Author 2");

        // Assert
        Assert.That(booksByAuthor1, Has.Exactly(1).EqualTo(book1));
        Assert.That(booksByAuthor2, Has.Exactly(1).EqualTo(book2));
    }

    [Test]
    public void GetBookByTitle_WhenBookExists_ShouldReturnCorrectBook()
    {
        // Arrange
        LibraryManager manager = new LibraryManager();
        LibraryStatisticsAnalyzer analyzer = new LibraryStatisticsAnalyzer(manager);
        Book? book = new Book { Title = "Test Book", Articul = "123ABC", Author = "John Doe" };
        manager.AddBook(book);

        // Act
        Book? foundBook = analyzer.GetBookByTitle("Test Book");

        // Assert
        Assert.That(foundBook, Is.EqualTo(book));
    }

    [Test]
    public void GetBookByArticul_WhenBookExists_ShouldReturnCorrectBook()
    {
        // Arrange
        LibraryManager manager = new LibraryManager();
        LibraryStatisticsAnalyzer analyzer = new LibraryStatisticsAnalyzer(manager);
        Book? book = new Book { Title = "Test Book", Articul = "123ABC", Author = "John Doe" };
        manager.AddBook(book);

        // Act
        Book? foundBook = analyzer.GetBookByArticul("123ABC");

        // Assert
        Assert.That(foundBook, Is.EqualTo(book));
    }

}
