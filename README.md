# DAQ-logging-UI-for-phidget-temperature
## Overview
This is a simple data logger application that is meant to work with a phidget temperature sensor. It might be used at Clemson University in the General Engineering department.   
The application is meant to be very simple so that freshman can record data temperatures in large engineering classes.  
  
![UI](https://raw.githubusercontent.com/garland3/DAQ-logging-UI-for-phidget-temperature/master/Images/Version1.02.PNG "Logo Title Text 1")
  
   
## Overview
This application is a modification of the example program that you can download from phidget.

## Installation
You need to install two things to collect data with the phidgets.
1. Phidget Drivers
   1. Download the Phidget drivers from the phidget website [www.phidgets.com](https://www.phidgets.com/docs/OS_-_Windows#Getting_started_with_Windows). In the Install section, you need to download and install the 64-bit Installer Download. See the screenshot below for reference.
   1. ![UI](https://github.com/garland3/DAQ-logging-UI-for-phidget-temperature/blob/master/phidgetDriverDownload1.png)  
1. Phidget Data Logging Software
   1. In the NSIS folder of this repository, [NSIS](./NSIS), find the newest version of the DAQ software and download it. 
   1. Chrome might block download this software since it is not used often. But you can override this block.
   1. Run the installer. 
   1. You might get a nasty security warning from windows when you install it. Again, you can override this security block and run the installer anyway. If you don't think it is safe, then search through the source code here on github until you are satisfied.

## How to use

* Plug in a Phidget temperature device
* Run the program
* Click 'Start Recording Data' to log temperature measurements every 5 seconds
* Click 'Stop Recording Data' to stop logging
* Click 'Save Data' to save the data to a csv file. 
    * The csv file has three columns (Timestamp, Elapsed time [s], and Temperature [C]). 
    * The delta T is the difference in time from when you clicked "Start Recording" until the measurements was made. The units are seconds. 
    * If you view the csv file in Microsft Excel, then the Timestamp will not show correct. If you open the .csv file in a text editor (like notepad), then you can see the whole time stamp information. 
    * The update interval is 0.20 Hz (5 s) by default. Depending on your computer, a slightly delay may cause the update-interval to be slightly larger. You can see this when you compare the time-stamps. 
* Click 'Clear Data' to clear any recorded data. 
## Development
This app was developed with 
* Visual Studio 2017
* NSIS Installer

###
* Install Phidget22.NET from NuGet to get fix any reference problems. 

## Found a problem?
* Bugs exist. Help squash them by reporting an issue [Report an issue here.](https://github.com/garland3/DAQ-logging-UI-for-phidget-temperature/issues)
* Thought of an amazing addition to the software that you would like? [Click here](https://github.com/garland3/DAQ-logging-UI-for-phidget-temperature/issues) to make a new feature request. Your issue should have the tag, *Enhancement*.

