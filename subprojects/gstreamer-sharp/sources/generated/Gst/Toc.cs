// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct Toc : IEquatable<Toc> {


		public static Gst.Toc Zero = new Gst.Toc ();

		public static Gst.Toc New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Toc.Zero;
			return (Gst.Toc) Marshal.PtrToStructure (raw, typeof (Gst.Toc));
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_toc_new(int scope);

		public static Toc New(Gst.TocScope scope)
		{
			Toc result = Toc.New (gst_toc_new((int) scope));
			return result;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_toc_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_toc_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_toc_append_entry(IntPtr raw, IntPtr entry);

		public void AppendEntry(Gst.TocEntry entry) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_entry = GLib.Marshaller.StructureToPtrAlloc (entry);
			gst_toc_append_entry(this_as_native, native_entry);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_entry);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_toc_dump(IntPtr raw);

		public void Dump() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_toc_dump(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_toc_find_entry(IntPtr raw, IntPtr uid);

		public Gst.TocEntry FindEntry(string uid) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_uid = GLib.Marshaller.StringToPtrGStrdup (uid);
			IntPtr raw_ret = gst_toc_find_entry(this_as_native, native_uid);
			Gst.TocEntry ret = Gst.TocEntry.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_uid);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_toc_get_entries(IntPtr raw);

		public GLib.List[] Entries { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_toc_get_entries(this_as_native);
				GLib.List[] ret = (GLib.List[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(GLib.List));
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_toc_get_scope(IntPtr raw);

		public Gst.TocScope Scope { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				int raw_ret = gst_toc_get_scope(this_as_native);
				Gst.TocScope ret = (Gst.TocScope) raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_toc_get_tags(IntPtr raw);

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_toc_set_tags(IntPtr raw, IntPtr tags);

		public Gst.TagList Tags { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr raw_ret = gst_toc_get_tags(this_as_native);
				Gst.TagList ret = raw_ret == IntPtr.Zero ? null : (Gst.TagList) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.TagList), false);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				value.Owned = false;
				gst_toc_set_tags(this_as_native, value == null ? IntPtr.Zero : value.Handle);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_toc_merge_tags(IntPtr raw, IntPtr tags, int mode);

		public void MergeTags(Gst.TagList tags, Gst.TagMergeMode mode) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_toc_merge_tags(this_as_native, tags == null ? IntPtr.Zero : tags.Handle, (int) mode);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		public void MergeTags(Gst.TagMergeMode mode) {
			MergeTags (null, mode);
		}

		static void ReadNative (IntPtr native, ref Gst.Toc target)
		{
			target = New (native);
		}

		public bool Equals (Toc other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is Toc && Equals ((Toc) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Toc boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Toc.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Toc (GLib.Value val)
		{
			return (Gst.Toc) val.Val;
		}
#endregion
	}
}
