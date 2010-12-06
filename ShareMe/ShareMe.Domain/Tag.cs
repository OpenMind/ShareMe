using System;
namespace ShareMe.Domain
{
	/// <summary>
	/// Describe a category tag to categorize 
	/// contents
	/// </summary>
	public class Tag : Entity<Guid>
	{
		/// <summary>
		/// Simple ctor
		/// </summary>
		public Tag ()
		{}
		
		/// <summary>
		/// Tag name
		/// </summary>
		public string Name {
			get;
			set;
		}
		
		/// <summary>
		/// Tag description
		/// </summary>
		public string Description {
			get;
			set;
		}
	}
}

