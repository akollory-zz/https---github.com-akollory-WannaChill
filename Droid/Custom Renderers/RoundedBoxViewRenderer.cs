using System;
using Xamarin.Forms;
using RBVRenderer;
using RBVRenderer.Android;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;


[assembly: ExportRendererAttribute(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]

namespace RBVRenderer.Android
{
    public class RoundedBoxViewRenderer : EntryRenderer
    {
        public RoundedBoxViewRenderer()
        {
            this.SetWillNotDraw(false);
        }

        public override void Draw(Canvas canvas)
        {
            RoundedBoxView rbv = new RoundedBoxView();

            Rect rc = new Rect();
            GetDrawingRect(rc);

            Rect interior = rc;
            interior.Inset((int)rbv.StrokeThickness, (int)rbv.StrokeThickness);

            Paint p = new Paint()
            {
                Color = rbv.Color.ToAndroid(),
                AntiAlias = true,
            };

            canvas.DrawRoundRect(new RectF(interior), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);

            p.Color = rbv.Stroke.ToAndroid();
            p.StrokeWidth = (float)rbv.StrokeThickness;
            p.SetStyle(Paint.Style.Stroke);

            canvas.DrawRoundRect(new RectF(rc), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);
        }


    }
}

