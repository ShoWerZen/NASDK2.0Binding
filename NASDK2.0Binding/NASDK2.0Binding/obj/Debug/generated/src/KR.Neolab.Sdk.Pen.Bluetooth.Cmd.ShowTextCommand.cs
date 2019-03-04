using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Cmd {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='ShowTextCommand']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/ShowTextCommand", DoNotGenerateAcw=true)]
	public partial class ShowTextCommand : global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/ShowTextCommand", typeof (ShowTextCommand));
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

		protected ShowTextCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='ShowTextCommand']/constructor[@name='ShowTextCommand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='kr.neolab.sdk.pen.bluetooth.cmd.CommandManager']]"
		[Register (".ctor", "(ILkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;)V", "")]
		public unsafe ShowTextCommand (int key, global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager comp)
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

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ShowTextCommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ShowTextCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string status = JNIEnv.GetString (native_status, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (status);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='ShowTextCommand']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void SetStatus (string status)
		{
			const string __id = "setStatus.(Ljava/lang/String;)V";
			IntPtr native_status = JNIEnv.NewString (status);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_status);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_status);
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ShowTextCommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ShowTextCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='ShowTextCommand']/method[@name='write' and count(parameter)=0]"
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
