using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Broadcastreceiver {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.broadcastreceiver']/class[@name='BTDuplicateRemoveBroadcasterReceiver']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/broadcastreceiver/BTDuplicateRemoveBroadcasterReceiver", DoNotGenerateAcw=true)]
	public partial class BTDuplicateRemoveBroadcasterReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.broadcastreceiver']/class[@name='BTDuplicateRemoveBroadcasterReceiver']/field[@name='ACTION_BT_REQ_CONNECT']"
		[Register ("ACTION_BT_REQ_CONNECT")]
		public const string ActionBtReqConnect = (string) "kr.neolab.sdk.connection.reqconnect";

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.broadcastreceiver']/class[@name='BTDuplicateRemoveBroadcasterReceiver']/field[@name='ACTION_BT_RESPONSE_CONNECTED']"
		[Register ("ACTION_BT_RESPONSE_CONNECTED")]
		public const string ActionBtResponseConnected = (string) "kr.neolab.sdk.connection.connected";

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.broadcastreceiver']/class[@name='BTDuplicateRemoveBroadcasterReceiver']/field[@name='EXTRA_BT_CONNECT_PACKAGENAME']"
		[Register ("EXTRA_BT_CONNECT_PACKAGENAME")]
		public const string ExtraBtConnectPackagename = (string) "connect_packagename";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/broadcastreceiver/BTDuplicateRemoveBroadcasterReceiver", typeof (BTDuplicateRemoveBroadcasterReceiver));
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

		protected BTDuplicateRemoveBroadcasterReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.broadcastreceiver']/class[@name='BTDuplicateRemoveBroadcasterReceiver']/constructor[@name='BTDuplicateRemoveBroadcasterReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BTDuplicateRemoveBroadcasterReceiver ()
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

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0, IntPtr native_arg1)
		{
			global::KR.Neolab.Sdk.Broadcastreceiver.BTDuplicateRemoveBroadcasterReceiver __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Broadcastreceiver.BTDuplicateRemoveBroadcasterReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context arg0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_arg0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent arg1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_arg1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (arg0, arg1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.broadcastreceiver']/class[@name='BTDuplicateRemoveBroadcasterReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context arg0, global::Android.Content.Intent arg1)
		{
			const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				__args [1] = new JniArgumentValue ((arg1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
