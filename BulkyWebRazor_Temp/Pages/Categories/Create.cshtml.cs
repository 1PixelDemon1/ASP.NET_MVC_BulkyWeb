using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    // Same as BindProperty attr but for entire class.
    // [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        
        // It lets us access this prop in post method.
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully!";
            return RedirectToPage("Index");
        }
    }
}
