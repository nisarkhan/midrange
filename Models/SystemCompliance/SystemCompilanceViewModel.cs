using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Midrange.Models.SystemCompilance
{
    public class SystemCompilanceViewModel
    {
        public int SystemCompilanceId { get; set; }
        public string SystemName { get; set; }
        public string ServerState { get; set; }
        public string ApplicationSystemUse { get; set; }
        public string AssetTag { get; set; }
        public string BackupClientAgentName { get; set; }
        public string BAckupMaster { get; set; }
        public string BackupType { get; set; }


        public string CommentFiled { get; set; }
        public string CPUCoresPerCPU { get; set; }
        public string NumberOfCPUs { get; set; }
        public string CPUSockets { get; set; }
        public string CPUSpeed { get; set; }
        public string DataCenterLocation { get; set; }
        public string DSNDomain { get; set; }
        public string GlobalSupportAccessRestriction { get; set; }
        public string GridLocation { get; set; }
        public string HardwareModel { get; set; }
        public string Manufacturer { get; set; }
        public string HostId { get; set; }
        public string InternalDrives { get; set; }
        public string IPAddress { get; set; }
        public string ClusterName { get; set; }
        public string KernelPatch { get; set; }
        public string Memory { get; set; }
        public string PrescriptiveServiceLevel { get; set; }
        public string Processor { get; set; }
        public DateTime InitialDeploymentDate { get; set; }
        public string RAIDLevel { get; set; }
        public string RoomFloor { get; set; }
        public string NetworkSpaceStorageSAN { get; set; }
        public string NetworkSpaceStorageAllocatged { get; set; }
        public string FunctionalDesc { get; set; }
        public string ServerCategory { get; set; }
        public string ServerUsageType { get; set; }
        public string StreetAddress { get; set; }

        public string SupportOrganization { get; set; }
        public string SupportTeam { get; set; }
        public string TimeZone { get; set; }
        public string XENHost { get; set; }
        
        public SystemCompilanceViewModel() { } 
    }
}