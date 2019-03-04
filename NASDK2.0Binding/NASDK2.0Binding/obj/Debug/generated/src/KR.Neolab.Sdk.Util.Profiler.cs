using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/util/Profiler", DoNotGenerateAcw=true)]
	public partial class Profiler : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']/field[@name='pType']"
		[Register ("pType")]
		public global::KR.Neolab.Sdk.Util.Profiler.ProfileType PType {
			get {
				const string __id = "pType.Lkr/neolab/sdk/util/Profiler$ProfileType;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler.ProfileType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pType.Lkr/neolab/sdk/util/Profiler$ProfileType;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler.ProfileType']"
		[global::Android.Runtime.Register ("kr/neolab/sdk/util/Profiler$ProfileType", DoNotGenerateAcw=true)]
		public sealed partial class ProfileType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler.ProfileType']/field[@name='CurrentTimeMillis']"
			[Register ("CurrentTimeMillis")]
			public static global::KR.Neolab.Sdk.Util.Profiler.ProfileType CurrentTimeMillis {
				get {
					const string __id = "CurrentTimeMillis.Lkr/neolab/sdk/util/Profiler$ProfileType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler.ProfileType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler.ProfileType']/field[@name='ElapsedRealtime']"
			[Register ("ElapsedRealtime")]
			public static global::KR.Neolab.Sdk.Util.Profiler.ProfileType ElapsedRealtime {
				get {
					const string __id = "ElapsedRealtime.Lkr/neolab/sdk/util/Profiler$ProfileType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler.ProfileType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler.ProfileType']/field[@name='MemoryUsage']"
			[Register ("MemoryUsage")]
			public static global::KR.Neolab.Sdk.Util.Profiler.ProfileType MemoryUsage {
				get {
					const string __id = "MemoryUsage.Lkr/neolab/sdk/util/Profiler$ProfileType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler.ProfileType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/util/Profiler$ProfileType", typeof (ProfileType));
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

			internal ProfileType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler.ProfileType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lkr/neolab/sdk/util/Profiler$ProfileType;", "")]
			public static unsafe global::KR.Neolab.Sdk.Util.Profiler.ProfileType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lkr/neolab/sdk/util/Profiler$ProfileType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler.ProfileType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler.ProfileType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lkr/neolab/sdk/util/Profiler$ProfileType;", "")]
			public static unsafe global::KR.Neolab.Sdk.Util.Profiler.ProfileType[] Values ()
			{
				const string __id = "values.()[Lkr/neolab/sdk/util/Profiler$ProfileType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::KR.Neolab.Sdk.Util.Profiler.ProfileType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Util.Profiler.ProfileType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/util/Profiler", typeof (Profiler));
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

		protected Profiler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']/constructor[@name='Profiler' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.util.Profiler.ProfileType']]"
		[Register (".ctor", "(Lkr/neolab/sdk/util/Profiler$ProfileType;)V", "")]
		public unsafe Profiler (global::KR.Neolab.Sdk.Util.Profiler.ProfileType clocktype)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkr/neolab/sdk/util/Profiler$ProfileType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clocktype == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clocktype).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_lap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLap_Ljava_lang_String_Handler ()
		{
			if (cb_lap_Ljava_lang_String_ == null)
				cb_lap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Lap_Ljava_lang_String_);
			return cb_lap_Ljava_lang_String_;
		}

		static void n_Lap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			global::KR.Neolab.Sdk.Util.Profiler __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			__this.Lap (label);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']/method[@name='lap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("lap", "(Ljava/lang/String;)V", "GetLap_Ljava_lang_String_Handler")]
		public virtual unsafe void Lap (string label)
		{
			const string __id = "lap.(Ljava/lang/String;)V";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Util.Profiler __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_report;
#pragma warning disable 0169
		static Delegate GetReportHandler ()
		{
			if (cb_report == null)
				cb_report = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Report);
			return cb_report;
		}

		static void n_Report (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Util.Profiler __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Report ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']/method[@name='report' and count(parameter)=0]"
		[Register ("report", "()V", "GetReportHandler")]
		public virtual unsafe void Report ()
		{
			const string __id = "report.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Util.Profiler __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Util.Profiler __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Util.Profiler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='Profiler']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
