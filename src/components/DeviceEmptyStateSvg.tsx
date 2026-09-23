export function DeviceEmptyStateSvg() {
  return (
    <div className="relative flex flex-col items-center justify-center select-none py-2">
      {/* Disconnected iPhone Chassis */}
      <svg
        width="110"
        height="180"
        viewBox="0 0 110 180"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
        className="drop-shadow-[0_0_15px_rgba(56,189,248,0.15)]"
      >
        {/* Outer Phone Frame */}
        <rect
          x="6"
          y="6"
          width="98"
          height="168"
          rx="22"
          stroke="#38BDF8"
          strokeWidth="2"
          strokeOpacity="0.75"
        />

        {/* Top Speaker / Ear Piece */}
        <line
          x1="45"
          y1="14"
          x2="65"
          y2="14"
          stroke="#38BDF8"
          strokeWidth="2"
          strokeLinecap="round"
          strokeOpacity="0.8"
        />

        {/* Top Status Bar: Battery Slashed (Top-Left) */}
        <g stroke="#38BDF8" strokeWidth="1.2" strokeOpacity="0.75" fill="none">
          <rect x="18" y="24" width="16" height="9" rx="2" />
          <line x1="34" y1="26.5" x2="35.5" y2="26.5" strokeWidth="1.5" strokeLinecap="round" />
          {/* Battery Red Diagonal Slash */}
          <line x1="16" y1="35" x2="36" y2="22" stroke="#EF4444" strokeWidth="1.5" strokeLinecap="round" />
        </g>

        {/* Top Status Bar: Wi-Fi Slashed (Top-Right) */}
        <g stroke="#38BDF8" strokeWidth="1.2" strokeOpacity="0.75" fill="none">
          <path d="M72 32 C75 29, 81 29, 84 32" strokeLinecap="round" />
          <path d="M75 35 C76.5 33.5, 79.5 33.5, 81 35" strokeLinecap="round" />
          <circle cx="78" cy="37.5" r="0.8" fill="#38BDF8" />
          {/* Wifi Red Diagonal Slash */}
          <line x1="70" y1="38" x2="86" y2="27" stroke="#EF4444" strokeWidth="1.5" strokeLinecap="round" />
        </g>

        {/* Big Modern Center 'X' */}
        <g stroke="#60A5FA" strokeWidth="2.8" strokeLinecap="round">
          <line x1="42" y1="76" x2="68" y2="102" />
          <line x1="68" y1="76" x2="42" y2="102" />
        </g>

        {/* Cellular Signal Bars & Red Mark */}
        <g fill="#38BDF8" fillOpacity="0.6">
          <rect x="20" y="138" width="2.5" height="4" rx="0.5" />
          <rect x="24" y="135" width="2.5" height="7" rx="0.5" />
          <rect x="28" y="132" width="2.5" height="10" rx="0.5" />
          <rect x="32" y="129" width="2.5" height="13" rx="0.5" />
        </g>
        {/* Tiny red x next to bars */}
        <g stroke="#EF4444" strokeWidth="1.2" strokeLinecap="round">
          <line x1="38" y1="133" x2="43" y2="138" />
          <line x1="43" y1="133" x2="38" y2="138" />
        </g>

        {/* Bottom Lock / Lightning / Power Icons */}
        <g stroke="#38BDF8" strokeWidth="1.2" strokeOpacity="0.6" fill="none">
          {/* Bell / alarm */}
          <path d="M50 156 A3 3 0 0 1 56 156 L57 159 L49 159 Z" />
          {/* Mini Lock */}
          <rect x="62" y="155" width="7" height="5" rx="1" />
          <path d="M63.5 155 V153 A2 2 0 0 1 67.5 153 V155" />
          {/* Mini Power */}
          <path d="M76 155 A3 3 0 1 0 80 155" strokeLinecap="round" />
          <line x1="78" y1="152" x2="78" y2="155" strokeLinecap="round" />
        </g>
      </svg>
    </div>
  );
}
