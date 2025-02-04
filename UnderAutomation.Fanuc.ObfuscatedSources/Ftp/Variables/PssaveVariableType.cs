//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type PSSAVE_T
	/// </summary>
	public class PssaveVariableType : GenericVariableType, IGenericVariableType {


		public PssaveVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MC_FOLDER
		/// </summary>
		public string McFolder { get; }

		/// <summary>
		/// Value of variable $SLAVE_SAVE
		/// </summary>
		public bool SlaveSave { get; }

		/// <summary>
		/// Value of variable $START_MULTI
		/// </summary>
		public bool StartMulti { get; }

		/// <summary>
		/// Value of variable $SLAVE_LOAD
		/// </summary>
		public bool[] SlaveLoad { get; }

		/// <summary>
		/// Value of variable $LOAD_DEV
		/// </summary>
		public short LoadDev { get; }

		/// <summary>
		/// Value of variable $KEEP_HNADDR
		/// </summary>
		public string KeepHnaddr { get; }

		/// <summary>
		/// Value of variable $KEEP_HRADDR
		/// </summary>
		public string KeepHraddr { get; }

		/// <summary>
		/// Value of variable $KEEP_CCOMM
		/// </summary>
		public string KeepCcomm { get; }

		/// <summary>
		/// Value of variable $KEEP_CPROT
		/// </summary>
		public string KeepCprot { get; }

		/// <summary>
		/// Value of variable $PS_KEEP_COP
		/// </summary>
		public short PsKeepCop { get; }

		/// <summary>
		/// Value of variable $KEEP_COPER
		/// </summary>
		public int KeepCoper { get; }

		/// <summary>
		/// Value of variable $KEEP_CSTATE
		/// </summary>
		public int KeepCstate { get; }

		/// <summary>
		/// Value of variable $KEEP_CREMOT
		/// </summary>
		public string KeepCremot { get; }

		/// <summary>
		/// Value of variable $KEEP_CTIMEO
		/// </summary>
		public int KeepCtimeo { get; }

		/// <summary>
		/// Value of variable $KEEP_CSREMO
		/// </summary>
		public string KeepCsremo { get; }

		/// <summary>
		/// Value of variable $KEEP_CUNAME
		/// </summary>
		public string KeepCuname { get; }

		/// <summary>
		/// Value of variable $KEEP_CHPWD
		/// </summary>
		public string KeepChpwd { get; }

		/// <summary>
		/// Value of variable $KEEP_SBMSK
		/// </summary>
		public string KeepSbmsk { get; }

		/// <summary>
		/// Value of variable $COLLABMODE
		/// </summary>
		public bool Collabmode { get; }

		/// <summary>
		/// Value of variable $PS_STARTED
		/// </summary>
		public bool PsStarted { get; }

		/// <summary>
		/// Value of variable $INITS_COMP
		/// </summary>
		public bool InitsComp { get; }

		/// <summary>
		/// Value of variable $NOLOADFCALB
		/// </summary>
		public bool Noloadfcalb { get; }

		/// <summary>
		/// Value of variable $START_DONE
		/// </summary>
		public bool StartDone { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
