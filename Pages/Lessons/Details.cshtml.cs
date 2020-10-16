using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Data;
using SchoolManager.Models;

namespace SchoolManager.Pages.Lessons
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolManager.Data.SchoolDbContext _context;

        public DetailsModel(SchoolManager.Data.SchoolDbContext context)
        {
            _context = context;
        }

        public Lesson Lesson { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lesson = await _context.Lessons.FirstOrDefaultAsync(m => m.Id == id);

            if (Lesson == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
