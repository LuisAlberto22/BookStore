using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Interface_Adapters.Models
{
	public class Genre : Model, IStatusableModel
	{
		public string Name { get; set; } = null!;
		public List<Book>? Books { get; set; }
		public Status Status { get; set; } = null!;
		public int StatusId { get; set; }
	}
}