import React, { useState } from 'react';
import { csharpProjectFiles, CSharpFile } from '../data/csharpFiles';
import {
  FileCode,
  FolderTree,
  Copy,
  Check,
  Download,
  Terminal,
  ExternalLink,
  Code2
} from 'lucide-react';

export function CodeExplorer() {
  const [selectedFile, setSelectedFile] = useState<CSharpFile>(
    csharpProjectFiles.find((f) => f.name === 'Form1.cs') || csharpProjectFiles[0]
  );
  const [copied, setCopied] = useState(false);
  const [activeCategory, setActiveCategory] = useState<string>('All');

  const categories = ['All', 'Forms', 'Controls', 'Core', 'Project', 'Solution', 'Docs'];

  const filteredFiles = activeCategory === 'All'
    ? csharpProjectFiles
    : csharpProjectFiles.filter((f) => f.category === activeCategory);

  const handleCopy = () => {
    navigator.clipboard.writeText(selectedFile.content);
    setCopied(true);
    setTimeout(() => setCopied(false), 2000);
  };

  const handleDownloadSingleFile = (file: CSharpFile) => {
    const blob = new Blob([file.content], { type: 'text/plain;charset=utf-8' });
    const url = URL.createObjectURL(blob);
    const link = document.createElement('a');
    link.href = url;
    link.download = file.name;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    URL.revokeObjectURL(url);
  };

  return (
    <div className="flex flex-col lg:flex-row gap-4 w-full h-[720px] bg-[#0A0E17] border border-[#1E293D] rounded-xl overflow-hidden shadow-2xl">
      {/* ── Left File Navigator (Visual Studio Solution Explorer) ── */}
      <div className="w-full lg:w-80 shrink-0 bg-[#0D121F] border-b lg:border-b-0 lg:border-r border-[#1B2538] flex flex-col">
        {/* Solution Header */}
        <div className="p-3.5 border-b border-[#1B2538] bg-[#090D16] flex items-center justify-between">
          <div className="flex items-center gap-2 text-slate-200 font-bold text-xs">
            <FolderTree size={16} className="text-blue-400" />
            <span>Visual Studio Solution Explorer</span>
          </div>
          <span className="text-[10px] bg-blue-950 text-blue-300 font-mono px-2 py-0.5 rounded border border-blue-800">
            {csharpProjectFiles.length} files
          </span>
        </div>

        {/* Category Pills */}
        <div className="flex items-center gap-1 p-2 bg-[#0A0E18] border-b border-[#1A2335] overflow-x-auto text-xs">
          {categories.map((cat) => (
            <button
              key={cat}
              onClick={() => setActiveCategory(cat)}
              className={`px-2.5 py-1 rounded-md text-[11px] font-medium transition-colors whitespace-nowrap cursor-pointer ${
                activeCategory === cat
                  ? 'bg-blue-600 text-white'
                  : 'text-slate-400 hover:text-slate-200 hover:bg-[#151D2E]'
              }`}
            >
              {cat}
            </button>
          ))}
        </div>

        {/* File List */}
        <div className="flex-1 overflow-y-auto p-2 flex flex-col gap-1">
          {filteredFiles.map((file) => {
            const isSelected = selectedFile.path === file.path;
            return (
              <button
                key={file.path}
                onClick={() => setSelectedFile(file)}
                className={`flex items-start gap-2.5 px-3 py-2 rounded-lg text-left text-xs transition-colors cursor-pointer ${
                  isSelected
                    ? 'bg-blue-600/20 text-blue-200 border border-blue-500/40 font-semibold'
                    : 'text-slate-400 hover:bg-[#131A29] hover:text-slate-200'
                }`}
              >
                <FileCode
                  size={15}
                  className={`mt-0.5 shrink-0 ${
                    file.name.endsWith('.cs')
                      ? 'text-emerald-400'
                      : file.name.endsWith('.csproj')
                      ? 'text-sky-400'
                      : file.name.endsWith('.sln')
                      ? 'text-purple-400'
                      : 'text-slate-400'
                  }`}
                />
                <div className="flex flex-col min-w-0">
                  <span className="truncate">{file.name}</span>
                  <span className="text-[10px] text-slate-500 truncate font-mono">
                    {file.path}
                  </span>
                </div>
              </button>
            );
          })}
        </div>

        {/* Download Zip Quick Box */}
        <div className="p-3 border-t border-[#1B2538] bg-[#090D16]">
          <a
            href="/BICloudToolkit.zip"
            download="BICloudToolkit.zip"
            className="w-full flex items-center justify-center gap-2 px-3 py-2 bg-gradient-to-r from-blue-600 to-indigo-600 hover:from-blue-500 hover:to-indigo-500 text-white text-xs font-bold rounded-lg shadow-lg shadow-blue-500/20 transition-all cursor-pointer"
          >
            <Download size={14} />
            <span>Download All Files (.ZIP)</span>
          </a>
        </div>
      </div>

      {/* ── Right Code Viewer ── */}
      <div className="flex-1 flex flex-col bg-[#0A0D15] min-w-0">
        {/* Code Header Bar */}
        <div className="flex items-center justify-between px-4 py-2.5 bg-[#0D121E] border-b border-[#1B2538]">
          <div className="flex items-center gap-2.5 min-w-0">
            <Code2 size={16} className="text-blue-400 shrink-0" />
            <div className="flex flex-col min-w-0">
              <span className="font-mono text-xs font-bold text-slate-100 truncate">
                {selectedFile.path}
              </span>
              <span className="text-[10px] text-slate-400 truncate">
                {selectedFile.description}
              </span>
            </div>
          </div>

          <div className="flex items-center gap-2 shrink-0">
            <button
              onClick={handleCopy}
              className="flex items-center gap-1.5 px-3 py-1.5 bg-[#161F32] hover:bg-[#1E2A44] border border-[#273552] rounded-md text-xs font-medium text-slate-200 transition-colors cursor-pointer"
            >
              {copied ? <Check size={13} className="text-emerald-400" /> : <Copy size={13} />}
              <span>{copied ? 'Copied!' : 'Copy Code'}</span>
            </button>

            <button
              onClick={() => handleDownloadSingleFile(selectedFile)}
              className="flex items-center gap-1.5 px-3 py-1.5 bg-[#161F32] hover:bg-[#1E2A44] border border-[#273552] rounded-md text-xs font-medium text-slate-200 transition-colors cursor-pointer"
              title="Download this file"
            >
              <Download size={13} />
              <span className="hidden sm:inline">Save File</span>
            </button>
          </div>
        </div>

        {/* Code Body with Line Numbers */}
        <div className="flex-1 overflow-auto p-4 font-mono text-xs text-slate-300 leading-relaxed bg-[#080B12]">
          <pre className="flex gap-4">
            {/* Line numbers */}
            <div className="select-none text-slate-600 text-right pr-2 border-r border-[#1B2436] shrink-0 font-mono">
              {selectedFile.content.split('\n').map((_, i) => (
                <div key={i}>{i + 1}</div>
              ))}
            </div>
            {/* Code text */}
            <code className="text-slate-200 whitespace-pre overflow-x-auto flex-1 font-mono">
              {selectedFile.content}
            </code>
          </pre>
        </div>
      </div>
    </div>
  );
}
