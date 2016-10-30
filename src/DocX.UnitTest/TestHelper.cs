using System;
using System.IO;
using System.Reflection;

namespace UnitTests
{
    public static class TestHelper
    {
        static TestHelper()
        {
            string baseDirectory = System.AppContext.BaseDirectory;

            DirectoryWithFiles = Path.Combine(baseDirectory, "documents");
        }

        public static string DirectoryWithFiles { get; }
    }
}