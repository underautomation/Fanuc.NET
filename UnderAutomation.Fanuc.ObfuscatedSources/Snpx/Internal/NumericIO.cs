//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Snpx.Internal {
	/// <summary>
	/// Provides read/write access to numeric (group/analog) I/O on the robot.
	/// </summary>
	public class NumericIO : SnpxElements<ushort, int> {

		/// <summary>
		/// Reads the numeric I/O value at the specified index.
		/// </summary>
		/// <param name="index">The I/O index (1-based).</param>
		/// <returns>The numeric I/O value.</returns>
		public override ushort Read(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads a range of numeric I/O values.
		/// </summary>
		/// <param name="firstIndex">The first I/O index (1-based).</param>
		/// <param name="count">The number of values to read.</param>
		/// <returns>An array of numeric I/O values.</returns>
		public ushort[] Read(int firstIndex, ushort count)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a value to the numeric I/O at the specified index.
		/// </summary>
		/// <param name="index">The I/O index (1-based).</param>
		/// <param name="value">The value to write.</param>
		public void Write(int index, ushort value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes values to consecutive numeric I/O.
		/// </summary>
		/// <param name="firstIndex">The first I/O index (1-based).</param>
		/// <param name="values">The values to write.</param>
		public void Write(int firstIndex, ushort[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the segment selector for this I/O group.
		/// </summary>
		public SegmentSelector SegmentSelector { get; }

		/// <summary>
		/// Gets the segment offset for this I/O group.
		/// </summary>
		public SegmentOffset SegmentOffset { get; }

		/// <summary>
		/// Gets the segment name identifying this I/O group.
		/// </summary>
		public SegmentName SegmentName { get; }
	}
}
