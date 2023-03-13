namespace NetApi.Models
{
    public class User
    {
        public string? Gender { get; set; }
        public Name? UserName { get; set; }
        public Location? UserLocation { get; set; }
        public string? Email { get; set; }
        public Login? UserLogin { get; set; }
        public Dob? UserDob { get; set; }
        
    }
}
