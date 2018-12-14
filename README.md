# DAQ-logging-UI-for-phidget-temperature
## Overview
This is a simple data logger application that is meant to work with a phidget temperature sensor. It might be used at Clemson University in the General Engineering department.   
The application is meant to be very simple so that freshman can record data temperatures in large engineering classes.  
  
![UI](https://raw.githubusercontent.com/garland3/DAQ-logging-UI-for-phidget-temperature/master/Images/Version1.02.PNG "Logo Title Text 1")
  
   
## Overview
This application is a modification of the example program that you can download from phidget.

## Installation
* Download the Phidget drivers from the phidget website [www.phidgets.com](https://www.phidgets.com/docs/OS_-_Windows#Getting_started_with_Windows). In the Quick Downloads section, you need to download and install the 64-bit Installer Download.   
  
![UI](https://github.com/garland3/DAQ-logging-UI-for-phidget-temperature/blob/master/phidgetDriverDownload.png)  
  
* In the NSIS folder of this repository, [NSIS](./NSIS), find the newest version of the DAQ software and download it. 
* Chrome might block download this software since it is not used often. But you can override this block.
* Run the installer. 
* You might get a nasty security warning from windows when you install it. If you don't think it is safe, then search through the source code here on github until you are satisfied. Again, you can override this security block and run the installer anyway. 

## How to use

* Plug in a Phidget temperature device
* Run the program
* Click 'Start Recording Data' to log temperature measurements every 5 seconds
* Click 'Stop Recording Data' to stop logging
* Click 'Save Data' to save the data to a csv file. 
    * The csv file has three columns (Timestamp, delta T (delta Time) and temperature). 
    * The delta T is the difference in time from when you clicked "Start Recording" until the measurements was made. The units are seconds. 
    * If you view the csv file in Microsft Excel, then the Timestamp will not show correct. If you open the .csv file in a text editor (like notepad), then youc an see the whole time stamp information. 
    * The update interval is 500 ms by default. Depending on your computer, a slightly delay may cause the update-interval to be slightly larger. You can see this when you compare the time-stamps. 
* Click 'Clear Data' to clear any recorded data. 
## Development
This app was developed with 
* Visual Studio 2017
* NSIS Installer

## Found a problem?
* Bugs exist. Help squash them by reporting an issue [Report an issue here.](https://github.com/garland3/DAQ-logging-UI-for-phidget-temperature/issues)
* Thought of an amazing addition to the software that you would like? [Click here](https://github.com/garland3/DAQ-logging-UI-for-phidget-temperature/issues) to make a new feature request. Your issue should have the tag, *Enhancement*.

