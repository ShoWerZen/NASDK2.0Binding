using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Pen.Bluetooth.Cmd {

	// Metadata.xml XPath interface reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/interface[@name='ICommand']"
	[Register ("kr/neolab/sdk/pen/bluetooth/cmd/ICommand", "", "KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommandInvoker")]
	public partial interface ICommand : IJavaObject {

		int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/interface[@name='ICommand']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler:KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommandInvoker, NASDK2.0Binding")] get;
		}

		bool IsAlive {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/interface[@name='ICommand']/method[@name='isAlive' and count(parameter)=0]"
			[Register ("isAlive", "()Z", "GetIsAliveHandler:KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommandInvoker, NASDK2.0Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/interface[@name='ICommand']/method[@name='excute' and count(parameter)=0]"
		[Register ("excute", "()V", "GetExcuteHandler:KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommandInvoker, NASDK2.0Binding")]
		void Excute ();

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.pen.bluetooth.cmd']/interface[@name='ICommand']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler:KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommandInvoker, NASDK2.0Binding")]
		void Finish ();

	}

	[global::Android.Runtime.Register ("kr/neolab/sdk/pen/bluetooth/cmd/ICommand", DoNotGenerateAcw=true)]
	internal class ICommandInvoker : global::Java.Lang.Object, ICommand {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("kr/neolab/sdk/pen/bluetooth/cmd/ICommand", typeof (ICommandInvoker));

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

		public static ICommand GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommand> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "kr.neolab.sdk.pen.bluetooth.cmd.ICommand"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe int Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId);
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAlive;
		}
#pragma warning restore 0169

		IntPtr id_isAlive;
		public unsafe bool IsAlive {
			get {
				if (id_isAlive == IntPtr.Zero)
					id_isAlive = JNIEnv.GetMethodID (class_ref, "isAlive", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAlive);
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Excute ();
		}
#pragma warning restore 0169

		IntPtr id_excute;
		public unsafe void Excute ()
		{
			if (id_excute == IntPtr.Zero)
				id_excute = JNIEnv.GetMethodID (class_ref, "excute", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_excute);
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
			global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Pen.Bluetooth.Cmd.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		IntPtr id_finish;
		public unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finish);
		}

	}

}
