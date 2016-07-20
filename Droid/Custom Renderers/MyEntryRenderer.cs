using LoginNavigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace LoginNavigation
{

    class MyEntryRenderer : EntryRenderer
    {
        //protected override void OnDraw(Canvas canvas)
        //{
        //    base.OnDraw(canvas);

        //    Paint p = new Paint();
        //    p.Color = Android.Graphics.Color.Maroon;
        //    canvas.DrawColor(Android.Graphics.Color.Olive);

        //    Rect rect = new Rect(0, 0, 3, 3);
        //    var rectF = new RectF(rect);


        //    canvas.DrawRoundRect(rectF, 1, 1, p);
            
              
        //}

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);

                Control.SetPadding(30, 1, 5, 1);

                GradientDrawable gd = new GradientDrawable();
                gd.SetShape(ShapeType.Rectangle);
                gd.SetStroke(1, Android.Graphics.Color.LightCyan);
                gd.SetCornerRadius(5);

                Control.SetBackground(gd);

                
            }
        }

    }
}
