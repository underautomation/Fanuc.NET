//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type CONDET_TRIG_
	/// </summary>
	public class CondetTrigVariableType : GenericVariableType, IGenericVariableType {

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
		/// Value of variable $STYLE_TYPE
		/// </summary>
		public int StyleType { get; }

		/// <summary>
		/// Value of variable $STYLE_PORT
		/// </summary>
		public int StylePort { get; }

		/// <summary>
		/// Value of variable $FLAG
		/// </summary>
		public int Flag { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
