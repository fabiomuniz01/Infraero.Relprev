using System;
using System.Collections.Generic;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class LocalModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public LocalDto Local { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
    }
}
