using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Penmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/penmsg/PenMsg", DoNotGenerateAcw=true)]
	public partial class PenMsg : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/field[@name='mac_address']"
		[Register ("mac_address")]
		public string MacAddress {
			get {
				const string __id = "mac_address.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mac_address.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/penmsg/PenMsg", typeof (PenMsg));
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

		protected PenMsg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/constructor[@name='PenMsg' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe PenMsg (int penMsgType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (penMsgType);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/constructor[@name='PenMsg' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe PenMsg (int penMsgType, string MACAddress)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_MACAddress = JNIEnv.NewString (MACAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (penMsgType);
				__args [1] = new JniArgumentValue (native_MACAddress);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_MACAddress);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/constructor[@name='PenMsg' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PenMsg (int penMsgType, string name, string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (penMsgType);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/constructor[@name='PenMsg' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String[]']]"
		[Register (".ctor", "(I[Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe PenMsg (int penMsgType, string[] names, string[] values)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I[Ljava/lang/String;[Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_names = JNIEnv.NewArray (names);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (penMsgType);
				__args [1] = new JniArgumentValue (native_names);
				__args [2] = new JniArgumentValue (native_values);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (names != null) {
					JNIEnv.CopyArray (native_names, names);
					JNIEnv.DeleteLocalRef (native_names);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/constructor[@name='PenMsg' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.json.JSONArray']]"
		[Register (".ctor", "(ILorg/json/JSONArray;)V", "")]
		public unsafe PenMsg (int penMsgType, global::Org.Json.JSONArray jarr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILorg/json/JSONArray;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (penMsgType);
				__args [1] = new JniArgumentValue ((jarr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jarr).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/constructor[@name='PenMsg' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(ILorg/json/JSONObject;)V", "")]
		public unsafe PenMsg (int penMsgType, global::Org.Json.JSONObject job)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILorg/json/JSONObject;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (penMsgType);
				__args [1] = new JniArgumentValue ((job == null) ? IntPtr.Zero : ((global::Java.Lang.Object) job).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				const string __id = "getContent.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentByJSONArray;
#pragma warning disable 0169
		static Delegate GetGetContentByJSONArrayHandler ()
		{
			if (cb_getContentByJSONArray == null)
				cb_getContentByJSONArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentByJSONArray);
			return cb_getContentByJSONArray;
		}

		static IntPtr n_GetContentByJSONArray (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentByJSONArray);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONArray ContentByJSONArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='getContentByJSONArray' and count(parameter)=0]"
			[Register ("getContentByJSONArray", "()Lorg/json/JSONArray;", "GetGetContentByJSONArrayHandler")]
			get {
				const string __id = "getContentByJSONArray.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentByJSONObject;
#pragma warning disable 0169
		static Delegate GetGetContentByJSONObjectHandler ()
		{
			if (cb_getContentByJSONObject == null)
				cb_getContentByJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentByJSONObject);
			return cb_getContentByJSONObject;
		}

		static IntPtr n_GetContentByJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentByJSONObject);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject ContentByJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='getContentByJSONObject' and count(parameter)=0]"
			[Register ("getContentByJSONObject", "()Lorg/json/JSONObject;", "GetGetContentByJSONObjectHandler")]
			get {
				const string __id = "getContentByJSONObject.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPenMsgType;
#pragma warning disable 0169
		static Delegate GetGetPenMsgTypeHandler ()
		{
			if (cb_getPenMsgType == null)
				cb_getPenMsgType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPenMsgType);
			return cb_getPenMsgType;
		}

		static int n_GetPenMsgType (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PenMsgType;
		}
#pragma warning restore 0169

		public virtual unsafe int PenMsgType {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='getPenMsgType' and count(parameter)=0]"
			[Register ("getPenMsgType", "()I", "GetGetPenMsgTypeHandler")]
			get {
				const string __id = "getPenMsgType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='getContentByJSONArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getContentByJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;", "")]
		public static unsafe global::Org.Json.JSONArray GetContentByJSONArray (string content)
		{
			const string __id = "getContentByJSONArray.(Ljava/lang/String;)Lorg/json/JSONArray;";
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='getContentByJSONObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getContentByJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;", "")]
		public static unsafe global::Org.Json.JSONObject GetContentByJSONObject (string content)
		{
			const string __id = "getContentByJSONObject.(Ljava/lang/String;)Lorg/json/JSONObject;";
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		static Delegate cb_toJSONString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToJSONString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_toJSONString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_toJSONString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJSONString_Ljava_lang_String_Ljava_lang_String_);
			return cb_toJSONString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ToJSONString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToJSONString (name, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='toJSONString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("toJSONString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetToJSONString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string ToJSONString (string name, string value)
		{
			const string __id = "toJSONString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_toJSONString_arrayLjava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToJSONString_arrayLjava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_toJSONString_arrayLjava_lang_String_arrayLjava_lang_String_ == null)
				cb_toJSONString_arrayLjava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJSONString_arrayLjava_lang_String_arrayLjava_lang_String_);
			return cb_toJSONString_arrayLjava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_ToJSONString_arrayLjava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_names, IntPtr native_values)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] names = (string[]) JNIEnv.GetArray (native_names, JniHandleOwnership.DoNotTransfer, typeof (string));
			string[] values = (string[]) JNIEnv.GetArray (native_values, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.NewString (__this.ToJSONString (names, values));
			if (names != null)
				JNIEnv.CopyArray (names, native_names);
			if (values != null)
				JNIEnv.CopyArray (values, native_values);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='toJSONString' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("toJSONString", "([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "GetToJSONString_arrayLjava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe string ToJSONString (string[] names, string[] values)
		{
			const string __id = "toJSONString.([Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_names = JNIEnv.NewArray (names);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_names);
				__args [1] = new JniArgumentValue (native_values);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (names != null) {
					JNIEnv.CopyArray (native_names, names);
					JNIEnv.DeleteLocalRef (native_names);
				}
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static Delegate cb_toJSONString_Ljava_util_LinkedHashMap_;
#pragma warning disable 0169
		static Delegate GetToJSONString_Ljava_util_LinkedHashMap_Handler ()
		{
			if (cb_toJSONString_Ljava_util_LinkedHashMap_ == null)
				cb_toJSONString_Ljava_util_LinkedHashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJSONString_Ljava_util_LinkedHashMap_);
			return cb_toJSONString_Ljava_util_LinkedHashMap_;
		}

		static IntPtr n_ToJSONString_Ljava_util_LinkedHashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_map)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.LinkedHashMap map = global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (native_map, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToJSONString (map));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='toJSONString' and count(parameter)=1 and parameter[1][@type='java.util.LinkedHashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("toJSONString", "(Ljava/util/LinkedHashMap;)Ljava/lang/String;", "GetToJSONString_Ljava_util_LinkedHashMap_Handler")]
		public virtual unsafe string ToJSONString (global::Java.Util.LinkedHashMap map)
		{
			const string __id = "toJSONString.(Ljava/util/LinkedHashMap;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((map == null) ? IntPtr.Zero : ((global::Java.Lang.Object) map).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toJSONString_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetToJSONString_Lorg_json_JSONArray_Handler ()
		{
			if (cb_toJSONString_Lorg_json_JSONArray_ == null)
				cb_toJSONString_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJSONString_Lorg_json_JSONArray_);
			return cb_toJSONString_Lorg_json_JSONArray_;
		}

		static IntPtr n_ToJSONString_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jarr)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray jarr = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_jarr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToJSONString (jarr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='toJSONString' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("toJSONString", "(Lorg/json/JSONArray;)Ljava/lang/String;", "GetToJSONString_Lorg_json_JSONArray_Handler")]
		public virtual unsafe string ToJSONString (global::Org.Json.JSONArray jarr)
		{
			const string __id = "toJSONString.(Lorg/json/JSONArray;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jarr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jarr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toJSONString_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetToJSONString_Lorg_json_JSONObject_Handler ()
		{
			if (cb_toJSONString_Lorg_json_JSONObject_ == null)
				cb_toJSONString_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToJSONString_Lorg_json_JSONObject_);
			return cb_toJSONString_Lorg_json_JSONObject_;
		}

		static IntPtr n_ToJSONString_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_job)
		{
			global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.PenMsg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject job = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_job, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToJSONString (job));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsg']/method[@name='toJSONString' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("toJSONString", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetToJSONString_Lorg_json_JSONObject_Handler")]
		public virtual unsafe string ToJSONString (global::Org.Json.JSONObject job)
		{
			const string __id = "toJSONString.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((job == null) ? IntPtr.Zero : ((global::Java.Lang.Object) job).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
