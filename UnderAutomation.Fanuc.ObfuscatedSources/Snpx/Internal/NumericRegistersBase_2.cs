//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Provides access to numeric registers (R[]) on the robot via SNPX.
	/// </summary>
	public abstract class NumericRegistersBase<TValue, TAssignment> : SnpxWritableAssignableIndexableElements<TValue, TAssignment> where TAssignment : BatchAssignment<TValue, int>, new() {


		protected override string GetAssignmentName(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override string GetAssignmentTarget(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected override int AssignmentSize => default;
	}
}
