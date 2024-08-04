namespace PathTracker.Data.Models
{
	public class PathProgress
	{
		public int Id { get; set; }
		public required string UserId { get; set; } // VPE UserId
		public required string MemberName { get; set; }
		public required string PathName { get; set; }
		public string? ClubName { get; set; }
		public string? ClubNumber { get; set; }
		public required string Level { get; set; }
		public decimal PercentageComplete { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public bool IsDeleted { get; set; }
	}
}
