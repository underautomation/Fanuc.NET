//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type AIO_CNV_T
	/// </summary>
	public class AioCnvVariableType : GenericVariableType, IGenericVariableType {


		public AioCnvVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $RACK
		/// </summary>
		public int Rack { get; }

		/// <summary>
		/// Value of variable $SLOT
		/// </summary>
		public int Slot { get; }

		/// <summary>
		/// Value of variable $MOD_TYPE
		/// </summary>
		public int ModType { get; }

		/// <summary>
		/// Value of variable $FIRST_CH
		/// </summary>
		public int FirstCh { get; }

		/// <summary>
		/// Value of variable $LAST_CH
		/// </summary>
		public int LastCh { get; }

		/// <summary>
		/// Value of variable $IN_OUT
		/// </summary>
		public int InOut { get; }

		/// <summary>
		/// Value of variable $FACTOR
		/// </summary>
		public double Factor { get; }

		/// <summary>
		/// Value of variable $INTERCEPT
		/// </summary>
		public double Intercept { get; }

		/// <summary>
		/// Value of variable $BIT_SIZE
		/// </summary>
		public int BitSize { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
