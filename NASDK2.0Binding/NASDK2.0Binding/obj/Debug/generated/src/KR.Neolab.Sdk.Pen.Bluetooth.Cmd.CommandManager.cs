using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Cmd {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/CommandManager", DoNotGenerateAcw=true)]
	public abstract partial class CommandManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/field[@name='commands']"
		[Register ("commands")]
		public global::Java.Util.LinkedHashMap Commands {
			get {
				const string __id = "commands.Ljava/util/LinkedHashMap;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "commands.Ljava/util/LinkedHashMap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/field[@name='rQueue']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/CommandManager", typeof (CommandManager));
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

		protected CommandManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/constructor[@name='CommandManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommandManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getConn;
#pragma warning disable 0169
		static Delegate GetGetConnHandler ()
		{
			if (cb_getConn == null)
				cb_getConn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConn);
			return cb_getConn;
		}

		static IntPtr n_GetConn (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Conn);
		}
#pragma warning restore 0169

		public abstract global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread Conn {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='getConn' and count(parameter)=0]"
			[Register ("getConn", "()Lkr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread;", "GetGetConnHandler")] get;
		}

		static Delegate cb_execute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_;
#pragma warning disable 0169
		static Delegate GetExecute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_Handler ()
		{
			if (cb_execute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_ == null)
				cb_execute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Execute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_);
			return cb_execute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_;
		}

		static void n_Execute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_ (IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand command = (global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand> (native_command, JniHandleOwnership.DoNotTransfer);
			__this.Execute (command);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.cmd.ICommand']]"
		[Register ("execute", "(Lkr/neolab/sdk/pen/bluetooth/cmd/ICommand;)V", "GetExecute_Lkr_neolab_sdk_pen_bluetooth_cmd_ICommand_Handler")]
		public virtual unsafe void Execute (global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand command)
		{
			const string __id = "execute.(Lkr/neolab/sdk/pen/bluetooth/cmd/ICommand;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object) command).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fill_arrayBI;
#pragma warning disable 0169
		static Delegate GetFill_arrayBIHandler ()
		{
			if (cb_fill_arrayBI == null)
				cb_fill_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Fill_arrayBI);
			return cb_fill_arrayBI;
		}

		static void n_Fill_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Fill (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='fill' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fill", "([BI)V", "GetFill_arrayBIHandler")]
		public abstract void Fill (byte[] p0, int p1);

		static Delegate cb_finishUpgrade;
#pragma warning disable 0169
		static Delegate GetFinishUpgradeHandler ()
		{
			if (cb_finishUpgrade == null)
				cb_finishUpgrade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishUpgrade);
			return cb_finishUpgrade;
		}

		static void n_FinishUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishUpgrade ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='finishUpgrade' and count(parameter)=0]"
		[Register ("finishUpgrade", "()V", "GetFinishUpgradeHandler")]
		public abstract void FinishUpgrade ();

		static Delegate cb_kill_I;
#pragma warning disable 0169
		static Delegate GetKill_IHandler ()
		{
			if (cb_kill_I == null)
				cb_kill_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Kill_I);
			return cb_kill_I;
		}

		static void n_Kill_I (IntPtr jnienv, IntPtr native__this, int key)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Kill (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='kill' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("kill", "(I)V", "GetKill_IHandler")]
		public virtual unsafe void Kill (int key)
		{
			const string __id = "kill.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqAddUsingNote_II;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_IIHandler ()
		{
			if (cb_reqAddUsingNote_II == null)
				cb_reqAddUsingNote_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ReqAddUsingNote_II);
			return cb_reqAddUsingNote_II;
		}

		static void n_ReqAddUsingNote_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqAddUsingNote", "(II)V", "GetReqAddUsingNote_IIHandler")]
		public abstract void ReqAddUsingNote (int p0, int p1);

		static Delegate cb_reqAddUsingNote_IIarrayI;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_IIarrayIHandler ()
		{
			if (cb_reqAddUsingNote_IIarrayI == null)
				cb_reqAddUsingNote_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ReqAddUsingNote_IIarrayI);
			return cb_reqAddUsingNote_IIarrayI;
		}

		static void n_ReqAddUsingNote_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNote' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("reqAddUsingNote", "(II[I)V", "GetReqAddUsingNote_IIarrayIHandler")]
		public abstract void ReqAddUsingNote (int p0, int p1, int[] p2);

		static Delegate cb_reqAddUsingNote_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_arrayIarrayIHandler ()
		{
			if (cb_reqAddUsingNote_arrayIarrayI == null)
				cb_reqAddUsingNote_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqAddUsingNote_arrayIarrayI);
			return cb_reqAddUsingNote_arrayIarrayI;
		}

		static void n_ReqAddUsingNote_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("reqAddUsingNote", "([I[I)V", "GetReqAddUsingNote_arrayIarrayIHandler")]
		public abstract void ReqAddUsingNote (int[] p0, int[] p1);

		static Delegate cb_reqAddUsingNoteAll;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNoteAllHandler ()
		{
			if (cb_reqAddUsingNoteAll == null)
				cb_reqAddUsingNoteAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqAddUsingNoteAll);
			return cb_reqAddUsingNoteAll;
		}

		static void n_ReqAddUsingNoteAll (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNoteAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNoteAll' and count(parameter)=0]"
		[Register ("reqAddUsingNoteAll", "()V", "GetReqAddUsingNoteAllHandler")]
		public abstract void ReqAddUsingNoteAll ();

		static Delegate cb_reqAutoPowerSetupOnOff_Z;
#pragma warning disable 0169
		static Delegate GetReqAutoPowerSetupOnOff_ZHandler ()
		{
			if (cb_reqAutoPowerSetupOnOff_Z == null)
				cb_reqAutoPowerSetupOnOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqAutoPowerSetupOnOff_Z);
			return cb_reqAutoPowerSetupOnOff_Z;
		}

		static void n_ReqAutoPowerSetupOnOff_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAutoPowerSetupOnOff (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAutoPowerSetupOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqAutoPowerSetupOnOff", "(Z)V", "GetReqAutoPowerSetupOnOff_ZHandler")]
		public abstract void ReqAutoPowerSetupOnOff (bool p0);

		static Delegate cb_reqForceCalibrate;
#pragma warning disable 0169
		static Delegate GetReqForceCalibrateHandler ()
		{
			if (cb_reqForceCalibrate == null)
				cb_reqForceCalibrate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqForceCalibrate);
			return cb_reqForceCalibrate;
		}

		static void n_ReqForceCalibrate (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqForceCalibrate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqForceCalibrate' and count(parameter)=0]"
		[Register ("reqForceCalibrate", "()V", "GetReqForceCalibrateHandler")]
		public abstract void ReqForceCalibrate ();

		static Delegate cb_reqInputPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqInputPassword_Ljava_lang_String_Handler ()
		{
			if (cb_reqInputPassword_Ljava_lang_String_ == null)
				cb_reqInputPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReqInputPassword_Ljava_lang_String_);
			return cb_reqInputPassword_Ljava_lang_String_;
		}

		static void n_ReqInputPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReqInputPassword (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqInputPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reqInputPassword", "(Ljava/lang/String;)V", "GetReqInputPassword_Ljava_lang_String_Handler")]
		public abstract void ReqInputPassword (string p0);

		static Delegate cb_reqOfflineData_III;
#pragma warning disable 0169
		static Delegate GetReqOfflineData_IIIHandler ()
		{
			if (cb_reqOfflineData_III == null)
				cb_reqOfflineData_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ReqOfflineData_III);
			return cb_reqOfflineData_III;
		}

		static void n_ReqOfflineData_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineData (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reqOfflineData", "(III)V", "GetReqOfflineData_IIIHandler")]
		public abstract void ReqOfflineData (int p0, int p1, int p2);

		static Delegate cb_reqOfflineDataList;
#pragma warning disable 0169
		static Delegate GetReqOfflineDataListHandler ()
		{
			if (cb_reqOfflineDataList == null)
				cb_reqOfflineDataList = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqOfflineDataList);
			return cb_reqOfflineDataList;
		}

		static void n_ReqOfflineDataList (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqOfflineDataList' and count(parameter)=0]"
		[Register ("reqOfflineDataList", "()V", "GetReqOfflineDataListHandler")]
		public abstract void ReqOfflineDataList ();

		static Delegate cb_reqPenBeepSetup_Z;
#pragma warning disable 0169
		static Delegate GetReqPenBeepSetup_ZHandler ()
		{
			if (cb_reqPenBeepSetup_Z == null)
				cb_reqPenBeepSetup_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqPenBeepSetup_Z);
			return cb_reqPenBeepSetup_Z;
		}

		static void n_ReqPenBeepSetup_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenBeepSetup (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqPenBeepSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqPenBeepSetup", "(Z)V", "GetReqPenBeepSetup_ZHandler")]
		public abstract void ReqPenBeepSetup (bool p0);

		static Delegate cb_reqPenStatus;
#pragma warning disable 0169
		static Delegate GetReqPenStatusHandler ()
		{
			if (cb_reqPenStatus == null)
				cb_reqPenStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqPenStatus);
			return cb_reqPenStatus;
		}

		static void n_ReqPenStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqPenStatus' and count(parameter)=0]"
		[Register ("reqPenStatus", "()V", "GetReqPenStatusHandler")]
		public abstract void ReqPenStatus ();

		static Delegate cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_ == null)
				cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_);
			return cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_ReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenSwUpgrade (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqPenSwUpgrade' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqPenSwUpgrade", "(Ljava/io/File;Ljava/lang/String;)V", "GetReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_Handler")]
		public abstract void ReqPenSwUpgrade (global::Java.IO.File p0, string p1);

		static Delegate cb_reqSetAutoShutdownTime_S;
#pragma warning disable 0169
		static Delegate GetReqSetAutoShutdownTime_SHandler ()
		{
			if (cb_reqSetAutoShutdownTime_S == null)
				cb_reqSetAutoShutdownTime_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetAutoShutdownTime_S);
			return cb_reqSetAutoShutdownTime_S;
		}

		static void n_ReqSetAutoShutdownTime_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetAutoShutdownTime (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetAutoShutdownTime' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetAutoShutdownTime", "(S)V", "GetReqSetAutoShutdownTime_SHandler")]
		public abstract void ReqSetAutoShutdownTime (short p0);

		static Delegate cb_reqSetPenSensitivity_S;
#pragma warning disable 0169
		static Delegate GetReqSetPenSensitivity_SHandler ()
		{
			if (cb_reqSetPenSensitivity_S == null)
				cb_reqSetPenSensitivity_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetPenSensitivity_S);
			return cb_reqSetPenSensitivity_S;
		}

		static void n_ReqSetPenSensitivity_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetPenSensitivity (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetPenSensitivity' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetPenSensitivity", "(S)V", "GetReqSetPenSensitivity_SHandler")]
		public abstract void ReqSetPenSensitivity (short p0);

		static Delegate cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_);
			return cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetUpPassword (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetUpPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqSetUpPassword", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void ReqSetUpPassword (string p0, string p1);

		static Delegate cb_reqSetupPenTipColor_I;
#pragma warning disable 0169
		static Delegate GetReqSetupPenTipColor_IHandler ()
		{
			if (cb_reqSetupPenTipColor_I == null)
				cb_reqSetupPenTipColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ReqSetupPenTipColor_I);
			return cb_reqSetupPenTipColor_I;
		}

		static void n_ReqSetupPenTipColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenTipColor (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetupPenTipColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reqSetupPenTipColor", "(I)V", "GetReqSetupPenTipColor_IHandler")]
		public abstract void ReqSetupPenTipColor (int p0);

		static Delegate cb_reqSuspendPenSwUpgrade;
#pragma warning disable 0169
		static Delegate GetReqSuspendPenSwUpgradeHandler ()
		{
			if (cb_reqSuspendPenSwUpgrade == null)
				cb_reqSuspendPenSwUpgrade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqSuspendPenSwUpgrade);
			return cb_reqSuspendPenSwUpgrade;
		}

		static void n_ReqSuspendPenSwUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSuspendPenSwUpgrade ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSuspendPenSwUpgrade' and count(parameter)=0]"
		[Register ("reqSuspendPenSwUpgrade", "()V", "GetReqSuspendPenSwUpgradeHandler")]
		public abstract void ReqSuspendPenSwUpgrade ();

		static Delegate cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_;
#pragma warning disable 0169
		static Delegate GetSetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_Handler ()
		{
			if (cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_ == null)
				cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_);
			return cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_;
		}

		static void n_SetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk p0 = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetChunk (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='setChunk' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.Chunk']]"
		[Register ("setChunk", "(Lkr/neolab/sdk/pen/bluetooth/lib/Chunk;)V", "GetSetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_Handler")]
		public abstract void SetChunk (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk p0);

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler")]
		public abstract void Write (byte[] p0);

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/CommandManager", DoNotGenerateAcw=true)]
	internal partial class CommandManagerInvoker : CommandManager {

		public CommandManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/CommandManager", typeof (CommandManagerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread Conn {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='getConn' and count(parameter)=0]"
			[Register ("getConn", "()Lkr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread;", "GetGetConnHandler")]
			get {
				const string __id = "getConn.()Lkr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='fill' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fill", "([BI)V", "GetFill_arrayBIHandler")]
		public override unsafe void Fill (byte[] p0, int p1)
		{
			const string __id = "fill.([BI)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='finishUpgrade' and count(parameter)=0]"
		[Register ("finishUpgrade", "()V", "GetFinishUpgradeHandler")]
		public override unsafe void FinishUpgrade ()
		{
			const string __id = "finishUpgrade.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqAddUsingNote", "(II)V", "GetReqAddUsingNote_IIHandler")]
		public override unsafe void ReqAddUsingNote (int p0, int p1)
		{
			const string __id = "reqAddUsingNote.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNote' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("reqAddUsingNote", "(II[I)V", "GetReqAddUsingNote_IIarrayIHandler")]
		public override unsafe void ReqAddUsingNote (int p0, int p1, int[] p2)
		{
			const string __id = "reqAddUsingNote.(II[I)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("reqAddUsingNote", "([I[I)V", "GetReqAddUsingNote_arrayIarrayIHandler")]
		public override unsafe void ReqAddUsingNote (int[] p0, int[] p1)
		{
			const string __id = "reqAddUsingNote.([I[I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAddUsingNoteAll' and count(parameter)=0]"
		[Register ("reqAddUsingNoteAll", "()V", "GetReqAddUsingNoteAllHandler")]
		public override unsafe void ReqAddUsingNoteAll ()
		{
			const string __id = "reqAddUsingNoteAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqAutoPowerSetupOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqAutoPowerSetupOnOff", "(Z)V", "GetReqAutoPowerSetupOnOff_ZHandler")]
		public override unsafe void ReqAutoPowerSetupOnOff (bool p0)
		{
			const string __id = "reqAutoPowerSetupOnOff.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqForceCalibrate' and count(parameter)=0]"
		[Register ("reqForceCalibrate", "()V", "GetReqForceCalibrateHandler")]
		public override unsafe void ReqForceCalibrate ()
		{
			const string __id = "reqForceCalibrate.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqInputPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reqInputPassword", "(Ljava/lang/String;)V", "GetReqInputPassword_Ljava_lang_String_Handler")]
		public override unsafe void ReqInputPassword (string p0)
		{
			const string __id = "reqInputPassword.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reqOfflineData", "(III)V", "GetReqOfflineData_IIIHandler")]
		public override unsafe void ReqOfflineData (int p0, int p1, int p2)
		{
			const string __id = "reqOfflineData.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqOfflineDataList' and count(parameter)=0]"
		[Register ("reqOfflineDataList", "()V", "GetReqOfflineDataListHandler")]
		public override unsafe void ReqOfflineDataList ()
		{
			const string __id = "reqOfflineDataList.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqPenBeepSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqPenBeepSetup", "(Z)V", "GetReqPenBeepSetup_ZHandler")]
		public override unsafe void ReqPenBeepSetup (bool p0)
		{
			const string __id = "reqPenBeepSetup.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqPenStatus' and count(parameter)=0]"
		[Register ("reqPenStatus", "()V", "GetReqPenStatusHandler")]
		public override unsafe void ReqPenStatus ()
		{
			const string __id = "reqPenStatus.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqPenSwUpgrade' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqPenSwUpgrade", "(Ljava/io/File;Ljava/lang/String;)V", "GetReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_Handler")]
		public override unsafe void ReqPenSwUpgrade (global::Java.IO.File p0, string p1)
		{
			const string __id = "reqPenSwUpgrade.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetAutoShutdownTime' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetAutoShutdownTime", "(S)V", "GetReqSetAutoShutdownTime_SHandler")]
		public override unsafe void ReqSetAutoShutdownTime (short p0)
		{
			const string __id = "reqSetAutoShutdownTime.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetPenSensitivity' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetPenSensitivity", "(S)V", "GetReqSetPenSensitivity_SHandler")]
		public override unsafe void ReqSetPenSensitivity (short p0)
		{
			const string __id = "reqSetPenSensitivity.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetUpPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqSetUpPassword", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void ReqSetUpPassword (string p0, string p1)
		{
			const string __id = "reqSetUpPassword.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSetupPenTipColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reqSetupPenTipColor", "(I)V", "GetReqSetupPenTipColor_IHandler")]
		public override unsafe void ReqSetupPenTipColor (int p0)
		{
			const string __id = "reqSetupPenTipColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='reqSuspendPenSwUpgrade' and count(parameter)=0]"
		[Register ("reqSuspendPenSwUpgrade", "()V", "GetReqSuspendPenSwUpgradeHandler")]
		public override unsafe void ReqSuspendPenSwUpgrade ()
		{
			const string __id = "reqSuspendPenSwUpgrade.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='setChunk' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.Chunk']]"
		[Register ("setChunk", "(Lkr/neolab/sdk/pen/bluetooth/lib/Chunk;)V", "GetSetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_Handler")]
		public override unsafe void SetChunk (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk p0)
		{
			const string __id = "setChunk.(Lkr/neolab/sdk/pen/bluetooth/lib/Chunk;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='CommandManager']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler")]
		public override unsafe void Write (byte[] p0)
		{
			const string __id = "write.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
