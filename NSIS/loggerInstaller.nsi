#

;NSIS Modern User Interface
;Basic Example Script
;Written by Joost Verburg
;
; modified for DAQ Phidget logger

;--------------------------------
;Include Modern UI and .net checker




!include "MUI2.nsh"
# !addplugindir "NsisDotNetChecker\bin",moved the dll to the plugins directory
# !include "DotNetChecker.nsh"
;--------------------------------
;General

;Name and file

!define PRODUCT_NAME "Phidget_Temperature_Logger"
!define PRODUCT_VERSION "1.00"
!define PRODUCT_PUBLISHER "Clemson University (open source development)"
!define PRODUCT_WEB_SITE "https://github.com/garland3/DAQ-logging-UI-for-phidget-temperature"

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "${PRODUCT_NAME}_${PRODUCT_VERSION}.exe"

; main.exe output
!define EXE_FILE "Phidgets_temp_data_logger.exe"

;Default installation folder
InstallDir "$PROGRAMFILES64\DAQ_Logger"

!define  FolderAndFile ""

;Get installation folder from registry if available
InstallDirRegKey HKCU "Software\Logger" ""

;Request application privileges for Windows Vista
RequestExecutionLevel admin

; images and icons
!define MUI_ICON "..\..\Common\phidget_icon.ico"
!define MUI_UNICON "..\..\Common\phidget_icon.ico"
;!define MUI_HEADERIMAGE
;!define MUI_HEADERIMAGE_BITMAP 
;!define MUI_HEADERIMAGE_RIGHT




;--------------------------------
;Interface Settings

!define MUI_ABORTWARNING

;--------------------------------
;Pages

# !insertmacro MUI_PAGE_LICENSE "garlandLicense.rtf"
;!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!define MUI_FINISHPAGE_RUN "$INSTDIR\${EXE_FILE}"
!define MUI_FINISHPAGE_RUN_TEXT "Launch ${PRODUCT_NAME}"
!insertmacro MUI_PAGE_FINISH



!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES




Function .onInit
  ; TEst to see if Graderworks already exists
  IfFileExists "$INSTDIR\${EXE_FILE}" "" done
	
	
	MessageBox MB_OKCANCEL|MB_ICONEXCLAMATION \
  "${PRODUCT_NAME} is already installed. $\n$\nClick `OK` to remove the \
  previous version or `Cancel` to cancel this upgrade." \
  IDOK uninst
  Abort
		 
	;Run the uninstaller
	uninst:
	ClearErrors
	ExecWait  "$INSTDIR\Uninstall.exe" ; instead of the ExecWait line
  
	
	done:
 FunctionEnd 

;--------------------------------
;Languages

!insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Installer Sections

Section "Main Program" SEC01

	; ,NET version
	;!insertmacro CheckNetFramework 461

	SetOutPath "$INSTDIR"
	SetOverwrite on
	;ADD YOUR OWN FILES HERE...
	CreateDirectory "$INSTDIR"	
	
	FILE "..\TemperatureSensor\bin\Release\${EXE_FILE}"
	FILE "..\TemperatureSensor\bin\Release\Phidget22.NET.dll"	

	;create desktop shortcut
	CreateShortCut "$DESKTOP\${PRODUCT_NAME}.lnk" "$INSTDIR\${EXE_FILE}" ""
	
	;create start-menu items
	  CreateDirectory "$SMPROGRAMS\${PRODUCT_NAME}"	
	  CreateShortCut "$SMPROGRAMS\${PRODUCT_NAME}\${PRODUCT_NAME}.lnk" "$INSTDIR\${EXE_FILE}" "" "$INSTDIR\${EXE_FILE}" 0

	;Store installation folder
	WriteRegStr HKCU "Software\Logger" "" $INSTDIR
	
	; write to the registry to add to the add/remove program list
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Logger" \
                 "DisplayName" "${PRODUCT_NAME}"
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Logger" \
                 "UninstallString" "$\"$INSTDIR\Uninstall.exe$\""
				 
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Logger" \
                 "DisplayVersion" "${PRODUCT_VERSION}" 
				 
	;WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Logger" \
    ;             "DisplayIcon" "$\"$INSTDIR\PRODUCT_VERSION.exe$\""
				 
	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Logger" \
                 "Publisher" "${PRODUCT_PUBLISHER}"

	;Create uninstaller
	WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd

;Uninstaller Section
Section "Uninstall"

	;ADD YOUR OWN FILES HERE...
	;Delete Start Menu Shortcuts
	  Delete "$DESKTOP\${PRODUCT_NAME}.lnk"
	  Delete "$SMPROGRAMS\${PRODUCT_NAME}\*.*"
	  RmDir  "$SMPROGRAMS\${PRODUCT_NAME}"
	
	Delete "$INSTDIR\${EXE_FILE}" 
	Delete "$INSTDIR\Phidget22.NET.dll" 

	Delete "$INSTDIR\Uninstall.exe"
	RMDir "$INSTDIR"
	DeleteRegKey /ifempty HKCU "Software\Logger"
	
	; remove the registry key for add/remove programs list
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Logger"
	
                

SectionEnd