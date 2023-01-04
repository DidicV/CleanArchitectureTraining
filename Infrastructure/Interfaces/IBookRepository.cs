using Domain;

namespace Infrastructure.Interfaces
{
    public interface IBookRepository
    {
        void CreateBook(Book book);

        List<Book> GetBooks();

        Book? GetBookById(Guid id);

        void UpdateBook(Book book);

        void DeleteBook(Book book);
    }
}
