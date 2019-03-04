using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Filter {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/filter/Fdot", DoNotGenerateAcw=true)]
	public partial class Fdot : global::KR.Neolab.Sdk.Ink.Structure.Dot, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/field[@name='DOT_DATA_BYTE_ALIGN']"
		[Register ("DOT_DATA_BYTE_ALIGN")]
		public int DotDataByteAlign {
			get {
				const string __id = "DOT_DATA_BYTE_ALIGN.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "DOT_DATA_BYTE_ALIGN.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/field[@name='DOT_DATA_COMPACT_BYTE_ALIGN']"
		[Register ("DOT_DATA_COMPACT_BYTE_ALIGN")]
		public int DotDataCompactByteAlign {
			get {
				const string __id = "DOT_DATA_COMPACT_BYTE_ALIGN.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "DOT_DATA_COMPACT_BYTE_ALIGN.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/field[@name='mac_address']"
		[Register ("mac_address")]
		public string MacAddress {
			get {
				const string __id = "mac_address.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mac_address.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/filter/Fdot", typeof (Fdot));
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

		protected Fdot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/constructor[@name='Fdot' and count(parameter)=14 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='int'] and parameter[14][@type='int']]"
		[Register (".ctor", "(FFIIJIIIIIIIII)V", "")]
		public unsafe Fdot (float x, float y, int pressure, int dotType, long timestamp, int sectionId, int ownerId, int noteId, int pageId, int color, int penTipType, int tiltX, int tiltY, int twist)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFIIJIIIIIIIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [14];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (pressure);
				__args [3] = new JniArgumentValue (dotType);
				__args [4] = new JniArgumentValue (timestamp);
				__args [5] = new JniArgumentValue (sectionId);
				__args [6] = new JniArgumentValue (ownerId);
				__args [7] = new JniArgumentValue (noteId);
				__args [8] = new JniArgumentValue (pageId);
				__args [9] = new JniArgumentValue (color);
				__args [10] = new JniArgumentValue (penTipType);
				__args [11] = new JniArgumentValue (tiltX);
				__args [12] = new JniArgumentValue (tiltY);
				__args [13] = new JniArgumentValue (twist);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ToString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_ToString == null)
				cb_ToString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_ToString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Filter.Fdot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/method[@name='ToString' and count(parameter)=0]"
		[Register ("ToString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			const string __id = "ToString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Filter.Fdot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			const string __id = "toByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_toCompactByteArray;
#pragma warning disable 0169
		static Delegate GetToCompactByteArrayHandler ()
		{
			if (cb_toCompactByteArray == null)
				cb_toCompactByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToCompactByteArray);
			return cb_toCompactByteArray;
		}

		static IntPtr n_ToCompactByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Filter.Fdot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToCompactByteArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/method[@name='toCompactByteArray' and count(parameter)=0]"
		[Register ("toCompactByteArray", "()[B", "GetToCompactByteArrayHandler")]
		public virtual unsafe byte[] ToCompactByteArray ()
		{
			const string __id = "toCompactByteArray.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_toDot;
#pragma warning disable 0169
		static Delegate GetToDotHandler ()
		{
			if (cb_toDot == null)
				cb_toDot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToDot);
			return cb_toDot;
		}

		static IntPtr n_ToDot (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Filter.Fdot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToDot ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='Fdot']/method[@name='toDot' and count(parameter)=0]"
		[Register ("toDot", "()Lkr/neolab/sdk/ink/structure/Dot;", "GetToDotHandler")]
		public virtual unsafe global::KR.Neolab.Sdk.Ink.Structure.Dot ToDot ()
		{
			const string __id = "toDot.()Lkr/neolab/sdk/ink/structure/Dot;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
