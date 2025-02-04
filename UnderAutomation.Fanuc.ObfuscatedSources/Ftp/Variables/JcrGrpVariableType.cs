//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type JCR_GRP_T
	/// </summary>
	public class JcrGrpVariableType : GenericVariableType, IGenericVariableType {

		/// <summary>
		/// Value of variable $JOG_WRSTJNT
		/// </summary>
		public bool JogWrstjnt { get; }

		/// <summary>
		/// Value of variable $JOG_FINE_MD
		/// </summary>
		public bool JogFineMd { get; }

		/// <summary>
		/// Value of variable $JOG_V_FINE
		/// </summary>
		public bool JogVFine { get; }

		/// <summary>
		/// Value of variable $PRG_RUN
		/// </summary>
		public bool PrgRun { get; }

		/// <summary>
		/// Value of variable $JOG_COORD
		/// </summary>
		public int JogCoord { get; }

		/// <summary>
		/// Value of variable $CD_JOG
		/// </summary>
		public bool CdJog { get; }

		/// <summary>
		/// Value of variable $FOLLOWER
		/// </summary>
		public int Follower { get; }

		/// <summary>
		/// Value of variable $JOG_RTCP
		/// </summary>
		public bool JogRtcp { get; }

		/// <summary>
		/// Value of variable $JOG_SGAVD
		/// </summary>
		public bool JogSgavd { get; }

		/// <summary>
		/// Value of variable $JOG_SUBGRP
		/// </summary>
		public bool JogSubgrp { get; }

		/// <summary>
		/// Value of variable $RRMC_JOG
		/// </summary>
		public bool RrmcJog { get; }

		/// <summary>
		/// Value of variable $LEADER
		/// </summary>
		public int Leader { get; }

		/// <summary>
		/// Value of variable $FIX_ORNT
		/// </summary>
		public bool FixOrnt { get; }

		/// <summary>
		/// Value of variable $KEYORDER
		/// </summary>
		public byte[] Keyorder { get; }

		/// <summary>
		/// Value of variable $SPATH_RDY
		/// </summary>
		public bool SpathRdy { get; }

		/// <summary>
		/// Value of variable $TRACK_JOG
		/// </summary>
		public bool TrackJog { get; }

		/// <summary>
		/// Value of variable $TJOG_LDR
		/// </summary>
		public short TjogLdr { get; }

		/// <summary>
		/// Value of variable $TJOG_FLWR
		/// </summary>
		public short TjogFlwr { get; }

		/// <summary>
		/// Value of variable $TJOG_MODE
		/// </summary>
		public int TjogMode { get; }

		/// <summary>
		/// Value of variable $TJOG_CNTR
		/// </summary>
		public int TjogCntr { get; }

		/// <summary>
		/// Value of variable $SPJOG_GMSK
		/// </summary>
		public int SpjogGmsk { get; }

		/// <summary>
		/// Value of variable $SPJOG_MODE
		/// </summary>
		public int SpjogMode { get; }

		/// <summary>
		/// Value of variable $FIX_ORNT_WR
		/// </summary>
		public bool FixOrntWr { get; }

		/// <summary>
		/// Value of variable $LDR_FRM_NUM
		/// </summary>
		public int LdrFrmNum { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
