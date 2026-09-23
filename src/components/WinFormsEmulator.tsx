import React, { useState } from 'react';
import {
  Cpu,
  HardDrive,
  Lock,
  ShieldCheck,
  Briefcase,
  Home,
  Smartphone,
  Wrench,
  Settings,
  Info,
  ChevronRight,
  RotateCw,
  Zap,
  Power,
  AlertCircle,
  X,
  Minus,
  Square,
  CheckCircle2,
  Apple,
  Unlink
} from 'lucide-react';
import { DeviceEmptyStateSvg } from './DeviceEmptyStateSvg';

interface WinFormsEmulatorProps {
  dpiScale: number;
}

export function WinFormsEmulator({ dpiScale }: WinFormsEmulatorProps) {
  const [activeTab, setActiveTab] = useState<'Home' | 'DeviceInfo' | 'BypassTools' | 'Toolbox' | 'Settings' | 'About'>('Home');
  const [showCreditBanner, setShowCreditBanner] = useState(true);
  const [isRefreshing, setIsRefreshing] = useState(false);
  const [demoModal, setDemoModal] = useState<{ isOpen: boolean; title: string; message: string } | null>(null);
  const [isA12Active, setIsA12Active] = useState(true);

  const triggerDemoAction = (title: string, customMessage?: string) => {
    setDemoModal({
      isOpen: true,
      title: title,
      message: customMessage || 'Demo action — no device operation performed.'
    });
  };

  const handleRefreshStatus = () => {
    setIsRefreshing(true);
    setIsA12Active((prev) => !prev);
    setTimeout(() => {
      setIsRefreshing(false);
      triggerDemoAction('Toolkit Status Monitor', 'Status monitor refreshed.\nDemo action — no device operation performed.');
    }, 400);
  };

  return (
    <div
      className="relative flex flex-col w-full bg-[#0B0F19] text-slate-100 rounded-xl border border-[#1E283D] shadow-2xl overflow-hidden font-sans transition-all duration-200"
      style={{
        transform: dpiScale !== 1 ? `scale(${dpiScale})` : undefined,
        transformOrigin: 'top center'
      }}
    >
      {/* ── Windows Native-Style Dark Titlebar ── */}
      <div className="flex items-center justify-between px-3 py-1.5 bg-[#090D15] border-b border-[#1A2336] select-none text-xs text-slate-400">
        <div className="flex items-center gap-2">
          <div className="w-3.5 h-3.5 rounded bg-blue-600 flex items-center justify-center text-[9px] font-bold text-white">
            B
          </div>
          <span className="font-medium text-slate-300">B-ICLOUD Platform - Apple Device Toolkit (WinForms Native)</span>
        </div>
        <div className="flex items-center gap-1">
          <button
            onClick={() => triggerDemoAction('Window Minimize')}
            className="w-7 h-5 flex items-center justify-center hover:bg-slate-800 rounded transition-colors text-slate-400 hover:text-white"
            title="Minimize"
          >
            <Minus size={11} />
          </button>
          <button
            onClick={() => triggerDemoAction('Window Maximize')}
            className="w-7 h-5 flex items-center justify-center hover:bg-slate-800 rounded transition-colors text-slate-400 hover:text-white"
            title="Maximize"
          >
            <Square size={9} />
          </button>
          <button
            onClick={() => triggerDemoAction('Window Close')}
            className="w-7 h-5 flex items-center justify-center hover:bg-red-600 rounded transition-colors text-slate-400 hover:text-white"
            title="Close"
          >
            <X size={11} />
          </button>
        </div>
      </div>

      {/* ── Top Header Area ── */}
      <div className="relative flex items-center justify-between px-6 py-2.5 bg-[#0D121F] border-b border-[#182236]">
        {/* Left: Brand Logo Lockup */}
        <div className="flex items-center gap-2.5">
          <div className="w-8 h-8 rounded-lg bg-blue-600 flex items-center justify-center shadow-lg shadow-blue-500/20">
            <svg width="20" height="20" viewBox="0 0 24 24" fill="none" stroke="white" strokeWidth="2.2" strokeLinecap="round" strokeLinejoin="round">
              <path d="M17.5 19H9a7 7 0 1 1 6.71-9h1.79a4.5 4.5 0 1 1 0 9Z" />
            </svg>
          </div>
          <div className="flex flex-col">
            <div className="flex items-center gap-1.5 leading-none">
              <span className="font-extrabold text-sm tracking-wide text-white">B-ICLOUD</span>
            </div>
            <span className="text-[9px] font-bold tracking-widest text-blue-500 uppercase mt-0.5">PLATFORM</span>
          </div>
        </div>

        {/* Center: Running out of credits Banner */}
        {showCreditBanner ? (
          <div className="flex items-center gap-2 px-3 py-1 bg-[#141A28] border border-[#2D374E] rounded-full text-xs text-slate-300 shadow-sm animate-in fade-in duration-150">
            <AlertCircle size={14} className="text-purple-400 shrink-0" />
            <span>You are running out of credits.</span>
            <button
              onClick={() => setShowCreditBanner(false)}
              className="ml-1 text-slate-400 hover:text-slate-100 transition-colors"
              title="Dismiss warning"
            >
              <X size={13} />
            </button>
          </div>
        ) : (
          <button
            onClick={() => setShowCreditBanner(true)}
            className="text-[11px] text-slate-500 hover:text-slate-300 transition-colors"
          >
            Show credit banner
          </button>
        )}

        {/* Right side balance spacer */}
        <div className="w-24"></div>
      </div>

      {/* ── Main Application Body ── */}
      <div className="flex flex-1 min-h-[580px]">
        {/* ── Left Sidebar (Dock: Left, 220px) ── */}
        <div className="w-56 shrink-0 bg-[#0B0F19] border-r border-[#172033] flex flex-col justify-between p-3 select-none">
          {/* Top Brand & Navigation */}
          <div className="flex flex-col gap-1">
            {/* Sidebar Logo Header */}
            <div className="flex items-center gap-2.5 px-2 py-3 mb-2 border-b border-[#161F33]">
              <div className="w-9 h-9 rounded-xl bg-blue-600 flex items-center justify-center text-white shadow-md shadow-blue-600/30">
                <Cpu size={20} />
              </div>
              <div className="flex flex-col leading-tight">
                <span className="font-bold text-sm tracking-wide text-white">B-ICLOUD</span>
                <span className="text-[8.5px] font-bold tracking-wider text-slate-400 uppercase">
                  APPLE DEVICE TOOLKIT
                </span>
              </div>
            </div>

            {/* Nav Menu */}
            <div className="flex flex-col gap-1">
              <button
                onClick={() => setActiveTab('Home')}
                className={`flex items-center gap-3 px-3 py-2.5 rounded-xl text-xs font-semibold transition-all ${
                  activeTab === 'Home'
                    ? 'bg-blue-600 text-white shadow-md shadow-blue-600/25'
                    : 'text-slate-400 hover:bg-[#162032] hover:text-slate-200'
                }`}
              >
                <Home size={16} />
                <span>Home</span>
              </button>

              <button
                onClick={() => {
                  setActiveTab('DeviceInfo');
                  triggerDemoAction('Device Info View');
                }}
                className={`flex items-center gap-3 px-3 py-2.5 rounded-xl text-xs font-medium transition-all ${
                  activeTab === 'DeviceInfo'
                    ? 'bg-blue-600 text-white'
                    : 'text-slate-400 hover:bg-[#162032] hover:text-slate-200'
                }`}
              >
                <Smartphone size={16} />
                <span>Device Info</span>
              </button>

              <button
                onClick={() => {
                  setActiveTab('BypassTools');
                  triggerDemoAction('Bypass Tools View');
                }}
                className={`flex items-center gap-3 px-3 py-2.5 rounded-xl text-xs font-medium transition-all ${
                  activeTab === 'BypassTools'
                    ? 'bg-blue-600 text-white'
                    : 'text-slate-400 hover:bg-[#162032] hover:text-slate-200'
                }`}
              >
                <Wrench size={16} />
                <span>Bypass Tools</span>
              </button>

              <button
                onClick={() => {
                  setActiveTab('Toolbox');
                  triggerDemoAction('Toolbox View');
                }}
                className={`flex items-center gap-3 px-3 py-2.5 rounded-xl text-xs font-medium transition-all ${
                  activeTab === 'Toolbox'
                    ? 'bg-blue-600 text-white'
                    : 'text-slate-400 hover:bg-[#162032] hover:text-slate-200'
                }`}
              >
                <Briefcase size={16} />
                <span>Toolbox</span>
              </button>

              <button
                onClick={() => {
                  setActiveTab('Settings');
                  triggerDemoAction('Settings View');
                }}
                className={`flex items-center gap-3 px-3 py-2.5 rounded-xl text-xs font-medium transition-all ${
                  activeTab === 'Settings'
                    ? 'bg-blue-600 text-white'
                    : 'text-slate-400 hover:bg-[#162032] hover:text-slate-200'
                }`}
              >
                <Settings size={16} />
                <span>Settings</span>
              </button>

              <button
                onClick={() => {
                  setActiveTab('About');
                  triggerDemoAction('About B-ICLOUD', 'B-ICLOUD Apple Device Toolkit v2.0.0 Stable.\nC# Windows Forms Desktop UI Reference Implementation.');
                }}
                className={`flex items-center gap-3 px-3 py-2.5 rounded-xl text-xs font-medium transition-all ${
                  activeTab === 'About'
                    ? 'bg-blue-600 text-white'
                    : 'text-slate-400 hover:bg-[#162032] hover:text-slate-200'
                }`}
              >
                <Info size={16} />
                <span>About</span>
              </button>
            </div>
          </div>

          {/* Sidebar Footer Version */}
          <div className="px-2 py-2 text-[10px] font-bold text-slate-500 tracking-wider">
            V2.0.0 STABLE
          </div>
        </div>

        {/* ── Center Dashboard Area (Dock: Fill) ── */}
        <div className="flex-1 flex flex-col p-4 gap-3 bg-[#0B0F19] overflow-y-auto">
          {/* ── 2x2 Feature Grid (TableLayoutPanel in WinForms) ── */}
          <div className="grid grid-cols-2 gap-3">
            {/* Card 1: A12+ Bypass (Blue Outline) */}
            <button
              onClick={() => triggerDemoAction('A12+ Bypass (iOS 26.0.1 / 26.1)')}
              className="group flex items-center justify-between p-3.5 rounded-2xl bg-[#121929] hover:bg-[#18233a] border border-blue-500/80 hover:border-blue-400 shadow-lg shadow-blue-500/5 transition-all text-left cursor-pointer"
            >
              <div className="flex items-center gap-3">
                <div className="w-11 h-11 rounded-xl bg-[#101726] border border-[#202B44] flex items-center justify-center text-blue-500 group-hover:scale-105 transition-transform">
                  <Cpu size={22} />
                </div>
                <div>
                  <h3 className="font-bold text-sm text-white group-hover:text-blue-200 transition-colors">
                    A12+ Bypass
                  </h3>
                  <p className="text-[10px] font-bold text-slate-400 tracking-wider">
                    IOS 26.0.1 / 26.1
                  </p>
                </div>
              </div>
              <ChevronRight size={18} className="text-slate-500 group-hover:text-slate-200 group-hover:translate-x-0.5 transition-all" />
            </button>

            {/* Card 2: Ramdisk Bypass (Purple Outline) */}
            <button
              onClick={() => triggerDemoAction('Ramdisk Bypass (iPhone 6 to X)')}
              className="group flex items-center justify-between p-3.5 rounded-2xl bg-[#121929] hover:bg-[#18233a] border border-purple-500/80 hover:border-purple-400 shadow-lg shadow-purple-500/5 transition-all text-left cursor-pointer"
            >
              <div className="flex items-center gap-3">
                <div className="w-11 h-11 rounded-xl bg-[#101726] border border-[#202B44] flex items-center justify-center text-purple-400 group-hover:scale-105 transition-transform">
                  <HardDrive size={22} />
                </div>
                <div>
                  <h3 className="font-bold text-sm text-white group-hover:text-purple-200 transition-colors">
                    Ramdisk Bypass
                  </h3>
                  <p className="text-[10px] font-bold text-slate-400 tracking-wider">
                    IPHONE 6 TO X
                  </p>
                </div>
              </div>
              <ChevronRight size={18} className="text-slate-500 group-hover:text-slate-200 group-hover:translate-x-0.5 transition-all" />
            </button>

            {/* Card 3: Jailbreak Bypass (Emerald / Cyan Outline) */}
            <button
              onClick={() => triggerDemoAction('Jailbreak Bypass (iPhone 5s to X)')}
              className="group flex items-center justify-between p-3.5 rounded-2xl bg-[#121929] hover:bg-[#18233a] border border-emerald-500/80 hover:border-emerald-400 shadow-lg shadow-emerald-500/5 transition-all text-left cursor-pointer"
            >
              <div className="flex items-center gap-3">
                <div className="w-11 h-11 rounded-xl bg-[#101726] border border-[#202B44] flex items-center justify-center text-emerald-400 group-hover:scale-105 transition-transform">
                  <Lock size={22} />
                </div>
                <div>
                  <h3 className="font-bold text-sm text-white group-hover:text-emerald-200 transition-colors">
                    Jailbreak Bypass
                  </h3>
                  <p className="text-[10px] font-bold text-slate-400 tracking-wider">
                    IPHONE 5S TO X
                  </p>
                </div>
              </div>
              <ChevronRight size={18} className="text-slate-500 group-hover:text-slate-200 group-hover:translate-x-0.5 transition-all" />
            </button>

            {/* Card 4: MDM Bypass (Amber Outline) */}
            <button
              onClick={() => triggerDemoAction('MDM Bypass (All iOS / iPhone / iPad)')}
              className="group flex items-center justify-between p-3.5 rounded-2xl bg-[#121929] hover:bg-[#18233a] border border-amber-500/80 hover:border-amber-400 shadow-lg shadow-amber-500/5 transition-all text-left cursor-pointer"
            >
              <div className="flex items-center gap-3">
                <div className="w-11 h-11 rounded-xl bg-[#101726] border border-[#202B44] flex items-center justify-center text-amber-400 group-hover:scale-105 transition-transform">
                  <ShieldCheck size={22} />
                </div>
                <div>
                  <h3 className="font-bold text-sm text-white group-hover:text-amber-200 transition-colors">
                    MDM Bypass
                  </h3>
                  <p className="text-[10px] font-bold text-slate-400 tracking-wider">
                    ALL IOS / IPHONE / IPAD
                  </p>
                </div>
              </div>
              <ChevronRight size={18} className="text-slate-500 group-hover:text-slate-200 group-hover:translate-x-0.5 transition-all" />
            </button>
          </div>

          {/* ── Wide ToolBox Card ── */}
          <button
            onClick={() => triggerDemoAction('ToolBox (Purplemode MagicCFG)')}
            className="group flex items-center justify-between p-3.5 rounded-2xl bg-[#121929] hover:bg-[#18233a] border border-[#1E283D] hover:border-sky-500/50 shadow-md transition-all text-left cursor-pointer"
          >
            <div className="flex items-center gap-3">
              <div className="w-11 h-11 rounded-xl bg-[#101726] border border-[#202B44] flex items-center justify-center text-sky-400 group-hover:scale-105 transition-transform">
                <Briefcase size={22} />
              </div>
              <div>
                <h3 className="font-bold text-sm text-white group-hover:text-sky-200 transition-colors">
                  ToolBox
                </h3>
                <p className="text-[10px] font-bold text-slate-400 tracking-wider">
                  PURPLEMODE (MAGICCFFG)
                </p>
              </div>
            </div>
            <ChevronRight size={18} className="text-slate-500 group-hover:text-slate-200 group-hover:translate-x-0.5 transition-all" />
          </button>

          {/* ── Empty Device Information State ── */}
          <div className="flex-1 flex flex-col items-center justify-center p-6 rounded-2xl bg-[#0F1523] border border-[#1C263B] text-center shadow-inner min-h-[220px]">
            {/* Device Vector Illustration matching screenshot */}
            <DeviceEmptyStateSvg />

            <h2 className="mt-3 font-extrabold text-xl text-white tracking-tight">
              No Device Connected
            </h2>
            <p className="mt-1 text-xs text-slate-400 max-w-md leading-relaxed">
              Connect your Apple device via USB-C or Lightning cable to begin the bypass process.
            </p>

            {/* Pill: Waiting for DFU Mode */}
            <div className="mt-4 flex items-center gap-2 px-4 py-1.5 bg-[#141A28] border border-[#28354D] rounded-full shadow-sm">
              <span className="w-2 h-2 rounded-full bg-purple-400 animate-pulse shadow-[0_0_8px_rgba(192,132,252,0.8)]" />
              <span className="text-[10px] font-extrabold text-purple-300 tracking-wider uppercase">
                WAITING FOR DFU MODE...
              </span>
            </div>
          </div>

          {/* ── Software Optimization Notice Banner ── */}
          <div className="flex items-center gap-3 px-4 py-2.5 rounded-xl bg-[#0F172A] border border-[#1E293B] text-xs">
            <div className="w-6 h-6 rounded-full bg-blue-500/10 border border-blue-500/20 flex items-center justify-center text-blue-400 shrink-0">
              <Info size={14} />
            </div>
            <div>
              <span className="font-bold text-sky-400 tracking-wide mr-1.5 uppercase text-[11px]">
                SOFTWARE OPTIMIZATION
              </span>
              <span className="text-slate-400 text-[11px]">
                Database version 2.4.8 is now active. All A12+ bypass scripts verified for iOS 17.5 compatibility.
              </span>
            </div>
          </div>
        </div>

        {/* ── Right Status Panel (Dock: Right, 310px) ── */}
        <div className="w-72 shrink-0 bg-[#0D121E] border-l border-[#172033] flex flex-col justify-between p-4 select-none">
          {/* Top Status Rows */}
          <div className="flex flex-col gap-2.5">
            {/* Status Header */}
            <div className="flex items-center justify-between pb-1 border-b border-[#1A2438]">
              <span className="font-bold text-sm text-white">Toolkit Status Monitor</span>
              <button
                onClick={handleRefreshStatus}
                className="p-1 rounded hover:bg-[#1A2438] text-slate-400 hover:text-white transition-colors"
                title="Refresh Status"
              >
                <RotateCw size={14} className={isRefreshing ? 'animate-spin text-blue-400' : ''} />
              </button>
            </div>

            {/* Row 1: A12+ Bypass */}
            <div className="flex items-center justify-between p-2.5 rounded-xl bg-[#111726] border border-[#1E283D]">
              <div className="flex items-center gap-2.5">
                <div className="w-8 h-8 rounded-lg bg-[#161F33] flex items-center justify-center text-slate-300">
                  <Cpu size={16} />
                </div>
                <div>
                  <h4 className="font-bold text-xs text-white">A12+ Bypass</h4>
                  <p className="text-[10px] text-slate-400">iOS 26.0.1 / 26.1</p>
                </div>
              </div>
              <div className="flex items-center pr-1">
                {isA12Active ? (
                  <span className="w-2.5 h-2.5 rounded-full bg-purple-500 shadow-[0_0_8px_rgba(168,85,247,0.9)]" />
                ) : (
                  <span className="w-2.5 h-2.5 rounded-full bg-slate-600" />
                )}
              </div>
            </div>

            {/* Row 2: Ramdisk Bypass */}
            <div className="flex items-center justify-between p-2.5 rounded-xl bg-[#111726] border border-[#1E283D]">
              <div className="flex items-center gap-2.5">
                <div className="w-8 h-8 rounded-lg bg-[#161F33] flex items-center justify-center text-slate-400">
                  <HardDrive size={16} />
                </div>
                <div>
                  <h4 className="font-bold text-xs text-slate-300">Ramdisk Bypass</h4>
                  <p className="text-[10px] text-slate-400">iPhone 6 to X</p>
                </div>
              </div>
              <div className="flex items-center pr-1">
                <span className="w-2.5 h-2.5 rounded-full bg-slate-600" />
              </div>
            </div>

            {/* Row 3: Jailbreak Bypass */}
            <div className="flex items-center justify-between p-2.5 rounded-xl bg-[#111726] border border-[#1E283D]">
              <div className="flex items-center gap-2.5">
                <div className="w-8 h-8 rounded-lg bg-[#161F33] flex items-center justify-center text-slate-400">
                  <Lock size={16} />
                </div>
                <div>
                  <h4 className="font-bold text-xs text-slate-300">Jailbreak Bypass</h4>
                  <p className="text-[10px] text-slate-400">iPhone 5s to X</p>
                </div>
              </div>
              <div className="flex items-center pr-1">
                <span className="w-2.5 h-2.5 rounded-full bg-slate-600" />
              </div>
            </div>

            {/* Row 4: MDM Bypass */}
            <div className="flex items-center justify-between p-2.5 rounded-xl bg-[#111726] border border-[#1E283D]">
              <div className="flex items-center gap-2.5">
                <div className="w-8 h-8 rounded-lg bg-[#161F33] flex items-center justify-center text-slate-400">
                  <ShieldCheck size={16} />
                </div>
                <div>
                  <h4 className="font-bold text-xs text-slate-300">MDM Bypass</h4>
                  <p className="text-[10px] text-slate-400">All iOS / iPad</p>
                </div>
              </div>
              <div className="flex items-center pr-1">
                <span className="w-2.5 h-2.5 rounded-full bg-slate-600" />
              </div>
            </div>
          </div>

          {/* Connection Error Panel */}
          <div className="p-3.5 rounded-2xl bg-[#181129] border border-[#4C1D95] shadow-lg shadow-purple-950/30 flex flex-col gap-1.5">
            <div className="flex items-center gap-1.5 text-purple-300 font-bold text-xs">
              <AlertCircle size={15} className="shrink-0 text-purple-400" />
              <span>CONNECTION UNAVAILABLE.</span>
            </div>
            <p className="text-[11px] text-slate-400 leading-tight">
              No device is currently connected.
            </p>
            <div className="mt-1 font-mono text-[9.5px] text-purple-300 bg-purple-950/40 px-2 py-1 rounded border border-purple-800/40">
              ERR_LOCKDOWN_FAIL: (-17) Password Protected
            </div>
          </div>
        </div>
      </div>

      {/* ── Bottom Fixed Action Bar ── */}
      <div className="flex items-center justify-between px-4 py-3 bg-[#0D121E] border-t border-[#182236] select-none">
        {/* Left: Device Model & Disconnected Pill */}
        <div className="flex items-center gap-2.5">
          {/* Apple Device Badge */}
          <div className="flex items-center gap-2 px-3 py-1.5 bg-[#141A28] border border-[#28354D] rounded-xl shadow-sm">
            <Apple size={16} className="text-slate-300" />
            <div className="flex flex-col leading-none">
              <span className="text-[8px] font-bold text-slate-400 uppercase tracking-wider">DEVICE</span>
              <span className="text-xs font-bold text-white">iPhone 13 Pro</span>
            </div>
          </div>

          {/* Disconnected Pill */}
          <div className="flex items-center gap-1.5 px-3 py-1.5 bg-[#24163A] border border-[#4C1D95] rounded-xl text-purple-300">
            <Unlink size={13} className="text-purple-400" />
            <span className="text-xs font-bold tracking-wide uppercase">DISCONNECTED</span>
          </div>
        </div>

        {/* Right: Functional Action Buttons */}
        <div className="flex items-center gap-2.5">
          {/* Button 1: Block OTA / Reset */}
          <button
            onClick={() => triggerDemoAction('Block OTA / Reset')}
            className="flex items-center gap-2 px-4 py-2 bg-[#141A28] hover:bg-[#1E273C] border border-[#2A3750] rounded-xl text-xs font-bold text-slate-200 transition-colors cursor-pointer shadow-sm active:scale-95"
          >
            <RotateCw size={14} className="text-slate-400" />
            <span>Block OTA / Reset</span>
          </button>

          {/* Button 2: Activate Device */}
          <button
            onClick={() => triggerDemoAction('Activate Device')}
            className="flex items-center gap-2 px-4 py-2 bg-blue-600 hover:bg-blue-500 rounded-xl text-xs font-bold text-white shadow-md shadow-blue-600/30 transition-all cursor-pointer active:scale-95"
          >
            <Zap size={14} className="text-white fill-white" />
            <span>Activate Device</span>
          </button>

          {/* Button 3: Exit Recovery */}
          <button
            onClick={() => triggerDemoAction('Exit Recovery')}
            className="flex items-center gap-2 px-4 py-2 bg-purple-600 hover:bg-purple-500 rounded-xl text-xs font-bold text-white shadow-md shadow-purple-600/30 transition-all cursor-pointer active:scale-95"
          >
            <Power size={14} />
            <span>Exit Recovery</span>
          </button>

          {/* Button 4: Read Device */}
          <button
            onClick={() => triggerDemoAction('Read Device')}
            className="flex items-center gap-2 px-4 py-2 bg-emerald-600 hover:bg-emerald-500 rounded-xl text-xs font-bold text-white shadow-md shadow-emerald-600/30 transition-all cursor-pointer active:scale-95"
          >
            <Zap size={14} className="text-white fill-white" />
            <span>Read Device</span>
          </button>
        </div>
      </div>

      {/* ── Native Windows Forms Dialog Modal (Requirement 11) ── */}
      {demoModal?.isOpen && (
        <div className="absolute inset-0 bg-black/60 backdrop-blur-[2px] z-50 flex items-center justify-center p-4 animate-in fade-in duration-100">
          <div className="w-[380px] bg-[#141B2D] border border-[#29354E] rounded-xl shadow-2xl overflow-hidden flex flex-col text-slate-200">
            {/* Dialog Title Bar */}
            <div className="flex items-center justify-between px-3.5 py-2 bg-[#0E1320] border-b border-[#222C42] text-xs font-semibold text-slate-300">
              <div className="flex items-center gap-2">
                <div className="w-2.5 h-2.5 rounded-full bg-blue-500" />
                <span>{demoModal.title}</span>
              </div>
              <button
                onClick={() => setDemoModal(null)}
                className="text-slate-400 hover:text-white transition-colors"
              >
                <X size={14} />
              </button>
            </div>

            {/* Dialog Content */}
            <div className="p-4 flex items-start gap-3">
              <div className="w-8 h-8 rounded-full bg-blue-500/20 text-blue-400 flex items-center justify-center shrink-0">
                <Info size={18} />
              </div>
              <div className="flex flex-col gap-1">
                <h4 className="font-bold text-xs text-white">Visual Desktop UI Demo</h4>
                <p className="text-xs text-slate-300 whitespace-pre-line leading-relaxed">
                  {demoModal.message}
                </p>
                <p className="text-[10px] text-slate-500 mt-1">
                  (Security Notice: In accordance with Requirement 11, this desktop UI contains visual demo controls only.)
                </p>
              </div>
            </div>

            {/* Dialog Action Buttons */}
            <div className="px-4 py-2.5 bg-[#0E1320] border-t border-[#222C42] flex justify-end">
              <button
                onClick={() => setDemoModal(null)}
                className="px-5 py-1.5 bg-blue-600 hover:bg-blue-500 text-white rounded-lg text-xs font-bold shadow transition-colors cursor-pointer"
              >
                OK
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
