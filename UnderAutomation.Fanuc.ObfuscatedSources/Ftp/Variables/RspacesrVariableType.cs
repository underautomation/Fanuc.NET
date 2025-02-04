//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type RSPACESR_T
	/// </summary>
	public class RspacesrVariableType : GenericVariableType, IGenericVariableType {


		public RspacesrVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $SR_ENB_TYP
		/// </summary>
		public int[] SrEnbTyp { get; }

		/// <summary>
		/// Value of variable $RUNNER_AXS
		/// </summary>
		public bool RunnerAxs { get; }

		/// <summary>
		/// Value of variable $HAND_LNGTH
		/// </summary>
		public double HandLngth { get; }

		/// <summary>
		/// Value of variable $HAND_THICK
		/// </summary>
		public double HandThick { get; }

		/// <summary>
		/// Value of variable $FLIP_ENB
		/// </summary>
		public bool FlipEnb { get; }

		/// <summary>
		/// Value of variable $INTFERENCE
		/// </summary>
		public bool Intference { get; }

		/// <summary>
		/// Value of variable $HAND_IF_CHK
		/// </summary>
		public bool HandIfChk { get; }

		/// <summary>
		/// Value of variable $HANDI_TYPE
		/// </summary>
		public int HandiType { get; }

		/// <summary>
		/// Value of variable $HANDI_INDX
		/// </summary>
		public int HandiIndx { get; }

		/// <summary>
		/// Value of variable $SR_G1POS
		/// </summary>
		public double[] SrG1pos { get; }

		/// <summary>
		/// Value of variable $SR_G1POS_IN
		/// </summary>
		public double[] SrG1posIn { get; }

		/// <summary>
		/// Value of variable $SR_G1ANG
		/// </summary>
		public double[] SrG1ang { get; }

		/// <summary>
		/// Value of variable $SR_G1ANG_JF
		/// </summary>
		public double[] SrG1angJf { get; }

		/// <summary>
		/// Value of variable $SR_PRM
		/// </summary>
		public int[] SrPrm { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
