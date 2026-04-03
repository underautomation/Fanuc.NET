//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common.Kcl {
	/// <summary>
	/// Result of a set variable command.
	/// </summary>
	public class SetVariableResult : SetValueResult {

		/// <summary>
		/// Controls whether the result should be finalized when an empty answer is received (i.e. a frame consisting only of VT100 escape sequences and whitespace).
		/// Override and return false until meaningful data has been accumulated, to prevent premature finalization caused by intermediate display-update frames.
		/// Default is true (backward compatible: finalize immediately on empty answer).
		/// </summary>
		protected override bool ShouldCompleteOnEmptyAnswer()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// During implementation, return true if it is assumed that the frame has finished being received.
		/// </summary>
		protected override bool FromResult(string data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public SetVariableResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
