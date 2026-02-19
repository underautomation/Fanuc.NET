//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {
	/// <summary>
	/// Provides read/write access to digital I/O signals on the robot.
	/// </summary>
	public class DigitalSignals : SnpxElements<bool, int> {

		/// <summary>
		/// Reads the digital signal at the specified index.
		/// </summary>
		/// <param name="index">The signal index (1-based).</param>
		/// <returns>The boolean state of the signal.</returns>
		public override bool Read(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a range of digital signals.
		/// </summary>
		/// <param name="firstIndex">The first signal index (1-based).</param>
		/// <param name="count">The number of signals to read.</param>
		/// <returns>An array of boolean signal states.</returns>
		public bool[] Read(int firstIndex, ushort count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the digital signal at the specified index.
		/// </summary>
		/// <param name="index">The signal index (1-based).</param>
		/// <param name="value">The boolean value to write.</param>
		public void Write(int index, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes values to consecutive digital signals.
		/// </summary>
		/// <param name="firstIndex">The first signal index (1-based).</param>
		/// <param name="values">The boolean values to write.</param>
		public void Write(int firstIndex, bool[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the segment selector for this signal group.
		/// </summary>
		public SegmentSelector SegmentSelector { get; }

		/// <summary>
		/// Gets the segment offset for this signal group.
		/// </summary>
		public SegmentOffset SegmentOffset { get; }

		/// <summary>
		/// Gets the segment name identifying this signal group.
		/// </summary>
		public SegmentName SegmentName { get; }
	}
}
