using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Metadata {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/metadata/MetadataCtrl", DoNotGenerateAcw=true)]
	public partial class MetadataCtrl : global::Java.Lang.Object, global::KR.Neolab.Sdk.Metadata.IMetadataCtrl {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/field[@name='PIXEL_TO_DOT_SCALE']"
		[Register ("PIXEL_TO_DOT_SCALE")]
		public static float PixelToDotScale {
			get {
				const string __id = "PIXEL_TO_DOT_SCALE.F";

				var __v = _members.StaticFields.GetSingleValue (__id);
				return __v;
			}
			set {
				const string __id = "PIXEL_TO_DOT_SCALE.F";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/metadata/MetadataCtrl", typeof (MetadataCtrl));
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

		protected MetadataCtrl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::KR.Neolab.Sdk.Metadata.MetadataCtrl Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lkr/neolab/sdk/metadata/MetadataCtrl;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lkr/neolab/sdk/metadata/MetadataCtrl;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_findApplicableSymbol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbol_Ljava_lang_String_Handler ()
		{
			if (cb_findApplicableSymbol_Ljava_lang_String_ == null)
				cb_findApplicableSymbol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindApplicableSymbol_Ljava_lang_String_);
			return cb_findApplicableSymbol_Ljava_lang_String_;
		}

		static IntPtr n_FindApplicableSymbol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindApplicableSymbol (id));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='findApplicableSymbol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findApplicableSymbol", "(Ljava/lang/String;)Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbol_Ljava_lang_String_Handler")]
		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol FindApplicableSymbol (string id)
		{
			const string __id = "findApplicableSymbol.(Ljava/lang/String;)Lkr/neolab/sdk/metadata/structure/Symbol;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_findApplicableSymbols_II;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbols_IIHandler ()
		{
			if (cb_findApplicableSymbols_II == null)
				cb_findApplicableSymbols_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FindApplicableSymbols_II);
			return cb_findApplicableSymbols_II;
		}

		static IntPtr n_FindApplicableSymbols_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.FindApplicableSymbols (noteId, pageId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='findApplicableSymbols' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("findApplicableSymbols", "(II)[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbols_IIHandler")]
		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (int noteId, int pageId)
		{
			const string __id = "findApplicableSymbols.(II)[Lkr/neolab/sdk/metadata/structure/Symbol;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
			} finally {
			}
		}

		static Delegate cb_findApplicableSymbols_IIFF;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbols_IIFFHandler ()
		{
			if (cb_findApplicableSymbols_IIFF == null)
				cb_findApplicableSymbols_IIFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float, float, IntPtr>) n_FindApplicableSymbols_IIFF);
			return cb_findApplicableSymbols_IIFF;
		}

		static IntPtr n_FindApplicableSymbols_IIFF (IntPtr jnienv, IntPtr native__this, int noteId, int pageId, float x, float y)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.FindApplicableSymbols (noteId, pageId, x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='findApplicableSymbols' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("findApplicableSymbols", "(IIFF)[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbols_IIFFHandler")]
		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (int noteId, int pageId, float x, float y)
		{
			const string __id = "findApplicableSymbols.(IIFF)[Lkr/neolab/sdk/metadata/structure/Symbol;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
			} finally {
			}
		}

		static Delegate cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_Handler ()
		{
			if (cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ == null)
				cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_);
			return cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_;
		}

		static IntPtr n_FindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nstr)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Ink.Structure.Stroke nstr = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (native_nstr, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.FindApplicableSymbols (nstr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='findApplicableSymbols' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.ink.structure.Stroke']]"
		[Register ("findApplicableSymbols", "(Lkr/neolab/sdk/ink/structure/Stroke;)[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_Handler")]
		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (global::KR.Neolab.Sdk.Ink.Structure.Stroke nstr)
		{
			const string __id = "findApplicableSymbols.(Lkr/neolab/sdk/ink/structure/Stroke;)[Lkr/neolab/sdk/metadata/structure/Symbol;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nstr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nstr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
			} finally {
			}
		}

		static Delegate cb_getExtraInfo_I;
#pragma warning disable 0169
		static Delegate GetGetExtraInfo_IHandler ()
		{
			if (cb_getExtraInfo_I == null)
				cb_getExtraInfo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetExtraInfo_I);
			return cb_getExtraInfo_I;
		}

		static IntPtr n_GetExtraInfo_I (IntPtr jnienv, IntPtr native__this, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetExtraInfo (noteId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getExtraInfo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getExtraInfo", "(I)Ljava/lang/String;", "GetGetExtraInfo_IHandler")]
		public virtual unsafe string GetExtraInfo (int noteId)
		{
			const string __id = "getExtraInfo.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getKind_I;
#pragma warning disable 0169
		static Delegate GetGetKind_IHandler ()
		{
			if (cb_getKind_I == null)
				cb_getKind_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetKind_I);
			return cb_getKind_I;
		}

		static int n_GetKind_I (IntPtr jnienv, IntPtr native__this, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetKind (noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getKind' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getKind", "(I)I", "GetGetKind_IHandler")]
		public virtual unsafe int GetKind (int noteId)
		{
			const string __id = "getKind.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getNoteTypeList_I;
#pragma warning disable 0169
		static Delegate GetGetNoteTypeList_IHandler ()
		{
			if (cb_getNoteTypeList_I == null)
				cb_getNoteTypeList_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetNoteTypeList_I);
			return cb_getNoteTypeList_I;
		}

		static IntPtr n_GetNoteTypeList_I (IntPtr jnienv, IntPtr native__this, int kind)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.GetNoteTypeList (kind));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getNoteTypeList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNoteTypeList", "(I)Ljava/util/ArrayList;", "GetGetNoteTypeList_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> GetNoteTypeList (int kind)
		{
			const string __id = "getNoteTypeList.(I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (kind);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOwnerCode_I;
#pragma warning disable 0169
		static Delegate GetGetOwnerCode_IHandler ()
		{
			if (cb_getOwnerCode_I == null)
				cb_getOwnerCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetOwnerCode_I);
			return cb_getOwnerCode_I;
		}

		static int n_GetOwnerCode_I (IntPtr jnienv, IntPtr native__this, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOwnerCode (noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getOwnerCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOwnerCode", "(I)I", "GetGetOwnerCode_IHandler")]
		public virtual unsafe int GetOwnerCode (int noteId)
		{
			const string __id = "getOwnerCode.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageHeight_II;
#pragma warning disable 0169
		static Delegate GetGetPageHeight_IIHandler ()
		{
			if (cb_getPageHeight_II == null)
				cb_getPageHeight_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageHeight_II);
			return cb_getPageHeight_II;
		}

		static float n_GetPageHeight_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageHeight (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageHeight' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageHeight", "(II)F", "GetGetPageHeight_IIHandler")]
		public virtual unsafe float GetPageHeight (int noteId, int pageId)
		{
			const string __id = "getPageHeight.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageHeightWithMargin_II;
#pragma warning disable 0169
		static Delegate GetGetPageHeightWithMargin_IIHandler ()
		{
			if (cb_getPageHeightWithMargin_II == null)
				cb_getPageHeightWithMargin_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageHeightWithMargin_II);
			return cb_getPageHeightWithMargin_II;
		}

		static float n_GetPageHeightWithMargin_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageHeightWithMargin (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageHeightWithMargin' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageHeightWithMargin", "(II)F", "GetGetPageHeightWithMargin_IIHandler")]
		public virtual unsafe float GetPageHeightWithMargin (int noteId, int pageId)
		{
			const string __id = "getPageHeightWithMargin.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageMarginBottom_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginBottom_IIHandler ()
		{
			if (cb_getPageMarginBottom_II == null)
				cb_getPageMarginBottom_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginBottom_II);
			return cb_getPageMarginBottom_II;
		}

		static float n_GetPageMarginBottom_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginBottom (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageMarginBottom' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginBottom", "(II)F", "GetGetPageMarginBottom_IIHandler")]
		public virtual unsafe float GetPageMarginBottom (int noteId, int pageId)
		{
			const string __id = "getPageMarginBottom.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageMarginLeft_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginLeft_IIHandler ()
		{
			if (cb_getPageMarginLeft_II == null)
				cb_getPageMarginLeft_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginLeft_II);
			return cb_getPageMarginLeft_II;
		}

		static float n_GetPageMarginLeft_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginLeft (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageMarginLeft' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginLeft", "(II)F", "GetGetPageMarginLeft_IIHandler")]
		public virtual unsafe float GetPageMarginLeft (int noteId, int pageId)
		{
			const string __id = "getPageMarginLeft.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageMarginRight_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginRight_IIHandler ()
		{
			if (cb_getPageMarginRight_II == null)
				cb_getPageMarginRight_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginRight_II);
			return cb_getPageMarginRight_II;
		}

		static float n_GetPageMarginRight_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginRight (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageMarginRight' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginRight", "(II)F", "GetGetPageMarginRight_IIHandler")]
		public virtual unsafe float GetPageMarginRight (int noteId, int pageId)
		{
			const string __id = "getPageMarginRight.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageMarginTop_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginTop_IIHandler ()
		{
			if (cb_getPageMarginTop_II == null)
				cb_getPageMarginTop_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginTop_II);
			return cb_getPageMarginTop_II;
		}

		static float n_GetPageMarginTop_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginTop (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageMarginTop' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginTop", "(II)F", "GetGetPageMarginTop_IIHandler")]
		public virtual unsafe float GetPageMarginTop (int noteId, int pageId)
		{
			const string __id = "getPageMarginTop.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageWidth_II;
#pragma warning disable 0169
		static Delegate GetGetPageWidth_IIHandler ()
		{
			if (cb_getPageWidth_II == null)
				cb_getPageWidth_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageWidth_II);
			return cb_getPageWidth_II;
		}

		static float n_GetPageWidth_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidth (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageWidth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageWidth", "(II)F", "GetGetPageWidth_IIHandler")]
		public virtual unsafe float GetPageWidth (int noteId, int pageId)
		{
			const string __id = "getPageWidth.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPageWidthWithMargin_II;
#pragma warning disable 0169
		static Delegate GetGetPageWidthWithMargin_IIHandler ()
		{
			if (cb_getPageWidthWithMargin_II == null)
				cb_getPageWidthWithMargin_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageWidthWithMargin_II);
			return cb_getPageWidthWithMargin_II;
		}

		static float n_GetPageWidthWithMargin_II (IntPtr jnienv, IntPtr native__this, int noteId, int pageId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidthWithMargin (noteId, pageId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getPageWidthWithMargin' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageWidthWithMargin", "(II)F", "GetGetPageWidthWithMargin_IIHandler")]
		public virtual unsafe float GetPageWidthWithMargin (int noteId, int pageId)
		{
			const string __id = "getPageWidthWithMargin.(II)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (noteId);
				__args [1] = new JniArgumentValue (pageId);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getSectionCode_I;
#pragma warning disable 0169
		static Delegate GetGetSectionCode_IHandler ()
		{
			if (cb_getSectionCode_I == null)
				cb_getSectionCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetSectionCode_I);
			return cb_getSectionCode_I;
		}

		static int n_GetSectionCode_I (IntPtr jnienv, IntPtr native__this, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSectionCode (noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getSectionCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSectionCode", "(I)I", "GetGetSectionCode_IHandler")]
		public virtual unsafe int GetSectionCode (int noteId)
		{
			const string __id = "getSectionCode.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getSegments_III;
#pragma warning disable 0169
		static Delegate GetGetSegments_IIIHandler ()
		{
			if (cb_getSegments_III == null)
				cb_getSegments_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetSegments_III);
			return cb_getSegments_III;
		}

		static IntPtr n_GetSegments_III (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSegments (sectionId, ownerId, noteId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getSegments' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getSegments", "(III)[Lkr/neolab/sdk/metadata/structure/Segment;", "GetGetSegments_IIIHandler")]
		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Segment[] GetSegments (int sectionId, int ownerId, int noteId)
		{
			const string __id = "getSegments.(III)[Lkr/neolab/sdk/metadata/structure/Segment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::KR.Neolab.Sdk.Metadata.Structure.Segment[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Segment));
			} finally {
			}
		}

		static Delegate cb_getStartPage_I;
#pragma warning disable 0169
		static Delegate GetGetStartPage_IHandler ()
		{
			if (cb_getStartPage_I == null)
				cb_getStartPage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetStartPage_I);
			return cb_getStartPage_I;
		}

		static int n_GetStartPage_I (IntPtr jnienv, IntPtr native__this, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStartPage (noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getStartPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStartPage", "(I)I", "GetGetStartPage_IHandler")]
		public virtual unsafe int GetStartPage (int noteId)
		{
			const string __id = "getStartPage.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getSymbols;
#pragma warning disable 0169
		static Delegate GetGetSymbolsHandler ()
		{
			if (cb_getSymbols == null)
				cb_getSymbols = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSymbols);
			return cb_getSymbols;
		}

		static IntPtr n_GetSymbols (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSymbols ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getSymbols' and count(parameter)=0]"
		[Register ("getSymbols", "()[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetGetSymbolsHandler")]
		public virtual unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] GetSymbols ()
		{
			const string __id = "getSymbols.()[Lkr/neolab/sdk/metadata/structure/Symbol;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
			} finally {
			}
		}

		static Delegate cb_getTitle_I;
#pragma warning disable 0169
		static Delegate GetGetTitle_IHandler ()
		{
			if (cb_getTitle_I == null)
				cb_getTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTitle_I);
			return cb_getTitle_I;
		}

		static IntPtr n_GetTitle_I (IntPtr jnienv, IntPtr native__this, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetTitle (noteId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTitle", "(I)Ljava/lang/String;", "GetGetTitle_IHandler")]
		public virtual unsafe string GetTitle (int noteId)
		{
			const string __id = "getTitle.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTotalPages_I;
#pragma warning disable 0169
		static Delegate GetGetTotalPages_IHandler ()
		{
			if (cb_getTotalPages_I == null)
				cb_getTotalPages_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetTotalPages_I);
			return cb_getTotalPages_I;
		}

		static int n_GetTotalPages_I (IntPtr jnienv, IntPtr native__this, int noteId)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTotalPages (noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='getTotalPages' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTotalPages", "(I)I", "GetGetTotalPages_IHandler")]
		public virtual unsafe int GetTotalPages (int noteId)
		{
			const string __id = "getTotalPages.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noteId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_loadFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetLoadFile_Ljava_io_File_Handler ()
		{
			if (cb_loadFile_Ljava_io_File_ == null)
				cb_loadFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadFile_Ljava_io_File_);
			return cb_loadFile_Ljava_io_File_;
		}

		static void n_LoadFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File file = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_file, JniHandleOwnership.DoNotTransfer);
			__this.LoadFile (file);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='loadFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("loadFile", "(Ljava/io/File;)V", "GetLoadFile_Ljava_io_File_Handler")]
		public virtual unsafe void LoadFile (global::Java.IO.File file)
		{
			const string __id = "loadFile.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_loadFiles_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadFiles_Ljava_lang_String_Handler ()
		{
			if (cb_loadFiles_Ljava_lang_String_ == null)
				cb_loadFiles_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadFiles_Ljava_lang_String_);
			return cb_loadFiles_Ljava_lang_String_;
		}

		static void n_LoadFiles_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileDirectoryPath)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fileDirectoryPath = JNIEnv.GetString (native_fileDirectoryPath, JniHandleOwnership.DoNotTransfer);
			__this.LoadFiles (fileDirectoryPath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='loadFiles' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadFiles", "(Ljava/lang/String;)V", "GetLoadFiles_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadFiles (string fileDirectoryPath)
		{
			const string __id = "loadFiles.(Ljava/lang/String;)V";
			IntPtr native_fileDirectoryPath = JNIEnv.NewString (fileDirectoryPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileDirectoryPath);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileDirectoryPath);
			}
		}

		static Delegate cb_parseBySAX_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetParseBySAX_Ljava_io_InputStream_Handler ()
		{
			if (cb_parseBySAX_Ljava_io_InputStream_ == null)
				cb_parseBySAX_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseBySAX_Ljava_io_InputStream_);
			return cb_parseBySAX_Ljava_io_InputStream_;
		}

		static void n_ParseBySAX_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_istream)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream istream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_istream, JniHandleOwnership.DoNotTransfer);
			__this.ParseBySAX (istream);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='parseBySAX' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("parseBySAX", "(Ljava/io/InputStream;)V", "GetParseBySAX_Ljava_io_InputStream_Handler")]
		public virtual unsafe void ParseBySAX (global::System.IO.Stream istream)
		{
			const string __id = "parseBySAX.(Ljava/io/InputStream;)V";
			IntPtr native_istream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (istream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_istream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_istream);
			}
		}

		static Delegate cb_parseByXmlPullParser_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetParseByXmlPullParser_Ljava_io_InputStream_Handler ()
		{
			if (cb_parseByXmlPullParser_Ljava_io_InputStream_ == null)
				cb_parseByXmlPullParser_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseByXmlPullParser_Ljava_io_InputStream_);
			return cb_parseByXmlPullParser_Ljava_io_InputStream_;
		}

		static void n_ParseByXmlPullParser_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_istream)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream istream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_istream, JniHandleOwnership.DoNotTransfer);
			__this.ParseByXmlPullParser (istream);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='parseByXmlPullParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("parseByXmlPullParser", "(Ljava/io/InputStream;)V", "GetParseByXmlPullParser_Ljava_io_InputStream_Handler")]
		public virtual unsafe void ParseByXmlPullParser (global::System.IO.Stream istream)
		{
			const string __id = "parseByXmlPullParser.(Ljava/io/InputStream;)V";
			IntPtr native_istream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (istream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_istream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_istream);
			}
		}

		static Delegate cb_print;
#pragma warning disable 0169
		static Delegate GetPrintHandler ()
		{
			if (cb_print == null)
				cb_print = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Print);
			return cb_print;
		}

		static void n_Print (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Metadata.MetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.MetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Print ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/class[@name='MetadataCtrl']/method[@name='print' and count(parameter)=0]"
		[Register ("print", "()V", "GetPrintHandler")]
		public virtual unsafe void Print ()
		{
			const string __id = "print.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
