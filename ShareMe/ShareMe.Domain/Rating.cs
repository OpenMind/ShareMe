
using System;
namespace ShareMe.Domain
{
	public class Rating : Entity<Guid>
	{
		public Rating ()
		{}
		
		public int Vote {get; set;}
	}
}
