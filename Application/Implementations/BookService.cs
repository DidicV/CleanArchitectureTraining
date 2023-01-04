using Application.Interfaces;
using Domain;
using Infrastructure.Interfaces;

namespace Application.Implementations
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void CreateBook(Book book)
        {
            _bookRepository.CreateBook(book);
        }

        public List<Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }

        public Book? GetBookById(Guid id)
        {
            return _bookRepository.GetBookById(id);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }

        public void DeleteBook(Book book)
        {
            _bookRepository.DeleteBook(book);
        }
    }
}
