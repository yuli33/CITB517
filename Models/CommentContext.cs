using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Demo.Models
{
    public class CommentContext : DbContext
    {
        public CommentContext() : base("Comment") { }
        public DbSet<CommentEntry> Entries { get; set; }
    }
}