using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolManager.Data;
using SchoolManager.Models;

namespace SchoolManager.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private readonly SchoolManager.Data.SchoolDbContext _context;

        public IndexModel(SchoolManager.Data.SchoolDbContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get;set; }

        public async Task OnGetAsync()
        {
            Teacher = await _context.Teachers.ToListAsync();
        }
    }
}
