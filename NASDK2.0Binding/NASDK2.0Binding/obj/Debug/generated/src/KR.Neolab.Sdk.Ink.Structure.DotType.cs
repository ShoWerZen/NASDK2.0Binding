using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Ink.Structure {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/ink/structure/DotType", DoNotGenerateAcw=true)]
	public sealed partial class DotType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/field[@name='PEN_ACTION_DOWN']"
		[Register ("PEN_ACTION_DOWN")]
		public static global::KR.Neolab.Sdk.Ink.Structure.DotType PenActionDown {
			get {
				const string __id = "PEN_ACTION_DOWN.Lkr/neolab/sdk/ink/structure/DotType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.DotType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/field[@name='PEN_ACTION_MOVE']"
		[Register ("PEN_ACTION_MOVE")]
		public static global::KR.Neolab.Sdk.Ink.Structure.DotType PenActionMove {
			get {
				const string __id = "PEN_ACTION_MOVE.Lkr/neolab/sdk/ink/structure/DotType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.DotType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/field[@name='PEN_ACTION_UP']"
		[Register ("PEN_ACTION_UP")]
		public static global::KR.Neolab.Sdk.Ink.Structure.DotType PenActionUp {
			get {
				const string __id = "PEN_ACTION_UP.Lkr/neolab/sdk/ink/structure/DotType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.DotType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/ink/structure/DotType", typeof (DotType));
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

		internal DotType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/method[@name='isPenActionDown' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPenActionDown", "(I)Z", "")]
		public static unsafe bool IsPenActionDown (int type)
		{
			const string __id = "isPenActionDown.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/method[@name='isPenActionMove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPenActionMove", "(I)Z", "")]
		public static unsafe bool IsPenActionMove (int type)
		{
			const string __id = "isPenActionMove.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/method[@name='isPenActionUp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPenActionUp", "(I)Z", "")]
		public static unsafe bool IsPenActionUp (int type)
		{
			const string __id = "isPenActionUp.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lkr/neolab/sdk/ink/structure/DotType;", "")]
		public static unsafe global::KR.Neolab.Sdk.Ink.Structure.DotType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lkr/neolab/sdk/ink/structure/DotType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.DotType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='DotType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lkr/neolab/sdk/ink/structure/DotType;", "")]
		public static unsafe global::KR.Neolab.Sdk.Ink.Structure.DotType[] Values ()
		{
			const string __id = "values.()[Lkr/neolab/sdk/ink/structure/DotType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::KR.Neolab.Sdk.Ink.Structure.DotType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Ink.Structure.DotType));
			} finally {
			}
		}

	}
}
