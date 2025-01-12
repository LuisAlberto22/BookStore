

namespace BookStore.Interface_Adapters.Models
{
	public class BookImage : Model, IStatusableModel
	{
		public int BookId { get; set; }
		public Book Book { get; set; } = null!;
		public string Link { get; set; } = null!;
		public Status Status { get; set; } = null!;
		public int StatusId { get; set; }
	}
}