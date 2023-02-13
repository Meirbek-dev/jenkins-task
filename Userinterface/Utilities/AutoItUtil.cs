using AutoItX3Lib;
using System.IO;

namespace Userinterface.Utilities
{
    internal class AutoItUtil
    {
        private const string _enterKey = "{ENTER}";
        private const string _uploadFileWindowName = "Open";

        public static void UploadFile(string pathToFile)
        {
            AutoItX3 auto = new AutoItX3();
            auto.WinActivate(_uploadFileWindowName);
            auto.WinWaitActive(_uploadFileWindowName);
            auto.Send(Path.GetFullPath(pathToFile));
            auto.Send(_enterKey);
            auto.WinWaitClose(_uploadFileWindowName, "", 5);
        }
    }
}