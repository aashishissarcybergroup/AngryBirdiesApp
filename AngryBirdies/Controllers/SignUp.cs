using Foundation;
using System;
using UIKit;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AngryBirdies
{
    public partial class SignUp : UIViewController
    {
		LoadingOverlay overlayView;
        public SignUp (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad() 		{ 			base.ViewDidLoad(); 			var gestureRecognizer = new UITapGestureRecognizer(() => View.EndEditing(true)); 			gestureRecognizer.CancelsTouchesInView = false; //for iOS5 			View.AddGestureRecognizer(gestureRecognizer); 		}  		public override void ViewWillAppear(bool animated) 		{ 			base.ViewWillAppear(animated); 			NavigationController.NavigationBarHidden = true; 			txtEmail.ShouldReturn += (textField) =>
			{ 				textField.ResignFirstResponder(); 				return true; 			}; 			txtEmail.ShouldReturn += (textField) =>
			{ 				textField.ResignFirstResponder(); 				return true; 			}; 			txtPasswords.ShouldReturn += (textField) =>
			{ 				textField.ResignFirstResponder(); 				return true; 			}; 			txtConfirmPassword.ShouldReturn += (textField) =>
			{ 				textField.ResignFirstResponder(); 				return true; 			};
			txtFname.ShouldReturn += (textField) =>
			{
				textField.ResignFirstResponder();
				return true;
			};
			txtLname.ShouldReturn += (textField) =>
			{
				textField.ResignFirstResponder();
				return true;
			};
			txtHandicaped.ShouldReturn += (textField) =>
			{
				textField.ResignFirstResponder();
				return true;
			}; 		}



	  partial void BackToLogin_TouchUpInside(UIButton sender)
		{
			NavigationController.PopViewController(true);
		}

		partial void ClickSignUp_TouchUpInside(UIButton sender)
		{
			if (txtEmail.Text.Length == 0) { 				PresentViewController (Login.alertViewWithMessage ("Enter EmailId"), animated: true, completionHandler: null); 				return; 			}  else if (txtPasswords.Text.Length == 0) {  				PresentViewController (Login.alertViewWithMessage ("Enter Password"), animated: true, completionHandler: null); 				return; 			}  else if (txtConfirmPassword.Text.Length == 0) { 				PresentViewController (Login.alertViewWithMessage ("Confirm Password"), animated: true, completionHandler: null); 				return; 			}  else if (txtFname.Text.Length == 0) { 				PresentViewController (Login.alertViewWithMessage ("Enter First Name"), animated: true, completionHandler: null); 				return; 			}
			else if (txtLname.Text.Length == 0)
			{
				PresentViewController(Login.alertViewWithMessage("Enter Last Name"), animated: true, completionHandler: null);
				return;
			}
			else if (txtHandicaped.Text.Length == 0)
			{
				PresentViewController(Login.alertViewWithMessage("Enter Handicaped"), animated: true, completionHandler: null);
				return;
			} 
			else if (txtPasswords.Text != txtConfirmPassword.Text) { 				PresentViewController (Login.alertViewWithMessage ("Confirm Password Mismatch"), animated: true, completionHandler: null); 				return; 			} 
			else {
				 int value;
				var isNumeric = int.TryParse(txtHandicaped.Text, out value);
				if (value == 0)
				{
					PresentViewController(Login.alertViewWithMessage("Enter Number In Handicaped"), animated: true, completionHandler: null);
					return;
				}
				else{ 				var bounds = UIScreen.MainScreen.Bounds;  				// show the loading overlay on the UI thread using the correct orientation sizing 				overlayView = new LoadingOverlay (bounds); 				View.Add (overlayView); 				registration (); 			}
			}
		}

		//Code For Registration
		public async  void registration() 		{ 			RegisterUser userItemModel = new RegisterUser()
			{ 				Email = txtEmail.Text, 				Password = txtPasswords.Text, 				Fname = txtFname.Text, 				Lname = txtLname.Text, 				Gender = SegmentGender.SelectedSegment== 0 ? "Male" : "Female",
				Handicap = Convert.ToInt32(txtHandicaped.Text) 			};
			//Code for api 
			 using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://localhost:9000/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				// New code:
				HttpResponseMessage response = await client.GetAsync("api/products/1");
				if (response.IsSuccessStatusCode)
				{
					Product product = await response.Content.ReadAsAsync > Product > ();
					Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
				}
			}


 			//var userObject = await new CreateAccount().Registration(userItemModel); 			//overlayView.Hide(); 			//if (userObject.Status == true)
			//{ 			//	var moveToWelcomeScreen = Storyboard.InstantiateViewController(Constants.ViewControllerIndentifier.WELCOME_SCREEN) as WelcomeScreen; 			//	moveToWelcomeScreen.userData = userObject; 			//	NavigationController.PushViewController(moveToWelcomeScreen, true); 			//}
			//else { 			//	PresentViewController(Login.alertViewWithMessage(userObject.Message), animated: true, completionHandler: null); 			//} 		} 


	}
}