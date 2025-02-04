//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes all elements inside an array. Basically, a wrapping of GenericField where some properties are inherited from it
	/// </summary>
	public class ArrayElement : GenericField, IGenericVariableType {


		public ArrayElement()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Parent Access
		/// </summary>
		public override string Access => default;

		/// <summary>
		/// Parent Type
		/// </summary>
		public override string Type => default;

		/// <summary>
		/// Parent IsRegister
		/// </summary>
		public override bool IsRegister => default;

		/// <summary>
		/// Parent StringLength
		/// </summary>
		public override int StringLength => default;

		/// <summary>
		/// Element index, example : [1] or [2,1]
		/// </summary>
		public override string Name => default;
	}
}
