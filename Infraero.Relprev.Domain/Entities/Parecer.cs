﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public  class Parecer : AuditableEntity
    {
        [Key]
        public int CodParecer { get; set; }
        public string DscParecer { get; set; }
        public string DscMotivoDevolucao { get; set; }
        public int FlgStatusParecer { get; set; }

    }
}
