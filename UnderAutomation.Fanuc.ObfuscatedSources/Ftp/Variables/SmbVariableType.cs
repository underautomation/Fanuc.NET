//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SMB_T
	/// </summary>
	public class SmbVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public bool Enable { get; }

		/// <summary>
		/// Value of variable $BCAST
		/// </summary>
		public bool Bcast { get; }

		/// <summary>
		/// Value of variable $WINS_IP
		/// </summary>
		public string WinsIp { get; }

		/// <summary>
		/// Value of variable $DOMAIN
		/// </summary>
		public string Domain { get; }

		/// <summary>
		/// Value of variable $EXPSRV
		/// </summary>
		public bool Expsrv { get; }

		/// <summary>
		/// Value of variable $SPARE
		/// </summary>
		public int Spare { get; }

		/// <summary>
		/// Value of variable $SMB_RAND
		/// </summary>
		public byte[] SmbRand { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
