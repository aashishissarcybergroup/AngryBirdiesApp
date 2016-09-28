using Foundation;
using System;
using UIKit;

namespace AngryBirdies
{
    public partial class Login : UIViewController
    {
	//	LoadingOverlay overlayView;

		public Login (IntPtr handle) : base (handle)
        {
        }

				public override void ViewWillAppear (bool animated) 		{ 			base.ViewWillAppear (animated); 			NavigationController.NavigationBarHidden = true; 			txtPassword.ShouldReturn += (textField) => { 				textField.ResignFirstResponder (); 				return true; 			} ; 			txtUserName.ShouldReturn += (textField) => { 				textField.ResignFirstResponder (); 				return true; 			} ;  		}  		public override void DidReceiveMemoryWarning() 		{ 			base.DidReceiveMemoryWarning(); 		}


partial void ClickedSignIn_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}

		public static UIAlertController alertViewWithMessage(string message) 		{
			//Depricated in iOS9...
			//var alertView = new UIAlertView("Alert!", message, null, "OK", null);
			//alertView.Show ();

			//use UIAlertController instead of UIAlertView...
			var alert = UIAlertController.Create("Alert", message, UIAlertControllerStyle.Alert); 			alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null)); 			return alert; 		} 
	}
}