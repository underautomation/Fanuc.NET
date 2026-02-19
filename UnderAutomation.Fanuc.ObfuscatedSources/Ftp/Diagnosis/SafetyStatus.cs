//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Safety status informations
	/// </summary>
	public class SafetyStatus : IFanucContent {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


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

		/// <summary>
		/// Hand broken signal is active
		/// </summary>
		public bool HandBroken { get; }

		/// <summary>
		/// Over travel limit is active
		/// </summary>
		public bool OverTravel { get; }

		/// <summary>
		/// Low air pressure alarm is active
		/// </summary>
		public bool LowAirAlarm { get; }

		/// <summary>
		/// Safety fence is open
		/// </summary>
		public bool FenceOpen { get; }

		/// <summary>
		/// Belt broken signal is active
		/// </summary>
		public bool BeltBroken { get; }

		/// <summary>
		/// Teach pendant is enabled
		/// </summary>
		public bool TPEnable { get; }

		/// <summary>
		/// The deadman switch of the teach pendant is active
		/// </summary>
		public bool TPDeadman { get; }

		/// <summary>
		/// Servo off detection is active
		/// </summary>
		public bool SVOFFDetect { get; }

		/// <summary>
		/// Non-teacher enable signal is active
		/// </summary>
		public bool NonTeacherEnb { get; }

		/// <summary>
		/// File name : sftysig.dg
		/// </summary>
		public string Name { get; }
	}
}
