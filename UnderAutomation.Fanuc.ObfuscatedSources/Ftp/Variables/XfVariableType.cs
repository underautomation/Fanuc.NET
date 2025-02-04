//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $XF
	/// </summary>
	public class XfVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $N
		/// </summary>
		public XYZPosition N { get; }

		/// <summary>
		/// Value of variable $O
		/// </summary>
		public XYZPosition O { get; }

		/// <summary>
		/// Value of variable $A
		/// </summary>
		public XYZPosition A { get; }

		/// <summary>
		/// Value of variable $L
		/// </summary>
		public XYZPosition L { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
