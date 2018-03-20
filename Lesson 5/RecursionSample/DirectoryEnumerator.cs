namespace RecursionSample
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public sealed class DirectoryEnumerator
    {
        private readonly List<string> directories = new List<string>();

        public IEnumerable<string> Directories
        {
            get { return directories; }
        }

        public void Enumerate(string directory)
        {            
            try
            {
                foreach (string dir in Directory.GetDirectories(directory))
                {
                    directories.Add(dir);
                    Enumerate(dir);
                }
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
