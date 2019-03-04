using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Cmd {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand20']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/FwUpgradeCommand20", DoNotGenerateAcw=true)]
	public partial class FwUpgradeCommand20 : global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand20']/field[@name='PACKET_SIZE']"
		[Register ("PACKET_SIZE")]
		public const int PacketSize = (int) 2048;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/FwUpgradeCommand20", typeof (FwUpgradeCommand20));
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

		protected FwUpgradeCommand20 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand20']/constructor[@name='FwUpgradeCommand20' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='kr.neolab.sdk.pen.bluetooth.cmd.CommandManager']]"
		[Register (".ctor", "(ILkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;)V", "")]
		public unsafe FwUpgradeCommand20 (int key, global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager comp)
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

		static Delegate cb_setInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_);
			return cb_setInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_fwVersion, IntPtr native_deviceName)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand20 __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File source = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_source, JniHandleOwnership.DoNotTransfer);
			string fwVersion = JNIEnv.GetString (native_fwVersion, JniHandleOwnership.DoNotTransfer);
			string deviceName = JNIEnv.GetString (native_deviceName, JniHandleOwnership.DoNotTransfer);
			__this.SetInfo (source, fwVersion, deviceName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand20']/method[@name='setInfo' and count(parameter)=3 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setInfo", "(Ljava/io/File;Ljava/lang/String;Ljava/lang/String;)V", "GetSetInfo_Ljava_io_File_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetInfo (global::Java.IO.File source, string fwVersion, string deviceName)
		{
			const string __id = "setInfo.(Ljava/io/File;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_fwVersion = JNIEnv.NewString (fwVersion);
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (native_fwVersion);
				__args [2] = new JniArgumentValue (native_deviceName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fwVersion);
				JNIEnv.DeleteLocalRef (native_deviceName);
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand20 __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.FwUpgradeCommand20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='FwUpgradeCommand20']/method[@name='write' and count(parameter)=0]"
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
