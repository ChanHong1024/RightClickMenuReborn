using System.Collections.Generic;
using Microsoft.Win32;
using System.Diagnostics;

namespace RightClickMenuReborn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateLog(string message)
        {
            // Get current timestamp
            string timestamp = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            listBoxLog.Items.Add("[" + timestamp + "]: " + message);
        }

        private void EnableWin10Menu()
        {
            try
            {
                // Create the registry key
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(
                    @"Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32"))
                {
                    key.SetValue("", "", RegistryValueKind.String);
                }
                // Display success message
                CreateLog("Windows 10 style context menu enabled!");
            }
            catch (Exception ex)
            {
                CreateLog($"Error: {ex.Message}");
            }
        }

        private void EnableWin11Menu()
        {
            try
            {
                // Delete the registry key
                Registry.CurrentUser.DeleteSubKeyTree(
                    @"Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}", false);
                // Display success message
                CreateLog("Windows 11 style context menu restored!");
            }
            catch (Exception ex)
            {
                CreateLog($"Error: {ex.Message}");
            }
        }

        private void CheckMenuStyle()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32"))
                {
                    if (key != null && key.GetValue("").ToString() == "")
                    {
                        // Prevent the event from firing when setting the checkbox state
                        btnEnable.CheckedChanged -= btnEnable_CheckedChanged;
                        btnEnable.Checked = true;
                        btnEnable.CheckedChanged += btnEnable_CheckedChanged;
                    }
                    else
                    {
                        // Prevent the event from firing when setting the checkbox state
                        btnEnable.CheckedChanged -= btnEnable_CheckedChanged;
                        btnEnable.Checked = false;
                        btnEnable.CheckedChanged += btnEnable_CheckedChanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RestartExplorer()
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                }
                Process.Start("explorer.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restarting Explorer: {ex.Message}");
                CreateLog($"Error restarting Explorer: {ex.Message}");
            }
        }

        private void btnEnable_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (btnEnable.Checked)
            {
                // Enable the Windows 10 style context menu
                EnableWin10Menu();
            }
            else
            {
                // Enable the Windows 11 style context menu
                EnableWin11Menu();
            }
            // Restart Explorer to apply changes
            RestartExplorer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateLog("Please make sure to run this application as an administrator.");
            CheckMenuStyle();
        }
    }
}
