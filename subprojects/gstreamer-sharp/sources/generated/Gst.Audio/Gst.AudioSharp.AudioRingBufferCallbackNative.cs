// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.AudioSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void AudioRingBufferCallbackNative(IntPtr rbuf, byte[] data, uint len, IntPtr user_data);

	internal class AudioRingBufferCallbackInvoker {

		AudioRingBufferCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~AudioRingBufferCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal AudioRingBufferCallbackInvoker (AudioRingBufferCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal AudioRingBufferCallbackInvoker (AudioRingBufferCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal AudioRingBufferCallbackInvoker (AudioRingBufferCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.Audio.AudioRingBufferCallback Handler {
			get {
				return new Gst.Audio.AudioRingBufferCallback(InvokeNative);
			}
		}

		void InvokeNative (Gst.Audio.AudioRingBuffer rbuf, byte[] data, uint len)
		{
			native_cb (rbuf == null ? IntPtr.Zero : rbuf.Handle, data, len, __data);
		}
	}

	internal class AudioRingBufferCallbackWrapper {

		public void NativeCallback (IntPtr rbuf, byte[] data, uint len, IntPtr user_data)
		{
			try {
				managed (GLib.Object.GetObject(rbuf) as Gst.Audio.AudioRingBuffer, data, len);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal AudioRingBufferCallbackNative NativeDelegate;
		Gst.Audio.AudioRingBufferCallback managed;

		public AudioRingBufferCallbackWrapper (Gst.Audio.AudioRingBufferCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new AudioRingBufferCallbackNative (NativeCallback);
		}

		public static Gst.Audio.AudioRingBufferCallback GetManagedDelegate (AudioRingBufferCallbackNative native)
		{
			if (native == null)
				return null;
			AudioRingBufferCallbackWrapper wrapper = (AudioRingBufferCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
