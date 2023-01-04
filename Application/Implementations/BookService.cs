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
            // Upper case first letter
            book.Title = char.ToUpper(book.Title[0]) + book.Title.Substring(1);

            book.Author = char.ToUpper(book.Author[0]) + book.Author.Substring(1);

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
