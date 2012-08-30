//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using OpenTK;

namespace AlexTouch.PSPDFKit {
	[Register("PSPDFBookmark", true)]
	public unsafe partial class PSPDFBookmark : NSObject {
		static readonly IntPtr selPage = Selector.GetHandle ("page");
		static readonly IntPtr selSetPage_ = Selector.GetHandle ("setPage:");
		static readonly IntPtr selInitWithPage_ = Selector.GetHandle ("initWithPage:");
		
		static readonly IntPtr class_ptr = Class.GetHandle ("PSPDFBookmark");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFBookmark () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public PSPDFBookmark (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBookmark (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFBookmark (IntPtr handle) : base (handle) {}

		[Export ("initWithPage:")]
		[CompilerGenerated]
		public PSPDFBookmark (System.UInt32 page) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selInitWithPage_, page);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selInitWithPage_, page);
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 Page {
			[Export ("page", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selPage);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selPage);
				}
			}
			
			[Export ("setPage:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetPage_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetPage_, value);
				}
			}
		}
		
	} /* class PSPDFBookmark */
}
