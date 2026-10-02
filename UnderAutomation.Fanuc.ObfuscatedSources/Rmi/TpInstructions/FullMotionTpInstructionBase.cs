//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System;
using UnderAutomation.Fanuc.Rmi.Data;

namespace UnderAutomation.Fanuc.Rmi.TpInstructions {
	/// <summary>
	/// Extends <see cref="UnderAutomation.Fanuc.Rmi.TpInstructions.MotionTpInstructionBase"/> with the full set of optional motion modifiers
	/// shared by all non-simplified instruction types.
	/// </summary>
	public abstract class FullMotionTpInstructionBase : MotionTpInstructionBase {


		protected FullMotionTpInstructionBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Optional acceleration override (1-100 %). <code>null</code> uses the controller default.
		/// </summary>
		public byte? Acc { get; set; }

		/// <summary>
		/// Offset position register number. <code>null</code> disables offset.
		/// </summary>
		public short? OffsetPrNumber { get; set; }

		/// <summary>
		/// Vision offset position register number. <code>null</code> disables vision offset.
		/// </summary>
		public short? VisionPrNumber { get; set; }

		/// <summary>
		/// Lock-and-continue (LCB) condition type string. <code>null</code> disables LCB.
		/// </summary>
		public string LcbType { get; set; }

		/// <summary>
		/// Lock-and-continue (LCB) condition value. Required when <see cref="UnderAutomation.Fanuc.Rmi.TpInstructions.FullMotionTpInstructionBase.LcbType"/> is set.
		/// </summary>
		public short? LcbValue { get; set; }

		/// <summary>
		/// Digital output port type to trigger at the end of this motion. <code>null</code> disables output.
		/// </summary>
		public RmiPortType? PortType { get; set; }

		/// <summary>
		/// Digital output port number. Required when <see cref="UnderAutomation.Fanuc.Rmi.TpInstructions.FullMotionTpInstructionBase.PortType"/> is set.
		/// </summary>
		public short? PortNumber { get; set; }

		/// <summary>
		/// Digital output port value. Required when <see cref="UnderAutomation.Fanuc.Rmi.TpInstructions.FullMotionTpInstructionBase.PortType"/> is set.
		/// </summary>
		public RmiOnOff? PortValue { get; set; }

		/// <summary>
		/// Tool-offset position register number. <code>null</code> disables tool offset. Requires MajorVersion &gt;= 4.
		/// </summary>
		public short? ToolOffsetPrNumber { get; set; }
	}
}
