//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CONDET_IO_T
	/// </summary>
	public class CondetIoVariableType : GenericVariableType, IGenericVariableType {


		public CondetIoVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public int Enable { get; }

		/// <summary>
		/// Value of variable $REQ_MASK
		/// </summary>
		public int ReqMask { get; }

		/// <summary>
		/// Value of variable $USED_MSK
		/// </summary>
		public int UsedMsk { get; }

		/// <summary>
		/// Value of variable $IO_DATA
		/// </summary>
		public DetIoVariableType[] IoData { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
