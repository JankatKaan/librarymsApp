using System.Threading.Tasks;
using librarymsApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace librarymsApp.Controllers{

    // Ödünç verme işlemlerini yöneten controller
    public class BookBorrowController : Controller{

        private readonly DataContext _context;

        public BookBorrowController(DataContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            return View(await _context.BookBorrows.Include(x=>x.Book).Include(x=>x.Member).ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Create(){
            ViewBag.Books =new SelectList(await _context.Books.Where(b => !_context.BookBorrows.Any(bb => bb.BookId == b.BookId)).ToListAsync(), "BookId", "Title");
            ViewBag.Members = new SelectList(await _context.Members.ToListAsync(), "MemberId", "NameSurname");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookBorrow model){
            model.BorrowDate = DateTime.Now;
            _context.BookBorrows.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id){
            if(id == null){
                return NotFound();
            }

            var bookBorrow = await _context.BookBorrows.Where(x=>x.BorrowId==id).Include(x=>x.Book).Include(x=>x.Member).FirstAsync();

            if(bookBorrow == null){
                return NotFound();
            }

            return View(bookBorrow);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm]int id){
            var bookBorrow = await _context.BookBorrows.FindAsync(id);
            if(bookBorrow == null){
                return NotFound();
            }
            _context.BookBorrows.Remove(bookBorrow);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}