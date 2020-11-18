using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace TuxNet_rework.Services
{
    public class XmlService
    {
        private readonly IWebHostEnvironment _env;

        public XmlService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public List<NewsPost> RetrievePosts()
        {
            var newsList = new List<NewsPost>();
            var postsFile = Path.Combine(_env.WebRootPath, "Posts", "Posts.xml");
            var xmlDoc = new XmlDocument();

            xmlDoc.Load(postsFile);
            var posts = xmlDoc.SelectSingleNode("//Posts");

            foreach (XmlNode post in posts.ChildNodes)
            {
                newsList.Add(new NewsPost
                {
                    Title = post["Title"].InnerText,
                    Content = post["Content"].InnerText,
                    Author = post["Author"].InnerText,
                    Date = DateTime.Parse(post["Date"].InnerText)
                });
            }

            return newsList;
        }
    }
}
