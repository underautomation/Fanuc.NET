//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the Fanuc type DICT_CFG_T
	/// </summary>
	public class DictCfgVariableType : GenericVariableType, IGenericVariableType {


		public DictCfgVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Value of variable $CACHE_ENB
		/// </summary>
		public bool CacheEnb { get; }

		/// <summary>
		/// Value of variable $CACHE_SIZE
		/// </summary>
		public int CacheSize { get; }

		/// <summary>
		/// Value of variable $CURR_ONLY
		/// </summary>
		public bool CurrOnly { get; }

		/// <summary>
		/// Value of variable $LANG_SUFFIX
		/// </summary>
		public string LangSuffix { get; }

		/// <summary>
		/// Value of variable $LOCALE
		/// </summary>
		public short Locale { get; }

		/// <summary>
		/// Value of variable $DUMMY5
		/// </summary>
		public byte Dummy5 { get; }

		/// <summary>
		/// Value of variable $DUMMY6
		/// </summary>
		public byte Dummy6 { get; }

		/// <summary>
		/// Type Name on the robot
		/// </summary>
		public override string FanucInternalTypeName => default;
	}
}
