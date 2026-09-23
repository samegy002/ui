import React, { useState } from 'react';
import {
  Download,
  Monitor,
  Code2,
  BookOpen,
  LayoutGrid,
  CheckCircle2,
  Sparkles,
  Smartphone,
  ExternalLink
} from 'lucide-react';
import { WinFormsEmulator } from './components/WinFormsEmulator';
import { CodeExplorer } from './components/CodeExplorer';
import { ArchitectureGuide } from './components/ArchitectureGuide';

type ViewMode = 'emulator' | 'code' | 'guide';

interface Resolution {
  label: string;
  width: number;
  height: number;
}

const resolutions: Resolution[] = [
  { label: '1280 × 800', width: 1280, height: 800 },
  { label: '1440 × 900', width: 1440, height: 900 },
  { label: '1600 × 950', width: 1600, height: 950 },
  { label: '1920 × 1080', width: 1920, height: 1080 }
];

export default function App() {
  const [viewMode, setViewMode] = useState<ViewMode>('emulator');
  const [selectedResolution, setSelectedResolution] = useState<Resolution>(resolutions[0]);
  const [dpiScale, setDpiScale] = useState<number>(1);

  return (
    <div className="min-h-screen bg-[#070A11] text-slate-100 flex flex-col font-sans">
      {/* ── Top Global Control Bar ── */}
      <header className="sticky top-0 z-40 bg-[#0B0F19]/95 backdrop-blur-md border-b border-[#1A2338] px-4 py-2.5 flex flex-wrap items-center justify-between gap-3 shadow-md">
        {/* Left: Brand Identity */}
        <div className="flex items-center gap-3">
          <div className="w-8 h-8 rounded-lg bg-blue-600 flex items-center justify-center text-white font-black text-sm shadow-md shadow-blue-600/30">
            B
          </div>
          <div className="flex flex-col">
            <div className="flex items-center gap-2">
              <span className="font-extrabold text-sm text-white tracking-wide">
                B-ICLOUD Device Toolkit
              </span>
              <span className="text-[10px] font-mono px-1.5 py-0.5 rounded bg-blue-950 text-blue-300 border border-blue-800">
                .NET 8 WinForms
              </span>
            </div>
            <span className="text-[10px] text-slate-400">
              Visual Studio C# Solution & Desktop UI Reference
            </span>
          </div>
        </div>

        {/* Center: Mode Tabs */}
        <div className="flex items-center gap-1 p-1 bg-[#101626] rounded-xl border border-[#1E293D]">
          <button
            onClick={() => setViewMode('emulator')}
            className={`flex items-center gap-1.5 px-3 py-1.5 rounded-lg text-xs font-semibold transition-all cursor-pointer ${
              viewMode === 'emulator'
                ? 'bg-blue-600 text-white shadow'
                : 'text-slate-400 hover:text-slate-200 hover:bg-[#162035]'
            }`}
          >
            <Monitor size={14} />
            <span>Live Desktop UI</span>
          </button>

          <button
            onClick={() => setViewMode('code')}
            className={`flex items-center gap-1.5 px-3 py-1.5 rounded-lg text-xs font-semibold transition-all cursor-pointer ${
              viewMode === 'code'
                ? 'bg-blue-600 text-white shadow'
                : 'text-slate-400 hover:text-slate-200 hover:bg-[#162035]'
            }`}
          >
            <Code2 size={14} />
            <span>Visual Studio Files (14)</span>
          </button>

          <button
            onClick={() => setViewMode('guide')}
            className={`flex items-center gap-1.5 px-3 py-1.5 rounded-lg text-xs font-semibold transition-all cursor-pointer ${
              viewMode === 'guide'
                ? 'bg-blue-600 text-white shadow'
                : 'text-slate-400 hover:text-slate-200 hover:bg-[#162035]'
            }`}
          >
            <BookOpen size={14} />
            <span>Architecture & Run Guide</span>
          </button>
        </div>

        {/* Right: Quick Download & Actions */}
        <div className="flex items-center gap-2">
          {viewMode === 'emulator' && (
            <div className="hidden xl:flex items-center gap-2 mr-2">
              {/* Resolution select */}
              <div className="flex items-center gap-1 bg-[#101626] border border-[#1E293D] rounded-lg p-0.5 text-xs text-slate-400">
                <span className="px-2 text-[10px] text-slate-500 font-mono">Viewport:</span>
                {resolutions.map((res) => (
                  <button
                    key={res.label}
                    onClick={() => setSelectedResolution(res)}
                    className={`px-2 py-1 rounded text-[11px] font-mono transition-colors cursor-pointer ${
                      selectedResolution.label === res.label
                        ? 'bg-[#1C263B] text-blue-300 font-bold'
                        : 'hover:text-slate-200'
                    }`}
                  >
                    {res.label}
                  </button>
                ))}
              </div>

              {/* DPI Scale */}
              <div className="flex items-center gap-1 bg-[#101626] border border-[#1E293D] rounded-lg p-0.5 text-xs text-slate-400">
                <span className="px-2 text-[10px] text-slate-500 font-mono">DPI:</span>
                {[1, 1.25, 1.5].map((scale) => (
                  <button
                    key={scale}
                    onClick={() => setDpiScale(scale)}
                    className={`px-2 py-1 rounded text-[11px] font-mono transition-colors cursor-pointer ${
                      dpiScale === scale
                        ? 'bg-[#1C263B] text-purple-300 font-bold'
                        : 'hover:text-slate-200'
                    }`}
                  >
                    {Math.round(scale * 100)}%
                  </button>
                ))}
              </div>
            </div>
          )}

          <a
            href="/BICloudToolkit.zip"
            download="BICloudToolkit.zip"
            className="flex items-center gap-2 px-4 py-2 bg-gradient-to-r from-blue-600 to-indigo-600 hover:from-blue-500 hover:to-indigo-500 text-white font-bold text-xs rounded-xl shadow-lg shadow-blue-500/20 transition-all cursor-pointer active:scale-95"
          >
            <Download size={14} />
            <span>Download .ZIP</span>
          </a>
        </div>
      </header>

      {/* ── Main View Content ── */}
      <main className="flex-1 p-4 lg:p-6 flex flex-col items-center">
        {viewMode === 'emulator' && (
          <div className="w-full max-w-[1400px] flex flex-col items-center gap-4">
            {/* Resolution indicator bar */}
            <div className="w-full flex items-center justify-between text-xs text-slate-400 px-2 select-none">
              <div className="flex items-center gap-2">
                <span className="w-2 h-2 rounded-full bg-emerald-400 animate-pulse" />
                <span>Running native WinForms layout emulation</span>
                <span className="text-slate-600">|</span>
                <span className="font-mono text-slate-300">
                  {selectedResolution.label} @ {Math.round(dpiScale * 100)}% DPI
                </span>
              </div>
              <div className="flex items-center gap-3 text-slate-500">
                <span>Layout: TableLayoutPanel + FlowLayoutPanel</span>
                <span>•</span>
                <span>Icons: Pure GDI+ Vectors</span>
              </div>
            </div>

            {/* Desktop Window Container */}
            <div
              className="w-full transition-all duration-300"
              style={{
                maxWidth: `${selectedResolution.width}px`
              }}
            >
              <WinFormsEmulator dpiScale={dpiScale} />
            </div>

            {/* Notice Footer */}
            <div className="w-full flex flex-col sm:flex-row items-center justify-between p-4 bg-[#0E1322] border border-[#1C263B] rounded-xl text-xs text-slate-400 gap-3">
              <div className="flex items-center gap-2">
                <CheckCircle2 size={16} className="text-emerald-400 shrink-0" />
                <span>
                  All project files (<code className="text-slate-200">.sln</code>, <code className="text-slate-200">.csproj</code>, <code className="text-slate-200">Form1.cs</code>, <code className="text-slate-200">Controls/*.cs</code>) are fully generated and available in the ZIP.
                </span>
              </div>
              <button
                onClick={() => setViewMode('code')}
                className="text-blue-400 hover:text-blue-300 font-semibold underline underline-offset-4 cursor-pointer shrink-0"
              >
                Inspect C# Code →
              </button>
            </div>
          </div>
        )}

        {viewMode === 'code' && (
          <div className="w-full max-w-7xl">
            <CodeExplorer />
          </div>
        )}

        {viewMode === 'guide' && (
          <div className="w-full">
            <ArchitectureGuide />
          </div>
        )}
      </main>
    </div>
  );
}
