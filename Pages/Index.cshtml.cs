using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TuxNet_rework.Services;

namespace TuxNet_rework.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<NewsPost> Posts;
        private readonly IWebHostEnvironment _env;

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public void OnGet()
        {
            var xmlService = new XmlService(_env);
            Posts = xmlService.RetrievePosts();
            Posts.Reverse();
        }
    }
}
