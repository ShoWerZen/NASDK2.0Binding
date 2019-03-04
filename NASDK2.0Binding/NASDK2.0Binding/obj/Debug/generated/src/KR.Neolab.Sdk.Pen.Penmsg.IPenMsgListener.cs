using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Penmsg {

	// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/interface[@name='IPenMsgListener']"
	[Register ("kr/neolab/sdk/pen/penmsg/IPenMsgListener", "", "KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListenerInvoker")]
	public partial interface IPenMsgListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/interface[@name='IPenMsgListener']/method[@name='onReceiveMessage' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.PenMsg']]"
		[Register ("onReceiveMessage", "(Lkr/neolab/sdk/pen/penmsg/PenMsg;)V", "GetOnReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_Handler:KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListenerInvoker, NASDK2.0Binding")]
		void OnReceiveMessage (global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg p0);

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/penmsg/IPenMsgListener", DoNotGenerateAcw=true)]
	internal class IPenMsgListenerInvoker : global::Java.Lang.Object, IPenMsgListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/penmsg/IPenMsgListener", typeof (IPenMsgListenerInvoker));

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

		public static IPenMsgListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPenMsgListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.penmsg.IPenMsgListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPenMsgListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_;
#pragma warning disable 0169
		static Delegate GetOnReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_Handler ()
		{
			if (cb_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_ == null)
				cb_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_);
			return cb_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_;
		}

		static void n_OnReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg p0 = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_;
		public unsafe void OnReceiveMessage (global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg p0)
		{
			if (id_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_ == IntPtr.Zero)
				id_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_ = JNIEnv.GetMethodID (class_ref, "onReceiveMessage", "(Lkr/neolab/sdk/pen/penmsg/PenMsg;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveMessage_Lkr_neolab_sdk_pen_penmsg_PenMsg_, __args);
		}

	}

	// event args for kr.neolab.sdk.pen.penmsg.IPenMsgListener.onReceiveMessage
	public partial class PenMsgEventArgs : global::System.EventArgs {

		public PenMsgEventArgs (global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg p0)
		{
			this.p0 = p0;
		}

		global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg p0;
		public global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/kr/neolab/sdk/pen/penmsg/IPenMsgListenerImplementor")]
	internal sealed partial class IPenMsgListenerImplementor : global::Java.Lang.Object, IPenMsgListener {

		object sender;

		public IPenMsgListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/kr/neolab/sdk/pen/penmsg/IPenMsgListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PenMsgEventArgs> Handler;
#pragma warning restore 0649

		public void OnReceiveMessage (global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PenMsgEventArgs (p0));
		}

		internal static bool __IsEmpty (IPenMsgListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
