//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CONDET_TRGP_
	/// </summary>
	public class CondetTrgpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $IO_TYPE
		/// </summary>
		public int IoType { get; }

		/// <summary>
		/// Value of variable $IO_PORT
		/// </summary>
		public int IoPort { get; }

		/// <summary>
		/// Value of variable $IO_STYLE
		/// </summary>
		public int IoStyle { get; }

		/// <summary>
		/// Value of variable $DELAY
		/// </summary>
		public int Delay { get; }

		/// <summary>
		/// Value of variable $JOB_NAME
		/// </summary>
		public string JobName { get; }

		/// <summary>
		/// Value of variable $GP_STATE
		/// </summary>
		public int GpState { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
