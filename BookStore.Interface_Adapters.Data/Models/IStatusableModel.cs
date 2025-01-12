using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Interface_Adapters.Models
{
	public interface IStatusableModel
	{
		Status Status { get; set; }
		int StatusId { get; set; }
	}
}