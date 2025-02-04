//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FX_TRIGGER_T
	/// </summary>
	public class FxTriggerVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $START_MODEL
		/// </summary>
		public int StartModel { get; }

		/// <summary>
		/// Value of variable $START_STEP
		/// </summary>
		public int StartStep { get; }

		/// <summary>
		/// Value of variable $START_PROG
		/// </summary>
		public string StartProg { get; }

		/// <summary>
		/// Value of variable $STOP_MODEL
		/// </summary>
		public int StopModel { get; }

		/// <summary>
		/// Value of variable $STOP_STEP
		/// </summary>
		public int StopStep { get; }

		/// <summary>
		/// Value of variable $STOP_PROG
		/// </summary>
		public string StopProg { get; }

		/// <summary>
		/// Value of variable $AXES
		/// </summary>
		public int Axes { get; }

		/// <summary>
		/// Value of variable $DATA_TYPE
		/// </summary>
		public int DataType { get; }

		/// <summary>
		/// Value of variable $DATETIME
		/// </summary>
		public int Datetime { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
