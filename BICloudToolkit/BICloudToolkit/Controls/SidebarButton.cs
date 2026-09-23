using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BICloudToolkit.Controls
{
    public enum SidebarIconType
    {
        Home,
        DeviceInfo,
        BypassTools,
        Toolbox,
        Settings,
        About
    }

    /// <summary>
    /// Sidebar navigation button with modern pill styling, crisp vector icon,
    /// and active/hover states.
    /// </summary>
    public class SidebarButton : Control
    {
        private bool _isActive = false;
        private bool _isHovered = false;
        private SidebarIconType _iconType = SidebarIconType.Home;
        private int _cornerRadius = 10;

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool IsActive
        {
            get => _isActive;
            set { _isActive = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(SidebarIconType.Home)]
        public SidebarIconType IconType
        {
            get => _iconType;
            set { _iconType = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(10)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        public SidebarButton()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(200, 42);
            Cursor = Cursors.Hand;
            Font = Theme.FontBody;
            ForeColor = Theme.TextSecondary;
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

            // Background Fill
            if (_isActive)
            {
                using var brush = new SolidBrush(Theme.AccentBlue);
                Theme.FillRoundedRectangle(g, brush, rect, _cornerRadius);
            }
            else if (_isHovered)
            {
                using var brush = new SolidBrush(Color.FromArgb(24, 32, 49));
                Theme.FillRoundedRectangle(g, brush, rect, _cornerRadius);
            }

            // Colors for Icon and Text
            Color contentColor = _isActive ? Color.White : (_isHovered ? Theme.TextPrimary : Theme.TextSecondary);

            // Draw Icon
            int iconSize = 18;
            int iconX = 14;
            int iconY = (Height - iconSize) / 2;
            var iconRect = new Rectangle(iconX, iconY, iconSize, iconSize);

            switch (_iconType)
            {
                case SidebarIconType.Home:
                    GdiIcons.DrawHome(g, iconRect, contentColor);
                    break;
                case SidebarIconType.DeviceInfo:
                    GdiIcons.DrawPhone(g, iconRect, contentColor);
                    break;
                case SidebarIconType.BypassTools:
                    GdiIcons.DrawWrench(g, iconRect, contentColor);
                    break;
                case SidebarIconType.Toolbox:
                    GdiIcons.DrawToolbox(g, iconRect, contentColor);
                    break;
                case SidebarIconType.Settings:
                    GdiIcons.DrawSettings(g, iconRect, contentColor);
                    break;
                case SidebarIconType.About:
                    GdiIcons.DrawAbout(g, iconRect, contentColor);
                    break;
            }

            // Draw Text
            int textX = iconX + iconSize + 12;
            var textRect = new Rectangle(textX, 0, Width - textX - 8, Height);
            TextRenderer.DrawText(g, Text, Font, textRect, contentColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }
}
