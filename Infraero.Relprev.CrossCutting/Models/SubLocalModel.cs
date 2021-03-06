﻿using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class SubLocalModel
    {
        public SubLocalDto SubLocal { get; set; }
        public SelectList ListLocal { get; set; }
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodLocal { get; set; }
    }
}
