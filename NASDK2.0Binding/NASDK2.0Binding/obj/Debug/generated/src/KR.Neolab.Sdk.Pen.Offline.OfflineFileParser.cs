using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/offline/OfflineFileParser", DoNotGenerateAcw=true)]
	public partial class OfflineFileParser : global::Java.Lang.Object, global::KR.Neolab.Sdk.Pen.Filter.IFilterListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/offline/OfflineFileParser", typeof (OfflineFileParser));
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

		protected OfflineFileParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/constructor[@name='OfflineFileParser' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe OfflineFileParser (global::Java.IO.File file)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/constructor[@name='OfflineFileParser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe OfflineFileParser (string filename)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/constructor[@name='OfflineFileParser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OfflineFileParser (string filepath, string filename)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_filepath = JNIEnv.NewString (filepath);
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filepath);
				__args [1] = new JniArgumentValue (native_filename);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filepath);
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		public static unsafe string DefaultFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/method[@name='getDefaultFilePath' and count(parameter)=0]"
			[Register ("getDefaultFilePath", "()Ljava/lang/String;", "GetGetDefaultFilePathHandler")]
			get {
				const string __id = "getDefaultFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string ExternalStoragePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/method[@name='getExternalStoragePath' and count(parameter)=0]"
			[Register ("getExternalStoragePath", "()Ljava/lang/String;", "GetGetExternalStoragePathHandler")]
			get {
				const string __id = "getExternalStoragePath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFileParser __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFileParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/method[@name='getOfflineFiles' and count(parameter)=0]"
		[Register ("getOfflineFiles", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetOfflineFiles ()
		{
			const string __id = "getOfflineFiles.()[Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/method[@name='getOfflineFiles' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOfflineFiles", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetOfflineFiles (string filepath)
		{
			const string __id = "getOfflineFiles.(Ljava/lang/String;)[Ljava/lang/String;";
			IntPtr native_filepath = JNIEnv.NewString (filepath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filepath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_filepath);
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

		static void n_OnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fdot)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFileParser __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFileParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Filter.Fdot fdot = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (native_fdot, JniHandleOwnership.DoNotTransfer);
			__this.OnFilteredDot (fdot);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/method[@name='onFilteredDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.filter.Fdot']]"
		[Register ("onFilteredDot", "(Lkr/neolab/sdk/pen/filter/Fdot;)V", "GetOnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler")]
		public virtual unsafe void OnFilteredDot (global::KR.Neolab.Sdk.Pen.Filter.Fdot fdot)
		{
			const string __id = "onFilteredDot.(Lkr/neolab/sdk/pen/filter/Fdot;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fdot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fdot).Handle);
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
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFileParser __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFileParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Parse ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFileParser']/method[@name='parse' and count(parameter)=0]"
		[Register ("parse", "()[Lkr/neolab/sdk/ink/structure/Stroke;", "GetParseHandler")]
		public virtual unsafe global::KR.Neolab.Sdk.Ink.Structure.Stroke[] Parse ()
		{
			const string __id = "parse.()[Lkr/neolab/sdk/ink/structure/Stroke;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::KR.Neolab.Sdk.Ink.Structure.Stroke[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Ink.Structure.Stroke));
			} finally {
			}
		}

	}
}
