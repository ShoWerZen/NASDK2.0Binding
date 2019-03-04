using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Ink.Structure {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/ink/structure/Dot", DoNotGenerateAcw=true)]
	public partial class Dot : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='color']"
		[Register ("color")]
		public int Color {
			get {
				const string __id = "color.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "color.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='noteId']"
		[Register ("noteId")]
		public int NoteId {
			get {
				const string __id = "noteId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "noteId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='ownerId']"
		[Register ("ownerId")]
		public int OwnerId {
			get {
				const string __id = "ownerId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ownerId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='pageId']"
		[Register ("pageId")]
		public int PageId {
			get {
				const string __id = "pageId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pageId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='penTipType']"
		[Register ("penTipType")]
		public int PenTipType {
			get {
				const string __id = "penTipType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "penTipType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='sectionId']"
		[Register ("sectionId")]
		public int SectionId {
			get {
				const string __id = "sectionId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sectionId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='tiltX']"
		[Register ("tiltX")]
		public int TiltX {
			get {
				const string __id = "tiltX.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "tiltX.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='tiltY']"
		[Register ("tiltY")]
		public int TiltY {
			get {
				const string __id = "tiltY.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "tiltY.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='twist']"
		[Register ("twist")]
		public int Twist {
			get {
				const string __id = "twist.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "twist.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='x']"
		[Register ("x")]
		public float X {
			get {
				const string __id = "x.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "x.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/field[@name='y']"
		[Register ("y")]
		public float Y {
			get {
				const string __id = "y.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "y.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/ink/structure/Dot", typeof (Dot));
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

		protected Dot (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/constructor[@name='Dot' and count(parameter)=14 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='int'] and parameter[14][@type='int']]"
		[Register (".ctor", "(FFIIJIIIIIIIII)V", "")]
		public unsafe Dot (float x, float y, int pressure, int dotType, long timestamp, int sectionId, int ownerId, int noteId, int pageId, int color, int penTipType, int tiltX, int tiltY, int twist)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/constructor[@name='Dot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.ink.structure.Dot']]"
		[Register (".ctor", "(Lkr/neolab/sdk/ink/structure/Dot;)V", "")]
		public unsafe Dot (global::KR.Neolab.Sdk.Ink.Structure.Dot dot)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkr/neolab/sdk/ink/structure/Dot;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dot).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDotType;
#pragma warning disable 0169
		static Delegate GetGetDotTypeHandler ()
		{
			if (cb_getDotType == null)
				cb_getDotType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDotType);
			return cb_getDotType;
		}

		static int n_GetDotType (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DotType;
		}
#pragma warning restore 0169

		public virtual unsafe int DotType {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='getDotType' and count(parameter)=0]"
			[Register ("getDotType", "()I", "GetGetDotTypeHandler")]
			get {
				const string __id = "getDotType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPressure;
#pragma warning disable 0169
		static Delegate GetGetPressureHandler ()
		{
			if (cb_getPressure == null)
				cb_getPressure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPressure);
			return cb_getPressure;
		}

		static int n_GetPressure (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pressure;
		}
#pragma warning restore 0169

		public virtual unsafe int Pressure {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='getPressure' and count(parameter)=0]"
			[Register ("getPressure", "()I", "GetGetPressureHandler")]
			get {
				const string __id = "getPressure.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				const string __id = "getTimestamp.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler")]
		public virtual unsafe float GetX ()
		{
			const string __id = "getX.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler")]
		public virtual unsafe float GetY ()
		{
			const string __id = "getY.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='makeDownDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.ink.structure.Dot']]"
		[Register ("makeDownDot", "(Lkr/neolab/sdk/ink/structure/Dot;)Lkr/neolab/sdk/ink/structure/Dot;", "")]
		public static unsafe global::KR.Neolab.Sdk.Ink.Structure.Dot MakeDownDot (global::KR.Neolab.Sdk.Ink.Structure.Dot dot)
		{
			const string __id = "makeDownDot.(Lkr/neolab/sdk/ink/structure/Dot;)Lkr/neolab/sdk/ink/structure/Dot;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dot).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='makeUpDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.ink.structure.Dot']]"
		[Register ("makeUpDot", "(Lkr/neolab/sdk/ink/structure/Dot;)Lkr/neolab/sdk/ink/structure/Dot;", "")]
		public static unsafe global::KR.Neolab.Sdk.Ink.Structure.Dot MakeUpDot (global::KR.Neolab.Sdk.Ink.Structure.Dot dot)
		{
			const string __id = "makeUpDot.(Lkr/neolab/sdk/ink/structure/Dot;)Lkr/neolab/sdk/ink/structure/Dot;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dot).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toByteArray_I;
#pragma warning disable 0169
		static Delegate GetToByteArray_IHandler ()
		{
			if (cb_toByteArray_I == null)
				cb_toByteArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ToByteArray_I);
			return cb_toByteArray_I;
		}

		static IntPtr n_ToByteArray_I (IntPtr jnienv, IntPtr native__this, int DOT_DATA_BYTE_ALIGN)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray (DOT_DATA_BYTE_ALIGN));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toByteArray", "(I)[B", "GetToByteArray_IHandler")]
		public virtual unsafe byte[] ToByteArray (int DOT_DATA_BYTE_ALIGN)
		{
			const string __id = "toByteArray.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (DOT_DATA_BYTE_ALIGN);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_parcel, int native_i)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Dot __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel parcel = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_parcel, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags i = (global::Android.OS.ParcelableWriteFlags) native_i;
			__this.WriteToParcel (parcel, i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Dot']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel parcel, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags i)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				__args [1] = new JniArgumentValue ((int) i);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
