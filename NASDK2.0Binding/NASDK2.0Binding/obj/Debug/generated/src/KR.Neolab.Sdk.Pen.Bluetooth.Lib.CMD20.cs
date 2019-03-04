using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Lib {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/lib/CMD20", DoNotGenerateAcw=true)]
	public partial class CMD20 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='ACK_OfflineChunk']"
		[Register ("ACK_OfflineChunk")]
		public const int ACKOfflineChunk = (int) 164;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='ACK_UploadPenFWChunk']"
		[Register ("ACK_UploadPenFWChunk")]
		public const int ACKUploadPenFWChunk = (int) 178;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_OfflineDataRequest']"
		[Register ("REQ_OfflineDataRequest")]
		public const int REQOfflineDataRequest = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_OfflineNoteList']"
		[Register ("REQ_OfflineNoteList")]
		public const int REQOfflineNoteList = (int) 33;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_OfflineNoteRemove']"
		[Register ("REQ_OfflineNoteRemove")]
		public const int REQOfflineNoteRemove = (int) 37;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_OfflinePageList']"
		[Register ("REQ_OfflinePageList")]
		public const int REQOfflinePageList = (int) 34;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_Password']"
		[Register ("REQ_Password")]
		public const int REQPassword = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PasswordSet']"
		[Register ("REQ_PasswordSet")]
		public const int REQPasswordSet = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenFWUpgrade']"
		[Register ("REQ_PenFWUpgrade")]
		public const int REQPenFWUpgrade = (int) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenInfo']"
		[Register ("REQ_PenInfo")]
		public const int REQPenInfo = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatus']"
		[Register ("REQ_PenStatus")]
		public const int REQPenStatus = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange']"
		[Register ("REQ_PenStatusChange")]
		public const int REQPenStatusChange = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_AutoPowerOnSet']"
		[Register ("REQ_PenStatusChange_TYPE_AutoPowerOnSet")]
		public const int REQPenStatusChangeTYPEAutoPowerOnSet = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_AutoShutdownTime']"
		[Register ("REQ_PenStatusChange_TYPE_AutoShutdownTime")]
		public const int REQPenStatusChangeTYPEAutoShutdownTime = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_BeepOnOff']"
		[Register ("REQ_PenStatusChange_TYPE_BeepOnOff")]
		public const int REQPenStatusChangeTYPEBeepOnOff = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_CurrentTimeSet']"
		[Register ("REQ_PenStatusChange_TYPE_CurrentTimeSet")]
		public const int REQPenStatusChangeTYPECurrentTimeSet = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_HoverOnOff']"
		[Register ("REQ_PenStatusChange_TYPE_HoverOnOff")]
		public const int REQPenStatusChangeTYPEHoverOnOff = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_LEDColorSet']"
		[Register ("REQ_PenStatusChange_TYPE_LEDColorSet")]
		public const int REQPenStatusChangeTYPELEDColorSet = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_OfflineDataSaveOnOff']"
		[Register ("REQ_PenStatusChange_TYPE_OfflineDataSaveOnOff")]
		public const int REQPenStatusChangeTYPEOfflineDataSaveOnOff = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_PenCapOnOff']"
		[Register ("REQ_PenStatusChange_TYPE_PenCapOnOff")]
		public const int REQPenStatusChangeTYPEPenCapOnOff = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_PenStatusChange_TYPE_SensitivitySet']"
		[Register ("REQ_PenStatusChange_TYPE_SensitivitySet")]
		public const int REQPenStatusChangeTYPESensitivitySet = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='REQ_UsingNoteNotify']"
		[Register ("REQ_UsingNoteNotify")]
		public const int REQUsingNoteNotify = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_EventBattery']"
		[Register ("RES_EventBattery")]
		public const int RESEventBattery = (int) 97;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_EventDotData']"
		[Register ("RES_EventDotData")]
		public const int RESEventDotData = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_EventIdChange']"
		[Register ("RES_EventIdChange")]
		public const int RESEventIdChange = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_EventPenUpDown']"
		[Register ("RES_EventPenUpDown")]
		public const int RESEventPenUpDown = (int) 99;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_EventPowerOff']"
		[Register ("RES_EventPowerOff")]
		public const int RESEventPowerOff = (int) 98;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_EventUploadPenFWChunk']"
		[Register ("RES_EventUploadPenFWChunk")]
		public const int RESEventUploadPenFWChunk = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_OfflineChunk']"
		[Register ("RES_OfflineChunk")]
		public const int RESOfflineChunk = (int) 36;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_OfflineDataRequest']"
		[Register ("RES_OfflineDataRequest")]
		public const int RESOfflineDataRequest = (int) 163;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_OfflineNoteList']"
		[Register ("RES_OfflineNoteList")]
		public const int RESOfflineNoteList = (int) 161;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_OfflineNoteRemove']"
		[Register ("RES_OfflineNoteRemove")]
		public const int RESOfflineNoteRemove = (int) 165;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_OfflinePageList']"
		[Register ("RES_OfflinePageList")]
		public const int RESOfflinePageList = (int) 162;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_Password']"
		[Register ("RES_Password")]
		public const int RESPassword = (int) 130;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_PasswordSet']"
		[Register ("RES_PasswordSet")]
		public const int RESPasswordSet = (int) 131;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_PenFWUpgrade']"
		[Register ("RES_PenFWUpgrade")]
		public const int RESPenFWUpgrade = (int) 177;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_PenInfo']"
		[Register ("RES_PenInfo")]
		public const int RESPenInfo = (int) 129;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_PenStatus']"
		[Register ("RES_PenStatus")]
		public const int RESPenStatus = (int) 132;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_PenStatusChange']"
		[Register ("RES_PenStatusChange")]
		public const int RESPenStatusChange = (int) 133;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/field[@name='RES_UsingNoteNotify']"
		[Register ("RES_UsingNoteNotify")]
		public const int RESUsingNoteNotify = (int) 145;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/lib/CMD20", typeof (CMD20));
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

		protected CMD20 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/constructor[@name='CMD20' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CMD20 ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/method[@name='isEventCMD' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isEventCMD", "(B)Z", "")]
		public static unsafe bool IsEventCMD (sbyte cmd)
		{
			const string __id = "isEventCMD.(B)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cmd);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.lib']/class[@name='CMD20']/method[@name='isEventCMD' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isEventCMD", "(I)Z", "")]
		public static unsafe bool IsEventCMD (int cmd)
		{
			const string __id = "isEventCMD.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cmd);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
