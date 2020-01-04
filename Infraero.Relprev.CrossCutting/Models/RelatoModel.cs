﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class RelatoModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public RelatoDto Relato { get; set; }
    }
}
