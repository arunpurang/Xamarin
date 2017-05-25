using System;

using System.Threading.Tasks;
using TestGallary;
using TestGallary.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(OpenGallary_IOS))]
namespace TestGallary.iOS
{
	
	public class OpenGallary_IOS : OpenGallary
	{
		public bool openGallary()
		{
			bool bRet = false;
			var imagePicker = new UIImagePickerController();
			imagePicker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			imagePicker.FinishedPickingMedia += async (sender, ev) =>
			{
				Console.WriteLine("Done");
			};

			imagePicker.Canceled += (sender, ev2) =>
			{
				UIApplication.SharedApplication.KeyWindow.RootViewController.DismissViewController(true, null);
				//we have to remove the entry from the list.
			};
			UIApplication.SharedApplication.KeyWindow.RootViewController.PresentModalViewController(imagePicker, true);
			return bRet;
		}
	}
}
