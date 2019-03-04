using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='TimeUtil']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/util/TimeUtil", DoNotGenerateAcw=true)]
	public partial class TimeUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/util/TimeUtil", typeof (TimeUtil));
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

		protected TimeUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='TimeUtil']/constructor[@name='TimeUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimeUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='TimeUtil']/method[@name='convertLocalTimeToUTC' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertLocalTimeToUTC", "(J)J", "")]
		public static unsafe long ConvertLocalTimeToUTC (long pv_localDateTime)
		{
			const string __id = "convertLocalTimeToUTC.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pv_localDateTime);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='TimeUtil']/method[@name='convertUTCToLocalTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertUTCToLocalTime", "(J)J", "")]
		public static unsafe long ConvertUTCToLocalTime (long pv_UTCDateTime)
		{
			const string __id = "convertUTCToLocalTime.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pv_UTCDateTime);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
