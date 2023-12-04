namespace Azure_02_Web_API_Build_Pipeline.Models
{
    public class Person
    {
        public int Personid { get; set; }

        public string LastName { get; set; } = null!;

        public string? FirstName { get; set; }

        public int? Age { get; set; }
    }
}