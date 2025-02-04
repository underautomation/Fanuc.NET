//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SFZN_CFG_T
	/// </summary>
	public class SfznCfgVariableType : GenericVariableType, IGenericVariableType {


		public SfznCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ENABLE
		/// </summary>
		public int Enable { get; }

		/// <summary>
		/// Value of variable $STATE
		/// </summary>
		public int State { get; }

		/// <summary>
		/// Value of variable $FLAG
		/// </summary>
		public int Flag { get; }

		/// <summary>
		/// Value of variable $DEBUG
		/// </summary>
		public int Debug { get; }

		/// <summary>
		/// Value of variable $RES
		/// </summary>
		public int Res { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
