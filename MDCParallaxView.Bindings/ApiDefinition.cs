using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ParallaxView.Bindings
{
	[BaseType (typeof (UIView))]
	public partial interface MDCParallaxView {

		[Export ("scrollView")]
		UIScrollView ScrollView { get; }

		[Export ("scrollViewDelegate", ArgumentSemantic.Assign)]
		UIScrollViewDelegate ScrollViewDelegate { get; set; }

		[Export ("backgroundHeight")]
		float BackgroundHeight { get; set; }

		[Export ("backgroundInteractionEnabled")]
		bool BackgroundInteractionEnabled { [Bind ("isBackgroundInteractionEnabled")] get; set; }

		[Export ("initWithBackgroundView:foregroundView:")]
		IntPtr Constructor (UIView backgroundView, UIView foregroundView);
	}
}

