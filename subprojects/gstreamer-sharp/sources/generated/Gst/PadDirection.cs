// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.PadDirectionGType))]
	public enum PadDirection {

		Unknown = 0,
		Src = 1,
		Sink = 2,
	}

	internal class PadDirectionGType {
		[DllImport ("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_pad_direction_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_pad_direction_get_type ());
			}
		}
	}
#endregion
}
