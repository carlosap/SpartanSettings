using System.IO;
using static System.Environment;

namespace SpartanSettings
{
    public class Setting : ISetting
    {
        /// <summary>
        /// Returns Module setting file path
        /// for example "appsettings" will return "c:\username\.spartan\appsettings.json"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateModuleSetting(string name)
        {
            string retVal = string.Empty;
            string userProfile = GetFolderPath(SpecialFolder.UserProfile);
            string appFolder = Path.Combine(userProfile, ".spartan");
            retVal = Path.Combine(appFolder, $"{name}.json");

            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
                File.Create(retVal).Close();
            }

            if (!File.Exists(retVal))
            {
                File.Create(retVal).Close();
            }

            return retVal;

        }
    }
}
