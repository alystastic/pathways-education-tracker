namespace PathTracker.Data.Models
{
	public class Member
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public string? Email { get; set; }
		public DateTime Created { get; set; } = DateTime.Now;
		public bool IsOfficer { get; set; }
		public string? OfficerRole { get; set; }
		public string[]? ClubNumber { get; set; }
		public string[]? ClubName { get; set; }
	}
}
