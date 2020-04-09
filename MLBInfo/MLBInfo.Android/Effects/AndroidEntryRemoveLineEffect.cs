using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomizationsApp.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("CustomizationsApp")]
[assembly: ExportEffect(typeof(AndroidEntryRemoveLineEffect), "RemoveLineEffect")]
namespace CustomizationsApp.Droid.Effects
{
    class AndroidEntryRemoveLineEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control != null)
            {
                Control.SetBackground(null);
            }

        }

        protected override void OnDetached()
        {
           
        }
    }
}