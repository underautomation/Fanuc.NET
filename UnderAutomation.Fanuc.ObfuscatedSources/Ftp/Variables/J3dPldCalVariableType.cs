//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type J3D_PLD_CAL_
	/// </summary>
	public class J3dPldCalVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PDCK_RB_TYP
		/// </summary>
		public int PdckRbTyp { get; }

		/// <summary>
		/// Value of variable $CO_J3_ALPHA
		/// </summary>
		public double CoJ3Alpha { get; }

		/// <summary>
		/// Value of variable $CO_J3_BETA
		/// </summary>
		public double CoJ3Beta { get; }

		/// <summary>
		/// Value of variable $AA
		/// </summary>
		public double Aa { get; }

		/// <summary>
		/// Value of variable $BB
		/// </summary>
		public double Bb { get; }

		/// <summary>
		/// Value of variable $CC
		/// </summary>
		public double Cc { get; }

		/// <summary>
		/// Value of variable $DD
		/// </summary>
		public double Dd { get; }

		/// <summary>
		/// Value of variable $EE
		/// </summary>
		public double Ee { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
