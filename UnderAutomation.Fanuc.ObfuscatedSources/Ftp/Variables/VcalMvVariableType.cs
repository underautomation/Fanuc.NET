//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type VCAL_MV_T
	/// </summary>
	public class VcalMvVariableType : GenericVariableType, IGenericVariableType {


		public VcalMvVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable ROB_GROUP
		/// </summary>
		public int RobGroup { get; }

		/// <summary>
		/// Value of variable COMMAND_POS
		/// </summary>
		public CartesianPositionVariable CommandPos { get; }

		/// <summary>
		/// Value of variable VS_SPEED
		/// </summary>
		public double VsSpeed { get; }

		/// <summary>
		/// Value of variable MAX_RDELAY
		/// </summary>
		public int MaxRdelay { get; }

		/// <summary>
		/// Value of variable ROB_AXIS
		/// </summary>
		public double RobAxis { get; }

		/// <summary>
		/// Value of variable MOTYPE
		/// </summary>
		public int Motype { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
