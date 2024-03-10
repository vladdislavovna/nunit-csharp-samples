using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LibraryManagerTests
{
    [TestMethod]
    public void AddBook_ValidBook_Success()
    {
        // Arrange
        var manager = new LibraryManager();
        var book = new Book { Title = "Book 1", Author = "Author 1" };

        // Act
        manager.AddBook(book);

        // Assert
        var books = manager.Books;
        CollectionAssert.Contains(books, book);
    }

    [TestMethod]
    public void AddBook_NullBook_ThrowsArgumentNullException()
    {
        // Arrange
        var manager = new LibraryManager();

        // Act & Assert
        Assert.ThrowsException<ArgumentNullException>(() => manager.AddBook(null));
    }

    [TestMethod]
    public void RemoveBook_ExistingBook_Success()
    {
        // Arrange
        var manager = new LibraryManager();
        var book = new Book { Title = "Book 1", Author = "Author 1" };
        manager.AddBook(book);

        // Act
        manager.RemoveBook(book);

        // Assert
        var books = manager.Books;
        Assert.AreEqual(0, books.Count);
    }
}