//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SV_INFO_T
	/// </summary>
	public class SvInfoVariableType : GenericVariableType, IGenericVariableType {


		public SvInfoVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TORQUE_CMD
		/// </summary>
		public double[] TorqueCmd { get; }

		/// <summary>
		/// Value of variable $MOTOR_SPEED
		/// </summary>
		public double[] MotorSpeed { get; }

		/// <summary>
		/// Value of variable $Q_CURRENT
		/// </summary>
		public double[] QCurrent { get; }

		/// <summary>
		/// Value of variable $AXIS_POS
		/// </summary>
		public double[] AxisPos { get; }

		/// <summary>
		/// Value of variable $SQ_CURRENT
		/// </summary>
		public double[] SqCurrent { get; }

		/// <summary>
		/// Value of variable $CART_POS
		/// </summary>
		public double[] CartPos { get; }

		/// <summary>
		/// Value of variable $CART_POS_UF
		/// </summary>
		public double[] CartPosUf { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
