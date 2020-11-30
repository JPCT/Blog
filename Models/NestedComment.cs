using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    [Table("NestedComment")]
    public class NestedComment
    {
        [Key]
        public string Id { get; set; }
        public string CommentId { get; set; }
        public Comment Comment { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public virtual ApplicationUser User { get; set; }

        public NestedComment()
        {
            Id = Guid.NewGuid().ToString();
            CommentDate = DateTime.Now;
        }
    }
}