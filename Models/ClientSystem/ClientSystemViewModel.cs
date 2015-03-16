using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Midrange.Models.ClientSystem
{
    public class ClientSystemViewModel
    {
        public int ClientId { get; set; }
        public string ClientDivision { get; set; }
        public string ClientCostCenter { get; set; }
        public string MSName { get; set; }
        public string SBUSDM { get; set; }
        public List<string> Alias { get; set; }
        public List<string> MACAddress { get; set; }
        public string NumberOfCPUs { get; set; }
        public string FloorLocation { get; set; }
        public string ManagementTools { get; set; }

        public ClientSystemViewModel() { } 
    }
}