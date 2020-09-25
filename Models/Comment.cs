using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public string Id { get; set; }
        public string PostId { get; set; }
        public Post Post { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public virtual ApplicationUser User { get; set; }
        [NotMapped]
        public List<NestedComment> NestedComments { get; set; }

        public Comment()
        {
            Id = Guid.NewGuid().ToString();
            CommentDate = DateTime.Now;
        }
    }
}