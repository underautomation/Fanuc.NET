//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Safety status informations
	/// </summary>
	public class SafetyStatus : IFanucContent {


		public SafetyStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// External emergency stop active
		/// </summary>
		public bool ExternalEStop { get; }

		/// <summary>
		/// Emergency stop active by SOP signal
		/// </summary>
		public bool SOPEStop { get; }

		/// <summary>
		/// Emergency stop active on teach peandant
		/// </summary>
		public bool TPEStop { get; }


		public bool HandBroken { get; }


		public bool OverTravel { get; }


		public bool LowAirAlarm { get; }


		public bool FenceOpen { get; }


		public bool BeltBroken { get; }

		/// <summary>
		/// Teach pendant is enabled
		/// </summary>
		public bool TPEnable { get; }

		/// <summary>
		/// The deadman switch of the teach pendant is active
		/// </summary>
		public bool TPDeadman { get; }


		public bool SVOFFDetect { get; }


		public bool NonTeacherEnb { get; }

		/// <summary>
		/// File name : sftysig.dg
		/// </summary>
		public string Name { get; }
	}
}
