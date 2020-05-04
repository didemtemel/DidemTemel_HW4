using CetBookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewComponents
{
    public class SearchCategoryViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;

        public SearchCategoryViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await dbContext.Categories.ToListAsync();
            return View(categories);
        }
    }
}
