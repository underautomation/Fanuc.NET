//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type $CALC_RESULT
	/// </summary>
	public class CalcResultVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $PAYLOAD
		/// </summary>
		public double Payload { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_1
		/// </summary>
		public double Payload1 { get; }

		/// <summary>
		/// Value of variable $PAYLOAD_2
		/// </summary>
		public double Payload2 { get; }

		/// <summary>
		/// Value of variable $PLD_J3ARM
		/// </summary>
		public double PldJ3arm { get; }

		/// <summary>
		/// Value of variable $PLD_J3ARM_1
		/// </summary>
		public double PldJ3arm1 { get; }

		/// <summary>
		/// Value of variable $PLD_J3ARM_2
		/// </summary>
		public double PldJ3arm2 { get; }

		/// <summary>
		/// Value of variable $INERTIA4
		/// </summary>
		public double Inertia4 { get; }

		/// <summary>
		/// Value of variable $INERTIA5
		/// </summary>
		public double Inertia5 { get; }

		/// <summary>
		/// Value of variable $INERTIA6
		/// </summary>
		public double Inertia6 { get; }

		/// <summary>
		/// Value of variable $MOMENT4
		/// </summary>
		public double Moment4 { get; }

		/// <summary>
		/// Value of variable $MOMENT5
		/// </summary>
		public double Moment5 { get; }

		/// <summary>
		/// Value of variable $MOMENT6
		/// </summary>
		public double Moment6 { get; }

		/// <summary>
		/// Value of variable $COMB_LOAD4
		/// </summary>
		public double CombLoad4 { get; }

		/// <summary>
		/// Value of variable $COMB_LOAD5
		/// </summary>
		public double CombLoad5 { get; }

		/// <summary>
		/// Value of variable $COMB_LOAD6
		/// </summary>
		public double CombLoad6 { get; }

		/// <summary>
		/// Value of variable $PUB_INRT4
		/// </summary>
		public double PubInrt4 { get; }

		/// <summary>
		/// Value of variable $PUB_INRT5
		/// </summary>
		public double PubInrt5 { get; }

		/// <summary>
		/// Value of variable $PUB_INRT6
		/// </summary>
		public double PubInrt6 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
