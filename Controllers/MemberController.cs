using System.Threading.Tasks;
using librarymsApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace librarymsApp.Controllers{

    // Üye işlemlerini yöneten controller
    public class MemberController : Controller{

        private readonly DataContext _context;

        public MemberController(DataContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            return View(await _context.Members.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Member model){

            _context.Members.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id){
            if(id == null){
                return NotFound();
            }
            var member = await _context.Members.FindAsync(id);

            if(member == null){
                return NotFound();
            }
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Member model){
            if(id != model.MemberId){
                return NotFound();
            }

            if(ModelState.IsValid){
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!_context.Members.Any(b=>b.MemberId == model.MemberId)){
                        return NotFound();
                    }
                    else{
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id){
            if(id == null){
                return NotFound();
            }

            var member = await _context.Members.FindAsync(id);

            if(member == null){
                return NotFound();
            }

            return View(member);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm]int id){
            var member = await _context.Members.FindAsync(id);
            if(member == null){
                return NotFound();
            }
            _context.Members.Remove(member);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}