//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type LOG_DIO_T
	/// </summary>
	public class LogDioVariableType : GenericVariableType, IGenericVariableType {


		public LogDioVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $RACK
		/// </summary>
		public int Rack { get; }

		/// <summary>
		/// Value of variable $SLOT
		/// </summary>
		public int Slot { get; }

		/// <summary>
		/// Value of variable $MOD_TYPE
		/// </summary>
		public int ModType { get; }

		/// <summary>
		/// Value of variable $PORT_TYPE
		/// </summary>
		public int PortType { get; }

		/// <summary>
		/// Value of variable $START_PORT
		/// </summary>
		public int StartPort { get; }

		/// <summary>
		/// Value of variable $END_PORT
		/// </summary>
		public int EndPort { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
