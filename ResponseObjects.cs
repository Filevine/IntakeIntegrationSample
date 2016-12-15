using System.Collections.Generic;

namespace FilevineIntakeIntegrationDemo
{
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
