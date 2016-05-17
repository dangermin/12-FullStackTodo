using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VSTDA.API.Models;

namespace VSTDA.API.Infrastructure
{
    // 1. Create class that inherits from DbContext
    public class TodoDataContext : DbContext
    {
        // 2. Set up Constructor - Shortcut: "ctor" TAB TAB
        public TodoDataContext() : base("ToDo")
        {
                
        }
        // 3. Describe the tables
        public IDbSet<ToDo> ToDoes { get; set; }
    }
}