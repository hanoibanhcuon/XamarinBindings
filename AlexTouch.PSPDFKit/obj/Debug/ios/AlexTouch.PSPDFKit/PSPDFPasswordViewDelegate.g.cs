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
	[Register("PSPDFPasswordViewDelegate", true)]
	[Model]
	public unsafe abstract partial class PSPDFPasswordViewDelegate : NSObject {
		
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public  PSPDFPasswordViewDelegate () : base (NSObjectFlag.Empty)
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
		public PSPDFPasswordViewDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public PSPDFPasswordViewDelegate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public PSPDFPasswordViewDelegate (IntPtr handle) : base (handle) {}

		[Export ("passwordView:didUnlockWithPassword:")]
		[CompilerGenerated]
		public abstract void DidUnlockWithPassword (PSPDFPasswordView passwordView, string password);
		[Export ("passwordView:didFailToUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual void DidFailToUnlockWithPassword (PSPDFPasswordView passwordView, string password)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("passwordView:shouldlUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual bool ShouldlUnlockWithPassword (PSPDFPasswordView passwordView, string password)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("passwordView:willUnlockWithPassword:")]
		[CompilerGenerated]
		public virtual void WillUnlockWithPassword (PSPDFPasswordView passwordView, string password)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PSPDFPasswordViewDelegate */
}
