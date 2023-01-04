using Domain;

namespace Application.Interfaces
{
    public interface IBookService
    {
        void CreateBook(Book book);

        List<Book> GetBooks();

        Book? GetBookById(Guid id);

        void UpdateBook(Book book);

        void DeleteBook(Book book);
    }
}
