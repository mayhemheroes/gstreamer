// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool MetaInitFunctionNative(IntPtr meta, IntPtr parms, IntPtr buffer);

	internal class MetaInitFunctionInvoker {

		MetaInitFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~MetaInitFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal MetaInitFunctionInvoker (MetaInitFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal MetaInitFunctionInvoker (MetaInitFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal MetaInitFunctionInvoker (MetaInitFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.MetaInitFunction Handler {
			get {
				return new Gst.MetaInitFunction(InvokeNative);
			}
		}

		bool InvokeNative (Gst.Meta meta, IntPtr parms, Gst.Buffer buffer)
		{
			IntPtr native_meta = GLib.Marshaller.StructureToPtrAlloc (meta);
			bool __result = native_cb (native_meta, parms, buffer == null ? IntPtr.Zero : buffer.Handle);
			Marshal.FreeHGlobal (native_meta);
			return __result;
		}
	}

	internal class MetaInitFunctionWrapper {

		public bool NativeCallback (IntPtr meta, IntPtr parms, IntPtr buffer)
		{
			try {
				bool __ret = managed (Gst.Meta.New (meta), parms, buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (buffer, typeof (Gst.Buffer), false));
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal MetaInitFunctionNative NativeDelegate;
		Gst.MetaInitFunction managed;

		public MetaInitFunctionWrapper (Gst.MetaInitFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new MetaInitFunctionNative (NativeCallback);
		}

		public static Gst.MetaInitFunction GetManagedDelegate (MetaInitFunctionNative native)
		{
			if (native == null)
				return null;
			MetaInitFunctionWrapper wrapper = (MetaInitFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
