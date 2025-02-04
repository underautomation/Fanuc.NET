//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HTTP_AUTH_T
	/// </summary>
	public class HttpAuthVariableType : GenericVariableType, IGenericVariableType {


		public HttpAuthVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $OBJECT
		/// </summary>
		public string Object { get; }

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $TYPE
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Value of variable $LEVEL
		/// </summary>
		public int Level { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
