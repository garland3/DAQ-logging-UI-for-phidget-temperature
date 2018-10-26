using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using Phidget22.ExampleUtils;
using PhidgetsControlLibrary;
using System.IO;

namespace TemperatureSensor_Example {
	public partial class Form1 : Form {
		CommandLineOpen open;
        formCleaner cleaner;
        TemperatureSensor temp = null;
		private ErrorEventBox errorBox;

        List<DataMeasurement> measurementList = new List<DataMeasurement>();

        private DateTime startRecordingDateTime;

        private int samplePeriod = 500; // in milli-seconds

		public Form1() {
			open = new CommandLineOpen(this);
            cleaner = new formCleaner(this);
            InitializeComponent();
		}

		public Form1(String[] commandLine) {
			open = new CommandLineOpen(this);
            cleaner = new formCleaner(this);
            open.commandLine = commandLine;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			

			errorBox = new ErrorEventBox(this);
            this.Size = new Size(533, 375);

            this.Size = this.MinimumSize;

            ClemsonConfig.SetDesktopAsDefaultOutputFolder();

			temp = new TemperatureSensor();

			//setup event handlers for the phidget
			temp.Attach += temp_attach;
            temp.Attach += GarlandOnAttach;
            temp.Detach += temp_detach;
			temp.Error += temp_error;
			temp.TemperatureChange += temp_change;
            temp.TemperatureChange += Temp_change_garland;


            List<TemperatureSensor> something = new List<TemperatureSensor>();
			something.Add(new TemperatureSensor());

            commandLineData phidgetParameters = open.parseCmdLine(); //get command line parameters

            try
            { //set all the values grabbed from command line.  these values have defaults that are set in ExampleUtils.cs, you can check there to see them.
                temp.Channel = phidgetParameters.Channel; //selects the channel on the device to open
                temp.DeviceSerialNumber = phidgetParameters.SerialNumber; //selects the device or hub to open
                temp.HubPort = phidgetParameters.HubPort; //selects the port on the hub to open
                temp.IsHubPortDevice = phidgetParameters.isHubPortDevice; //is the device a port on a VINT hub?

                if (phidgetParameters.isRemote) //are we trying to open a remote device?
                {
                    temp.IsRemote = true;
                    Net.EnableServerDiscovery(ServerType.Device); //turn on network scan
                    if (phidgetParameters.Password != null && phidgetParameters.ServerName != null)
                        Net.SetServerPassword(phidgetParameters.ServerName, phidgetParameters.Password); //set the password if there is one
                }
                else
                    temp.IsLocal = true;

                temp.Open(); //open the device specified by the above parameters
            }
            catch (PhidgetException ex)
            {
                errorBox.addMessage("Error opening device: " + ex.Message);
            }

            //settingsBox.Visible = false;
           
        }

        void GarlandOnAttach(object sender, AttachEventArgs e)
        {
            string local_string = temp.DeviceName;
            ShowMessageToOutputBox(local_string);

            // ---------------
            // Set  the intervalu rate. 
            // ---------------
            temp.DataInterval = samplePeriod; // ms
            //ShowMessageToOutputBox("Update rate 500 ms");
            temp.TemperatureChangeTrigger = 0; // this will cause the update temperature to fire every DataInterval

            // ShowMessageToOutputBox("Min interval");
            //ShowMessageToOutputBox(temp.MinDataInterval.ToString());
            //ShowMessageToOutputBox("Max interval");
            //ShowMessageToOutputBox(temp.MaxDataInterval.ToString());
            // temp.DataInterval = 
        }

        void Temp_change_garland(object sender, TemperatureSensorTemperatureChangeEventArgs e)
        {
            // tempTxt.Text = e.Temperature.ToString() + "°C";
            //);
            if (ClemsonConfig.isRecording)
            {
                measurementList.Add(new DataMeasurement(e.Temperature, DateTime.Now));
            }
            
        }

        public void ShowMessageToOutputBox(string message)
        {
            richTextBox1.AppendText(message+"\n");
           
        }

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			temp.Close();
		}

		void temp_attach(object sender, Phidget22.Events.AttachEventArgs e) {
			phidgetInfoBox1.FillPhidgetInfo((Phidget)sender);

			TemperatureSensor attachedDevice = (TemperatureSensor)sender;

            dataIntervalTrk.Unit = "ms";
			dataIntervalTrk.minTxt = attachedDevice.MinDataInterval.ToString();
			dataIntervalTrk.Minimum = attachedDevice.MinDataInterval;
			dataIntervalTrk.maxTxt = attachedDevice.MaxDataInterval.ToString();
			dataIntervalTrk.Maximum = attachedDevice.MaxDataInterval;
			dataIntervalTrk.Value = attachedDevice.DataInterval;

			//differing max/min means the interval is a settable configuration
			if (attachedDevice.MaxDataInterval == attachedDevice.MinDataInterval)
				dataIntervalTrk.Enabled = false;

            changeTriggerTrk.Unit = "°C";
			changeTriggerTrk.minTxt = attachedDevice.MinTemperatureChangeTrigger.ToString();
			changeTriggerTrk.Minimum = attachedDevice.MinTemperatureChangeTrigger;
			changeTriggerTrk.Maximum = attachedDevice.MaxTemperatureChangeTrigger;
			changeTriggerTrk.maxTxt = attachedDevice.MaxTemperatureChangeTrigger.ToString();
			changeTriggerTrk.Value = attachedDevice.TemperatureChangeTrigger;

			//adjust any device specific settings
			//switch (temp.ChannelSubclass) {
			//case ChannelSubclass.TemperatureSensorThermocouple:
			//	additionalSettings.Visible = true;
			//	thermocouplePanel.Visible = true;
			//	thermocoupletypeCombo.DataSource = typeof(ThermocoupleType).ToList();
			//	thermocoupletypeCombo.SelectedIndex = 1; //set it to K-type by default
			//	break;
   //         case ChannelSubclass.TemperatureSensorRTD:
   //             additionalSettings.Visible = true;
   //             rtdTypePanel.Visible = true;
   //             rtdTypeCombo.DataSource = typeof(RTDType).ToList();
   //             rtdTypeCombo.SelectedIndex = 1; //set it to PT1000_3850 by default
   //             rtdWireSetupPanel.Visible = true;
   //             rtdWireSetupCombo.DataSource = typeof(RTDWireSetup).ToList();
   //             rtdWireSetupCombo.SelectedIndex = 2; //set it to 4-wire by default
   //             break;
			//default:
			//	break;
			//}
			//settingsBox.Visible = true;
			outputBox.Visible = true;
		}


		void temp_detach(object sender, Phidget22.Events.DetachEventArgs e) {
			phidgetInfoBox1.Clear();
            cleaner.clean();

            settingsBox.Visible = false;
			outputBox.Visible = false;
			//thermocouplePanel.Visible = false;
   //         rtdTypePanel.Visible = false;
   //         rtdWireSetupPanel.Visible = false;
   //         additionalSettings.Visible = false;
		}

		void temp_error(object sender, Phidget22.Events.ErrorEventArgs e) {
			errorBox.addMessage(e.Description);
		}

		void temp_change(object sender, Phidget22.Events.TemperatureSensorTemperatureChangeEventArgs e) {
			tempTxt.Text = e.Temperature.ToString() + "°C";
		}

		private void thermocoupletypeCombo_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				temp.ThermocoupleType = (ThermocoupleType)Enum.Parse(typeof(ThermocoupleType), thermocoupletypeCombo.SelectedValue.ToString());
			} catch (PhidgetException ex) { errorBox.addMessage("Error setting thermocouple type: " + ex.Message); }
		}

        private void rtdTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                temp.RTDType = (RTDType)Enum.Parse(typeof(RTDType), rtdTypeCombo.SelectedValue.ToString());
            }
            catch (PhidgetException ex) { errorBox.addMessage("Error setting RTD type: " + ex.Message); }
        }

        private void rtdWireSetupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                temp.RTDWireSetup = (RTDWireSetup)Enum.Parse(typeof(RTDWireSetup), rtdWireSetupCombo.SelectedValue.ToString());
            }
            catch (PhidgetException ex) { errorBox.addMessage("Error setting RTD type: " + ex.Message); }
        }

        private void changeTriggerCustom_LogScroll(object sender, EventArgs e) {
			if (MouseButtons != MouseButtons.Left) {
				try {
					temp.TemperatureChangeTrigger = changeTriggerTrk.Value;
				} catch (Exception ex) {
					errorBox.addMessage("Error setting change trigger: " + ex.Message);
				}
			}
		}

		private void changeTriggerCustom_LogMouseUp(object sender, MouseEventArgs e) {
			try {
				temp.TemperatureChangeTrigger = changeTriggerTrk.Value;
			} catch (Exception ex) {
				errorBox.addMessage("Error setting change trigger: " + ex.Message);
			}
		}

		private void dataInvertalTrk_LogScroll(object sender, EventArgs e) {
			if (MouseButtons != MouseButtons.Left) {
				try {
					temp.DataInterval = (int)dataIntervalTrk.Value;
				} catch (Exception ex) {
					errorBox.addMessage("Error setting data interval: " + ex.Message);
				}
			}
		}

		private void dataInvertalTrk_LogMouseUp(object sender, MouseEventArgs e) {
			try {
				temp.DataInterval = (int)dataIntervalTrk.Value;
			} catch (Exception ex) {
				errorBox.addMessage("Error setting data interval: " + ex.Message);
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string local_string = folderBrowserDialog1.SelectedPath;
                ShowMessageToOutputBox(local_string);
                ClemsonConfig.outputFolder = local_string;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear any old data before recording new data. 
            // Button 4 is the clear data button. 
            button4_Click(null, null);

            startRecordingDateTime = DateTime.Now;


            ClemsonConfig.isRecording = true;
            ShowMessageToOutputBox(ClemsonConfig.DisplayRecordingState());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClemsonConfig.isRecording = false;
            ShowMessageToOutputBox("Stopped Recording Data");
           // ShowMessageToOutputBox(ClemsonConfig.DisplayRecordingState());

          
        }

        private void SaveDataToFile()
        {
            int interation = 1;
            string outname = "temperature_data"+DateTime.Now.ToString("HH_mm_ss")+"_ " + interation + ".csv";
            string fullpath = Path.Combine(ClemsonConfig.outputFolder, outname);
            
            while ( File.Exists(fullpath))
            {
                outname = "temperature_data" + interation + ".csv";
                fullpath = Path.Combine(ClemsonConfig.outputFolder, outname);
                interation++;
                //ShowMessageToOutputBox("File name is: "+ outname);
            }
            ShowMessageToOutputBox("Folder: " + ClemsonConfig.outputFolder);
            ShowMessageToOutputBox("File : " + outname);

            SaveDataToCSV(fullpath);
        }

        private void SaveDataToCSV(string fullpath)
        {
            //before your loop
            var csv = new StringBuilder();

            string first = "TimeStamp";
            string second = "Delta T in seconds";
            string third = "Temperature in C";
            var newLine = string.Format("{0},{1},{2}", first, second,third);
            csv.AppendLine(newLine);

            //in your loop
            foreach (DataMeasurement measure in measurementList){
             
                csv.AppendLine(measure.ToCSVFileLine(startRecordingDateTime));
            }
           

            //after your loop
            File.WriteAllText(fullpath, csv.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.measurementList.Clear();
            ShowMessageToOutputBox("Cleared Any Recorded Data");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            phidgetInfoBox1.Visible = checkBox1.Checked;
            settingsBox.Visible = checkBox1.Checked;
            //additionalSettings.Visible = checkBox1.Checked;
            if (checkBox1.Checked == false)
                this.Size = new Size(533, 375);
            else
                this.Size = new Size(533, 700);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ClemsonConfig.isRecording == true)
            {
                ClemsonConfig.isRecording = false;
            }


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv file|*.csv";
            saveFileDialog1.Title = "Save an Data File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                
                SaveDataToFile(saveFileDialog1.FileName);
            }

               
           
        }

        private void SaveDataToFile(string fileName)
        {
            SaveDataToCSV(fileName);
        }
    }
}