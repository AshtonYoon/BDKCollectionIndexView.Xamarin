﻿using System;
using AVFoundation;
using CloudKit;
using CoreAnimation;
using CoreData;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using CoreLocation;
using CoreVideo;
using FileProvider;
using Foundation;
using IOSurface;
using ImageIO;
using Intents;
using LinkPresentation;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;
using UserNotifications;

namespace BDK
{// @interface BDKCollectionIndexView : UIControl
	[BaseType(typeof(UIControl))]
	[Protocol]
	interface BDKCollectionIndexView
	{
		[Wrap("WeakDelegate")]
		BDKCollectionIndexViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<BDKCollectionIndexViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) NSArray * indexTitles;
		[Export("indexTitles", ArgumentSemantic.Strong)]
		NSObject[] IndexTitles { get; set; }

		// @property (readonly, nonatomic) NSUInteger currentIndex;
		[Export("currentIndex")]
		nuint CurrentIndex { get; }

		// @property (readonly) BDKCollectionIndexViewDirection direction;
		[Export("direction")]
		BDKCollectionIndexViewDirection Direction { get; }

		// @property (readonly) NSString * currentIndexTitle;
		[Export("currentIndexTitle")]
		string CurrentIndexTitle { get; }

		// @property (nonatomic, strong) UIFont * font;
		[Export("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * touchStatusBackgroundColor;
		[Export("touchStatusBackgroundColor", ArgumentSemantic.Strong)]
		UIColor TouchStatusBackgroundColor { get; set; }

		// @property (nonatomic) CGFloat touchStatusViewAlpha;
		[Export("touchStatusViewAlpha")]
		nfloat TouchStatusViewAlpha { get; set; }

		// +(instancetype)indexViewWithFrame:(CGRect)frame indexTitles:(NSArray *)indexTitles;
		[Static]
		[Export("indexViewWithFrame:indexTitles:")]
		BDKCollectionIndexView IndexViewWithFrame(CGRect frame, NSObject[] indexTitles);

		// -(instancetype)initWithFrame:(CGRect)frame indexTitles:(NSArray *)indexTitles;
		[Export("initWithFrame:indexTitles:")]
		IntPtr Constructor(CGRect frame, NSObject[] indexTitles);

		// -(void)reloadData;
		[Export("reloadData")]
		void ReloadData();
	}

	// @protocol BDKCollectionIndexViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface BDKCollectionIndexViewDelegate
	{
		// @optional -(void)collectionIndexView:(BDKCollectionIndexView *)collectionIndexView isPressedOnIndex:(NSUInteger)pressedIndex indexTitle:(NSString *)indexTitle;
		[Export("collectionIndexView:isPressedOnIndex:indexTitle:")]
		void IsPressedOnIndex(BDKCollectionIndexView collectionIndexView, nuint pressedIndex, string indexTitle);

		// @optional -(void)collectionIndexView:(BDKCollectionIndexView *)collectionIndexView liftedFingerFromIndex:(NSUInteger)pressedIndex;
		[Export("collectionIndexView:liftedFingerFromIndex:")]
		void LiftedFingerFromIndex(BDKCollectionIndexView collectionIndexView, nuint pressedIndex);
	}
}

