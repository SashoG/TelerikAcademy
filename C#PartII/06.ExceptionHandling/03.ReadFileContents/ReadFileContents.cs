using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.ReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file path:");
                string str = Console.ReadLine();
                string fileContents = File.ReadAllText(str, UnicodeEncoding.Unicode);
                Console.WriteLine(fileContents);
            }
           
            catch (ArgumentNullException)
            {
                Console.WriteLine("No path is enetered");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid path");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("No such directory");
            }    
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is not in a valid format");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No access for you");
            }
            catch (IOException)
            {
                Console.WriteLine("Error opening file");
            }
        }
    }
}
