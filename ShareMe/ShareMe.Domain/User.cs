
using System;
using System.Collections.Generic;
namespace ShareMe.Domain
{
	/// <summary>
	/// User info and reference
	/// </summary>
	public class User : Entity<Guid>
	{
		/// <summary>
		/// Get or set the user name
		/// </summary>
		public string Name {
			get;
			set;
		}
		
		/// <summary>
		/// Get or set a linked user nickname
		/// </summary>
		public string Nick {
			get;
			set;
		}
		
		/// <summary>
		/// Get the user password hash
		/// </summary>
		public long PasswordHash {
			get;
			private set;
		}
			
	}
}
