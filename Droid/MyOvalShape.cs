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
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Graphics.Drawables.Shapes;

namespace LoginNavigation.Droid
{
    public class MyOvalShape : View
    {

        private readonly ShapeDrawable _shape;
        public MyOvalShape(Context content) : base(content)
        {

            var paint = new Paint();
            paint.SetARGB(225, 200, 255, 0);
            paint.SetStyle(Paint.Style.Stroke);
            paint.StrokeWidth = 4;

            _shape = new ShapeDrawable(new OvalShape());
            _shape.Paint.Set(paint);
            _shape.SetBounds(20, 30, 300, 300);
            

        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);    

        }


    }


}