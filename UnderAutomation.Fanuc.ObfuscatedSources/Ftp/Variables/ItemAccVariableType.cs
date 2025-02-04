//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type ITEM_ACC_T
	/// </summary>
	public class ItemAccVariableType : GenericVariableType, IGenericVariableType {


		public ItemAccVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TIME_STAMP
		/// </summary>
		public int TimeStamp { get; }

		/// <summary>
		/// Value of variable $LAST_TICK
		/// </summary>
		public int LastTick { get; }

		/// <summary>
		/// Value of variable $ON_ACC
		/// </summary>
		public int OnAcc { get; }

		/// <summary>
		/// Value of variable $OFF_ACC
		/// </summary>
		public int OffAcc { get; }

		/// <summary>
		/// Value of variable $ELAPS_ACC
		/// </summary>
		public int ElapsAcc { get; }

		/// <summary>
		/// Value of variable $BUFF_IDX
		/// </summary>
		public int BuffIdx { get; }

		/// <summary>
		/// Value of variable $HIST_IDX
		/// </summary>
		public int HistIdx { get; }

		/// <summary>
		/// Value of variable $REP_IDX
		/// </summary>
		public int RepIdx { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
