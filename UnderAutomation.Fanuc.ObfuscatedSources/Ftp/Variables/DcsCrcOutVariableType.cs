//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCS_CRC_OUT_
	/// </summary>
	public class DcsCrcOutVariableType : GenericVariableType, IGenericVariableType {


		public DcsCrcOutVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $START_GRP
		/// </summary>
		public short[] StartGrp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
