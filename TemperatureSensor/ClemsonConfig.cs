﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TemperatureSensor_Example
{
    class ClemsonConfig
    {
        public static string outputFolder;
        public static bool isRecording = false;

        public static string DisplayRecordingState()
        {
            if(isRecording == true)
            {
                return "Recording Data";
            } else
            {
                return "Not Recording Data";
            }
        }

        internal static void SetDesktopAsDefaultOutputFolder()
        {
            string temp = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine("GetFolderPath: {0}", temp);
            outputFolder = temp;
        }
    }

    class DataMeasurement
    {
        double temperature;
        DateTime timestamp;

        public DataMeasurement()
        {

        }

        public DataMeasurement(double temp, DateTime t)
        {
            this.temperature = temp;
            this.timestamp = t;
        }

        public string ToCSVFileLine()
        {
            return string.Format("{0},{1}", timestamp.ToString("s"), temperature.ToString());
        }

        internal string ToCSVFileLine(DateTime startRecordingDateTime)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            TimeSpan t = this.timestamp.Subtract(startRecordingDateTime);
            return string.Format("{0},{2},{1}",
                timestamp.ToString("M/dd/yyy hh:mm:ss.FFF", ci),
                temperature.ToString(),
                t.TotalSeconds);
        }
    }
}
