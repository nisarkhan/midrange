using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Midrange.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public int MaintenanceId { get; set; }
        public bool CoveredByDRContract { get; set; }
        public string HWWarrentyInformationContract { get; set; }
        public string PatchingGroup { get; set; }
        public string RebootDesc { get; set; }        
        public string SWSupportVendor { get; set; }

        public MaintenanceViewModel() { } 
    }
}