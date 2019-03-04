using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/util/NLog", DoNotGenerateAcw=true)]
	public partial class NLog : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/field[@name='UseExternalLogger']"
		[Register ("UseExternalLogger")]
		public static bool UseExternalLogger {
			get {
				const string __id = "UseExternalLogger.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "UseExternalLogger.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/util/NLog", typeof (NLog));
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

		protected NLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/constructor[@name='NLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NLog ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "")]
		public static unsafe void D (string text)
		{
			const string __id = "d.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string tag, string text)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "")]
		public static unsafe void E (string text)
		{
			const string __id = "e.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void E (string text, global::Java.Lang.Exception e)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/Exception;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "")]
		public static unsafe void I (string text)
		{
			const string __id = "i.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string tag, string text)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "")]
		public static unsafe void W (string text)
		{
			const string __id = "w.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='NLog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string tag, string text)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_text);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

	}
}
