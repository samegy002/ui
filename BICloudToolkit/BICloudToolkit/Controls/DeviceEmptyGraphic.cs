using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BICloudToolkit.Controls
{
    /// <summary>
    /// Custom GDI+ vector illustration rendering the empty state disconnected iPhone
    /// graphic matching the reference image.
    /// </summary>
    public class DeviceEmptyGraphic : Control
    {
        public DeviceEmptyGraphic()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(140, 150);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = 70;
            int h = 120;
            int x = (Width - w) / 2;
            int y = (Height - h) / 2;

            var phoneRect = new Rectangle(x, y, w, h);

            // Phone outline
            Color phoneOutlineColor = Color.FromArgb(70, 130, 180);
            using (var pen = new Pen(phoneOutlineColor, 1.8f))
            {
                Theme.DrawRoundedRectangle(g, pen, phoneRect, 14);
            }

            // Top speaker notch
            using (var notchPen = new Pen(phoneOutlineColor, 1.5f) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawLine(notchPen, x + w / 2 - 8, y + 6, x + w / 2 + 8, y + 6);
            }

            // Top-left: Battery slash
            using (var batPen = new Pen(Color.FromArgb(100, 150, 190), 1.2f))
            {
                g.DrawRectangle(batPen, x + 10, y + 15, 14, 8);
                g.DrawLine(batPen, x + 24, y + 17, x + 24, y + 21);
                // slash
                g.DrawLine(new Pen(Color.FromArgb(239, 68, 68), 1.2f), x + 8, y + 24, x + 26, y + 14);
            }

            // Top-right: Wifi slash
            using (var wifiPen = new Pen(Color.FromArgb(100, 150, 190), 1.2f))
            {
                g.DrawArc(wifiPen, x + w - 24, y + 14, 14, 14, 210, 120);
                g.DrawArc(wifiPen, x + w - 21, y + 17, 8, 8, 210, 120);
                // slash
                g.DrawLine(new Pen(Color.FromArgb(239, 68, 68), 1.2f), x + w - 26, y + 24, x + w - 8, y + 14);
            }

            // Large Center "X"
            using (var xPen = new Pen(Color.FromArgb(110, 160, 210), 2.2f) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                int cx = x + w / 2;
                int cy = y + h / 2 - 2;
                int s = 10;
                g.DrawLine(xPen, cx - s, cy - s, cx + s, cy + s);
                g.DrawLine(xPen, cx + s, cy - s, cx - s, cy + s);
            }

            // Bottom Signal bars & small red cross
            using (var barBrush = new SolidBrush(Color.FromArgb(80, 130, 180)))
            {
                for (int i = 0; i < 4; i++)
                {
                    int bh = 3 + i * 2;
                    g.FillRectangle(barBrush, x + 12 + i * 4, y + h - 25 - bh, 2, bh);
                }
            }
            using (var redPen = new Pen(Color.FromArgb(239, 68, 68), 1.2f))
            {
                g.DrawLine(redPen, x + 30, y + h - 30, x + 34, y + h - 26);
                g.DrawLine(redPen, x + 34, y + h - 30, x + 30, y + h - 26);
            }

            // Bottom miniature dock icons (bell, lock, power)
            using (var iconPen = new Pen(Color.FromArgb(90, 130, 170), 1.2f))
            {
                // Bell
                g.DrawArc(iconPen, x + 14, y + h - 14, 6, 6, 180, 180);
                g.DrawLine(iconPen, x + 12, y + h - 8, x + 22, y + h - 8);

                // Lock
                g.DrawRectangle(iconPen, x + w / 2 - 3, y + h - 11, 6, 5);
                g.DrawArc(iconPen, x + w / 2 - 2, y + h - 14, 4, 4, 180, 180);

                // Power
                g.DrawArc(iconPen, x + w - 20, y + h - 12, 6, 6, -60, 300);
                g.DrawLine(iconPen, x + w - 17, y + h - 13, x + w - 17, y + h - 10);
            }
        }
    }
}
