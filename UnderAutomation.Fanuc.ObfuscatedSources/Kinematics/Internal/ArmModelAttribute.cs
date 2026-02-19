//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.ComponentModel;
using System.Runtime.InteropServices;
using Kinematics;

namespace Kinematics.Internal {
	/// <summary>
	/// Attribute that associates DH parameters with an arm kinematic model enum value.
	/// </summary>
	public class ArmModelAttribute : DescriptionAttribute, IDhParameters {

		/// <summary>
		/// Initializes a new instance of <xref href="UnderAutomation.Fanuc.Kinematics.Internal.ArmModelAttribute" data-throw-if-not-resolved="false"></xref> with the specified description and DH parameters.
		/// </summary>
		/// <param name="description">The human-readable model name.</param>
		/// <param name="d4">DH parameter D4 (mm).</param>
		/// <param name="d5">DH parameter D5 (mm).</param>
		/// <param name="d6">DH parameter D6 (mm).</param>
		/// <param name="a1">DH parameter A1 (mm).</param>
		/// <param name="a2">DH parameter A2 (mm).</param>
		/// <param name="a3">DH parameter A3 (mm).</param>
		public ArmModelAttribute(string description, double d4, double d5, double d6, double a1, double a2, double a3)
		{
			// Source is hidden, a Source licence is needed to access internal code...
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
		/// DH parameter D4 (mm).
		/// </summary>
		public double D4 { get; }

		/// <summary>
		/// DH parameter D5 (mm).
		/// </summary>
		public double D5 { get; }

		/// <summary>
		/// DH parameter D6 (mm).
		/// </summary>
		public double D6 { get; }

		/// <summary>
		/// DH parameter A1 (mm).
		/// </summary>
		public double A1 { get; }

		/// <summary>
		/// DH parameter A2 (mm).
		/// </summary>
		public double A2 { get; }

		/// <summary>
		/// DH parameter A3 (mm).
		/// </summary>
		public double A3 { get; }
	}
}
