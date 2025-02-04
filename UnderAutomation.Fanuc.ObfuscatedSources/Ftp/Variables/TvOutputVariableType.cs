//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TV_OUTPUT_T
	/// </summary>
	public class TvOutputVariableType : GenericVariableType, IGenericVariableType {


		public TvOutputVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SELECTED
		/// </summary>
		public string[] Selected { get; }

		/// <summary>
		/// Value of variable $DATATYPE
		/// </summary>
		public short[] Datatype { get; }

		/// <summary>
		/// Value of variable $STATE
		/// </summary>
		public string[] State { get; }

		/// <summary>
		/// Value of variable $CMD_STATUS
		/// </summary>
		public int[] CmdStatus { get; }

		/// <summary>
		/// Value of variable $TEMPINT
		/// </summary>
		public int[] Tempint { get; }

		/// <summary>
		/// Value of variable $SELECTEDMOD
		/// </summary>
		public string[] Selectedmod { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
