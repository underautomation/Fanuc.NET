//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TRACECTL_T
	/// </summary>
	public class TracectlVariableType : GenericVariableType, IGenericVariableType {


		public TracectlVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TASK_STATUS
		/// </summary>
		public short TaskStatus { get; }

		/// <summary>
		/// Value of variable $TRC_TOP_IDX
		/// </summary>
		public short TrcTopIdx { get; }

		/// <summary>
		/// Value of variable $TRC_BTM_IDX
		/// </summary>
		public short TrcBtmIdx { get; }

		/// <summary>
		/// Value of variable $TASK_ID
		/// </summary>
		public byte TaskId { get; }

		/// <summary>
		/// Value of variable $DUMMY4
		/// </summary>
		public byte Dummy4 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
