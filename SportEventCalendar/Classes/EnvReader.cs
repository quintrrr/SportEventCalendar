using System;

namespace SportEventCalendar.Classes
{
    using System;
    using System.IO;
    using SportEventCalendar.Properties;

    class EnvReader
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show(Resources.fileDoesntExist, Resources.errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                {
                    continue; 
                }

                var parts = line.Split('=', 2);
                if (parts.Length != 2)
                {
                    continue;
                }
                var key = parts[0].Trim();
                var value = parts[1].Trim();
                Environment.SetEnvironmentVariable(key, value);
            }
        }
    }

}
