using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/CMD", DoNotGenerateAcw=true)]
	public partial class CMD : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_AlarmResponse']"
		[Register ("A_AlarmResponse")]
		public const int AAlarmResponse = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_AutoPowerOnResponse']"
		[Register ("A_AutoPowerOnResponse")]
		public const int AAutoPowerOnResponse = (int) 43;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_AutoShutdownTimeResponse']"
		[Register ("A_AutoShutdownTimeResponse")]
		public const int AAutoShutdownTimeResponse = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_BeepSetResponse']"
		[Register ("A_BeepSetResponse")]
		public const int ABeepSetResponse = (int) 47;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_DotData']"
		[Register ("A_DotData")]
		public const int ADotData = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_DotIDChange']"
		[Register ("A_DotIDChange")]
		public const int ADotIDChange = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_DotIDChange32']"
		[Register ("A_DotIDChange32")]
		public const int ADotIDChange32 = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_DotUpDownData']"
		[Register ("A_DotUpDownData")]
		public const int ADotUpDownData = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_DotUpDownDataNew']"
		[Register ("A_DotUpDownDataNew")]
		public const int ADotUpDownDataNew = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_Echo']"
		[Register ("A_Echo")]
		public const int AEcho = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_ForceCalibrateResponse']"
		[Register ("A_ForceCalibrateResponse")]
		public const int AForceCalibrateResponse = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_OfflineChunk']"
		[Register ("A_OfflineChunk")]
		public const int AOfflineChunk = (int) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_OfflineDataInfo']"
		[Register ("A_OfflineDataInfo")]
		public const int AOfflineDataInfo = (int) 73;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_OfflineDataRemoveResponse']"
		[Register ("A_OfflineDataRemoveResponse")]
		public const int AOfflineDataRemoveResponse = (int) 75;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_OfflineInfo']"
		[Register ("A_OfflineInfo")]
		public const int AOfflineInfo = (int) 65;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_OfflineNoteListResponse']"
		[Register ("A_OfflineNoteListResponse")]
		public const int AOfflineNoteListResponse = (int) 70;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_OfflineResultResponse']"
		[Register ("A_OfflineResultResponse")]
		public const int AOfflineResultResponse = (int) 72;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PasswordRequest']"
		[Register ("A_PasswordRequest")]
		public const int APasswordRequest = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PasswordSetResponse']"
		[Register ("A_PasswordSetResponse")]
		public const int APasswordSetResponse = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenColorSetResponse']"
		[Register ("A_PenColorSetResponse")]
		public const int APenColorSetResponse = (int) 41;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenDebug']"
		[Register ("A_PenDebug")]
		public const int APenDebug = (int) 229;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenOnState']"
		[Register ("A_PenOnState")]
		public const int APenOnState = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenSWUpgradeRequest']"
		[Register ("A_PenSWUpgradeRequest")]
		public const int APenSWUpgradeRequest = (int) 82;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenSWUpgradeStatus']"
		[Register ("A_PenSWUpgradeStatus")]
		public const int APenSWUpgradeStatus = (int) 84;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenSensitivityResponse']"
		[Register ("A_PenSensitivityResponse")]
		public const int APenSensitivityResponse = (int) 45;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenStatusResponse']"
		[Register ("A_PenStatusResponse")]
		public const int APenStatusResponse = (int) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_PenStatusSetupResponse']"
		[Register ("A_PenStatusSetupResponse")]
		public const int APenStatusSetupResponse = (int) 39;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_RTCsetResponse']"
		[Register ("A_RTCsetResponse")]
		public const int ARTCsetResponse = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='A_UsingNoteNotifyResponse']"
		[Register ("A_UsingNoteNotifyResponse")]
		public const int AUsingNoteNotifyResponse = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_Alarmset']"
		[Register ("P_Alarmset")]
		public const int PAlarmset = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_AutoPowerOnSet']"
		[Register ("P_AutoPowerOnSet")]
		public const int PAutoPowerOnSet = (int) 42;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_AutoShutdownTime']"
		[Register ("P_AutoShutdownTime")]
		public const int PAutoShutdownTime = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_BeepSet']"
		[Register ("P_BeepSet")]
		public const int PBeepSet = (int) 46;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_DotUpDownResponse']"
		[Register ("P_DotUpDownResponse")]
		public const int PDotUpDownResponse = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_EchoResponse']"
		[Register ("P_EchoResponse")]
		public const int PEchoResponse = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_ForceCalibrate']"
		[Register ("P_ForceCalibrate")]
		public const int PForceCalibrate = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_OfflineChunkResponse']"
		[Register ("P_OfflineChunkResponse")]
		public const int POfflineChunkResponse = (int) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_OfflineDataRemove']"
		[Register ("P_OfflineDataRemove")]
		public const int POfflineDataRemove = (int) 74;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_OfflineDataRequest']"
		[Register ("P_OfflineDataRequest")]
		public const int POfflineDataRequest = (int) 71;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_OfflineInfoResponse']"
		[Register ("P_OfflineInfoResponse")]
		public const int POfflineInfoResponse = (int) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_OfflineNoteList']"
		[Register ("P_OfflineNoteList")]
		public const int POfflineNoteList = (int) 69;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PasswordResponse']"
		[Register ("P_PasswordResponse")]
		public const int PPasswordResponse = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PasswordSet']"
		[Register ("P_PasswordSet")]
		public const int PPasswordSet = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PenColorSet']"
		[Register ("P_PenColorSet")]
		public const int PPenColorSet = (int) 40;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PenOnResponse']"
		[Register ("P_PenOnResponse")]
		public const int PPenOnResponse = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PenSWUpgradeCommand']"
		[Register ("P_PenSWUpgradeCommand")]
		public const int PPenSWUpgradeCommand = (int) 81;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PenSWUpgradeResponse']"
		[Register ("P_PenSWUpgradeResponse")]
		public const int PPenSWUpgradeResponse = (int) 83;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PenSensitivity']"
		[Register ("P_PenSensitivity")]
		public const int PPenSensitivity = (int) 44;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PenStatusRequest']"
		[Register ("P_PenStatusRequest")]
		public const int PPenStatusRequest = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_PenStatusSetup']"
		[Register ("P_PenStatusSetup")]
		public const int PPenStatusSetup = (int) 38;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_RTCset']"
		[Register ("P_RTCset")]
		public const int PRTCset = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_ShowText']"
		[Register ("P_ShowText")]
		public const int PShowText = (int) 97;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/field[@name='P_UsingNoteNotify']"
		[Register ("P_UsingNoteNotify")]
		public const int PUsingNoteNotify = (int) 11;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/CMD", typeof (CMD));
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

		protected CMD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD']/constructor[@name='CMD' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CMD ()
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
