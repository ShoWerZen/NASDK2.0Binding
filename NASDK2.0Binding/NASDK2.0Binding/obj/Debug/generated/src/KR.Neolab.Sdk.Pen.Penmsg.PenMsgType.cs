using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Penmsg {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/penmsg/PenMsgType", DoNotGenerateAcw=true)]
	public partial class PenMsgType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='EVENT_LOW_BATTERY']"
		[Register ("EVENT_LOW_BATTERY")]
		public const int EventLowBattery = (int) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='EVENT_POWER_OFF']"
		[Register ("EVENT_POWER_OFF")]
		public const int EventPowerOff = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_FILE_CREATED']"
		[Register ("OFFLINE_DATA_FILE_CREATED")]
		public const int OfflineDataFileCreated = (int) 53;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_FILE_DELETED']"
		[Register ("OFFLINE_DATA_FILE_DELETED")]
		public const int OfflineDataFileDeleted = (int) 54;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_NOTE_LIST']"
		[Register ("OFFLINE_DATA_NOTE_LIST")]
		public const int OfflineDataNoteList = (int) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_PAGE_LIST']"
		[Register ("OFFLINE_DATA_PAGE_LIST")]
		public const int OfflineDataPageList = (int) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_SEND_FAILURE']"
		[Register ("OFFLINE_DATA_SEND_FAILURE")]
		public const int OfflineDataSendFailure = (int) 52;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_SEND_START']"
		[Register ("OFFLINE_DATA_SEND_START")]
		public const int OfflineDataSendStart = (int) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_SEND_STATUS']"
		[Register ("OFFLINE_DATA_SEND_STATUS")]
		public const int OfflineDataSendStatus = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='OFFLINE_DATA_SEND_SUCCESS']"
		[Register ("OFFLINE_DATA_SEND_SUCCESS")]
		public const int OfflineDataSendSuccess = (int) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PASSWORD_REQUEST']"
		[Register ("PASSWORD_REQUEST")]
		public const int PasswordRequest = (int) 81;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PASSWORD_SETUP_FAILURE']"
		[Register ("PASSWORD_SETUP_FAILURE")]
		public const int PasswordSetupFailure = (int) 83;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PASSWORD_SETUP_SUCCESS']"
		[Register ("PASSWORD_SETUP_SUCCESS")]
		public const int PasswordSetupSuccess = (int) 82;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_ACTION_GESTURE']"
		[Register ("PEN_ACTION_GESTURE")]
		public const int PenActionGesture = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_ALREADY_CONNECTED']"
		[Register ("PEN_ALREADY_CONNECTED")]
		public const int PenAlreadyConnected = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_AUTHORIZED']"
		[Register ("PEN_AUTHORIZED")]
		public const int PenAuthorized = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_CALIBRATION_FINISH']"
		[Register ("PEN_CALIBRATION_FINISH")]
		[Obsolete ("deprecated")]
		public const int PenCalibrationFinish = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_CALIBRATION_START']"
		[Register ("PEN_CALIBRATION_START")]
		[Obsolete ("deprecated")]
		public const int PenCalibrationStart = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_CONNECTION_FAILURE']"
		[Register ("PEN_CONNECTION_FAILURE")]
		public const int PenConnectionFailure = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_CONNECTION_FAILURE_BTDUPLICATE']"
		[Register ("PEN_CONNECTION_FAILURE_BTDUPLICATE")]
		public const int PenConnectionFailureBtduplicate = (int) 84;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_CONNECTION_SUCCESS']"
		[Register ("PEN_CONNECTION_SUCCESS")]
		public const int PenConnectionSuccess = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_CONNECTION_TRY']"
		[Register ("PEN_CONNECTION_TRY")]
		public const int PenConnectionTry = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_DISCONNECTED']"
		[Register ("PEN_DISCONNECTED")]
		public const int PenDisconnected = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_FW_UPGRADE_FAILURE']"
		[Register ("PEN_FW_UPGRADE_FAILURE")]
		public const int PenFwUpgradeFailure = (int) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_FW_UPGRADE_STATUS']"
		[Register ("PEN_FW_UPGRADE_STATUS")]
		public const int PenFwUpgradeStatus = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_FW_UPGRADE_SUCCESS']"
		[Register ("PEN_FW_UPGRADE_SUCCESS")]
		public const int PenFwUpgradeSuccess = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_FW_UPGRADE_SUSPEND']"
		[Register ("PEN_FW_UPGRADE_SUSPEND")]
		public const int PenFwUpgradeSuspend = (int) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_FW_VERSION']"
		[Register ("PEN_FW_VERSION")]
		public const int PenFwVersion = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_AUTO_POWER_ON_RESULT']"
		[Register ("PEN_SETUP_AUTO_POWER_ON_RESULT")]
		public const int PenSetupAutoPowerOnResult = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_AUTO_SHUTDOWN_RESULT']"
		[Register ("PEN_SETUP_AUTO_SHUTDOWN_RESULT")]
		public const int PenSetupAutoShutdownResult = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_BEEP_RESULT']"
		[Register ("PEN_SETUP_BEEP_RESULT")]
		public const int PenSetupBeepResult = (int) 23;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_FAILURE']"
		[Register ("PEN_SETUP_FAILURE")]
		public const int PenSetupFailure = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_HOVER_ONOFF']"
		[Register ("PEN_SETUP_HOVER_ONOFF")]
		public const int PenSetupHoverOnoff = (int) 97;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_OFFLINEDATA_SAVE_ONOFF']"
		[Register ("PEN_SETUP_OFFLINEDATA_SAVE_ONOFF")]
		public const int PenSetupOfflinedataSaveOnoff = (int) 98;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_PEN_CAP_OFF']"
		[Register ("PEN_SETUP_PEN_CAP_OFF")]
		public const int PenSetupPenCapOff = (int) 96;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_PEN_COLOR_RESULT']"
		[Register ("PEN_SETUP_PEN_COLOR_RESULT")]
		public const int PenSetupPenColorResult = (int) 24;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_SENSITIVITY_RESULT']"
		[Register ("PEN_SETUP_SENSITIVITY_RESULT")]
		public const int PenSetupSensitivityResult = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_SETUP_SUCCESS']"
		[Register ("PEN_SETUP_SUCCESS")]
		public const int PenSetupSuccess = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/field[@name='PEN_STATUS']"
		[Register ("PEN_STATUS")]
		public const int PenStatus = (int) 17;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/penmsg/PenMsgType", typeof (PenMsgType));
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

		protected PenMsgType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.penmsg']/class[@name='PenMsgType']/constructor[@name='PenMsgType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PenMsgType ()
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
