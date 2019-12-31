using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class SubLocalModel
    {
        public SubLocalDto SubLocal { get; set; }
        public List<SelectListItem> ListLocal { get; set; }
        public List<SelectListItem> ListUnidadeInfraestrutura { get; set; }
    }
}
