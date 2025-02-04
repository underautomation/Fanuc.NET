//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TRACE_ITEM_T
	/// </summary>
	public class TraceItemVariableType : GenericVariableType, IGenericVariableType {


		public TraceItemVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $PRG_NAME
		/// </summary>
		public string PrgName { get; }

		/// <summary>
		/// Value of variable $VAR_NAME
		/// </summary>
		public string VarName { get; }

		/// <summary>
		/// Value of variable $DESC
		/// </summary>
		public string Desc { get; }

		/// <summary>
		/// Value of variable $UNITS
		/// </summary>
		public string Units { get; }

		/// <summary>
		/// Value of variable $TYPE
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Value of variable $IO_TYPE
		/// </summary>
		public int IoType { get; }

		/// <summary>
		/// Value of variable $PORT_NUM
		/// </summary>
		public int PortNum { get; }

		/// <summary>
		/// Value of variable $SQUARE
		/// </summary>
		public double Square { get; }

		/// <summary>
		/// Value of variable $SLOPE
		/// </summary>
		public double Slope { get; }

		/// <summary>
		/// Value of variable $INTERCEPT
		/// </summary>
		public double Intercept { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
