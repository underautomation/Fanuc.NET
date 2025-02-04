//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TPGL_CONF_T
	/// </summary>
	public class TpglConfVariableType : GenericVariableType, IGenericVariableType {


		public TpglConfVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $MOUNT
		/// </summary>
		public string[] Mount { get; }

		/// <summary>
		/// Value of variable $LOCK_FOLLOW
		/// </summary>
		public bool LockFollow { get; }

		/// <summary>
		/// Value of variable $DBGLVL
		/// </summary>
		public int Dbglvl { get; }

		/// <summary>
		/// Value of variable $GLDBGLVL
		/// </summary>
		public int Gldbglvl { get; }

		/// <summary>
		/// Value of variable $TEST_XML
		/// </summary>
		public string TestXml { get; }

		/// <summary>
		/// Value of variable $TEMPINT
		/// </summary>
		public int[] Tempint { get; }

		/// <summary>
		/// Value of variable $TEMPSTR
		/// </summary>
		public string[] Tempstr { get; }

		/// <summary>
		/// Value of variable $USER_VIEWS
		/// </summary>
		public TpglUviewVariableType[] UserViews { get; }

		/// <summary>
		/// Value of variable $CAMERAS
		/// </summary>
		public TpglCamVariableType[] Cameras { get; }

		/// <summary>
		/// Value of variable $TEMP_LOCS
		/// </summary>
		public TpglViewVariableType[] TempLocs { get; }

		/// <summary>
		/// Value of variable $SCENE_VIEW
		/// </summary>
		public TpglViewVariableType[] SceneView { get; }

		/// <summary>
		/// Value of variable $KAREL_TMO
		/// </summary>
		public int KarelTmo { get; }

		/// <summary>
		/// Value of variable $TPDRAW_TMO
		/// </summary>
		public int TpdrawTmo { get; }

		/// <summary>
		/// Value of variable $JOG_VECLEN
		/// </summary>
		public int JogVeclen { get; }

		/// <summary>
		/// Value of variable $JOG_RADIUS
		/// </summary>
		public JogRadVariableType[] JogRadius { get; }

		/// <summary>
		/// Value of variable $CHECK_TOOLS
		/// </summary>
		public int CheckTools { get; }

		/// <summary>
		/// Value of variable $CHECK_VIS
		/// </summary>
		public int CheckVis { get; }

		/// <summary>
		/// Value of variable $REG_VIS32
		/// </summary>
		public int RegVis32 { get; }

		/// <summary>
		/// Value of variable $REG_VIS64
		/// </summary>
		public int RegVis64 { get; }

		/// <summary>
		/// Value of variable $MACHSET
		/// </summary>
		public TpglMsetVariableType[] Machset { get; }

		/// <summary>
		/// Value of variable $CONT_IDX
		/// </summary>
		public byte ContIdx { get; }

		/// <summary>
		/// Value of variable $DUMMY31
		/// </summary>
		public byte Dummy31 { get; }

		/// <summary>
		/// Value of variable $VISIBLE
		/// </summary>
		public byte[] Visible { get; }

		/// <summary>
		/// Value of variable $RAIL_BOXES
		/// </summary>
		public byte[] RailBoxes { get; }

		/// <summary>
		/// Value of variable $ROBOT_XML
		/// </summary>
		public string[] RobotXml { get; }

		/// <summary>
		/// Value of variable $SHOWWARN
		/// </summary>
		public byte[] Showwarn { get; }

		/// <summary>
		/// Value of variable $CONTROLMAX
		/// </summary>
		public int Controlmax { get; }

		/// <summary>
		/// Value of variable $CONTROLMASK
		/// </summary>
		public byte[] Controlmask { get; }

		/// <summary>
		/// Value of variable $FP_TO_FK
		/// </summary>
		public CartesianPositionVariable[] FpToFk { get; }

		/// <summary>
		/// Value of variable $HTML5_ENBL
		/// </summary>
		public bool Html5Enbl { get; }

		/// <summary>
		/// Value of variable $UPDATE_MINT
		/// </summary>
		public int UpdateMint { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
