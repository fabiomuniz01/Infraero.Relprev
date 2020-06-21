using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class EmpresasInfraero 
    {

        [Key]
        public string vendor_id { get; set; }
        public string vendor_loc_code { get; set; }
        public string organization_operating_name { get; set; }
        public string vendor_search { get; set; }
        public string custom_field_10 { get; set; }
        public string custom_field_18 { get; set; }
        public string addr_line_1 { get; set; }
        public string street_or_post_office_box_2 { get; set; }
        public string city_name { get; set; }
        public string country_sub_entity_code { get; set; }
        public string postal_code { get; set; }
        public string vendor_status_code { get; set; }
    }
}
