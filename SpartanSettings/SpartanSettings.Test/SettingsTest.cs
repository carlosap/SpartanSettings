using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace SpartanSettings.Test
{
    [TestClass]
    public class SettingsTest
    {
        [TestMethod]
        public void TestCreateFolderSetting()
        {
            var _settings = new Setting();
            var expFolder = _settings.CreateFolderSetting("Logs");
            Assert.IsTrue(Directory.Exists(expFolder));
        }

        [TestMethod]
        public void TestCreateModuleSetting()
        {
            var _settings = new Setting();
            var expectedJsonFile = _settings.CreateModuleSetting("test");
            Assert.IsTrue(File.Exists(expectedJsonFile));
        }

        [TestMethod]
        public void TestAppFolder()
        {
            var _settings = new Setting();
            var appFolder = _settings.AppFolder;
            Assert.IsTrue(Directory.Exists(appFolder));
        }

    }
}
