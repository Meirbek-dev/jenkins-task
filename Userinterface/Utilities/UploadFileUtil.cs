using System;
using System.IO;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace Userinterface.Utilities
{
    internal class UploadFileUtil
    {
        public static void UploadFile(string fileName)
        {
            Thread.Sleep(500);
            new InputSimulator().Keyboard
                .TextEntry(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName))
                .KeyDown(VirtualKeyCode.TAB)
                .KeyDown(VirtualKeyCode.TAB)
                .KeyDown(VirtualKeyCode.RETURN);
            Thread.Sleep(500);
        }
    }
}