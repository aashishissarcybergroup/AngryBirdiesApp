// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AngryBirdies
{
    [Register ("SignUp")]
    partial class SignUp
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton backToLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton clickSignUp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl SegmentGender { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtConfirmPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtHandicaped { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtLname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPasswords { get; set; }

        [Action ("BackToLogin_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BackToLogin_TouchUpInside (UIKit.UIButton sender);

        [Action ("ClickSignUp_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClickSignUp_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (backToLogin != null) {
                backToLogin.Dispose ();
                backToLogin = null;
            }

            if (clickSignUp != null) {
                clickSignUp.Dispose ();
                clickSignUp = null;
            }

            if (SegmentGender != null) {
                SegmentGender.Dispose ();
                SegmentGender = null;
            }

            if (txtConfirmPassword != null) {
                txtConfirmPassword.Dispose ();
                txtConfirmPassword = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
            }

            if (txtFname != null) {
                txtFname.Dispose ();
                txtFname = null;
            }

            if (txtHandicaped != null) {
                txtHandicaped.Dispose ();
                txtHandicaped = null;
            }

            if (txtLname != null) {
                txtLname.Dispose ();
                txtLname = null;
            }

            if (txtPasswords != null) {
                txtPasswords.Dispose ();
                txtPasswords = null;
            }
        }
    }
}