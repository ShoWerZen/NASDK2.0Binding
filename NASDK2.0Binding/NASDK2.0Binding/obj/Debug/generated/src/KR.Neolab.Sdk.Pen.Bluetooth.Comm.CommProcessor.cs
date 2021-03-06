using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Comm {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/comm/CommProcessor", DoNotGenerateAcw=true)]
	public partial class CommProcessor : global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager, global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.ProtocolParser.IParsedPacketListener, global::KR.Neolab.Sdk.Pen.Filter.IFilterListener {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/field[@name='isUpgrading']"
		[Register ("isUpgrading")]
		public bool IsUpgrading {
			get {
				const string __id = "isUpgrading.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isUpgrading.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/field[@name='isUpgradingSuspended']"
		[Register ("isUpgradingSuspended")]
		public bool IsUpgradingSuspended {
			get {
				const string __id = "isUpgradingSuspended.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isUpgradingSuspended.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/field[@name='olFile']"
		[Register ("olFile")]
		public global::KR.Neolab.Sdk.Pen.Offline.OfflineFile OlFile {
			get {
				const string __id = "olFile.Lkr/neolab/sdk/pen/offline/OfflineFile;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Offline.OfflineFile> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "olFile.Lkr/neolab/sdk/pen/offline/OfflineFile;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/comm/CommProcessor", typeof (CommProcessor));
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

		protected CommProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/constructor[@name='CommProcessor' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.BTAdt.ConnectedThread']]"
		[Register (".ctor", "(Lkr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread;)V", "")]
		public unsafe CommProcessor (global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread conn)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lkr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getChunk;
#pragma warning disable 0169
		static Delegate GetGetChunkHandler ()
		{
			if (cb_getChunk == null)
				cb_getChunk = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChunk);
			return cb_getChunk;
		}

		static IntPtr n_GetChunk (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Chunk);
		}
#pragma warning restore 0169

		public virtual unsafe global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk Chunk {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='getChunk' and count(parameter)=0]"
			[Register ("getChunk", "()Lkr/neolab/sdk/pen/bluetooth/lib/Chunk;", "GetGetChunkHandler")]
			get {
				const string __id = "getChunk.()Lkr/neolab/sdk/pen/bluetooth/lib/Chunk;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConn;
#pragma warning disable 0169
		static Delegate GetGetConnHandler ()
		{
			if (cb_getConn == null)
				cb_getConn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConn);
			return cb_getConn;
		}

		static IntPtr n_GetConn (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Conn);
		}
#pragma warning restore 0169

		public override unsafe global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread Conn {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='getConn' and count(parameter)=0]"
			[Register ("getConn", "()Lkr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread;", "GetGetConnHandler")]
			get {
				const string __id = "getConn.()Lkr/neolab/sdk/pen/bluetooth/BTAdt$ConnectedThread;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.BTAdt.ConnectedThread> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkEstablish;
#pragma warning disable 0169
		static Delegate GetCheckEstablishHandler ()
		{
			if (cb_checkEstablish == null)
				cb_checkEstablish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckEstablish);
			return cb_checkEstablish;
		}

		static void n_CheckEstablish (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckEstablish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='checkEstablish' and count(parameter)=0]"
		[Register ("checkEstablish", "()V", "GetCheckEstablishHandler")]
		public virtual unsafe void CheckEstablish ()
		{
			const string __id = "checkEstablish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fill_arrayBI;
#pragma warning disable 0169
		static Delegate GetFill_arrayBIHandler ()
		{
			if (cb_fill_arrayBI == null)
				cb_fill_arrayBI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Fill_arrayBI);
			return cb_fill_arrayBI;
		}

		static void n_Fill_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int size)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Fill (data, size);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='fill' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fill", "([BI)V", "GetFill_arrayBIHandler")]
		public override unsafe void Fill (byte[] data, int size)
		{
			const string __id = "fill.([BI)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_finishUpgrade;
#pragma warning disable 0169
		static Delegate GetFinishUpgradeHandler ()
		{
			if (cb_finishUpgrade == null)
				cb_finishUpgrade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishUpgrade);
			return cb_finishUpgrade;
		}

		static void n_FinishUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishUpgrade ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='finishUpgrade' and count(parameter)=0]"
		[Register ("finishUpgrade", "()V", "GetFinishUpgradeHandler")]
		public override unsafe void FinishUpgrade ()
		{
			const string __id = "finishUpgrade.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_;
#pragma warning disable 0169
		static Delegate GetOnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_Handler ()
		{
			if (cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ == null)
				cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_);
			return cb_onCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_;
		}

		static void n_OnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packet)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet packet = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet> (native_packet, JniHandleOwnership.DoNotTransfer);
			__this.OnCreatePacket (packet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='onCreatePacket' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.Packet']]"
		[Register ("onCreatePacket", "(Lkr/neolab/sdk/pen/bluetooth/lib/Packet;)V", "GetOnCreatePacket_Lkr_neolab_sdk_pen_bluetooth_lib_Packet_Handler")]
		public virtual unsafe void OnCreatePacket (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Packet packet)
		{
			const string __id = "onCreatePacket.(Lkr/neolab/sdk/pen/bluetooth/lib/Packet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((packet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_;
#pragma warning disable 0169
		static Delegate GetOnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler ()
		{
			if (cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ == null)
				cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_);
			return cb_onFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_;
		}

		static void n_OnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dot)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Filter.Fdot dot = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Filter.Fdot> (native_dot, JniHandleOwnership.DoNotTransfer);
			__this.OnFilteredDot (dot);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='onFilteredDot' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.filter.Fdot']]"
		[Register ("onFilteredDot", "(Lkr/neolab/sdk/pen/filter/Fdot;)V", "GetOnFilteredDot_Lkr_neolab_sdk_pen_filter_Fdot_Handler")]
		public virtual unsafe void OnFilteredDot (global::KR.Neolab.Sdk.Pen.Filter.Fdot dot)
		{
			const string __id = "onFilteredDot.(Lkr/neolab/sdk/pen/filter/Fdot;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dot).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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

		static void n_ReqAddUsingNote_II (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNote (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqAddUsingNote", "(II)V", "GetReqAddUsingNote_IIHandler")]
		public override unsafe void ReqAddUsingNote (int sectionId, int ownerId)
		{
			const string __id = "reqAddUsingNote.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqAddUsingNote_IIarrayI;
#pragma warning disable 0169
		static Delegate GetReqAddUsingNote_IIarrayIHandler ()
		{
			if (cb_reqAddUsingNote_IIarrayI == null)
				cb_reqAddUsingNote_IIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ReqAddUsingNote_IIarrayI);
			return cb_reqAddUsingNote_IIarrayI;
		}

		static void n_ReqAddUsingNote_IIarrayI (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, IntPtr native_noteIds)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] noteIds = (int[]) JNIEnv.GetArray (native_noteIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (sectionId, ownerId, noteIds);
			if (noteIds != null)
				JNIEnv.CopyArray (noteIds, native_noteIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqAddUsingNote' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("reqAddUsingNote", "(II[I)V", "GetReqAddUsingNote_IIarrayIHandler")]
		public override unsafe void ReqAddUsingNote (int sectionId, int ownerId, int[] noteIds)
		{
			const string __id = "reqAddUsingNote.(II[I)V";
			IntPtr native_noteIds = JNIEnv.NewArray (noteIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (native_noteIds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (noteIds != null) {
					JNIEnv.CopyArray (native_noteIds, noteIds);
					JNIEnv.DeleteLocalRef (native_noteIds);
				}
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

		static void n_ReqAddUsingNote_arrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_sectionId, IntPtr native_ownerId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] sectionId = (int[]) JNIEnv.GetArray (native_sectionId, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] ownerId = (int[]) JNIEnv.GetArray (native_ownerId, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.ReqAddUsingNote (sectionId, ownerId);
			if (sectionId != null)
				JNIEnv.CopyArray (sectionId, native_sectionId);
			if (ownerId != null)
				JNIEnv.CopyArray (ownerId, native_ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqAddUsingNote' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int[]']]"
		[Register ("reqAddUsingNote", "([I[I)V", "GetReqAddUsingNote_arrayIarrayIHandler")]
		public override unsafe void ReqAddUsingNote (int[] sectionId, int[] ownerId)
		{
			const string __id = "reqAddUsingNote.([I[I)V";
			IntPtr native_sectionId = JNIEnv.NewArray (sectionId);
			IntPtr native_ownerId = JNIEnv.NewArray (ownerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sectionId);
				__args [1] = new JniArgumentValue (native_ownerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (sectionId != null) {
					JNIEnv.CopyArray (native_sectionId, sectionId);
					JNIEnv.DeleteLocalRef (native_sectionId);
				}
				if (ownerId != null) {
					JNIEnv.CopyArray (native_ownerId, ownerId);
					JNIEnv.DeleteLocalRef (native_ownerId);
				}
			}
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAddUsingNoteAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqAddUsingNoteAll' and count(parameter)=0]"
		[Register ("reqAddUsingNoteAll", "()V", "GetReqAddUsingNoteAllHandler")]
		public override unsafe void ReqAddUsingNoteAll ()
		{
			const string __id = "reqAddUsingNoteAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reqAutoPowerSetupOnOff_Z;
#pragma warning disable 0169
		static Delegate GetReqAutoPowerSetupOnOff_ZHandler ()
		{
			if (cb_reqAutoPowerSetupOnOff_Z == null)
				cb_reqAutoPowerSetupOnOff_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqAutoPowerSetupOnOff_Z);
			return cb_reqAutoPowerSetupOnOff_Z;
		}

		static void n_ReqAutoPowerSetupOnOff_Z (IntPtr jnienv, IntPtr native__this, bool isOn)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqAutoPowerSetupOnOff (isOn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqAutoPowerSetupOnOff' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqAutoPowerSetupOnOff", "(Z)V", "GetReqAutoPowerSetupOnOff_ZHandler")]
		public override unsafe void ReqAutoPowerSetupOnOff (bool isOn)
		{
			const string __id = "reqAutoPowerSetupOnOff.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isOn);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqForceCalibrate;
#pragma warning disable 0169
		static Delegate GetReqForceCalibrateHandler ()
		{
			if (cb_reqForceCalibrate == null)
				cb_reqForceCalibrate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqForceCalibrate);
			return cb_reqForceCalibrate;
		}

		static void n_ReqForceCalibrate (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqForceCalibrate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqForceCalibrate' and count(parameter)=0]"
		[Register ("reqForceCalibrate", "()V", "GetReqForceCalibrateHandler")]
		public override unsafe void ReqForceCalibrate ()
		{
			const string __id = "reqForceCalibrate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reqInputPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqInputPassword_Ljava_lang_String_Handler ()
		{
			if (cb_reqInputPassword_Ljava_lang_String_ == null)
				cb_reqInputPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReqInputPassword_Ljava_lang_String_);
			return cb_reqInputPassword_Ljava_lang_String_;
		}

		static void n_ReqInputPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_password)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
			__this.ReqInputPassword (password);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqInputPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("reqInputPassword", "(Ljava/lang/String;)V", "GetReqInputPassword_Ljava_lang_String_Handler")]
		public override unsafe void ReqInputPassword (string password)
		{
			const string __id = "reqInputPassword.(Ljava/lang/String;)V";
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_password);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		static Delegate cb_reqOfflineData_III;
#pragma warning disable 0169
		static Delegate GetReqOfflineData_IIIHandler ()
		{
			if (cb_reqOfflineData_III == null)
				cb_reqOfflineData_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ReqOfflineData_III);
			return cb_reqOfflineData_III;
		}

		static void n_ReqOfflineData_III (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId, int noteId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineData (sectionId, ownerId, noteId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqOfflineData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("reqOfflineData", "(III)V", "GetReqOfflineData_IIIHandler")]
		public override unsafe void ReqOfflineData (int sectionId, int ownerId, int noteId)
		{
			const string __id = "reqOfflineData.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataList ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqOfflineDataList' and count(parameter)=0]"
		[Register ("reqOfflineDataList", "()V", "GetReqOfflineDataListHandler")]
		public override unsafe void ReqOfflineDataList ()
		{
			const string __id = "reqOfflineDataList.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reqOfflineDataRemove_II;
#pragma warning disable 0169
		static Delegate GetReqOfflineDataRemove_IIHandler ()
		{
			if (cb_reqOfflineDataRemove_II == null)
				cb_reqOfflineDataRemove_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ReqOfflineDataRemove_II);
			return cb_reqOfflineDataRemove_II;
		}

		static void n_ReqOfflineDataRemove_II (IntPtr jnienv, IntPtr native__this, int sectionId, int ownerId)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqOfflineDataRemove (sectionId, ownerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqOfflineDataRemove' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("reqOfflineDataRemove", "(II)V", "GetReqOfflineDataRemove_IIHandler")]
		public virtual unsafe void ReqOfflineDataRemove (int sectionId, int ownerId)
		{
			const string __id = "reqOfflineDataRemove.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqPenBeepSetup_Z;
#pragma warning disable 0169
		static Delegate GetReqPenBeepSetup_ZHandler ()
		{
			if (cb_reqPenBeepSetup_Z == null)
				cb_reqPenBeepSetup_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ReqPenBeepSetup_Z);
			return cb_reqPenBeepSetup_Z;
		}

		static void n_ReqPenBeepSetup_Z (IntPtr jnienv, IntPtr native__this, bool isOn)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenBeepSetup (isOn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqPenBeepSetup' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("reqPenBeepSetup", "(Z)V", "GetReqPenBeepSetup_ZHandler")]
		public override unsafe void ReqPenBeepSetup (bool isOn)
		{
			const string __id = "reqPenBeepSetup.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isOn);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqPenStatus' and count(parameter)=0]"
		[Register ("reqPenStatus", "()V", "GetReqPenStatusHandler")]
		public override unsafe void ReqPenStatus ()
		{
			const string __id = "reqPenStatus.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_ == null)
				cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_);
			return cb_reqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_;
		}

		static void n_ReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_target)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File source = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_source, JniHandleOwnership.DoNotTransfer);
			string target = JNIEnv.GetString (native_target, JniHandleOwnership.DoNotTransfer);
			__this.ReqPenSwUpgrade (source, target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqPenSwUpgrade' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqPenSwUpgrade", "(Ljava/io/File;Ljava/lang/String;)V", "GetReqPenSwUpgrade_Ljava_io_File_Ljava_lang_String_Handler")]
		public override unsafe void ReqPenSwUpgrade (global::Java.IO.File source, string target)
		{
			const string __id = "reqPenSwUpgrade.(Ljava/io/File;Ljava/lang/String;)V";
			IntPtr native_target = JNIEnv.NewString (target);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (native_target);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_target);
			}
		}

		static Delegate cb_reqSetAutoShutdownTime_S;
#pragma warning disable 0169
		static Delegate GetReqSetAutoShutdownTime_SHandler ()
		{
			if (cb_reqSetAutoShutdownTime_S == null)
				cb_reqSetAutoShutdownTime_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetAutoShutdownTime_S);
			return cb_reqSetAutoShutdownTime_S;
		}

		static void n_ReqSetAutoShutdownTime_S (IntPtr jnienv, IntPtr native__this, short min)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetAutoShutdownTime (min);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqSetAutoShutdownTime' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetAutoShutdownTime", "(S)V", "GetReqSetAutoShutdownTime_SHandler")]
		public override unsafe void ReqSetAutoShutdownTime (short min)
		{
			const string __id = "reqSetAutoShutdownTime.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (min);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetPenSensitivity_S;
#pragma warning disable 0169
		static Delegate GetReqSetPenSensitivity_SHandler ()
		{
			if (cb_reqSetPenSensitivity_S == null)
				cb_reqSetPenSensitivity_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_ReqSetPenSensitivity_S);
			return cb_reqSetPenSensitivity_S;
		}

		static void n_ReqSetPenSensitivity_S (IntPtr jnienv, IntPtr native__this, short sensitivity)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetPenSensitivity (sensitivity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqSetPenSensitivity' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("reqSetPenSensitivity", "(S)V", "GetReqSetPenSensitivity_SHandler")]
		public override unsafe void ReqSetPenSensitivity (short sensitivity)
		{
			const string __id = "reqSetPenSensitivity.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sensitivity);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_);
			return cb_reqSetUpPassword_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldPassword, IntPtr native_newPassword)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oldPassword = JNIEnv.GetString (native_oldPassword, JniHandleOwnership.DoNotTransfer);
			string newPassword = JNIEnv.GetString (native_newPassword, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetUpPassword (oldPassword, newPassword);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqSetUpPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("reqSetUpPassword", "(Ljava/lang/String;Ljava/lang/String;)V", "GetReqSetUpPassword_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void ReqSetUpPassword (string oldPassword, string newPassword)
		{
			const string __id = "reqSetUpPassword.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_oldPassword = JNIEnv.NewString (oldPassword);
			IntPtr native_newPassword = JNIEnv.NewString (newPassword);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_oldPassword);
				__args [1] = new JniArgumentValue (native_newPassword);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_oldPassword);
				JNIEnv.DeleteLocalRef (native_newPassword);
			}
		}

		static Delegate cb_reqSetupPenTipColor_I;
#pragma warning disable 0169
		static Delegate GetReqSetupPenTipColor_IHandler ()
		{
			if (cb_reqSetupPenTipColor_I == null)
				cb_reqSetupPenTipColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ReqSetupPenTipColor_I);
			return cb_reqSetupPenTipColor_I;
		}

		static void n_ReqSetupPenTipColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSetupPenTipColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqSetupPenTipColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reqSetupPenTipColor", "(I)V", "GetReqSetupPenTipColor_IHandler")]
		public override unsafe void ReqSetupPenTipColor (int color)
		{
			const string __id = "reqSetupPenTipColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reqSuspendPenSwUpgrade;
#pragma warning disable 0169
		static Delegate GetReqSuspendPenSwUpgradeHandler ()
		{
			if (cb_reqSuspendPenSwUpgrade == null)
				cb_reqSuspendPenSwUpgrade = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReqSuspendPenSwUpgrade);
			return cb_reqSuspendPenSwUpgrade;
		}

		static void n_ReqSuspendPenSwUpgrade (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReqSuspendPenSwUpgrade ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='reqSuspendPenSwUpgrade' and count(parameter)=0]"
		[Register ("reqSuspendPenSwUpgrade", "()V", "GetReqSuspendPenSwUpgradeHandler")]
		public override unsafe void ReqSuspendPenSwUpgrade ()
		{
			const string __id = "reqSuspendPenSwUpgrade.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resPenSwRequest_I;
#pragma warning disable 0169
		static Delegate GetResPenSwRequest_IHandler ()
		{
			if (cb_resPenSwRequest_I == null)
				cb_resPenSwRequest_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ResPenSwRequest_I);
			return cb_resPenSwRequest_I;
		}

		static void n_ResPenSwRequest_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResPenSwRequest (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='resPenSwRequest' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("resPenSwRequest", "(I)V", "GetResPenSwRequest_IHandler")]
		public virtual unsafe void ResPenSwRequest (int index)
		{
			const string __id = "resPenSwRequest.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_resPenSwUpgStatus_I;
#pragma warning disable 0169
		static Delegate GetResPenSwUpgStatus_IHandler ()
		{
			if (cb_resPenSwUpgStatus_I == null)
				cb_resPenSwUpgStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ResPenSwUpgStatus_I);
			return cb_resPenSwUpgStatus_I;
		}

		static void n_ResPenSwUpgStatus_I (IntPtr jnienv, IntPtr native__this, int status)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResPenSwUpgStatus (status);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='resPenSwUpgStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("resPenSwUpgStatus", "(I)V", "GetResPenSwUpgStatus_IHandler")]
		public virtual unsafe void ResPenSwUpgStatus (int status)
		{
			const string __id = "resPenSwUpgStatus.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (status);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_;
#pragma warning disable 0169
		static Delegate GetSetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_Handler ()
		{
			if (cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_ == null)
				cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_);
			return cb_setChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_;
		}

		static void n_SetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chunk)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk chunk = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk> (native_chunk, JniHandleOwnership.DoNotTransfer);
			__this.SetChunk (chunk);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='setChunk' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.pen.bluetooth.lib.Chunk']]"
		[Register ("setChunk", "(Lkr/neolab/sdk/pen/bluetooth/lib/Chunk;)V", "GetSetChunk_Lkr_neolab_sdk_pen_bluetooth_lib_Chunk_Handler")]
		public override unsafe void SetChunk (global::KR.Neolab.Sdk.Pen.Bluetooth.Lib.Chunk chunk)
		{
			const string __id = "setChunk.(Lkr/neolab/sdk/pen/bluetooth/lib/Chunk;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((chunk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chunk).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBHandler ()
		{
			if (cb_write_arrayB == null)
				cb_write_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_arrayB);
			return cb_write_arrayB;
		}

		static void n_Write_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Comm.CommProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (buffer);
			if (buffer != null)
				JNIEnv.CopyArray (buffer, native_buffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.comm']/class[@name='CommProcessor']/method[@name='write' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("write", "([B)V", "GetWrite_arrayBHandler")]
		public override unsafe void Write (byte[] buffer)
		{
			const string __id = "write.([B)V";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_buffer);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

	}
}
