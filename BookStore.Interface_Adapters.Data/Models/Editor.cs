using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Interface_Adapters.Models
{
	public class Editor : Model, IStatusableModel
	{
		public List<Book>? Books { get; set; }

		public string Name { get; set; } = null!;

		public string Code { get; set; } = null!;
		public Status Status { get; set; } = null!;
		public int StatusId { get; set; }
	}
}