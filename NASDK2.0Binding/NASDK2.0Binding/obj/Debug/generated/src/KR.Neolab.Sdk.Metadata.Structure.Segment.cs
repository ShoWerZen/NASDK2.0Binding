using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Metadata.Structure {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/metadata/structure/Segment", DoNotGenerateAcw=true)]
	public partial class Segment : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mBook']"
		[Register ("mBook")]
		public int MBook {
			get {
				const string __id = "mBook.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mBook.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mEndPageNumber']"
		[Register ("mEndPageNumber")]
		public int MEndPageNumber {
			get {
				const string __id = "mEndPageNumber.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mEndPageNumber.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mOwner']"
		[Register ("mOwner")]
		public int MOwner {
			get {
				const string __id = "mOwner.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mOwner.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mPageSize']"
		[Register ("mPageSize")]
		public int MPageSize {
			get {
				const string __id = "mPageSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mPageSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mSection']"
		[Register ("mSection")]
		public int MSection {
			get {
				const string __id = "mSection.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mSection.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mSegmentNumber']"
		[Register ("mSegmentNumber")]
		public int MSegmentNumber {
			get {
				const string __id = "mSegmentNumber.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mSegmentNumber.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mStartPageNumber']"
		[Register ("mStartPageNumber")]
		public int MStartPageNumber {
			get {
				const string __id = "mStartPageNumber.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mStartPageNumber.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mSubCode']"
		[Register ("mSubCode")]
		public string MSubCode {
			get {
				const string __id = "mSubCode.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSubCode.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/field[@name='mTotalPageSize']"
		[Register ("mTotalPageSize")]
		public int MTotalPageSize {
			get {
				const string __id = "mTotalPageSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTotalPageSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/metadata/structure/Segment", typeof (Segment));
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

		protected Segment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Segment']/constructor[@name='Segment' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register (".ctor", "(IIILjava/lang/String;IIIII)V", "")]
		public unsafe Segment (int section, int owner, int book, string subCode, int segmentNumber, int startPageNumber, int endPageNumber, int totalPageSize, int pageSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIILjava/lang/String;IIIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_subCode = JNIEnv.NewString (subCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (section);
				__args [1] = new JniArgumentValue (owner);
				__args [2] = new JniArgumentValue (book);
				__args [3] = new JniArgumentValue (native_subCode);
				__args [4] = new JniArgumentValue (segmentNumber);
				__args [5] = new JniArgumentValue (startPageNumber);
				__args [6] = new JniArgumentValue (endPageNumber);
				__args [7] = new JniArgumentValue (totalPageSize);
				__args [8] = new JniArgumentValue (pageSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_subCode);
			}
		}

	}
}
