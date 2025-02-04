//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PSSAVE_GRP_T
	/// </summary>
	public class PssaveGrpVariableType : GenericVariableType, IGenericVariableType {


		public PssaveGrpVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $FLANGE
		/// </summary>
		public short Flange { get; }

		/// <summary>
		/// Value of variable $SYNC_FLANGE
		/// </summary>
		public short SyncFlange { get; }

		/// <summary>
		/// Value of variable $SYNC_MST_CN
		/// </summary>
		public int SyncMstCn { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
