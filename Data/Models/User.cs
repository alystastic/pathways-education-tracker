namespace PathTracker.Data.Models
{
	public class User
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Email { get; set; }
		public required string Password { get; set; }
		public bool EmailConfirmed { get; set; } = false;
		public DateTime Created { get; set; } = DateTime.Now;
		public DateTime Updated { get; set; }
		public int Status { get; set; } = 0;
		public string? WebsiteRole {  get; set; }
		public int[]? ClubIds { get; set;}
		public string[]? ClubName { get; set;}
	}
}
