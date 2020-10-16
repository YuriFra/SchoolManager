using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Data;
using SchoolManager.Models;

namespace SchoolManager.Pages.Lessons
{
    public class CreateModel : PageModel
    {
        private readonly SchoolManager.Data.SchoolDbContext _context;

        public CreateModel(SchoolManager.Data.SchoolDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["TeacherList"] = new SelectList(_context.Teachers, "Name", "FirstName");
            return Page();
        }

        [BindProperty]
        public Lesson Lesson { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lessons.Add(Lesson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
