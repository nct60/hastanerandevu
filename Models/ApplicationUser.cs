﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HastaneRandevuSistemi.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public int HastaNo { get; set; }

        public string? Adres { get; set; }

       
    }
}
