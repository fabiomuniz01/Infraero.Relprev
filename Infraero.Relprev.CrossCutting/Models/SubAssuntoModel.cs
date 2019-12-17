using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class SubAssuntoModel
    {
        public SubAssuntoDto SubAssunto { get; set; }
        public List<SelectListItem> ListAssunto { get; set; }
    }
}
