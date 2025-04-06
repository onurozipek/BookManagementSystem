using BookManagementSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var bookList = _context.Books.ToList();
            return Ok(bookList);
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            var deleteBook = _context.Books.Find(id);
            _context.Books.Remove(deleteBook);
            _context.SaveChanges();
            return Ok();
        }
        
    }
    
    
    
}
