using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureTraining.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            try
            {
                return View(_bookService.GetBooks());
            }
            catch 
            {
                return View();
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,Title,Author")] Book book)
        {
            try
            {
                _bookService.CreateBook(book);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Edit(Guid id)
        {
            var book = _bookService.GetBookById(id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            try
            {
                _bookService.UpdateBook(book);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(Guid id)
        {
            var book = _bookService.GetBookById(id);

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var book = _bookService.GetBookById(id);

            _bookService.DeleteBook(book);

            return RedirectToAction("Index");
        }
    }
}
