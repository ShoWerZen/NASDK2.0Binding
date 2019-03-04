using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteParser']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/offline/OfflineByteParser", DoNotGenerateAcw=true)]
	public partial class OfflineByteParser : global::Java.Lang.Object, global::KR.Neolab.Sdk.Pen.Filter.IFilterListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/offline/OfflineByteParser", typeof (OfflineByteParser));
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

		protected OfflineByteParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteParser']/constructor[@name='OfflineByteParser' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe OfflineByteParser (byte[] buffer)
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

		static Delegate cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_;
#pragma warning disable 0169
		static Delegate GetOnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler ()
		{
			if (cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ == null)
				cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_);
			return cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_;
		}

		static void n_OnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dot)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineByteParser __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineByteParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Filter.Fdot dot = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (native_dot, JniHandleOwnership.DoNotTransfer);
			__this.OnFilteredDot (dot);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteParser']/method[@name='onFilteredDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.filter.Fdot']]"
		[Register ("onFilteredDot", "(Lkr/neolab/sdk/pen/filter/Fdot;)V", "GetOnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler")]
		public virtual unsafe void OnFilteredDot (global::KR.Neolab.Sdk.Pen.Filter.Fdot dot)
		{
			const string __id = "onFilteredDot.(Lkr/neolab/sdk/pen/filter/Fdot;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dot).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_parse;
#pragma warning disable 0169
		static Delegate GetParseHandler ()
		{
			if (cb_parse == null)
				cb_parse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Parse);
			return cb_parse;
		}

		static IntPtr n_Parse (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineByteParser __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineByteParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Ink.Structure.Stroke>.ToLocalJniHandle (__this.Parse ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteParser']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()Ljava/util/ArrayList;", "GetParseHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::KR.Neolab.Sdk.Ink.Structure.Stroke> Parse ()
		{
			const string __id = "parse.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Ink.Structure.Stroke>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteParser']/method[@name='unzip' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("unzip", "([BI)[B", "")]
		public static unsafe byte[] Unzip (byte[] buffer, int sizeBeforeCompress)
		{
			const string __id = "unzip.([BI)[B";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (sizeBeforeCompress);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

	}
}
