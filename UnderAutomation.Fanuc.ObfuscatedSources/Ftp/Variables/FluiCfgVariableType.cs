//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type FLUI_CFG_T
	/// </summary>
	public class FluiCfgVariableType : GenericVariableType, IGenericVariableType {


		public FluiCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public int Dbglvl { get; }

		/// <summary>
		/// Value of variable $RECURSE
		/// </summary>
		public int Recurse { get; }

		/// <summary>
		/// Value of variable $STYLE
		/// </summary>
		public int Style { get; }

		/// <summary>
		/// Value of variable $EDT_RCNT_SI
		/// </summary>
		public int EdtRcntSi { get; }

		/// <summary>
		/// Value of variable $TEMPINT
		/// </summary>
		public int[] Tempint { get; }

		/// <summary>
		/// Value of variable $TEMPSTR
		/// </summary>
		public string[] Tempstr { get; }

		/// <summary>
		/// Value of variable $JOG_COORD
		/// </summary>
		public int JogCoord { get; }

		/// <summary>
		/// Value of variable $OVRTEXT
		/// </summary>
		public string Ovrtext { get; }

		/// <summary>
		/// Value of variable $SHOTEMPLATE
		/// </summary>
		public bool Shotemplate { get; }

		/// <summary>
		/// Value of variable $ASSIST_MODE
		/// </summary>
		public int AssistMode { get; }

		/// <summary>
		/// Value of variable $CUSTOM
		/// </summary>
		public int Custom { get; }

		/// <summary>
		/// Value of variable $DBG_1
		/// </summary>
		public int Dbg1 { get; }

		/// <summary>
		/// Value of variable $DBG_2
		/// </summary>
		public int Dbg2 { get; }

		/// <summary>
		/// Value of variable $DBG_3
		/// </summary>
		public int Dbg3 { get; }

		/// <summary>
		/// Value of variable $DBG_4
		/// </summary>
		public int Dbg4 { get; }

		/// <summary>
		/// Value of variable $DBG_5
		/// </summary>
		public int Dbg5 { get; }

		/// <summary>
		/// Value of variable $FORCE
		/// </summary>
		public bool Force { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
