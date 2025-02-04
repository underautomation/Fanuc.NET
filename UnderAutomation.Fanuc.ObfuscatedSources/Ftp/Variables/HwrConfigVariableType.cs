//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type HWR_CONFIG_T
	/// </summary>
	public class HwrConfigVariableType : GenericVariableType, IGenericVariableType {


		public HwrConfigVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MAINCPU
		/// </summary>
		public int Maincpu { get; }

		/// <summary>
		/// Value of variable $VISIONCPU
		/// </summary>
		public int Visioncpu { get; }

		/// <summary>
		/// Value of variable $SPARE1
		/// </summary>
		public int Spare1 { get; }

		/// <summary>
		/// Value of variable $SPARE2
		/// </summary>
		public int Spare2 { get; }

		/// <summary>
		/// Value of variable $SPARE3
		/// </summary>
		public int Spare3 { get; }

		/// <summary>
		/// Value of variable $SPARE4
		/// </summary>
		public int Spare4 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
