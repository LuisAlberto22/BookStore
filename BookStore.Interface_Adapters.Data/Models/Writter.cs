using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Interface_Adapters.Models
{
	public class Writter : Model, IStatusableModel
	{
		public string Name { get; set; } = null!;

		public DateTime BirthDate { get; set; }

		public string? Biography { get; set; }

		public string? Photo { get; set; }

		public List<Book>? Books { get; set; }
		public Status Status { get; set; } = null!;
		public int StatusId { get; set; }
	}
}