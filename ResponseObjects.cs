using System;
using System.Collections.Generic;

namespace FilevineIntakeIntegrationDemo
{
    public class FilevineApiResult
    {
        public static Version FilevineApiVersion;
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public List<OrgMinimalResponse> Data { get; set; }
        public Version Version => FilevineApiVersion;
    }

    public class OrgMinimalResponse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ProjectTypeMinimalResponse> ProjectTypes { get; set; }
    }

    public class ProjectTypeMinimalResponse
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
