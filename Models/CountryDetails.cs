namespace HttpClientUsageAPI.Models
{
    public class CountryDetails
    {
        public Name Name { get; set; } = null!;
    }

    public class Name
    {
        public string Common { get; set; } = string.Empty;

        public string Official { get; set; } = string.Empty;
        
        public NativeName NativeName { get; set; } = null!;

    }

    public class NativeName
    {
        public Por Por { get; set; } = null!;
    }

    public class Por
    {
        public string Official { get; set; } = string.Empty;

        public string Common { get; set; } = string.Empty;
    }
}
