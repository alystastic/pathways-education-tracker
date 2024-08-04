namespace PathTracker.Data.Models
{
	public class Project
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public int LevelId { get; set; }
		public string? Description { get; set; }
		public bool Required { get; set; }
		public int NumberOfParts { get; set; } = 1;
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public bool IsDeleted { get; set; }
	}
}
