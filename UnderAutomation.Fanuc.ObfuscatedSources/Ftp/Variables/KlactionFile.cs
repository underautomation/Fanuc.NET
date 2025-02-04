//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc variable file klaction.va
	/// </summary>
	public class KlactionFile : GenericVariableFile, IGenericVariableType, IFanucContent {


		public KlactionFile()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable DATA_TYPE
		/// </summary>
		public int DataType { get; }

		/// <summary>
		/// Value of variable INT_VALUE
		/// </summary>
		public int IntValue { get; }

		/// <summary>
		/// Value of variable REAL_VALUE
		/// </summary>
		public double RealValue { get; }

		/// <summary>
		/// Value of variable STRING_VALUE
		/// </summary>
		public string StringValue { get; }

		/// <summary>
		/// Value of variable STATUS
		/// </summary>
		public int Status { get; }

		/// <summary>
		/// Value of variable PARAM_OK
		/// </summary>
		public bool ParamOk { get; }
	}
}
