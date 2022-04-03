using System.IO;

namespace MetaP.Test
{
    /// <summary>Contains test utitlity code.</summary>
    public class Utility
    {
        /// <summary>The full path of the project directory.</summary>
        public static string ProjectDir { get; }

        /// <summary>The full path of the output directory.</summary>
        public static string OutputDir { get; }

        /// <summary>Initializes the <see cref="Utility"/> class.</summary>
        static Utility()
        {
            ProjectDir = GetProjectDir();
            OutputDir = Path.Combine(ProjectDir, "Data", "Output");
        }

        private static string GetProjectDir()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            if (currentDirectory != null)
            {
                DirectoryInfo? debugDir = Directory.GetParent(currentDirectory);
                if (debugDir != null)
                {
                    DirectoryInfo? projectDir = debugDir?.Parent?.Parent;
                    if (projectDir != null) return projectDir.FullName;
                }
            }

            return "** Project Directory Path not found **";
        }

        /// <summary>Returns the full path specification of a specified relative output path.</summary>
        /// <param name="relativePath">A path relative to the output folder.</param>
        /// <returns></returns>
        public static string GetOutputPath(string relativePath) => Path.Combine(OutputDir, relativePath);
    }
}
