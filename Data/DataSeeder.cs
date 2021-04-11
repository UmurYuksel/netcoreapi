using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Data
{
    public static class DataSeeder
    {
       
        public static void Seed(ProjectCon con)
        {
            List<Tag> tags = new List<Tag>() { new Tag { TagSlug="FirstTag"},
            new Tag {TagSlug="SecondTag"},
            new Tag {TagSlug="ThirdTag"}};


            BlogPost xBlog = new BlogPost
            {
                Slug = "firstSlug",
                PostTitle = "FirstHeader",
                PostDescription = "FirstDesc",
                PostFooter = "FirstFooter",
                Tags = tags
            };

            con.Tags.AddRange(tags);
            con.BlogPosts.Add(xBlog);
            con.SaveChanges();
        }

    }
}
