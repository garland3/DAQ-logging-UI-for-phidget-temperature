# DAQ-logging-UI-for-phidget-temperature
## Overview
This is a simple data logger application that is meant to work with a phidget temperature sensor. It might be used at Clemson University in the General Engineering department.   
The application is meant to be very simple so that freshman can record data temperatures in large engineering classes.  
  
![UI](https://raw.githubusercontent.com/garland3/DAQ-logging-UI-for-phidget-temperature/master/tempSnip.PNG "Logo Title Text 1")
  
   
## Overview
This application is a modification of the example program that you can download from phidget.
## How to use
* Install the program
     * Go the NSIS folder for this repository.
     * Download the newest version
     * You might get a nasty security warning from windows when you install it. If you don't think it is safe, then search through the source code here on github until you are satisfied. 
* Plug in a Phidget temperature device
* Run the program
* Click 'Start Recording Data' to log temperature measurements every 0.5 seconds
* Click 'Stop Recording Data' to stop logging
* Click 'Save Data' to save the data to a csv file on the desktop. 
## Development
This app was developed with 
* Visual Studio 2017
* NSIS Installer
