using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BICloudToolkit.Controls
{
    public enum FeatureCardType
    {
        A12Bypass,
        RamdiskBypass,
        JailbreakBypass,
        MdmBypass,
        Toolbox
    }

    /// <summary>
    /// Interactive feature card component matching the exact cards shown in the center dashboard.
    /// Includes custom vector icon squircle, high-contrast typography, border accenting, and chevron.
    /// </summary>
    public class FeatureCard : Control
    {
        private FeatureCardType _cardType = FeatureCardType.A12Bypass;
        private string _title = "A12+ Bypass";
        private string _subtitle = "IOS 26.0.1 / 26.1";
        private Color _accentColor = Theme.AccentBlue;
        private bool _isHovered = false;
        private bool _isPressed = false;
        private int _cornerRadius = 14;

        [Category("Appearance")]
        public FeatureCardType CardType
        {
            get => _cardType;
            set
            {
                _cardType = value;
                ApplyDefaultMetadata();
                Invalidate();
            }
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
        public Color AccentColor
        {
            get => _accentColor;
            set { _accentColor = value; Invalidate(); }
        }

        public FeatureCard()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(260, 68);
            Cursor = Cursors.Hand;
            BackColor = Color.Transparent;
        }

        public void ApplyDefaultMetadata()
        {
            switch (_cardType)
            {
                case FeatureCardType.A12Bypass:
                    _title = "A12+ Bypass";
                    _subtitle = "IOS 26.0.1 / 26.1";
                    _accentColor = Theme.AccentBlue;
                    break;
                case FeatureCardType.RamdiskBypass:
                    _title = "Ramdisk Bypass";
                    _subtitle = "IPHONE 6 TO X";
                    _accentColor = Theme.AccentPurple;
                    break;
                case FeatureCardType.JailbreakBypass:
                    _title = "Jailbreak Bypass";
                    _subtitle = "IPHONE 5S TO X";
                    _accentColor = Theme.AccentEmerald;
                    break;
                case FeatureCardType.MdmBypass:
                    _title = "MDM Bypass";
                    _subtitle = "ALL IOS / IPHONE / IPAD";
                    _accentColor = Theme.AccentAmber;
                    break;
                case FeatureCardType.Toolbox:
                    _title = "ToolBox";
                    _subtitle = "PURPLEMODE (MAGICCFFG)";
                    _accentColor = Color.FromArgb(56, 189, 248); // Cyan
                    break;
            }
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
            _isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _isPressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isPressed = false;
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            // Requirement 11: Demo action — no device operation performed.
            MessageBox.Show(
                $"Demo action: {_title} selected.\nNo device operation performed.",
                "B-ICLOUD Demo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            // Background Color
            Color bgColor = _isPressed ? Color.FromArgb(14, 20, 32) :
                            _isHovered ? Theme.CardBackgroundHover : Theme.CardBackground;

            using (var brush = new SolidBrush(bgColor))
            {
                Theme.FillRoundedRectangle(g, brush, rect, _cornerRadius);
            }

            // Border with Accent Color
            using (var pen = new Pen(_accentColor, _isHovered ? 2f : 1.5f))
            {
                Theme.DrawRoundedRectangle(g, pen, rect, _cornerRadius);
            }

            // Left Icon Squircle container
            int iconBoxSize = 42;
            int iconBoxX = 14;
            int iconBoxY = (Height - iconBoxSize) / 2;
            var iconBoxRect = new Rectangle(iconBoxX, iconBoxY, iconBoxSize, iconBoxSize);

            using (var boxBrush = new SolidBrush(Color.FromArgb(16, 21, 35)))
            {
                Theme.FillRoundedRectangle(g, boxBrush, iconBoxRect, 10);
            }
            using (var boxPen = new Pen(Color.FromArgb(32, 43, 67), 1f))
            {
                Theme.DrawRoundedRectangle(g, boxPen, iconBoxRect, 10);
            }

            // Draw Icon inside Box
            int iconInnerSize = 22;
            var innerIconRect = new Rectangle(
                iconBoxX + (iconBoxSize - iconInnerSize) / 2,
                iconBoxY + (iconBoxSize - iconInnerSize) / 2,
                iconInnerSize,
                iconInnerSize);

            switch (_cardType)
            {
                case FeatureCardType.A12Bypass:
                    GdiIcons.DrawChip(g, innerIconRect, _accentColor);
                    break;
                case FeatureCardType.RamdiskBypass:
                    GdiIcons.DrawRamdisk(g, innerIconRect, _accentColor);
                    break;
                case FeatureCardType.JailbreakBypass:
                    GdiIcons.DrawLock(g, innerIconRect, _accentColor);
                    break;
                case FeatureCardType.MdmBypass:
                    GdiIcons.DrawShield(g, innerIconRect, _accentColor);
                    break;
                case FeatureCardType.Toolbox:
                    GdiIcons.DrawToolbox(g, innerIconRect, _accentColor);
                    break;
            }

            // Text layout
            int textX = iconBoxX + iconBoxSize + 14;
            int textAvailableWidth = Width - textX - 35;

            // Title
            using var titleFont = Theme.FontCardTitle;
            var titleRect = new Rectangle(textX, iconBoxY + 2, textAvailableWidth, 20);
            TextRenderer.DrawText(g, _title, titleFont, titleRect, Theme.TextPrimary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            // Subtitle
            using var subFont = Theme.FontSubtitle;
            var subRect = new Rectangle(textX, iconBoxY + 22, textAvailableWidth, 18);
            TextRenderer.DrawText(g, _subtitle.ToUpperInvariant(), subFont, subRect, Theme.TextSecondary,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            // Right Chevron
            int chevSize = 16;
            int chevX = Width - 24;
            int chevY = (Height - chevSize) / 2;
            var chevRect = new Rectangle(chevX, chevY, chevSize, chevSize);
            GdiIcons.DrawChevronRight(g, chevRect, _isHovered ? Theme.TextPrimary : Theme.TextMuted);
        }
    }
}
