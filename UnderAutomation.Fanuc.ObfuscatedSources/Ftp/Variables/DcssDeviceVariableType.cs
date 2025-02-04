//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DCSS_DEVICE_
	/// </summary>
	public class DcssDeviceVariableType : GenericVariableType, IGenericVariableType {


		public DcssDeviceVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TYPE
		/// </summary>
		public int Type { get; }

		/// <summary>
		/// Value of variable $RBT_NUM
		/// </summary>
		public int RbtNum { get; }

		/// <summary>
		/// Value of variable $SPI_IDX
		/// </summary>
		public int SpiIdx { get; }

		/// <summary>
		/// Value of variable $SPO_IDX
		/// </summary>
		public int SpoIdx { get; }

		/// <summary>
		/// Value of variable $SPI_BYTE
		/// </summary>
		public int SpiByte { get; }

		/// <summary>
		/// Value of variable $SPO_BYTE
		/// </summary>
		public int SpoByte { get; }

		/// <summary>
		/// Value of variable $STO
		/// </summary>
		public int Sto { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
