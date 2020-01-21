using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Infraero.Relprev.Infrastructure.Identity
{
    public class WebProfileRole : IdentityRole
    {
        [Display(Name = "Description")] public string Description { get; set; }

        
    }
}