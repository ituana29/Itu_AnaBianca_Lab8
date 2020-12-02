using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Itu_AnaBianca_Lab8.Data;
using Itu_AnaBianca_Lab8.Models;

namespace Itu_AnaBianca_Lab8.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Itu_AnaBianca_Lab8.Data.Itu_AnaBianca_Lab8Context _context;

        public DetailsModel(Itu_AnaBianca_Lab8.Data.Itu_AnaBianca_Lab8Context context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
