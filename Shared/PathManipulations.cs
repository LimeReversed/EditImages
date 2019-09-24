using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Shared
{
    public class PathManipulations
    {
        /// <summary>
        /// Inserts the string of your choice to the end of the file name but before an eventual file extension.
        /// </summary>
        /// <param name="nameOrPath"></param>
        /// <param name="insertThis"></param>
        /// <returns></returns>
        public static string EditFileName(string nameOrPath, string insertThis)
        {
            string pathToFile = Path.GetDirectoryName(nameOrPath);
            string updatedName = $"{Path.GetFileNameWithoutExtension(nameOrPath)}{insertThis}";
            string extension = Path.GetExtension(nameOrPath);
            
            return $"{pathToFile}{Path.DirectorySeparatorChar}{updatedName}{extension}";
        }
    }
}
