using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Filter {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='FilterForPaper']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/filter/FilterForPaper", DoNotGenerateAcw=true)]
	public partial class FilterForPaper : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/filter/FilterForPaper", typeof (FilterForPaper));
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

		protected FilterForPaper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='FilterForPaper']/constructor[@name='FilterForPaper' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.filter.IFilterListener']]"
		[Register (".ctor", "(Lkr/neolab/sdk/pen/filter/IFilterListener;)V", "")]
		public unsafe FilterForPaper (global::KR.Neolab.Sdk.Pen.Filter.IFilterListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkr/neolab/sdk/pen/filter/IFilterListener;)V";

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

		static Delegate cb_put_Lkr_neolab_sdk_pen_filter_Fdot_;
#pragma warning disable 0169
		static Delegate GetPut_Lkr_neolab_sdk_pen_filter_Fdot_Handler ()
		{
			if (cb_put_Lkr_neolab_sdk_pen_filter_Fdot_ == null)
				cb_put_Lkr_neolab_sdk_pen_filter_Fdot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Put_Lkr_neolab_sdk_pen_filter_Fdot_);
			return cb_put_Lkr_neolab_sdk_pen_filter_Fdot_;
		}

		static void n_Put_Lkr_neolab_sdk_pen_filter_Fdot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mdot)
		{
			global::KR.Neolab.Sdk.Pen.Filter.FilterForPaper __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.FilterForPaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Filter.Fdot mdot = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (native_mdot, JniHandleOwnership.DoNotTransfer);
			__this.Put (mdot);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.filter']/class[@name='FilterForPaper']/method[@name='put' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.filter.Fdot']]"
		[Register ("put", "(Lkr/neolab/sdk/pen/filter/Fdot;)V", "GetPut_Lkr_neolab_sdk_pen_filter_Fdot_Handler")]
		public virtual unsafe void Put (global::KR.Neolab.Sdk.Pen.Filter.Fdot mdot)
		{
			const string __id = "put.(Lkr/neolab/sdk/pen/filter/Fdot;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mdot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mdot).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
