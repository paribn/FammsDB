﻿namespace ex_famms.Models
{
    public class Contact:BaseEntity
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
