//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file symotn.va
	/// </summary>
	public class SymotnFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable $CF_PARAMGP
		/// </summary>
		public CfParamgpVariableType[] CfParamgp { get; }

		/// <summary>
		/// Value of variable $CRCFG
		/// </summary>
		public CrcfgVariableType Crcfg { get; }

		/// <summary>
		/// Value of variable $ENC_STAT
		/// </summary>
		public EncStatVariableType[] EncStat { get; }

		/// <summary>
		/// Value of variable $FMR2_GRP
		/// </summary>
		public Fmr2GrpVariableType[] Fmr2Grp { get; }

		/// <summary>
		/// Value of variable $GROUP
		/// </summary>
		public UprVariableType[] Group { get; }

		/// <summary>
		/// Value of variable $HSCD_GROUP
		/// </summary>
		public HscdGrpVariableType[] HscdGroup { get; }

		/// <summary>
		/// Value of variable $JOG_GROUP
		/// </summary>
		public UjrGrpVariableType[] JogGroup { get; }

		/// <summary>
		/// Value of variable $MISC
		/// </summary>
		public MiscGrpVariableType[] Misc { get; }

		/// <summary>
		/// Value of variable $MOTASK_DATA
		/// </summary>
		public int MotaskData { get; }

		/// <summary>
		/// Value of variable $MRR2_GRP
		/// </summary>
		public Mrr2GrpVariableType[] Mrr2Grp { get; }

		/// <summary>
		/// Value of variable $MRR_GRP
		/// </summary>
		public MrrGrpVariableType[] MrrGrp { get; }

		/// <summary>
		/// Value of variable $PARAM2_GRP
		/// </summary>
		public Mrr2GrpVariableType[] Param2Grp { get; }

		/// <summary>
		/// Value of variable $PARAM_GROUP
		/// </summary>
		public MrrGrpVariableType[] ParamGroup { get; }

		/// <summary>
		/// Value of variable $PLID_GRP
		/// </summary>
		public PlidGrpVariableType[] PlidGrp { get; }

		/// <summary>
		/// Value of variable $PLID_SV
		/// </summary>
		public PlidSvVariableType PlidSv { get; }

		/// <summary>
		/// Value of variable $PLST_GRP1
		/// </summary>
		public PlstGrpVariableType[] PlstGrp1 { get; }

		/// <summary>
		/// Value of variable $PLST_GRP2
		/// </summary>
		public PlstGrpVariableType[] PlstGrp2 { get; }

		/// <summary>
		/// Value of variable $PLST_GRP3
		/// </summary>
		public PlstGrpVariableType[] PlstGrp3 { get; }

		/// <summary>
		/// Value of variable $PLST_GRP4
		/// </summary>
		public PlstGrpVariableType[] PlstGrp4 { get; }

		/// <summary>
		/// Value of variable $PLST_GRP5
		/// </summary>
		public PlstGrpVariableType[] PlstGrp5 { get; }

		/// <summary>
		/// Value of variable $PLST_GRPMAD
		/// </summary>
		public int PlstGrpmad { get; }

		/// <summary>
		/// Value of variable $PLST_PARNUM
		/// </summary>
		public int[] PlstParnum { get; }

		/// <summary>
		/// Value of variable $PLST_SCHMAD
		/// </summary>
		public int PlstSchmad { get; }

		/// <summary>
		/// Value of variable $PLST_SCHNUM
		/// </summary>
		public int PlstSchnum { get; }

		/// <summary>
		/// Value of variable $PLST_UPDNUM
		/// </summary>
		public int[] PlstUpdnum { get; }

		/// <summary>
		/// Value of variable $PODATA_GRP
		/// </summary>
		public PodataVariableType[] PodataGrp { get; }

		/// <summary>
		/// Value of variable $POINFO_GRP
		/// </summary>
		public PoinfoVariableType[] PoinfoGrp { get; }

		/// <summary>
		/// Value of variable $POIO_GRP
		/// </summary>
		public PoioVariableType[] PoioGrp { get; }

		/// <summary>
		/// Value of variable $PSSAVE_GRP
		/// </summary>
		public PssaveGrpVariableType[] PssaveGrp { get; }

		/// <summary>
		/// Value of variable $SCR
		/// </summary>
		public ScrVariableType Scr { get; }

		/// <summary>
		/// Value of variable $SCR_GRP
		/// </summary>
		public ScrGrpVariableType[] ScrGrp { get; }

		/// <summary>
		/// Value of variable $TBCCFG
		/// </summary>
		public TbccfgVariableType Tbccfg { get; }

		/// <summary>
		/// Value of variable $TBC_GRP
		/// </summary>
		public TbcGrpVariableType[] TbcGrp { get; }

		/// <summary>
		/// Value of variable $TBJCFG
		/// </summary>
		public TbjcfgVariableType Tbjcfg { get; }

		/// <summary>
		/// Value of variable $TBJ_GRP
		/// </summary>
		public TbjGrpVariableType[] TbjGrp { get; }

		/// <summary>
		/// Value of variable $TORQCTRL
		/// </summary>
		public TorqctrlVariableType Torqctrl { get; }

		/// <summary>
		/// Value of variable $TSR_GRP
		/// </summary>
		public TsrGrpVariableType[] TsrGrp { get; }
	}
}
