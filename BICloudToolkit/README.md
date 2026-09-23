# B-ICLOUD Apple Device Toolkit (Windows Forms .NET 8 / .NET 9)

A native C# Windows Forms desktop application meticulously recreating the futuristic dark-themed B-ICLOUD Apple Device Toolkit UI reference.

![B-ICLOUD Dashboard](https://raw.githubusercontent.com/placeholder/b-icloud.png)

---

## 📁 Project Architecture & Files

```text
BICloudToolkit.sln                    <- Visual Studio Solution file
BICloudToolkit/
 ├── BICloudToolkit.csproj             <- .NET 8.0-windows Windows Forms project
 ├── Program.cs                        <- Application entry point with Per-Monitor V2 DPI configuration
 ├── Form1.cs                          <- Main desktop window logic and event handlers
 ├── Form1.Designer.cs                 <- WinForms responsive layout tree (TableLayoutPanel, Panels)
 ├── Theme.cs                          <- Centralized design tokens: colors, fonts, and GDI+ geometry
 └── Controls/
      ├── GdiIcons.cs                  <- Vector GDI+ rendering (Apple, Chip, Ramdisk, Lock, Shield, etc.)
      ├── RoundedPanel.cs              <- Anti-aliased flicker-free rounded panel
      ├── SidebarButton.cs             <- Reusable navigation button with active/hover states
      ├── FeatureCard.cs               <- 2x2 dashboard cards & ToolBox card with accent glows
      ├── StatusItem.cs                <- Right status monitor rows with glowing LED indicators
      ├── ActionButton.cs              <- Bottom toolbar buttons with vector icons and color themes
      └── DeviceEmptyGraphic.cs        <- Disconnected iPhone chassis vector illustration
```

---

## 🚀 How to Open and Run in Visual Studio

### Prerequisites
- Windows 10 (Build 1809+) or Windows 11
- Visual Studio 2022 (v17.4 or later) with the **".NET Desktop Development"** workload installed.
- .NET 8.0 SDK or .NET 9.0 SDK.

### Option A: Using Visual Studio 2022
1. Double-click `BICloudToolkit.sln` to open the solution in Visual Studio.
2. In the top toolbar, ensure the build configuration is set to **Debug** or **Release** and platform is **Any CPU**.
3. Press **F5** (or click the green **Start** arrow) to build and run the application.

### Option B: Using .NET CLI
Open PowerShell or Command Prompt in the `BICloudToolkit` root directory:
```bash
# Navigate to the project directory
cd BICloudToolkit/BICloudToolkit

# Restore dependencies and build
dotnet build

# Launch the desktop application
dotnet run
```

---

## 🎨 Visual Design & Layout Architecture

### 1. Responsive WinForms Layout
- **No absolute coordinates**: Built with modern WinForms layout containers (`TableLayoutPanel`, `Panel`, `FlowLayoutPanel`, `Dock`, and `Anchor`).
- **Full resolution support**: Seamlessly scales across `1280x800`, `1440x900`, `1600x950`, and `1920x1080` screen resolutions.
- **PerMonitorV2 DPI Scaling**: Sharp, clear typography without blurred controls on 100%, 125%, 150%, and 200% Windows display scaling settings.

### 2. GDI+ Vector Graphics (No External Assets)
All icons (Apple logo, A12+ chip, ramdisk, jailbreak lock, MDM shield, toolbox, battery/wifi disconnected indicators, and action icons) are rendered dynamically with GDI+ anti-aliased vectors. The project has zero external image runtime dependencies, preventing broken or missing assets.

### 3. Centralized `Theme.cs` Tokens
All color codes, font families (`Inter` with fallback to `Segoe UI`), border widths, corner radii, and drawing routines are consolidated in `Theme.cs` for single-point styling.

---

## 🛡️ Security & Compliance Notice (Requirement 11)

This project is strictly a visual desktop user interface implementation. It does **NOT** contain any actual activation lock bypasses, MDM circumvention tools, exploit payloads, or unauthorized device access routines. All action buttons and cards trigger visual demo feedback dialogs:
> *"Demo action — no device operation performed."*
