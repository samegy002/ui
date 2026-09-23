using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BICloudToolkit.Controls
{
    /// <summary>
    /// Vector drawing methods using GDI+ for crisp, resolution-independent icons
    /// that require zero external assets or image dependencies at runtime.
    /// </summary>
    public static class GdiIcons
    {
        public static void DrawChip(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };
            using var fillBrush = new SolidBrush(Color.FromArgb(20, color));

            int pad = Math.Max(2, r.Width / 4);
            var centerRect = new Rectangle(r.X + pad, r.Y + pad, r.Width - pad * 2, r.Height - pad * 2);

            // Core chip body
            g.FillRectangle(fillBrush, centerRect);
            g.DrawRectangle(pen, centerRect);

            // Inner core square
            int innerPad = Math.Max(2, centerRect.Width / 4);
            var innerRect = new Rectangle(centerRect.X + innerPad, centerRect.Y + innerPad, centerRect.Width - innerPad * 2, centerRect.Height - innerPad * 2);
            g.DrawRectangle(pen, innerRect);

            // Pins (top & bottom)
            int pinLen = pad - 1;
            for (int i = 1; i <= 2; i++)
            {
                int x = centerRect.X + (centerRect.Width * i) / 3;
                g.DrawLine(pen, x, centerRect.Top, x, centerRect.Top - pinLen);
                g.DrawLine(pen, x, centerRect.Bottom, x, centerRect.Bottom + pinLen);
            }
            // Pins (left & right)
            for (int i = 1; i <= 2; i++)
            {
                int y = centerRect.Y + (centerRect.Height * i) / 3;
                g.DrawLine(pen, centerRect.Left, y, centerRect.Left - pinLen, y);
                g.DrawLine(pen, centerRect.Right, y, centerRect.Right + pinLen, y);
            }
        }

        public static void DrawRamdisk(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };
            using var brush = new SolidBrush(color);

            int x = r.X + 2;
            int y = r.Y + r.Height / 4;
            int w = r.Width - 4;
            int h = r.Height / 2;

            // Disk shelf / tray outline
            g.DrawRectangle(pen, x, y, w, h);

            // Disk slot lines
            g.DrawLine(pen, x + 4, y + h / 2, x + w - 12, y + h / 2);
            // Activity indicator dot
            g.FillEllipse(brush, x + w - 7, y + h / 2 - 2, 4, 4);

            // Top rack line
            g.DrawLine(pen, x + 3, y - 3, x + w - 3, y - 3);
        }

        public static void DrawLock(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };
            using var fillBrush = new SolidBrush(color);

            int bw = (r.Width * 3) / 4;
            int bh = (r.Height * 5) / 10;
            int bx = r.X + (r.Width - bw) / 2;
            int by = r.Y + r.Height - bh - 2;

            // Lock body
            g.DrawRectangle(pen, bx, by, bw, bh);

            // Lock shackle (curved arch)
            int sw = bw * 2 / 3;
            int sx = r.X + (r.Width - sw) / 2;
            int sh = (r.Height * 4) / 10;
            int sy = by - sh + 2;

            var path = new GraphicsPath();
            path.AddArc(sx, sy, sw, sh, 180, 180);
            path.AddLine(sx + sw, sy + sh / 2, sx + sw, by);
            g.DrawPath(pen, path);

            // Keyhole
            g.FillEllipse(fillBrush, bx + bw / 2 - 2, by + bh / 3, 4, 4);
            g.DrawLine(pen, bx + bw / 2, by + bh / 3 + 2, bx + bw / 2, by + bh * 2 / 3);
        }

        public static void DrawShield(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };

            int x = r.X + 2;
            int y = r.Y + 2;
            int w = r.Width - 4;
            int h = r.Height - 4;

            var path = new GraphicsPath();
            path.AddLine(x, y, x + w, y);
            path.AddLine(x + w, y, x + w, y + h / 2);
            path.AddBezier(x + w, y + h / 2, x + w, y + h, x + w / 2, y + h, x + w / 2, y + h);
            path.AddBezier(x + w / 2, y + h, x, y + h, x, y + h / 2, x, y + h / 2);
            path.CloseFigure();

            g.DrawPath(pen, path);

            // Inner checkmark
            g.DrawLine(pen, x + w / 3, y + h / 2, x + w / 2 - 1, y + h * 2 / 3);
            g.DrawLine(pen, x + w / 2 - 1, y + h * 2 / 3, x + w * 2 / 3 + 1, y + h / 3 + 1);
        }

        public static void DrawToolbox(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };

            int x = r.X + 2;
            int y = r.Y + r.Height / 3;
            int w = r.Width - 4;
            int h = (r.Height * 3) / 5;

            // Box outline
            g.DrawRectangle(pen, x, y, w, h);

            // Latches / center clasp
            g.DrawRectangle(pen, x + w / 2 - 3, y + 2, 6, 5);

            // Handle
            int hw = w / 3;
            int hx = r.X + (r.Width - hw) / 2;
            g.DrawLine(pen, hx, y, hx, y - 5);
            g.DrawLine(pen, hx, y - 5, hx + hw, y - 5);
            g.DrawLine(pen, hx + hw, y - 5, hx + hw, y);
        }

        public static void DrawHome(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };

            int x = r.X + 2;
            int y = r.Y + 2;
            int w = r.Width - 4;
            int h = r.Height - 4;

            var path = new GraphicsPath();
            // Roof peak
            path.AddLine(x + w / 2, y, x + w, y + h / 2);
            path.AddLine(x + w, y + h / 2, x + w - 2, y + h / 2);
            path.AddLine(x + w - 2, y + h, x + 2, y + h);
            path.AddLine(x + 2, y + h, x + 2, y + h / 2);
            path.CloseFigure();

            g.DrawPath(pen, path);
            // Door
            g.DrawRectangle(pen, x + w / 2 - 3, y + h - 6, 6, 6);
        }

        public static void DrawPhone(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };

            int pw = (r.Width * 6) / 10;
            int ph = r.Height - 4;
            int px = r.X + (r.Width - pw) / 2;
            int py = r.Y + 2;

            g.DrawRectangle(pen, px, py, pw, ph);
            // Speaker
            g.DrawLine(pen, px + pw / 2 - 3, py + 3, px + pw / 2 + 3, py + 3);
            // Home indicator
            g.DrawLine(pen, px + pw / 2 - 4, py + ph - 4, px + pw / 2 + 4, py + ph - 4);
        }

        public static void DrawSettings(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f);
            int cx = r.X + r.Width / 2;
            int cy = r.Y + r.Height / 2;
            int radius = r.Width / 3;

            g.DrawEllipse(pen, cx - radius, cy - radius, radius * 2, radius * 2);
            g.DrawEllipse(pen, cx - radius / 2, cy - radius / 2, radius, radius);

            // Cogs
            for (int i = 0; i < 8; i++)
            {
                double angle = i * Math.PI / 4.0;
                int x1 = (int)(cx + Math.Cos(angle) * radius);
                int y1 = (int)(cy + Math.Sin(angle) * radius);
                int x2 = (int)(cx + Math.Cos(angle) * (radius + 3));
                int y2 = (int)(cy + Math.Sin(angle) * (radius + 3));
                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public static void DrawAbout(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f);
            using var brush = new SolidBrush(color);

            int d = Math.Min(r.Width, r.Height) - 4;
            int x = r.X + (r.Width - d) / 2;
            int y = r.Y + (r.Height - d) / 2;

            g.DrawEllipse(pen, x, y, d, d);
            // Dot
            g.FillEllipse(brush, x + d / 2 - 1, y + d / 4, 3, 3);
            // Stem
            g.DrawLine(pen, x + d / 2, y + d / 2 - 1, x + d / 2, y + (d * 3) / 4);
        }

        public static void DrawWrench(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };
            int x = r.X + 3;
            int y = r.Y + 3;
            int w = r.Width - 6;
            int h = r.Height - 6;

            g.DrawLine(pen, x, y + h, x + w * 2 / 3, y + h / 3);
            g.DrawArc(pen, x + w / 2, y, w / 2, h / 2, 225, 270);
        }

        public static void DrawAppleLogo(Graphics g, Rectangle r, Color color)
        {
            using var brush = new SolidBrush(color);
            using var pen = new Pen(color, 1.5f);

            int cx = r.X + r.Width / 2;
            int cy = r.Y + r.Height / 2 + 1;
            int size = Math.Min(r.Width, r.Height) - 4;

            // Simplified apple body
            g.FillEllipse(brush, cx - size / 2, cy - size / 2, size * 9 / 10, size);
            // Stem / leaf
            g.DrawBezier(pen, cx, cy - size / 2, cx + 2, cy - size / 2 - 3, cx + 4, cy - size / 2 - 2, cx + 3, cy - size / 2 + 1);
        }

        public static void DrawChevronRight(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 2f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            int cx = r.X + r.Width / 2;
            int cy = r.Y + r.Height / 2;
            g.DrawLine(pen, cx - 3, cy - 5, cx + 3, cy);
            g.DrawLine(pen, cx + 3, cy, cx - 3, cy + 5);
        }

        public static void DrawRefresh(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { LineJoin = LineJoin.Round, StartCap = LineCap.Round, EndCap = LineCap.Round };
            int d = Math.Min(r.Width, r.Height) - 6;
            int x = r.X + (r.Width - d) / 2;
            int y = r.Y + (r.Height - d) / 2;

            g.DrawArc(pen, x, y, d, d, 45, 270);
            // Arrowhead
            int ax = x + d - 2;
            int ay = y + d / 3;
            g.DrawLine(pen, ax, ay, ax + 4, ay - 2);
            g.DrawLine(pen, ax, ay, ax + 2, ay + 4);
        }

        public static void DrawLightning(Graphics g, Rectangle r, Color color)
        {
            using var brush = new SolidBrush(color);
            int cx = r.X + r.Width / 2;
            int cy = r.Y + r.Height / 2;

            Point[] pts = {
                new Point(cx + 1, cy - 7),
                new Point(cx - 5, cy),
                new Point(cx - 1, cy),
                new Point(cx - 2, cy + 7),
                new Point(cx + 5, cy - 1),
                new Point(cx + 1, cy - 1)
            };
            g.FillPolygon(brush, pts);
        }

        public static void DrawPower(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 2f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            int d = Math.Min(r.Width, r.Height) - 6;
            int x = r.X + (r.Width - d) / 2;
            int y = r.Y + (r.Height - d) / 2;

            g.DrawArc(pen, x, y, d, d, -60, 300);
            g.DrawLine(pen, x + d / 2, y - 1, x + d / 2, y + d / 2 - 1);
        }

        public static void DrawExclamationCircle(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f);
            using var brush = new SolidBrush(color);

            int d = Math.Min(r.Width, r.Height) - 4;
            int x = r.X + (r.Width - d) / 2;
            int y = r.Y + (r.Height - d) / 2;

            g.DrawEllipse(pen, x, y, d, d);
            g.DrawLine(new Pen(color, 2f) { StartCap = LineCap.Round, EndCap = LineCap.Round }, x + d / 2, y + d / 4, x + d / 2, y + d * 5 / 8);
            g.FillEllipse(brush, x + d / 2 - 1.5f, y + d * 3 / 4, 3, 3);
        }

        public static void DrawClose(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.5f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            int cx = r.X + r.Width / 2;
            int cy = r.Y + r.Height / 2;
            g.DrawLine(pen, cx - 4, cy - 4, cx + 4, cy + 4);
            g.DrawLine(pen, cx + 4, cy - 4, cx - 4, cy + 4);
        }

        public static void DrawDisconnected(Graphics g, Rectangle r, Color color)
        {
            using var pen = new Pen(color, 1.8f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            int cx = r.X + r.Width / 2;
            int cy = r.Y + r.Height / 2;

            // Plug / broken chain symbol
            g.DrawLine(pen, cx - 5, cy - 3, cx - 2, cy - 3);
            g.DrawLine(pen, cx - 2, cy - 5, cx - 2, cy - 1);

            g.DrawLine(pen, cx + 5, cy + 3, cx + 2, cy + 3);
            g.DrawLine(pen, cx + 2, cy + 5, cx + 2, cy + 1);

            // Slash
            g.DrawLine(new Pen(color, 1.5f), cx - 6, cy + 6, cx + 6, cy - 6);
        }
    }
}
