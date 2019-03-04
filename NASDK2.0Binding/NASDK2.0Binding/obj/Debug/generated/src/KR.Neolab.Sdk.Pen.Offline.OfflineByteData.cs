using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteData']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/offline/OfflineByteData", DoNotGenerateAcw=true)]
	public partial class OfflineByteData : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteData']/field[@name='noteId']"
		[Register ("noteId")]
		public int NoteId {
			get {
				const string __id = "noteId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "noteId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteData']/field[@name='ownerId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteData']/field[@name='sectionId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteData']/field[@name='strokes']"
		[Register ("strokes")]
		public IList<KR.Neolab.Sdk.Ink.Structure.Stroke> Strokes {
			get {
				const string __id = "strokes.[Lkr/neolab/sdk/ink/structure/Stroke;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::KR.Neolab.Sdk.Ink.Structure.Stroke>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "strokes.[Lkr/neolab/sdk/ink/structure/Stroke;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::KR.Neolab.Sdk.Ink.Structure.Stroke>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/offline/OfflineByteData", typeof (OfflineByteData));
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

		protected OfflineByteData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.offline']/class[@name='OfflineByteData']/constructor[@name='OfflineByteData' and count(parameter)=4 and parameter[1][@type='kr.neolab.sdk.ink.structure.Stroke[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "([Lkr/neolab/sdk/ink/structure/Stroke;III)V", "")]
		public unsafe OfflineByteData (global::KR.Neolab.Sdk.Ink.Structure.Stroke[] strokes, int sectionId, int ownerId, int noteId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lkr/neolab/sdk/ink/structure/Stroke;III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_strokes = JNIEnv.NewArray (strokes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_strokes);
				__args [1] = new JniArgumentValue (sectionId);
				__args [2] = new JniArgumentValue (ownerId);
				__args [3] = new JniArgumentValue (noteId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (strokes != null) {
					JNIEnv.CopyArray (native_strokes, strokes);
					JNIEnv.DeleteLocalRef (native_strokes);
				}
			}
		}

	}
}
