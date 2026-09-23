using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BICloudToolkit.Controls
{
    /// <summary>
    /// A flicker-free Panel with customizable rounded corners, background fill,
    /// and outer border color.
    /// </summary>
    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 12;
        private Color _fillColor = Theme.SurfaceBackground;
        private Color _borderColor = Theme.BorderDefault;
        private float _borderWidth = 1f;

        [Category("Appearance")]
        [DefaultValue(12)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        public Color FillColor
        {
            get => _fillColor;
            set { _fillColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(1f)]
        public float BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = Math.Max(0f, value); Invalidate(); }
        }

        public RoundedPanel()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            BackColor = Color.Transparent;
            Padding = new Padding(12);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            // Fill
            using (var brush = new SolidBrush(_fillColor))
            {
                Theme.FillRoundedRectangle(e.Graphics, brush, rect, _cornerRadius);
            }

            // Border
            if (_borderWidth > 0 && _borderColor != Color.Transparent)
            {
                using var pen = new Pen(_borderColor, _borderWidth);
                Theme.DrawRoundedRectangle(e.Graphics, pen, rect, _cornerRadius);
            }

            base.OnPaint(e);
        }
    }
}
