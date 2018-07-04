using System;

namespace CosmosDbWriter.Domain
{
    public class User
    {
        public string Name { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}