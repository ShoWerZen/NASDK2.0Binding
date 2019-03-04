using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/offline/OfflineFile", DoNotGenerateAcw=true)]
	public partial class OfflineFile : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/field[@name='DEFAULT_FILE_FORMAT']"
		[Register ("DEFAULT_FILE_FORMAT")]
		public static string DefaultFileFormat {
			get {
				const string __id = "DEFAULT_FILE_FORMAT.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "DEFAULT_FILE_FORMAT.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/field[@name='appendCount']"
		[Register ("appendCount")]
		public int AppendCount {
			get {
				const string __id = "appendCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "appendCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/field[@name='packetCount']"
		[Register ("packetCount")]
		public int PacketCount {
			get {
				const string __id = "packetCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "packetCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/offline/OfflineFile", typeof (OfflineFile));
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

		protected OfflineFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/constructor[@name='OfflineFile' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(IIIZ)V", "")]
		public unsafe OfflineFile (int sectionId, int ownerId, int noteId, bool isCompressed)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				__args [3] = new JniArgumentValue (isCompressed);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/constructor[@name='OfflineFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;IZ)V", "")]
		public unsafe OfflineFile (string fileinfo, int packetCount, bool isCompressed)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fileinfo = JNIEnv.NewString (fileinfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_fileinfo);
				__args [1] = new JniArgumentValue (packetCount);
				__args [2] = new JniArgumentValue (isCompressed);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileinfo);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string DefaultFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getDefaultFilePath' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getExternalStoragePath' and count(parameter)=0]"
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

		static Delegate cb_getNoteId;
#pragma warning disable 0169
		static Delegate GetGetNoteIdHandler ()
		{
			if (cb_getNoteId == null)
				cb_getNoteId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNoteId);
			return cb_getNoteId;
		}

		static int n_GetNoteId (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoteId;
		}
#pragma warning restore 0169

		public virtual unsafe int NoteId {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getNoteId' and count(parameter)=0]"
			[Register ("getNoteId", "()I", "GetGetNoteIdHandler")]
			get {
				const string __id = "getNoteId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string OfflineFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getOfflineFilePath' and count(parameter)=0]"
			[Register ("getOfflineFilePath", "()Ljava/lang/String;", "GetGetOfflineFilePathHandler")]
			get {
				const string __id = "getOfflineFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOwnerId;
#pragma warning disable 0169
		static Delegate GetGetOwnerIdHandler ()
		{
			if (cb_getOwnerId == null)
				cb_getOwnerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOwnerId);
			return cb_getOwnerId;
		}

		static int n_GetOwnerId (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OwnerId;
		}
#pragma warning restore 0169

		public virtual unsafe int OwnerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getOwnerId' and count(parameter)=0]"
			[Register ("getOwnerId", "()I", "GetGetOwnerIdHandler")]
			get {
				const string __id = "getOwnerId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPageId;
#pragma warning disable 0169
		static Delegate GetGetPageIdHandler ()
		{
			if (cb_getPageId == null)
				cb_getPageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPageId);
			return cb_getPageId;
		}

		static int n_GetPageId (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PageId;
		}
#pragma warning restore 0169

		public virtual unsafe int PageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getPageId' and count(parameter)=0]"
			[Register ("getPageId", "()I", "GetGetPageIdHandler")]
			get {
				const string __id = "getPageId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSectionId;
#pragma warning disable 0169
		static Delegate GetGetSectionIdHandler ()
		{
			if (cb_getSectionId == null)
				cb_getSectionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSectionId);
			return cb_getSectionId;
		}

		static int n_GetSectionId (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SectionId;
		}
#pragma warning restore 0169

		public virtual unsafe int SectionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='getSectionId' and count(parameter)=0]"
			[Register ("getSectionId", "()I", "GetGetSectionIdHandler")]
			get {
				const string __id = "getSectionId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_append_arrayBI;
#pragma warning disable 0169
		static Delegate GetAppend_arrayBIHandler ()
		{
			if (cb_append_arrayBI == null)
				cb_append_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Append_arrayBI);
			return cb_append_arrayBI;
		}

		static void n_Append_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int index)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Append (data, index);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='append' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("append", "([BI)V", "GetAppend_arrayBIHandler")]
		public virtual unsafe void Append (byte[] data, int index)
		{
			const string __id = "append.([BI)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_clearTempFile;
#pragma warning disable 0169
		static Delegate GetClearTempFileHandler ()
		{
			if (cb_clearTempFile == null)
				cb_clearTempFile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearTempFile);
			return cb_clearTempFile;
		}

		static void n_ClearTempFile (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearTempFile ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='clearTempFile' and count(parameter)=0]"
		[Register ("clearTempFile", "()V", "GetClearTempFileHandler")]
		public virtual unsafe void ClearTempFile ()
		{
			const string __id = "clearTempFile.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_make;
#pragma warning disable 0169
		static Delegate GetMakeHandler ()
		{
			if (cb_make == null)
				cb_make = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Make);
			return cb_make;
		}

		static IntPtr n_Make (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Offline.OfflineFile __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Make ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='make' and count(parameter)=0]"
		[Register ("make", "()Ljava/lang/String;", "GetMakeHandler")]
		public virtual unsafe string Make ()
		{
			const string __id = "make.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineFile']/method[@name='setOfflineFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOfflineFilePath", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool SetOfflineFilePath (string newPath)
		{
			const string __id = "setOfflineFilePath.(Ljava/lang/String;)Z";
			IntPtr native_newPath = JNIEnv.NewString (newPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_newPath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_newPath);
			}
		}

	}
}
