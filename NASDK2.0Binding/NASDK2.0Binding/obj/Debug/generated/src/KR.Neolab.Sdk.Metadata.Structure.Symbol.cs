using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Metadata.Structure {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/metadata/structure/Symbol", DoNotGenerateAcw=true)]
	public partial class Symbol : global::Android.Graphics.RectF {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/field[@name='nextId']"
		[Register ("nextId")]
		public string NextId {
			get {
				const string __id = "nextId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nextId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/field[@name='noteId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/field[@name='pageId']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/field[@name='previousId']"
		[Register ("previousId")]
		public string PreviousId {
			get {
				const string __id = "previousId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "previousId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/metadata/structure/Symbol", typeof (Symbol));
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

		protected Symbol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/constructor[@name='Symbol' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='float']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;FFFF)V", "")]
		public unsafe Symbol (int noteId, int pageId, string name, string action, string param, float left, float top, float right, float bottom)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;FFFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_action = JNIEnv.NewString (action);
			IntPtr native_param = JNIEnv.NewString (param);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (native_action);
				__args [4] = new JniArgumentValue (native_param);
				__args [5] = new JniArgumentValue (left);
				__args [6] = new JniArgumentValue (top);
				__args [7] = new JniArgumentValue (right);
				__args [8] = new JniArgumentValue (bottom);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_action);
				JNIEnv.DeleteLocalRef (native_param);
			}
		}

		static Delegate cb_getAction;
#pragma warning disable 0169
		static Delegate GetGetActionHandler ()
		{
			if (cb_getAction == null)
				cb_getAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAction);
			return cb_getAction;
		}

		static IntPtr n_GetAction (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Action);
		}
#pragma warning restore 0169

		public virtual unsafe string Action {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getAction' and count(parameter)=0]"
			[Register ("getAction", "()Ljava/lang/String;", "GetGetActionHandler")]
			get {
				const string __id = "getAction.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHeight);
			return cb_getHeight;
		}

		static float n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		public virtual unsafe float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNext;
#pragma warning disable 0169
		static Delegate GetGetNextHandler ()
		{
			if (cb_getNext == null)
				cb_getNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNext);
			return cb_getNext;
		}

		static IntPtr n_GetNext (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next);
		}
#pragma warning restore 0169

		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol Next {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getNext' and count(parameter)=0]"
			[Register ("getNext", "()Lkr/neolab/sdk/metadata/structure/Symbol;", "GetGetNextHandler")]
			get {
				const string __id = "getNext.()Lkr/neolab/sdk/metadata/structure/Symbol;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParam;
#pragma warning disable 0169
		static Delegate GetGetParamHandler ()
		{
			if (cb_getParam == null)
				cb_getParam = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParam);
			return cb_getParam;
		}

		static IntPtr n_GetParam (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Param);
		}
#pragma warning restore 0169

		public virtual unsafe string Param {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getParam' and count(parameter)=0]"
			[Register ("getParam", "()Ljava/lang/String;", "GetGetParamHandler")]
			get {
				const string __id = "getParam.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrevious;
#pragma warning disable 0169
		static Delegate GetGetPreviousHandler ()
		{
			if (cb_getPrevious == null)
				cb_getPrevious = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrevious);
			return cb_getPrevious;
		}

		static IntPtr n_GetPrevious (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Previous);
		}
#pragma warning restore 0169

		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol Previous {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getPrevious' and count(parameter)=0]"
			[Register ("getPrevious", "()Lkr/neolab/sdk/metadata/structure/Symbol;", "GetGetPreviousHandler")]
			get {
				const string __id = "getPrevious.()Lkr/neolab/sdk/metadata/structure/Symbol;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWidth);
			return cb_getWidth;
		}

		static float n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		public virtual unsafe float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler")]
		public virtual unsafe float GetX ()
		{
			const string __id = "getX.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata.structure']/class[@name='Symbol']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler")]
		public virtual unsafe float GetY ()
		{
			const string __id = "getY.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
