﻿
using UIKit;
using Xamarin.Forms;

namespace CarouselView.FormsPlugin.iOS
{
	public class ViewContainer : UIViewController
	{
		// To save current position
		public object Tag { get; set; }

		// Commented because Crash due to disposed objects when jumping back and forth #143
		/*protected override void Dispose(bool disposing)
		{
			// because this runs in the finalizer thread and disposing is equal false
            InvokeOnMainThread( () => {
			//if (disposing)
			//{
				// Significant Memory Leak for iOS when using custom layout for page content #125
				// Thanks to johnnysbug for the help!
				foreach (var view in View.Subviews)
				{
					view.RemoveFromSuperview();
					view.Dispose();
				}

				View.RemoveFromSuperview();
				View.Dispose();
				View = null;
			//}
			});

			base.Dispose(disposing);
		}*/
	}
}

