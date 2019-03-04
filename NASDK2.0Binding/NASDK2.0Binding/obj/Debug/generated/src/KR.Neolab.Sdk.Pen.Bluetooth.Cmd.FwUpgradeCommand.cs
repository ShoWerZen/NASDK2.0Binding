using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Cmd {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/FwUpgradeCommand", DoNotGenerateAcw=true)]
	public partial class FwUpgradeCommand : global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand']/field[@name='rQueue']"
		[Register ("rQueue")]
		public global::Java.Util.IQueue RQueue {
			get {
				const string __id = "rQueue.Ljava/util/Queue;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rQueue.Ljava/util/Queue;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/FwUpgradeCommand", typeof (FwUpgradeCommand));
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

		protected FwUpgradeCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand']/constructor[@name='FwUpgradeCommand' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='kr.neolab.sdk.pen.bluetooth.cmd.CommandManager']]"
		[Register (".ctor", "(ILkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;)V", "")]
		public unsafe FwUpgradeCommand (int key, global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager comp)
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

		static Delegate cb_setInfo_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInfo_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_setInfo_Ljava_io_File_Ljava_lang_String_ == null)
				cb_setInfo_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInfo_Ljava_io_File_Ljava_lang_String_);
			return cb_setInfo_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_SetInfo_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_target)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File source = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_source, JniHandleOwnership.DoNotTransfer);
			string target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			__this.SetInfo (source, target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand']/method[@name='setInfo' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("setInfo", "(Ljava/io/File;Ljava/lang/String;)V", "GetSetInfo_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe void SetInfo (global::Java.IO.File source, string target)
		{
			const string __id = "setInfo.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_target = JNIEnv.NewString (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (native_target);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand']/method[@name='write' and count(parameter)=0]"
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
