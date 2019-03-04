using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace KR.Neolab.Sdk.Ink.Structure {

	// Metadata.xml XPath class reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']"
	[global::Android.Runtime.Register ("kr/neolab/sdk/ink/structure/Stroke", DoNotGenerateAcw=true)]
	public partial class Stroke : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='PEN_TIP_TYPE_ERASER']"
		[Register ("PEN_TIP_TYPE_ERASER")]
		public const int PenTipTypeEraser = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='PEN_TIP_TYPE_NORMAL']"
		[Register ("PEN_TIP_TYPE_NORMAL")]
		public const int PenTipTypeNormal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='STROKE_TYPE_HIGHLIGHT']"
		[Register ("STROKE_TYPE_HIGHLIGHT")]
		public const int StrokeTypeHighlight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='STROKE_TYPE_NORMAL']"
		[Register ("STROKE_TYPE_NORMAL")]
		public const int StrokeTypeNormal = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='STROKE_TYPE_PEN']"
		[Register ("STROKE_TYPE_PEN")]
		public const int StrokeTypePen = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='color']"
		[Register ("color")]
		public int Color {
			get {
				const string __id = "color.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "color.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='noteId']"
		[Register ("noteId")]
		public int NoteId {
			get {
				const string __id = "noteId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "noteId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='ownerId']"
		[Register ("ownerId")]
		public int OwnerId {
			get {
				const string __id = "ownerId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ownerId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='pageId']"
		[Register ("pageId")]
		public int PageId {
			get {
				const string __id = "pageId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pageId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='penTipType']"
		[Register ("penTipType")]
		public int PenTipType {
			get {
				const string __id = "penTipType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "penTipType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='sectionId']"
		[Register ("sectionId")]
		public int SectionId {
			get {
				const string __id = "sectionId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "sectionId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='thickness']"
		[Register ("thickness")]
		public int Thickness {
			get {
				const string __id = "thickness.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "thickness.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='timeStampEnd']"
		[Register ("timeStampEnd")]
		public long TimeStampEnd {
			get {
				const string __id = "timeStampEnd.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timeStampEnd.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='timeStampStart']"
		[Register ("timeStampStart")]
		public long TimeStampStart {
			get {
				const string __id = "timeStampStart.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timeStampStart.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				const string __id = "type.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "type.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("kr/neolab/sdk/ink/structure/Stroke", typeof (Stroke));
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

		protected Stroke (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/constructor[@name='Stroke' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe Stroke (int sectionId, int ownerId, int noteId, int pageId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				__args [3] = new JniArgumentValue (pageId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/constructor[@name='Stroke' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(IIIII)V", "")]
		public unsafe Stroke (int sectionId, int ownerId, int noteId, int pageId, int color)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				__args [3] = new JniArgumentValue (pageId);
				__args [4] = new JniArgumentValue (color);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/constructor[@name='Stroke' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(IIIIII)V", "")]
		public unsafe Stroke (int sectionId, int ownerId, int noteId, int pageId, int color, int type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (sectionId);
				__args [1] = new JniArgumentValue (ownerId);
				__args [2] = new JniArgumentValue (noteId);
				__args [3] = new JniArgumentValue (pageId);
				__args [4] = new JniArgumentValue (color);
				__args [5] = new JniArgumentValue (type);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDots;
#pragma warning disable 0169
		static Delegate GetGetDotsHandler ()
		{
			if (cb_getDots == null)
				cb_getDots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDots);
			return cb_getDots;
		}

		static IntPtr n_GetDots (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Ink.Structure.Dot>.ToLocalJniHandle (__this.Dots);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::KR.Neolab.Sdk.Ink.Structure.Dot> Dots {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='getDots' and count(parameter)=0]"
			[Register ("getDots", "()Ljava/util/ArrayList;", "GetGetDotsHandler")]
			get {
				const string __id = "getDots.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::KR.Neolab.Sdk.Ink.Structure.Dot>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReadOnly;
#pragma warning disable 0169
		static Delegate GetIsReadOnlyHandler ()
		{
			if (cb_isReadOnly == null)
				cb_isReadOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReadOnly);
			return cb_isReadOnly;
		}

		static bool n_IsReadOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReadOnly;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsReadOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='isReadOnly' and count(parameter)=0]"
			[Register ("isReadOnly", "()Z", "GetIsReadOnlyHandler")]
			get {
				const string __id = "isReadOnly.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Path);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Path Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Landroid/graphics/Path;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Landroid/graphics/Path;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lkr_neolab_sdk_ink_structure_Dot_;
#pragma warning disable 0169
		static Delegate GetAdd_Lkr_neolab_sdk_ink_structure_Dot_Handler ()
		{
			if (cb_add_Lkr_neolab_sdk_ink_structure_Dot_ == null)
				cb_add_Lkr_neolab_sdk_ink_structure_Dot_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Lkr_neolab_sdk_ink_structure_Dot_);
			return cb_add_Lkr_neolab_sdk_ink_structure_Dot_;
		}

		static bool n_Add_Lkr_neolab_sdk_ink_structure_Dot_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dot)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::KR.Neolab.Sdk.Ink.Structure.Dot dot = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (native_dot, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (dot);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='add' and count(parameter)=1 and parameter[1][@type='kr.neolab.sdk.ink.structure.Dot']]"
		[Register ("add", "(Lkr/neolab/sdk/ink/structure/Dot;)Z", "GetAdd_Lkr_neolab_sdk_ink_structure_Dot_Handler")]
		public virtual unsafe bool Add (global::KR.Neolab.Sdk.Ink.Structure.Dot dot)
		{
			const string __id = "add.(Lkr/neolab/sdk/ink/structure/Dot;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dot == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dot).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_changePos_FF;
#pragma warning disable 0169
		static Delegate GetChangePos_FFHandler ()
		{
			if (cb_changePos_FF == null)
				cb_changePos_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_ChangePos_FF);
			return cb_changePos_FF;
		}

		static void n_ChangePos_FF (IntPtr jnienv, IntPtr native__this, float dx, float dy)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangePos (dx, dy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='changePos' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("changePos", "(FF)V", "GetChangePos_FFHandler")]
		public virtual unsafe void ChangePos (float dx, float dy)
		{
			const string __id = "changePos.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dx);
				__args [1] = new JniArgumentValue (dy);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_changeScale_F;
#pragma warning disable 0169
		static Delegate GetChangeScale_FHandler ()
		{
			if (cb_changeScale_F == null)
				cb_changeScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_ChangeScale_F);
			return cb_changeScale_F;
		}

		static void n_ChangeScale_F (IntPtr jnienv, IntPtr native__this, float scale)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeScale (scale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='changeScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("changeScale", "(F)V", "GetChangeScale_FHandler")]
		public virtual unsafe void ChangeScale (float scale)
		{
			const string __id = "changeScale.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (scale);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_contains_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetContains_Landroid_graphics_RectF_Handler ()
		{
			if (cb_contains_Landroid_graphics_RectF_ == null)
				cb_contains_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Landroid_graphics_RectF_);
			return cb_contains_Landroid_graphics_RectF_;
		}

		static bool n_Contains_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_area)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF area = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_area, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (area);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("contains", "(Landroid/graphics/RectF;)Z", "GetContains_Landroid_graphics_RectF_Handler")]
		public virtual unsafe bool Contains (global::Android.Graphics.RectF area)
		{
			const string __id = "contains.(Landroid/graphics/RectF;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((area == null) ? IntPtr.Zero : ((global::Java.Lang.Object) area).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lkr/neolab/sdk/ink/structure/Dot;", "GetGet_IHandler")]
		public virtual unsafe global::KR.Neolab.Sdk.Ink.Structure.Dot Get (int index)
		{
			const string __id = "get.(I)Lkr/neolab/sdk/ink/structure/Dot;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Dot> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPressureArray;
#pragma warning disable 0169
		static Delegate GetGetPressureArrayHandler ()
		{
			if (cb_getPressureArray == null)
				cb_getPressureArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPressureArray);
			return cb_getPressureArray;
		}

		static IntPtr n_GetPressureArray (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPressureArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='getPressureArray' and count(parameter)=0]"
		[Register ("getPressureArray", "()[S", "GetGetPressureArrayHandler")]
		public virtual unsafe short[] GetPressureArray ()
		{
			const string __id = "getPressureArray.()[S";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (short[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (short));
			} finally {
			}
		}

		static Delegate cb_getTimestampArray;
#pragma warning disable 0169
		static Delegate GetGetTimestampArrayHandler ()
		{
			if (cb_getTimestampArray == null)
				cb_getTimestampArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimestampArray);
			return cb_getTimestampArray;
		}

		static IntPtr n_GetTimestampArray (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTimestampArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='getTimestampArray' and count(parameter)=0]"
		[Register ("getTimestampArray", "()[J", "GetGetTimestampArrayHandler")]
		public virtual unsafe long[] GetTimestampArray ()
		{
			const string __id = "getTimestampArray.()[J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static Delegate cb_getXArray;
#pragma warning disable 0169
		static Delegate GetGetXArrayHandler ()
		{
			if (cb_getXArray == null)
				cb_getXArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXArray);
			return cb_getXArray;
		}

		static IntPtr n_GetXArray (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetXArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='getXArray' and count(parameter)=0]"
		[Register ("getXArray", "()[F", "GetGetXArrayHandler")]
		public virtual unsafe float[] GetXArray ()
		{
			const string __id = "getXArray.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getYArray;
#pragma warning disable 0169
		static Delegate GetGetYArrayHandler ()
		{
			if (cb_getYArray == null)
				cb_getYArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYArray);
			return cb_getYArray;
		}

		static IntPtr n_GetYArray (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetYArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='getYArray' and count(parameter)=0]"
		[Register ("getYArray", "()[F", "GetGetYArrayHandler")]
		public virtual unsafe float[] GetYArray ()
		{
			const string __id = "getYArray.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_intersect_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetIntersect_Landroid_graphics_RectF_Handler ()
		{
			if (cb_intersect_Landroid_graphics_RectF_ == null)
				cb_intersect_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Intersect_Landroid_graphics_RectF_);
			return cb_intersect_Landroid_graphics_RectF_;
		}

		static bool n_Intersect_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_area)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF area = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_area, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Intersect (area);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='intersect' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("intersect", "(Landroid/graphics/RectF;)Z", "GetIntersect_Landroid_graphics_RectF_Handler")]
		public virtual unsafe bool Intersect (global::Android.Graphics.RectF area)
		{
			const string __id = "intersect.(Landroid/graphics/RectF;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((area == null) ? IntPtr.Zero : ((global::Java.Lang.Object) area).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_parcel, int native_i)
		{
			global::KR.Neolab.Sdk.Ink.Structure.Stroke __this = global::Java.Lang.Object.GetObject<global::KR.Neolab.Sdk.Ink.Structure.Stroke> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel parcel = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_parcel, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags i = (global::Android.OS.ParcelableWriteFlags) native_i;
			__this.WriteToParcel (parcel, i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='kr.neolab.sdk.ink.structure']/class[@name='Stroke']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel parcel, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags i)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				__args [1] = new JniArgumentValue ((int) i);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
