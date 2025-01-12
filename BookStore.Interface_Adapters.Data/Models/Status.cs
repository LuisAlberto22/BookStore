using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Interface_Adapters.Models
{
	public class Status : Model
	{
		public string Name { get; set; } = null!;
		public List<Book> Books { get; set; } = null!;
		public List<Editor> Editors { get; set; } = null!;
		public List<Genre> Genres { get; set; } = null!;
		public List<Writter> Writters { get; set; } = null!;

	}
}