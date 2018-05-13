namespace SpartanSettings
{
    public interface ISetting
    {
        string CreateModuleSetting(string name);
        string CreateFolderSetting(string folderName);
        string GetAppFolder();
    }
}
