using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Filter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/interface[@name='IFilterListener']"
	[Register ("kr/neolab/sdk/pen/filter/IFilterListener", "", "KR.Neolab.Sdk.Pen.Filter.IFilterListenerInvoker")]
	public partial interface IFilterListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/interface[@name='IFilterListener']/method[@name='onFilteredDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.filter.Fdot']]"
		[Register ("onFilteredDot", "(Lkr/neolab/sdk/pen/filter/Fdot;)V", "GetOnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler:KR.Neolab.Sdk.Pen.Filter.IFilterListenerInvoker, NASDK2.0Binding")]
		void OnFilteredDot (global::KR.Neolab.Sdk.Pen.Filter.Fdot p0);

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/filter/IFilterListener", DoNotGenerateAcw=true)]
	internal class IFilterListenerInvoker : global::Java.Lang.Object, IFilterListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/filter/IFilterListener", typeof (IFilterListenerInvoker));

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

		public static IFilterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFilterListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.filter.IFilterListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFilterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_;
#pragma warning disable 0169
		static Delegate GetOnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler ()
		{
			if (cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ == null)
				cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_);
			return cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_;
		}

		static void n_OnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.Filter.IFilterListener __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.IFilterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Filter.Fdot p0 = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFilteredDot (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_;
		public unsafe void OnFilteredDot (global::KR.Neolab.Sdk.Pen.Filter.Fdot p0)
		{
			if (id_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ == IntPtr.Zero)
				id_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ = JNIEnv.GetMethodID (class_ref, "onFilteredDot", "(Lkr/neolab/sdk/pen/filter/Fdot;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_, __args);
		}

	}

	// event args for kr.neolab.sdk.pen.filter.IFilterListener.onFilteredDot
	public partial class FilterEventArgs : global::System.EventArgs {

		public FilterEventArgs (global::KR.Neolab.Sdk.Pen.Filter.Fdot p0)
		{
			this.p0 = p0;
		}

		global::KR.Neolab.Sdk.Pen.Filter.Fdot p0;
		public global::KR.Neolab.Sdk.Pen.Filter.Fdot P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/kr/neolab/sdk/pen/filter/IFilterListenerImplementor")]
	internal sealed partial class IFilterListenerImplementor : global::Java.Lang.Object, IFilterListener {

		object sender;

		public IFilterListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/kr/neolab/sdk/pen/filter/IFilterListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FilterEventArgs> Handler;
#pragma warning restore 0649

		public void OnFilteredDot (global::KR.Neolab.Sdk.Pen.Filter.Fdot p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FilterEventArgs (p0));
		}

		internal static bool __IsEmpty (IFilterListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
