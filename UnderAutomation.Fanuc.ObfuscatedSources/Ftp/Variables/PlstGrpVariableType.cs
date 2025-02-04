//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PLST_GRP_T
	/// </summary>
	public class PlstGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $COMMENT
		/// </summary>
		public string Comment { get; }

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public double Payload { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_X
		/// </summary>
		public double PayloadX { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Y
		/// </summary>
		public double PayloadY { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_Z
		/// </summary>
		public double PayloadZ { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IX
		/// </summary>
		public double PayloadIx { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IY
		/// </summary>
		public double PayloadIy { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_IZ
		/// </summary>
		public double PayloadIz { get; }

		/// <summary>
		/// Value of variable $ICONDISP
		/// </summary>
		public int Icondisp { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
