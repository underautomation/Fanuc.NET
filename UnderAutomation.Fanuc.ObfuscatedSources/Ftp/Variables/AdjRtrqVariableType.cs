//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ADJ_RTRQ_T
	/// </summary>
	public class AdjRtrqVariableType : GenericVariableType, IGenericVariableType {


		public AdjRtrqVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $COR_TRQ
		/// </summary>
		public double[] CorTrq { get; }

		/// <summary>
		/// Value of variable $COR_TEMP
		/// </summary>
		public double[] CorTemp { get; }

		/// <summary>
		/// Value of variable $EFF_AXIS
		/// </summary>
		public EffAxisVariableType[] EffAxis { get; }

		/// <summary>
		/// Value of variable $LIMIT
		/// </summary>
		public double Limit { get; }

		/// <summary>
		/// Value of variable $ADJ_NUM
		/// </summary>
		public int AdjNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
