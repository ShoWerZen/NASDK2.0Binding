using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Metadata.Structure {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/metadata/structure/Page", DoNotGenerateAcw=true)]
	public partial class Page : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='angle']"
		[Register ("angle")]
		public int Angle {
			get {
				const string __id = "angle.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "angle.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='height']"
		[Register ("height")]
		public float Height {
			get {
				const string __id = "height.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "height.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='margin_bottom']"
		[Register ("margin_bottom")]
		public float MarginBottom {
			get {
				const string __id = "margin_bottom.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "margin_bottom.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='margin_left']"
		[Register ("margin_left")]
		public float MarginLeft {
			get {
				const string __id = "margin_left.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "margin_left.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='margin_right']"
		[Register ("margin_right")]
		public float MarginRight {
			get {
				const string __id = "margin_right.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "margin_right.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='margin_top']"
		[Register ("margin_top")]
		public float MarginTop {
			get {
				const string __id = "margin_top.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "margin_top.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='noteId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='pageId']"
		[Register ("pageId")]
		public int PageId {
			get {
				const string __id = "pageId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pageId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/field[@name='width']"
		[Register ("width")]
		public float Width {
			get {
				const string __id = "width.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "width.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/metadata/structure/Page", typeof (Page));
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

		protected Page (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Page']/constructor[@name='Page' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Page ()
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
