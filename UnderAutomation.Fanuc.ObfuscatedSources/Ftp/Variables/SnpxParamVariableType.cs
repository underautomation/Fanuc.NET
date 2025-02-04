//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type SNPX_PARAM_T
	/// </summary>
	public class SnpxParamVariableType : GenericVariableType, IGenericVariableType {


		public SnpxParamVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $TIMEOUT
		/// </summary>
		public int Timeout { get; }

		/// <summary>
		/// Value of variable $SNP_ID
		/// </summary>
		public string SnpId { get; }

		/// <summary>
		/// Value of variable $NUM_ASG
		/// </summary>
		public int NumAsg { get; }

		/// <summary>
		/// Value of variable $NUM_CIMP
		/// </summary>
		public int NumCimp { get; }

		/// <summary>
		/// Value of variable $NUM_FRIF
		/// </summary>
		public int NumFrif { get; }

		/// <summary>
		/// Value of variable $VERSION
		/// </summary>
		public int Version { get; }

		/// <summary>
		/// Value of variable $STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable $DISP_INFO
		/// </summary>
		public int DispInfo { get; }

		/// <summary>
		/// Value of variable $MODBUS_ADR
		/// </summary>
		public int ModbusAdr { get; }

		/// <summary>
		/// Value of variable $NUM_MODBUS
		/// </summary>
		public int NumModbus { get; }

		/// <summary>
		/// Value of variable $MODBUS_PORT
		/// </summary>
		public int ModbusPort { get; }

		/// <summary>
		/// Value of variable $CMD_ENDIAN
		/// </summary>
		public byte CmdEndian { get; }

		/// <summary>
		/// Value of variable $COMP_FLAG
		/// </summary>
		public byte CompFlag { get; }

		/// <summary>
		/// Value of variable $DUMMY13
		/// </summary>
		public byte Dummy13 { get; }

		/// <summary>
		/// Value of variable $DUMMY14
		/// </summary>
		public byte Dummy14 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
