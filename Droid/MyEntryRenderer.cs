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
using Xamarin.Forms;
using LoginNavigation;
using LoginNavigation.Droid;
using Xamarin.Forms.Platform.Android;
using Element = Android.Renderscripts.Element;

[assembly: ExportRenderer(typeof(MyEntry), typeof(LoginNavigation.Droid.MyEntryRenderer))]
namespace LoginNavigation.Droid
{
    class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightCoral);

            }

        }

    }
}