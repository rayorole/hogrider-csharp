using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace hogrider
{
    public class Install
    {
        public static void Main()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dir = path + "\\hogrider\\";

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/931181529755959316/968412068350947328/unknown.png", dir+"\\miggers.png");
            webClient.DownloadFile("https://github.com/rayorole/viruses/raw/main/hog-rider.mp3", dir + "\\hog-rider.mp3");
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/954855477957771304/968920419925110784/hog_rider_tom.jpg", dir + "\\hoggy_doggy.jpg");
        }
    }
}
