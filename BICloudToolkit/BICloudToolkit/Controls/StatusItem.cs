using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BICloudToolkit.Controls
{
    public enum StatusItemIcon
    {
        Chip,
        Disk,
        Lock,
        Shield
    }

    /// <summary>
    /// Status monitor list row with rounded container, icon squircle, text descriptions,
    /// and live status indicator dot.
    /// </summary>
    public class StatusItem : Control
    {
        private StatusItemIcon _icon = StatusItemIcon.Chip;
        private string _title = "A12+ Bypass";
        private string _subtitle = "iOS 26.0.1 / 26.1";
        private bool _isActive = true;
        private Color _activeDotColor = Theme.AccentPurple;
        private int _cornerRadius = 10;
        private bool _isHovered = false;

        [Category("Appearance")]
        public StatusItemIcon Icon
        {
            get => _icon;
            set { _icon = value; Invalidate(); }
        }

        [Category("Appearance")]
        public string Title
        {
            get => _title;
            set { _title = value; Invalidate(); }
        }

        [Category("Appearance")]
        public string Subtitle
        {
            get => _subtitle;
            set { _subtitle = value; Invalidate(); }
        }

        [Category("Appearance")]
        public bool IsActive
        {
            get => _isActive;
            set { _isActive = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color ActiveDotColor
        {
            get => _activeDotColor;
            set { _activeDotColor = value; Invalidate(); }
        }

        public StatusItem()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(270, 52);
            BackColor = Color.Transparent;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            // Background Fill
            Color fill = _isHovered ? Color.FromArgb(22, 28, 44) : Color.FromArgb(17, 23, 36);
            using (var brush = new SolidBrush(fill))
            {
                Theme.FillRoundedRectangle(g, brush, rect, _cornerRadius);
            }

            // Border
            using (var pen = new Pen(Color.FromArgb(28, 36, 52), 1f))
            {
                Theme.DrawRoundedRectangle(g, pen, rect, _cornerRadius);
            }

            // Icon squircle
            int iconBoxSize = 34;
            int iconBoxX = 10;
            int iconBoxY = (Height - iconBoxSize) / 2;
            var iconBoxRect = new Rectangle(iconBoxX, iconBoxY, iconBoxSize, iconBoxSize);

            using (var brush = new SolidBrush(Color.FromArgb(23, 29, 44)))
            {
                Theme.FillRoundedRectangle(g, brush, iconBoxRect, 8);
            }

            // Icon
            int iconSize = 16;
            var innerIconRect = new Rectangle(
                iconBoxX + (iconBoxSize - iconSize) / 2,
                iconBoxY + (iconBoxSize - iconSize) / 2,
                iconSize,
                iconSize);

            Color iconCol = _isHovered ? Theme.TextPrimary : Theme.TextSecondary;
            switch (_icon)
            {
                case StatusItemIcon.Chip:
                    GdiIcons.DrawChip(g, innerIconRect, iconCol);
                    break;
                case StatusItemIcon.Disk:
                    GdiIcons.DrawRamdisk(g, innerIconRect, iconCol);
                    break;
                case StatusItemIcon.Lock:
                    GdiIcons.DrawLock(g, innerIconRect, iconCol);
                    break;
                case StatusItemIcon.Shield:
                    GdiIcons.DrawShield(g, innerIconRect, iconCol);
                    break;
            }

            // Text
            int textX = iconBoxX + iconBoxSize + 10;
            int textWidth = Width - textX - 35;

            using var titleFont = Theme.FontSubtitle;
            var titleRect = new Rectangle(textX, iconBoxY, textWidth, 18);
            TextRenderer.DrawText(g, _title, titleFont, titleRect, Theme.TextPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            using var subFont = Theme.FontSmall;
            var subRect = new Rectangle(textX, iconBoxY + 16, textWidth, 16);
            TextRenderer.DrawText(g, _subtitle, subFont, subRect, Theme.TextMuted,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            // Status Indicator Dot
            int dotSize = 8;
            int dotX = Width - 20;
            int dotY = (Height - dotSize) / 2;

            if (_isActive)
            {
                // Glowing outer halo
                using var glowBrush = new SolidBrush(Color.FromArgb(60, _activeDotColor));
                g.FillEllipse(glowBrush, dotX - 2, dotY - 2, dotSize + 4, dotSize + 4);

                using var dotBrush = new SolidBrush(_activeDotColor);
                g.FillEllipse(dotBrush, dotX, dotY, dotSize, dotSize);
            }
            else
            {
                using var dotBrush = new SolidBrush(Color.FromArgb(45, 55, 75));
                g.FillEllipse(dotBrush, dotX, dotY, dotSize, dotSize);
            }
        }
    }
}
