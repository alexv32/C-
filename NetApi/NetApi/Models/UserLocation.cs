namespace NetApi.Models
{
    public class Location
    {

        public Street? UserStreet { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int PostCode { get; set; }
        public Coordinates? UserCoordinates { get; set; }
        public TimeZone? UserTimezone { get; set; }
    }
    public class Street
    {
        public int Number { get; set; }
        public string? Name { get; set; }
    }
    public class Coordinates
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }

    }
    public class TimeZone
    {
        public string? Offset { get; set; }
        public string? Description { get; set; }
    }
}
