using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.Application.Grid
{
    public class ManagerMainGrid<TFormGrid> : ManagerGrid where TFormGrid : new()
    {
        public ManagerMainGrid() : base()
        {
            //Instancia FormView
            FormGrid = new TFormGrid();
        }

        public TFormGrid FormGrid { get; set; }
    }
}
