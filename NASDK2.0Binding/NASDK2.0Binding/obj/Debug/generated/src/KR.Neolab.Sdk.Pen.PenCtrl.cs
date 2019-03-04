using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/PenCtrl", DoNotGenerateAcw=true)]
	public partial class PenCtrl : global::Java.Lang.Object, global::KR.Neolab.Sdk.Pen.IPenCtrl {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/PenCtrl", typeof (PenCtrl));
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

		protected PenCtrl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConnectedDevice);
		}
#pragma warning restore 0169

		public virtual unsafe string ConnectedDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='getConnectedDevice' and count(parameter)=0]"
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

		public static unsafe global::KR.Neolab.Sdk.Pen.PenCtrl Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lkr/neolab/sdk/pen/PenCtrl;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lkr/neolab/sdk/pen/PenCtrl;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener listener = (global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Listener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;", "GetGetListenerHandler")]
			get {
				const string __id = "getListener.()Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IPenMsgListener']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener listener = (global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OffLineDataListener = listener;
		}
#pragma warning restore 0169

		public virtual unsafe global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener OffLineDataListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='getOffLineDataListener' and count(parameter)=0]"
			[Register ("getOffLineDataListener", "()Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;", "GetGetOffLineDataListenerHandler")]
			get {
				const string __id = "getOffLineDataListener.()Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='setOffLineDataListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IOfflineDataListener']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProtocolVersion;
		}
#pragma warning restore 0169

		public virtual unsafe int ProtocolVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='getProtocolVersion' and count(parameter)=0]"
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

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calibratePen;
#pragma warning disable 0169
		static Delegate GetCalibratePenHandler ()
		{
			if (cb_calibratePen == null)
				cb_calibratePen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalibratePen);
			return cb_calibratePen;
		}

		static void n_CalibratePen (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalibratePen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='calibratePen' and count(parameter)=0]"
		[Register ("calibratePen", "()V", "GetCalibratePenHandler")]
		public virtual unsafe void CalibratePen ()
		{
			const string __id = "calibratePen.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			__this.Connect (address);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			__this.InputPassword (password);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='inputPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAvailableDevice (mac);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='isAvailableDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_registerBroadcastBTDuplicate;
#pragma warning disable 0169
		static Delegate GetRegisterBroadcastBTDuplicateHandler ()
		{
			if (cb_registerBroadcastBTDuplicate == null)
				cb_registerBroadcastBTDuplicate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterBroadcastBTDuplicate);
			return cb_registerBroadcastBTDuplicate;
		}

		static void n_RegisterBroadcastBTDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterBroadcastBTDuplicate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='registerBroadcastBTDuplicate' and count(parameter)=0]"
		[Register ("registerBroadcastBTDuplicate", "()V", "GetRegisterBroadcastBTDuplicateHandler")]
		public virtual unsafe void RegisterBroadcastBTDuplicate ()
		{
			const string __id = "registerBroadcastBTDuplicate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOfflineData (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='removeOfflineData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] noteIds = (int[]) JNIEnv.GetArray (native_noteIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.RemoveOfflineData (sectionId, ownerId, noteIds);
			if (noteIds != null)
				JNIEnv.CopyArray (noteIds, native_noteIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='removeOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] noteIds = (int[]) JNIEnv.GetArray (native_noteIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (sectionId, ownerId, noteIds);
			if (noteIds != null)
				JNIEnv.CopyArray (noteIds, native_noteIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] sectionId = (int[]) JNIEnv.GetArray (native_sectionId, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] ownerId = (int[]) JNIEnv.GetArray (native_ownerId, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (sectionId, ownerId);
			if (sectionId != null)
				JNIEnv.CopyArray (sectionId, native_sectionId);
			if (ownerId != null)
				JNIEnv.CopyArray (ownerId, native_ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var noteList = global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Util.UseNoteData>.FromJniHandle (native_noteList, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (noteList);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;kr.neolab.sdk.util.UseNoteData&gt;']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNoteAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqAddUsingNoteAll' and count(parameter)=0]"
		[Register ("reqAddUsingNoteAll", "()V", "GetReqAddUsingNoteAllHandler")]
		public virtual unsafe void ReqAddUsingNoteAll ()
		{
			const string __id = "reqAddUsingNoteAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineData (sectionId, ownerId, noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] pageIds = (int[]) JNIEnv.GetArray (native_pageIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqOfflineData (sectionId, ownerId, noteId, pageIds);
			if (pageIds != null)
				JNIEnv.CopyArray (pageIds, native_pageIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqOfflineData' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqOfflineDataList' and count(parameter)=0]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqOfflineDataList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataPageList (sectionId, ownerId, noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqOfflineDataPageList' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqPenStatus' and count(parameter)=0]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oldPassword = JNIEnv.GetString (native_oldPassword, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetUpPasswordOff (oldPassword);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetUpPasswordOff' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupAutoPowerOnOff (setOn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupAutoPowerOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupAutoShutdownTime (minute);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupAutoShutdownTime' and count(parameter)=1 and parameter[1][@type='short']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oldPassword = JNIEnv.GetString (native_oldPassword, JniHandleOwnership.DoNotTransfer);
			string newPassword = JNIEnv.GetString (native_newPassword, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPassword (oldPassword, newPassword);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenBeepOnOff (setOn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupPenBeepOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenCapOff (on);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupPenCapOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenHover (on);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupPenHover' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenSensitivity (level);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupPenSensitivity' and count(parameter)=1 and parameter[1][@type='short']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenTipColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='reqSetupPenTipColor' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowOfflineData (allow);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='setAllowOfflineData' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetContext (global::Android.Content.Context context)
		{
			const string __id = "setContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener listener = (global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetDotListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='setDotListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IPenDotListener']]"
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
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.SetOfflineDataLocation (path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='setOfflineDataLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_startup;
#pragma warning disable 0169
		static Delegate GetStartupHandler ()
		{
			if (cb_startup == null)
				cb_startup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Startup);
			return cb_startup;
		}

		static void n_Startup (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Startup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='startup' and count(parameter)=0]"
		[Register ("startup", "()V", "GetStartupHandler")]
		public virtual unsafe void Startup ()
		{
			const string __id = "startup.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_suspendPenUpgrade;
#pragma warning disable 0169
		static Delegate GetSuspendPenUpgradeHandler ()
		{
			if (cb_suspendPenUpgrade == null)
				cb_suspendPenUpgrade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SuspendPenUpgrade);
			return cb_suspendPenUpgrade;
		}

		static void n_SuspendPenUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SuspendPenUpgrade ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='suspendPenUpgrade' and count(parameter)=0]"
		[Register ("suspendPenUpgrade", "()V", "GetSuspendPenUpgradeHandler")]
		public virtual unsafe void SuspendPenUpgrade ()
		{
			const string __id = "suspendPenUpgrade.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unregisterBroadcastBTDuplicate;
#pragma warning disable 0169
		static Delegate GetUnregisterBroadcastBTDuplicateHandler ()
		{
			if (cb_unregisterBroadcastBTDuplicate == null)
				cb_unregisterBroadcastBTDuplicate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterBroadcastBTDuplicate);
			return cb_unregisterBroadcastBTDuplicate;
		}

		static void n_UnregisterBroadcastBTDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterBroadcastBTDuplicate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='unregisterBroadcastBTDuplicate' and count(parameter)=0]"
		[Register ("unregisterBroadcastBTDuplicate", "()V", "GetUnregisterBroadcastBTDuplicateHandler")]
		public virtual unsafe void UnregisterBroadcastBTDuplicate ()
		{
			const string __id = "unregisterBroadcastBTDuplicate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_upgradePen_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetUpgradePen_Ljava_io_File_Handler ()
		{
			if (cb_upgradePen_Ljava_io_File_ == null)
				cb_upgradePen_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpgradePen_Ljava_io_File_);
			return cb_upgradePen_Ljava_io_File_;
		}

		static void n_UpgradePen_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fwFile)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File fwFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_fwFile, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePen (fwFile);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='upgradePen' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("upgradePen", "(Ljava/io/File;)V", "GetUpgradePen_Ljava_io_File_Handler")]
		public virtual unsafe void UpgradePen (global::Java.IO.File fwFile)
		{
			const string __id = "upgradePen.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fwFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fwFile).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_upgradePen_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpgradePen_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_upgradePen_Ljava_io_File_Ljava_lang_String_ == null)
				cb_upgradePen_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpgradePen_Ljava_io_File_Ljava_lang_String_);
			return cb_upgradePen_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_UpgradePen_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fwFile, IntPtr native_targetPath)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File fwFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_fwFile, JniHandleOwnership.DoNotTransfer);
			string targetPath = JNIEnv.GetString (native_targetPath, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePen (fwFile, targetPath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='upgradePen' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("upgradePen", "(Ljava/io/File;Ljava/lang/String;)V", "GetUpgradePen_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe void UpgradePen (global::Java.IO.File fwFile, string targetPath)
		{
			const string __id = "upgradePen.(Ljava/io/File;Ljava/lang/String;)V";
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

		static Delegate cb_upgradePen2_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpgradePen2_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_upgradePen2_Ljava_io_File_Ljava_lang_String_ == null)
				cb_upgradePen2_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpgradePen2_Ljava_io_File_Ljava_lang_String_);
			return cb_upgradePen2_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_UpgradePen2_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fwFile, IntPtr native_fwVersion)
		{
			global::KR.Neolab.Sdk.Pen.PenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.PenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File fwFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_fwFile, JniHandleOwnership.DoNotTransfer);
			string fwVersion = JNIEnv.GetString (native_fwVersion, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePen2 (fwFile, fwVersion);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/class[@name='PenCtrl']/method[@name='upgradePen2' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("upgradePen2", "(Ljava/io/File;Ljava/lang/String;)V", "GetUpgradePen2_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe void UpgradePen2 (global::Java.IO.File fwFile, string fwVersion)
		{
			const string __id = "upgradePen2.(Ljava/io/File;Ljava/lang/String;)V";
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
