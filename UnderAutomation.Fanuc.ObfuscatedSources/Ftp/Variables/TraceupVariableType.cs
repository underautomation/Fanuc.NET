//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TRACEUP_T
	/// </summary>
	public class TraceupVariableType : GenericVariableType, IGenericVariableType {


		public TraceupVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TRC_UPDATE
		/// </summary>
		public bool TrcUpdate { get; }

		/// <summary>
		/// Value of variable $DISP_PXNN
		/// </summary>
		public byte DispPxnn { get; }

		/// <summary>
		/// Value of variable $DUMMY2
		/// </summary>
		public byte Dummy2 { get; }

		/// <summary>
		/// Value of variable $DUMMY3
		/// </summary>
		public byte Dummy3 { get; }

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
