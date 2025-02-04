//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type MR_HIST_T
	/// </summary>
	public class MrHistVariableType : GenericVariableType, IGenericVariableType {


		public MrHistVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $GROUP
		/// </summary>
		public byte Group { get; }

		/// <summary>
		/// Value of variable $ID
		/// </summary>
		public byte Id { get; }

		/// <summary>
		/// Value of variable $TYPE
		/// </summary>
		public byte Type { get; }

		/// <summary>
		/// Value of variable $DUE_TYPE
		/// </summary>
		public byte DueType { get; }

		/// <summary>
		/// Value of variable $NAME
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Value of variable $DUE_ACT
		/// </summary>
		public int DueAct { get; }

		/// <summary>
		/// Value of variable $DUE_DATE
		/// </summary>
		public double DueDate { get; }

		/// <summary>
		/// Value of variable $WARN_DATE
		/// </summary>
		public int WarnDate { get; }

		/// <summary>
		/// Value of variable $DONE
		/// </summary>
		public bool Done { get; }

		/// <summary>
		/// Value of variable $DONE_DATE
		/// </summary>
		public int DoneDate { get; }

		/// <summary>
		/// Value of variable $DONE_PAST
		/// </summary>
		public string DonePast { get; }

		/// <summary>
		/// Value of variable $RECORDED
		/// </summary>
		public bool Recorded { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
