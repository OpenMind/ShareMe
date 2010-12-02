
using System;
namespace ShareMe.Domain
{
	public class RatingVote : Entity<Guid>
	{
		public RatingVote ()
		{}
		
		public int Vote {get; set;}
	}
}
