using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxDemo160520.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("AjaxDemo160520")
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}