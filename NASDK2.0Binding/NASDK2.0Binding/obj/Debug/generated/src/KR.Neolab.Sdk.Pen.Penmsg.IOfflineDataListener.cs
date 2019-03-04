using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Penmsg {

	// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/interface[@name='IOfflineDataListener']"
	[Register ("kr/neolab/sdk/pen/penmsg/IOfflineDataListener", "", "KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListenerInvoker")]
	public partial interface IOfflineDataListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/interface[@name='IOfflineDataListener']/method[@name='onReceiveOfflineStrokes' and count(parameter)=4 and parameter[1][@type='kr.neolab.sdk.ink.structure.Stroke[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onReceiveOfflineStrokes", "([Lkr/neolab/sdk/ink/structure/Stroke;III)V", "GetOnReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_IIIHandler:KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListenerInvoker, NASDK2.0Binding")]
		void OnReceiveOfflineStrokes (global::KR.Neolab.Sdk.Ink.Structure.Stroke[] p0, int p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/penmsg/IOfflineDataListener", DoNotGenerateAcw=true)]
	internal class IOfflineDataListenerInvoker : global::Java.Lang.Object, IOfflineDataListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/penmsg/IOfflineDataListener", typeof (IOfflineDataListenerInvoker));

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

		public static IOfflineDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOfflineDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.penmsg.IOfflineDataListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOfflineDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III;
#pragma warning disable 0169
		static Delegate GetOnReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_IIIHandler ()
		{
			if (cb_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III == null)
				cb_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III);
			return cb_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III;
		}

		static void n_OnReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Ink.Structure.Stroke[] p0 = (global::KR.Neolab.Sdk.Ink.Structure.Stroke[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::KR.Neolab.Sdk.Ink.Structure.Stroke));
			__this.OnReceiveOfflineStrokes (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III;
		public unsafe void OnReceiveOfflineStrokes (global::KR.Neolab.Sdk.Ink.Structure.Stroke[] p0, int p1, int p2, int p3)
		{
			if (id_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III == IntPtr.Zero)
				id_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III = JNIEnv.GetMethodID (class_ref, "onReceiveOfflineStrokes", "([Lkr/neolab/sdk/ink/structure/Stroke;III)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveOfflineStrokes_arrayLkr_neolab_sdk_ink_structure_Stroke_III, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	// event args for kr.neolab.sdk.pen.penmsg.IOfflineDataListener.onReceiveOfflineStrokes
	public partial class OfflineDataEventArgs : global::System.EventArgs {

		public OfflineDataEventArgs (global::KR.Neolab.Sdk.Ink.Structure.Stroke[] p0, int p1, int p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::KR.Neolab.Sdk.Ink.Structure.Stroke[] p0;
		public global::KR.Neolab.Sdk.Ink.Structure.Stroke[] P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/kr/neolab/sdk/pen/penmsg/IOfflineDataListenerImplementor")]
	internal sealed partial class IOfflineDataListenerImplementor : global::Java.Lang.Object, IOfflineDataListener {

		object sender;

		public IOfflineDataListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/kr/neolab/sdk/pen/penmsg/IOfflineDataListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<OfflineDataEventArgs> Handler;
#pragma warning restore 0649

		public void OnReceiveOfflineStrokes (global::KR.Neolab.Sdk.Ink.Structure.Stroke[] p0, int p1, int p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new OfflineDataEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IOfflineDataListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
