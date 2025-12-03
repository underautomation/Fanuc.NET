//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.ComponentModel;
using System.Runtime.InteropServices;
using Kinematics;

namespace Kinematics.Internal {

	public class ArmModelAttribute : DescriptionAttribute, IDhParameters {


		public ArmModelAttribute(string description, double d4, double d5, double d6, double a1, double a2, double a3)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public double D4 { get; }


		public double D5 { get; }


		public double D6 { get; }


		public double A1 { get; }


		public double A2 { get; }


		public double A3 { get; }
	}
}
