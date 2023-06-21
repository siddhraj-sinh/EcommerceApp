using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcommerceApp.Data;
using EcommerceApp.Models;

namespace EcommerceApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly EcommerceApp.Data.EcommerceContext _context;

        public IndexModel(EcommerceApp.Data.EcommerceContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products
                .Include(p => p.Category).ToListAsync();
            }
        }
    }
}
