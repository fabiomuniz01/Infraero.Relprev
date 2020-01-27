using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Infraero.Relprev.Infrastructure.Identity
{
    public class WebProfileUser : IdentityUser
    {
        [Required]
        [Display(Name = "Date Registered")]
        public DateTime DateRegistered { get; set; }

        [Display(Name = "Date Email Confirmed")]
        public DateTime? DateEmailConfirmed { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; }

        [Display(Name = "First Access")]
        public DateTime? FirstAccess { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}