using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LibraryStatisticsAnalyzerTests
{
    [TestMethod]
    public void GetBooksByAuthor_ValidAuthor_ReturnsBookList()
    {
        // Arrange
        var manager = new LibraryManager();
        var analyzer = new LibraryStatisticsAnalyzer(manager);
        var author = "Author 1";
        var expectedBook = new Book { Title = "Book 1", Author = author };
        manager.AddBook(expectedBook);

        // Act
        var result = analyzer.GetBooksByAuthor(author);

        // Assert
        CollectionAssert.Contains(result, expectedBook);
    }

    [TestMethod]
    public void GetBookByTitle_ValidTitle_ReturnsBook()
    {
        // Arrange
        var manager = new LibraryManager();
        var analyzer = new LibraryStatisticsAnalyzer(manager);
        var title = "Book 1";
        var expectedBook = new Book { Title = title, Author = "Author 1" };
        manager.AddBook(expectedBook);

        // Act
        var result = analyzer.GetBookByTitle(title);

        // Assert
        Assert.AreEqual(expectedBook, result);
    }

    [TestMethod]
    public void GetBookByArticul_ValidArticul_ReturnsBook()
    {
        // Arrange
        var manager = new LibraryManager();
        var analyzer = new LibraryStatisticsAnalyzer(manager);
        var articul = "123456";
        var expectedBook = new Book { Title = "Book 1", Author = "Author 1", Articul = articul };
        manager.AddBook(expectedBook);

        // Act
        var result = analyzer.GetBookByArticul(articul);

        // Assert
        Assert.AreEqual(expectedBook, result);
    }
}