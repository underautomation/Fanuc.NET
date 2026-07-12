//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;

namespace Rmi.Data {
	/// <summary>
	/// Parameters for defining payload mass, center of gravity, and optionally inertia
	/// for a payload schedule.
	/// Used by <xref href="UnderAutomation.Fanuc.Rmi.Internal.RmiClientBase.SetPayloadValue(UnderAutomation.Fanuc.Rmi.Data.RmiSetPayloadParameters)" data-throw-if-not-resolved="false"></xref>.
	/// All positional values are in meters; mass in kg; inertia in kg·m².
	/// </summary>
	public class RmiSetPayloadParameters {


		public RmiSetPayloadParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Payload schedule number to configure.
		/// </summary>
		public byte ScheduleNumber { get; set; }

		/// <summary>
		/// Payload mass in kilograms.
		/// </summary>
		public float MassKg { get; set; }

		/// <summary>
		/// Center-of-gravity X offset in meters.
		/// </summary>
		public float CgXm { get; set; }

		/// <summary>
		/// Center-of-gravity Y offset in meters.
		/// </summary>
		public float CgYm { get; set; }

		/// <summary>
		/// Center-of-gravity Z offset in meters.
		/// </summary>
		public float CgZm { get; set; }

		/// <summary>
		/// Inertia around the X axis in kg·m². <code>null</code> omits this field from the command.
		/// </summary>
		public float? InertiaXkgm2 { get; set; }

		/// <summary>
		/// Inertia around the Y axis in kg·m². <code>null</code> omits this field from the command.
		/// </summary>
		public float? InertiaYkgm2 { get; set; }

		/// <summary>
		/// Inertia around the Z axis in kg·m². <code>null</code> omits this field from the command.
		/// </summary>
		public float? InertiaZkgm2 { get; set; }

		/// <summary>
		/// Optional motion group number. <code>null</code> uses the active group.
		/// </summary>
		public byte? Group { get; set; }
	}
}
