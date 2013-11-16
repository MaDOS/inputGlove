using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using arduinoLib;

namespace inputGlove
{
    public class gloveIno : uno
    {
        public gloveIno(string comPort)
            : base(comPort)
        {
            this.ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ComPort_DataReceived);
        }

        private void ComPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = ComPort.ReadTo(";");
            debugHelper.addDbgMsg("Data received: " + data);
            gloveInputHandler.interpreteInput(data);
        }
    }
}
