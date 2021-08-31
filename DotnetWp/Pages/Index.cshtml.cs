using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetWp.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotnetWp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WordPressDbContext _db;

        public IndexModel(ILogger<IndexModel> logger, WordPressDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            var post = _db.Posts.FirstOrDefault();
            ViewData["post"] = post.ToString();
        }
    }
}
