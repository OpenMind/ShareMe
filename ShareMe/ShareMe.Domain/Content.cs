using System;
using System.Collections.Generic;

namespace ShareMe.Domain
{
	/// <summary>
	/// Describe a shared content
	/// </summary>
	public class Content : Entity<Guid>
	{
		/// <summary>
		/// Simple ctor
		/// </summary>
		public Content ()
		{}
		
		/// <summary>
		/// Get or set the shared content type
		/// </summary>
		public ContentType Type {
			get;
			set;
		}
		
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
		
		/// <summary>
		/// Content categorization tags
		/// </summary>
		public IList<Tag> Tags {
			get;
			set;
		}
		
		/// <summary>
		/// Content voting ratings
		/// </summary>
		public IList<Rating> Ratings {
			get;
			set;
		}
		
		/// <summary>
		/// Get or set the content owner
		/// </summary>
		public User Owner {
			get;
			set;
		}
		
		/// <summary>
		/// Get or set the content uri info
		/// </summary>
		public string Uri {
			get;
			set;
		}
	}
}

