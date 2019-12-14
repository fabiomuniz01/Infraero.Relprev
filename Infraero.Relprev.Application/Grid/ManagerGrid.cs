using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.Application.Grid
{
    public class ManagerGrid
    {
        public int iTotalDisplayRecords { get; set; }
        public int iTotalRecords { get; set; }
        public int recordsFiltered { get; set; }
        public int sEcho { get; set; }
    }
}
