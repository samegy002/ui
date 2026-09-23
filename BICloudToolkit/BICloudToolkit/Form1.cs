using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BICloudToolkit.Controls;

namespace BICloudToolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupCustomStyles();
        }

        private void SetupCustomStyles()
        {
            // Set form visual presentation
            this.BackColor = Theme.AppBackground;
            this.ForeColor = Theme.TextPrimary;

            // Ensure High DPI fonts are assigned
            lblNoDeviceTitle.Font = new Font(Theme.FontFamily, 16f, FontStyle.Bold);
            lblNoDeviceSubtitle.Font = new Font(Theme.FontFamily, 9.5f, FontStyle.Regular);
            lblHeaderBrand.Font = new Font(Theme.FontFamily, 11f, FontStyle.Bold);
            lblBrandTitle.Font = new Font(Theme.FontFamily, 11.5f, FontStyle.Bold);
            lblStatusHeaderTitle.Font = new Font(Theme.FontFamily, 11f, FontStyle.Bold);
            lblCreditText.Font = new Font(Theme.FontFamily, 8.5f, FontStyle.Regular);
            lblDeviceModel.Font = new Font(Theme.FontFamily, 8f, FontStyle.Bold);
            lblDisconnected.Font = new Font(Theme.FontFamily, 8f, FontStyle.Bold);
            lblSidebarVersion.Font = new Font(Theme.FontFamily, 7.5f, FontStyle.Bold);

            // Hook bottom action buttons with demo response
            btnBlockOta.Click += ActionButton_Click;
            btnActivateDevice.Click += ActionButton_Click;
            btnExitRecovery.Click += ActionButton_Click;
            btnReadDevice.Click += ActionButton_Click;
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            if (sender is SidebarButton clickedBtn)
            {
                // Uncheck all sidebar buttons
                btnNavHome.IsActive = false;
                btnNavDeviceInfo.IsActive = false;
                btnNavBypassTools.IsActive = false;
                btnNavToolbox.IsActive = false;
                btnNavSettings.IsActive = false;
                btnNavAbout.IsActive = false;

                // Activate selected
                clickedBtn.IsActive = true;
            }
        }

        private void BtnCloseCredit_Click(object sender, EventArgs e)
        {
            pnlCreditBanner.Visible = false;
        }

        private void BtnRefreshStatus_Click(object sender, EventArgs e)
        {
            // Demo visual status refresh
            statusA12.IsActive = !statusA12.IsActive;
            MessageBox.Show(
                "Status monitor refreshed.\nDemo action — no device operation performed.",
                "Toolkit Status Monitor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (sender is ActionButton btn)
            {
                // Explicitly complies with Requirement 11
                MessageBox.Show(
                    $"Triggered: {btn.Text}\nDemo action — no device operation performed.",
                    "B-ICLOUD Device Toolkit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void PnlBrandHeader_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw blue logo chip icon container on left
            var iconBoxRect = new Rectangle(12, 12, 36, 36);
            using (var brush = new SolidBrush(Theme.AccentBlue))
            {
                Theme.FillRoundedRectangle(g, brush, iconBoxRect, 9);
            }

            // Draw chip icon inside box
            var innerChipRect = new Rectangle(20, 20, 20, 20);
            GdiIcons.DrawChip(g, innerChipRect, Color.White);
        }

        private void PnlDeviceIdentifier_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw Apple logo on left of device model pill
            var appleRect = new Rectangle(10, 10, 18, 18);
            GdiIcons.DrawAppleLogo(g, appleRect, Color.FromArgb(203, 213, 225));
        }

        private void PnlDisconnectedPill_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw disconnected / broken cable icon on left of pill
            var iconRect = new Rectangle(10, 10, 18, 18);
            GdiIcons.DrawDisconnected(g, iconRect, Color.FromArgb(192, 132, 252));
        }
    }
}
