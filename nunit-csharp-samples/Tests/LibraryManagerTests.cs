using NUnit.Framework;

namespace nunit_csharp_samples.Tests;

using NUnit.Framework;

[TestFixture]
public class LibraryManagerTests
{
    [Test]
    public void AddBook_WhenBookAdded_ShouldContainSameBook()
    {
        // Arrange
        LibraryManager manager = new LibraryManager();
        Book? book = new Book { Title = "Test Book", Articul = "123ABC", Author = "John Doe" };

        // Act
        manager.AddBook(book);

        // Assert
        Assert.That(manager.Books, Contains.Item(book));
    }

    [Test]
    public void AddBook_WhenMultipleBooksAdded_ShouldContainAllBooks()
    {
        // Arrange
        LibraryManager manager = new LibraryManager();
        Book? book1 = new Book { Title = "Book 1", Articul = "111AAA", Author = "Author 1" };
        Book? book2 = new Book { Title = "Book 2", Articul = "222BBB", Author = "Author 2" };

        // Act
        manager.AddBook(book1);
        manager.AddBook(book2);

        // Assert
        Assert.That(manager.Books, Contains.Item(book1));
        Assert.That(manager.Books, Contains.Item(book2));
    }

    [Test]
    public void RemoveBook_WhenBookRemoved_ShouldNotContainRemovedBook()
    {
        // Arrange
        LibraryManager manager = new LibraryManager();
        Book? book = new Book { Title = "Test Book", Articul = "123ABC", Author = "John Doe" };
        manager.AddBook(book);

        // Act
        manager.RemoveBook(book);

        // Assert
        Assert.That(manager.Books, Does.Not.Contains(book));
    }

    [Test]
    public void RemoveBook_WhenBookNotInCollection_ShouldNotModifyCollection()
    {
        // Arrange
        LibraryManager manager = new LibraryManager();
        Book? book1 = new Book { Title = "Book 1", Articul = "111AAA", Author = "Author 1" };
        Book? book2 = new Book { Title = "Book 2", Articul = "222BBB", Author = "Author 2" };
        manager.AddBook(book1);

        // Act
        manager.RemoveBook(book2);

        // Assert
        Assert.That(manager.Books, Contains.Item(book1));
    }
}
