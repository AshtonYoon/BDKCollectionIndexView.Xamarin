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
	[Protocol (Name = "BDKCollectionIndexViewDelegate", WrapperType = typeof (BDKCollectionIndexViewDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsPressedOnIndex", Selector = "collectionIndexView:isPressedOnIndex:indexTitle:", ParameterType = new Type [] { typeof (BDK.BDKCollectionIndexView), typeof (nuint), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LiftedFingerFromIndex", Selector = "collectionIndexView:liftedFingerFromIndex:", ParameterType = new Type [] { typeof (BDK.BDKCollectionIndexView), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public interface IBDKCollectionIndexViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class BDKCollectionIndexViewDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void IsPressedOnIndex (this IBDKCollectionIndexViewDelegate This, BDKCollectionIndexView collectionIndexView, nuint pressedIndex, string indexTitle)
		{
			if (collectionIndexView == null)
				throw new ArgumentNullException ("collectionIndexView");
			if (indexTitle == null)
				throw new ArgumentNullException ("indexTitle");
			var nsindexTitle = NSString.CreateNative (indexTitle);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (This.Handle, Selector.GetHandle ("collectionIndexView:isPressedOnIndex:indexTitle:"), collectionIndexView.Handle, pressedIndex, nsindexTitle);
			NSString.ReleaseNative (nsindexTitle);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LiftedFingerFromIndex (this IBDKCollectionIndexViewDelegate This, BDKCollectionIndexView collectionIndexView, nuint pressedIndex)
		{
			if (collectionIndexView == null)
				throw new ArgumentNullException ("collectionIndexView");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (This.Handle, Selector.GetHandle ("collectionIndexView:liftedFingerFromIndex:"), collectionIndexView.Handle, pressedIndex);
		}
		
	}
	
	internal sealed class BDKCollectionIndexViewDelegateWrapper : BaseWrapper, IBDKCollectionIndexViewDelegate {
		[Preserve (Conditional = true)]
		public BDKCollectionIndexViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace BDK {
	[Protocol()]
	[Register("ApiDefinition__BDK_BDKCollectionIndexViewDelegate", false)]
	[Model]
	public unsafe partial class BDKCollectionIndexViewDelegate : NSObject, IBDKCollectionIndexViewDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BDKCollectionIndexViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected BDKCollectionIndexViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal BDKCollectionIndexViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("collectionIndexView:isPressedOnIndex:indexTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IsPressedOnIndex (BDKCollectionIndexView collectionIndexView, nuint pressedIndex, string indexTitle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("collectionIndexView:liftedFingerFromIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LiftedFingerFromIndex (BDKCollectionIndexView collectionIndexView, nuint pressedIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class BDKCollectionIndexViewDelegate */
}
