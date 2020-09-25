using Blog.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public PostCategory Category { get; set; }
        public DateTime PostDate { get; set; }
        public virtual ApplicationUser User {get;set;}
        [NotMapped]
        public List<Comment> Comments { get; set; }

        public Post()
        {
            Id = Guid.NewGuid().ToString();
            PostDate = DateTime.Now;
        }
        
    }
}