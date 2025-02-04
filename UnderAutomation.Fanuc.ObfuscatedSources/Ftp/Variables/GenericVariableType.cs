//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {

	public abstract class GenericVariableType : IGenericVariableType {


		public GenericField GetField(string name)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected GenericVariableType()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public GenericField[] Fields { get; }


		public abstract string FanucInternalTypeName { get; }

		/// <summary>
		/// Parent of this structure
		/// </summary>
		public IGenericVariableType Parent { get; }

		IGenericVariableType[] IGenericVariableType.Fields => Fields;

		string IGenericVariableType.Name => FanucInternalTypeName;
	}
}
