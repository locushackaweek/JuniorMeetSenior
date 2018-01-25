using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HackathonApp.Models
{
    public class Patient
    {
        [Key]
        public string UserId { get; set; }
    }

    
}