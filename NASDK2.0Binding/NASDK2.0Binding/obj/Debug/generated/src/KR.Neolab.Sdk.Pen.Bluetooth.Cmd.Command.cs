using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Cmd {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/Command", DoNotGenerateAcw=true)]
	public abstract partial class Command : global::Java.Lang.Object, global::Java.Lang.IRunnable, global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/field[@name='comp']"
		[Register ("comp")]
		protected global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager Comp {
			get {
				const string __id = "comp.Lkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "comp.Lkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/Command", typeof (Command));
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

		protected Command (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/constructor[@name='Command' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='kr.neolab.sdk.pen.bluetooth.cmd.CommandManager']]"
		[Register (".ctor", "(ILkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;)V", "")]
		public unsafe Command (int key, global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.CommandManager comp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILkr/neolab/sdk/pen/bluetooth/cmd/CommandManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (key);
				__args [1] = new JniArgumentValue ((comp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				const string __id = "getId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAlive;
#pragma warning disable 0169
		static Delegate GetIsAliveHandler ()
		{
			if (cb_isAlive == null)
				cb_isAlive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAlive);
			return cb_isAlive;
		}

		static bool n_IsAlive (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAlive;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAlive {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/method[@name='isAlive' and count(parameter)=0]"
			[Register ("isAlive", "()Z", "GetIsAliveHandler")]
			get {
				const string __id = "isAlive.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_excute;
#pragma warning disable 0169
		static Delegate GetExcuteHandler ()
		{
			if (cb_excute == null)
				cb_excute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Excute);
			return cb_excute;
		}

		static void n_Excute (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Excute ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/method[@name='excute' and count(parameter)=0]"
		[Register ("excute", "()V", "GetExcuteHandler")]
		public virtual unsafe void Excute ()
		{
			const string __id = "excute.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			const string __id = "finish.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_write;
#pragma warning disable 0169
		static Delegate GetWriteHandler ()
		{
			if (cb_write == null)
				cb_write = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Write);
			return cb_write;
		}

		static void n_Write (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.Command> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/method[@name='write' and count(parameter)=0]"
		[Register ("write", "()V", "GetWriteHandler")]
		protected abstract void Write ();

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/Command", DoNotGenerateAcw=true)]
	internal partial class CommandInvoker : Command {

		public CommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/Command", typeof (CommandInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/class[@name='Command']/method[@name='write' and count(parameter)=0]"
		[Register ("write", "()V", "GetWriteHandler")]
		protected override unsafe void Write ()
		{
			const string __id = "write.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
