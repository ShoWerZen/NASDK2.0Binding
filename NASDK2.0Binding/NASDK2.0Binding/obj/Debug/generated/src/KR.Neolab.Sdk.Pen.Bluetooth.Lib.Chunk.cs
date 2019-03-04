using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/Chunk", DoNotGenerateAcw=true)]
	public partial class Chunk : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/field[@name='size']"
		[Register ("size")]
		public int Size {
			get {
				const string __id = "size.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "size.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/Chunk", typeof (Chunk));
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

		protected Chunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/constructor[@name='Chunk' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/io/InputStream;J)V", "")]
		public unsafe Chunk (global::System.IO.Stream @is, long filesize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__is);
				__args [1] = new JniArgumentValue (filesize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/constructor[@name='Chunk' and count(parameter)=3 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/io/InputStream;JI)V", "")]
		public unsafe Chunk (global::System.IO.Stream @is, long filesize, int packetSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;JI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native__is);
				__args [1] = new JniArgumentValue (filesize);
				__args [2] = new JniArgumentValue (packetSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static Delegate cb_getChecksum;
#pragma warning disable 0169
		static Delegate GetGetChecksumHandler ()
		{
			if (cb_getChecksum == null)
				cb_getChecksum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetChecksum);
			return cb_getChecksum;
		}

		static sbyte n_GetChecksum (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Checksum;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte Checksum {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='getChecksum' and count(parameter)=0]"
			[Register ("getChecksum", "()B", "GetGetChecksumHandler")]
			get {
				const string __id = "getChecksum.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getChunkLength;
#pragma warning disable 0169
		static Delegate GetGetChunkLengthHandler ()
		{
			if (cb_getChunkLength == null)
				cb_getChunkLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChunkLength);
			return cb_getChunkLength;
		}

		static int n_GetChunkLength (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChunkLength;
		}
#pragma warning restore 0169

		public virtual unsafe int ChunkLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='getChunkLength' and count(parameter)=0]"
			[Register ("getChunkLength", "()I", "GetGetChunkLengthHandler")]
			get {
				const string __id = "getChunkLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getChunksize;
#pragma warning disable 0169
		static Delegate GetGetChunksizeHandler ()
		{
			if (cb_getChunksize == null)
				cb_getChunksize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChunksize);
			return cb_getChunksize;
		}

		static int n_GetChunksize (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Chunksize;
		}
#pragma warning restore 0169

		public virtual unsafe int Chunksize {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='getChunksize' and count(parameter)=0]"
			[Register ("getChunksize", "()I", "GetGetChunksizeHandler")]
			get {
				const string __id = "getChunksize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				const string __id = "getStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStatusPercent;
#pragma warning disable 0169
		static Delegate GetGetStatusPercentHandler ()
		{
			if (cb_getStatusPercent == null)
				cb_getStatusPercent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusPercent);
			return cb_getStatusPercent;
		}

		static int n_GetStatusPercent (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusPercent;
		}
#pragma warning restore 0169

		public virtual unsafe int StatusPercent {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='getStatusPercent' and count(parameter)=0]"
			[Register ("getStatusPercent", "()I", "GetGetStatusPercentHandler")]
			get {
				const string __id = "getStatusPercent.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='calcChecksum' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("calcChecksum", "([B)B", "")]
		public static unsafe sbyte CalcChecksum (byte[] bytes)
		{
			const string __id = "calcChecksum.([B)B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_calcChecksum_arrayarrayB;
#pragma warning disable 0169
		static Delegate GetCalcChecksum_arrayarrayBHandler ()
		{
			if (cb_calcChecksum_arrayarrayB == null)
				cb_calcChecksum_arrayarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, sbyte>) n_CalcChecksum_arrayarrayB);
			return cb_calcChecksum_arrayarrayB;
		}

		static sbyte n_CalcChecksum_arrayarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[][] bytes = (byte[][]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte[]));
			sbyte __ret = __this.CalcChecksum (bytes);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='calcChecksum' and count(parameter)=1 and parameter[1][@type='byte[][]']]"
		[Register ("calcChecksum", "([[B)B", "GetCalcChecksum_arrayarrayBHandler")]
		public virtual unsafe sbyte CalcChecksum (byte[][] bytes)
		{
			const string __id = "calcChecksum.([[B)B";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_getChecksum_I;
#pragma warning disable 0169
		static Delegate GetGetChecksum_IHandler ()
		{
			if (cb_getChecksum_I == null)
				cb_getChecksum_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte>) n_GetChecksum_I);
			return cb_getChecksum_I;
		}

		static sbyte n_GetChecksum_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetChecksum (number);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='getChecksum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getChecksum", "(I)B", "GetGetChecksum_IHandler")]
		public virtual unsafe sbyte GetChecksum (int number)
		{
			const string __id = "getChecksum.(I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getChunk_I;
#pragma warning disable 0169
		static Delegate GetGetChunk_IHandler ()
		{
			if (cb_getChunk_I == null)
				cb_getChunk_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetChunk_I);
			return cb_getChunk_I;
		}

		static IntPtr n_GetChunk_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetChunk (number));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='getChunk' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getChunk", "(I)[B", "GetGetChunk_IHandler")]
		public virtual unsafe byte[] GetChunk (int number)
		{
			const string __id = "getChunk.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public virtual unsafe void Load ()
		{
			const string __id = "load.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_offsetToIndex_I;
#pragma warning disable 0169
		static Delegate GetOffsetToIndex_IHandler ()
		{
			if (cb_offsetToIndex_I == null)
				cb_offsetToIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_OffsetToIndex_I);
			return cb_offsetToIndex_I;
		}

		static int n_OffsetToIndex_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetToIndex (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='offsetToIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("offsetToIndex", "(I)I", "GetOffsetToIndex_IHandler")]
		public virtual unsafe int OffsetToIndex (int offset)
		{
			const string __id = "offsetToIndex.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setStatus_IZ;
#pragma warning disable 0169
		static Delegate GetSetStatus_IZHandler ()
		{
			if (cb_setStatus_IZ == null)
				cb_setStatus_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetStatus_IZ);
			return cb_setStatus_IZ;
		}

		static void n_SetStatus_IZ (IntPtr jnienv, IntPtr native__this, int index, bool status)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (index, status);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='Chunk']/method[@name='setStatus' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setStatus", "(IZ)V", "GetSetStatus_IZHandler")]
		public virtual unsafe void SetStatus (int index, bool status)
		{
			const string __id = "setStatus.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (status);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
