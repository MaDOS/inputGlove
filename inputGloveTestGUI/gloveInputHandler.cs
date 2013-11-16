using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace inputGlove
{
    static class gloveInputHandler
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        private static void mouse_down_left()
        {
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
        }


        private static void mouse_up_left()
        {
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        public static void interpreteInput(string data)
        {
            string[] commands = data.Split(';');

            foreach (string command in commands)
            {
                if (command.Trim() != "")
                {
                    debugHelper.addDbgMsg("interpreting command: " + command);
                    interpreteCommand(command);
                }
            }
        }

        public static void interpreteCommand(string command)
        {
            if (command.StartsWith("mouse"))
            {
                debugHelper.addDbgMsg("-> mouse event found");
                command = command.Remove(0, 6);
                string[] parameters = command.Split(':');

                if (parameters[0] == "left")
                {
                    if (parameters[1] == "down")
                    {
                        debugHelper.addDbgMsg("-> left mouse down");
                        mouse_down_left();
                    }
                    else if (parameters[1] == "up")
                    {
                        debugHelper.addDbgMsg("-> left mouse up");
                        mouse_up_left();
                    }
                }
            }
        }
    }
}
