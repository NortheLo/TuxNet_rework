using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TuxNet_rework.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly List<NewsPost> Posts;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Posts = new List<NewsPost>();
            Posts.Add(new NewsPost
            {
                Title = "Neue Seite",
                Content = "Seit heute ist die neue Webseite online! Schauen Sie sich gerne um!",
                Author = "Nomis",
                Date = DateTime.Today
            });
            Posts.Add(new NewsPost
            {
                Title = "Erstes Update",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas hendrerit sollicitudin libero vel bibendum. Nullam laoreet magna in dui congue, sed pretium quam tincidunt. Suspendisse ultrices efficitur ante, quis vehicula massa consectetur in. Proin rhoncus ante tempus ornare vehicula. Donec aliquam porttitor justo, quis pharetra diam. Suspendisse placerat turpis leo, ac vulputate eros elementum sed. Interdum et malesuada fames ac ante ipsum primis in faucibus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Sed at ante dui.",
                Author = "Hans-Peter",
                Date = new DateTime(2020, 11, 21)
            });
        }

        public void OnGet()
        {

        }
    }
}
