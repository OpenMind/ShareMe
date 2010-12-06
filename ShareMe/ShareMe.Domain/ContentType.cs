
using System;
using System.Collections.Generic;
namespace ShareMe.Domain
{
	/// <summary>
	/// Describe a content type
	/// </summary>
	public class ContentType : Entity<Guid>
	{
		/// <summary>
		/// Simple ctor
		/// </summary>
		public ContentType ()
		{}
		/// <summary>
		/// Content type name
		/// </summary>
		public string Name {
			get;
			set;
		}
		/// <summary>
		/// Content type description
		/// </summary>
		public string Description {
			get;
			set;
		}
	}
}
