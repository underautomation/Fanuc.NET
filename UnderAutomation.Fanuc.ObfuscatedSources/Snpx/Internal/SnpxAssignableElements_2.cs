//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {

	public abstract class SnpxAssignableElements<TValue, TIndex> : SnpxElements<TValue, TIndex> {


		protected abstract TValue ReadFromClient(int offset);


		public override TValue Read(TIndex index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected abstract string GetAssignmentTarget(TIndex index);


		protected abstract string GetAssignmentName(TIndex index);


		public Assignment<TIndex> GetOrCreateAssignment(TIndex index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected abstract int AssignmentSize { get; }
	}
}
