using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Cmd {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='PenStatusCommand']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/PenStatusCommand", DoNotGenerateAcw=true)]
	public partial class PenStatusCommand : global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/PenStatusCommand", typeof (PenStatusCommand));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected PenStatusCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='PenStatusCommand']/constructor[@name='PenStatusCommand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='kr.neolab.sdk.pen.bluetooth.cmd.CommandManager']]"
		[Register (".ctor", "(ILkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;)V", "")]
		public unsafe PenStatusCommand (int key, global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager comp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (key);
				__args [1] = new JniArgumentValue ((comp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_write;
#pragma warning disable 0169
		static Delegate GetWriteHandler ()
		{
			if (cb_write == null)
				cb_write = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Write);
			return cb_write;
		}

		static void n_Write (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.PenStatusCommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.PenStatusCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='PenStatusCommand']/method[@name='write' and count(parameter)=0]"
		[Register ("write", "()V", "GetWriteHandler")]
		protected override unsafe void Write ()
		{
			const string __id = "write.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
