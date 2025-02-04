//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type JINC_T
	/// </summary>
	public class JincVariableType : GenericVariableType, IGenericVariableType {


		public JincVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $JINC_ENB
		/// </summary>
		public bool JincEnb { get; }

		/// <summary>
		/// Value of variable $JOG_INCRE
		/// </summary>
		public int JogIncre { get; }

		/// <summary>
		/// Value of variable $INCRE_TRANS
		/// </summary>
		public double[] IncreTrans { get; }

		/// <summary>
		/// Value of variable $INCRE_JNT
		/// </summary>
		public double[] IncreJnt { get; }

		/// <summary>
		/// Value of variable $FLEX_I
		/// </summary>
		public int[] FlexI { get; }

		/// <summary>
		/// Value of variable $FLEX_R
		/// </summary>
		public double[] FlexR { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
