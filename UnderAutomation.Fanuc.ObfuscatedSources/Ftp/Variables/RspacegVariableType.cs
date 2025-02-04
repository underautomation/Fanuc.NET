//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RSPACEG_T
	/// </summary>
	public class RspacegVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $COM_SPACE
		/// </summary>
		public ComSpaceVariableType[] ComSpace { get; }

		/// <summary>
		/// Value of variable $GP_HOLD
		/// </summary>
		public GpHoldVariableType[] GpHold { get; }

		/// <summary>
		/// Value of variable $SPARE_INT
		/// </summary>
		public int[] SpareInt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
