using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizationsApp.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("CustomizationsApp")]
[assembly: ExportEffect(typeof(IOSEntryRemoveLineEffect), "RemoveLineEffect")]
namespace CustomizationsApp.iOS.Effects
{
    public class IOSEntryRemoveLineEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is UITextField element)
            {
                element.BorderStyle = UITextBorderStyle.None;
            }
        }

        protected override void OnDetached()
        {
          
        }
    }
}