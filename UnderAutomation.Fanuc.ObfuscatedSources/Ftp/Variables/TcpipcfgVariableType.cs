//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type TCPIPCFG_T
	/// </summary>
	public class TcpipcfgVariableType : GenericVariableType, IGenericVariableType {


		public TcpipcfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $ARPSIZE
		/// </summary>
		public int Arpsize { get; }

		/// <summary>
		/// Value of variable $HOST_IPF
		/// </summary>
		public int HostIpf { get; }

		/// <summary>
		/// Value of variable $HW_MCFILTER
		/// </summary>
		public int HwMcfilter { get; }

		/// <summary>
		/// Value of variable $DEF_INTERFA
		/// </summary>
		public int DefInterfa { get; }

		/// <summary>
		/// Value of variable $CLASSMASK
		/// </summary>
		public bool Classmask { get; }

		/// <summary>
		/// Value of variable $SHO_NETINFO
		/// </summary>
		public bool ShoNetinfo { get; }

		/// <summary>
		/// Value of variable $PPS_INT
		/// </summary>
		public int PpsInt { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
