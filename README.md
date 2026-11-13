# Local Crypto Wallet Inventory Analyzer (Public PoC)

A lightweight, strictly **read-only** Windows desktop Proof-of-Concept built with **C# / WPF (.NET 8)**.

## Security & Scope
- **Non-Intrusive:** Performs directory metadata checks only. Never launches wallet applications or accesses private keys, seed phrases, or vault files.
- **Demo Limitation:** This public PoC intentionally scans only the **Google Chrome Default profile** for **MetaMask** extension metadata.
- Full multi-browser enumeration (Edge, Brave, Firefox, multi-profile), desktop wallet detection (Exodus, Ledger Live, Trezor Suite, Atomic), installation timestamps, and structured reporting are reserved for the production build.

## How to Run
1. Open `WalletScannerDemo.csproj` in Visual Studio 2022 (with .NET Desktop Development workload) or run via CLI:
   ```bash
   dotnet run
   ```
