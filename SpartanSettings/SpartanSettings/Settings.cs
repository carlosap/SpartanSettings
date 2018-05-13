using System.IO;
using static System.Environment;

namespace SpartanSettings
{
    public class Setting : ISetting
    {
        private static string _userProfile;

        /// <summary>
        /// Provides Application Folder location
        /// </summary>
        public string AppFolder { get; set; }


        /// <summary>
        /// sets initial enviromental settings folder
        /// userprofile and .spartan folder
        /// </summary>
        public Setting()
        {
            _userProfile = GetFolderPath(SpecialFolder.UserProfile);
            AppFolder = Path.Combine(_userProfile, ".spartan");
            if (!Directory.Exists(AppFolder))
            {
                Directory.CreateDirectory(AppFolder);
            }

        }

        /// <summary>
        /// Returns Module setting file path
        /// for example "appsettings" will return "c:\username\.spartan\appsettings.json"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateModuleSetting(string name)
        {
            string retVal = string.Empty;
            retVal = Path.Combine(AppFolder, $"{name}.json");
            if (!File.Exists(retVal))
            {
                File.Create(retVal).Close();
            }
            return retVal;

        }

        /// <summary>
        /// creates a folder under your userprofile/.spartan/[your foldername] path
        /// </summary>
        /// <param name="folderName">folder name</param>
        /// <returns>folder path</returns>
        public string CreateFolderSetting(string folderName)
        {
            string retVal = string.Empty;
            retVal = Path.Combine(AppFolder, folderName);
            if (!Directory.Exists(retVal))
            {
                Directory.CreateDirectory(retVal);
            }
            return retVal;
        }
    }
}
