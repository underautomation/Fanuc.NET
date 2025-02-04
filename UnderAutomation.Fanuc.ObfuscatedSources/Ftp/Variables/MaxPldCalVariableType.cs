//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $MAX_PLD_CAL
	/// </summary>
	public class MaxPldCalVariableType : GenericVariableType, IGenericVariableType {


		public MaxPldCalVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

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
