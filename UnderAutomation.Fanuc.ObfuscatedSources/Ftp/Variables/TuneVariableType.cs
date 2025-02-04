//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TUNE_T
	/// </summary>
	public class TuneVariableType : GenericVariableType, IGenericVariableType {


		public TuneVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $STAT
		/// </summary>
		public int[] Stat { get; }

		/// <summary>
		/// Value of variable $VAL
		/// </summary>
		public double[] Val { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
