using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/ByteConverter", DoNotGenerateAcw=true)]
	public partial class ByteConverter : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/ByteConverter", typeof (ByteConverter));
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

		protected ByteConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/constructor[@name='ByteConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteConverter ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='byteArrayToHexString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("byteArrayToHexString", "([BI)Ljava/lang/String;", "")]
		public static unsafe string ByteArrayToHexString (byte[] array, int size)
		{
			const string __id = "byteArrayToHexString.([BI)Ljava/lang/String;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='byteArrayToInt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteArrayToInt", "([B)I", "")]
		public static unsafe int ByteArrayToInt (byte[] bytes)
		{
			const string __id = "byteArrayToInt.([B)I";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='byteArrayToLong' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteArrayToLong", "([B)J", "")]
		public static unsafe long ByteArrayToLong (byte[] bytes)
		{
			const string __id = "byteArrayToLong.([B)J";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='byteArrayToShort' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteArrayToShort", "([B)S", "")]
		public static unsafe short ByteArrayToShort (byte[] bytes)
		{
			const string __id = "byteArrayToShort.([B)S";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='charArrayTobyte' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register ("charArrayTobyte", "([C)[B", "")]
		public static unsafe byte[] CharArrayTobyte (char[] values)
		{
			const string __id = "charArrayTobyte.([C)[B";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='intTobyte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("intTobyte", "(I)[B", "")]
		public static unsafe byte[] IntTobyte (int value)
		{
			const string __id = "intTobyte.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='longTobyte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("longTobyte", "(J)[B", "")]
		public static unsafe byte[] LongTobyte (long value)
		{
			const string __id = "longTobyte.(J)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='shortTobyte' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("shortTobyte", "(S)[B", "")]
		public static unsafe byte[] ShortTobyte (short value)
		{
			const string __id = "shortTobyte.(S)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='ByteConverter']/method[@name='stringTobyte' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringTobyte", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] StringTobyte (string value)
		{
			const string __id = "stringTobyte.(Ljava/lang/String;)[B";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
