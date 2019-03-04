using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Penmsg {

	// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/interface[@name='IPenDotListener']"
	[Register ("kr/neolab/sdk/pen/penmsg/IPenDotListener", "", "KR.Neolab.Sdk.Pen.Penmsg.IPenDotListenerInvoker")]
	public partial interface IPenDotListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/interface[@name='IPenDotListener']/method[@name='onReceiveDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.ink.structure.Dot']]"
		[Register ("onReceiveDot", "(Lkr/neolab/sdk/ink/structure/Dot;)V", "GetOnReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_Handler:KR.Neolab.Sdk.Pen.Penmsg.IPenDotListenerInvoker, NASDK2.0Binding")]
		void OnReceiveDot (global::KR.Neolab.Sdk.Ink.Structure.Dot p0);

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/penmsg/IPenDotListener", DoNotGenerateAcw=true)]
	internal class IPenDotListenerInvoker : global::Java.Lang.Object, IPenDotListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/penmsg/IPenDotListener", typeof (IPenDotListenerInvoker));

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

		public static IPenDotListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPenDotListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.penmsg.IPenDotListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPenDotListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_;
#pragma warning disable 0169
		static Delegate GetOnReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_Handler ()
		{
			if (cb_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_ == null)
				cb_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_);
			return cb_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_;
		}

		static void n_OnReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Ink.Structure.Dot p0 = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveDot (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_;
		public unsafe void OnReceiveDot (global::KR.Neolab.Sdk.Ink.Structure.Dot p0)
		{
			if (id_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_ == IntPtr.Zero)
				id_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_ = JNIEnv.GetMethodID (class_ref, "onReceiveDot", "(Lkr/neolab/sdk/ink/structure/Dot;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveDot_Lkr_neolab_sdk_ink_structure_Dot_, __args);
		}

	}

	// event args for kr.neolab.sdk.pen.penmsg.IPenDotListener.onReceiveDot
	public partial class PenDotEventArgs : global::System.EventArgs {

		public PenDotEventArgs (global::KR.Neolab.Sdk.Ink.Structure.Dot p0)
		{
			this.p0 = p0;
		}

		global::KR.Neolab.Sdk.Ink.Structure.Dot p0;
		public global::KR.Neolab.Sdk.Ink.Structure.Dot P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/kr/neolab/sdk/pen/penmsg/IPenDotListenerImplementor")]
	internal sealed partial class IPenDotListenerImplementor : global::Java.Lang.Object, IPenDotListener {

		object sender;

		public IPenDotListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/kr/neolab/sdk/pen/penmsg/IPenDotListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PenDotEventArgs> Handler;
#pragma warning restore 0649

		public void OnReceiveDot (global::KR.Neolab.Sdk.Ink.Structure.Dot p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PenDotEventArgs (p0));
		}

		internal static bool __IsEmpty (IPenDotListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
