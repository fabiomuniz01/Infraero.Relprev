﻿using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.SubAssuntos.Queries.GetSubAssuntos
{
    public class GridSubAssunto : ManagerMainGrid<SubAssuntoDto>
    {
        public IEnumerable<SubAssuntoDto> aaData { get; set; }
    }
}
