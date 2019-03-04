using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Metadata {

	// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']"
	[Register ("kr/neolab/sdk/metadata/IMetadataCtrl", "", "KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker")]
	public partial interface IMetadataCtrl : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='findApplicableSymbol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findApplicableSymbol", "(Ljava/lang/String;)Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbol_Ljava_lang_String_Handler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		global::KR.Neolab.Sdk.Metadata.Structure.Symbol FindApplicableSymbol (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='findApplicableSymbols' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("findApplicableSymbols", "(II)[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbols_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='findApplicableSymbols' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("findApplicableSymbols", "(IIFF)[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbols_IIFFHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (int p0, int p1, float p2, float p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='findApplicableSymbols' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.ink.structure.Stroke']]"
		[Register ("findApplicableSymbols", "(Lkr/neolab/sdk/ink/structure/Stroke;)[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetFindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_Handler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (global::KR.Neolab.Sdk.Ink.Structure.Stroke p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getExtraInfo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getExtraInfo", "(I)Ljava/lang/String;", "GetGetExtraInfo_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		string GetExtraInfo (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getKind' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getKind", "(I)I", "GetGetKind_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		int GetKind (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getNoteTypeList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNoteTypeList", "(I)Ljava/util/ArrayList;", "GetGetNoteTypeList_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		global::System.Collections.Generic.IList<global::Java.Lang.Integer> GetNoteTypeList (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getOwnerCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOwnerCode", "(I)I", "GetGetOwnerCode_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		int GetOwnerCode (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageHeight' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageHeight", "(II)F", "GetGetPageHeight_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageHeight (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageHeightWithMargin' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageHeightWithMargin", "(II)F", "GetGetPageHeightWithMargin_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageHeightWithMargin (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageMarginBottom' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginBottom", "(II)F", "GetGetPageMarginBottom_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageMarginBottom (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageMarginLeft' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginLeft", "(II)F", "GetGetPageMarginLeft_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageMarginLeft (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageMarginRight' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginRight", "(II)F", "GetGetPageMarginRight_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageMarginRight (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageMarginTop' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageMarginTop", "(II)F", "GetGetPageMarginTop_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageMarginTop (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageWidth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageWidth", "(II)F", "GetGetPageWidth_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageWidth (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getPageWidthWithMargin' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getPageWidthWithMargin", "(II)F", "GetGetPageWidthWithMargin_IIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		float GetPageWidthWithMargin (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getSectionCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSectionCode", "(I)I", "GetGetSectionCode_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		int GetSectionCode (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getSegments' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getSegments", "(III)[Lkr/neolab/sdk/metadata/structure/Segment;", "GetGetSegments_IIIHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		global::KR.Neolab.Sdk.Metadata.Structure.Segment[] GetSegments (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getStartPage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStartPage", "(I)I", "GetGetStartPage_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		int GetStartPage (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getSymbols' and count(parameter)=0]"
		[Register ("getSymbols", "()[Lkr/neolab/sdk/metadata/structure/Symbol;", "GetGetSymbolsHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] GetSymbols ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTitle", "(I)Ljava/lang/String;", "GetGetTitle_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		string GetTitle (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='getTotalPages' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTotalPages", "(I)I", "GetGetTotalPages_IHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		int GetTotalPages (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='loadFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("loadFile", "(Ljava/io/File;)V", "GetLoadFile_Ljava_io_File_Handler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		void LoadFile (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='loadFiles' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadFiles", "(Ljava/lang/String;)V", "GetLoadFiles_Ljava_lang_String_Handler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		void LoadFiles (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='parseBySAX' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("parseBySAX", "(Ljava/io/InputStream;)V", "GetParseBySAX_Ljava_io_InputStream_Handler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		void ParseBySAX (global::System.IO.Stream p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='parseByXmlPullParser' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("parseByXmlPullParser", "(Ljava/io/InputStream;)V", "GetParseByXmlPullParser_Ljava_io_InputStream_Handler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		void ParseByXmlPullParser (global::System.IO.Stream p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.metadata']/interface[@name='IMetadataCtrl']/method[@name='print' and count(parameter)=0]"
		[Register ("print", "()V", "GetPrintHandler:KR.Neolab.Sdk.Metadata.IMetadataCtrlInvoker, NASDK2.0Binding")]
		void Print ();

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/metadata/IMetadataCtrl", DoNotGenerateAcw=true)]
	internal class IMetadataCtrlInvoker : global::Java.Lang.Object, IMetadataCtrl {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/metadata/IMetadataCtrl", typeof (IMetadataCtrlInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMetadataCtrl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetadataCtrl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.metadata.IMetadataCtrl"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetadataCtrlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_findApplicableSymbol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbol_Ljava_lang_String_Handler ()
		{
			if (cb_findApplicableSymbol_Ljava_lang_String_ == null)
				cb_findApplicableSymbol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindApplicableSymbol_Ljava_lang_String_);
			return cb_findApplicableSymbol_Ljava_lang_String_;
		}

		static IntPtr n_FindApplicableSymbol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindApplicableSymbol (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_findApplicableSymbol_Ljava_lang_String_;
		public unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol FindApplicableSymbol (string p0)
		{
			if (id_findApplicableSymbol_Ljava_lang_String_ == IntPtr.Zero)
				id_findApplicableSymbol_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "findApplicableSymbol", "(Ljava/lang/String;)Lkr/neolab/sdk/metadata/structure/Symbol;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol __ret = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.Structure.Symbol> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findApplicableSymbol_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_findApplicableSymbols_II;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbols_IIHandler ()
		{
			if (cb_findApplicableSymbols_II == null)
				cb_findApplicableSymbols_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FindApplicableSymbols_II);
			return cb_findApplicableSymbols_II;
		}

		static IntPtr n_FindApplicableSymbols_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.FindApplicableSymbols (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_findApplicableSymbols_II;
		public unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (int p0, int p1)
		{
			if (id_findApplicableSymbols_II == IntPtr.Zero)
				id_findApplicableSymbols_II = JNIEnv.GetMethodID (class_ref, "findApplicableSymbols", "(II)[Lkr/neolab/sdk/metadata/structure/Symbol;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findApplicableSymbols_II, __args), JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
		}

		static Delegate cb_findApplicableSymbols_IIFF;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbols_IIFFHandler ()
		{
			if (cb_findApplicableSymbols_IIFF == null)
				cb_findApplicableSymbols_IIFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float, float, IntPtr>) n_FindApplicableSymbols_IIFF);
			return cb_findApplicableSymbols_IIFF;
		}

		static IntPtr n_FindApplicableSymbols_IIFF (IntPtr jnienv, IntPtr native__this, int p0, int p1, float p2, float p3)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.FindApplicableSymbols (p0, p1, p2, p3));
		}
#pragma warning restore 0169

		IntPtr id_findApplicableSymbols_IIFF;
		public unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (int p0, int p1, float p2, float p3)
		{
			if (id_findApplicableSymbols_IIFF == IntPtr.Zero)
				id_findApplicableSymbols_IIFF = JNIEnv.GetMethodID (class_ref, "findApplicableSymbols", "(IIFF)[Lkr/neolab/sdk/metadata/structure/Symbol;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			return (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findApplicableSymbols_IIFF, __args), JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
		}

		static Delegate cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_;
#pragma warning disable 0169
		static Delegate GetFindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_Handler ()
		{
			if (cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ == null)
				cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_);
			return cb_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_;
		}

		static IntPtr n_FindApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Ink.Structure.Stroke p0 = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.FindApplicableSymbols (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_;
		public unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] FindApplicableSymbols (global::KR.Neolab.Sdk.Ink.Structure.Stroke p0)
		{
			if (id_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ == IntPtr.Zero)
				id_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_ = JNIEnv.GetMethodID (class_ref, "findApplicableSymbols", "(Lkr/neolab/sdk/ink/structure/Stroke;)[Lkr/neolab/sdk/metadata/structure/Symbol;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] __ret = (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_findApplicableSymbols_Lkr_neolab_sdk_ink_structure_Stroke_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
			return __ret;
		}

		static Delegate cb_getExtraInfo_I;
#pragma warning disable 0169
		static Delegate GetGetExtraInfo_IHandler ()
		{
			if (cb_getExtraInfo_I == null)
				cb_getExtraInfo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetExtraInfo_I);
			return cb_getExtraInfo_I;
		}

		static IntPtr n_GetExtraInfo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetExtraInfo (p0));
		}
#pragma warning restore 0169

		IntPtr id_getExtraInfo_I;
		public unsafe string GetExtraInfo (int p0)
		{
			if (id_getExtraInfo_I == IntPtr.Zero)
				id_getExtraInfo_I = JNIEnv.GetMethodID (class_ref, "getExtraInfo", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraInfo_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getKind_I;
#pragma warning disable 0169
		static Delegate GetGetKind_IHandler ()
		{
			if (cb_getKind_I == null)
				cb_getKind_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetKind_I);
			return cb_getKind_I;
		}

		static int n_GetKind_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetKind (p0);
		}
#pragma warning restore 0169

		IntPtr id_getKind_I;
		public unsafe int GetKind (int p0)
		{
			if (id_getKind_I == IntPtr.Zero)
				id_getKind_I = JNIEnv.GetMethodID (class_ref, "getKind", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKind_I, __args);
		}

		static Delegate cb_getNoteTypeList_I;
#pragma warning disable 0169
		static Delegate GetGetNoteTypeList_IHandler ()
		{
			if (cb_getNoteTypeList_I == null)
				cb_getNoteTypeList_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetNoteTypeList_I);
			return cb_getNoteTypeList_I;
		}

		static IntPtr n_GetNoteTypeList_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.GetNoteTypeList (p0));
		}
#pragma warning restore 0169

		IntPtr id_getNoteTypeList_I;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> GetNoteTypeList (int p0)
		{
			if (id_getNoteTypeList_I == IntPtr.Zero)
				id_getNoteTypeList_I = JNIEnv.GetMethodID (class_ref, "getNoteTypeList", "(I)Ljava/util/ArrayList;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNoteTypeList_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getOwnerCode_I;
#pragma warning disable 0169
		static Delegate GetGetOwnerCode_IHandler ()
		{
			if (cb_getOwnerCode_I == null)
				cb_getOwnerCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetOwnerCode_I);
			return cb_getOwnerCode_I;
		}

		static int n_GetOwnerCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOwnerCode (p0);
		}
#pragma warning restore 0169

		IntPtr id_getOwnerCode_I;
		public unsafe int GetOwnerCode (int p0)
		{
			if (id_getOwnerCode_I == IntPtr.Zero)
				id_getOwnerCode_I = JNIEnv.GetMethodID (class_ref, "getOwnerCode", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOwnerCode_I, __args);
		}

		static Delegate cb_getPageHeight_II;
#pragma warning disable 0169
		static Delegate GetGetPageHeight_IIHandler ()
		{
			if (cb_getPageHeight_II == null)
				cb_getPageHeight_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageHeight_II);
			return cb_getPageHeight_II;
		}

		static float n_GetPageHeight_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageHeight (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageHeight_II;
		public unsafe float GetPageHeight (int p0, int p1)
		{
			if (id_getPageHeight_II == IntPtr.Zero)
				id_getPageHeight_II = JNIEnv.GetMethodID (class_ref, "getPageHeight", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageHeight_II, __args);
		}

		static Delegate cb_getPageHeightWithMargin_II;
#pragma warning disable 0169
		static Delegate GetGetPageHeightWithMargin_IIHandler ()
		{
			if (cb_getPageHeightWithMargin_II == null)
				cb_getPageHeightWithMargin_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageHeightWithMargin_II);
			return cb_getPageHeightWithMargin_II;
		}

		static float n_GetPageHeightWithMargin_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageHeightWithMargin (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageHeightWithMargin_II;
		public unsafe float GetPageHeightWithMargin (int p0, int p1)
		{
			if (id_getPageHeightWithMargin_II == IntPtr.Zero)
				id_getPageHeightWithMargin_II = JNIEnv.GetMethodID (class_ref, "getPageHeightWithMargin", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageHeightWithMargin_II, __args);
		}

		static Delegate cb_getPageMarginBottom_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginBottom_IIHandler ()
		{
			if (cb_getPageMarginBottom_II == null)
				cb_getPageMarginBottom_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginBottom_II);
			return cb_getPageMarginBottom_II;
		}

		static float n_GetPageMarginBottom_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginBottom (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageMarginBottom_II;
		public unsafe float GetPageMarginBottom (int p0, int p1)
		{
			if (id_getPageMarginBottom_II == IntPtr.Zero)
				id_getPageMarginBottom_II = JNIEnv.GetMethodID (class_ref, "getPageMarginBottom", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageMarginBottom_II, __args);
		}

		static Delegate cb_getPageMarginLeft_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginLeft_IIHandler ()
		{
			if (cb_getPageMarginLeft_II == null)
				cb_getPageMarginLeft_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginLeft_II);
			return cb_getPageMarginLeft_II;
		}

		static float n_GetPageMarginLeft_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginLeft (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageMarginLeft_II;
		public unsafe float GetPageMarginLeft (int p0, int p1)
		{
			if (id_getPageMarginLeft_II == IntPtr.Zero)
				id_getPageMarginLeft_II = JNIEnv.GetMethodID (class_ref, "getPageMarginLeft", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageMarginLeft_II, __args);
		}

		static Delegate cb_getPageMarginRight_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginRight_IIHandler ()
		{
			if (cb_getPageMarginRight_II == null)
				cb_getPageMarginRight_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginRight_II);
			return cb_getPageMarginRight_II;
		}

		static float n_GetPageMarginRight_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginRight (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageMarginRight_II;
		public unsafe float GetPageMarginRight (int p0, int p1)
		{
			if (id_getPageMarginRight_II == IntPtr.Zero)
				id_getPageMarginRight_II = JNIEnv.GetMethodID (class_ref, "getPageMarginRight", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageMarginRight_II, __args);
		}

		static Delegate cb_getPageMarginTop_II;
#pragma warning disable 0169
		static Delegate GetGetPageMarginTop_IIHandler ()
		{
			if (cb_getPageMarginTop_II == null)
				cb_getPageMarginTop_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageMarginTop_II);
			return cb_getPageMarginTop_II;
		}

		static float n_GetPageMarginTop_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageMarginTop (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageMarginTop_II;
		public unsafe float GetPageMarginTop (int p0, int p1)
		{
			if (id_getPageMarginTop_II == IntPtr.Zero)
				id_getPageMarginTop_II = JNIEnv.GetMethodID (class_ref, "getPageMarginTop", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageMarginTop_II, __args);
		}

		static Delegate cb_getPageWidth_II;
#pragma warning disable 0169
		static Delegate GetGetPageWidth_IIHandler ()
		{
			if (cb_getPageWidth_II == null)
				cb_getPageWidth_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageWidth_II);
			return cb_getPageWidth_II;
		}

		static float n_GetPageWidth_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidth (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageWidth_II;
		public unsafe float GetPageWidth (int p0, int p1)
		{
			if (id_getPageWidth_II == IntPtr.Zero)
				id_getPageWidth_II = JNIEnv.GetMethodID (class_ref, "getPageWidth", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageWidth_II, __args);
		}

		static Delegate cb_getPageWidthWithMargin_II;
#pragma warning disable 0169
		static Delegate GetGetPageWidthWithMargin_IIHandler ()
		{
			if (cb_getPageWidthWithMargin_II == null)
				cb_getPageWidthWithMargin_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, float>) n_GetPageWidthWithMargin_II);
			return cb_getPageWidthWithMargin_II;
		}

		static float n_GetPageWidthWithMargin_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPageWidthWithMargin (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPageWidthWithMargin_II;
		public unsafe float GetPageWidthWithMargin (int p0, int p1)
		{
			if (id_getPageWidthWithMargin_II == IntPtr.Zero)
				id_getPageWidthWithMargin_II = JNIEnv.GetMethodID (class_ref, "getPageWidthWithMargin", "(II)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPageWidthWithMargin_II, __args);
		}

		static Delegate cb_getSectionCode_I;
#pragma warning disable 0169
		static Delegate GetGetSectionCode_IHandler ()
		{
			if (cb_getSectionCode_I == null)
				cb_getSectionCode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetSectionCode_I);
			return cb_getSectionCode_I;
		}

		static int n_GetSectionCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSectionCode (p0);
		}
#pragma warning restore 0169

		IntPtr id_getSectionCode_I;
		public unsafe int GetSectionCode (int p0)
		{
			if (id_getSectionCode_I == IntPtr.Zero)
				id_getSectionCode_I = JNIEnv.GetMethodID (class_ref, "getSectionCode", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSectionCode_I, __args);
		}

		static Delegate cb_getSegments_III;
#pragma warning disable 0169
		static Delegate GetGetSegments_IIIHandler ()
		{
			if (cb_getSegments_III == null)
				cb_getSegments_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetSegments_III);
			return cb_getSegments_III;
		}

		static IntPtr n_GetSegments_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSegments (p0, p1, p2));
		}
#pragma warning restore 0169

		IntPtr id_getSegments_III;
		public unsafe global::KR.Neolab.Sdk.Metadata.Structure.Segment[] GetSegments (int p0, int p1, int p2)
		{
			if (id_getSegments_III == IntPtr.Zero)
				id_getSegments_III = JNIEnv.GetMethodID (class_ref, "getSegments", "(III)[Lkr/neolab/sdk/metadata/structure/Segment;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return (global::KR.Neolab.Sdk.Metadata.Structure.Segment[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSegments_III, __args), JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Segment));
		}

		static Delegate cb_getStartPage_I;
#pragma warning disable 0169
		static Delegate GetGetStartPage_IHandler ()
		{
			if (cb_getStartPage_I == null)
				cb_getStartPage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetStartPage_I);
			return cb_getStartPage_I;
		}

		static int n_GetStartPage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStartPage (p0);
		}
#pragma warning restore 0169

		IntPtr id_getStartPage_I;
		public unsafe int GetStartPage (int p0)
		{
			if (id_getStartPage_I == IntPtr.Zero)
				id_getStartPage_I = JNIEnv.GetMethodID (class_ref, "getStartPage", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStartPage_I, __args);
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
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSymbols ());
		}
#pragma warning restore 0169

		IntPtr id_getSymbols;
		public unsafe global::KR.Neolab.Sdk.Metadata.Structure.Symbol[] GetSymbols ()
		{
			if (id_getSymbols == IntPtr.Zero)
				id_getSymbols = JNIEnv.GetMethodID (class_ref, "getSymbols", "()[Lkr/neolab/sdk/metadata/structure/Symbol;");
			return (global::KR.Neolab.Sdk.Metadata.Structure.Symbol[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSymbols), JniHandleOwnership.TransferLocalRef, typeof (global::KR.Neolab.Sdk.Metadata.Structure.Symbol));
		}

		static Delegate cb_getTitle_I;
#pragma warning disable 0169
		static Delegate GetGetTitle_IHandler ()
		{
			if (cb_getTitle_I == null)
				cb_getTitle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTitle_I);
			return cb_getTitle_I;
		}

		static IntPtr n_GetTitle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetTitle (p0));
		}
#pragma warning restore 0169

		IntPtr id_getTitle_I;
		public unsafe string GetTitle (int p0)
		{
			if (id_getTitle_I == IntPtr.Zero)
				id_getTitle_I = JNIEnv.GetMethodID (class_ref, "getTitle", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getTotalPages_I;
#pragma warning disable 0169
		static Delegate GetGetTotalPages_IHandler ()
		{
			if (cb_getTotalPages_I == null)
				cb_getTotalPages_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetTotalPages_I);
			return cb_getTotalPages_I;
		}

		static int n_GetTotalPages_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTotalPages (p0);
		}
#pragma warning restore 0169

		IntPtr id_getTotalPages_I;
		public unsafe int GetTotalPages (int p0)
		{
			if (id_getTotalPages_I == IntPtr.Zero)
				id_getTotalPages_I = JNIEnv.GetMethodID (class_ref, "getTotalPages", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalPages_I, __args);
		}

		static Delegate cb_loadFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetLoadFile_Ljava_io_File_Handler ()
		{
			if (cb_loadFile_Ljava_io_File_ == null)
				cb_loadFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadFile_Ljava_io_File_);
			return cb_loadFile_Ljava_io_File_;
		}

		static void n_LoadFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadFile (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadFile_Ljava_io_File_;
		public unsafe void LoadFile (global::Java.IO.File p0)
		{
			if (id_loadFile_Ljava_io_File_ == IntPtr.Zero)
				id_loadFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "loadFile", "(Ljava/io/File;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadFile_Ljava_io_File_, __args);
		}

		static Delegate cb_loadFiles_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadFiles_Ljava_lang_String_Handler ()
		{
			if (cb_loadFiles_Ljava_lang_String_ == null)
				cb_loadFiles_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadFiles_Ljava_lang_String_);
			return cb_loadFiles_Ljava_lang_String_;
		}

		static void n_LoadFiles_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadFiles (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadFiles_Ljava_lang_String_;
		public unsafe void LoadFiles (string p0)
		{
			if (id_loadFiles_Ljava_lang_String_ == IntPtr.Zero)
				id_loadFiles_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadFiles", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadFiles_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_parseBySAX_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetParseBySAX_Ljava_io_InputStream_Handler ()
		{
			if (cb_parseBySAX_Ljava_io_InputStream_ == null)
				cb_parseBySAX_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseBySAX_Ljava_io_InputStream_);
			return cb_parseBySAX_Ljava_io_InputStream_;
		}

		static void n_ParseBySAX_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParseBySAX (p0);
		}
#pragma warning restore 0169

		IntPtr id_parseBySAX_Ljava_io_InputStream_;
		public unsafe void ParseBySAX (global::System.IO.Stream p0)
		{
			if (id_parseBySAX_Ljava_io_InputStream_ == IntPtr.Zero)
				id_parseBySAX_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "parseBySAX", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseBySAX_Ljava_io_InputStream_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_parseByXmlPullParser_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetParseByXmlPullParser_Ljava_io_InputStream_Handler ()
		{
			if (cb_parseByXmlPullParser_Ljava_io_InputStream_ == null)
				cb_parseByXmlPullParser_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseByXmlPullParser_Ljava_io_InputStream_);
			return cb_parseByXmlPullParser_Ljava_io_InputStream_;
		}

		static void n_ParseByXmlPullParser_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParseByXmlPullParser (p0);
		}
#pragma warning restore 0169

		IntPtr id_parseByXmlPullParser_Ljava_io_InputStream_;
		public unsafe void ParseByXmlPullParser (global::System.IO.Stream p0)
		{
			if (id_parseByXmlPullParser_Ljava_io_InputStream_ == IntPtr.Zero)
				id_parseByXmlPullParser_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "parseByXmlPullParser", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseByXmlPullParser_Ljava_io_InputStream_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::KR.Neolab.Sdk.Metadata.IMetadataCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Metadata.IMetadataCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Print ();
		}
#pragma warning restore 0169

		IntPtr id_print;
		public unsafe void Print ()
		{
			if (id_print == IntPtr.Zero)
				id_print = JNIEnv.GetMethodID (class_ref, "print", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_print);
		}

	}

}
