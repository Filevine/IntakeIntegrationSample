using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FilevineIntakeIntegrationDemo
{
    public class FilevineCalls
    {
        public async Task<List<OrgMinimalResponse>> CallForOrgList(string apiKey)
        {
            var client = GetApiClient(apiKey, "");
            var orgList = new List<OrgMinimalResponse>();
            try
            {
                var response = await client.GetAsync("api/public/v1/orgs");
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<GetOrgListResult>(stringResult);
                    orgList = result.Data;
                }
                return orgList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    
        public async Task<int> SendProjectInfo(string apiKey, int orgID, int projectTypeID, string clientFirstName, string clientLastName)
        {
            var client = GetApiClient(apiKey, "");

            var project = new CreateExtendedProjectRequest();
            project.ProjectTypeID = projectTypeID;
            project.Client.FirstName = clientFirstName;
            project.Client.LastName = clientLastName;

            //rest of this is generated for the demo but would be filled with real data from the intake system
            project.Client.Phones.Add(new PhoneRequest { Number = "(800)555-1212" });
            project.Client.Emails.Add(new EmailRequest { Address = "client@lawfirm.com" });
            project.Client.Addresses.Add(new AddressRequest { Line1 = "123 Main Street", City = "Las Vegas", State = "NV", Zip = "89148" });
            project.IncidentDate = DateTime.Today;
            project.OtherAttributes.Add(new AttributeRequest {AttributeName = "Some Piece of Info", AttributeValue = "blah"});
            project.OtherAttributes.Add(new AttributeRequest { AttributeName = "Other Piece of Info", AttributeValue = "blah blah blah" });
            project.OtherContacts.Add(new PersonRequest {FirstName = "Joe", LastName = "Jones"});
            project.OtherContacts.Add(new PersonRequest { FirstName = "Betty", LastName = "Smith" });

            var projectJson = new StringContent(JsonConvert.SerializeObject(project), Encoding.UTF8, "application/json");
            var projectID = 0;
            try
            {
                var response = await client.PostAsync($"api/public/v1/orgs/{orgID}/projects/create", projectJson);
                if (response.IsSuccessStatusCode)
                {
                    var stringResult = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<SendExtendedProjectResult>(stringResult);
                    projectID = result.Data.ProjectID;
                }
                return projectID;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private HttpClient GetApiClient(string apiKey, string url)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("filevine-api-key", apiKey);
            client.BaseAddress = new Uri("https://app.filevine.com/");

            return client;
        }
    }
}
