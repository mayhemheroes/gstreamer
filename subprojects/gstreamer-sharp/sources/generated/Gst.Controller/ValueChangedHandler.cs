// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Controller {

	using System;

	public delegate void ValueChangedHandler(object o, ValueChangedArgs args);

	public class ValueChangedArgs : GLib.SignalArgs {
		public Gst.Controller.ControlPoint TimedValue{
			get {
				return (Gst.Controller.ControlPoint) Args [0];
			}
		}

	}
}
