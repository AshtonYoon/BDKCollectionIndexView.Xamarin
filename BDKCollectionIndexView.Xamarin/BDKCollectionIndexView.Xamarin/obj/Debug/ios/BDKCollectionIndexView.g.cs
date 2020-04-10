//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace BDK {
	[Protocol (Name = "BDKCollectionIndexView", WrapperType = typeof (BDKCollectionIndexViewWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "IndexViewWithFrame", Selector = "indexViewWithFrame:indexTitles:", ReturnType = typeof (BDK.BDKCollectionIndexView), ParameterType = new Type [] { typeof (CGRect), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReloadData", Selector = "reloadData")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakDelegate", Selector = "delegate", PropertyType = typeof (NSObject), GetterSelector = "delegate", SetterSelector = "setDelegate:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IndexTitles", Selector = "indexTitles", PropertyType = typeof (NSObject[]), GetterSelector = "indexTitles", SetterSelector = "setIndexTitles:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentIndex", Selector = "currentIndex", PropertyType = typeof (nuint), GetterSelector = "currentIndex", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Direction", Selector = "direction", PropertyType = typeof (BDK.BDKCollectionIndexViewDirection), GetterSelector = "direction", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentIndexTitle", Selector = "currentIndexTitle", PropertyType = typeof (string), GetterSelector = "currentIndexTitle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Font", Selector = "font", PropertyType = typeof (UIFont), GetterSelector = "font", SetterSelector = "setFont:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TouchStatusBackgroundColor", Selector = "touchStatusBackgroundColor", PropertyType = typeof (UIColor), GetterSelector = "touchStatusBackgroundColor", SetterSelector = "setTouchStatusBackgroundColor:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TouchStatusViewAlpha", Selector = "touchStatusViewAlpha", PropertyType = typeof (nfloat), GetterSelector = "touchStatusViewAlpha", SetterSelector = "setTouchStatusViewAlpha:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IBDKCollectionIndexView : INativeObject, IDisposable
	{
	}
	
	public static partial class BDKCollectionIndexView_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReloadData (this IBDKCollectionIndexView This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("reloadData"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetWeakDelegate (this IBDKCollectionIndexView This)
		{
			return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetWeakDelegate (this IBDKCollectionIndexView This, NSObject value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetIndexTitles (this IBDKCollectionIndexView This)
		{
			return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("indexTitles")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetIndexTitles (this IBDKCollectionIndexView This, NSObject[] value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsa_value = NSArray.FromNSObjects (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setIndexTitles:"), nsa_value.Handle);
			nsa_value.Dispose ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetCurrentIndex (this IBDKCollectionIndexView This)
		{
			return global::ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("currentIndex"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static BDKCollectionIndexViewDirection GetDirection (this IBDKCollectionIndexView This)
		{
			BDKCollectionIndexViewDirection ret;
			if (IntPtr.Size == 8) {
				ret = (BDKCollectionIndexViewDirection) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("direction"));
			} else {
				ret = (BDKCollectionIndexViewDirection) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("direction"));
			}
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetCurrentIndexTitle (this IBDKCollectionIndexView This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("currentIndexTitle")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIFont GetFont (this IBDKCollectionIndexView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("font")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetFont (this IBDKCollectionIndexView This, global::UIKit.UIFont value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setFont:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor GetTouchStatusBackgroundColor (this IBDKCollectionIndexView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("touchStatusBackgroundColor")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTouchStatusBackgroundColor (this IBDKCollectionIndexView This, global::UIKit.UIColor value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTouchStatusBackgroundColor:"), value.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetTouchStatusViewAlpha (this IBDKCollectionIndexView This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("touchStatusViewAlpha"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTouchStatusViewAlpha (this IBDKCollectionIndexView This, nfloat value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setTouchStatusViewAlpha:"), value);
		}
		
	}
	
	internal sealed class BDKCollectionIndexViewWrapper : BaseWrapper, IBDKCollectionIndexView {
		[Preserve (Conditional = true)]
		public BDKCollectionIndexViewWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace BDK {
	[Protocol()]
	[Register("BDKCollectionIndexView", true)]
	public unsafe partial class BDKCollectionIndexView : global::UIKit.UIControl, IBDKCollectionIndexView {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("BDKCollectionIndexView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BDKCollectionIndexView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public BDKCollectionIndexView (NSCoder coder) : base (NSObjectFlag.Empty)
		{

			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BDKCollectionIndexView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BDKCollectionIndexView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:indexTitles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BDKCollectionIndexView (CGRect frame, NSObject[] indexTitles)
			: base (NSObjectFlag.Empty)
		{
			if (indexTitles == null)
				throw new ArgumentNullException ("indexTitles");
			var nsa_indexTitles = NSArray.FromNSObjects (indexTitles);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:indexTitles:"), frame, nsa_indexTitles.Handle), "initWithFrame:indexTitles:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:indexTitles:"), frame, nsa_indexTitles.Handle), "initWithFrame:indexTitles:");
			}
			nsa_indexTitles.Dispose ();
			
		}
		
		[Export ("indexViewWithFrame:indexTitles:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static BDKCollectionIndexView IndexViewWithFrame (CGRect frame, NSObject[] indexTitles)
		{
			if (indexTitles == null)
				throw new ArgumentNullException ("indexTitles");
			var nsa_indexTitles = NSArray.FromNSObjects (indexTitles);
			
			BDKCollectionIndexView ret;
			ret =  Runtime.GetNSObject<BDKCollectionIndexView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (class_ptr, Selector.GetHandle ("indexViewWithFrame:indexTitles:"), frame, nsa_indexTitles.Handle));
			nsa_indexTitles.Dispose ();
			
			return ret;
		}
		
		[Export ("reloadData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadData ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reloadData"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reloadData"));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint CurrentIndex {
			[Export ("currentIndex")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("currentIndex"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentIndex"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CurrentIndexTitle {
			[Export ("currentIndexTitle")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("currentIndexTitle")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currentIndexTitle")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BDKCollectionIndexViewDelegate Delegate {
			get {
				return WeakDelegate as BDKCollectionIndexViewDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BDKCollectionIndexViewDirection Direction {
			[Export ("direction")]
			get {
				BDKCollectionIndexViewDirection ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (BDKCollectionIndexViewDirection) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("direction"));
					} else {
						ret = (BDKCollectionIndexViewDirection) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("direction"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (BDKCollectionIndexViewDirection) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("direction"));
					} else {
						ret = (BDKCollectionIndexViewDirection) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("direction"));
					}
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIFont Font {
			[Export ("font", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("font")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("font")));
				}
				return ret;
			}
			
			[Export ("setFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFont:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] IndexTitles {
			[Export ("indexTitles", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("indexTitles")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("indexTitles")));
				}
				return ret;
			}
			
			[Export ("setIndexTitles:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIndexTitles:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setIndexTitles:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor TouchStatusBackgroundColor {
			[Export ("touchStatusBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("touchStatusBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("touchStatusBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setTouchStatusBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTouchStatusBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTouchStatusBackgroundColor:"), value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat TouchStatusViewAlpha {
			[Export ("touchStatusViewAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("touchStatusViewAlpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("touchStatusViewAlpha"));
				}
			}
			
			[Export ("setTouchStatusViewAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setTouchStatusViewAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setTouchStatusViewAlpha:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class BDKCollectionIndexViewAppearance : global::UIKit.UIControl.UIControlAppearance {
			protected internal BDKCollectionIndexViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new BDKCollectionIndexViewAppearance Appearance {
			get { return new BDKCollectionIndexViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new BDKCollectionIndexViewAppearance GetAppearance<T> () where T: BDKCollectionIndexView {
			return new BDKCollectionIndexViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new BDKCollectionIndexViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new BDKCollectionIndexViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new BDKCollectionIndexViewAppearance GetAppearance (UITraitCollection traits) {
			return new BDKCollectionIndexViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new BDKCollectionIndexViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new BDKCollectionIndexViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new BDKCollectionIndexViewAppearance GetAppearance<T> (UITraitCollection traits) where T: BDKCollectionIndexView {
			return new BDKCollectionIndexViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new BDKCollectionIndexViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: BDKCollectionIndexView{
			return new BDKCollectionIndexViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class BDKCollectionIndexView */
}
