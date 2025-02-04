//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {

	public class GenericField : GenericValue, IGenericVariableType {


		public virtual string Access { get; }


		public virtual string Type { get; set; }


		public virtual bool IsRegister { get; }


		public virtual int StringLength { get; }


		public int Dimension1 { get; }


		public int Dimension2 { get; }


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
