//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type KAREL_CFG_T
	/// </summary>
	public class KarelCfgVariableType : GenericVariableType, IGenericVariableType {


		public KarelCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CONV_ENABLE
		/// </summary>
		public bool ConvEnable { get; }

		/// <summary>
		/// Value of variable $CONV_CTRL
		/// </summary>
		public bool ConvCtrl { get; }

		/// <summary>
		/// Value of variable $CONV_FLAGS
		/// </summary>
		public int ConvFlags { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
