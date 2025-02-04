//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VSMO_VAL_T
	/// </summary>
	public class VsmoValVariableType : GenericVariableType, IGenericVariableType {


		public VsmoValVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $POSITION
		/// </summary>
		public PositionVariableType Position { get; }

		/// <summary>
		/// Value of variable $SPEED
		/// </summary>
		public PositionVariableType Speed { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
