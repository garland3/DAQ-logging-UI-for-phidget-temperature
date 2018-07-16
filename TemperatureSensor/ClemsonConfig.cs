using System;
using System.Collections.Generic;
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

    }
}
