//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Internal {

	public abstract class SectionParser {


		public virtual bool CanHandleSection(string line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public abstract void ParseLine(string line);


		public virtual void AfterParse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected SectionParser()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public virtual string[] SectionStart { get; }


		public virtual bool EndOfFile { get; set; }
	}
}
