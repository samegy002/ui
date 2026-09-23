using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BICloudToolkit.Controls
{
    public enum ActionButtonIcon
    {
        None,
        BlockOta,
        Activate,
        ExitRecovery,
        ReadDevice
    }

    /// <summary>
    /// Custom styled action button with solid or bordered futuristic styling,
    /// vector icon rendering, and anti-aliased rounded corners.
    /// </summary>
    public class ActionButton : Control
    {
        private ActionButtonIcon _icon = ActionButtonIcon.None;
        private Color _buttonColor = Theme.AccentDarkSlate;
        private Color _hoverColor = Theme.AccentDarkSlateHover;
        private Color _borderColor = Theme.BorderDefault;
        private Color _textColor = Theme.TextPrimary;
        private int _cornerRadius = 8;
        private bool _isHovered = false;
        private bool _isPressed = false;

        [Category("Appearance")]
        public ActionButtonIcon Icon
        {
            get => _icon;
            set { _icon = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color ButtonColor
        {
            get => _buttonColor;
            set { _buttonColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color TextColor
        {
            get => _textColor;
            set { _textColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(8)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        public ActionButton()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Size = new Size(130, 38);
            Cursor = Cursors.Hand;
            Font = Theme.FontSubtitle;
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
                $"Action '{Text}' triggered.\nDemo action — no device operation performed.",
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

            Color fill = _isPressed ? Color.FromArgb(
                             Math.Max(0, _buttonColor.R - 20),
                             Math.Max(0, _buttonColor.G - 20),
                             Math.Max(0, _buttonColor.B - 20)) :
                         _isHovered ? _hoverColor : _buttonColor;

            // Background Fill
            using (var brush = new SolidBrush(fill))
            {
                Theme.FillRoundedRectangle(g, brush, rect, _cornerRadius);
            }

            // Optional Border
            if (_borderColor != Color.Transparent)
            {
                using var pen = new Pen(_borderColor, 1f);
                Theme.DrawRoundedRectangle(g, pen, rect, _cornerRadius);
            }

            // Calculate content placement (icon + text centered)
            int iconSize = 16;
            bool hasIcon = _icon != ActionButtonIcon.None;
            var textSize = TextRenderer.MeasureText(Text, Font);

            int totalContentWidth = (hasIcon ? iconSize + 8 : 0) + textSize.Width;
            int startX = Math.Max(6, (Width - totalContentWidth) / 2);

            if (hasIcon)
            {
                int iconY = (Height - iconSize) / 2;
                var iconRect = new Rectangle(startX, iconY, iconSize, iconSize);

                switch (_icon)
                {
                    case ActionButtonIcon.BlockOta:
                        GdiIcons.DrawRefresh(g, iconRect, _textColor);
                        break;
                    case ActionButtonIcon.Activate:
                        GdiIcons.DrawLightning(g, iconRect, _textColor);
                        break;
                    case ActionButtonIcon.ExitRecovery:
                        GdiIcons.DrawPower(g, iconRect, _textColor);
                        break;
                    case ActionButtonIcon.ReadDevice:
                        GdiIcons.DrawLightning(g, iconRect, _textColor);
                        break;
                }

                startX += iconSize + 8;
            }

            var textRect = new Rectangle(startX, 0, Width - startX - 4, Height);
            TextRenderer.DrawText(g, Text, Font, textRect, _textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }
}
