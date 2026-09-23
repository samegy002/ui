import React from 'react';
import {
  Layers,
  Monitor,
  Cpu,
  ShieldAlert,
  Play,
  CheckCircle2,
  FolderTree,
  Terminal,
  FileCode2,
  PackageCheck
} from 'lucide-react';

export function ArchitectureGuide() {
  return (
    <div className="flex flex-col gap-6 w-full max-w-5xl mx-auto py-2">
      {/* ── Header Card ── */}
      <div className="p-6 bg-[#0E1424] border border-[#1E293D] rounded-2xl shadow-xl flex flex-col md:flex-row items-start md:items-center justify-between gap-4">
        <div>
          <span className="text-xs font-mono font-bold text-blue-400 uppercase tracking-widest">
            Architecture Specification
          </span>
          <h2 className="text-xl font-bold text-white mt-1">
            Native C# Windows Forms .NET 8 Desktop Solution
          </h2>
          <p className="text-sm text-slate-400 mt-1 max-w-2xl">
            A production-ready Windows Forms desktop architecture created directly from your visual reference image, utilizing GDI+ vector graphics, responsive container layout math, and centralized design tokens.
          </p>
        </div>

        <a
          href="/BICloudToolkit.zip"
          download="BICloudToolkit.zip"
          className="shrink-0 flex items-center gap-2 px-5 py-2.5 bg-blue-600 hover:bg-blue-500 text-white font-bold text-xs rounded-xl shadow-lg shadow-blue-600/30 transition-all cursor-pointer"
        >
          <PackageCheck size={16} />
          <span>Download Complete Solution (.ZIP)</span>
        </a>
      </div>

      {/* ── 3-Column Pillars ── */}
      <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
        {/* Pillar 1: Layout & Resizing */}
        <div className="p-5 bg-[#0D121F] border border-[#1A2338] rounded-xl flex flex-col gap-3">
          <div className="w-10 h-10 rounded-lg bg-blue-500/10 border border-blue-500/20 text-blue-400 flex items-center justify-center">
            <Layers size={20} />
          </div>
          <h3 className="font-bold text-sm text-white">1. Responsive Layout Math</h3>
          <p className="text-xs text-slate-400 leading-relaxed">
            Eliminates brittle hardcoded absolute X/Y points. Utilizes WinForms <code className="text-slate-200">TableLayoutPanel</code> (50%/50% 2x2 grid), <code className="text-slate-200">FlowLayoutPanel</code> for right-aligned action buttons, and nested <code className="text-slate-200">Dock</code> containers with clean margins and inner padding.
          </p>
        </div>

        {/* Pillar 2: High DPI & Scaling */}
        <div className="p-5 bg-[#0D121F] border border-[#1A2338] rounded-xl flex flex-col gap-3">
          <div className="w-10 h-10 rounded-lg bg-purple-500/10 border border-purple-500/20 text-purple-400 flex items-center justify-center">
            <Monitor size={20} />
          </div>
          <h3 className="font-bold text-sm text-white">2. High-DPI (PerMonitorV2)</h3>
          <p className="text-xs text-slate-400 leading-relaxed">
            Fully handles 100%, 125%, 150%, and 200% Windows display scaling without blurry fonts or clipped controls via <code className="text-slate-200">ApplicationHighDpiMode.PerMonitorV2</code> and scalable font sizing.
          </p>
        </div>

        {/* Pillar 3: GDI+ Vector Graphics */}
        <div className="p-5 bg-[#0D121F] border border-[#1A2338] rounded-xl flex flex-col gap-3">
          <div className="w-10 h-10 rounded-lg bg-emerald-500/10 border border-emerald-500/20 text-emerald-400 flex items-center justify-center">
            <Cpu size={20} />
          </div>
          <h3 className="font-bold text-sm text-white">3. Zero-Asset Vector GDI+</h3>
          <p className="text-xs text-slate-400 leading-relaxed">
            All iconography (Apple logo, CPU chip, ramdisk, jailbreak lock, shield, toolbox, battery/wifi disconnected indicators) is rendered with pure GDI+ vector graphics in <code className="text-slate-200">GdiIcons.cs</code>. No missing runtime images!
          </p>
        </div>
      </div>

      {/* ── Step-by-Step Build Instructions ── */}
      <div className="p-6 bg-[#0E1322] border border-[#1D263B] rounded-2xl flex flex-col gap-4">
        <div className="flex items-center gap-2 text-white font-bold text-base">
          <Play size={18} className="text-emerald-400" />
          <span>How to Open and Run the Project</span>
        </div>

        <div className="grid grid-cols-1 md:grid-cols-2 gap-4 mt-1">
          {/* Method 1: Visual Studio 2022 */}
          <div className="p-4 bg-[#0A0E18] border border-[#192235] rounded-xl flex flex-col gap-2">
            <span className="text-xs font-bold text-blue-400 uppercase tracking-wide">Method A: Visual Studio 2022</span>
            <ol className="text-xs text-slate-300 space-y-1.5 list-decimal list-inside leading-relaxed">
              <li>Extract <code className="text-slate-100 font-mono">BICloudToolkit.zip</code>.</li>
              <li>Double-click <code className="text-slate-100 font-mono">BICloudToolkit.sln</code> to open the solution.</li>
              <li>Ensure Visual Studio has the <strong>".NET Desktop Development"</strong> workload installed.</li>
              <li>Set target to <strong>Debug</strong> and <strong>Any CPU</strong>.</li>
              <li>Press <strong>F5</strong> or click <strong>Start</strong> to compile and launch.</li>
            </ol>
          </div>

          {/* Method 2: .NET CLI */}
          <div className="p-4 bg-[#0A0E18] border border-[#192235] rounded-xl flex flex-col gap-2">
            <span className="text-xs font-bold text-emerald-400 uppercase tracking-wide">Method B: .NET CLI / Terminal</span>
            <div className="bg-[#06080E] p-3 rounded-lg border border-[#171E2D] font-mono text-[11px] text-slate-300 flex flex-col gap-1">
              <span className="text-slate-500"># Navigate to project</span>
              <span>cd BICloudToolkit/BICloudToolkit</span>
              <span className="text-slate-500 mt-1"># Build solution</span>
              <span>dotnet build</span>
              <span className="text-slate-500 mt-1"># Launch desktop application</span>
              <span className="text-emerald-400">dotnet run</span>
            </div>
          </div>
        </div>
      </div>

      {/* ── Visual Comparison & Verification Checklist ── */}
      <div className="p-6 bg-[#0E1322] border border-[#1D263B] rounded-2xl flex flex-col gap-4">
        <div className="flex items-center gap-2 text-white font-bold text-base">
          <CheckCircle2 size={18} className="text-blue-400" />
          <span>Verification Checklist Against Reference Screenshot</span>
        </div>

        <div className="grid grid-cols-1 sm:grid-cols-2 gap-3 text-xs">
          {[
            { title: 'Top Pill Notification', desc: 'Center "(!) You are running out of credits. ×" pill dismissible banner.' },
            { title: 'Sidebar Branding', desc: 'Blue rounded squircle chip logo, B-ICLOUD title, and "V2.0.0 STABLE" footer.' },
            { title: 'Active Navigation State', desc: 'Home button with solid blue pill (#2563EB), crisp white text and icon.' },
            { title: '2x2 Feature Grid', desc: 'A12+ (Blue), Ramdisk (Purple), Jailbreak (Emerald), MDM (Amber) with chevrons.' },
            { title: 'Wide ToolBox Card', desc: 'Briefcase icon, "PURPLEMODE (MAGICCFFG)" subtitle, and subtle border accent.' },
            { title: 'Center Empty State Panel', desc: 'Vector disconnected iPhone illustration, "No Device Connected", DFU mode pill.' },
            { title: 'Software Optimization Banner', desc: 'Database version 2.4.8 notification with light blue title.' },
            { title: 'Toolkit Status Monitor', desc: 'Right-side monitor with refresh icon, glowing purple A12+ dot, and status rows.' },
            { title: 'Connection Unavailable Box', desc: 'Purple container with ERR_LOCKDOWN_FAIL code and warning icon.' },
            { title: 'Bottom Action Bar', desc: 'Apple iPhone 13 Pro badge, DISCONNECTED pill, and 4 colored action buttons.' }
          ].map((item, idx) => (
            <div key={idx} className="flex items-start gap-2.5 p-3 rounded-xl bg-[#090D17] border border-[#172133]">
              <CheckCircle2 size={15} className="text-emerald-400 shrink-0 mt-0.5" />
              <div>
                <span className="font-bold text-slate-100">{item.title}: </span>
                <span className="text-slate-400">{item.desc}</span>
              </div>
            </div>
          ))}
        </div>
      </div>

      {/* ── Security & Compliance Notice (Requirement 11) ── */}
      <div className="p-4 bg-amber-950/20 border border-amber-500/30 rounded-xl flex items-start gap-3 text-xs text-amber-200">
        <ShieldAlert size={18} className="text-amber-400 shrink-0 mt-0.5" />
        <div>
          <span className="font-bold">Security & Compliance Notice (Requirement 11): </span>
          <span>
            This application is strictly a visual Windows Forms desktop UI reference implementation. No actual activation lock circumvention, MDM bypass, or unauthorized exploitation mechanisms are included. All action triggers display the visual demo dialog: <code className="bg-amber-950/60 px-1.5 py-0.5 rounded text-amber-300 font-mono">"Demo action — no device operation performed."</code>
          </span>
        </div>
      </div>
    </div>
  );
}
