//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Collections.Generic;
using Common;
using System.Collections;

namespace Cgtp.BatchVariables {
	/// <summary>
	/// Collection of batch variables to read from or write to the controller in a single operation.
	/// Provides convenience methods to add typed variables.
	/// </summary>
	public class CgtpBatchVariables : IList<ICgtpBatchVariable>, ICollection<ICgtpBatchVariable>, IEnumerable<ICgtpBatchVariable>, IEnumerable {


		public void Add(ICgtpBatchVariable item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public void Clear()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public bool Contains(ICgtpBatchVariable item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public void CopyTo(ICgtpBatchVariable[] array, int arrayIndex)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public IEnumerator<ICgtpBatchVariable> GetEnumerator()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public int IndexOf(ICgtpBatchVariable item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public void Insert(int index, ICgtpBatchVariable item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public bool Remove(ICgtpBatchVariable item)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public void RemoveAt(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Add multiple variables at once.
		/// </summary>
		public void AddRange(IEnumerable<ICgtpBatchVariable> items)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Add a numeric register for reading. The value and comment will be populated after a batch read.
		/// </summary>
		/// <param name="index">1-based register index (R[index])</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpNumericRegister AddNumericRegister(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a numeric register with an integer value and comment for writing.
		/// </summary>
		/// <param name="index">1-based register index (R[index])</param>
		/// <param name="comment">Register comment (mandatory)</param>
		/// <param name="value">Integer value to write</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpNumericRegister AddNumericRegisterAsInteger(int index, string comment, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a numeric register with a real (double) value and comment for writing.
		/// </summary>
		/// <param name="index">1-based register index (R[index])</param>
		/// <param name="comment">Register comment (mandatory)</param>
		/// <param name="value">Real value to write</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpNumericRegister AddNumericRegisterAsReal(int index, string comment, double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a string register for reading. The value and comment will be populated after a batch read.
		/// </summary>
		/// <param name="index">1-based register index (SR[index])</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpStringRegister AddStringRegister(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a string register with a value and comment for writing.
		/// </summary>
		/// <param name="index">1-based register index (SR[index])</param>
		/// <param name="comment">Register comment (mandatory)</param>
		/// <param name="value">String value to write</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpStringRegister AddStringRegisterWithValue(int index, string comment, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a position register for reading. The position data will be populated after a batch read.
		/// </summary>
		/// <param name="index">1-based register index (PR[index])</param>
		/// <param name="group">Motion group number (default 1)</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpPositionRegister AddPositionRegister(int index, int group = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a position register with a Cartesian position for writing.
		/// </summary>
		/// <param name="index">1-based register index (PR[index])</param>
		/// <param name="position">Cartesian position to write</param>
		/// <param name="group">Motion group number (default 1)</param>
		/// <param name="comment">Optional comment. Null means no comment is written.</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpPositionRegister AddPositionRegisterAsCartesian(int index, CartesianPosition position, int group = 1, string comment = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a position register with a joint position for writing.
		/// </summary>
		/// <param name="index">1-based register index (PR[index])</param>
		/// <param name="position">Joint position to write</param>
		/// <param name="group">Motion group number (default 1)</param>
		/// <param name="comment">Optional comment. Null means no comment is written.</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpPositionRegister AddPositionRegisterAsJoint(int index, JointsPosition position, int group = 1, string comment = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Add a generic variable for reading or writing.
		/// For system variables, leave <code class="paramref">programName</code> null.
		/// Set the desired value on the returned object before performing a batch write.
		/// </summary>
		/// <param name="name">Full variable name (e.g. "$RMT_MASTER", "$MNUTOOL[1,1]")</param>
		/// <param name="programName">Program name that owns the variable. Null for system variables.</param>
		/// <returns>The variable added to the collection</returns>
		public CgtpVariable AddVariable(string name, string programName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public CgtpBatchVariables()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public ICgtpBatchVariable this[int index] { get; set; }


		public int Count { get; }


		public bool IsReadOnly { get; }
	}
}
