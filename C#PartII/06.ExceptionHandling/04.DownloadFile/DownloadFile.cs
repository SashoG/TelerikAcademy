using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter URI for download:");
                string str = Console.ReadLine();
                Uri myUri = new Uri(str);
                WebClient webClinet = new WebClient();
                webClinet.DownloadFile(myUri, "logo.jpg");
            }
            catch (WebException)
            {
                Console.WriteLine("Error while downloading");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("URI is empty");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Problem with URI format");
            }
        }
    }
}
