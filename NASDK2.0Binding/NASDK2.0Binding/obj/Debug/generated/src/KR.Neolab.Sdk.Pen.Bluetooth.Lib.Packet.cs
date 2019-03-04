using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/Packet", DoNotGenerateAcw=true)]
	public partial class Packet : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/field[@name='checkSum']"
		[Register ("checkSum")]
		public int CheckSum {
			get {
				const string __id = "checkSum.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "checkSum.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				const string __id = "data.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "data.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/field[@name='isEvent']"
		[Register ("isEvent")]
		public bool IsEvent {
			get {
				const string __id = "isEvent.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isEvent.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/Packet", typeof (Packet));
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

		protected Packet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Packet ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe Packet (byte[] buffer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_buffer);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe Packet (byte[] buffer, int protocolVer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (protocolVer);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "([BIZ)V", "")]
		public unsafe Packet (byte[] buffer, int protocolVer, bool isEvent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (protocolVer);
				__args [2] = new JniArgumentValue (isEvent);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

		static Delegate cb_getCmd;
#pragma warning disable 0169
		static Delegate GetGetCmdHandler ()
		{
			if (cb_getCmd == null)
				cb_getCmd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCmd);
			return cb_getCmd;
		}

		static int n_GetCmd (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cmd;
		}
#pragma warning restore 0169

		public virtual unsafe int Cmd {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getCmd' and count(parameter)=0]"
			[Register ("getCmd", "()I", "GetGetCmdHandler")]
			get {
				const string __id = "getCmd.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDataLength;
#pragma warning disable 0169
		static Delegate GetGetDataLengthHandler ()
		{
			if (cb_getDataLength == null)
				cb_getDataLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataLength);
			return cb_getDataLength;
		}

		static int n_GetDataLength (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataLength;
		}
#pragma warning restore 0169

		public virtual unsafe int DataLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getDataLength' and count(parameter)=0]"
			[Register ("getDataLength", "()I", "GetGetDataLengthHandler")]
			get {
				const string __id = "getDataLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetResultCode);
			return cb_getResultCode;
		}

		static sbyte n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultCode;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()B", "GetGetResultCodeHandler")]
			get {
				const string __id = "getResultCode.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='copyOfRange' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("copyOfRange", "([BII)[B", "")]
		public static unsafe byte[] CopyOfRange (byte[] buffer, int start, int size)
		{
			const string __id = "copyOfRange.([BII)[B";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual unsafe byte[] GetData ()
		{
			const string __id = "getData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDataRange_II;
#pragma warning disable 0169
		static Delegate GetGetDataRange_IIHandler ()
		{
			if (cb_getDataRange_II == null)
				cb_getDataRange_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetDataRange_II);
			return cb_getDataRange_II;
		}

		static IntPtr n_GetDataRange_II (IntPtr jnienv, IntPtr native__this, int start, int size)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDataRange (start, size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getDataRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDataRange", "(II)[B", "GetGetDataRange_IIHandler")]
		public virtual unsafe byte[] GetDataRange (int start, int size)
		{
			const string __id = "getDataRange.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDataRangeInt_II;
#pragma warning disable 0169
		static Delegate GetGetDataRangeInt_IIHandler ()
		{
			if (cb_getDataRangeInt_II == null)
				cb_getDataRangeInt_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetDataRangeInt_II);
			return cb_getDataRangeInt_II;
		}

		static int n_GetDataRangeInt_II (IntPtr jnienv, IntPtr native__this, int start, int size)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDataRangeInt (start, size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getDataRangeInt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDataRangeInt", "(II)I", "GetGetDataRangeInt_IIHandler")]
		public virtual unsafe int GetDataRangeInt (int start, int size)
		{
			const string __id = "getDataRangeInt.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDataRangeLong_II;
#pragma warning disable 0169
		static Delegate GetGetDataRangeLong_IIHandler ()
		{
			if (cb_getDataRangeLong_II == null)
				cb_getDataRangeLong_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, long>) n_GetDataRangeLong_II);
			return cb_getDataRangeLong_II;
		}

		static long n_GetDataRangeLong_II (IntPtr jnienv, IntPtr native__this, int start, int size)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDataRangeLong (start, size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getDataRangeLong' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDataRangeLong", "(II)J", "GetGetDataRangeLong_IIHandler")]
		public virtual unsafe long GetDataRangeLong (int start, int size)
		{
			const string __id = "getDataRangeLong.(II)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDataRangeShort_II;
#pragma warning disable 0169
		static Delegate GetGetDataRangeShort_IIHandler ()
		{
			if (cb_getDataRangeShort_II == null)
				cb_getDataRangeShort_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, short>) n_GetDataRangeShort_II);
			return cb_getDataRangeShort_II;
		}

		static short n_GetDataRangeShort_II (IntPtr jnienv, IntPtr native__this, int start, int size)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDataRangeShort (start, size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getDataRangeShort' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDataRangeShort", "(II)S", "GetGetDataRangeShort_IIHandler")]
		public virtual unsafe short GetDataRangeShort (int start, int size)
		{
			const string __id = "getDataRangeShort.(II)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDataRangeString_II;
#pragma warning disable 0169
		static Delegate GetGetDataRangeString_IIHandler ()
		{
			if (cb_getDataRangeString_II == null)
				cb_getDataRangeString_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_GetDataRangeString_II);
			return cb_getDataRangeString_II;
		}

		static IntPtr n_GetDataRangeString_II (IntPtr jnienv, IntPtr native__this, int start, int size)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetDataRangeString (start, size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Packet']/method[@name='getDataRangeString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getDataRangeString", "(II)Ljava/lang/String;", "GetGetDataRangeString_IIHandler")]
		public virtual unsafe string GetDataRangeString (int start, int size)
		{
			const string __id = "getDataRangeString.(II)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
