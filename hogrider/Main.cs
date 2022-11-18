using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using hogrider;


/*[DllImport("kernel32.dll")]
static extern IntPtr GetConsoleWindow();

[DllImport("user32.dll")]
static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

const int SW_HIDE = 0;

var handle = GetConsoleWindow();
ShowWindow(handle, SW_HIDE);*/



string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string dir = path + "\\hogrider\\";

// Thread.Sleep(60000 * 2); // 2 Minutes

// Check if directory exists
if (Directory.Exists(dir))
{
    Console.WriteLine("Directory found, skipping installs...");
} else
{
    Directory.CreateDirectory(dir);
    Install.Main();
}

/*System.Windows.Forms.MessageBox.Show("Free bo frans my G", "Hog rider coc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
Utils.ChangeVolume();*/

Utils.OpenFile(dir, "hoggy_doggy.jpg");
Utils.OpenFile(dir, "miggers.png");
// Utils.OpenUrl("https://www.google.com/search?q=How+to+buy+hasj+on+darkweb+legit+tutorial+2016&rlz=1C1GCEA_enBE992BE992&oq=How+to+buy+hasj+on+darkweb+legit+tutorial+2016&aqs=chrome..69i57.218j0j9&sourceid=chrome&ie=UTF-8");