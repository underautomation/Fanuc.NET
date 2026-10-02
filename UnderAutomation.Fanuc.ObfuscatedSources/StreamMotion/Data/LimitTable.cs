//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Robotics.Motion;

namespace UnderAutomation.Fanuc.StreamMotion.Data {
	/// <summary>
	/// Table of allowable limits of one axis for one type of limit.
	/// The limit depends on the speed of the flange center: the table gives 20 values, for speeds up to 1/20, 2/20, ... 20/20 of <see cref="UnderAutomation.Fanuc.StreamMotion.Data.LimitTable.MaxSpeed"/>,
	/// with no payload and with the maximum payload.
	/// </summary>
	public class LimitTable {

		/// <summary>
		/// Number of speed stages of a table
		/// </summary>
		public const int StageCount = 20;

		/// <summary>
		/// Computes the limit for a given flange speed and payload, as the robot does when $STMO_GRP[1].$LMT_MODE is 0:
		/// linear interpolation between the speed stages (the first stage applies below Vmax/20, and values are extrapolated above Vmax),
		/// then linear interpolation between no payload and maximum payload.
		/// </summary>
		/// <param name="flangeSpeed">Peak speed of the flange center, in mm/s</param>
		/// <param name="payload">Payload mass, in kg</param>
		/// <param name="maxPayload">Maximum payload of the robot, in kg</param>
		public double GetValue(double flangeSpeed, double payload, double maxPayload)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


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

		/// <summary>
		/// Axis number (1 to 9)
		/// </summary>
		public int Axis { get; }

		/// <summary>
		/// Type of limit
		/// </summary>
		public LimitType Type { get; }

		/// <summary>
		/// Maximum speed of the flange center (Vmax, system variable $STMO_GRP[1].$MAX_SPD), in mm/s
		/// </summary>
		public double MaxSpeed { get; }

		/// <summary>
		/// Time interval of the intermediate check of the limits, in seconds
		/// </summary>
		public double IntermediateCheckTime { get; }

		/// <summary>
		/// Limits with no payload, for flange speeds up to 1/20, 2/20, ... 20/20 of <see cref="UnderAutomation.Fanuc.StreamMotion.Data.LimitTable.MaxSpeed"/> (20 values)
		/// </summary>
		public double[] NoPayload { get; }

		/// <summary>
		/// Limits with the maximum payload, for flange speeds up to 1/20, 2/20, ... 20/20 of <see cref="UnderAutomation.Fanuc.StreamMotion.Data.LimitTable.MaxSpeed"/> (20 values)
		/// </summary>
		public double[] MaxPayload { get; }

		/// <summary>
		/// Reference limit: value with the maximum payload at the maximum speed.
		/// It is the value of the system variables $STMO_GRP[1].$JNT_VEL_LIM, $JNT_ACC_LIM or $JNT_JRK_LIM.
		/// </summary>
		public double ReferenceValue { get; }

		/// <summary>
		/// Indicates if the axis exists (at least one value is not 0)
		/// </summary>
		public bool IsAxisPresent { get; }
	}
}
