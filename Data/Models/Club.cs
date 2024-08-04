namespace PathTracker.Data.Models
{
	public class Club
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string ClubNumber { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public bool IsDeleted { get; set; }
	}
}
