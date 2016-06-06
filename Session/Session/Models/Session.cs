using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Session2.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}