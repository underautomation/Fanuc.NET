//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file vcmrinit.va
	/// </summary>
	public class VcmrinitFile : GenericVariableFile, IGenericVariableType, IFanucContent {

		/// <summary>
		/// Value of variable VDETECT_VAR
		/// </summary>
		public VcalVdVariableType VdetectVar { get; }

		/// <summary>
		/// Value of variable VFB_VAR
		/// </summary>
		public VcalVfVariableType VfbVar { get; }

		/// <summary>
		/// Value of variable MOVE_VAR
		/// </summary>
		public VcalMvVariableType MoveVar { get; }

		/// <summary>
		/// Value of variable VTCP_VAR
		/// </summary>
		public VtcpsetVariableType VtcpVar { get; }

		/// <summary>
		/// Value of variable SELECT_GRP
		/// </summary>
		public int SelectGrp { get; }

		/// <summary>
		/// Value of variable ARG_STR
		/// </summary>
		public string ArgStr { get; }

		/// <summary>
		/// Value of variable DATA_TYPE
		/// </summary>
		public int DataType { get; }

		/// <summary>
		/// Value of variable DMY_INT
		/// </summary>
		public int DmyInt { get; }

		/// <summary>
		/// Value of variable DMY_REAL
		/// </summary>
		public double DmyReal { get; }

		/// <summary>
		/// Value of variable DMY_STR
		/// </summary>
		public string DmyStr { get; }

		/// <summary>
		/// Value of variable DMY_STAT
		/// </summary>
		public int DmyStat { get; }

		/// <summary>
		/// Value of variable PARAM_VAL
		/// </summary>
		public string ParamVal { get; }

		/// <summary>
		/// Value of variable PRM_SET_DONE
		/// </summary>
		public bool PrmSetDone { get; }
	}
}
