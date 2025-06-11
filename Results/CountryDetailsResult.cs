namespace HttpClientUsageAPI.Results
{
    public class CountryDetailsResult
    {
        public NameResult Name { get; set; } = null!;
    }

    public class NameResult
    {
        public string Common { get; set; } = string.Empty;
        public string Official { get; set; } = string.Empty;
        public NativeNameResult NativeName { get; set; } = null!;

    }

    public class NativeNameResult
    {
        public PorResult Por { get; set; } = null!;
    }

    public class PorResult
    {
        public string Official { get; set; } = string.Empty;
        public string Common { get; set; } = string.Empty;
    }
}
