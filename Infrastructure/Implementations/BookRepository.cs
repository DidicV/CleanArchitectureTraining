using Domain;
using Infrastructure.Interfaces;

namespace Infrastructure.Implementations
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book? GetBookById(Guid id)
        {
            return _context.Books.Find(id);
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
