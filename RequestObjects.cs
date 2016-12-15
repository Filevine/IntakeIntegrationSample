using System;
using System.Collections.Generic;

namespace FilevineIntakeIntegrationDemo
{
    public class CreateExtendedProjectRequest
    {
        public CreateExtendedProjectRequest()
        {
            Client = new PersonRequest();
            OtherContacts = new List<PersonRequest>();
            OtherAttributes = new List<AttributeRequest>();
        }

        public int ProjectTypeID { get; set; }
        public PersonRequest Client { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string IncidentDescription { get; set; }
        public List<PersonRequest> OtherContacts { get; set; }
        public List<AttributeRequest> OtherAttributes { get; set; }
    }

    public class PersonRequest
    {
        public PersonRequest()
        {
            Addresses = new List<AddressRequest>();
            Emails = new List<EmailRequest>();
            Phones = new List<PhoneRequest>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname { get; set; }

        public List<PhoneRequest> Phones { get; set; }
        public List<AddressRequest> Addresses { get; set; }
        public List<EmailRequest> Emails { get; set; }

        public string Ssn { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Notes { get; set; }
    }

    public class AddressRequest
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Label { get; set; }
    }

    public class EmailRequest
    {
        public string Address { get; set; }
        public string Label { get; set; }
    }

    public class PhoneRequest
    {
        public string Number { get; set; }
        public string Label { get; set; }
    }

    public class AttributeRequest
    {
        public string AttributeName { get; set; }
        public Object AttributeValue { get; set; }
    }
}
