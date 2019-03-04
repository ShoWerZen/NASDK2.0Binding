using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='UseNoteData']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/util/UseNoteData", DoNotGenerateAcw=true)]
	public partial class UseNoteData : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='UseNoteData']/field[@name='noteIds']"
		[Register ("noteIds")]
		public IList<int> NoteIds {
			get {
				const string __id = "noteIds.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "noteIds.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='UseNoteData']/field[@name='ownerId']"
		[Register ("ownerId")]
		public int OwnerId {
			get {
				const string __id = "ownerId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ownerId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='UseNoteData']/field[@name='sectionId']"
		[Register ("sectionId")]
		public int SectionId {
			get {
				const string __id = "sectionId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sectionId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/util/UseNoteData", typeof (UseNoteData));
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

		protected UseNoteData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.util']/class[@name='UseNoteData']/constructor[@name='UseNoteData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UseNoteData ()
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

	}
}
