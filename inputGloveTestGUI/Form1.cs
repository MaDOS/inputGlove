using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using arduinoLib;

namespace inputGlove
{
    public partial class Form1 : Form
    {
        string comPort = "COM3";
        gloveIno device;

        public Form1()
        {
            Form.CheckForIllegalCrossThreadCalls = false; //dbg

            InitializeComponent();
            debugHelper.frmInstance = this;
            debugHelper.lstDebug = this.lstLog;
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = new gloveIno(comboBox1.SelectedItem.ToString());
        }
    }
}
