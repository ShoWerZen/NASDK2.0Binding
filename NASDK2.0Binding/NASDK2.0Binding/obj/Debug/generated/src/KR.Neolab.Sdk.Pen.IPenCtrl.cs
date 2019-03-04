using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen {

	// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']"
	[Register ("kr/neolab/sdk/pen/IPenCtrl", "", "KR.Neolab.Sdk.Pen.IPenCtrlInvoker")]
	public partial interface IPenCtrl : IJavaObject {

		string ConnectedDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='getConnectedDevice' and count(parameter)=0]"
			[Register ("getConnectedDevice", "()Ljava/lang/String;", "GetGetConnectedDeviceHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")] get;
		}

		global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;", "GetGetListenerHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IPenMsgListener']]"
			[Register ("setListener", "(Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;)V", "GetSetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")] set;
		}

		global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener OffLineDataListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='getOffLineDataListener' and count(parameter)=0]"
			[Register ("getOffLineDataListener", "()Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;", "GetGetOffLineDataListenerHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='setOffLineDataListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IOfflineDataListener']]"
			[Register ("setOffLineDataListener", "(Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;)V", "GetSetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")] set;
		}

		int ProtocolVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='getProtocolVersion' and count(parameter)=0]"
			[Register ("getProtocolVersion", "()I", "GetGetProtocolVersionHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")] get;
		}

		string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='calibratePen' and count(parameter)=0]"
		[Register ("calibratePen", "()V", "GetCalibratePenHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void CalibratePen ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/String;)V", "GetConnect_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void Connect (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='inputPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("inputPassword", "(Ljava/lang/String;)V", "GetInputPassword_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void InputPassword (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='isAvailableDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAvailableDevice", "(Ljava/lang/String;)Z", "GetIsAvailableDevice_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		bool IsAvailableDevice (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='registerBroadcastBTDuplicate' and count(parameter)=0]"
		[Register ("registerBroadcastBTDuplicate", "()V", "GetRegisterBroadcastBTDuplicateHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void RegisterBroadcastBTDuplicate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='removeOfflineData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
[Obsolete (@"deprecated")]
		[Register ("removeOfflineData", "(II)V", "GetRemoveOfflineData_IIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void RemoveOfflineData (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='removeOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("removeOfflineData", "(II[I)V", "GetRemoveOfflineData_IIarrayIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void RemoveOfflineData (int p0, int p1, int[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqAddUsingNote", "(II)V", "GetReqAddUsingNote_IIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqAddUsingNote (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("reqAddUsingNote", "(II[I)V", "GetReqAddUsingNote_IIarrayIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqAddUsingNote (int p0, int p1, int[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("reqAddUsingNote", "([I[I)V", "GetReqAddUsingNote_arrayIarrayIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqAddUsingNote (int[] p0, int[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqAddUsingNote' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;kr.neolab.sdk.util.UseNoteData&gt;']]"
		[Register ("reqAddUsingNote", "(Ljava/util/ArrayList;)V", "GetReqAddUsingNote_Ljava_util_ArrayList_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqAddUsingNote (global::System.Collections.Generic.IList<global::KR.Neolab.Sdk.Util.UseNoteData> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqAddUsingNoteAll' and count(parameter)=0]"
		[Register ("reqAddUsingNoteAll", "()V", "GetReqAddUsingNoteAllHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqAddUsingNoteAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reqOfflineData", "(III)V", "GetReqOfflineData_IIIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqOfflineData (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqOfflineData' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]']]"
		[Register ("reqOfflineData", "(III[I)V", "GetReqOfflineData_IIIarrayIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqOfflineData (int p0, int p1, int p2, int[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqOfflineDataList' and count(parameter)=0]"
		[Register ("reqOfflineDataList", "()V", "GetReqOfflineDataListHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqOfflineDataList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqOfflineDataList' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqOfflineDataList", "(II)V", "GetReqOfflineDataList_IIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqOfflineDataList (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqOfflineDataPageList' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reqOfflineDataPageList", "(III)V", "GetReqOfflineDataPageList_IIIHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqOfflineDataPageList (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqPenStatus' and count(parameter)=0]"
		[Register ("reqPenStatus", "()V", "GetReqPenStatusHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqPenStatus ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetUpPasswordOff' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reqSetUpPasswordOff", "(Ljava/lang/String;)V", "GetReqSetUpPasswordOff_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetUpPasswordOff (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupAutoPowerOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupAutoPowerOnOff", "(Z)V", "GetReqSetupAutoPowerOnOff_ZHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupAutoPowerOnOff (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupAutoShutdownTime' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetupAutoShutdownTime", "(S)V", "GetReqSetupAutoShutdownTime_SHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupAutoShutdownTime (short p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqSetupPassword", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReqSetupPassword_Ljava_lang_String_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupPassword (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupPenBeepOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupPenBeepOnOff", "(Z)V", "GetReqSetupPenBeepOnOff_ZHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupPenBeepOnOff (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupPenCapOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupPenCapOff", "(Z)V", "GetReqSetupPenCapOff_ZHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupPenCapOff (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupPenHover' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqSetupPenHover", "(Z)V", "GetReqSetupPenHover_ZHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupPenHover (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupPenSensitivity' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetupPenSensitivity", "(S)V", "GetReqSetupPenSensitivity_SHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupPenSensitivity (short p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='reqSetupPenTipColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reqSetupPenTipColor", "(I)V", "GetReqSetupPenTipColor_IHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void ReqSetupPenTipColor (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='setAllowOfflineData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowOfflineData", "(Z)V", "GetSetAllowOfflineData_ZHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void SetAllowOfflineData (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void SetContext (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='setDotListener' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.penmsg.IPenDotListener']]"
		[Register ("setDotListener", "(Lkr/neolab/sdk/pen/penmsg/IPenDotListener;)V", "GetSetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void SetDotListener (global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='setOfflineDataLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOfflineDataLocation", "(Ljava/lang/String;)V", "GetSetOfflineDataLocation_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void SetOfflineDataLocation (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='startup' and count(parameter)=0]"
		[Register ("startup", "()V", "GetStartupHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void Startup ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='suspendPenUpgrade' and count(parameter)=0]"
		[Register ("suspendPenUpgrade", "()V", "GetSuspendPenUpgradeHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void SuspendPenUpgrade ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='unregisterBroadcastBTDuplicate' and count(parameter)=0]"
		[Register ("unregisterBroadcastBTDuplicate", "()V", "GetUnregisterBroadcastBTDuplicateHandler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void UnregisterBroadcastBTDuplicate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='upgradePen' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
[Obsolete (@"deprecated")]
		[Register ("upgradePen", "(Ljava/io/File;)V", "GetUpgradePen_Ljava_io_File_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void UpgradePen (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='upgradePen' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("upgradePen", "(Ljava/io/File;Ljava/lang/String;)V", "GetUpgradePen_Ljava_io_File_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void UpgradePen (global::Java.IO.File p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen']/interface[@name='IPenCtrl']/method[@name='upgradePen2' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("upgradePen2", "(Ljava/io/File;Ljava/lang/String;)V", "GetUpgradePen2_Ljava_io_File_Ljava_lang_String_Handler:KR.Neolab.Sdk.Pen.IPenCtrlInvoker, NASDK2.0Binding")]
		void UpgradePen2 (global::Java.IO.File p0, string p1);

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/IPenCtrl", DoNotGenerateAcw=true)]
	internal class IPenCtrlInvoker : global::Java.Lang.Object, IPenCtrl {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/IPenCtrl", typeof (IPenCtrlInvoker));

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

		public static IPenCtrl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPenCtrl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.IPenCtrl"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPenCtrlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getConnectedDevice;
#pragma warning disable 0169
		static Delegate GetGetConnectedDeviceHandler ()
		{
			if (cb_getConnectedDevice == null)
				cb_getConnectedDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedDevice);
			return cb_getConnectedDevice;
		}

		static IntPtr n_GetConnectedDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConnectedDevice);
		}
#pragma warning restore 0169

		IntPtr id_getConnectedDevice;
		public unsafe string ConnectedDevice {
			get {
				if (id_getConnectedDevice == IntPtr.Zero)
					id_getConnectedDevice = JNIEnv.GetMethodID (class_ref, "getConnectedDevice", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectedDevice), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_Handler ()
		{
			if (cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ == null)
				cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_);
			return cb_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_;
		}

		static void n_SetListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener p0 = (global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Listener = p0;
		}
#pragma warning restore 0169

		IntPtr id_getListener;
		IntPtr id_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_;
		public unsafe global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener Listener {
			get {
				if (id_getListener == IntPtr.Zero)
					id_getListener = JNIEnv.GetMethodID (class_ref, "getListener", "()Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;");
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenMsgListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListener), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ == IntPtr.Zero)
					id_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lkr/neolab/sdk/pen/penmsg/IPenMsgListener;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lkr_neolab_sdk_pen_penmsg_IPenMsgListener_, __args);
			}
		}

		static Delegate cb_getOffLineDataListener;
#pragma warning disable 0169
		static Delegate GetGetOffLineDataListenerHandler ()
		{
			if (cb_getOffLineDataListener == null)
				cb_getOffLineDataListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffLineDataListener);
			return cb_getOffLineDataListener;
		}

		static IntPtr n_GetOffLineDataListener (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OffLineDataListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_;
#pragma warning disable 0169
		static Delegate GetSetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_Handler ()
		{
			if (cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ == null)
				cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_);
			return cb_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_;
		}

		static void n_SetOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener p0 = (global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OffLineDataListener = p0;
		}
#pragma warning restore 0169

		IntPtr id_getOffLineDataListener;
		IntPtr id_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_;
		public unsafe global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener OffLineDataListener {
			get {
				if (id_getOffLineDataListener == IntPtr.Zero)
					id_getOffLineDataListener = JNIEnv.GetMethodID (class_ref, "getOffLineDataListener", "()Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;");
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IOfflineDataListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOffLineDataListener), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ == IntPtr.Zero)
					id_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_ = JNIEnv.GetMethodID (class_ref, "setOffLineDataListener", "(Lkr/neolab/sdk/pen/penmsg/IOfflineDataListener;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOffLineDataListener_Lkr_neolab_sdk_pen_penmsg_IOfflineDataListener_, __args);
			}
		}

		static Delegate cb_getProtocolVersion;
#pragma warning disable 0169
		static Delegate GetGetProtocolVersionHandler ()
		{
			if (cb_getProtocolVersion == null)
				cb_getProtocolVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProtocolVersion);
			return cb_getProtocolVersion;
		}

		static int n_GetProtocolVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProtocolVersion;
		}
#pragma warning restore 0169

		IntPtr id_getProtocolVersion;
		public unsafe int ProtocolVersion {
			get {
				if (id_getProtocolVersion == IntPtr.Zero)
					id_getProtocolVersion = JNIEnv.GetMethodID (class_ref, "getProtocolVersion", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getProtocolVersion);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		public unsafe string Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_calibratePen;
#pragma warning disable 0169
		static Delegate GetCalibratePenHandler ()
		{
			if (cb_calibratePen == null)
				cb_calibratePen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalibratePen);
			return cb_calibratePen;
		}

		static void n_CalibratePen (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalibratePen ();
		}
#pragma warning restore 0169

		IntPtr id_calibratePen;
		public unsafe void CalibratePen ()
		{
			if (id_calibratePen == IntPtr.Zero)
				id_calibratePen = JNIEnv.GetMethodID (class_ref, "calibratePen", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calibratePen);
		}

		static Delegate cb_connect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Handler ()
		{
			if (cb_connect_Ljava_lang_String_ == null)
				cb_connect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_String_);
			return cb_connect_Ljava_lang_String_;
		}

		static void n_Connect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		IntPtr id_connect_Ljava_lang_String_;
		public unsafe void Connect (string p0)
		{
			if (id_connect_Ljava_lang_String_ == IntPtr.Zero)
				id_connect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
		}

		static Delegate cb_inputPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInputPassword_Ljava_lang_String_Handler ()
		{
			if (cb_inputPassword_Ljava_lang_String_ == null)
				cb_inputPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InputPassword_Ljava_lang_String_);
			return cb_inputPassword_Ljava_lang_String_;
		}

		static void n_InputPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InputPassword (p0);
		}
#pragma warning restore 0169

		IntPtr id_inputPassword_Ljava_lang_String_;
		public unsafe void InputPassword (string p0)
		{
			if (id_inputPassword_Ljava_lang_String_ == IntPtr.Zero)
				id_inputPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "inputPassword", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inputPassword_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_isAvailableDevice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsAvailableDevice_Ljava_lang_String_Handler ()
		{
			if (cb_isAvailableDevice_Ljava_lang_String_ == null)
				cb_isAvailableDevice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAvailableDevice_Ljava_lang_String_);
			return cb_isAvailableDevice_Ljava_lang_String_;
		}

		static bool n_IsAvailableDevice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAvailableDevice (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isAvailableDevice_Ljava_lang_String_;
		public unsafe bool IsAvailableDevice (string p0)
		{
			if (id_isAvailableDevice_Ljava_lang_String_ == IntPtr.Zero)
				id_isAvailableDevice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isAvailableDevice", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAvailableDevice_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_registerBroadcastBTDuplicate;
#pragma warning disable 0169
		static Delegate GetRegisterBroadcastBTDuplicateHandler ()
		{
			if (cb_registerBroadcastBTDuplicate == null)
				cb_registerBroadcastBTDuplicate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterBroadcastBTDuplicate);
			return cb_registerBroadcastBTDuplicate;
		}

		static void n_RegisterBroadcastBTDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterBroadcastBTDuplicate ();
		}
#pragma warning restore 0169

		IntPtr id_registerBroadcastBTDuplicate;
		public unsafe void RegisterBroadcastBTDuplicate ()
		{
			if (id_registerBroadcastBTDuplicate == IntPtr.Zero)
				id_registerBroadcastBTDuplicate = JNIEnv.GetMethodID (class_ref, "registerBroadcastBTDuplicate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerBroadcastBTDuplicate);
		}

		static Delegate cb_removeOfflineData_II;
#pragma warning disable 0169
		static Delegate GetRemoveOfflineData_IIHandler ()
		{
			if (cb_removeOfflineData_II == null)
				cb_removeOfflineData_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_RemoveOfflineData_II);
			return cb_removeOfflineData_II;
		}

		static void n_RemoveOfflineData_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOfflineData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeOfflineData_II;
		public unsafe void RemoveOfflineData (int p0, int p1)
		{
			if (id_removeOfflineData_II == IntPtr.Zero)
				id_removeOfflineData_II = JNIEnv.GetMethodID (class_ref, "removeOfflineData", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOfflineData_II, __args);
		}

		static Delegate cb_removeOfflineData_IIarrayI;
#pragma warning disable 0169
		static Delegate GetRemoveOfflineData_IIarrayIHandler ()
		{
			if (cb_removeOfflineData_IIarrayI == null)
				cb_removeOfflineData_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_RemoveOfflineData_IIarrayI);
			return cb_removeOfflineData_IIarrayI;
		}

		static void n_RemoveOfflineData_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.RemoveOfflineData (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_removeOfflineData_IIarrayI;
		public unsafe void RemoveOfflineData (int p0, int p1, int[] p2)
		{
			if (id_removeOfflineData_IIarrayI == IntPtr.Zero)
				id_removeOfflineData_IIarrayI = JNIEnv.GetMethodID (class_ref, "removeOfflineData", "(II[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOfflineData_IIarrayI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_reqAddUsingNote_II;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_IIHandler ()
		{
			if (cb_reqAddUsingNote_II == null)
				cb_reqAddUsingNote_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ReqAddUsingNote_II);
			return cb_reqAddUsingNote_II;
		}

		static void n_ReqAddUsingNote_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_reqAddUsingNote_II;
		public unsafe void ReqAddUsingNote (int p0, int p1)
		{
			if (id_reqAddUsingNote_II == IntPtr.Zero)
				id_reqAddUsingNote_II = JNIEnv.GetMethodID (class_ref, "reqAddUsingNote", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqAddUsingNote_II, __args);
		}

		static Delegate cb_reqAddUsingNote_IIarrayI;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_IIarrayIHandler ()
		{
			if (cb_reqAddUsingNote_IIarrayI == null)
				cb_reqAddUsingNote_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ReqAddUsingNote_IIarrayI);
			return cb_reqAddUsingNote_IIarrayI;
		}

		static void n_ReqAddUsingNote_IIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_reqAddUsingNote_IIarrayI;
		public unsafe void ReqAddUsingNote (int p0, int p1, int[] p2)
		{
			if (id_reqAddUsingNote_IIarrayI == IntPtr.Zero)
				id_reqAddUsingNote_IIarrayI = JNIEnv.GetMethodID (class_ref, "reqAddUsingNote", "(II[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqAddUsingNote_IIarrayI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_reqAddUsingNote_arrayIarrayI;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_arrayIarrayIHandler ()
		{
			if (cb_reqAddUsingNote_arrayIarrayI == null)
				cb_reqAddUsingNote_arrayIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqAddUsingNote_arrayIarrayI);
			return cb_reqAddUsingNote_arrayIarrayI;
		}

		static void n_ReqAddUsingNote_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_reqAddUsingNote_arrayIarrayI;
		public unsafe void ReqAddUsingNote (int[] p0, int[] p1)
		{
			if (id_reqAddUsingNote_arrayIarrayI == IntPtr.Zero)
				id_reqAddUsingNote_arrayIarrayI = JNIEnv.GetMethodID (class_ref, "reqAddUsingNote", "([I[I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqAddUsingNote_arrayIarrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_reqAddUsingNote_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_Ljava_util_ArrayList_Handler ()
		{
			if (cb_reqAddUsingNote_Ljava_util_ArrayList_ == null)
				cb_reqAddUsingNote_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReqAddUsingNote_Ljava_util_ArrayList_);
			return cb_reqAddUsingNote_Ljava_util_ArrayList_;
		}

		static void n_ReqAddUsingNote_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Util.UseNoteData>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqAddUsingNote_Ljava_util_ArrayList_;
		public unsafe void ReqAddUsingNote (global::System.Collections.Generic.IList<global::KR.Neolab.Sdk.Util.UseNoteData> p0)
		{
			if (id_reqAddUsingNote_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_reqAddUsingNote_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "reqAddUsingNote", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Util.UseNoteData>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqAddUsingNote_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_reqAddUsingNoteAll;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNoteAllHandler ()
		{
			if (cb_reqAddUsingNoteAll == null)
				cb_reqAddUsingNoteAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqAddUsingNoteAll);
			return cb_reqAddUsingNoteAll;
		}

		static void n_ReqAddUsingNoteAll (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNoteAll ();
		}
#pragma warning restore 0169

		IntPtr id_reqAddUsingNoteAll;
		public unsafe void ReqAddUsingNoteAll ()
		{
			if (id_reqAddUsingNoteAll == IntPtr.Zero)
				id_reqAddUsingNoteAll = JNIEnv.GetMethodID (class_ref, "reqAddUsingNoteAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqAddUsingNoteAll);
		}

		static Delegate cb_reqOfflineData_III;
#pragma warning disable 0169
		static Delegate GetReqOfflineData_IIIHandler ()
		{
			if (cb_reqOfflineData_III == null)
				cb_reqOfflineData_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ReqOfflineData_III);
			return cb_reqOfflineData_III;
		}

		static void n_ReqOfflineData_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_reqOfflineData_III;
		public unsafe void ReqOfflineData (int p0, int p1, int p2)
		{
			if (id_reqOfflineData_III == IntPtr.Zero)
				id_reqOfflineData_III = JNIEnv.GetMethodID (class_ref, "reqOfflineData", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqOfflineData_III, __args);
		}

		static Delegate cb_reqOfflineData_IIIarrayI;
#pragma warning disable 0169
		static Delegate GetReqOfflineData_IIIarrayIHandler ()
		{
			if (cb_reqOfflineData_IIIarrayI == null)
				cb_reqOfflineData_IIIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, IntPtr>) n_ReqOfflineData_IIIarrayI);
			return cb_reqOfflineData_IIIarrayI;
		}

		static void n_ReqOfflineData_IIIarrayI (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqOfflineData (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_reqOfflineData_IIIarrayI;
		public unsafe void ReqOfflineData (int p0, int p1, int p2, int[] p3)
		{
			if (id_reqOfflineData_IIIarrayI == IntPtr.Zero)
				id_reqOfflineData_IIIarrayI = JNIEnv.GetMethodID (class_ref, "reqOfflineData", "(III[I)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqOfflineData_IIIarrayI, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_reqOfflineDataList;
#pragma warning disable 0169
		static Delegate GetReqOfflineDataListHandler ()
		{
			if (cb_reqOfflineDataList == null)
				cb_reqOfflineDataList = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqOfflineDataList);
			return cb_reqOfflineDataList;
		}

		static void n_ReqOfflineDataList (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList ();
		}
#pragma warning restore 0169

		IntPtr id_reqOfflineDataList;
		public unsafe void ReqOfflineDataList ()
		{
			if (id_reqOfflineDataList == IntPtr.Zero)
				id_reqOfflineDataList = JNIEnv.GetMethodID (class_ref, "reqOfflineDataList", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqOfflineDataList);
		}

		static Delegate cb_reqOfflineDataList_II;
#pragma warning disable 0169
		static Delegate GetReqOfflineDataList_IIHandler ()
		{
			if (cb_reqOfflineDataList_II == null)
				cb_reqOfflineDataList_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ReqOfflineDataList_II);
			return cb_reqOfflineDataList_II;
		}

		static void n_ReqOfflineDataList_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_reqOfflineDataList_II;
		public unsafe void ReqOfflineDataList (int p0, int p1)
		{
			if (id_reqOfflineDataList_II == IntPtr.Zero)
				id_reqOfflineDataList_II = JNIEnv.GetMethodID (class_ref, "reqOfflineDataList", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqOfflineDataList_II, __args);
		}

		static Delegate cb_reqOfflineDataPageList_III;
#pragma warning disable 0169
		static Delegate GetReqOfflineDataPageList_IIIHandler ()
		{
			if (cb_reqOfflineDataPageList_III == null)
				cb_reqOfflineDataPageList_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ReqOfflineDataPageList_III);
			return cb_reqOfflineDataPageList_III;
		}

		static void n_ReqOfflineDataPageList_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataPageList (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_reqOfflineDataPageList_III;
		public unsafe void ReqOfflineDataPageList (int p0, int p1, int p2)
		{
			if (id_reqOfflineDataPageList_III == IntPtr.Zero)
				id_reqOfflineDataPageList_III = JNIEnv.GetMethodID (class_ref, "reqOfflineDataPageList", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqOfflineDataPageList_III, __args);
		}

		static Delegate cb_reqPenStatus;
#pragma warning disable 0169
		static Delegate GetReqPenStatusHandler ()
		{
			if (cb_reqPenStatus == null)
				cb_reqPenStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqPenStatus);
			return cb_reqPenStatus;
		}

		static void n_ReqPenStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenStatus ();
		}
#pragma warning restore 0169

		IntPtr id_reqPenStatus;
		public unsafe void ReqPenStatus ()
		{
			if (id_reqPenStatus == IntPtr.Zero)
				id_reqPenStatus = JNIEnv.GetMethodID (class_ref, "reqPenStatus", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqPenStatus);
		}

		static Delegate cb_reqSetUpPasswordOff_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqSetUpPasswordOff_Ljava_lang_String_Handler ()
		{
			if (cb_reqSetUpPasswordOff_Ljava_lang_String_ == null)
				cb_reqSetUpPasswordOff_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReqSetUpPasswordOff_Ljava_lang_String_);
			return cb_reqSetUpPasswordOff_Ljava_lang_String_;
		}

		static void n_ReqSetUpPasswordOff_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetUpPasswordOff (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetUpPasswordOff_Ljava_lang_String_;
		public unsafe void ReqSetUpPasswordOff (string p0)
		{
			if (id_reqSetUpPasswordOff_Ljava_lang_String_ == IntPtr.Zero)
				id_reqSetUpPasswordOff_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reqSetUpPasswordOff", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetUpPasswordOff_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_reqSetupAutoPowerOnOff_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupAutoPowerOnOff_ZHandler ()
		{
			if (cb_reqSetupAutoPowerOnOff_Z == null)
				cb_reqSetupAutoPowerOnOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupAutoPowerOnOff_Z);
			return cb_reqSetupAutoPowerOnOff_Z;
		}

		static void n_ReqSetupAutoPowerOnOff_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupAutoPowerOnOff (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupAutoPowerOnOff_Z;
		public unsafe void ReqSetupAutoPowerOnOff (bool p0)
		{
			if (id_reqSetupAutoPowerOnOff_Z == IntPtr.Zero)
				id_reqSetupAutoPowerOnOff_Z = JNIEnv.GetMethodID (class_ref, "reqSetupAutoPowerOnOff", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupAutoPowerOnOff_Z, __args);
		}

		static Delegate cb_reqSetupAutoShutdownTime_S;
#pragma warning disable 0169
		static Delegate GetReqSetupAutoShutdownTime_SHandler ()
		{
			if (cb_reqSetupAutoShutdownTime_S == null)
				cb_reqSetupAutoShutdownTime_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetupAutoShutdownTime_S);
			return cb_reqSetupAutoShutdownTime_S;
		}

		static void n_ReqSetupAutoShutdownTime_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupAutoShutdownTime (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupAutoShutdownTime_S;
		public unsafe void ReqSetupAutoShutdownTime (short p0)
		{
			if (id_reqSetupAutoShutdownTime_S == IntPtr.Zero)
				id_reqSetupAutoShutdownTime_S = JNIEnv.GetMethodID (class_ref, "reqSetupAutoShutdownTime", "(S)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupAutoShutdownTime_S, __args);
		}

		static Delegate cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqSetupPassword_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqSetupPassword_Ljava_lang_String_Ljava_lang_String_);
			return cb_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ReqSetupPassword_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPassword (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void ReqSetupPassword (string p0, string p1)
		{
			if (id_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "reqSetupPassword", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupPassword_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_reqSetupPenBeepOnOff_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupPenBeepOnOff_ZHandler ()
		{
			if (cb_reqSetupPenBeepOnOff_Z == null)
				cb_reqSetupPenBeepOnOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupPenBeepOnOff_Z);
			return cb_reqSetupPenBeepOnOff_Z;
		}

		static void n_ReqSetupPenBeepOnOff_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenBeepOnOff (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupPenBeepOnOff_Z;
		public unsafe void ReqSetupPenBeepOnOff (bool p0)
		{
			if (id_reqSetupPenBeepOnOff_Z == IntPtr.Zero)
				id_reqSetupPenBeepOnOff_Z = JNIEnv.GetMethodID (class_ref, "reqSetupPenBeepOnOff", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupPenBeepOnOff_Z, __args);
		}

		static Delegate cb_reqSetupPenCapOff_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupPenCapOff_ZHandler ()
		{
			if (cb_reqSetupPenCapOff_Z == null)
				cb_reqSetupPenCapOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupPenCapOff_Z);
			return cb_reqSetupPenCapOff_Z;
		}

		static void n_ReqSetupPenCapOff_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenCapOff (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupPenCapOff_Z;
		public unsafe void ReqSetupPenCapOff (bool p0)
		{
			if (id_reqSetupPenCapOff_Z == IntPtr.Zero)
				id_reqSetupPenCapOff_Z = JNIEnv.GetMethodID (class_ref, "reqSetupPenCapOff", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupPenCapOff_Z, __args);
		}

		static Delegate cb_reqSetupPenHover_Z;
#pragma warning disable 0169
		static Delegate GetReqSetupPenHover_ZHandler ()
		{
			if (cb_reqSetupPenHover_Z == null)
				cb_reqSetupPenHover_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqSetupPenHover_Z);
			return cb_reqSetupPenHover_Z;
		}

		static void n_ReqSetupPenHover_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenHover (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupPenHover_Z;
		public unsafe void ReqSetupPenHover (bool p0)
		{
			if (id_reqSetupPenHover_Z == IntPtr.Zero)
				id_reqSetupPenHover_Z = JNIEnv.GetMethodID (class_ref, "reqSetupPenHover", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupPenHover_Z, __args);
		}

		static Delegate cb_reqSetupPenSensitivity_S;
#pragma warning disable 0169
		static Delegate GetReqSetupPenSensitivity_SHandler ()
		{
			if (cb_reqSetupPenSensitivity_S == null)
				cb_reqSetupPenSensitivity_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetupPenSensitivity_S);
			return cb_reqSetupPenSensitivity_S;
		}

		static void n_ReqSetupPenSensitivity_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenSensitivity (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupPenSensitivity_S;
		public unsafe void ReqSetupPenSensitivity (short p0)
		{
			if (id_reqSetupPenSensitivity_S == IntPtr.Zero)
				id_reqSetupPenSensitivity_S = JNIEnv.GetMethodID (class_ref, "reqSetupPenSensitivity", "(S)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupPenSensitivity_S, __args);
		}

		static Delegate cb_reqSetupPenTipColor_I;
#pragma warning disable 0169
		static Delegate GetReqSetupPenTipColor_IHandler ()
		{
			if (cb_reqSetupPenTipColor_I == null)
				cb_reqSetupPenTipColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ReqSetupPenTipColor_I);
			return cb_reqSetupPenTipColor_I;
		}

		static void n_ReqSetupPenTipColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenTipColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_reqSetupPenTipColor_I;
		public unsafe void ReqSetupPenTipColor (int p0)
		{
			if (id_reqSetupPenTipColor_I == IntPtr.Zero)
				id_reqSetupPenTipColor_I = JNIEnv.GetMethodID (class_ref, "reqSetupPenTipColor", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reqSetupPenTipColor_I, __args);
		}

		static Delegate cb_setAllowOfflineData_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowOfflineData_ZHandler ()
		{
			if (cb_setAllowOfflineData_Z == null)
				cb_setAllowOfflineData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowOfflineData_Z);
			return cb_setAllowOfflineData_Z;
		}

		static void n_SetAllowOfflineData_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowOfflineData (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAllowOfflineData_Z;
		public unsafe void SetAllowOfflineData (bool p0)
		{
			if (id_setAllowOfflineData_Z == IntPtr.Zero)
				id_setAllowOfflineData_Z = JNIEnv.GetMethodID (class_ref, "setAllowOfflineData", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAllowOfflineData_Z, __args);
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (p0);
		}
#pragma warning restore 0169

		IntPtr id_setContext_Landroid_content_Context_;
		public unsafe void SetContext (global::Android.Content.Context p0)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args);
		}

		static Delegate cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_;
#pragma warning disable 0169
		static Delegate GetSetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_Handler ()
		{
			if (cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ == null)
				cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_);
			return cb_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_;
		}

		static void n_SetDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener p0 = (global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener)global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDotListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_;
		public unsafe void SetDotListener (global::KR.Neolab.Sdk.Pen.Penmsg.IPenDotListener p0)
		{
			if (id_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ == IntPtr.Zero)
				id_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_ = JNIEnv.GetMethodID (class_ref, "setDotListener", "(Lkr/neolab/sdk/pen/penmsg/IPenDotListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDotListener_Lkr_neolab_sdk_pen_penmsg_IPenDotListener_, __args);
		}

		static Delegate cb_setOfflineDataLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOfflineDataLocation_Ljava_lang_String_Handler ()
		{
			if (cb_setOfflineDataLocation_Ljava_lang_String_ == null)
				cb_setOfflineDataLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOfflineDataLocation_Ljava_lang_String_);
			return cb_setOfflineDataLocation_Ljava_lang_String_;
		}

		static void n_SetOfflineDataLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOfflineDataLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOfflineDataLocation_Ljava_lang_String_;
		public unsafe void SetOfflineDataLocation (string p0)
		{
			if (id_setOfflineDataLocation_Ljava_lang_String_ == IntPtr.Zero)
				id_setOfflineDataLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOfflineDataLocation", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOfflineDataLocation_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_startup;
#pragma warning disable 0169
		static Delegate GetStartupHandler ()
		{
			if (cb_startup == null)
				cb_startup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Startup);
			return cb_startup;
		}

		static void n_Startup (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Startup ();
		}
#pragma warning restore 0169

		IntPtr id_startup;
		public unsafe void Startup ()
		{
			if (id_startup == IntPtr.Zero)
				id_startup = JNIEnv.GetMethodID (class_ref, "startup", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startup);
		}

		static Delegate cb_suspendPenUpgrade;
#pragma warning disable 0169
		static Delegate GetSuspendPenUpgradeHandler ()
		{
			if (cb_suspendPenUpgrade == null)
				cb_suspendPenUpgrade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SuspendPenUpgrade);
			return cb_suspendPenUpgrade;
		}

		static void n_SuspendPenUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SuspendPenUpgrade ();
		}
#pragma warning restore 0169

		IntPtr id_suspendPenUpgrade;
		public unsafe void SuspendPenUpgrade ()
		{
			if (id_suspendPenUpgrade == IntPtr.Zero)
				id_suspendPenUpgrade = JNIEnv.GetMethodID (class_ref, "suspendPenUpgrade", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_suspendPenUpgrade);
		}

		static Delegate cb_unregisterBroadcastBTDuplicate;
#pragma warning disable 0169
		static Delegate GetUnregisterBroadcastBTDuplicateHandler ()
		{
			if (cb_unregisterBroadcastBTDuplicate == null)
				cb_unregisterBroadcastBTDuplicate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterBroadcastBTDuplicate);
			return cb_unregisterBroadcastBTDuplicate;
		}

		static void n_UnregisterBroadcastBTDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterBroadcastBTDuplicate ();
		}
#pragma warning restore 0169

		IntPtr id_unregisterBroadcastBTDuplicate;
		public unsafe void UnregisterBroadcastBTDuplicate ()
		{
			if (id_unregisterBroadcastBTDuplicate == IntPtr.Zero)
				id_unregisterBroadcastBTDuplicate = JNIEnv.GetMethodID (class_ref, "unregisterBroadcastBTDuplicate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterBroadcastBTDuplicate);
		}

		static Delegate cb_upgradePen_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetUpgradePen_Ljava_io_File_Handler ()
		{
			if (cb_upgradePen_Ljava_io_File_ == null)
				cb_upgradePen_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpgradePen_Ljava_io_File_);
			return cb_upgradePen_Ljava_io_File_;
		}

		static void n_UpgradePen_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePen (p0);
		}
#pragma warning restore 0169

		IntPtr id_upgradePen_Ljava_io_File_;
		public unsafe void UpgradePen (global::Java.IO.File p0)
		{
			if (id_upgradePen_Ljava_io_File_ == IntPtr.Zero)
				id_upgradePen_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "upgradePen", "(Ljava/io/File;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upgradePen_Ljava_io_File_, __args);
		}

		static Delegate cb_upgradePen_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpgradePen_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_upgradePen_Ljava_io_File_Ljava_lang_String_ == null)
				cb_upgradePen_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpgradePen_Ljava_io_File_Ljava_lang_String_);
			return cb_upgradePen_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_UpgradePen_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePen (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_upgradePen_Ljava_io_File_Ljava_lang_String_;
		public unsafe void UpgradePen (global::Java.IO.File p0, string p1)
		{
			if (id_upgradePen_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_upgradePen_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "upgradePen", "(Ljava/io/File;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upgradePen_Ljava_io_File_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_upgradePen2_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpgradePen2_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_upgradePen2_Ljava_io_File_Ljava_lang_String_ == null)
				cb_upgradePen2_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpgradePen2_Ljava_io_File_Ljava_lang_String_);
			return cb_upgradePen2_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_UpgradePen2_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::KR.Neolab.Sdk.Pen.IPenCtrl __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.IPenCtrl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpgradePen2 (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_upgradePen2_Ljava_io_File_Ljava_lang_String_;
		public unsafe void UpgradePen2 (global::Java.IO.File p0, string p1)
		{
			if (id_upgradePen2_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_upgradePen2_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "upgradePen2", "(Ljava/io/File;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upgradePen2_Ljava_io_File_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
