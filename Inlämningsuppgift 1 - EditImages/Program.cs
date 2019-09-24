using System;
using System.Drawing;
using System.IO;
using Shared;

namespace Inlämningsuppgift_1___EditImages
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;
            
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                bool retry = false;
                string message = "Please enter the path to your image: ";
                string retryMessage = "\nCould not find image, please try again: ";

                while (!File.Exists(path))
                {
                    Console.Write(retry ? retryMessage : message);
                    path = Console.ReadLine();
                    retry = true;
                }
            }

            Console.WriteLine("Working...");

            Bitmap original;

            try
            {
                // Kolla om filen är en bildfil och tilldela isf den till "original"
                original = new Bitmap(path);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file is not an acceptable format.");
                return;
            }

            if (original.Width >= 5000 || original.Height >= 5000)
            {
                Console.WriteLine("The image cannot be over 5000 pixels in height or width.");
                return;
            }

            Bitmap negative = ImageManipulations.MakeNegative(original);
            negative.Save(PathManipulations.EditFileName(path, "_negative"));
            Console.WriteLine("Negative saved");

            Bitmap gray = ImageManipulations.MakeGray(original);
            gray.Save(PathManipulations.EditFileName(path, "_grayscale"));
            Console.WriteLine("Grayscale saved");

            Bitmap blurry = ImageManipulations.MakeBlurry(original);
            blurry.Save(PathManipulations.EditFileName(path, "_blurred"));
            Console.WriteLine("The blurry image saved");

            // Om vi inte har anledning att misstänka att en server använder programmet, 
            // så låt den eventuella användaren läsa eventuella meddelanden innan programmet avslutas. 
            if (args.Length == 0)
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
