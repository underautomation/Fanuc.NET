//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MOPTIMIZ_T
	/// </summary>
	public class MoptimizVariableType : GenericVariableType, IGenericVariableType {


		public MoptimizVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DATA_OUT
		/// </summary>
		public bool DataOut { get; }

		/// <summary>
		/// Value of variable $CNT_DYN_ACC
		/// </summary>
		public bool[] CntDynAcc { get; }

		/// <summary>
		/// Value of variable $DD_MOTOR1
		/// </summary>
		public bool[] DdMotor1 { get; }

		/// <summary>
		/// Value of variable $UPDATE_MAP3
		/// </summary>
		public bool[] UpdateMap3 { get; }

		/// <summary>
		/// Value of variable $UPDATE_MAP7
		/// </summary>
		public bool UpdateMap7 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
