namespace PathTracker.Data.Models
{
	public class ProgressUpdate
	{
		public int Id { get; set; }
		public int CreatedByUserId { get; set; }
		public required string MemberId { get; set; }
		public required string PathName { get; set; }
		public required int ProjectId { get; set; }
		public int? PartNumber { get; set; }
		public bool IsCompleted { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
		public bool IsDeleted { get; set; }
	}
}
