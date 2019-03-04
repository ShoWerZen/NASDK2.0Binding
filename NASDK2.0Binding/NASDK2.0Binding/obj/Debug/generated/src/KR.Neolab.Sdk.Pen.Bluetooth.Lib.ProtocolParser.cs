using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser", DoNotGenerateAcw=true)]
	public partial class ProtocolParser : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/field[@name='USING_NOTE_TYPE_ALL']"
		[Register ("USING_NOTE_TYPE_ALL")]
		public const int UsingNoteTypeAll = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/field[@name='USING_NOTE_TYPE_NOTE']"
		[Register ("USING_NOTE_TYPE_NOTE")]
		public const int UsingNoteTypeNote = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/field[@name='USING_NOTE_TYPE_SECTION_OWNER']"
		[Register ("USING_NOTE_TYPE_SECTION_OWNER")]
		public const int UsingNoteTypeSectionOwner = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/interface[@name='ProtocolParser.IParsedPacketListener']"
		[Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser$IParsedPacketListener", "", "KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser/IParsedPacketListenerInvoker")]
		public partial interface IParsedPacketListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/interface[@name='ProtocolParser.IParsedPacketListener']/method[@name='onCreatePacket' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.Packet']]"
			[Register ("onCreatePacket", "(Lkr/neolab/sdk/pen/bluetooth/lib/Packet;)V", "GetOnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_Handler:KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser/IParsedPacketListenerInvoker, NASDK2.0Binding")]
			void OnCreatePacket (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet p0);

		}

		[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser$IParsedPacketListener", DoNotGenerateAcw=true)]
		internal class IParsedPacketListenerInvoker : global::Java.Lang.Object, IParsedPacketListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser$IParsedPacketListener", typeof (IParsedPacketListenerInvoker));

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
								JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.bluetooth.lib.ProtocolParser.IParsedPacketListener"));
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.IParsedPacketListener __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.IParsedPacketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// event args for kr.neolab.sdk.pen.bluetooth.lib.ProtocolParser.IParsedPacketListener.onCreatePacket
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

		[global::Android.Runtime.Register ("mono/kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser_IParsedPacketListenerImplementor")]
		internal sealed partial class IParsedPacketListenerImplementor : global::Java.Lang.Object, IParsedPacketListener {

			object sender;

			public IParsedPacketListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser_IParsedPacketListenerImplementor", "()V"),
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


		// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']"
		[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser$PacketBuilder", DoNotGenerateAcw=true)]
		public partial class PacketBuilder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser$PacketBuilder", typeof (PacketBuilder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/constructor[@name='ProtocolParser.PacketBuilder' and count(parameter)=1 and parameter[1][@type='int']]"
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.NewArray (__this.ResizeByteArray (bytes, newsize));
				if (bytes != null)
					JNIEnv.CopyArray (bytes, native_bytes);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='ResizeByteArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Allocate (length);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='allocate' and count(parameter)=1 and parameter[1][@type='int']]"
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetPacket ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='getPacket' and count(parameter)=0]"
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetCommand (cmd);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='setCommand' and count(parameter)=1 and parameter[1][@type='int']]"
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
					cb_showPacket = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowPacket);
				return cb_showPacket;
			}

			static void n_ShowPacket (IntPtr jnienv, IntPtr native__this)
			{
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShowPacket ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='showPacket' and count(parameter)=0]"
			[Register ("showPacket", "()V", "GetShowPacketHandler")]
			public virtual unsafe void ShowPacket ()
			{
				const string __id = "showPacket.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='showPacket' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("showPacket", "([B)V", "")]
			public static unsafe void ShowPacket (byte[] bytes)
			{
				const string __id = "showPacket.([B)V";
				IntPtr native_bytes = JNIEnv.NewArray (bytes);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_bytes);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Write (data);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte']]"
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Write (buffer);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
				global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.PacketBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Write (buffer, valid_size);
				if (buffer != null)
					JNIEnv.CopyArray (buffer, native_buffer);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser.PacketBuilder']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/ProtocolParser", typeof (ProtocolParser));
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

		protected ProtocolParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/constructor[@name='ProtocolParser' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.ProtocolParser.IParsedPacketListener']]"
		[Register (".ctor", "(Lkr/neolab/sdk/pen/bluetooth/lib/ProtocolParser$IParsedPacketListener;)V", "")]
		public unsafe ProtocolParser (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.IParsedPacketListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkr/neolab/sdk/pen/bluetooth/lib/ProtocolParser$IParsedPacketListener;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildAddUsingAllNotes' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildAddUsingNotes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildAddUsingNotes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("buildAddUsingNotes", "(II[I)[B", "")]
		public static unsafe byte[] BuildAddUsingNotes (int sectionId, int ownerId, int[] noteIds)
		{
			const string __id = "buildAddUsingNotes.(II[I)[B";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildAutoShutdownTimeSetup' and count(parameter)=1 and parameter[1][@type='short']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildForceCalibrateData' and count(parameter)=0]"
		[Register ("buildForceCalibrateData", "()[B", "")]
		public static unsafe byte[] BuildForceCalibrateData ()
		{
			const string __id = "buildForceCalibrateData.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildOfflineChunkResponse' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("buildOfflineChunkResponse", "(I)[B", "")]
		public static unsafe byte[] BuildOfflineChunkResponse (int index)
		{
			const string __id = "buildOfflineChunkResponse.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildOfflineInfoResponse' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildOfflineInfoResponse", "(Z)[B", "")]
		public static unsafe byte[] BuildOfflineInfoResponse (bool result)
		{
			const string __id = "buildOfflineInfoResponse.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (result);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPasswordInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPasswordSetup' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("buildPasswordSetup", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] BuildPasswordSetup (string oldPassword, string newPassword)
		{
			const string __id = "buildPasswordSetup.(Ljava/lang/String;Ljava/lang/String;)[B";
			IntPtr native_oldPassword = JNIEnv.NewString (oldPassword);
			IntPtr native_newPassword = JNIEnv.NewString (newPassword);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_oldPassword);
				__args [1] = new JniArgumentValue (native_newPassword);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_oldPassword);
				JNIEnv.DeleteLocalRef (native_newPassword);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenAutoPowerSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenBeepSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenEchoResponse' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("buildPenEchoResponse", "(B)[B", "")]
		public static unsafe byte[] BuildPenEchoResponse (sbyte echar)
		{
			const string __id = "buildPenEchoResponse.(B)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (echar);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenOnOffData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("buildPenOnOffData", "(Z)[B", "")]
		public static unsafe byte[] BuildPenOnOffData (bool status)
		{
			const string __id = "buildPenOnOffData.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (status);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenSensitivitySetup' and count(parameter)=1 and parameter[1][@type='short']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenStatusData' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenSwUpgrade' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='short'] and parameter[4][@type='short']]"
		[Register ("buildPenSwUpgrade", "(Ljava/lang/String;ISS)[B", "")]
		public static unsafe byte[] BuildPenSwUpgrade (string filename, int filesize, short chunk_count, short chunk_size)
		{
			const string __id = "buildPenSwUpgrade.(Ljava/lang/String;ISS)[B";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_filename);
				__args [1] = new JniArgumentValue (filesize);
				__args [2] = new JniArgumentValue (chunk_count);
				__args [3] = new JniArgumentValue (chunk_size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenSwUpgradeResponse' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]']]"
		[Register ("buildPenSwUpgradeResponse", "(IB[B)[B", "")]
		public static unsafe byte[] BuildPenSwUpgradeResponse (int index, sbyte checksum, byte[] data)
		{
			const string __id = "buildPenSwUpgradeResponse.(IB[B)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (checksum);
				__args [2] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenTipColorSetup' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildPenUpRespnse' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("buildPenUpRespnse", "(J)[B", "")]
		public static unsafe byte[] BuildPenUpRespnse (long ts)
		{
			const string __id = "buildPenUpRespnse.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ts);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildReqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildReqOfflineDataList' and count(parameter)=0]"
		[Register ("buildReqOfflineDataList", "()[B", "")]
		public static unsafe byte[] BuildReqOfflineDataList ()
		{
			const string __id = "buildReqOfflineDataList.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildReqOfflineDataRemove' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("buildReqOfflineDataRemove", "(II)[B", "")]
		public static unsafe byte[] BuildReqOfflineDataRemove (int sectionId, int ownerId)
		{
			const string __id = "buildReqOfflineDataRemove.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildSetCurrentTimeData' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='buildShowTextData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("buildShowTextData", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] BuildShowTextData (string showText)
		{
			const string __id = "buildShowTextData.(Ljava/lang/String;)[B";
			IntPtr native_showText = JNIEnv.NewString (showText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_showText);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_showText);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='getLocalTimeOffset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getLocalTimeOffset", "(J)I", "")]
		public static unsafe int GetLocalTimeOffset (long timetick)
		{
			const string __id = "getLocalTimeOffset.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timetick);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ParseByteData (data, size);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ProtocolParser']/method[@name='parseByteData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
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
