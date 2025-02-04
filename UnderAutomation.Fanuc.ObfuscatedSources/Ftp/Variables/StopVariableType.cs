//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $STOP
	/// </summary>
	public class StopVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $TICK
		/// </summary>
		public int Tick { get; }

		/// <summary>
		/// Value of variable $SPD
		/// </summary>
		public double Spd { get; }

		/// <summary>
		/// Value of variable $POS1
		/// </summary>
		public double Pos1 { get; }

		/// <summary>
		/// Value of variable $POS2
		/// </summary>
		public double Pos2 { get; }

		/// <summary>
		/// Value of variable $POS3
		/// </summary>
		public double Pos3 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
