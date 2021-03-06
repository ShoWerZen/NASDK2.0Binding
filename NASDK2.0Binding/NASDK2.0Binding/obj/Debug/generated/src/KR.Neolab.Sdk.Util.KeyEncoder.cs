using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='KeyEncoder']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/util/KeyEncoder", DoNotGenerateAcw=true)]
	public partial class KeyEncoder : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/util/KeyEncoder", typeof (KeyEncoder));
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

		protected KeyEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='KeyEncoder']/constructor[@name='KeyEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KeyEncoder ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='KeyEncoder']/method[@name='makeMasterKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeMasterKey", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string MakeMasterKey (string mac_address)
		{
			const string __id = "makeMasterKey.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_mac_address = JNIEnv.NewString (mac_address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mac_address);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mac_address);
			}
		}

	}
}
