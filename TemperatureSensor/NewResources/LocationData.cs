using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phidget22.ExampleUtils
{
    public partial class LocationData : Form
    {
        string serial, port, channel, hubport, server, ip, _class;
        bool remoteFlag = false;

        public LocationData()
        {
            InitializeComponent();
        }

        public LocationData(Phidget22.Phidget device)
        {
            serial = device.DeviceSerialNumber.ToString();
            port = device.HubPort.ToString();
            channel = device.Channel.ToString();
            hubport = device.IsHubPortDevice.ToString();
            _class = device.ChannelClass.ToString();
            if (device.IsRemote)
            {
                remoteFlag = true;
                server = device.ServerHostname.ToString();
                ip = device.ServerPeerName.ToString();
            }

            InitializeComponent();
        }

        private void LocationData_Load(object sender, EventArgs e)
        {
            serialTxt.Text = serial;
            portTxt.Text = port;
            channelTxt.Text = channel;
            hubportTxt.Text = hubport;
            classTxt.Text = _class;
            if (remoteFlag)
            {
                serverTxt.Text = server;
                ipTxt.Text = ip;
            }
            else
            {
                serverTxt.Text = "Locally attached";
                ipTxt.Text = "Locally attached";
            }
        }
    }
}
