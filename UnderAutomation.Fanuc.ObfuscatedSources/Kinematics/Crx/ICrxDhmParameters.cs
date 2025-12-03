//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Kinematics.Crx {
	/// <summary>
	/// Denavit–Hartenberg Modified (DHm) parameters for Fanuc CRX with only the relevant parameters
	/// </summary>
	public interface ICrxDhmParameters {


		double A2 { get; }


		double D4 { get; }


		double D5 { get; }


		double D6 { get; }
	}
}
