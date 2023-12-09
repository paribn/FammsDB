﻿using System.ComponentModel.DataAnnotations;

namespace ex_famms.Models
{
    public class Query 
    {

        public int Id { get; set; }

        public string FullName { get; set; }


        public string Email { get; set; }


        public string Subject { get; set; }

        public string Message { get; set; }

    }
}
