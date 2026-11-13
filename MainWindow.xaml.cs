using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace WalletScannerDemo
{
    public partial class MainWindow : Window
    {
        // Demo Scope: Only MetaMask Extension ID on Chrome Default Profile
        private const string MetaMaskId = "nkbihfbeogaeaoehlefnkodbefgpgknn";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRunDemo_Click(object sender, RoutedEventArgs e)
        {
            var demoList = new List<DemoItem>();

            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string chromeDefaultExt = Path.Combine(localAppData, @"Google\Chrome\User Data\Default\Extensions", MetaMaskId);

            // Read-only directory existence check (No vault or key access)
            if (Directory.Exists(chromeDefaultExt))
            {
                demoList.Add(new DemoItem
                {
                    Name = "MetaMask",
                    Source = "Chrome (Default Profile)",
                    Status = "Detected (Metadata Only)"
                });
            }

            // NOTE: Additional browsers (Edge, Brave, Firefox), multi-profile enumeration,
            // desktop wallet registry/folder scanners, and install timestamp parsers
            // are implemented in the full private repository.

            DgDemoResults.ItemsSource = demoList;
            TxtStatus.Text = demoList.Count > 0 
                ? "Demo scan finished (1 sample item shown)." 
                : "MetaMask not found in Chrome Default profile.";
        }
    }

    public class DemoItem
    {
        public string Name { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
