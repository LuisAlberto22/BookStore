namespace BookStore.Interface_Adapters.Models
{
	public class Book : Model, IStatusableModel
	{
		public string Title { get; set; } = null!;

		public int PageCount { get; set; }

		public int EditorId { get; set; }

		public List<Writter> Writters { get; set; } = null!;

		public DateTime PublishedDate { get; set; }

		public List<Genre> Genres { get; set; } = null!;

		public List<BookImage> Images { get; set; } = null!;

		public Editor Editor { get; set; } = null!;
		public int StatusId { get; set; }
		public Status Status { get; set; } = null!;
	}
}