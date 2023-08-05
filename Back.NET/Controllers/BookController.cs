using Back.NET.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Back.NET.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _bookRepository.GetAll();
            var result = View(books);
            return result;
        }
    }
}
