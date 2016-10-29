using System;
using System.IO;
using System.Reflection;

namespace UnitTests
{
    public static class TestHelper
    {
        static TestHelper()
        {
            string baseDirectory = Assembly.GetEntryAssembly().Location;

            DirectoryWithFiles = Path.Combine(baseDirectory, "documents");
        }

        public static string DirectoryWithFiles { get; }
    }
}