using System;
namespace ShareMe.Domain
{
	public class Content : Entity<Guid>
	{
		public Content ()
		{}
		
		/// <summary>
		/// Get or set the content uri address
		/// </summary>
		public Uri Url {
			get;
			set;
		}
			
		/// <summary>
		/// Get or set the content name
		/// </summary>
		public string Name {
			get;
			set;
		}
		
		/// <summary>
		/// Get or set the content description
		/// </summary>
		public string Description {
			get;
			set;
		}
	}
}

