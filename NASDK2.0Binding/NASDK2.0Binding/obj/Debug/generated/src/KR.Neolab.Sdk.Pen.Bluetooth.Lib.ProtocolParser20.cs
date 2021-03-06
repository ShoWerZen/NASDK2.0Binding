using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20", DoNotGenerateAcw=true)]
	public partial class ProtocolParser20 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/field[@name='PKT_DLE']"
		[Register ("PKT_DLE")]
		public const int PktDle = (int) 125;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/field[@name='PKT_RESULT_FAIL']"
		[Register ("PKT_RESULT_FAIL")]
		public const int PktResultFail = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/field[@name='PKT_RESULT_FAIL2']"
		[Register ("PKT_RESULT_FAIL2")]
		public const int PktResultFail2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/field[@name='PKT_RESULT_SUCCESS']"
		[Register ("PKT_RESULT_SUCCESS")]
		public const int PktResultSuccess = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/interface[@name='ProtocolParser20.IParsedPacketListener']"
		[Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20$IParsedPacketListener", "", "KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20/IParsedPacketListenerInvoker")]
		public partial interface IParsedPacketListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/interface[@name='ProtocolParser20.IParsedPacketListener']/method[@name='onCreatePacket' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.Packet']]"
			[Register ("onCreatePacket", "(Lkr/neolab/sdk/pen/bluetooth/lib/Packet;)V", "GetOnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_Handler:KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20/IParsedPacketListenerInvoker, NASDK2.0Binding")]
			void OnCreatePacket (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet p0);

		}

		[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20$IParsedPacketListener", DoNotGenerateAcw=true)]
		internal class IParsedPacketListenerInvoker : global::Java.Lang.Object, IParsedPacketListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20$IParsedPacketListener", typeof (IParsedPacketListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IParsedPacketListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IParsedPacketListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.bluetooth.lib.ProtocolParser20.IParsedPacketListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IParsedPacketListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_;
#pragma warning disable 0169
			static Delegate GetOnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_Handler ()
			{
				if (cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ == null)
					cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_);
				return cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_;
			}

			static void n_OnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.IParsedPacketListener __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.IParsedPacketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet p0 = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCreatePacket (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_;
			public unsafe void OnCreatePacket (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet p0)
			{
				if (id_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ == IntPtr.Zero)
					id_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ = JNIEnv.GetMethodID (class_ref, "onCreatePacket", "(Lkr/neolab/sdk/pen/bluetooth/lib/Packet;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_, __args);
			}

		}

		// event args for kr.neolab.sdk.pen.bluetooth.lib.ProtocolParser20.IParsedPacketListener.onCreatePacket
		public partial class ParsedPacketEventArgs : global::System.EventArgs {

			public ParsedPacketEventArgs (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet p0)
			{
				this.p0 = p0;
			}

			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet p0;
			public global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20_IParsedPacketListenerImplementor")]
		internal sealed partial class IParsedPacketListenerImplementor : global::Java.Lang.Object, IParsedPacketListener {

			object sender;

			public IParsedPacketListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20_IParsedPacketListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ParsedPacketEventArgs> Handler;
#pragma warning restore 0649

			public void OnCreatePacket (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ParsedPacketEventArgs (p0));
			}

			internal static bool __IsEmpty (IParsedPacketListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']"
		[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20$PacketBuilder", DoNotGenerateAcw=true)]
		public partial class PacketBuilder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20$PacketBuilder", typeof (PacketBuilder));
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

			protected PacketBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/constructor[@name='ProtocolParser20.PacketBuilder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe PacketBuilder (int length)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (length);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/constructor[@name='ProtocolParser20.PacketBuilder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe PacketBuilder (int length, int errorCode)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (length);
					__args [1] = new JniArgumentValue (errorCode);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_ResizeByteArray_arrayBI;
#pragma warning disable 0169
			static Delegate GetResizeByteArray_arrayBIHandler ()
			{
				if (cb_ResizeByteArray_arrayBI == null)
					cb_ResizeByteArray_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_ResizeByteArray_arrayBI);
				return cb_ResizeByteArray_arrayBI;
			}

			static IntPtr n_ResizeByteArray_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes, int newsize)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.ResizeByteArray (bytes, newsize));
				if (bytes != null)
					JNIEnv.CopyArray (bytes, native_bytes);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='ResizeByteArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("ResizeByteArray", "([BI)[B", "GetResizeByteArray_arrayBIHandler")]
			public virtual unsafe byte[] ResizeByteArray (byte[] bytes, int newsize)
			{
				const string __id = "ResizeByteArray.([BI)[B";
				IntPtr native_bytes = JNIEnv.NewArray (bytes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_bytes);
					__args [1] = new JniArgumentValue (newsize);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
					if (bytes != null) {
						JNIEnv.CopyArray (native_bytes, bytes);
						JNIEnv.DeleteLocalRef (native_bytes);
					}
				}
			}

			static Delegate cb_allocate_I;
#pragma warning disable 0169
			static Delegate GetAllocate_IHandler ()
			{
				if (cb_allocate_I == null)
					cb_allocate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Allocate_I);
				return cb_allocate_I;
			}

			static void n_Allocate_I (IntPtr jnienv, IntPtr native__this, int length)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Allocate (length);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='allocate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("allocate", "(I)V", "GetAllocate_IHandler")]
			public virtual unsafe void Allocate (int length)
			{
				const string __id = "allocate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (length);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_allocate_II;
#pragma warning disable 0169
			static Delegate GetAllocate_IIHandler ()
			{
				if (cb_allocate_II == null)
					cb_allocate_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Allocate_II);
				return cb_allocate_II;
			}

			static void n_Allocate_II (IntPtr jnienv, IntPtr native__this, int length, int errorCode)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Allocate (length, errorCode);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='allocate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("allocate", "(II)V", "GetAllocate_IIHandler")]
			public virtual unsafe void Allocate (int length, int errorCode)
			{
				const string __id = "allocate.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (length);
					__args [1] = new JniArgumentValue (errorCode);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getPacket;
#pragma warning disable 0169
			static Delegate GetGetPacketHandler ()
			{
				if (cb_getPacket == null)
					cb_getPacket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPacket);
				return cb_getPacket;
			}

			static IntPtr n_GetPacket (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetPacket ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='getPacket' and count(parameter)=0]"
			[Register ("getPacket", "()[B", "GetGetPacketHandler")]
			public virtual unsafe byte[] GetPacket ()
			{
				const string __id = "getPacket.()[B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_setCommand_I;
#pragma warning disable 0169
			static Delegate GetSetCommand_IHandler ()
			{
				if (cb_setCommand_I == null)
					cb_setCommand_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCommand_I);
				return cb_setCommand_I;
			}

			static void n_SetCommand_I (IntPtr jnienv, IntPtr native__this, int cmd)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetCommand (cmd);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='setCommand' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCommand", "(I)V", "GetSetCommand_IHandler")]
			public virtual unsafe void SetCommand (int cmd)
			{
				const string __id = "setCommand.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (cmd);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_showPacket;
#pragma warning disable 0169
			static Delegate GetShowPacketHandler ()
			{
				if (cb_showPacket == null)
					cb_showPacket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowPacket);
				return cb_showPacket;
			}

			static IntPtr n_ShowPacket (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ShowPacket ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='showPacket' and count(parameter)=0]"
			[Register ("showPacket", "()Ljava/lang/String;", "GetShowPacketHandler")]
			public virtual unsafe string ShowPacket ()
			{
				const string __id = "showPacket.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='showPacket' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("showPacket", "([BI)Ljava/lang/String;", "")]
			public static unsafe string ShowPacket (byte[] bytes, int count)
			{
				const string __id = "showPacket.([BI)Ljava/lang/String;";
				IntPtr native_bytes = JNIEnv.NewArray (bytes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_bytes);
					__args [1] = new JniArgumentValue (count);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (bytes != null) {
						JNIEnv.CopyArray (native_bytes, bytes);
						JNIEnv.DeleteLocalRef (native_bytes);
					}
				}
			}

			static Delegate cb_write_B;
#pragma warning disable 0169
			static Delegate GetWrite_BHandler ()
			{
				if (cb_write_B == null)
					cb_write_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte>) n_Write_B);
				return cb_write_B;
			}

			static void n_Write_B (IntPtr jnienv, IntPtr native__this, sbyte data)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Write (data);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("write", "(B)V", "GetWrite_BHandler")]
			public virtual unsafe void Write (sbyte data)
			{
				const string __id = "write.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (data);
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Write (buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

			static Delegate cb_write_arrayBI;
#pragma warning disable 0169
			static Delegate GetWrite_arrayBIHandler ()
			{
				if (cb_write_arrayBI == null)
					cb_write_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayBI);
				return cb_write_arrayBI;
			}

			static void n_Write_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int valid_size)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Write (buffer, valid_size);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20.PacketBuilder']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("write", "([BI)V", "GetWrite_arrayBIHandler")]
			public virtual unsafe void Write (byte[] buffer, int valid_size)
			{
				const string __id = "write.([BI)V";
				IntPtr native_buffer = JNIEnv.NewArray (buffer);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_buffer);
					__args [1] = new JniArgumentValue (valid_size);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (buffer != null) {
						JNIEnv.CopyArray (native_buffer, buffer);
						JNIEnv.DeleteLocalRef (native_buffer);
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20", typeof (ProtocolParser20));
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

		protected ProtocolParser20 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/constructor[@name='ProtocolParser20' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.ProtocolParser20.IParsedPacketListener']]"
		[Register (".ctor", "(Lkr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20$IParsedPacketListener;)V", "")]
		public unsafe ProtocolParser20 (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20.IParsedPacketListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkr/neolab/sdk/pen/bluetooth/lib/ProtocolParser20$IParsedPacketListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildAddUsingAllNotes' and count(parameter)=0]"
		[Register ("buildAddUsingAllNotes", "()[B", "")]
		public static unsafe byte[] BuildAddUsingAllNotes ()
		{
			const string __id = "buildAddUsingAllNotes.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildAddUsingNotes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("buildAddUsingNotes", "(II)[B", "")]
		public static unsafe byte[] BuildAddUsingNotes (int sectionId, int ownerId)
		{
			const string __id = "buildAddUsingNotes.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildAddUsingNotes' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("buildAddUsingNotes", "([I[I)[B", "")]
		public static unsafe byte[] BuildAddUsingNotes (int[] sectionId, int[] ownerId)
		{
			const string __id = "buildAddUsingNotes.([I[I)[B";
			IntPtr native_sectionId = JNIEnv.NewArray (sectionId);
			IntPtr native_ownerId = JNIEnv.NewArray (ownerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sectionId);
				__args [1] = new JniArgumentValue (native_ownerId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildAddUsingNotes' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;kr.neolab.sdk.util.UseNoteData&gt;']]"
		[Register ("buildAddUsingNotes", "(Ljava/util/ArrayList;)[B", "")]
		public static unsafe byte[] BuildAddUsingNotes (global::System.Collections.Generic.IList<global::KR.Neolab.Sdk.Util.UseNoteData> noteList)
		{
			const string __id = "buildAddUsingNotes.(Ljava/util/ArrayList;)[B";
			IntPtr native_noteList = global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Util.UseNoteData>.ToLocalJniHandle (noteList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_noteList);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_noteList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildAutoShutdownTimeSetup' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("buildAutoShutdownTimeSetup", "(S)[B", "")]
		public static unsafe byte[] BuildAutoShutdownTimeSetup (short shutdownTime)
		{
			const string __id = "buildAutoShutdownTimeSetup.(S)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shutdownTime);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildOfflineChunkResponse' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("buildOfflineChunkResponse", "(III)[B", "")]
		public static unsafe byte[] BuildOfflineChunkResponse (int errorCode, int packetId, int position)
		{
			const string __id = "buildOfflineChunkResponse.(III)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (errorCode);
				__args [1] = new JniArgumentValue (packetId);
				__args [2] = new JniArgumentValue (position);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPasswordInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("buildPasswordInput", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] BuildPasswordInput (string password)
		{
			const string __id = "buildPasswordInput.(Ljava/lang/String;)[B";
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_password);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPasswordSetup' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("buildPasswordSetup", "(ZLjava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] BuildPasswordSetup (bool isUse, string oldPassword, string newPassword)
		{
			const string __id = "buildPasswordSetup.(ZLjava/lang/String;Ljava/lang/String;)[B";
			IntPtr native_oldPassword = JNIEnv.NewString (oldPassword);
			IntPtr native_newPassword = JNIEnv.NewString (newPassword);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (isUse);
				__args [1] = new JniArgumentValue (native_oldPassword);
				__args [2] = new JniArgumentValue (native_newPassword);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_oldPassword);
				JNIEnv.DeleteLocalRef (native_newPassword);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenAutoPowerSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildPenAutoPowerSetup", "(Z)[B", "")]
		public static unsafe byte[] BuildPenAutoPowerSetup (bool on)
		{
			const string __id = "buildPenAutoPowerSetup.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenBeepSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildPenBeepSetup", "(Z)[B", "")]
		public static unsafe byte[] BuildPenBeepSetup (bool on)
		{
			const string __id = "buildPenBeepSetup.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenCapOnOffSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildPenCapOnOffSetup", "(Z)[B", "")]
		public static unsafe byte[] BuildPenCapOnOffSetup (bool on)
		{
			const string __id = "buildPenCapOnOffSetup.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenHoverSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildPenHoverSetup", "(Z)[B", "")]
		public static unsafe byte[] BuildPenHoverSetup (bool on)
		{
			const string __id = "buildPenHoverSetup.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenOfflineDataSaveSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildPenOfflineDataSaveSetup", "(Z)[B", "")]
		public static unsafe byte[] BuildPenOfflineDataSaveSetup (bool on)
		{
			const string __id = "buildPenOfflineDataSaveSetup.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (on);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenSensitivitySetup' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("buildPenSensitivitySetup", "(S)[B", "")]
		public static unsafe byte[] BuildPenSensitivitySetup (short sensitivity)
		{
			const string __id = "buildPenSensitivitySetup.(S)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sensitivity);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenStatusData' and count(parameter)=0]"
		[Register ("buildPenStatusData", "()[B", "")]
		public static unsafe byte[] BuildPenStatusData ()
		{
			const string __id = "buildPenStatusData.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenSwUpgrade' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte']]"
		[Register ("buildPenSwUpgrade", "(Ljava/lang/String;Ljava/lang/String;IB)[B", "")]
		public static unsafe byte[] BuildPenSwUpgrade (string fwVersion, string deviceName, int filesize, sbyte checkSum)
		{
			const string __id = "buildPenSwUpgrade.(Ljava/lang/String;Ljava/lang/String;IB)[B";
			IntPtr native_fwVersion = JNIEnv.NewString (fwVersion);
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_fwVersion);
				__args [1] = new JniArgumentValue (native_deviceName);
				__args [2] = new JniArgumentValue (filesize);
				__args [3] = new JniArgumentValue (checkSum);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_fwVersion);
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenSwUploadChunk' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("buildPenSwUploadChunk", "(I[BIZ)[B", "")]
		public static unsafe byte[] BuildPenSwUploadChunk (int offset, byte[] data, int status, bool isCompress)
		{
			const string __id = "buildPenSwUploadChunk.(I[BIZ)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue (status);
				__args [3] = new JniArgumentValue (isCompress);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildPenTipColorSetup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("buildPenTipColorSetup", "(I)[B", "")]
		public static unsafe byte[] BuildPenTipColorSetup (int color)
		{
			const string __id = "buildPenTipColorSetup.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildReqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("buildReqOfflineData", "(III)[B", "")]
		public static unsafe byte[] BuildReqOfflineData (int sectionId, int ownerId, int noteId)
		{
			const string __id = "buildReqOfflineData.(III)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildReqOfflineData' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]']]"
		[Register ("buildReqOfflineData", "(III[I)[B", "")]
		public static unsafe byte[] BuildReqOfflineData (int sectionId, int ownerId, int noteId, int[] pageIds)
		{
			const string __id = "buildReqOfflineData.(III[I)[B";
			IntPtr native_pageIds = JNIEnv.NewArray (pageIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				__args [3] = new JniArgumentValue (native_pageIds);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (pageIds != null) {
					JNIEnv.CopyArray (native_pageIds, pageIds);
					JNIEnv.DeleteLocalRef (native_pageIds);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildReqOfflineDataList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("buildReqOfflineDataList", "(II)[B", "")]
		public static unsafe byte[] BuildReqOfflineDataList (int sectionId, int ownerId)
		{
			const string __id = "buildReqOfflineDataList.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildReqOfflineDataListAll' and count(parameter)=0]"
		[Register ("buildReqOfflineDataListAll", "()[B", "")]
		public static unsafe byte[] BuildReqOfflineDataListAll ()
		{
			const string __id = "buildReqOfflineDataListAll.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildReqOfflineDataPageList' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("buildReqOfflineDataPageList", "(III)[B", "")]
		public static unsafe byte[] BuildReqOfflineDataPageList (int sectionId, int ownerId, int noteId)
		{
			const string __id = "buildReqOfflineDataPageList.(III)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildReqOfflineDataRemove' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("buildReqOfflineDataRemove", "(II[I)[B", "")]
		public static unsafe byte[] BuildReqOfflineDataRemove (int sectionId, int ownerId, int[] noteIds)
		{
			const string __id = "buildReqOfflineDataRemove.(II[I)[B";
			IntPtr native_noteIds = JNIEnv.NewArray (noteIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (native_noteIds);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (noteIds != null) {
					JNIEnv.CopyArray (native_noteIds, noteIds);
					JNIEnv.DeleteLocalRef (native_noteIds);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildReqPenInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("buildReqPenInfo", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] BuildReqPenInfo (string appVer, string masterKey)
		{
			const string __id = "buildReqPenInfo.(Ljava/lang/String;Ljava/lang/String;)[B";
			IntPtr native_appVer = JNIEnv.NewString (appVer);
			IntPtr native_masterKey = JNIEnv.NewString (masterKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_appVer);
				__args [1] = new JniArgumentValue (native_masterKey);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_appVer);
				JNIEnv.DeleteLocalRef (native_masterKey);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='buildSetCurrentTimeData' and count(parameter)=0]"
		[Register ("buildSetCurrentTimeData", "()[B", "")]
		public static unsafe byte[] BuildSetCurrentTimeData ()
		{
			const string __id = "buildSetCurrentTimeData.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_parseByteData_arrayBI;
#pragma warning disable 0169
		static Delegate GetParseByteData_arrayBIHandler ()
		{
			if (cb_parseByteData_arrayBI == null)
				cb_parseByteData_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ParseByteData_arrayBI);
			return cb_parseByteData_arrayBI;
		}

		static void n_ParseByteData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int size)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20 __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ParseByteData (data, size);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser20']/method[@name='parseByteData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parseByteData", "([BI)V", "GetParseByteData_arrayBIHandler")]
		public virtual unsafe void ParseByteData (byte[] data, int size)
		{
			const string __id = "parseByteData.([BI)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
