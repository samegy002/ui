using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BICloudToolkit
{
    /// <summary>
    /// Centralized Theme design tokens, colors, fonts, and GDI+ helper routines
    /// matching the modern dark futuristic B-ICLOUD visual specification.
    /// </summary>
    public static class Theme
    {
        // Core Palette
        public static readonly Color AppBackground = Color.FromArgb(11, 15, 25);         // Deep dark navy
        public static readonly Color HeaderBackground = Color.FromArgb(13, 18, 31);      // Top navigation bar
        public static readonly Color SidebarBackground = Color.FromArgb(11, 15, 25);     // Left navigation
        public static readonly Color SurfaceBackground = Color.FromArgb(16, 22, 36);     // Panel containers
        public static readonly Color CardBackground = Color.FromArgb(18, 25, 41);        // Feature card fill
        public static readonly Color CardBackgroundHover = Color.FromArgb(24, 33, 54);   // Feature card hover fill
        
        // Borders & Lines
        public static readonly Color BorderSubtle = Color.FromArgb(27, 36, 54);          // Subtle dividers
        public static readonly Color BorderDefault = Color.FromArgb(31, 41, 61);         // Default card border
        public static readonly Color BorderActive = Color.FromArgb(59, 130, 246);        // Focused/active border

        // Feature Accent Highlights
        public static readonly Color AccentBlue = Color.FromArgb(37, 99, 235);           // A12+ Bypass (#2563EB)
        public static readonly Color AccentBlueGlow = Color.FromArgb(59, 130, 246);      
        public static readonly Color AccentPurple = Color.FromArgb(139, 92, 246);        // Ramdisk Bypass (#8B5CF6)
        public static readonly Color AccentEmerald = Color.FromArgb(16, 185, 129);       // Jailbreak Bypass (#10B981)
        public static readonly Color AccentAmber = Color.FromArgb(245, 158, 11);         // MDM Bypass (#F59E0B)
        public static readonly Color AccentDarkSlate = Color.FromArgb(24, 30, 44);       // Neutral buttons
        public static readonly Color AccentDarkSlateHover = Color.FromArgb(34, 43, 62);
        
        // Special Containers
        public static readonly Color CreditPillBackground = Color.FromArgb(20, 25, 38);
        public static readonly Color CreditPillBorder = Color.FromArgb(45, 55, 78);
        public static readonly Color ErrorBoxBackground = Color.FromArgb(24, 18, 41);    // Right panel error container
        public static readonly Color ErrorBoxBorder = Color.FromArgb(76, 29, 149);
        public static readonly Color ErrorBoxText = Color.FromArgb(192, 132, 252);
        public static readonly Color OptimizationBg = Color.FromArgb(15, 23, 42);        // Software optimization banner
        public static readonly Color OptimizationBorder = Color.FromArgb(30, 41, 59);

        // Typography Colors
        public static readonly Color TextPrimary = Color.FromArgb(248, 250, 252);        // #F8FAFC
        public static readonly Color TextSecondary = Color.FromArgb(148, 163, 184);      // #94A3B8
        public static readonly Color TextMuted = Color.FromArgb(100, 116, 139);          // #64748B
        public static readonly Color TextDisabled = Color.FromArgb(71, 85, 105);

        // Standard Font Family
        public static readonly string FontFamily = DetectPreferredFont();

        private static string DetectPreferredFont()
        {
            try
            {
                using var testFont = new Font("Inter", 9f);
                if (testFont.Name.Equals("Inter", StringComparison.OrdinalIgnoreCase))
                    return "Inter";
            }
            catch { }
            return "Segoe UI";
        }

        // Font Generators
        public static Font FontDisplayLarge => new Font(FontFamily, 16f, FontStyle.Bold);
        public static Font FontHeader => new Font(FontFamily, 13f, FontStyle.Bold);
        public static Font FontCardTitle => new Font(FontFamily, 11.5f, FontStyle.Bold);
        public static Font FontSubtitle => new Font(FontFamily, 8.5f, FontStyle.Bold);
        public static Font FontBody => new Font(FontFamily, 9.5f, FontStyle.Regular);
        public static Font FontSmall => new Font(FontFamily, 8f, FontStyle.Regular);
        public static Font FontSmallBold => new Font(FontFamily, 8f, FontStyle.Bold);
        public static Font FontMonospace => new Font("Consolas", 8.5f, FontStyle.Regular);

        /// <summary>
        /// Creates a smooth rounded rectangle path for high DPI GDI+ rendering.
        /// </summary>
        public static GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            int diameter = radius * 2;
            var arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            // Top-left
            path.AddArc(arc, 180, 90);

            // Top-right
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static void DrawRoundedRectangle(Graphics g, Pen pen, Rectangle bounds, int radius)
        {
            using var path = CreateRoundedRectangle(bounds, radius);
            g.DrawPath(pen, path);
        }

        public static void FillRoundedRectangle(Graphics g, Brush brush, Rectangle bounds, int radius)
        {
            using var path = CreateRoundedRectangle(bounds, radius);
            g.FillPath(brush, path);
        }
    }
}
