using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/BTAdt", DoNotGenerateAcw=true)]
	public partial class BTAdt : global::Java.Lang.Object, global::KR.Neolab.Sdk.Pen.IPenAdt {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='ALLOWED_MAC_PREFIX']"
		[Register ("ALLOWED_MAC_PREFIX")]
		public const string AllowedMacPrefix = (string) "9C:7B:D2";

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='COD_20']"
		[Register ("COD_20")]
		public const int Cod20 = (int) 66972;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='CONN_STATUS_AUTHORIZED']"
		[Register ("CONN_STATUS_AUTHORIZED")]
		public const int ConnStatusAuthorized = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='CONN_STATUS_BINDED']"
		[Register ("CONN_STATUS_BINDED")]
		public const int ConnStatusBinded = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='CONN_STATUS_ESTABLISHED']"
		[Register ("CONN_STATUS_ESTABLISHED")]
		public const int ConnStatusEstablished = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='CONN_STATUS_IDLE']"
		[Register ("CONN_STATUS_IDLE")]
		public const int ConnStatusIdle = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='CONN_STATUS_TRY']"
		[Register ("CONN_STATUS_TRY")]
		public const int ConnStatusTry = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='DENIED_MAC_PREFIX']"
		[Register ("DENIED_MAC_PREFIX")]
		public const string DeniedMacPrefix = (string) "9C:7B:D2:01";

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='NAME_PEN']"
		[Register ("NAME_PEN")]
		public const string NamePen = (string) "NWP-F";

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='QUEUE_DOT']"
		[Register ("QUEUE_DOT")]
		public const int QueueDot = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='QUEUE_MSG']"
		[Register ("QUEUE_MSG")]
		public const int QueueMsg = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='QUEUE_OFFLINE']"
		[Register ("QUEUE_OFFLINE")]
		public const int QueueOffline = (int) 3;


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='allowOffline']"
		[Register ("allowOffline")]
		public static bool AllowOffline {
			get {
				const string __id = "allowOffline.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "allowOffline.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='isFreePass']"
		[Register ("isFreePass")]
		public global::Java.Lang.Boolean IsFreePass {
			get {
				const string __id = "isFreePass.Ljava/lang/Boolean;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "isFreePass.Ljava/lang/Boolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='penAddress']"
		[Register ("penAddress")]
		public string PenAddress {
			get {
				const string __id = "penAddress.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "penAddress.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/field[@name='penBtName']"
		[Register ("penBtName")]
		public string PenBtName {
			get {
				const string __id = "penBtName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "penBtName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']"
		[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread", DoNotGenerateAcw=true)]
		public partial class ConnectedThread : global::Java.Lang.Thread {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread", typeof (ConnectedThread));
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

			protected ConnectedThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/constructor[@name='BTAdt.ConnectedThread' and count(parameter)=2 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.BTAdt'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lkr/neolab/sdk/pen/bluetooth/BTAdt;I)V", "")]
			public unsafe ConnectedThread (global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __self, int protocolVer)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue (protocolVer);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getIsEstablished;
#pragma warning disable 0169
			static Delegate GetGetIsEstablishedHandler ()
			{
				if (cb_getIsEstablished == null)
					cb_getIsEstablished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsEstablished);
				return cb_getIsEstablished;
			}

			static bool n_GetIsEstablished (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsEstablished;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsEstablished {
				// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='getIsEstablished' and count(parameter)=0]"
				[Register ("getIsEstablished", "()Z", "GetGetIsEstablishedHandler")]
				get {
					const string __id = "getIsEstablished.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getMacAddress;
#pragma warning disable 0169
			static Delegate GetGetMacAddressHandler ()
			{
				if (cb_getMacAddress == null)
					cb_getMacAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMacAddress);
				return cb_getMacAddress;
			}

			static IntPtr n_GetMacAddress (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.MacAddress);
			}
#pragma warning restore 0169

			public virtual unsafe string MacAddress {
				// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='getMacAddress' and count(parameter)=0]"
				[Register ("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")]
				get {
					const string __id = "getMacAddress.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPacketProcessor;
#pragma warning disable 0169
			static Delegate GetGetPacketProcessorHandler ()
			{
				if (cb_getPacketProcessor == null)
					cb_getPacketProcessor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPacketProcessor);
				return cb_getPacketProcessor;
			}

			static IntPtr n_GetPacketProcessor (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PacketProcessor);
			}
#pragma warning restore 0169

			public virtual unsafe global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager PacketProcessor {
				// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='getPacketProcessor' and count(parameter)=0]"
				[Register ("getPacketProcessor", "()Lkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;", "GetGetPacketProcessorHandler")]
				get {
					const string __id = "getPacketProcessor.()Lkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_bind_Landroid_bluetooth_BluetoothSocket_;
#pragma warning disable 0169
			static Delegate GetBind_Landroid_bluetooth_BluetoothSocket_Handler ()
			{
				if (cb_bind_Landroid_bluetooth_BluetoothSocket_ == null)
					cb_bind_Landroid_bluetooth_BluetoothSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Bind_Landroid_bluetooth_BluetoothSocket_);
				return cb_bind_Landroid_bluetooth_BluetoothSocket_;
			}

			static bool n_Bind_Landroid_bluetooth_BluetoothSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socket)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Bluetooth.BluetoothSocket socket = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothSocket> (native_socket, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Bind (socket);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='bind' and count(parameter)=1 and parameter[1][@type='android.bluetooth.BluetoothSocket']]"
			[Register ("bind", "(Landroid/bluetooth/BluetoothSocket;)Z", "GetBind_Landroid_bluetooth_BluetoothSocket_Handler")]
			public virtual unsafe bool Bind (global::Android.Bluetooth.BluetoothSocket socket)
			{
				const string __id = "bind.(Landroid/bluetooth/BluetoothSocket;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((socket == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socket).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_onAuthorized;
#pragma warning disable 0169
			static Delegate GetOnAuthorizedHandler ()
			{
				if (cb_onAuthorized == null)
					cb_onAuthorized = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAuthorized);
				return cb_onAuthorized;
			}

			static void n_OnAuthorized (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAuthorized ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='onAuthorized' and count(parameter)=0]"
			[Register ("onAuthorized", "()V", "GetOnAuthorizedHandler")]
			public virtual unsafe void OnAuthorized ()
			{
				const string __id = "onAuthorized.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_onCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_;
#pragma warning disable 0169
			static Delegate GetOnCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler ()
			{
				if (cb_onCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_ == null)
					cb_onCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_);
				return cb_onCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_;
			}

			static void n_OnCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dot)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::KR.Neolab.Sdk.Pen.Filter.Fdot dot = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (native_dot, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateDot (dot);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='onCreateDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.filter.Fdot']]"
			[Register ("onCreateDot", "(Lkr/neolab/sdk/pen/filter/Fdot;)V", "GetOnCreateDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler")]
			public virtual unsafe void OnCreateDot (global::KR.Neolab.Sdk.Pen.Filter.Fdot dot)
			{
				const string __id = "onCreateDot.(Lkr/neolab/sdk/pen/filter/Fdot;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((dot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dot).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_;
#pragma warning disable 0169
			static Delegate GetOnCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_Handler ()
			{
				if (cb_onCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_ == null)
					cb_onCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_);
				return cb_onCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_;
			}

			static void n_OnCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg msg = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (native_msg, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateMsg (msg);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='onCreateMsg' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.PenMsg']]"
			[Register ("onCreateMsg", "(Lkr/neolab/sdk/pen/penmsg/PenMsg;)V", "GetOnCreateMsg_Lkr_neolab_sdk_pen_penmsg_PenMsg_Handler")]
			public virtual unsafe void OnCreateMsg (global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg msg)
			{
				const string __id = "onCreateMsg.(Lkr/neolab/sdk/pen/penmsg/PenMsg;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_;
#pragma warning disable 0169
			static Delegate GetOnCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_Handler ()
			{
				if (cb_onCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_ == null)
					cb_onCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_);
				return cb_onCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_;
			}

			static void n_OnCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offlineByteData)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::KR.Neolab.Sdk.Pen.Offline.OfflineByteData offlineByteData = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineByteData> (native_offlineByteData, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateOfflineStrokes (offlineByteData);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='onCreateOfflineStrokes' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.offline.OfflineByteData']]"
			[Register ("onCreateOfflineStrokes", "(Lkr/neolab/sdk/pen/offline/OfflineByteData;)V", "GetOnCreateOfflineStrokes_Lkr_neolab_sdk_pen_offline_OfflineByteData_Handler")]
			public virtual unsafe void OnCreateOfflineStrokes (global::KR.Neolab.Sdk.Pen.Offline.OfflineByteData offlineByteData)
			{
				const string __id = "onCreateOfflineStrokes.(Lkr/neolab/sdk/pen/offline/OfflineByteData;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((offlineByteData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) offlineByteData).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onEstablished;
#pragma warning disable 0169
			static Delegate GetOnEstablishedHandler ()
			{
				if (cb_onEstablished == null)
					cb_onEstablished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnEstablished);
				return cb_onEstablished;
			}

			static void n_OnEstablished (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnEstablished ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='onEstablished' and count(parameter)=0]"
			[Register ("onEstablished", "()V", "GetOnEstablishedHandler")]
			public virtual unsafe void OnEstablished ()
			{
				const string __id = "onEstablished.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_read;
#pragma warning disable 0169
			static Delegate GetReadHandler ()
			{
				if (cb_read == null)
					cb_read = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Read);
				return cb_read;
			}

			static void n_Read (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Read ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='read' and count(parameter)=0]"
			[Register ("read", "()V", "GetReadHandler")]
			public virtual unsafe void Read ()
			{
				const string __id = "read.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_startConnect;
#pragma warning disable 0169
			static Delegate GetStartConnectHandler ()
			{
				if (cb_startConnect == null)
					cb_startConnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartConnect);
				return cb_startConnect;
			}

			static void n_StartConnect (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.StartConnect ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='startConnect' and count(parameter)=0]"
			[Register ("startConnect", "()V", "GetStartConnectHandler")]
			public virtual unsafe void StartConnect ()
			{
				const string __id = "startConnect.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_stopRunning;
#pragma warning disable 0169
			static Delegate GetStopRunningHandler ()
			{
				if (cb_stopRunning == null)
					cb_stopRunning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopRunning);
				return cb_stopRunning;
			}

			static void n_StopRunning (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.StopRunning ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='stopRunning' and count(parameter)=0]"
			[Register ("stopRunning", "()V", "GetStopRunningHandler")]
			public virtual unsafe void StopRunning ()
			{
				const string __id = "stopRunning.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_unbind;
#pragma warning disable 0169
			static Delegate GetUnbindHandler ()
			{
				if (cb_unbind == null)
					cb_unbind = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unbind);
				return cb_unbind;
			}

			static void n_Unbind (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Unbind ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='unbind' and count(parameter)=0]"
			[Register ("unbind", "()V", "GetUnbindHandler")]
			public virtual unsafe void Unbind ()
			{
				const string __id = "unbind.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_unbind_Z;
#pragma warning disable 0169
			static Delegate GetUnbind_ZHandler ()
			{
				if (cb_unbind_Z == null)
					cb_unbind_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Unbind_Z);
				return cb_unbind_Z;
			}

			static void n_Unbind_Z (IntPtr jnienv, IntPtr native__this, bool isRegularDisconnect)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Unbind (isRegularDisconnect);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='unbind' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("unbind", "(Z)V", "GetUnbind_ZHandler")]
			public virtual unsafe void Unbind (bool isRegularDisconnect)
			{
				const string __id = "unbind.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isRegularDisconnect);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_write_arrayB;
#pragma warning disable 0169
			static Delegate GetWrite_arrayBHandler ()
			{
				if (cb_write_arrayB == null)
					cb_write_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_arrayB);
				return cb_write_arrayB;
			}

			static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Write (buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt.ConnectedThread']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("write", "([B)V", "GetWrite_arrayBHandler")]
			public virtual unsafe void Write (byte[] buffer)
			{
				const string __id = "write.([B)V";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_buffer);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/BTAdt", typeof (BTAdt));
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

		protected BTAdt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/constructor[@name='BTAdt' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BTAdt ()
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

		static Delegate cb_getConnectedDevice;
#pragma warning disable 0169
		static Delegate GetGetConnectedDeviceHandler ()
		{
			if (cb_getConnectedDevice == null)
				cb_getConnectedDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedDevice);
			return cb_getConnectedDevice;
		}

		static IntPtr n_GetConnectedDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConnectedDevice);
		}
#pragma warning restore 0169

		public virtual unsafe string ConnectedDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='getConnectedDevice' and count(parameter)=0]"
			[Register ("getConnectedDevice", "()Ljava/lang/String;", "GetGetConnectedDeviceHandler")]
			get {
				const string __id = "getConnectedDevice.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Context = context;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
			set {
				const string __id = "setContext.(Landroid/content/Context;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public static unsafe global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lkr/neolab/sdk/pen/bluetooth/BTAdt;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lkr/neolab/sdk/pen/bluetooth/BTAdt;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_Handler ()
		{
			if (cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ == null)
				cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_);
			return cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_;
		}

		static void n_SetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener listener = (global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Listener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;", "GetGetListenerHandler")]
			get {
				const string __id = "getListener.()Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IPenMsgListener']]"
			[Register ("setListener", "(Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;)V", "GetSetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_Handler")]
			set {
				const string __id = "setListener.(Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOffLineDataListener;
#pragma warning disable 0169
		static Delegate GetGetOffLineDataListenerHandler ()
		{
			if (cb_getOffLineDataListener == null)
				cb_getOffLineDataListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffLineDataListener);
			return cb_getOffLineDataListener;
		}

		static IntPtr n_GetOffLineDataListener (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OffLineDataListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_;
#pragma warning disable 0169
		static Delegate GetSetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_Handler ()
		{
			if (cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ == null)
				cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_);
			return cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_;
		}

		static void n_SetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener listener = (global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OffLineDataListener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener OffLineDataListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='getOffLineDataListener' and count(parameter)=0]"
			[Register ("getOffLineDataListener", "()Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;", "GetGetOffLineDataListenerHandler")]
			get {
				const string __id = "getOffLineDataListener.()Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='setOffLineDataListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IOfflineDataListener']]"
			[Register ("setOffLineDataListener", "(Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;)V", "GetSetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_Handler")]
			set {
				const string __id = "setOffLineDataListener.(Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProtocolVersion;
#pragma warning disable 0169
		static Delegate GetGetProtocolVersionHandler ()
		{
			if (cb_getProtocolVersion == null)
				cb_getProtocolVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProtocolVersion);
			return cb_getProtocolVersion;
		}

		static int n_GetProtocolVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProtocolVersion;
		}
#pragma warning restore 0169

		public virtual unsafe int ProtocolVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='getProtocolVersion' and count(parameter)=0]"
			[Register ("getProtocolVersion", "()I", "GetGetProtocolVersionHandler")]
			get {
				const string __id = "getProtocolVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_connect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Handler ()
		{
			if (cb_connect_Ljava_lang_String_ == null)
				cb_connect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_String_);
			return cb_connect_Ljava_lang_String_;
		}

		static void n_Connect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			__this.Connect (address);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/String;)V", "GetConnect_Ljava_lang_String_Handler")]
		public virtual unsafe void Connect (string address)
		{
			const string __id = "connect.(Ljava/lang/String;)V";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_address);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_ZHandler ()
		{
			if (cb_connect_Ljava_lang_String_Z == null)
				cb_connect_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_lang_String_Z);
			return cb_connect_Ljava_lang_String_Z;
		}

		static void n_Connect_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_address, bool isFreePass)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			__this.Connect (address, isFreePass);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("connect", "(Ljava/lang/String;Z)V", "GetConnect_Ljava_lang_String_ZHandler")]
		public virtual unsafe void Connect (string address, bool isFreePass)
		{
			const string __id = "connect.(Ljava/lang/String;Z)V";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue (isFreePass);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_endup;
#pragma warning disable 0169
		static Delegate GetEndupHandler ()
		{
			if (cb_endup == null)
				cb_endup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Endup);
			return cb_endup;
		}

		static void n_Endup (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Endup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='endup' and count(parameter)=0]"
		[Register ("endup", "()V", "GetEndupHandler")]
		public virtual unsafe void Endup ()
		{
			const string __id = "endup.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_inputPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInputPassword_Ljava_lang_String_Handler ()
		{
			if (cb_inputPassword_Ljava_lang_String_ == null)
				cb_inputPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InputPassword_Ljava_lang_String_);
			return cb_inputPassword_Ljava_lang_String_;
		}

		static void n_InputPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_password)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			__this.InputPassword (password);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='inputPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("inputPassword", "(Ljava/lang/String;)V", "GetInputPassword_Ljava_lang_String_Handler")]
		public virtual unsafe void InputPassword (string password)
		{
			const string __id = "inputPassword.(Ljava/lang/String;)V";
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_password);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		static Delegate cb_isAvailableDevice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsAvailableDevice_Ljava_lang_String_Handler ()
		{
			if (cb_isAvailableDevice_Ljava_lang_String_ == null)
				cb_isAvailableDevice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAvailableDevice_Ljava_lang_String_);
			return cb_isAvailableDevice_Ljava_lang_String_;
		}

		static bool n_IsAvailableDevice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAvailableDevice (mac);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='isAvailableDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAvailableDevice", "(Ljava/lang/String;)Z", "GetIsAvailableDevice_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsAvailableDevice (string mac)
		{
			const string __id = "isAvailableDevice.(Ljava/lang/String;)Z";
			IntPtr native_mac = JNIEnv.NewString (mac);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mac);
			}
		}

		static Delegate cb_removeOfflineData_II;
#pragma warning disable 0169
		static Delegate GetRemoveOfflineData_IIHandler ()
		{
			if (cb_removeOfflineData_II == null)
				cb_removeOfflineData_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_RemoveOfflineData_II);
			return cb_removeOfflineData_II;
		}

		static void n_RemoveOfflineData_II (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOfflineData (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='removeOfflineData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("removeOfflineData", "(II)V", "GetRemoveOfflineData_IIHandler")]
		public virtual unsafe void RemoveOfflineData (int sectionId, int ownerId)
		{
			const string __id = "removeOfflineData.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeOfflineData_IIarrayI;
#pragma warning disable 0169
		static Delegate GetRemoveOfflineData_IIarrayIHandler ()
		{
			if (cb_removeOfflineData_IIarrayI == null)
				cb_removeOfflineData_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_RemoveOfflineData_IIarrayI);
			return cb_removeOfflineData_IIarrayI;
		}

		static void n_RemoveOfflineData_IIarrayI (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, IntPtr native_noteIds)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] noteIds = (int[]) JNIEnv.GetArray (native_noteIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.RemoveOfflineData (sectionId, ownerId, noteIds);
			if (noteIds != null)
				JNIEnv.CopyArray (noteIds, native_noteIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='removeOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("removeOfflineData", "(II[I)V", "GetRemoveOfflineData_IIarrayIHandler")]
		public virtual unsafe void RemoveOfflineData (int sectionId, int ownerId, int[] noteIds)
		{
			const string __id = "removeOfflineData.(II[I)V";
			IntPtr native_noteIds = JNIEnv.NewArray (noteIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (native_noteIds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (noteIds != null) {
					JNIEnv.CopyArray (native_noteIds, noteIds);
					JNIEnv.DeleteLocalRef (native_noteIds);
				}
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

		static void n_ReqAddUsingNote_II (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqAddUsingNote", "(II)V", "GetReqAddUsingNote_IIHandler")]
		public virtual unsafe void ReqAddUsingNote (int sectionId, int ownerId)
		{
			const string __id = "reqAddUsingNote.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqAddUsingNote_IIarrayI;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_IIarrayIHandler ()
		{
			if (cb_reqAddUsingNote_IIarrayI == null)
				cb_reqAddUsingNote_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ReqAddUsingNote_IIarrayI);
			return cb_reqAddUsingNote_IIarrayI;
		}

		static void n_ReqAddUsingNote_IIarrayI (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, IntPtr native_noteIds)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] noteIds = (int[]) JNIEnv.GetArray (native_noteIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (sectionId, ownerId, noteIds);
			if (noteIds != null)
				JNIEnv.CopyArray (noteIds, native_noteIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqAddUsingNote' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("reqAddUsingNote", "(II[I)V", "GetReqAddUsingNote_IIarrayIHandler")]
		public virtual unsafe void ReqAddUsingNote (int sectionId, int ownerId, int[] noteIds)
		{
			const string __id = "reqAddUsingNote.(II[I)V";
			IntPtr native_noteIds = JNIEnv.NewArray (noteIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (native_noteIds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (noteIds != null) {
					JNIEnv.CopyArray (native_noteIds, noteIds);
					JNIEnv.DeleteLocalRef (native_noteIds);
				}
			}
		}

		static Delegate cb_reqAddUsingNote_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_arrayIarrayIHandler ()
		{
			if (cb_reqAddUsingNote_arrayIarrayI == null)
				cb_reqAddUsingNote_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqAddUsingNote_arrayIarrayI);
			return cb_reqAddUsingNote_arrayIarrayI;
		}

		static void n_ReqAddUsingNote_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_sectionId, IntPtr native_ownerId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] sectionId = (int[]) JNIEnv.GetArray (native_sectionId, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] ownerId = (int[]) JNIEnv.GetArray (native_ownerId, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (sectionId, ownerId);
			if (sectionId != null)
				JNIEnv.CopyArray (sectionId, native_sectionId);
			if (ownerId != null)
				JNIEnv.CopyArray (ownerId, native_ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("reqAddUsingNote", "([I[I)V", "GetReqAddUsingNote_arrayIarrayIHandler")]
		public virtual unsafe void ReqAddUsingNote (int[] sectionId, int[] ownerId)
		{
			const string __id = "reqAddUsingNote.([I[I)V";
			IntPtr native_sectionId = JNIEnv.NewArray (sectionId);
			IntPtr native_ownerId = JNIEnv.NewArray (ownerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sectionId);
				__args [1] = new JniArgumentValue (native_ownerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (sectionId != null) {
					JNIEnv.CopyArray (native_sectionId, sectionId);
					JNIEnv.DeleteLocalRef (native_sectionId);
				}
				if (ownerId != null) {
					JNIEnv.CopyArray (native_ownerId, ownerId);
					JNIEnv.DeleteLocalRef (native_ownerId);
				}
			}
		}

		static Delegate cb_reqAddUsingNote_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_Ljava_util_ArrayList_Handler ()
		{
			if (cb_reqAddUsingNote_Ljava_util_ArrayList_ == null)
				cb_reqAddUsingNote_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReqAddUsingNote_Ljava_util_ArrayList_);
			return cb_reqAddUsingNote_Ljava_util_ArrayList_;
		}

		static void n_ReqAddUsingNote_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_noteList)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var noteList = global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Util.UseNoteData>.FromJniHandle (native_noteList, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (noteList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqAddUsingNote' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;kr.neolab.sdk.util.UseNoteData&gt;']]"
		[Register ("reqAddUsingNote", "(Ljava/util/ArrayList;)V", "GetReqAddUsingNote_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void ReqAddUsingNote (global::System.Collections.Generic.IList<global::KR.Neolab.Sdk.Util.UseNoteData> noteList)
		{
			const string __id = "reqAddUsingNote.(Ljava/util/ArrayList;)V";
			IntPtr native_noteList = global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Util.UseNoteData>.ToLocalJniHandle (noteList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_noteList);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_noteList);
			}
		}

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
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNoteAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqAddUsingNoteAll' and count(parameter)=0]"
		[Register ("reqAddUsingNoteAll", "()V", "GetReqAddUsingNoteAllHandler")]
		public virtual unsafe void ReqAddUsingNoteAll ()
		{
			const string __id = "reqAddUsingNoteAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

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
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqForceCalibrate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqForceCalibrate' and count(parameter)=0]"
		[Register ("reqForceCalibrate", "()V", "GetReqForceCalibrateHandler")]
		public virtual unsafe void ReqForceCalibrate ()
		{
			const string __id = "reqForceCalibrate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reqFwUpgrade_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqFwUpgrade_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_reqFwUpgrade_Ljava_io_File_Ljava_lang_String_ == null)
				cb_reqFwUpgrade_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqFwUpgrade_Ljava_io_File_Ljava_lang_String_);
			return cb_reqFwUpgrade_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_ReqFwUpgrade_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fwFile, IntPtr native_targetPath)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File fwFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_fwFile, JniHandleOwnership.DoNotTransfer);
			string targetPath = JNIEnv.GetString (native_targetPath, JniHandleOwnership.DoNotTransfer);
			__this.ReqFwUpgrade (fwFile, targetPath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqFwUpgrade' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqFwUpgrade", "(Ljava/io/File;Ljava/lang/String;)V", "GetReqFwUpgrade_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe void ReqFwUpgrade (global::Java.IO.File fwFile, string targetPath)
		{
			const string __id = "reqFwUpgrade.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_targetPath = JNIEnv.NewString (targetPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fwFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fwFile).Handle);
				__args [1] = new JniArgumentValue (native_targetPath);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetPath);
			}
		}

		static Delegate cb_reqFwUpgrade2_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqFwUpgrade2_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_reqFwUpgrade2_Ljava_io_File_Ljava_lang_String_ == null)
				cb_reqFwUpgrade2_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqFwUpgrade2_Ljava_io_File_Ljava_lang_String_);
			return cb_reqFwUpgrade2_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_ReqFwUpgrade2_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fwFile, IntPtr native_fwVersion)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File fwFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_fwFile, JniHandleOwnership.DoNotTransfer);
			string fwVersion = JNIEnv.GetString (native_fwVersion, JniHandleOwnership.DoNotTransfer);
			__this.ReqFwUpgrade2 (fwFile, fwVersion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqFwUpgrade2' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqFwUpgrade2", "(Ljava/io/File;Ljava/lang/String;)V", "GetReqFwUpgrade2_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe void ReqFwUpgrade2 (global::Java.IO.File fwFile, string fwVersion)
		{
			const string __id = "reqFwUpgrade2.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_fwVersion = JNIEnv.NewString (fwVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fwFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fwFile).Handle);
				__args [1] = new JniArgumentValue (native_fwVersion);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fwVersion);
			}
		}

		static Delegate cb_reqOfflineData_III;
#pragma warning disable 0169
		static Delegate GetReqOfflineData_IIIHandler ()
		{
			if (cb_reqOfflineData_III == null)
				cb_reqOfflineData_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ReqOfflineData_III);
			return cb_reqOfflineData_III;
		}

		static void n_ReqOfflineData_III (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, int noteId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineData (sectionId, ownerId, noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reqOfflineData", "(III)V", "GetReqOfflineData_IIIHandler")]
		public virtual unsafe void ReqOfflineData (int sectionId, int ownerId, int noteId)
		{
			const string __id = "reqOfflineData.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqOfflineData_IIIarrayI;
#pragma warning disable 0169
		static Delegate GetReqOfflineData_IIIarrayIHandler ()
		{
			if (cb_reqOfflineData_IIIarrayI == null)
				cb_reqOfflineData_IIIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, IntPtr>) n_ReqOfflineData_IIIarrayI);
			return cb_reqOfflineData_IIIarrayI;
		}

		static void n_ReqOfflineData_IIIarrayI (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, int noteId, IntPtr native_pageIds)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] pageIds = (int[]) JNIEnv.GetArray (native_pageIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqOfflineData (sectionId, ownerId, noteId, pageIds);
			if (pageIds != null)
				JNIEnv.CopyArray (pageIds, native_pageIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqOfflineData' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]']]"
		[Register ("reqOfflineData", "(III[I)V", "GetReqOfflineData_IIIarrayIHandler")]
		public virtual unsafe void ReqOfflineData (int sectionId, int ownerId, int noteId, int[] pageIds)
		{
			const string __id = "reqOfflineData.(III[I)V";
			IntPtr native_pageIds = JNIEnv.NewArray (pageIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				__args [3] = new JniArgumentValue (native_pageIds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (pageIds != null) {
					JNIEnv.CopyArray (native_pageIds, pageIds);
					JNIEnv.DeleteLocalRef (native_pageIds);
				}
			}
		}

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
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqOfflineDataList' and count(parameter)=0]"
		[Register ("reqOfflineDataList", "()V", "GetReqOfflineDataListHandler")]
		public virtual unsafe void ReqOfflineDataList ()
		{
			const string __id = "reqOfflineDataList.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reqOfflineDataList_II;
#pragma warning disable 0169
		static Delegate GetReqOfflineDataList_IIHandler ()
		{
			if (cb_reqOfflineDataList_II == null)
				cb_reqOfflineDataList_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ReqOfflineDataList_II);
			return cb_reqOfflineDataList_II;
		}

		static void n_ReqOfflineDataList_II (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqOfflineDataList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqOfflineDataList", "(II)V", "GetReqOfflineDataList_IIHandler")]
		public virtual unsafe void ReqOfflineDataList (int sectionId, int ownerId)
		{
			const string __id = "reqOfflineDataList.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqOfflineDataPageList_III;
#pragma warning disable 0169
		static Delegate GetReqOfflineDataPageList_IIIHandler ()
		{
			if (cb_reqOfflineDataPageList_III == null)
				cb_reqOfflineDataPageList_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ReqOfflineDataPageList_III);
			return cb_reqOfflineDataPageList_III;
		}

		static void n_ReqOfflineDataPageList_III (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, int noteId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataPageList (sectionId, ownerId, noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqOfflineDataPageList' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reqOfflineDataPageList", "(III)V", "GetReqOfflineDataPageList_IIIHandler")]
		public virtual unsafe void ReqOfflineDataPageList (int sectionId, int ownerId, int noteId)
		{
			const string __id = "reqOfflineDataPageList.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqPenStatus' and count(parameter)=0]"
		[Register ("reqPenStatus", "()V", "GetReqPenStatusHandler")]
		public virtual unsafe void ReqPenStatus ()
		{
			const string __id = "reqPenStatus.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reqSetUpPasswordOff_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqSetUpPasswordOff_Ljava_lang_String_Handler ()
		{
			if (cb_reqSetUpPasswordOff_Ljava_lang_String_ == null)
				cb_reqSetUpPasswordOff_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReqSetUpPasswordOff_Ljava_lang_String_);
			return cb_reqSetUpPasswordOff_Ljava_lang_String_;
		}

		static void n_ReqSetUpPasswordOff_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldPassword)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oldPassword = JNIEnv.GetString (native_oldPassword, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetUpPasswordOff (oldPassword);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetUpPasswordOff' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reqSetUpPasswordOff", "(Ljava/lang/String;)V", "GetReqSetUpPasswordOff_Ljava_lang_String_Handler")]
		public virtual unsafe void ReqSetUpPasswordOff (string oldPassword)
		{
			const string __id = "reqSetUpPasswordOff.(Ljava/lang/String;)V";
			IntPtr native_oldPassword = JNIEnv.NewString (oldPassword);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_oldPassword);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_oldPassword);
			}
		}

		static Delegate cb_reqSetupAutoPowerOnOff_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupAutoPowerOnOff_ZHandler ()
		{
			if (cb_reqSetupAutoPowerOnOff_Z == null)
				cb_reqSetupAutoPowerOnOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupAutoPowerOnOff_Z);
			return cb_reqSetupAutoPowerOnOff_Z;
		}

		static void n_ReqSetupAutoPowerOnOff_Z (IntPtr jnienv, IntPtr native__this, bool setOn)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupAutoPowerOnOff (setOn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupAutoPowerOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupAutoPowerOnOff", "(Z)V", "GetReqSetupAutoPowerOnOff_ZHandler")]
		public virtual unsafe void ReqSetupAutoPowerOnOff (bool setOn)
		{
			const string __id = "reqSetupAutoPowerOnOff.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setOn);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetupAutoShutdownTime_S;
#pragma warning disable 0169
		static Delegate GetReqSetupAutoShutdownTime_SHandler ()
		{
			if (cb_reqSetupAutoShutdownTime_S == null)
				cb_reqSetupAutoShutdownTime_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetupAutoShutdownTime_S);
			return cb_reqSetupAutoShutdownTime_S;
		}

		static void n_ReqSetupAutoShutdownTime_S (IntPtr jnienv, IntPtr native__this, short minute)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupAutoShutdownTime (minute);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupAutoShutdownTime' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetupAutoShutdownTime", "(S)V", "GetReqSetupAutoShutdownTime_SHandler")]
		public virtual unsafe void ReqSetupAutoShutdownTime (short minute)
		{
			const string __id = "reqSetupAutoShutdownTime.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minute);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqSetupPassword_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqSetupPassword_Ljava_lang_String_Ljava_lang_String_);
			return cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ReqSetupPassword_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldPassword, IntPtr native_newPassword)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oldPassword = JNIEnv.GetString (native_oldPassword, JniHandleOwnership.DoNotTransfer);
			string newPassword = JNIEnv.GetString (native_newPassword, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPassword (oldPassword, newPassword);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqSetupPassword", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReqSetupPassword_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ReqSetupPassword (string oldPassword, string newPassword)
		{
			const string __id = "reqSetupPassword.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_oldPassword = JNIEnv.NewString (oldPassword);
			IntPtr native_newPassword = JNIEnv.NewString (newPassword);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_oldPassword);
				__args [1] = new JniArgumentValue (native_newPassword);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_oldPassword);
				JNIEnv.DeleteLocalRef (native_newPassword);
			}
		}

		static Delegate cb_reqSetupPenBeepOnOff_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupPenBeepOnOff_ZHandler ()
		{
			if (cb_reqSetupPenBeepOnOff_Z == null)
				cb_reqSetupPenBeepOnOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupPenBeepOnOff_Z);
			return cb_reqSetupPenBeepOnOff_Z;
		}

		static void n_ReqSetupPenBeepOnOff_Z (IntPtr jnienv, IntPtr native__this, bool setOn)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenBeepOnOff (setOn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupPenBeepOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupPenBeepOnOff", "(Z)V", "GetReqSetupPenBeepOnOff_ZHandler")]
		public virtual unsafe void ReqSetupPenBeepOnOff (bool setOn)
		{
			const string __id = "reqSetupPenBeepOnOff.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (setOn);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetupPenCapOff_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupPenCapOff_ZHandler ()
		{
			if (cb_reqSetupPenCapOff_Z == null)
				cb_reqSetupPenCapOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupPenCapOff_Z);
			return cb_reqSetupPenCapOff_Z;
		}

		static void n_ReqSetupPenCapOff_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenCapOff (on);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupPenCapOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupPenCapOff", "(Z)V", "GetReqSetupPenCapOff_ZHandler")]
		public virtual unsafe void ReqSetupPenCapOff (bool on)
		{
			const string __id = "reqSetupPenCapOff.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetupPenHover_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupPenHover_ZHandler ()
		{
			if (cb_reqSetupPenHover_Z == null)
				cb_reqSetupPenHover_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupPenHover_Z);
			return cb_reqSetupPenHover_Z;
		}

		static void n_ReqSetupPenHover_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenHover (on);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupPenHover' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupPenHover", "(Z)V", "GetReqSetupPenHover_ZHandler")]
		public virtual unsafe void ReqSetupPenHover (bool on)
		{
			const string __id = "reqSetupPenHover.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetupPenSensitivity_S;
#pragma warning disable 0169
		static Delegate GetReqSetupPenSensitivity_SHandler ()
		{
			if (cb_reqSetupPenSensitivity_S == null)
				cb_reqSetupPenSensitivity_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetupPenSensitivity_S);
			return cb_reqSetupPenSensitivity_S;
		}

		static void n_ReqSetupPenSensitivity_S (IntPtr jnienv, IntPtr native__this, short level)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenSensitivity (level);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupPenSensitivity' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetupPenSensitivity", "(S)V", "GetReqSetupPenSensitivity_SHandler")]
		public virtual unsafe void ReqSetupPenSensitivity (short level)
		{
			const string __id = "reqSetupPenSensitivity.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (level);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetupPenTipColor_I;
#pragma warning disable 0169
		static Delegate GetReqSetupPenTipColor_IHandler ()
		{
			if (cb_reqSetupPenTipColor_I == null)
				cb_reqSetupPenTipColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ReqSetupPenTipColor_I);
			return cb_reqSetupPenTipColor_I;
		}

		static void n_ReqSetupPenTipColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenTipColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSetupPenTipColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reqSetupPenTipColor", "(I)V", "GetReqSetupPenTipColor_IHandler")]
		public virtual unsafe void ReqSetupPenTipColor (int color)
		{
			const string __id = "reqSetupPenTipColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSuspendFwUpgrade;
#pragma warning disable 0169
		static Delegate GetReqSuspendFwUpgradeHandler ()
		{
			if (cb_reqSuspendFwUpgrade == null)
				cb_reqSuspendFwUpgrade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqSuspendFwUpgrade);
			return cb_reqSuspendFwUpgrade;
		}

		static void n_ReqSuspendFwUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSuspendFwUpgrade ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='reqSuspendFwUpgrade' and count(parameter)=0]"
		[Register ("reqSuspendFwUpgrade", "()V", "GetReqSuspendFwUpgradeHandler")]
		public virtual unsafe void ReqSuspendFwUpgrade ()
		{
			const string __id = "reqSuspendFwUpgrade.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAllowOfflineData_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowOfflineData_ZHandler ()
		{
			if (cb_setAllowOfflineData_Z == null)
				cb_setAllowOfflineData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowOfflineData_Z);
			return cb_setAllowOfflineData_Z;
		}

		static void n_SetAllowOfflineData_Z (IntPtr jnienv, IntPtr native__this, bool allow)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowOfflineData (allow);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='setAllowOfflineData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowOfflineData", "(Z)V", "GetSetAllowOfflineData_ZHandler")]
		public virtual unsafe void SetAllowOfflineData (bool allow)
		{
			const string __id = "setAllowOfflineData.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allow);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_;
#pragma warning disable 0169
		static Delegate GetSetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_Handler ()
		{
			if (cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ == null)
				cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_);
			return cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_;
		}

		static void n_SetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener listener = (global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetDotListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='setDotListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IPenDotListener']]"
		[Register ("setDotListener", "(Lkr/neolab/sdk/pen/penmsg/IPenDotListener;)V", "GetSetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_Handler")]
		public virtual unsafe void SetDotListener (global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener listener)
		{
			const string __id = "setDotListener.(Lkr/neolab/sdk/pen/penmsg/IPenDotListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOfflineDataLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOfflineDataLocation_Ljava_lang_String_Handler ()
		{
			if (cb_setOfflineDataLocation_Ljava_lang_String_ == null)
				cb_setOfflineDataLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOfflineDataLocation_Ljava_lang_String_);
			return cb_setOfflineDataLocation_Ljava_lang_String_;
		}

		static void n_SetOfflineDataLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.SetOfflineDataLocation (path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='setOfflineDataLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOfflineDataLocation", "(Ljava/lang/String;)V", "GetSetOfflineDataLocation_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOfflineDataLocation (string path)
		{
			const string __id = "setOfflineDataLocation.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_startListen;
#pragma warning disable 0169
		static Delegate GetStartListenHandler ()
		{
			if (cb_startListen == null)
				cb_startListen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartListen);
			return cb_startListen;
		}

		static void n_StartListen (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartListen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth']/class[@name='BTAdt']/method[@name='startListen' and count(parameter)=0]"
		[Register ("startListen", "()V", "GetStartListenHandler")]
		public virtual unsafe void StartListen ()
		{
			const string __id = "startListen.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener"
		public event EventHandler<global::KR.Neolab.Sdk.Pen.Penmsg.PenDotEventArgs> Dot {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener, global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListenerImplementor>(
						ref weak_implementor_SetDotListener,
						__CreateIPenDotListenerImplementor,
						SetDotListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener, global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListenerImplementor>(
						ref weak_implementor_SetDotListener,
						global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListenerImplementor.__IsEmpty,
						__v => SetDotListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetDotListener;

		global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListenerImplementor __CreateIPenDotListenerImplementor ()
		{
			return new global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListenerImplementor (this);
		}
#endregion
#region "Event implementation for KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener"

		global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListenerImplementor __CreateIPenMsgListenerImplementor ()
		{
			return new global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListenerImplementor (this);
		}
#endregion
#region "Event implementation for KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener"
		public event EventHandler<global::KR.Neolab.Sdk.Pen.Penmsg.OfflineDataEventArgs> OffLineData {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener, global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListenerImplementor>(
						ref weak_implementor___SetOffLineDataListener,
						__CreateIOfflineDataListenerImplementor,
						__v => OffLineDataListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener, global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListenerImplementor>(
						ref weak_implementor___SetOffLineDataListener,
						global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListenerImplementor.__IsEmpty,
						__v => OffLineDataListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOffLineDataListener;

		global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListenerImplementor __CreateIOfflineDataListenerImplementor ()
		{
			return new global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListenerImplementor (this);
		}
#endregion
	}
}
