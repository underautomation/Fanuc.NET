//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type GLOFSET_T
	/// </summary>
	public class GlofsetVariableType : GenericVariableType, IGenericVariableType {


		public GlofsetVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $NUMFILES
		/// </summary>
		public int Numfiles { get; }

		/// <summary>
		/// Value of variable $ATTRPTR
		/// </summary>
		public int Attrptr { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
