using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace VSTDA.API.Models
{
    public class ToDo
    {
        // Primary Key
        public int ToDoId { get; set; }

        // Foriegn Key - Optional

        // User Data
        public string Text { get; set; }
        public int Priority { get; set; }

    }
}